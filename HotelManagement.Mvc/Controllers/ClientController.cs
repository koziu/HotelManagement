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
    [Authorize(Roles = "Employee")]
    public class ClientController : Controller
    {
        private HotelManagementContext db = new HotelManagementContext();

        // GET: ClientModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ClientModels.ToListAsync());
        }

        // GET: ClientModels/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModels clientModels = await db.ClientModels.FindAsync(id);
            if (clientModels == null)
            {
                return HttpNotFound();
            }
            return View(clientModels);
        }

        // GET: ClientModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PhoneNumber,Street, City, PostalCode,Email,Comments,Name,Surname,IdentityCardNumber,BrithDay,BrithPlace,CompanyName,TaxId,REGON")] ClientModels clientModels)
        {
            if (ModelState.IsValid)
            {
                clientModels.Id = Guid.NewGuid();
                db.ClientModels.Add(clientModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(clientModels);
        }

        // GET: ClientModels/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModels clientModels = await db.ClientModels.FindAsync(id);
            if (clientModels == null)
            {
                return HttpNotFound();
            }
            return View(clientModels);
        }

        // POST: ClientModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PhoneNumber,Street, City, PostalCode,Email,Comments,Name,Surname,IdentityCardNumber,BrithDay,BrithPlace,CompanyName,TaxId,REGON")] ClientModels clientModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(clientModels);
        }

        // GET: ClientModels/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModels clientModels = await db.ClientModels.FindAsync(id);
            if (clientModels == null)
            {
                return HttpNotFound();
            }
            return View(clientModels);
        }

        // POST: ClientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            ClientModels clientModels = await db.ClientModels.FindAsync(id);
            db.ClientModels.Remove(clientModels);
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
