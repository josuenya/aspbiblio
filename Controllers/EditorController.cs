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
    public class EditorController : Controller
    {
        // private readonly ILogger<AuthController> _logger;
    
        private readonly ApplicationDbContext db;

        public EditorController(ApplicationDbContext db)
        {
            this.db = db;
        }

        //connect to mysql database
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";

        public IActionResult Index()
        { 
            ViewBag.Title = "Editeur des Livres"; 
            return View(Geteditor());
        } 

            //To View all Users details      
        private IEnumerable<Editor> Geteditor()    
        {     
        List<Editor> lsteditor = new List<Editor>();   
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "select * from editors";
            MySqlCommand cmd = new MySqlCommand(query, con); 
            //ouverture de la connection a la base de donnee           
            con.Open();    
            MySqlDataReader result = cmd.ExecuteReader();  

            while (result.Read())    
            {    
                Editor editor = new Editor(); 
                editor.id = Convert.ToInt32(result["id"]);    
                editor.name = result["name"].ToString();    
                editor.adress = result["adress"].ToString();
                editor.city = result["city"].ToString(); 
                // editor.created_at = Convert.ToDateTime(result["created_at"]);             
                // editor.updated_at = Convert.ToDateTime(result["updated_at"]);             
                lsteditor.Add(editor);    
            }    
            //Fermerture de la connection a la base de donnee
            con.Close();    
        }    
            return lsteditor;    
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
        public ActionResult Save(string name, string adress,string city)
        { 
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "INSERT INTO editors (`name`,`adress`,`city`) values('"+name+"','"+adress+"','"+city+"')";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                cmd.ExecuteNonQuery();
                con.Close();    
            }           
            return RedirectToAction("Index", "Editor");
        }


        public ActionResult Delete(int id)
        {
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "DELETE FROM editors WHERE editors.id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        }           
            return RedirectToAction("Index", "Editor");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
