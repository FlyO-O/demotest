using demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class EditController : Controller
    {
        private UserMessageModel db = new UserMessageModel();
                
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMes mes = db.UserMess.Find(id);            
            if (mes == null)
            {
                return HttpNotFound();
            }
            return View(mes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserName,Tel,Address,Age,Sex")] UserMes user)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(user).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(user);

            try
            {
                var m = db.UserMess.Single(s => s.ID == user.ID);
                m.UserName = user.UserName;
                m.Tel = user.Tel;
                m.Sex = user.Sex;
                m.Address = user.Address;
                m.Age = user.Age;
                db.SaveChanges();
                return View("Edit",user);
            }
            catch
            {
                return View(user);
            }
        }
    }
}