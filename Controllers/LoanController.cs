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
    public class LoanController : Controller
    {
        
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";

            //To View all Users details      
            private IEnumerable<Users> GetAllUsers()    
            {     
                List<Users> lstusers = new List<Users>();    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    string query = "select * from users";
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
                        lstusers.Add(users);    
                    }    
                    con.Close();    
                }    
                return lstusers;    
            }   


            public IActionResult Index()
            {
                return View(GetAllUsers());
            } 

    }

}