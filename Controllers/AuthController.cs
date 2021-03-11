using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;  
using aspbiblio.Models;
using aspbiblio.Data;


namespace aspbiblio.Controllers
{
    public class AuthController : Controller
    {
    private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";


    private readonly ApplicationDbContext db;

    public AuthController(ApplicationDbContext db)
    {
        this.db = db;
    }

    public ActionResult Login()
    {            
        return View();
    }  

    public ActionResult login_action(string email,string password)
    {   
        List<Users> lstuser = new List<Users>();    
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "select * from users u,roles r where email = '"+email+"' and u.roles_id = r.id";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            MySqlDataReader rdr = cmd.ExecuteReader();  
            while (rdr.Read())    
            {    
                Users user = new Users(); 
                user.id = Convert.ToInt32(rdr["id"]);    
                user.email = rdr["email"].ToString();    
                user.name = rdr["name"].ToString();
                user.phone = rdr["phone"].ToString();
                lstuser.Add(user);
            }
            con.Close();    
        }
        return View();
    }
        
        
        //GET: /Account/Register
    public ActionResult Register(string returnUrl)
    {
        return View(); 
    }

    public ActionResult Register_action()
    {
        return View(); 
    }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
