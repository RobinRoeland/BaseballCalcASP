﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BaseballCalcASP.Data;
using BaseballCalcASP.Models;

namespace BaseballCalcASP.Controllers
{
    public class SeasonsController : Controller
    {
        private readonly BaseballCalcASPContext _context;

        public SeasonsController(BaseballCalcASPContext context)
        {
            _context = context;
        }

        // GET: Seasons
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.players = _context.Players;
            ViewBag.playerid = id;

            if (id != null)
            {
                List<Season>? seasons = _context.Seasons.Where(season => season.PlayerKey == id).ToList();
                return seasons != null ? 
                    View(seasons) : 
                    Problem("Player or seasons not found.");
            }
            else
                return _context.Seasons != null ?
                    View(await _context.Seasons.ToListAsync()) :
                    Problem("Entity set 'BaseballCalcASPContext.Season'  is null.");

        }

        // GET: Seasons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Seasons == null)
            {
                return NotFound();
            }

            var season = await _context.Seasons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (season == null)
            {
                return NotFound();
            }

            return View(season);
        }

        public async Task<IActionResult> Leaderboard()
        {
            ViewBag.players = _context.Players;

            List<Season>? seasons = _context.Seasons.Where(season => season.Year == DateTime.Now.Year).ToList();
            return seasons != null ?
                View(seasons) :
                Problem("Player or seasons not found.");
        }

        // GET: Seasons/Create
        public IActionResult Create(int? id)
        {
            ViewBag.Player = _context.Players.Find(id);
            
            return View();
        }

        // POST: Seasons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlayerKey,GamesPlayed,Year,PlateAppearences,HStrikeOuts,Hits,Singles,Doubles,Triples,HomeRuns,BaseOnBalls,HitByPitch,SacrificeFlies,SacrificeHits,CaughtStealing,StolenBases,Runs,Errors,DoublePlays,TriplePlays,PassedBalls,PStrikeOuts")] Season season)
        {
            if (ModelState.IsValid)
            {
                _context.Add(season);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(season);
        }

        // GET: Seasons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Seasons == null)
            {
                return NotFound();
            }

            var season = await _context.Seasons.FindAsync(id);
            if (season == null)
            {
                return NotFound();
            }
            return View(season);
        }

        // POST: Seasons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlayerKey,GamesPlayed,Year,PlateAppearences,HStrikeOuts,Hits,Singles,Doubles,Triples,HomeRuns,BaseOnBalls,HitByPitch,SacrificeFlies,SacrificeHits,CaughtStealing,StolenBases,Runs,Errors,DoublePlays,TriplePlays,PassedBalls,PStrikeOuts")] Season season)
        {
            if (id != season.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(season);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeasonExists(season.Id))
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
            return View(season);
        }

        // GET: Seasons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Seasons == null)
            {
                return NotFound();
            }

            var season = await _context.Seasons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (season == null)
            {
                return NotFound();
            }

            return View(season);
        }

        // POST: Seasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Seasons == null)
            {
                return Problem("Entity set 'BaseballCalcASPContext.Season'  is null.");
            }
            var season = await _context.Seasons.FindAsync(id);
            if (season != null)
            {
                _context.Seasons.Remove(season);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeasonExists(int id)
        {
          return (_context.Seasons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
