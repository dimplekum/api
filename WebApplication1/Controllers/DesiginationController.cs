using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DesiginationController : Controller
    {
        // GET: Desigination
        public ActionResult Index()
        {
            return View();
        }

        // GET: Desigination/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Desigination/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Desigination/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Desigination/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Desigination/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Desigination/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Desigination/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
