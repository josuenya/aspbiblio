using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;    
using MySql.Data.MySqlClient;  
using aspbiblio.Models;

namespace aspbiblio.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public UsersController(ILogger<AuthController> logger)
        {
            _logger = logger;
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
                    // cmd.CommandType = CommandType.StoredProcedure;            
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

        [HttpPost]
        public ActionResult edit(Users userModel)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            { 
            
            }
            ModelState.Clear();
            return View("Create", new Users());
        }
                
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
