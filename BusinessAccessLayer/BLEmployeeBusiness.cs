using CommanLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BusinessAccessLayer
{
    public class BLEmployeeBusiness
    {
        private EmployeeDataAccessDb employeeData;
        public BLEmployeeBusiness()
        {
            employeeData = new EmployeeDataAccessDb();
        }
         public List<Employyes> GetEmployees()
         { 
             return employeeData.GetEmployees();
         }
    }
}
