using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = new ComicBookRepository();

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id) // this is the change more xxnge
            // hey I have added some more changes
            // these are final changes by the gaurab branch
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(_comicBookRepository.GetComicBook(id.Value));
        }
    }
}