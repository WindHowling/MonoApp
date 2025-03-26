using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Pagging;
using WebApp.Services.Interface;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class VehicleMakesController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public VehicleMakesController(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService;
            _mapper = mapper;
        }

        // GET: VehicleMakes/Index
        public async Task<IActionResult> Index(string sortOrder, string searchString, int pageNumber = 1)
        {
            int pageSize = 5;

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["AbrvSortParm"] = sortOrder == "abrv" ? "abrv_desc" : "abrv";
            ViewData["CurrentFilter"] = searchString;

            var query = _vehicleService.GetMakeQuery();

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

            var pagedMakes = await PaginatedList<VehicleMake>.CreateAsync(query, pageNumber, pageSize);

            var viewModels = new PaginatedList<VehicleMakeViewModel>(
                pagedMakes.Select(m => _mapper.Map<VehicleMakeViewModel>(m)).ToList(),
                pagedMakes.TotalCount,
                pagedMakes.PageIndex,
                pageSize
            );

            
            var view = View(viewModels);
            return view;
        }

        // GET: VehicleMakes/Create
        public IActionResult Create()
        {
            return View(new VehicleMakeViewModel());
        }

        // POST: VehicleMakes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleMakeViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var make = _mapper.Map<VehicleMake>(viewModel);
            await _vehicleService.AddMakeAsync(make);

            return RedirectToAction(nameof(Index));
        }

        // GET: VehicleMakes/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var make = await _vehicleService.GetMakeByIdAsync(id);
            if (make == null)
                return NotFound();

            var viewModel = _mapper.Map<VehicleMakeViewModel>(make);
            return View(viewModel);
        }

        // POST: VehicleMakes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleMakeViewModel viewModel)
        {
            if (id != viewModel.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingMake = await _vehicleService.GetMakeByIdAsync(id);
            if (existingMake == null)
                return NotFound();

            _mapper.Map(viewModel, existingMake);
            await _vehicleService.UpdateMakeAsync(existingMake);

            return RedirectToAction(nameof(Index));
        }
        // GET: VehicleMakes/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var make = await _vehicleService.GetMakeByIdAsync(id);
            if (make == null)
                return NotFound();

            var viewModel = _mapper.Map<VehicleMakeViewModel>(make);
            return View(viewModel);
        }
        // POST: VehicleMakes/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var make = await _vehicleService.GetMakeByIdAsync(id);
            if (make == null)
                return NotFound();

            await _vehicleService.DeleteMakeAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}