using DocumentFormat.OpenXml.Bibliography;
using Ofek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ofek
{
    public static class Helpers
    {
        public static List<SelectListItem> GetCustomers()
        {
            OfekDBContext objDB = new OfekDBContext();
            return objDB.Customers.Select(c => new SelectListItem() { Text = c.FirstName + " " + c.LastName, Value = c.CustomerID }).ToList();
        }

        public static List<SelectListItem> Getproducts() {
            OfekDBContext objDB = new OfekDBContext();
            return objDB.Products.Select(p => new SelectListItem()  { Text = p.FinanceInstitue + " " + p.ProductType, Value = p.ProductID }).ToList();

        }

        public static string GetDateString(DateTime ? date)
        {
            return date == null ? "" : ((DateTime)(date)).ToString("dd/MM/yyyy");
        }

        public static List<CustomersAndProducts> GetCustomersAndProducts()
        {
            OfekDBContext objDB = new OfekDBContext();
            return (from c in objDB.Customers
                    join cp in objDB.CustomerProducts on c.CustomerID equals cp.CustomerID
                    join p in objDB.Products on cp.ProductID equals p.ProductID
                    select new CustomersAndProducts()
                    {
                        CustomerID = c.CustomerID,
                        CustCreatedDate = c.CreatedDate,
                        FullName = c.LastName + " " + c.FirstName,
                        Address = c.City + " " + c.Street + " " + c.HouseNumber,
                        Email = c.PrivateEMail,
                        BirthDate = c.BirthDate,
                        ProductID = cp.ProductID,
                        FinanceInstitue = p.FinanceInstitue,
                        ProductType = p.ProductType,
                        InvestType = p.InvestType,
                        ProdCreatedDate = p.CreatedDate,
                        CustomerProductID = cp.CustomerProductID,
                        AccountNumber = cp.AccountNumber,
                        sum = cp.Sum,
                        status = cp.Status,
                        productCrreationDate = cp.CreatedDate
                    }).ToList();
              
        }
    }
}