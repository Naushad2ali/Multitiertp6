using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using CommanLayer.Models;

namespace DataAccessLayer
{
    public  class EmployeeDataAccessDb
    {
        private DbConnection db = new DbConnection();
        public List <Employyes> GetEmployees()
        {
            string query = "select *from Employees";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.Cnn;
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Employees> employees = new List<Employees>();
            while(reader.Read())
            {
                Employees emp = new Employees();
                emp.Id = (int)reader["Id"];
                emp.Name = reader["Name"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.Address = reader["Address"].ToString();
                employees.Add(emp);
                

            }
            db.Cnn.Close();
            return Employees;
        

       
        }
    }
}
