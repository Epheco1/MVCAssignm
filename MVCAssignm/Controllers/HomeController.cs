using MVCAssignm.Models.DB_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Register(Customers newCustomer)
        {

            try
            {
                var db = new BankDb();
                var cust = new Customer();
                cust.FirstName = newCustomer.FirstName;
                cust.LastName = newCustomer.LastName;
                cust.DOB = newCustomer.DOB;
                db.Customers.Add(cust);
                db.SaveChanges();
                ViewBag.ErrorMessage = "";
                return RedirectToAction("SuccessfulReg");
            }
            catch (Exception Ex)
            {

                ViewBag.ErrorMessage = "Än error occured during registration";
                return View();
             
            }
        }

        public ActionResult SuccessfulReg()
        {
            return View();
        }
    }
}