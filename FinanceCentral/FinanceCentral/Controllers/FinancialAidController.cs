using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using FinanceCentral.Models;

namespace FinanceCentral.Controllers
{
    public class FinancialAidController : Controller
    {
        // GET: FinancialAid
        public ActionResult Index()
        {
            using (FCModels finAidAmtModel = new FCModels())
                return View(finAidAmtModel.FinancialAidAmt.ToList());
        }

        // GET: FinancialAid/Details/5
        public ActionResult Details(string id)
        {
            using (FCModels finAidAmtModel = new FCModels())
            {
                return View(finAidAmtModel.FinancialAidAmt.Where(x => x.finAidName == id).FirstOrDefault());
            }
        }

        // GET: FinancialAid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinancialAid/Create
        [HttpPost]
        public ActionResult Create(FinancialAidAmt finAid)
        {
            try
            {
                using (FCModels finAidAmtModel = new FCModels())
                {
                    finAidAmtModel.FinancialAidAmt.Add(finAid);
                    finAidAmtModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FinancialAid/Edit/5
        public ActionResult Edit(string id)
        {
            using (FCModels finAidAmtModel = new FCModels())
            {
                return View(finAidAmtModel.FinancialAidAmt.Where(x => x.finAidName == id).FirstOrDefault());
            }
        }

        // POST: FinancialAid/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FinancialAidAmt finAid)
        {
            try
            {
                using (FCModels finAidAmtModel = new FCModels())
                {
                    finAidAmtModel.Entry(finAid).State = EntityState.Modified;
                    finAidAmtModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FinancialAid/Delete/5
        public ActionResult Delete(string id)
        {
            using (FCModels finAidAmtModel = new FCModels())
            {
                return View(finAidAmtModel.FinancialAidAmt.Where(x => x.finAidName == id).FirstOrDefault());
            }
        }

        // POST: FinancialAid/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (FCModels finAidAmtModel = new FCModels())
                {
                    FinancialAidAmt finAid = finAidAmtModel.FinancialAidAmt.Where(x => x.finAidName == id).FirstOrDefault();
                    finAidAmtModel.FinancialAidAmt.Remove(finAid);
                    finAidAmtModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
