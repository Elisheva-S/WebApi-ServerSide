using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class DepartmentQueries : Base_SQL
    {
        public DataTable GetAllDepartments()
        {
            string query = @"exec getAlldep";
            DataTable departmentsTable = new DataTable();
            SqlQuery.RunCommand(query, departmentsTable.Load);


            return departmentsTable;
        }
        public string PostDepartment(Department department)
        {
            string query = $"exec addNewDepartment '{department.DepartmentName}','{department.Description}'";
            DataTable dataTable = new DataTable();
            SqlQuery.RunCommand(query, dataTable.Load);

            return "departmentOK";
        }
        public string EditDep(Department department)
        {
            string query = $"exec editDepartment {department.DepartmentId},'{department.DepartmentName}','{department.Description}'";
            DataTable dataTable = new DataTable();
            SqlQuery.RunCommand(query, dataTable.Load);
            return "EditDep";
        }
        public string DeleteDepartment(int departmentId)
        {
            string query = $"exec deleteFromDepartments {departmentId}";
            DataTable dataTable = new DataTable();
            SqlQuery.RunCommand(query, dataTable.Load);
            return "department deleted";
        }
       
    }
}
