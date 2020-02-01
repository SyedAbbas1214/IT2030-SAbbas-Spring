using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.Message = " Product/Index is displayed ";
            return View();
        }
        public string Browse()
        {
            return " Browse displayed ";
        }
        public string Details(int id)
        {
            string message = " Details displayed for Id = " + id;
            return message;
        }
    }
}