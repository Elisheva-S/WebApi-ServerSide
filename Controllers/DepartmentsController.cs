using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using System.Data;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.Intrinsics.Arm;
using Model;
using Entities;

namespace WebApi_ServerSide.Controllers
{
    public class DepartmentsController : Controller
    {
        Department_entity departmentEntity = new Department_entity();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("getAllDepartments")]

        public JsonResult Get()
        {
            return new JsonResult(departmentEntity.GetAllDepartments());
        }
        [HttpPost("postDepartment")]
        public JsonResult Post([FromBody] Department department)
        {
            return new JsonResult(departmentEntity.PostDepartment(department));            
        }

        [HttpPut("editDepartment")]
        public JsonResult Put([FromBody] Department department)
        {
            return new JsonResult(departmentEntity.EditDep(department));
        }

        [HttpDelete("deleteDepatrment")]
        public JsonResult Delete(int departmentId)
        {
            return new JsonResult(departmentEntity.DeleteDep(departmentId));           
        }
        
    }
}
