using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly MeetingContext _context;

        public MeetingsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            var meetingContext = _context.Meetings.Include(m => m.ClosingPrayer).Include(m => m.Leader).Include(m => m.OpeningPrayer);
            return View(await meetingContext.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.ClosingPrayer)
                .Include(m => m.Leader)
                .Include(m => m.OpeningPrayer)
                .FirstOrDefaultAsync(m => m.MeetingID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            ViewData["ClosingPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "FullName");
            ViewData["LeaderId"] = new SelectList(_context.Peoples, "PeopleID", "FullName");
            ViewData["OpeningPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "FullName");
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,LeaderId,OpeningSong,SacramentHymn,ClosingSong,Intermediate,OpeningPrayerID,ClosingPrayerID")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClosingPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.ClosingPrayerID);
            ViewData["LeaderId"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.LeaderId);
            ViewData["OpeningPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.OpeningPrayerID);
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            ViewData["ClosingPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.ClosingPrayerID);
            ViewData["LeaderId"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.LeaderId);
            ViewData["OpeningPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.OpeningPrayerID);
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeetingID,Date,LeaderId,OpeningSong,SacramentHymn,ClosingSong,Intermediate,OpeningPrayerID,ClosingPrayerID")] Meeting meeting)
        {
            if (id != meeting.MeetingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.MeetingID))
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
            ViewData["ClosingPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.ClosingPrayerID);
            ViewData["LeaderId"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.LeaderId);
            ViewData["OpeningPrayerID"] = new SelectList(_context.Peoples, "PeopleID", "PeopleID", meeting.OpeningPrayerID);
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.ClosingPrayer)
                .Include(m => m.Leader)
                .Include(m => m.OpeningPrayer)
                .FirstOrDefaultAsync(m => m.MeetingID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.MeetingID == id);
        }
    }
}
