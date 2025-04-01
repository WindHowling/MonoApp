﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Project.Service.Models;
using Project.MVC.ViewModels;
using Project.Service.Pagging;
using Project.Service.Services.Interface;
using Project.Service.Helper;

namespace Project.MVC.Controllers
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

            ViewData["Title"] = "Pregled marki vozila";
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["AbrvSortParm"] = sortOrder == "abrv" ? "abrv_desc" : "abrv";
            ViewData["CurrentFilter"] = searchString;

            var pagedMakes = await _vehicleService.GetFilteredMakesAsync(sortOrder, searchString, pageNumber, pageSize);

            var viewModels = new PaginatedList<VehicleMakeViewModel>(
                pagedMakes.Select(m => _mapper.Map<VehicleMakeViewModel>(m)).ToList(),
                pagedMakes.TotalCount,
                pagedMakes.PageIndex,
                pageSize
            );

            return View(viewModels);
        }

        // GET: VehicleMakes/Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Dodaj marku vozila";
            return View(new VehicleMakeViewModel());
        }

        // POST: VehicleMakes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleMakeViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var make = _mapper.Map<VehicleMake>(viewModel);
            var result = await _vehicleService.TryAddMakeAsync(make);

            if (!result.IsSuccess)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View(viewModel);
            }

            TempData["Success"] = "Marka vozila uspešno dodana.";
            return RedirectToAction(nameof(Index));
        }

        // GET: VehicleMakes/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var make = await _vehicleService.GetMakeByIdAsync(id);
            if (make == null)
                return NotFound();

            ViewData["Title"] = "Izmeni marku vozila";
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
                return View(viewModel);

            var make = _mapper.Map<VehicleMake>(viewModel);
            var result = await _vehicleService.TryUpdateMakeAsync(make);

            if (!result.IsSuccess)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View(viewModel);
            }

            TempData["Success"] = "Marka vozila uspešno izmenjena.";
            return RedirectToAction(nameof(Index));
        }

        // GET: VehicleMakes/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var make = await _vehicleService.GetMakeByIdAsync(id);
            if (make == null)
                return NotFound();

            ViewData["Title"] = "Obriši marku vozila";
            var viewModel = _mapper.Map<VehicleMakeViewModel>(make);
            return View(viewModel);
        }

        // POST: VehicleMakes/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _vehicleService.TryDeleteMakeAsync(id);

            if (!result.IsSuccess)
            {
                TempData["Error"] = result.Message;
                return RedirectToAction(nameof(Delete), new { id });
            }

            TempData["Success"] = "Marka vozila uspešno obrisana.";
            return RedirectToAction(nameof(Index));
        }
    }
}
