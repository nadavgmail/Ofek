using DocumentFormat.OpenXml.Office2010.Excel;
using Ofek.Models;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ofek
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


       
        public ActionResult getUsers(string id)
        {
            List<CustomersAndProducts> joinedItems = Helpers.GetCustomersAndProducts().Where(cp => cp.ProductID == id).ToList();
            return View(joinedItems);
        }

        public ActionResult getPruducts(string id) {
            List<CustomersAndProducts> joinedItems = Helpers.GetCustomersAndProducts().Where(cp => cp.CustomerID == id).ToList();
            return View(joinedItems);

        }
        
        
        public ActionResult Test()
        {
            var checked1 = Helpers.GetCustomersAndProducts();
            OfekDBContext objDB = new OfekDBContext();
            try
            {
                //objDB = new OfekDBContext();
                string strTest = $"{objDB.Customers.ToList().Count} Customers,  {objDB.Products.ToList().Count} Products";
                //return Content(strTest);
                List<CustomersAndProducts> joinedItems  = Helpers.GetCustomersAndProducts();
                List<string> prodId = joinedItems.Select(p=>p.ProductID).ToList();
                var list = objDB.Products.ToList().Where(o => !prodId.Contains(o.ProductID));


                return View(joinedItems);

            }
            catch(Exception ex)
            {
                throw new Exception("Error on Text", ex);
            }
            finally
            {
                objDB.Dispose();
            }
            
           
        }

    }
}
