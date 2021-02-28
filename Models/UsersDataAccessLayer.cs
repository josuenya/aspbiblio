    using System;    
    using System.Collections.Generic;    
    using System.Data;    
    using MySql.Data.MySqlClient;   
    using System.Linq;    
    using System.Threading.Tasks;    
    using aspbiblio.Data;
    
    namespace aspbiblio.Models    
    {    
        public class UsersDataAccessLayer    
        {    
        private string connectionString = "server=localhost; database=mybookshop; uid=root; pwd=;SslMode = none";

            //To View all Users details      
            public IEnumerable<Users> GetAllUsers()    
            {    
                List<Users> lstusers = new List<Users>();    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    MySqlCommand cmd = new MySqlCommand("spGetAllEmployees", con);    
                    cmd.CommandType = CommandType.StoredProcedure;            
                    con.Open();    
                    MySqlDataReader rdr = cmd.ExecuteReader();    
        
                    while (rdr.Read())    
                    {    
                        Users users = new Users();    
        
                        users.id = Convert.ToInt32(rdr["EmployeeID"]);    
                        users.name = rdr["Name"].ToString();    
                        users.username = rdr["Gender"].ToString();    
                        users.phone = rdr["Department"].ToString();    
                        users.email = rdr["City"].ToString();    
        
                        lstusers.Add(users);    
                    }    
                    con.Close();    
                }    
                return lstusers;    
            }    
        
            //To Add new employee record      
            public void AddUsers(Users users)    
            {    
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    MySqlCommand cmd = new MySqlCommand("spAddEmployee", con);    
                    cmd.CommandType = CommandType.StoredProcedure;    
        
                    cmd.Parameters.AddWithValue("@Name", users.name);    
                    cmd.Parameters.AddWithValue("@Gender", users.username);    
                    cmd.Parameters.AddWithValue("@Department", users.phone);    
                    cmd.Parameters.AddWithValue("@City", users.email);    
        
                    con.Open();    
                    cmd.ExecuteNonQuery();    
                    con.Close();    
                }    
            }    
        
            //To Update the records of a particluar employee    
            public void UpdateEmployee(Users users)    
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    MySqlCommand cmd = new MySqlCommand("spUpdateEmployee", con);    
                    cmd.CommandType = CommandType.StoredProcedure;    
        
                    // cmd.Parameters.AddWithValue("@EmpId", users.id);    
                    cmd.Parameters.AddWithValue("@Name", users.name);    
                    cmd.Parameters.AddWithValue("@Gender", users.email);    
                    cmd.Parameters.AddWithValue("@Department", users.phone);    
                    cmd.Parameters.AddWithValue("@City", users.password);    
                    cmd.Parameters.AddWithValue("@City", users.roles_id); 
                    con.Open();    
                    cmd.ExecuteNonQuery();    
                    con.Close();    
                }    
            }    
        
            //Get the details of a particular employee    
            public Users GetUsersData(int? id)    
            {    
                Users users = new Users();    
            
                using (MySqlConnection con = new MySqlConnection())    
                {    
                    string sqlQuery = "SELECT * FROM users WHERE users.id= " + id;    
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);    
        
                    con.Open();    
                    MySqlDataReader rdr = cmd.ExecuteReader();    
        
                    while (rdr.Read())    
                    {    
                        users.id = Convert.ToInt32(rdr["EmployeeID"]);    
                        users.name = rdr["Name"].ToString();    
                        users.email = rdr["Gender"].ToString();    
                        users.phone = rdr["Department"].ToString();    
                        users.username = rdr["City"].ToString();    
                    }    
                }    
                return users;    
            }    
        
            //To Delete the record on a particular users    
            public void DeleteUsers(int? id)    
            {            
                using (MySqlConnection con = new MySqlConnection(connectionString))    
                {    
                    MySqlCommand cmd = new MySqlCommand("spDeleteEmployee", con);    
                    cmd.CommandType = CommandType.StoredProcedure;   
        
                    cmd.Parameters.AddWithValue("@EmpId", id);    
        
                    con.Open();    
                    cmd.ExecuteNonQuery();    
                    con.Close();    
                }    
            }    
        }    
    }    
