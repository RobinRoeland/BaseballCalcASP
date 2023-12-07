using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaseballCalcASP.Data;
using BaseballCalcASP.Models;
using BaseballCalcASP.Migrations;

namespace BaseballCalcASP.Controllers
{
    public class PlayersController : Controller
    {
        private readonly BaseballCalcASPContext _context;

        public PlayersController(BaseballCalcASPContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            List<Player> players = await _context.Players.ToListAsync();

            foreach (Player player in players)
            {
                player.Team = _context.Teams.Find(player.TeamId);
            }

              return players != null ? 
                          View(players) :
                          Problem("Entity set 'BaseballCalcASPContext.Player' is null.");
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            player.Team = _context.Teams.Find(player.TeamId);

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create(int? id)
        {
            if(id != null)
                ViewBag.Team = _context.Teams.Find(id);

            ViewBag.Teams = _context.Teams;

            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,DOB,TeamId")] Player player)
        {
            player.Team = _context.Teams.Find(player.TeamId);

            if (ModelState.IsValid)
            {
                _context.Players.Add(player);
                _context.SaveChanges();
                
                foreach (Team team in _context.Teams)
                {
                    team.TotalPlayers = _context.Players.Where(p => p.TeamId == team.Id).Count();
                    _context.Update(team);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            ViewBag.Teams = _context.Teams;

            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DOB,TeamId")] Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    player.Team = _context.Teams.Find(player.TeamId);
                    _context.Update(player);

                    foreach (Team team in _context.Teams)
                    {
                        team.TotalPlayers = _context.Players.Where(p => p.Team.Id == team.Id).Count();
                        _context.Update(team);
                    }

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.Id))
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

            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Players == null)
            {
                return Problem("Entity set 'BaseballCalcASPContext.Player'  is null.");
            }
            var player = await _context.Players.FindAsync(id);
            if (player != null)
            {
                _context.Remove(player);
            }

            foreach (Team team in _context.Teams)
            {
                team.TotalPlayers = _context.Players.Where(p => p.Team.Id == team.Id).Count();
                _context.Update(team);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
          return (_context.Players?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
