using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class DelController : Controller
    {
        private UserMessageModel db = new UserMessageModel();
        // GET: Del
        public ActionResult Index()
        {
            var mes = (from m in db.UserMess
                       select m).ToList();
            return View(mes);
        }

        // GET: Movies/Delete/5
        public ActionResult Del(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMes user = db.UserMess.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Del")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserMes user = db.UserMess.Find(id);
            db.UserMess.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }    
}