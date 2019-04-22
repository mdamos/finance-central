using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using FinanceCentral.Models;

namespace FinanceCentral.Controllers
{
    public class IncomeController : Controller
    {
        // GET: Income/Index
        public ActionResult Index()
        {
            using (FCModels incomeModel = new FCModels())
                return View(incomeModel.Incomes.ToList());
        }

        // GET: Income/Details/5
        public ActionResult Details(int id)
        {
            using (FCModels incomeModel = new FCModels())
            {
                return View(incomeModel.Incomes.Where(x => x.incomeID == id).FirstOrDefault());
            }
                
        }

        // GET: Income/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Income/Create
        [HttpPost]
        public ActionResult Create(Income income)
        {
            try
            {
                using (FCModels incomeModel = new FCModels())
                {
                    incomeModel.Incomes.Add(income);
                    incomeModel.SaveChanges();
                }


                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Income/Edit/5
        public ActionResult Edit(int id)
        {
            using (FCModels incomeModel = new FCModels())
            {
                return View(incomeModel.Incomes.Where(x => x.incomeID == id).FirstOrDefault());
            }
        }

        // POST: Income/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Income income)
        {
            try
            {
                using (FCModels incomeModel = new FCModels())
                {
                    incomeModel.Entry(income).State = EntityState.Modified;
                    incomeModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Income/Delete/5
        public ActionResult Delete(int id)
        {
            using (FCModels incomeModel = new FCModels())
            {
                return View(incomeModel.Incomes.Where(x => x.incomeID == id).FirstOrDefault());
            }
        }

        // POST: Income/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (FCModels incomeModel = new FCModels())
                {
                    Income income = incomeModel.Incomes.Where(x => x.incomeID == id).FirstOrDefault();
                    incomeModel.Incomes.Remove(income);
                    incomeModel.SaveChanges();
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
