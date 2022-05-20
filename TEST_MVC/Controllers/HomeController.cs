using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_MVC.Models;

namespace TEST_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //SubjectModel model = new SubjectModel();
            //model.SubjectList.Add(new SelectListItem { Text = "Physics", Value = "1" });
            //model.SubjectList.Add(new SelectListItem { Text = "Chemistry", Value = "2" });
            //model.SubjectList.Add(new SelectListItem { Text = "Mathematics", Value = "3" });
            //return View(model);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}