using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spa.Configuration;
using Spa.Data;
using Spa.Models;

namespace Spa.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public SchedulesController(ApplicationDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
            
            return View(await _unitOfWork.ScheduleRepository.GetAllAsync());
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var schedule = await _unitOfWork.ScheduleRepository.GetbByIdAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,UserId,TimeId")] Schedule schedule)
        {
            _unitOfWork.ScheduleRepository.Add(schedule);
            _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", schedule.UserId);
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,UserId,TimeId")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", schedule.UserId);
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedule == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Schedule'  is null.");
            }
                    
            _unitOfWork.ScheduleRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
          return _unitOfWork.ScheduleRepository.GetbByIdAsync(id) != null;
        }
    }
}
