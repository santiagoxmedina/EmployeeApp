using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;
using Repository.DAL;

namespace WebApplication.Controllers
{
    public class EmployeeInfoDTOController : Controller
    {
        private DBRepositoryContext db = new DBRepositoryContext();

        // GET: EmployeeInfoDTO
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: EmployeeInfoDTO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInfoDTO employeeInfoDTO = db.Employees.Find(id);
            if (employeeInfoDTO == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfoDTO);
        }

        // GET: EmployeeInfoDTO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeInfoDTO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ContractTypeName,RoleId,RoleName,RoleDescription,HourlySalary,MonthlySalary")] EmployeeInfoDTO employeeInfoDTO)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employeeInfoDTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeInfoDTO);
        }

        // GET: EmployeeInfoDTO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInfoDTO employeeInfoDTO = db.Employees.Find(id);
            if (employeeInfoDTO == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfoDTO);
        }

        // POST: EmployeeInfoDTO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ContractTypeName,RoleId,RoleName,RoleDescription,HourlySalary,MonthlySalary")] EmployeeInfoDTO employeeInfoDTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeInfoDTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeInfoDTO);
        }

        // GET: EmployeeInfoDTO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInfoDTO employeeInfoDTO = db.Employees.Find(id);
            if (employeeInfoDTO == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfoDTO);
        }

        // POST: EmployeeInfoDTO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeInfoDTO employeeInfoDTO = db.Employees.Find(id);
            db.Employees.Remove(employeeInfoDTO);
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
