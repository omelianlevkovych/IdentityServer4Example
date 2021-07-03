﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Client.ApiServices;
using Movies.Client.Models;

namespace Movies.Client.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieApiService movieApiService;

        public MoviesController(IMovieApiService movieApiService)
        {
            this.movieApiService = movieApiService;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await movieApiService.GetMovies());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            return View();

            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var movie = await _context.Movie
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (movie == null)
            //{
            //    return NotFound();
            //}

            //return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Genre,ReleaseDate,Rating,ImageUrl,Owner")] Movie movie)
        {
            return View();
            //if (ModelState.IsValid)
            //{
            //    _context.Add(movie);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var movie = await _context.Movie.FindAsync(id);
            //if (movie == null)
            //{
            //    return NotFound();
            //}
            //return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Title,Genre,ReleaseDate,Rating,ImageUrl,Owner")] Movie movie)
        {
            return View();

            //if (id != movie.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(movie);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!MovieExists(movie.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            return View();

            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var movie = await _context.Movie
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (movie == null)
            //{
            //    return NotFound();
            //}

            //return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            return View();

            //var movie = await _context.Movie.FindAsync(id);
            //_context.Movie.Remove(movie);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(long id)
        {
            return true;
        }
    }
}
