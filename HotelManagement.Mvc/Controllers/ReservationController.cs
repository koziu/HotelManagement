using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HotelManagement.Mvc.DAL.Context;
using HotelManagement.Mvc.Models;

namespace HotelManagement.Mvc.Controllers
{
  public class ReservationController : Controller
  {
    private readonly HotelManagementContext db = new HotelManagementContext();

    // GET: ReservationModels
    public async Task<ActionResult> Index()
    {
      IQueryable<ReservationModels> reservationModelses = db.ReservationModelses.Include(r => r.Events);
      return View(await reservationModelses.ToListAsync());
    }

    // GET: ReservationModels/Details/5
    public async Task<ActionResult> Details(Guid? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      ReservationModels reservationModels = await db.ReservationModelses.FindAsync(id);
      if (reservationModels == null)
      {
        return HttpNotFound();
      }
      return View(reservationModels);
    }

    // GET: ReservationModels/Create
    public ActionResult Create()
    {
      ViewBag.Id = new SelectList(db.Events, "Id", "Id");
      return View();
    }

    // POST: ReservationModels/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create([Bind(Include = "Id")] ReservationModels reservationModels)
    {
      if (ModelState.IsValid)
      {
        reservationModels.Id = Guid.NewGuid();
        db.ReservationModelses.Add(reservationModels);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
      }

      ViewBag.Id = new SelectList(db.Events, "Id", "Id", reservationModels.Id);
      return View(reservationModels);
    }

    // GET: ReservationModels/Edit/5
    public async Task<ActionResult> Edit(Guid? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      ReservationModels reservationModels = await db.ReservationModelses.FindAsync(id);
      if (reservationModels == null)
      {
        return HttpNotFound();
      }
      ViewBag.Id = new SelectList(db.Events, "Id", "Id", reservationModels.Id);
      return View(reservationModels);
    }

    // POST: ReservationModels/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit([Bind(Include = "Id")] ReservationModels reservationModels)
    {
      if (ModelState.IsValid)
      {
        db.Entry(reservationModels).State = EntityState.Modified;
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
      }
      ViewBag.Id = new SelectList(db.Events, "Id", "Id", reservationModels.Id);
      return View(reservationModels);
    }

    // GET: ReservationModels/Delete/5
    public async Task<ActionResult> Delete(Guid? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      ReservationModels reservationModels = await db.ReservationModelses.FindAsync(id);
      if (reservationModels == null)
      {
        return HttpNotFound();
      }
      return View(reservationModels);
    }

    // POST: ReservationModels/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirmed(Guid id)
    {
      ReservationModels reservationModels = await db.ReservationModelses.FindAsync(id);
      db.ReservationModelses.Remove(reservationModels);
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