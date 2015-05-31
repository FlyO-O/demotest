using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class RegisterController : Controller
    {
        private UserMessageModel db = new UserMessageModel();

        // GET: Register
        public ActionResult Index()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include="ID,Email,PassWord,UserName,Tel,Address,Age,Sex")] UserMes user)
        {
            var num = db.UserMess.Where(s => s.Email == user.Email).Count();
            if (num == 0)
            {
                if (ModelState.IsValid)
                {                    
                    db.UserMess.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index","Login");
                }
            }

            return View();            
        }
    }
}