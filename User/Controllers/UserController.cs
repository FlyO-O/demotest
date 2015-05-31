using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using User.Models;

namespace User.Controllers
{
    public class UserController : Controller
    {
        private UserModels db = new UserModels();

        // GET: User
        public ActionResult Index()
        {
            ViewBag.Title="Index";
            return View();
        }

        //注册，只是显示注册界面
        public ActionResult Register()
        {
            return View();
        }

        //注册，保存注册人信息
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include="ID,UserName,PassWord,ConfirmPassWord")] UserMessage user)
        {
            var num=db.UserMessages.Where(s => s.UserName == user.UserName).Count();
            if (num == 0)
            {
                if (ModelState.IsValid)
                {                    
                    db.UserMessages.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(user);
        }

        //登陆，只显示用户登录界面
        public ActionResult Login()
        {
            return View();
        }

        //登陆
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection fc)
        {
            var username = fc["UserName"];
            var password = fc["PassWord"];
            if (username == null || password == null)
            {
                return View();
            }
            else
            {
                var usercount = (from u in db.UserMessages
                                 where u.UserName == username && u.PassWord == password
                                 select u).Count();
                if(usercount==1)
                {
                    return RedirectToAction("Edit");
                }
                return View();
            }
        }

        //后台登陆，只显示登陆界面
        public ActionResult Manager()
        {            
            return View();
        }

        //后台登陆，登陆成功跳到后台管理，失败不跳转
        [HttpPost]
        public ActionResult Manager(FormCollection fc)
        {
            var user=fc["UserName"];
            var password=fc["PassWord"];
            if(user.Equals("admin"))
            {
                var count = (from s in db.UserMessages
                             where s.PassWord == password && s.UserName=="admin"
                             select s).Count();
                if(count==1)
                {
                    var usermanage=db.UserMessages.Where(s=>s.UserName!="admin").ToList();
                    return View("UserManage", usermanage);
                }
            }
            return View();
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMessage user = db.UserMessages.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //编辑用户信息
        [HttpPost]
        public ActionResult Edit([Bind(Include="ID,Tel")] UserMessage user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}