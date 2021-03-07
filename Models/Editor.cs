using System;

namespace aspbiblio.Models
{
    public class Editor
    {
        public int id { get;set;}
        public string name { get;set;}
        public string adress { get;set;}
        public string city { get;set;}
        public DateTime created_at { get; set;} 
        public DateTime updated_at { get; set;} 
    }
}