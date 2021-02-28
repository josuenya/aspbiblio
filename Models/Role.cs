using System;

namespace aspbiblio.Models
{
    public class Role
    {
        public int id {get;set;}
        public string libelle {get;set;}
        public string description {get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}

    }
}