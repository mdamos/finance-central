using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using FinanceCentral.Models;

namespace FinanceCentral.Controllers
{
    public class ExpensesController : Controller
    {
        // GET: Expenses
        public ActionResult Index()
        {
            using (FCModels expensesModel = new FCModels())
                return View(expensesModel.Expenses.ToList());
        }

        // GET: Expenses/Details/5
        public ActionResult Details(int id)
        {
            using (FCModels expensesModel = new FCModels())
            {
                return View(expensesModel.Expenses.Where(x => x.expenseID == id).FirstOrDefault());
            }
        }

        // GET: Expenses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expenses/Create
        [HttpPost]
        public ActionResult Create(Expenses expense)
        {
            try
            {
                using (FCModels expensesModel = new FCModels())
                {
                    expensesModel.Expenses.Add(expense);
                    expensesModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Expenses/Edit/5
        public ActionResult Edit(int id)
        {
            using (FCModels expensesModel = new FCModels())
            {
                return View(expensesModel.Expenses.Where(x => x.expenseID == id).FirstOrDefault());
            }
        }

        // POST: Expenses/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Expenses expense)
        {
            try
            {
                using (FCModels expensesModel = new FCModels())
                {
                    expensesModel.Entry(expense).State = EntityState.Modified;
                    expensesModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Expenses/Delete/5
        public ActionResult Delete(int id)
        {
            using (FCModels expensesModel = new FCModels())
            {
                return View(expensesModel.Expenses.Where(x => x.expenseID == id).FirstOrDefault());
            }
        }

        // POST: Expenses/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (FCModels expensesModel = new FCModels())
                {
                    Expenses expense = expensesModel.Expenses.Where(x => x.expenseID == id).FirstOrDefault();
                    expensesModel.Expenses.Remove(expense);
                    expensesModel.SaveChanges();
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
