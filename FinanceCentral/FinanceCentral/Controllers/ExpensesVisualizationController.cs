using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using FinanceCentral.Models;


namespace FinanceCentral.Controllers
{
    public class ExpensesVisualizationController : Controller
    {
        FCModels context = new FCModels();
        // GET: ExpensesVisualization
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExpensesVisualization/GetData
        public ActionResult GetData()
        {
            int januaryExpense;
            int februaryExpense;
            int marchExpense;
            int aprilExpense;

            Ratio obj = new Ratio();
            

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4QAMP7B\\SQLEXPRESS;Initial Catalog=FinanceCentral;Integrated Security=SSPI");
            SqlCommand sql = new SqlCommand();
            sql.CommandType = System.Data.CommandType.Text;
            sql.CommandText = "SELECT SUM(amount) FROM Expenses WHERE month = 'January'";
            sql.Connection = con;
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                januaryExpense = Convert.ToInt32(dr.GetValue(0));
                obj.januaryExpense = januaryExpense;
            }
            
            con.Close();

            sql.CommandType = System.Data.CommandType.Text;
            sql.CommandText = "SELECT SUM(amount) FROM Expenses WHERE month = 'February'";
            sql.Connection = con;
            con.Open();
            dr = sql.ExecuteReader();
            if (dr.Read())
            {
                februaryExpense = Convert.ToInt32(dr.GetValue(0));
                obj.februaryExpense = februaryExpense;
            }
            
            con.Close();

            sql.CommandType = System.Data.CommandType.Text;
            sql.CommandText = "SELECT SUM(amount) FROM Expenses WHERE month = 'March'";
            sql.Connection = con;
            con.Open();
            dr = sql.ExecuteReader();
            if (dr.Read())
            {
                marchExpense = Convert.ToInt32(dr.GetValue(0));
                obj.marchExpense = marchExpense;
            }
            
            con.Close();

            sql.CommandType = System.Data.CommandType.Text;
            sql.CommandText = "SELECT SUM(amount) FROM Expenses WHERE month = 'April'; ";
            sql.Connection = con;
            con.Open();
            dr = sql.ExecuteReader();
            if (dr.Read())
            {
                aprilExpense = Convert.ToInt32(dr.GetValue(0));
                obj.aprilExpense = aprilExpense;
            }
            con.Close();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public class Ratio
        {
            public int januaryExpense { get; set; }
            public int februaryExpense { get; set; }
            public int marchExpense { get; set; }
            public int aprilExpense { get; set; }
        }
    }
}
