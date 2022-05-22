using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TEST_MVC_2.Models;

namespace TEST_MVC_2.Controllers
{
    public class SelfTestController : Controller
    {
        // GET: SelfTest
        public ActionResult Index()
        {
            Student model1 = new Student();

            SubjectModel model = new SubjectModel();
            model.SubjectList.Add(new SelectListItem { Text = "Physics", Value = "1" });
            model.SubjectList.Add(new SelectListItem { Text = "Chemistry", Value = "2" });
            model.SubjectList.Add(new SelectListItem { Text = "Mathematics", Value = "3" });

            model1.SubjectList = model.SubjectList;
            return View(model1);
        }



        [HttpPost]
        public ActionResult IndexPost(Student model)
        {
            //if (!ModelState.IsValid) { return RedirectToAction("Index"); }

            var json = new JavaScriptSerializer().Serialize(model);

            return RedirectToAction("Index");
        }
    }
}