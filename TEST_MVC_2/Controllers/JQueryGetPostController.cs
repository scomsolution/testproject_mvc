using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEST_MVC_2.Controllers
{
    public class JQueryGetPostController : Controller
    {
        // GET: JQueryGetPost
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult DetailReturn(Detail d)
        {

            d.ID = "1"; d.Name = "SUJEET"; d.City = "HAJIPUR"; d.State = "BIHAR";

            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DetailReturn2(FormCollection d1)
        {

            Detail d = new Detail();

            string ID = d1["ID"];
            d.ID = "1"; d.Name = "SUJEET"; d.City = "HAJIPUR"; d.State = "BIHAR";

            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DetailReturn1(Detail d)
        {

            d.ID = "1"; d.Name = "SUJEET"; d.City = "HAJIPUR"; d.State = "BIHAR";

            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult DetailReturn()
        {
            Detail d = new Detail();
            List<Detail> list = new List<Detail>();

            d.ID = "1"; d.Name = "SUJEET"; d.City = "HAJIPUR"; d.State = "BIHAR";

            return Json(d, JsonRequestBehavior.AllowGet);
        }


    }

    public class Detail
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}