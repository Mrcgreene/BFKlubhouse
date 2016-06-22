using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BFKH.Models;

namespace BFKH.Controllers
{
    public class OrderMenusManagerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrderMenusManager
        public ActionResult Index()
        {
            return View(db.OrderMenus.ToList());
        }

        // GET: OrderMenusManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderMenu orderMenu = db.OrderMenus.Find(id);
            if (orderMenu == null)
            {
                return HttpNotFound();
            }
            return View(orderMenu);
        }

        // GET: OrderMenusManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderMenusManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Dish,Description,Price")] OrderMenu orderMenu)
        {
            if (ModelState.IsValid)
            {
                db.OrderMenus.Add(orderMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderMenu);
        }

        // GET: OrderMenusManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderMenu orderMenu = db.OrderMenus.Find(id);
            if (orderMenu == null)
            {
                return HttpNotFound();
            }
            return View(orderMenu);
        }

        // POST: OrderMenusManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Dish,Description,Price")] OrderMenu orderMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderMenu);
        }

        // GET: OrderMenusManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderMenu orderMenu = db.OrderMenus.Find(id);
            if (orderMenu == null)
            {
                return HttpNotFound();
            }
            return View(orderMenu);
        }

        // POST: OrderMenusManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderMenu orderMenu = db.OrderMenus.Find(id);
            db.OrderMenus.Remove(orderMenu);
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
