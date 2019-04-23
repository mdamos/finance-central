using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using FinanceCentral.Models;

namespace FinanceCentral.Controllers
{
    public class GoalsController : Controller
    {
        // GET: Goals
        public ActionResult Index()
        {
            using (FCModels goalsModel = new FCModels())
                return View(goalsModel.Goals.ToList());
        }

        // GET: Goals/Details/5
        public ActionResult Details(int id)
        {
            using (FCModels goalsModel = new FCModels())
            {
                return View(goalsModel.Goals.Where(x => x.goalID == id).FirstOrDefault());
            }
        }

        // GET: Goals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Goals/Create
        [HttpPost]
        public ActionResult Create(Goals goal)
        {
            try
            {
                using(FCModels goalsModel = new FCModels())
                {
                    goalsModel.Goals.Add(goal);
                    goalsModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Goals/Edit/5
        public ActionResult Edit(int id)
        {
            using (FCModels goalsModel = new FCModels())
            {
                return View(goalsModel.Goals.Where(x => x.goalID == id).FirstOrDefault());
            }
        }

        // POST: Goals/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Goals goal)
        {
            try
            {
                using (FCModels goalsModel = new FCModels())
                {
                    goalsModel.Entry(goal).State = EntityState.Modified;
                    goalsModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Goals/Delete/5
        public ActionResult Delete(int id)
        {
            using (FCModels goalsModel = new FCModels())
            {
                return View(goalsModel.Goals.Where(x => x.goalID == id).FirstOrDefault());
            }
        }

        // POST: Goals/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (FCModels goalsModel = new FCModels())
                {
                    Goals goal = goalsModel.Goals.Where(x => x.goalID == id).FirstOrDefault();
                    goalsModel.Goals.Remove(goal);
                    goalsModel.SaveChanges();
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
