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
    public class AutorController : Controller
    {
        // private readonly ILogger<AuthController> _logger;
    
        private readonly ApplicationDbContext db;

        public AutorController(ApplicationDbContext db)
        {
            this.db = db;
        }

        //connect to mysql database
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";

        public IActionResult Index()
        { 
            ViewBag.Title = "Auteur des Livres"; 
            return View(Getautor());
        } 

        //To View all Users details      
        private IEnumerable<Autor> Getautor()    
        {     
        List<Autor> lstautor = new List<Autor>();   
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "select * from autors";
            MySqlCommand cmd = new MySqlCommand(query, con);    
            //cmd.CommandType = CommandType.StoredProcedure;            
            con.Open();    
            MySqlDataReader result = cmd.ExecuteReader();  

            while (result.Read())    
            {    
                Autor autor = new Autor(); 
                autor.id = Convert.ToInt32(result["id"]);    
                autor.name = result["name"].ToString();    
                autor.phone = result["phone"].ToString(); 
                autor.created_at = Convert.ToDateTime(result["created_at"]);             
                autor.updated_at = Convert.ToDateTime(result["updated_at"]);             
                lstautor.Add(autor);    
            }    
            con.Close();    
        }    
            return lstautor;    
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
        // []
        public ActionResult Save(String name, String phone)
            { 
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "INSERT INTO autors (`name`,`phone`) values('"+name+"','"+phone+"')";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                cmd.ExecuteNonQuery();
                con.Close();    
            }           
            return RedirectToAction("Index", "Autor");
        }

        public ActionResult Delete(int id)
        {
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "DELETE FROM autors WHERE autors.id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        }           
            return RedirectToAction("Index", "Autor");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
