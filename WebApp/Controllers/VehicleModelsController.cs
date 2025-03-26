using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Pagging;
using WebApp.Services.Interface;
using WebApp.ViewModels;

namespace WebApp.Controllers
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

        // GET: VehicleModels/Index
        public async Task<IActionResult> Index(int? makeId, string sortOrder, string searchString, int pageNumber = 1)
        {
            int pageSize = 5;

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["AbrvSortParm"] = sortOrder == "abrv" ? "abrv_desc" : "abrv";
            ViewData["CurrentFilter"] = searchString;

            var query = _vehicleService.GetModelQuery();

            if (makeId.HasValue)
            {
                query = query.Where(m => m.MakeId == makeId.Value);
                ViewBag.MakeId = makeId.Value;
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.Name.Contains(searchString) || m.Abrv.Contains(searchString));
            }

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(m => m.Name),
                "abrv" => query.OrderBy(m => m.Abrv),
                "abrv_desc" => query.OrderByDescending(m => m.Abrv),
                _ => query.OrderBy(m => m.Name)
            };

            var pagedModels = await PaginatedList<VehicleModel>.CreateAsync(query, pageNumber, pageSize);

            var viewModels = new PaginatedList<VehicleModelViewModel>(
                pagedModels.Select(m => _mapper.Map<VehicleModelViewModel>(m)).ToList(),
                pagedModels.TotalCount,
                pagedModels.PageIndex,
                pageSize
            );

            return View(viewModels);
        }

        // GET: VehicleModels/Create
        public async Task<IActionResult> Create(int makeId)
        {
            ViewBag.MakeId = makeId;
            ViewBag.VehicleMakes = await _vehicleService.GetAllMakesAsync();
            return View(new VehicleModelViewModel { MakeId = makeId });
        }

        // POST: VehicleModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleModelViewModel viewModel)
        {
            //Validate that the selected MakeId exists
            var makeExists = await _vehicleService.GetMakeByIdAsync(viewModel.MakeId);
            if (makeExists == null)
            {
                ModelState.AddModelError("MakeId", "The selected vehicle make does not exist.");
            }

            if (ModelState.IsValid)
            {
                var model = _mapper.Map<VehicleModel>(viewModel);
                await _vehicleService.AddModelAsync(model);
                return RedirectToAction("Index", new { makeId = model.MakeId });
            }

            ViewBag.VehicleMakes = await _vehicleService.GetAllMakesAsync();
            ViewBag.MakeId = viewModel.MakeId;
            return View(viewModel);
        }

        // GET: VehicleModels/Edit
        public async Task<IActionResult> Edit(int id, int? makeId)
        {
            var model = await _vehicleService.GetModelByIdAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            ViewBag.VehicleMakes = await _vehicleService.GetAllMakesAsync();
            ViewBag.MakeId = makeId ?? model.MakeId;

            var viewModel = _mapper.Map<VehicleModelViewModel>(model);
            return View(viewModel);
        }

        // POST: VehicleModels/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleModelViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ViewBag.VehicleMakes = await _vehicleService.GetAllMakesAsync();
                ViewBag.MakeId = viewModel.MakeId;
                return View(viewModel);
            }

            var existingModel = await _vehicleService.GetModelByIdAsync(id);
            if (existingModel == null)
            {
                return NotFound();
            }

            _mapper.Map(viewModel, existingModel);
            await _vehicleService.UpdateModelAsync(existingModel);

            return RedirectToAction("Index", new { makeId = existingModel.MakeId });
        }

        // GET: VehicleModels/Delete
        public async Task<IActionResult> Delete(int id, int? makeId)
        {
            var model = await _vehicleService.GetModelByIdAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            ViewBag.MakeId = makeId ?? model.MakeId;
            var viewModel = _mapper.Map<VehicleModelViewModel>(model);
            return View(viewModel);
        }

        // POST: VehicleModels/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _vehicleService.GetModelByIdAsync(id);
            if (model != null)
            {
                int makeId = model.MakeId;
                await _vehicleService.DeleteModelAsync(id);
                return RedirectToAction("Index", new { makeId });
            }

            return RedirectToAction("Index");
        }
    }
}
