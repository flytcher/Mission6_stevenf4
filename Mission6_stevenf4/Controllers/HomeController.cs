using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_stevenf4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_stevenf4.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext mContext { get; set; }

        public HomeController ( MovieContext someName)
        {
            mContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View("Podcast");
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            ViewBag.Categories = mContext.Categories.ToList();

            var categories = mContext.Categories.ToList();

            return View("M");
        }

        [HttpPost]
        public IActionResult MovieEntry(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                mContext.Add(ar);
                mContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = mContext.Categories.ToList();

                return View("M");
            }


        }

        public IActionResult MovieList()
        {
            var movies = mContext.Responses
                .Include(x => x.category)
                .ToList();

            return View(movies);
        }

        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = mContext.Categories.ToList();

            var entry = mContext.Responses.Single(x => x.MovieID == movieid);

            return View("M", entry);
        }

        [HttpPost]

        public IActionResult Edit (ApplicationResponse blah)
        {
            mContext.Update(blah);
            mContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var entry = mContext.Responses.Single(x => x.MovieID == movieid);

            return View(entry);
        }

        [HttpPost]

        public IActionResult Delete (ApplicationResponse ar)
        {
            mContext.Responses.Remove(ar);
            mContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
