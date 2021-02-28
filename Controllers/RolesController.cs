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
    public class RolesController : Controller
    {
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";
            
        public IActionResult Index()
        { 
            ViewBag.Title = "roles"; 
            return View(roles());
        } 
        
        //Diplay all roles users in database
        private IEnumerable<Role> roles()    
        {     
            List<Role> lstroles = new List<Role>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from roles";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                // cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader rdr = cmd.ExecuteReader();  

                while (rdr.Read())    
                {    
                    Role roles = new Role(); 
                    roles.id = Convert.ToInt32(rdr["id"]);    
                    roles.libelle = rdr["libelle"].ToString();    
                    roles.description = rdr["description"].ToString(); 
                    // roles.created_at = rdr["created_at"];        
                    // roles.updated_at = rdr["updated_at"];        
                    lstroles.Add(roles);    
                }    
                con.Close();    
            }    
            return lstroles;    
        } 

        public ActionResult Create([Bind("Id,libelle,description")] Role role)
        {
            ViewBag.Title = "Creation d'un Nouveau Role"; 

            return View();
        } 

        public ActionResult Edit(int? id)
        {
            ViewBag.Title = "Modification"; 
            if (id == null) return NotFound();
            List<Role> lstroles = new List<Role>();
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from roles r where r.id=id ";
                MySqlCommand cmd = new MySqlCommand(query, con); 
                con.Open();    
                MySqlDataReader rdr = cmd.ExecuteReader(); 
                while (rdr.Read())    
                {    
                    Role roles = new Role(); 
                    roles.id = Convert.ToInt32(rdr["id"]);    
                    roles.libelle = rdr["libelle"].ToString();    
                    roles.description = rdr["description"].ToString(); 
                    // roles.created_at = rdr["created_at"];        
                    // roles.updated_at = rdr["updated_at"];        
                    lstroles.Add(roles);    
                }  
            }
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}