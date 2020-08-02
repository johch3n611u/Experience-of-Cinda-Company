using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using SimpleAccountSystem.Models;
using SimpleAccountSystem.Models.DTO;

namespace SimpleAccountSystem.Controllers
{
    public class tblUsersController : Controller
    {
        private Account db = new Account();

        // POST: tblUsers/Search
        [HttpPost, ActionName("Search")]
        public ActionResult Index(string searchString)
        {
            if (searchString != "")
            {

                var UserDetailsView = (from t1 in db.tblUser.AsNoTracking()
                                       join t2 in db.tblUserGroup.AsNoTracking() on t1.cAccount equals t2.cAccount
                                       join t3 in db.tblGroup.AsNoTracking() on t2.cGroupID equals t3.cGroupID
                                       where t1.cName.Contains(searchString) || t3.cGroupName.Contains(searchString)
                                       select new { t1, t2, t3 }
                                ).ToList();

                // Using DTO
                List<UserDetails> UserDetailsList = new List<UserDetails>();

                foreach (var User in db.tblUser)
                {
                    UserDetails UserDetail = new UserDetails();
                    UserDetail.cAccount = User.cAccount;
                    UserDetail.cName = User.cName;
                    UserDetail.cEmail = User.cEmail;
                    UserDetail.cStatus = User.cStatus;

                    // Group GroupNames
                    var ViewList = UserDetailsView.Where(x => x.t1.cAccount == User.cAccount).ToList();
                    if (ViewList.Any())
                    {
                        for (var i = 0; i < ViewList.Count; i++)
                        {
                            UserDetail.cGroupNames += ViewList[i].t3.cGroupName;
                            {
                                UserDetail.cGroupNames += "、";
                            }
                        }

                        UserDetailsList.Add(UserDetail);
                    }
                };


                return View("Index", UserDetailsList);

            }
            else {

                return RedirectToAction("Index");
            }
        }

        // GET: tblUsers
        public ActionResult Index()
        {
            // LINQ
            var UserDetailsView = (
                from t1 in db.tblUser.AsNoTracking()
                join t2 in db.tblUserGroup.AsNoTracking() on t1.cAccount equals t2.cAccount
                join t3 in db.tblGroup.AsNoTracking() on t2.cGroupID equals t3.cGroupID
                select new { t1, t2, t3 }).AsQueryable();
            // Using DTO
            List<UserDetails> UserDetailsList = new List<UserDetails>();

            foreach (var User in db.tblUser)
            {
                UserDetails UserDetail = new UserDetails();
                UserDetail.cAccount = User.cAccount;
                UserDetail.cName = User.cName;
                UserDetail.cEmail = User.cEmail;
                UserDetail.cStatus = User.cStatus;

                // Group GroupNames
                var ViewList = UserDetailsView.Where(x => x.t1.cAccount == User.cAccount).ToList();
                for (var i = 0; i < ViewList.Count; i++)
                {
                    UserDetail.cGroupNames += ViewList[i].t3.cGroupName;
                    if (i != ViewList.Count-1)
                    {
                        UserDetail.cGroupNames += "、";
                    }
                }

                UserDetailsList.Add(UserDetail);
            };

            return View(UserDetailsList);
        }

        // GET: tblUsers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUser tblUser = db.tblUser.Find(id);
            if (tblUser == null)
            {
                return HttpNotFound();
            }
            return View(tblUser);
        }

        // GET: tblUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblUsers/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cAccount,cName,cEmail,cCreateDT,cStatus")] tblUser tblUser)
        {
            if (ModelState.IsValid)
            {
                db.tblUser.Add(tblUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblUser);
        }

        // GET: tblUsers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUser tblUser = db.tblUser.Find(id);
            if (tblUser == null)
            {
                return HttpNotFound();
            }
            return View(tblUser);
        }

        // POST: tblUsers/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cAccount,cName,cEmail,cCreateDT,cStatus")] tblUser tblUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblUser);
        }

        // GET: tblUsers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUser tblUser = db.tblUser.Find(id);
            if (tblUser == null)
            {
                return HttpNotFound();
            }
            return View(tblUser);
        }

        // POST: tblUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tblUser tblUser = db.tblUser.Find(id);
            db.tblUser.Remove(tblUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
