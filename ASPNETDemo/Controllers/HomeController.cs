using ASPNETDemo.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string xname)
        {
            if(xname ==null) xname="";
            Hello hello = new Hello(xname);
            return View(hello);


        }
    }
}