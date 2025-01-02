using Question1_DB_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Question1_DB_First.Controllers
{
    public class CodeController : Controller
    {
        private northwindEntities db = new northwindEntities();

        public  ActionResult costumersInGermany()
        {
            var cust1 = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(cust1);
        }

        public ActionResult CustomerDetails(int orderId)
        {
            var cust2 = db.Orders.Where(o => o.OrderID == orderId).Select(o => o.Customer).FirstOrDefault();
            return View(cust2);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}