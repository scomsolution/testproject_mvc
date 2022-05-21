using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TEST_MVC_2.Models;

namespace TEST_MVC_2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region Enable Migrations Command

        //Go to Visual Studio "Tools -> NuGet Package Manager -> Package Manager Console". Then execute the following command. 
        //Enable-Migrations – (We need to enable the migration, only then can we do the EF Code First Migration ).
        //Add-Migration IntialDb(migration name) – (Add a migration name and run the command ).
        //Update-Database -Verbose — if it is successful then we can see this message (Running Seed method). Once Migration is done; then, we can see that the respective files are auto-generated under the “Migrations” folder.

        //1. Enable-Migrations
        //2. Enable-Migrations -EnableAutomaticMigrations
        //3. Enable-Migrations -EnableAutomaticMigrations -Force
        //4. Add-Migration IntialDb
        //5. Update-Database -Verbose
        //6. Update-Database -Force


        #endregion

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Database.SetInitializer<StudentContext> (new DropCreateDatabaseIfModelChanges<StudentContext>());
        }
    }
}
