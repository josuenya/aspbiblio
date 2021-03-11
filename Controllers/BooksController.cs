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

        //diplay all the book is saving in database
        private IEnumerable<Book> Getbook()    
        {   
            //creation d'une liste de book
            List<Book> lstbooks = new List<Book>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from books_autors ba,books b,autors a where ba.books_id = b.id and ba.autors_id = a.id";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader();  

                while (result.Read())    
                {    
                    Book books = new Book(); 
                    books.id = Convert.ToInt32(result["id"]);    
                    books.libelle = result["libelle"].ToString();    
                    books.description = result["description"].ToString();
                    books.qty = Convert.ToInt32(result["qty"]);         
                    books.autors_name = result["name"].ToString();          
                    books.created_at = Convert.ToDateTime(result["created_at"]);             
                    books.updated_at = Convert.ToDateTime(result["updated_at"]);             
                    
                    lstbooks.Add(books);    
                }    
                con.Close();    
            }    
            return lstbooks;    
        }

        //Permet d'afficher le formulaire d'ajout des livres
        public IActionResult Create()
        {
            List<Editor> lsteditor = new List<Editor>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from editors";
                MySqlCommand cmd = new MySqlCommand(query, con);    
                //cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader();  
    
                while (result.Read())    
                {    
                    Editor editors = new Editor(); 
                    editors.id = Convert.ToInt32(result["id"]);    
                    editors.name = result["name"].ToString(); 
                    lsteditor.Add(editors);    
                }    
                con.Close();    
            }   
            return View("Views/Books/Create.cshtml",lsteditor);
        }

        //enregistrement des des donnees provenant du formulaire en base de donnee
        public ActionResult Save(String libelle, String description,int qty,int editors_id)
        { 
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "INSERT INTO books (`libelle`,`description`,`qty`,`editors_id`) values('"+libelle+"','"+description+"','"+qty+"','"+editors_id+"')";
                MySqlCommand cmd = new MySqlCommand(query, con);            
                con.Open();    
                cmd.ExecuteNonQuery();
                con.Close();    
            }           
            return RedirectToAction("Index", "Books");
        }

        //Affiche la liste de tous les livres
        public IActionResult catalogue()
        {
            ViewBag.Title = "Nos Catalogues"; 
            List<Book> lstcatalogue = new List<Book>();    
            using (MySqlConnection con = new MySqlConnection(connectionString))    
            {    
                string query = "select * from books";
                MySqlCommand cmd = new MySqlCommand(query, con);             
                con.Open();    
                MySqlDataReader result = cmd.ExecuteReader();  
                while (result.Read())    
                {    
                    Book books = new Book(); 
                    books.id = Convert.ToInt32(result["id"]);    
                    books.libelle = result["libelle"].ToString();    
                    books.description = result["description"].ToString();
                    books.qty = Convert.ToInt32(result["qty"]);             
                    books.created_at = Convert.ToDateTime(result["created_at"]);             
                    books.updated_at = Convert.ToDateTime(result["updated_at"]);             
                    
                    lstcatalogue.Add(books);    
                }    
                con.Close();    
            }    

            return View("Views/Books/Catalogue.cshtml",lstcatalogue);
        }

    }
}
