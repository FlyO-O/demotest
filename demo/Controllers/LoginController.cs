using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class LoginController : Controller
    {
        private UserMessageModel db = new UserMessageModel();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection fc)
        {
            var email = fc["Email"];
            var password = fc["PassWord"];
            if (email == null || password == null)
            {
                return View("Index");
            }
            else
            {
                var message = from u in db.UserMess
                              where u.Email == email && u.PassWord == password
                              select u;
                var usercount = message.Count();
                if (usercount == 1)
                {
                    return View("Edit", message.ToList());
                }
                return View("Index");
            }
        }
    }
}