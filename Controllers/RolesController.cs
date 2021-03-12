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
            ViewBag.Title = "Roles"; 
            return View(getroles());
        } 
        
        //Diplay all roles users in database
        private IEnumerable<Role> getroles()    
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

        public ActionResult Create()
        {
            ViewBag.Title = "Creation d'un Nouveau Role"; 
            return View();
        } 

        //enregistrement des roles utilisateurs venant du formulaire
        public ActionResult Save(String libelle, String description)
        { 
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "INSERT INTO roles (`libelle`,`description`) values('"+libelle+"','"+description+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        }           
            return RedirectToAction("Index", "Roles");
        }

        public ActionResult Edit(int? id)
        {
            ViewBag.Title = "Modification"; 
            if (id == null) return NotFound();
            Role role = new Role();
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from roles r where r.id='"+id+"' ";
                MySqlCommand cmd = new MySqlCommand(query, con); 
                con.Open();    
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())    
                {    
                    role.id = Convert.ToInt32(rdr["id"]);    
                    role.libelle = rdr["libelle"].ToString();    
                    role.description = rdr["description"].ToString(); 
                    // roles.created_at = rdr["created_at"];        
                    // roles.updated_at = rdr["updated_at"];  
                }  
            }
            return View(role);
        }

        public ActionResult Update(string libelle,string description,int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "UPDATE roles  SET `libelle` = '"+libelle+"', `description` = '"+description+"' WHERE roles.id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        } 
        return RedirectToAction("Index", "Roles");
        }

        public ActionResult Delete(int id)
        {
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "DELETE FROM roles WHERE roles.id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        }           
            return RedirectToAction("Index", "Roles");
        }
    }
}