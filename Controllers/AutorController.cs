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
                    // autor.created_at = Convert.ToDateTime(result["created_at"]);             
                    // autor.updated_at = Convert.ToDateTime(result["updated_at"]);             
                    lstautor.Add(autor);    
                }    
                con.Close();    
            }    
                return lstautor;    
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
        
        public ActionResult Edit(int? id)
        {
            ViewBag.Title = "Modification"; 
            if (id == null) return NotFound();
            Autor autor = new Autor();
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from autors a where a.id='"+id+"' ";
                MySqlCommand cmd = new MySqlCommand(query, con); 
                con.Open();    
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())    
                {    
                    autor.id = Convert.ToInt32(rdr["id"]);    
                    autor.name = rdr["name"].ToString();    
                    autor.phone = rdr["phone"].ToString(); 
                    // roles.created_at = rdr["created_at"];        
                    // roles.updated_at = rdr["updated_at"];  
                }  
            }
            return View(autor);
        }
        

        public ActionResult Update(string name,string phone,int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "UPDATE autors  SET `name` = '"+name+"', `phone` = '"+phone+"' WHERE autors.id = '"+id+"'";
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

    }
}
