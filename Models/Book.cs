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
        public int editor_id { get; set;}
        public int autor_id { get; set;}
    }
}