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
    public class BooksController : Controller
    {

        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";

        private readonly ApplicationDbContext db;

        public BooksController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(Getbook());
        }

        private IEnumerable<Book> Getbook()    
            {     
                List<Book> lstbooks = new List<Book>();    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    string query = "select * from books";
                    MySqlCommand cmd = new MySqlCommand(query, con);    
                    //cmd.CommandType = CommandType.StoredProcedure;            
                    con.Open();    
                    MySqlDataReader result = cmd.ExecuteReader();  
        
                    while (result.Read())    
                    {    
                        Book books = new Book(); 
                        books.id = Convert.ToInt32(result["id"]);    
                        books.libelle = result["libelle"].ToString();    
                        books.description = result["description"].ToString();          
                        lstbooks.Add(books);    
                    }    
                    con.Close();    
                }    
                return lstbooks;    
            }


        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
