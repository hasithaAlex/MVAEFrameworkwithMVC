using Application04.Models;
using Application04.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application04.Controllers
{
    public class ArtistController : Controller
    {
        ArtistRepository repository = new ArtistRepository();
        // GET: Artist
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid) return View(artist);

            repository.Add(artist);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}