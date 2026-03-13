using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PublisherModelsController : Controller
    {
        private readonly BookDbContext _context;

        public PublisherModelsController(BookDbContext context)
        {
            _context = context;
        }

        // GET: PublisherModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Publishers.ToListAsync());
        }

        // GET: PublisherModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherModel = await _context.Publishers
                .FirstOrDefaultAsync(m => m.PublisherId == id);
            if (publisherModel == null)
            {
                return NotFound();
            }

            return View(publisherModel);
        }

        // GET: PublisherModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PublisherModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PublisherId,PublisherName,City")] PublisherModel publisherModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publisherModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publisherModel);
        }

        // GET: PublisherModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherModel = await _context.Publishers.FindAsync(id);
            if (publisherModel == null)
            {
                return NotFound();
            }
            return View(publisherModel);
        }

        // POST: PublisherModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PublisherId,PublisherName,City")] PublisherModel publisherModel)
        {
            if (id != publisherModel.PublisherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publisherModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublisherModelExists(publisherModel.PublisherId))
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
            return View(publisherModel);
        }

        // GET: PublisherModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherModel = await _context.Publishers
                .FirstOrDefaultAsync(m => m.PublisherId == id);
            if (publisherModel == null)
            {
                return NotFound();
            }

            return View(publisherModel);
        }

        // POST: PublisherModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherModel = await _context.Publishers.FindAsync(id);
            if (publisherModel != null)
            {
                _context.Publishers.Remove(publisherModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublisherModelExists(int id)
        {
            return _context.Publishers.Any(e => e.PublisherId == id);
        }
    }
}
