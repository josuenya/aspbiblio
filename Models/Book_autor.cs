using System;

namespace aspbiblio.Models
{
    public class Book_autor
    {
        public int id { get; set;}
        public int books_id { get; set;}
        public int autors_id { get; set;}
        public DateTime created_at { get; set;} 
        public DateTime updated_at { get; set;} 
        
    }
}