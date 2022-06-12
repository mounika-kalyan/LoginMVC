using Microsoft.AspNetCore.Mvc;
using LoginMVC.Models;
using System.Data.SqlClient;

namespace LoginMVC.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        //GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionSTring()
        {
            con.ConnectionString = "data source=MOUNIKAK; database=WPF; integrated security = SSPI;";
        }
        public ActionResult Verify(Account acc)
        {
            connectionSTring();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from Login where UserName='"+acc.UserName+"' and Password='"+acc.Password+"' ";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
            
        }
    }
}
