using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_MVC_2.Models;

namespace TEST_MVC_2.Controllers
{
    public class DropDownController : Controller
    {
        public ActionResult Index()
        {
            StateModel objStateModel = new StateModel();
            objStateModel.StateList = State();
            List<City> objcity = new List<City>();
            objcity = GetCityList(0);
            objStateModel.CityList = objcity;
            return View(objStateModel);
        }
        [HttpPost]
        public ActionResult Index(int StateId)
        {
            //ss
            StateModel objStateModel = new StateModel();
            objStateModel.StateList = State();
            List<City> objcity = new List<City>();
            objcity = GetCityList(StateId);
            objStateModel.CityList = objcity;
            return View(objStateModel);
        }
        public SelectList State()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "State 1", Value = "1", Selected = true });
            items.Add(new SelectListItem() { Text = "State 2", Value = "2", Selected = false });

            SelectList objstatelist = new SelectList(items, "Value", "Text", 0);
            return objstatelist;
        }
        public List<City> GetCityList(int stateID)
        {
            List<City> objCity = new List<City>();
            objCity.Add(new City { CityId = 1, StateId = 1, CityName = "City 1" });
            objCity.Add(new City { CityId = 2, StateId = 2, CityName = "City 2" });
            objCity.Add(new City { CityId = 3, StateId = 1, CityName = "City 3" });
            return objCity.Where(m => m.StateId == stateID).ToList();
        }
    }
}