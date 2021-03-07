using System;
namespace aspbiblio.Models
{
    public class Autor
    {
        public int id { get;set;}
        public string name {get;set;}
        public string phone { get;set;} 
        public DateTime created_at { get; set;} 
        public DateTime updated_at { get; set;} 
    }
}