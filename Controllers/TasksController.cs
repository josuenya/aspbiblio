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
    public class TasksController : Controller
    {
        private MySqlDatabase MySqlDatabase { get; set; }

        public TasksController(MySqlDatabase mySqlDatabase)
        {
            this.MySqlDatabase = mySqlDatabase;
        }

        [HttpPost] 
        public void Complete(dto.TaskIdentifier input)
        {
          var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"UPDATE Tasks SET Completed = STR_TO_DATE(@Date, '%Y/%m/%d') WHERE TaskId = @TaskId;";
          cmd.Parameters.AddWithValue("@TaskId", input.TaskId);
          cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy/MM/dd"));
          var recs = cmd.ExecuteNonQuery();
        }

        [HttpPost]
        public void Incomplete(dto.TaskIdentifier input)
        {
          var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"UPDATE Tasks SET Completed = NULL WHERE TaskId = @TaskId;";
          cmd.Parameters.AddWithValue("@TaskId", input.TaskId);

          var recs = cmd.ExecuteNonQuery();
        }

        [HttpPost]
        public void Archive(dto.TaskIdentifier input)
        {
          var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"UPDATE Tasks SET Archived = STR_TO_DATE(@Date, '%Y/%m/%d') WHERE TaskId = @TaskId;";
          cmd.Parameters.AddWithValue("@TaskId", input.TaskId);
          cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy/MM/dd"));
          var recs = cmd.ExecuteNonQuery();
        }

        }
}