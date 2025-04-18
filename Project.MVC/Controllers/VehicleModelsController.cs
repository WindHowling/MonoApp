using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Project.Service.Models;
using Project.MVC.ViewModels;
using Project.Service.Pagging;
using Project.Service.Services.Interface;

namespace Project.MVC.Controllers
{
    public class VehicleModelsController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public VehicleModelsController(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int? makeId, string sortOrder, string searchString, int pageNumber = 1)
        {
            int pageSize = 5;

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["AbrvSortParm"] = sortOrder == "abrv" ? "abrv_desc" : "abrv";
            ViewData["CurrentFilter"] = searchString;
            ViewBag.MakeId = makeId;

            var pagedModels = await _vehicleService.GetFilteredModelsAsync(makeId, sortOrder, searchString, pageNumber, pageSize);

            var viewModels = new PaginatedList<VehicleModelViewModel>(
                pagedModels.Select(m => _mapper.Map<VehicleModelViewModel>(m)).ToList(),
                pagedModels.TotalCount,
                pagedModels.PageIndex,
                pageSize
            );

            return View(viewModels);
        }

        public async Task<IActionResult> Create(int makeId)
        {
            ViewBag.MakeId = makeId;
            ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
            return View(new VehicleModelViewModel { MakeId = makeId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleModelViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
                return View(viewModel);
            }

            var makeExists = await _vehicleService.GetMakeByIdAsync(viewModel.MakeId);
            if (makeExists == null)
            {
                ModelState.AddModelError("MakeId", "Odabrani proizvođač vozila ne postoji.");
                ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
                return View(viewModel);
            }

            var model = _mapper.Map<VehicleModel>(viewModel);
            var result = await _vehicleService.TryAddModelAsync(model);

            if (!result.IsSuccess)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
                return View(viewModel);
            }

            TempData["Success"] = "Model vozila uspješno dodat.";
            return RedirectToAction(nameof(Index), new { makeId = viewModel.MakeId });
        }

        public async Task<IActionResult> Edit(int id, int? makeId)
        {
            var model = await _vehicleService.GetModelByIdAsync(id);
            if (model == null)
            {
                TempData["Error"] = "Model nije pronađen.";
                return RedirectToAction(nameof(Index), new { makeId });
            }

            ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
            ViewBag.MakeId = makeId ?? model.MakeId;

            var viewModel = new VehicleModelViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Abrv = model.Abrv,
                MakeId = model.MakeId
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleModelViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                TempData["Error"] = "Neispravan ID modela.";
                return RedirectToAction(nameof(Index), new { makeId = viewModel.MakeId });
            }

            if (!ModelState.IsValid)
            {
                ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
                return View(viewModel);
            }

            var existingModel = await _vehicleService.GetModelByIdAsync(viewModel.Id);
            if (existingModel == null)
            {
                TempData["Error"] = "Model nije pronađen.";
                return RedirectToAction(nameof(Index), new { makeId = viewModel.MakeId });
            }

            existingModel.Name = viewModel.Name;
            existingModel.Abrv = viewModel.Abrv;
            existingModel.MakeId = viewModel.MakeId;

            var result = await _vehicleService.TryUpdateModelAsync(existingModel);

            if (!result.IsSuccess)
            {
                ModelState.AddModelError("", result.Message);
                ViewBag.VehicleMakes = (await _vehicleService.GetAllMakesAsync(1, 100)).ToList();
                return View(viewModel);
            }

            TempData["Success"] = "Model vozila uspješno izmenjen.";
            return RedirectToAction(nameof(Index), new { makeId = viewModel.MakeId });
        }



        public async Task<IActionResult> Delete(int id, int? makeId)
        {
            var model = await _vehicleService.GetModelByIdAsync(id);
            if (model == null)
            {
                TempData["Error"] = "Model nije pronađen.";
                return RedirectToAction(nameof(Index), new { makeId });
            }

            ViewBag.MakeId = makeId ?? model.MakeId;
            var viewModel = _mapper.Map<VehicleModelViewModel>(model);
            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _vehicleService.GetModelByIdAsync(id);
            if (model == null)
            {
                TempData["Error"] = "Model koji pokušavate obrisati ne postoji.";
                return RedirectToAction(nameof(Index));
            }

            var result = await _vehicleService.TryDeleteModelAsync(id);

            if (!result.IsSuccess)
            {
                TempData["Error"] = result.Message;
                return RedirectToAction(nameof(Index), new { makeId = model.MakeId });
            }

            TempData["Success"] = "Model vozila uspješno obrisan.";
            return RedirectToAction(nameof(Index), new { makeId = model.MakeId });
        }
    }
}
