using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Delete(int id)
        {
            return View();
        }
            // GET: Movies
            public async Task<IActionResult> Index()
            {
                var listMovies = new List<Movie>
                {
                    new Movie
                    {
                        Genre = "Terror",
                        Id = 1,
                        Price = 1,
                        ReleaseDate = DateTime.Now,
                        Title = "La noche del terror"
                    },
                    new Movie
                    {
                        Genre = "Terror",
                        Id = 2,
                        Price = 1,
                        ReleaseDate = DateTime.Now,
                        Title = "La noche del terror II"
                    }
                };

                return View(listMovies);
            }

            // GET: Movies/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var movie = new Movie
                {
                    Genre = "Terror",
                    Id = 1,
                    Price = 1,
                    ReleaseDate = DateTime.Now,
                    Title = "La noche del terror"
                };

                return View(movie);
            }
            public IActionResult NuevaVista()
            {
                return View();
            }
    }
}