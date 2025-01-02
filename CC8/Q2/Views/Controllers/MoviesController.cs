using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Question2.Models;


namespace Question2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MoviesDBContext())
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            using (var db = new MoviesDBContext())
            {
                var movie = db.Movies.Find(id);
                if (movie == null)
                {
                    return HttpNotFound();
                }
                return View(movie);
            }
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MoviesDBContext())
                {
                    db.Entry(movie).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(movie);
        }

        
        }

       


    }