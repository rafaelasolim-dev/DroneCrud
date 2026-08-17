using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DroneCrud.Models;

namespace DroneCrud.Controllers
{
    public class DroneController : Controller
    {
        private readonly DroneContext _context;

        public DroneController(DroneContext context)
        {
            _context = context;
        }

        // GET: Drone
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drones.ToListAsync());
        }

        // GET: Drone/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drone = await _context.Drones
                .FirstOrDefaultAsync(m => m.IdDrone == id);
            if (drone == null)
            {
                return NotFound();
            }

            return View(drone);
        }

        // GET: Drone/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drone/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDrone,Modelo,Preco,Helice,DataCadastro")] Drone drone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drone);
        }

        // GET: Drone/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drone = await _context.Drones.FindAsync(id);
            if (drone == null)
            {
                return NotFound();
            }
            return View(drone);
        }

        // POST: Drone/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDrone,Modelo,Preco,Helice,DataCadastro")] Drone drone)
        {
            if (id != drone.IdDrone)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DroneExists(drone.IdDrone))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(drone);
        }

        // GET: Drone/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drone = await _context.Drones
                .FirstOrDefaultAsync(m => m.IdDrone == id);
            if (drone == null)
            {
                return NotFound();
            }

            return View(drone);
        }

        // POST: Drone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drone = await _context.Drones.FindAsync(id);
            if (drone != null)
            {
                _context.Drones.Remove(drone);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DroneExists(int id)
        {
            return _context.Drones.Any(e => e.IdDrone == id);
        }
    }
}
