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


        public ActionResult getPruducts(string id) {
            List<CustomersAndProducts> joinedItems = Helpers.GetCustomersAndProducts().Where(cp => cp.CustomerID == id).ToList();
            return View(joinedItems);

        }
        public ActionResult Test()
        {
            OfekDBContext objDB = new OfekDBContext();
            try
            {
                return View(objDB.Customers.ToList());

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
