using System;
namespace aspbiblio.Models
{
    public class Loan
    {
        public int id { get; set;}
        public int users_id { get;set;}
        public int books_id { get;set;}
        public string status { get;set;}
        public DateTime return_date { get;set;}
        public DateTime created_at { get; set;}
        public DateTime updated_at { get; set;}

        //attributte non in Loan table
        public string users_name {get;set;}
        public string libelle {get;set;}

    }
}