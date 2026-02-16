using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        { 
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)  //en fonction du jour de la semaine, on redirige vers la page d'accueil
            {
                return Redirect("/");
            }

            return Content("Hello from the Comic Books controller!");

        }
    }
}