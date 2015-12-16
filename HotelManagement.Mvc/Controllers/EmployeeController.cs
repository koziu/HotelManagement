using System;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HotelManagement.Mvc.DAL.Context;
using HotelManagement.Mvc.Models;

namespace HotelManagement.Mvc.Controllers
{
  public class EmployeeController : Controller
  {
    private readonly HotelManagementContext db = new HotelManagementContext();

    // GET: Employee
    public async Task<ActionResult> Index()
    {
      return View(await db.EmployeeModels.ToListAsync());
    }

    // GET: Employee/Details/5
    public async Task<ActionResult> Details(Guid id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      EmployeeModels employeeModels = await db.EmployeeModels.FindAsync(id);
      if (employeeModels == null)
      {
        return HttpNotFound();
      }
      return View(employeeModels);
    }

    // GET: Employee/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Employee/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(
      [Bind(Include = "Id,Name,Surname,Address,DeliveriesAddress,Email,PhoneNumber,BrithDay,BrithPlace,TaxId")] EmployeeModels employeeModels)
    {
      if (ModelState.IsValid)
      {
        employeeModels.Id = Guid.NewGuid();
        db.EmployeeModels.Add(employeeModels);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
      }

      return View(employeeModels);
    }

    // GET: Employee/Edit/5
    public async Task<ActionResult> Edit(Guid id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      EmployeeModels employeeModels = await db.EmployeeModels.FindAsync(id);
      if (employeeModels == null)
      {
        return HttpNotFound();
      }
      return View(employeeModels);
    }

    // POST: Employee/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(
      [Bind(Include = "Id,Name,Surname,Address,DeliveriesAddress,Email,PhoneNumber,BrithDay,BrithPlace,TaxId")] EmployeeModels employeeModels)
    {
      if (ModelState.IsValid)
      {
        db.Entry(employeeModels).State = EntityState.Modified;
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
      }
      return View(employeeModels);
    }

    // GET: Employee/Delete/5
    public async Task<ActionResult> Delete(Guid id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      EmployeeModels employeeModels = await db.EmployeeModels.FindAsync(id);
      if (employeeModels == null)
      {
        return HttpNotFound();
      }
      return View(employeeModels);
    }

    // POST: Employee/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirmed(Guid id)
    {
      EmployeeModels employeeModels = await db.EmployeeModels.FindAsync(id);
      db.EmployeeModels.Remove(employeeModels);
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