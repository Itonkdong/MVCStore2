using MVCStore2.Models;
using MVCStore2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStore2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hellow from Store.index";
        }


        public ActionResult Details()
        {
            List<Album> albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album(i,$"Album{i}", $"Description{i}"));
            }

            Artist artist = new Artist(0, "Viktor");
            ArtistAlbumViewModel artistAlbumViewModel = new ArtistAlbumViewModel(artist, albums);

            return View(artistAlbumViewModel);
        }

        public string Browse()
        {
            return "Hellow from Store.Brows";
        }

        [Route("store/showinfo/{artistId:range(1,5)}/{albumId:regex(\\w*\\d{4})}")]
        public string ShowInfo(int? artistId, string albumId)
        {

            var value = new { a = 1, b = 3 };
            return $"Showing from artis {artistId}, album {albumId}";

        }

        public ActionResult Contact()
        {
            /*return this.View();*/

            return RedirectToAction("Index", "Home", new { param1 = 12, param2 = 13 });
        }

        public ActionResult ShowSearch()
        {
            return View();
        }

        public ActionResult Search(string q)
        {
            List<Album> albums = new List<Album>();

            albums.Add(new Album(1, "Experience", "Ds 1"));
            albums.Add(new Album(2, "Music for the Jillted Generation", "Ds 2"));
            albums.Add(new Album(3, "The Fat of the Land", "Ds 3"));
            albums.Add(new Album(4, "Always Outnumbered, Never Outgunned", "Ds 4"));
            albums.Add(new Album(5, "Invaders Must Die", "Ds 5"));
            albums.Add(new Album(6, "The day is my enemy", "Ds 6"));

            var resultAlbumbs = new List<Album>();
            foreach (var album in albums)
            {
                if(album.Name.Contains(q))
                {
                    resultAlbumbs.Add(album);
                }
            }
            return View(resultAlbumbs);
        }

        public ActionResult Helpers()
        {
            return View();
        }

        public ActionResult HelpersV()
        {
            return Content("");
        }

    }
}