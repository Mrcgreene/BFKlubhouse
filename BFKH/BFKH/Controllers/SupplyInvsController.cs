using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using BFKH.Models;

namespace BFKH.Controllers
{
    public class SupplyInvsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SupplyInvs
        public ActionResult Index()
        {
            return View(db.SupplyInvs.ToList());
        }

        // GET: SupplyInvs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplyInv supplyInv = db.SupplyInvs.Find(id);
            if (supplyInv == null)
            {
                return HttpNotFound();
            }
            return View(supplyInv);
        }

        // GET: SupplyInvs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplyInvs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Item,Description,Size,Price,Quantity")] SupplyInv supplyInv)
        {
            if (ModelState.IsValid)
            {
                db.SupplyInvs.Add(supplyInv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(supplyInv);
        }

        // GET: SupplyInvs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplyInv supplyInv = db.SupplyInvs.Find(id);
            if (supplyInv == null)
            {
                return HttpNotFound();
            }
            return View(supplyInv);
        }

        // POST: SupplyInvs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Item,Description,Size,Price,Quantity")] SupplyInv supplyInv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supplyInv).State = EntityState.Modified;
                db.SaveChanges();

                //if (supplyInv.Quantity <= supplyInv.purchaseLevel)
                //{
                //    var fromAddress = new MailAddress("placeemailaddresshere@gmail.com", "Best Friendz");
                //    var toAddress = new MailAddress("placeemailaddresshere@gmail.comm", "Manager");
                //    const string fromPassword = "actualpasswordforsenderaddresssgoeshere";
                //    const string subject = "Low Supplies Inventory, please place order immediately";
                //    const string body = "Please check your inventory, item(s) have reached restock level, place order.";

                //    var smtp = new SmtpClient
                //    {
                //        Host = "smtp.gmail.com",
                //        Port = 587,
                //        EnableSsl = true,
                //        DeliveryMethod = SmtpDeliveryMethod.Network,
                //        UseDefaultCredentials = false,
                //        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                //    };
                //    using (var message = new MailMessage(fromAddress, toAddress)
                //    {
                //        Subject = subject,
                //        Body = body
                //    })
                //    {
                //        smtp.Send(message);
                //    }
                //}
                return RedirectToAction("Index");
            }
            return View(supplyInv);
        }

        // GET: SupplyInvs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplyInv supplyInv = db.SupplyInvs.Find(id);
            if (supplyInv == null)
            {
                return HttpNotFound();
            }
            return View(supplyInv);
        }

        // POST: SupplyInvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SupplyInv supplyInv = db.SupplyInvs.Find(id);
            db.SupplyInvs.Remove(supplyInv);
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
