using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class GoodController : Controller
    {
        // GET: Good
        public ActionResult Index(string ID)
        {            
            ViewBag.ID = ID;
            return View();
        }

        public ActionResult ContentResult()
        {
            return Content("Hi, 我是ContentResult结果");
        }
       
    }
}