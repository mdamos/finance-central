using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanceCentral.Controllers
{
    public class FinancialAidController : Controller
    {
        // GET: FinancialAid
        public ActionResult Index()
        {
            return View();
        }

        // GET: FinancialAid/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FinancialAid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinancialAid/Create
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

        // GET: FinancialAid/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinancialAid/Edit/5
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

        // GET: FinancialAid/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FinancialAid/Delete/5
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
