using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Configuration;
using Ofek;

namespace Ofek
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {

        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "Default", // Route name
            //    "{controller}/{action}/{id}", // URL with parameters
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                                              new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }


        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();


            if (ConfigurationManager.AppSettings["RequireDBMigrate"] != "true")
                Database.SetInitializer(new DropCreateDatabaseAlways<DbContext>());
            else
                Database.SetInitializer(new MyDbMigrateToLatest());

            OfekDBContext objDB = new OfekDBContext();

            if (objDB.Products.ToList().Count == 0)
            {
                //creating products:
                List<string> lstProductIDs = new List<string>();
                foreach(string strFinanceInstitue  in new List<string>() { "פסגות","אלטשולר שחם", "הלמן אלדובי" })
                {
                    foreach (string strProductType in new List<string>() { "קרן השתלמות", "קופת גמל", "פוליסת חסכון" })
                    {
                        foreach (string strInvestType in new List<string>() { "מניות", "אג\"ח", "50% מניות" })
                        {
                            Product objProduct = new Product() { ProductID = Guid.NewGuid().ToString(), CreatedDate = DateTime.Now, FinanceInstitue = strFinanceInstitue, ProductType = strProductType, InvestType= strInvestType };
                            objDB.Products.Add(objProduct);

                            lstProductIDs.Add(objProduct.ProductID);
                        }
                    }
                }


                Customer objCustomer = null;
                CustomerProduct objCustomerProduct = null;

                objCustomer = new Customer() { CustomerID = Guid.NewGuid().ToString(), FirstName = "ישראל", LastName = "ישראלי", BirthDate = new DateTime(1986, 3, 1), City = "נתניה", Street = "האלון", HouseNumber = "44", PrivateEMail = "tsdfdsfest@gmail.com", CreatedDate = DateTime.Now };
                objDB.Customers.Add(objCustomer);

                objCustomerProduct = new CustomerProduct() { CustomerProductID= Guid.NewGuid().ToString(), ProductID = lstProductIDs[0], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 300000, AccountNumber="12345" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[5], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 155000, AccountNumber = "56543" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[7], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "מוקפא", Sum = 250499, AccountNumber = "433434" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomer = new Customer() { CustomerID = Guid.NewGuid().ToString(), FirstName = "ישראלה", LastName = "ישראלי", BirthDate = new DateTime(1988, 2, 6), City = "נתניה", Street = "האלון", HouseNumber = "44", PrivateEMail = "tesdfsdfst@gmail.com", CreatedDate = DateTime.Now };
                objDB.Customers.Add(objCustomer);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[3], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 230000, AccountNumber = "23232" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[6], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 60499, AccountNumber = "4545" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[9], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "מוקפא", Sum = 32456, AccountNumber = "787878" };
                objDB.CustomerProducts.Add(objCustomerProduct);




                objCustomer = new Customer() { CustomerID = Guid.NewGuid().ToString(), FirstName = "שמריהו", LastName = "כהן", BirthDate = new DateTime(1975, 7, 8), City = "חיפה", Street = "הגליל", HouseNumber = "15", PrivateEMail = "tesdfdsfst@gmail.com", CreatedDate = DateTime.Now };
                objDB.Customers.Add(objCustomer);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[1], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 265000, AccountNumber = "989898989" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[9], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 62399, AccountNumber = "343434" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[10], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "מוקפא", Sum = 37856, AccountNumber = "7347456" };
                objDB.CustomerProducts.Add(objCustomerProduct);



                objCustomer = new Customer() { CustomerID = Guid.NewGuid().ToString(), FirstName = "מיאו", LastName = "כהן", BirthDate = new DateTime(1977, 4, 10), City = "באר שבע", Street = "הפרח", HouseNumber = "28", PrivateEMail = "tesadfsdfst@gmail.com", CreatedDate = DateTime.Now };
                objDB.Customers.Add(objCustomer);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[7], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 450000, AccountNumber = "22222" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[8], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "פעיל", Sum = 46499, AccountNumber = "3333333" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objCustomerProduct = new CustomerProduct() { CustomerProductID = Guid.NewGuid().ToString(), ProductID = lstProductIDs[9], CustomerID = objCustomer.CustomerID, CreatedDate = DateTime.Now, Status = "מוקפא", Sum = 12456, AccountNumber = "6666666" };
                objDB.CustomerProducts.Add(objCustomerProduct);

                objDB.SaveChanges();
            }
            objDB.Dispose();
            //Database.SetInitializer<OfekDBContext>(null);
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

        }



    }


}

public sealed class Configuration : DbMigrationsConfiguration<OfekDBContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = true;
        AutomaticMigrationDataLossAllowed = false;
        
        
        //uncomment for big migration:
        //CommandTimeout = 900;
    }

    protected override void Seed(OfekDBContext context)
    {
        // Whatever
    }
}

class MyDbMigrateToLatest : MigrateDatabaseToLatestVersion<OfekDBContext, Configuration>
{
}
