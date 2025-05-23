﻿
using System.Diagnostics;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;


namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
            return View(allActors);
        }
        // Actors/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(int id, [Bind("Id,FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
     

        //  Actors/Edit/1
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            if (actorsDetails == null) return View("Empty");
            return View(actorsDetails);
        }
        [HttpPost]
        public async Task<IActionResult>
            Edit(int id, [Bind("Id,FullName, ProfilePictureURL, Bio")] Actor newActor)
        {
            if (!ModelState.IsValid)
            {
                return View(newActor);
            }
            await _service.UpdateAsync(id, newActor);
            return RedirectToAction(nameof(Index));
        }
        // Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
        //  Actors/Delete/1
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            if (actorsDetails == null) return View("Empty");
            return View(actorsDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult>
            DeleteConfirm(int id)
        {

            var actorsDetails = await _service.GetByIdAsync(id);
            if (actorsDetails == null) return View("Empty");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
