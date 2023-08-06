using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ofek;

namespace Ofek.Controllers
{
    public class CustomerProductsController : Controller
    {
        private OfekDBContext db = new OfekDBContext();

        // GET: CustomerProducts
        public ActionResult Index()
        {
            return View(db.CustomerProducts.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerProductID,CustomerID,AccountNumber,ProductID,Sum,Status,CreatedDate")] CustomerProduct customerProduct)
        {
            if (ModelState.IsValid)
            {
                customerProduct.CustomerProductID = (Guid.NewGuid().ToString());
                db.CustomerProducts.Add(customerProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerProduct);
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
