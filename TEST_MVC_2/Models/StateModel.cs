using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEST_MVC_2.Models
{
    public class StateModel
    {
        public int StateId { get; set; }
        public SelectList StateList { get; set; }
        public List<City> CityList { get; set; }
    }
    public class City
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
    }
}