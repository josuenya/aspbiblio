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
    public class PurcharseController : Controller
    {
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";
            
        public IActionResult Index()
        { 
            ViewBag.Title = "Mes Achats"; 
            return View(getachats());
        } 
        
        //Diplay all roles users in database
        private IEnumerable<Purcharse> getachats()    
        {     
            List<Purcharse> lstachats = new List<Purcharse>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select p.*,b.libelle as libelle from purcharses p ,books b where p.books_id = b.id";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                // cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader rdr = cmd.ExecuteReader();  

                while (rdr.Read())    
                {    
                    Purcharse purcharse = new Purcharse(); 
                    purcharse.id = Convert.ToInt32(rdr["id"]);    
                    purcharse.libelle = rdr["libelle"].ToString();    
                    purcharse.buying_price = Convert.ToDecimal(rdr["buying_price"]); 
                    purcharse.qty = Convert.ToInt32(rdr["qty"]); 
                    
                    // roles.created_at = rdr["created_at"];        
                    // roles.updated_at = rdr["updated_at"];        
                    lstachats.Add(purcharse);    
                }    
                con.Close();    
            }    
            return lstachats;    
        } 

        public ActionResult Create()
        {
            ViewBag.Title = "Nouveau Achat"; 
            List<Book> lstbook = new List<Book>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from books";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                //cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader();  
    
                while (result.Read())    
                {    
                    Book book = new Book(); 
                    book.id = Convert.ToInt32(result["id"]);    
                    book.libelle = result["libelle"].ToString(); 
                    lstbook.Add(book);    
                }    
                con.Close();    
            }   
            return View("Views/Purcharse/Create.cshtml",lstbook);
        } 

        //enregistrement des roles utilisateurs venant du formulaire
        public ActionResult Save(String books_id, decimal buying_price,int qty)
        { 
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "INSERT INTO purcharse (`books_id`,`buying_price`,`qty`) values('"+books_id+"','"+buying_price+"','"+qty+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        }           
            return RedirectToAction("Index", "Purcharse");
        }

        public ActionResult Edit(int? id)
        {
            ViewBag.Title = "Modification"; 
            if (id == null) return NotFound();
            List<Role> lstroles = new List<Role>();
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from roles r where r.id='"+id+"' ";
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
            return View(lstroles);
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
        using (MySqlConnection con = new MySqlConnection(connectionString))    
        {    
            string query = "DELETE FROM purcharses WHERE purcharses.id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);            
            con.Open();    
            cmd.ExecuteNonQuery();
            con.Close();    
        }           
            return RedirectToAction("Index", "Purcharse");
        }
    
    }
}