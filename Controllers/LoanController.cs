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

            public IActionResult Index()
            {
                return View(GetLoan());
            } 

            //To View all Users details      
            private IEnumerable<Loan> GetLoan()    
            {     
                List<Loan> lstloan = new List<Loan>();    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    string query = "select * from loan l,users u,books b where l.users_id = u.id and l.books_id = b.id";
                    MySqlCommand cmd = new MySqlCommand(query, con);    
                    // cmd.CommandType = CommandType.StoredProcedure;            
                    con.Open();    
                    MySqlDataReader result = cmd.ExecuteReader();    
        
                    while (result.Read())    
                    {     
                        Loan loan = new Loan(); 
                        loan.id = Convert.ToInt32(result["id"]);    
                        loan.users_name = result["name"].ToString();
                        loan.libelle = result["libelle"].ToString();
                        loan.status = result["statut"].ToString();    
                        loan.return_date = Convert.ToDateTime(result["return_date"]);             
                        // loan.created_at = Convert.ToDateTime(result["return_date"]); 
                        // loan.updated_at = Convert.ToDateTime(result["updated_at"]);    
                        lstloan.Add(loan);    
                    }    
                    con.Close();    
                }    
                return lstloan;    
            }   

             //To create View of this Action result                
            public ActionResult Create()
            {
                ViewBag.Title = "Nouveau Emprunt";
                List<Users> lstusers = new List<Users>();    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    string query = "select * from users";
                    MySqlCommand cmd = new MySqlCommand(query, con);    
                    //cmd.CommandType = CommandType.StoredProcedure;            
                    con.Open();    
                    MySqlDataReader result = cmd.ExecuteReader();  
        
                    while (result.Read())    
                    {    
                        Users users = new Users(); 
                        users.id = Convert.ToInt32(result["id"]);    
                        users.name = result["name"].ToString(); 
                        lstusers.Add(users);    
                    }    
                    con.Close();    
                }   
                
                return View("Views/Loan/Create.cshtml",lstusers);
            } 

    }

}