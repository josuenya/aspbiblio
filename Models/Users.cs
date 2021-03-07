using System;    
using System.Collections.Generic;    
using System.ComponentModel.DataAnnotations;    
using System.Linq;    
using System.Threading.Tasks; 

namespace aspbiblio.Models
{
    public class Users
    {
        public int id {get;set;}

        [Required]
        public string name {get;set;}
        public string username {get;set;}

        [Required]
        public string email  {get;set;}

        [Required]
        public string phone {get;set;}

        [Required]
        public string password  {get;set;}

        [Required]
        public int roles_id {get;set;}

        public string roles {get;set;}
        public DateTime created_at { get; set;} 
        public DateTime updated_at { get; set;}
    }
}