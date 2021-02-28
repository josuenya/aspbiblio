using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using aspbiblio.Data;

using Microsoft.AspNetCore.Mvc;

using MySql.Data.MySqlClient;

using dto = aspbiblio.Models;

namespace aspbiblio.Controllers
{
    public class BooksController : Controller
    {

        private MySqlDatabase MySqlDatabase { get; set; }

        public BooksController(MySqlDatabase mySqlDatabase)
        {
            this.MySqlDatabase = mySqlDatabase;
        }

        public IActionResult Index()
        {
            return View();
        }


        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
