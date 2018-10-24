using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class LevelsController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Level() { Name = "Shrek" };

            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


        public ActionResult LevelsByCreateDate(int year, int month)
        {
            return Content(" / " + month + " / " + year);
        }

        //When you navigate to "Movies"
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
    }
}