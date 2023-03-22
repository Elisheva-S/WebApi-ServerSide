using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Data;

namespace WebApi_ServerSide.Controllers
{
    public class ProductController : Controller
    {
        Product_entity ProductEntity = new Product_entity();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getAllProducts")]

        public JsonResult Get()
        {
            return new JsonResult(ProductEntity.GetAllProducts());
        }
        [HttpPost("postProduct")]
        public JsonResult Post([FromBody] Product Product)
        {
            return new JsonResult(ProductEntity.PostProduct(Product));
        }
        [HttpPut("EditProduct")]
        public JsonResult Put([FromBody] Product Product)
        {
            return new JsonResult (ProductEntity.EditProduct(Product));           
        }
        [HttpDelete("deleteProduct")]
        public JsonResult Delete(int ProductId)
        {
            return new JsonResult(ProductEntity.DeleteProduct(ProductId));
        }
    }
}
