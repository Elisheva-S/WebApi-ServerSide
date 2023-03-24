using Microsoft.AspNetCore.Mvc;
using Model;
using SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Department_entity:Base_entity
    {
        DepartmentQueries query=new DepartmentQueries();
        public List<Department> GetAllDepartments()
        {
            DataTable table = query.GetAllDepartments();
            return ConvertDataTableToDeprtmentList(table);
        }
            private List<Department> ConvertDataTableToDeprtmentList(DataTable table)
        {
            List<Department> list = new List<Department>();
            foreach (DataRow dr in table.Rows)
            {
                var values = dr.ItemArray;
                var dep = new Department()
                {
                    DepartmentId = (int)values[0],
                    DepartmentName = values[1].ToString(),
                    Description = values[2].ToString()
                };
                list.Add(dep);
            }
            return list;
        }

        public string PostDepartment(Department department)
        {
            return query.PostDepartment(department);
        }
        public string EditDep(Department department)
        {
            return query.EditDep(department);
        }
        public string DeleteDep(int depId)
        {
            return query.DeleteDepartment(depId);
        }

    }
}
