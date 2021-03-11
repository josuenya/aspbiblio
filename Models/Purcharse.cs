using System;

namespace aspbiblio.Models
{
    public class Purcharse
    {
        public int id { get; set;}
        public int book_id { get; set;}
        public decimal buying_price { get; set;}
        public int qty { get; set;}

        public DateTime created_at { get; set;} 
        public DateTime updated_at { get; set;} 

        //not in table
        public string libelle {get;set;}
    }
}