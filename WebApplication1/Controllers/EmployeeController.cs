using BusinessObjects;
using DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDB serviceDb = new EmployeeDB();
        // GET: Employee
        public ActionResult Index()
        {
            List<EMPLOYEE> lst = new List<EMPLOYEE>();
            lst = serviceDb.GetAll(); // .Where(o => o.FIRST_NAME.Length > 0).ToList();

            return View(lst);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View(new EMPLOYEE());
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EMPLOYEE obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //DB.GUESTs.Add(obj);
                    //DB.SaveChanges();
                    //guestService.Save(obj);
                    serviceDb.Save(obj);

                    return RedirectToAction("Index");
                }
            }
            catch (DataException ex /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", ex.Message + "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(obj);


        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE course = serviceDb.getDetail(Convert.ToInt32( id));
            if (course == null)
            {
                return HttpNotFound();
            }

            return View(course);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(EMPLOYEE collection)
        {
            try
            {
                // TODO: Add update logic here
                serviceDb.Update(collection);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE course = serviceDb.getDetail(Convert.ToInt32(id));
            if (course == null)
            {
                return HttpNotFound();
            }

            return View(course);
        }

        // POST: Employee/Delete/5
        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            serviceDb.Remove(id);
           
            return RedirectToAction("Index");
        }



    }
}
