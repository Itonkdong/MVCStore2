using MVCStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStore2.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre

        static List<Genre> genreList = new List<Genre> { new Genre(1, "Rock", "Ds1"), new Genre(2, "Jazz", "Ds 2") };
        public ActionResult Index()
        {
            return View(genreList);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateNewGenre(Genre genre)
        {
            genre.Description = "No Description";
            genreList.Add(genre);
            return RedirectToAction("Index", "Genre");
        }

        public ActionResult Delete(int id)
        {
            foreach (var genre in genreList.ToList())
            {
                if(genre.GenreId == id)
                {
                    genreList.Remove(genre);
                }
            }
            return RedirectToAction("Index", "Genre");
        }
    }
}