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
        // private readonly ILogger<AuthController> _logger;
    
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
                return View(GetAllUsers());
            } 

            //To View all Users details      
            private IEnumerable<Users> GetAllUsers()    
            {     
                List<Users> lstusers = new List<Users>();    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    string query = "select u.*,r.libelle from users u,roles r where u.roles_id = r.id";
                    MySqlCommand cmd = new MySqlCommand(query, con);    
                    //cmd.CommandType = CommandType.StoredProcedure;            
                    con.Open();    
                    MySqlDataReader rdr = cmd.ExecuteReader();  
        
                    while (rdr.Read())    
                    {    
                        Users users = new Users(); 
                        users.id = Convert.ToInt32(rdr["id"]);    
                        users.name = rdr["name"].ToString();    
                        users.username = rdr["username"].ToString();    
                        users.phone = rdr["phone"].ToString();    
                        users.email = rdr["email"].ToString(); 
                        users.roles = rdr["libelle"].ToString();           
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
                return View();
            } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
