using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;    
using MySql.Data.MySqlClient;  
using aspbiblio.Models;
using aspbiblio.Data;
namespace aspbiblio.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext db;

        public UsersController(ApplicationDbContext db)
        {
            this.db = db;
        }

        //connect to mysql database
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";

        public IActionResult Index()
        { 
            ViewBag.Title = "users"; 
            return View(Getusers());
        } 

        //To View all Users details      
        private IEnumerable<Users> Getusers()    
        {     
            List<Users> lstusers = new List<Users>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select u.*,r.libelle as roles from users u,roles r where u.roles_id = r.id";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                //cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader();  
    
                while (result.Read())    
                {    
                    Users users = new Users(); 
                    users.id = Convert.ToInt32(result["id"]);    
                    users.name = result["name"].ToString();    
                    users.username = result["username"].ToString();    
                    users.phone = result["phone"].ToString();    
                    users.email = result["email"].ToString(); 
                    users.roles = result["roles"].ToString();
                    // users.created_at = Convert.ToDateTime(result["created_at"]);             
                    // users.updated_at = Convert.ToDateTime(result["updated_at"]);           
                    lstusers.Add(users);     
                }    
                con.Close();    
            }    
            return lstusers;    
        }   

        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var arlistuser = new ArrayList();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            { 
                string query = "select * from users u where u.id = id";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                // cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader(); 
                    while (result.Read())    
                    {   
                        arlistuser.Add(result[0]);
                        arlistuser.Add(result[0]);
                        arlistuser.Add(result[0]);
                        arlistuser.Add(result[0]);
                    }    
                    con.Close(); 
            
            }
            return View(arlistuser);
        }
        //To create View of this Action result                
        public ActionResult Create()
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
                    Role role = new Role(); 
                    role.id = Convert.ToInt32(result["id"]);    
                    role.libelle = result["libelle"].ToString(); 
                    lstroles.Add(role);    
                }    
                con.Close();    
            }   
            return View("Views/Users/Create.cshtml",lstroles);
        } 
        public ActionResult Save(string email, string name,string username,string password,int roles_id,string phone)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "INSERT INTO users (`email`,`roles_id`,`name`,`username`,`password`,`phone`) values('"+email+"','"+roles_id+"','"+name+"','"+username+"','"+password+"','"+phone+"')";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                cmd.ExecuteNonQuery();
                con.Close();    
            }           
            return RedirectToAction("Index", "Users");
        }  

        public ActionResult Delete(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "DELETE FROM users WHERE users.id = '"+id+"'";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                cmd.ExecuteNonQuery();
                con.Close();    
            }           
            return RedirectToAction("Index", "Users");
        }
    
    }
}
