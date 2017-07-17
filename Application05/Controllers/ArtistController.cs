using Application05.Models;
using Application05.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application05.Controllers
{
    public class ArtistController : Controller
    {
        ArtistRepository repository = new ArtistRepository();
        // GET: Artist
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }


        public ActionResult Details(int id)
        {
            Artist artist = repository.Get(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(artist);
            }            
        }
    }
}