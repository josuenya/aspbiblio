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

    //GET: /Auth/Login
    public ActionResult Login()
    {            
        return View();
    }  

    //POST: /Auth/login_action
    public ActionResult Login_action(string email,string password)
    {   
        //instantiation de la classe Users
        Users user = new Users();  
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "select * from users u,roles r where email = '"+email+"' and u.roles_id = r.id";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            MySqlDataReader result = cmd.ExecuteReader();  
            while (result.Read())    
            {    
                user.id = Convert.ToInt32(result["id"]);    
                user.email = result["email"].ToString();    
                user.name = result["name"].ToString();
                user.phone = result["phone"].ToString();
                user.password = result["password"].ToString();
            } 
            con.Close();    
        }
        if (user.email == email && user.password == password) {
            return RedirectToAction("Index","Home");
        }else
        {
            return RedirectToAction("Login","Auth");
        }
    
    }
        
        
    //GET: /Auth/Register
    public ActionResult Register()
    {
         List<Role> lstroles = new List<Role>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from roles";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                //cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader();  
    
                while (result.Read())    
                {    
                    Role roles = new Role(); 
                    roles.id = Convert.ToInt32(result["id"]);    
                    roles.libelle = result["libelle"].ToString(); 
                    lstroles.Add(roles);    
                }    
                con.Close();    
            }   
            return View("Views/Auth/Register.cshtml",lstroles); 
    }

    //POST : Auth/Register_action
    public ActionResult Register_action(string email,int roles_id,string name,string username,string password,string phone)
    {
        using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "INSERT INTO users (`email`,`roles_id`,`name`,`username`,`password`,`phone`) values('"+email+"','"+roles_id+"','"+username+"','"+username+"','"+password+"','"+phone+"')";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                cmd.ExecuteNonQuery();
                con.Close();    
            }           
                return RedirectToAction("Login", "Auth");
    }

    }
}
