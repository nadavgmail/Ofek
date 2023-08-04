using KellermanSoftware.CompareNetObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ofek.Models
{
    public class CustomersAndProducts
    {
        public string CustomerID { get; set; }
        public DateTime? CustCreatedDate { get; set; }
        public string  FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ProductID { get; set; }
        public string FinanceInstitue { get; set; }
        public string ProductType { get; set; }
        public string InvestType { get; set; }
        public DateTime ? ProdCreatedDate { get; set; }
        public string CustomerProductID { get; set; }
        public string AccountNumber { get; set; }
        public double ?sum { get; set; }
        public string status { get; set; }
        public DateTime ? productCrreationDate { get; set; }

    }


}