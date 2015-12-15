using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotelManagement.Mvc.DAL.Context;
using HotelManagement.Mvc.Models;

namespace HotelManagement.Mvc.Controllers
{
    public class RoomController : Controller
    {
        private HotelManagementContext db = new HotelManagementContext();

        // GET: RoomModels
        public async Task<ActionResult> Index()
        {
            return View(await db.RoomModels.ToListAsync());
        }

        // GET: RoomModels/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomModels roomModels = await db.RoomModels.FindAsync(id);
            if (roomModels == null)
            {
                return HttpNotFound();
            }
            return View(roomModels);
        }

        // GET: RoomModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,RoomName,RoomState,BedSBCOunt,BEdDBCount,AddtionalBed,FixedPricePerRoom,FixedPricePerPerson,RoomDescription,Floor,RoomCapacity")] RoomModels roomModels)
        {
            if (ModelState.IsValid)
            {
                roomModels.Id = Guid.NewGuid();
                db.RoomModels.Add(roomModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(roomModels);
        }

        // GET: RoomModels/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomModels roomModels = await db.RoomModels.FindAsync(id);
            if (roomModels == null)
            {
                return HttpNotFound();
            }
            return View(roomModels);
        }

        // POST: RoomModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,RoomName,RoomState,BedSBCOunt,BEdDBCount,AddtionalBed,FixedPricePerRoom,FixedPricePerPerson,RoomDescription,Floor,RoomCapacity")] RoomModels roomModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(roomModels);
        }

        // GET: RoomModels/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomModels roomModels = await db.RoomModels.FindAsync(id);
            if (roomModels == null)
            {
                return HttpNotFound();
            }
            return View(roomModels);
        }

        // POST: RoomModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            RoomModels roomModels = await db.RoomModels.FindAsync(id);
            db.RoomModels.Remove(roomModels);
            await db.SaveChangesAsync();
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
