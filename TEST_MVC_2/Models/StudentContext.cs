﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TEST_MVC_2.Models
{
    public class StudentContext : DbContext
    {
        //public StudentContext() : base("CodeFirstDemoDB") { }

        public DbSet<Student> Students { get; set; }
    }
}