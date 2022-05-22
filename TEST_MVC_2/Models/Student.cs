using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEST_MVC_2.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [MaxLength(4, ErrorMessage = "The property {0} doesn't have more than {1} elements")]
        public string Name { get; set; }
        public string Address { get; set; }

        [Required()]
        public int Mobile { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<SelectListItem> SubjectList { get; set; }
    }
}