using System;
namespace aspbiblio.Models
{
    public class Loan
    {
        public int id { get; set;}
        public int user_id { get;set;}
        public int book_id { get;set;}
        public DateTime loan_date { get; set;}
        public DateTime return_date { get;set;}
        // public Date
    }
}