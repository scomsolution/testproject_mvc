using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_MVC_2.Models;

namespace TEST_MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SubjectModel model = new SubjectModel();
            model.SubjectList.Add(new SelectListItem { Text = "Physics", Value = "1" });
            model.SubjectList.Add(new SelectListItem { Text = "Chemistry", Value = "2" });
            model.SubjectList.Add(new SelectListItem { Text = "Mathematics", Value = "3" });
            return View(model);
            //return View();
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

        [HttpPost]
        public ActionResult Products(SubjectModel subjectModel, FormCollection form, int? sortBy, int page = 1, int pageSize = 9)
        {
            sortBy = Convert.ToInt32(Request.Form["OrderBy"]);

            string strDDLValue = Request.Form["ddlVendor"].ToString();

            string strDDLValue1 = form["ddlVendor"].ToString();

            //string SelectedValue = subjectModel.SubjectList.;



            SubjectModel model = new SubjectModel();
            model.SubjectList.Add(new SelectListItem { Text = "Physics", Value = "1",  });
            model.SubjectList.Add(new SelectListItem { Text = "Chemistry", Value = "2" });
            model.SubjectList.Add(new SelectListItem { Text = "Mathematics", Value = "3" });
            return RedirectToAction("Index", model);

            
        }

        private void TESTME()
        {
            AccessModifiers student1 = new AccessModifiers();

            // accessing name field and printing it
            Console.WriteLine("Name: " + student1.name1);

            // accessing print method from Student
            student1.print1();
            Console.ReadLine();


            
        }
    }


}