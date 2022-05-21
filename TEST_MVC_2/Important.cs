using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TEST_MVC_2
{
    public class Important
    {
        SqlConnection conn = new SqlConnection();
        public string ConnectionString = "";

        public Important()
        {

        }


        public DataTable FillTable()
        {
            DataTable dtTemp = new DataTable();
            





            return dtTemp;
        }
    }
}