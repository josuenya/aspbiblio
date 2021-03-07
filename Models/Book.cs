using System;


namespace aspbiblio.Models
{
    public class Book
    {
        public int id { get; set; }
        public string libelle { get; set; }
        public string description { get; set; }
        public decimal PU { get; set; }
        public int qty { get; set;} 
        public DateTime created_at { get; set;} 
        public DateTime updated_at { get; set;} 

        //attribute not in Books table
        public string autors_name {get; set;}

    }
}