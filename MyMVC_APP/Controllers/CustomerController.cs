using MyMVC_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC_APP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCusomer(NewCustomerViewModel Customer)
        {
            MyContext _Context = new MyContext();
            _Context.Customers.Add(Customer.Customer);
            _Context.SaveChanges();
            return RedirectToAction("NewCustomer", "Customer");
        }
        public ActionResult NewCustomer()
        {
            MyContext _Context = new MyContext();
            var Memberships=_Context.MemberShipTypes.ToList();
             NewCustomerViewModel xxx = new NewCustomerViewModel();
            xxx.membershiptype = Memberships;
            return View(xxx);
        }
    }
}