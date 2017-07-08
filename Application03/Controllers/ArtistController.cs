using Application03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application03.Controllers
{
    public class ArtistController : Controller
    {
        MusicStoreDataContext context = new MusicStoreDataContext();

        // GET: Artist
        public ActionResult Index()
        {
            return View(context.Artist.ToList());
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid) return View(artist);

            context.Artist.Add(artist);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}