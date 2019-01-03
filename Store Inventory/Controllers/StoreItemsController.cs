using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Store_Inventory.Models;

namespace Store_Inventory.Controllers
{
    public class StoreItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StoreItems
        public ActionResult Index()
        {
            return View(db.StoreItems.ToList());
        }

        // GET: StoreItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoreItems storeItems = db.StoreItems.Find(id);
            if (storeItems == null)
            {
                return HttpNotFound();
            }
            return View(storeItems);
        }

        // GET: StoreItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,ItemName,ItemQuantity,ItemPrice")] StoreItems storeItems)
        {
            if (ModelState.IsValid)
            {
                db.StoreItems.Add(storeItems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(storeItems);
        }

        // GET: StoreItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoreItems storeItems = db.StoreItems.Find(id);
            if (storeItems == null)
            {
                return HttpNotFound();
            }
            return View(storeItems);
        }

        // POST: StoreItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,ItemName,ItemQuantity,ItemPrice")] StoreItems storeItems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(storeItems).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(storeItems);
        }

        // GET: StoreItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoreItems storeItems = db.StoreItems.Find(id);
            if (storeItems == null)
            {
                return HttpNotFound();
            }
            return View(storeItems);
        }

        // POST: StoreItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StoreItems storeItems = db.StoreItems.Find(id);
            db.StoreItems.Remove(storeItems);
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
