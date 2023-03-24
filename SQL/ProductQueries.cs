using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Data;

namespace SQL
{
    public class ProductQueries:Base_SQL
    {
        public DataTable GetAllProducts()
        {
            string query = @"exec getAllItems";
            DataTable ProductsTable = new DataTable();
            SqlQuery.RunCommand(query, ProductsTable.Load);
            return ProductsTable;
        }
        public string PostProduct(Product Product)
        {
            string query = $"exec postItem '{Product.ProductName}',{Product.Price},{Product.InStock},{Product.DepartmentId}";
            DataTable dataTable = new DataTable();
            SqlQuery.RunCommand(query, dataTable.Load);

            return"ProductOK";
        }
        public string EditProduct(Product Product)
        {
            string query = $"exec editItem {Product.ProductId},'{Product.ProductName}',{Product.Price},{Product.InStock},{Product.DepartmentId}";
            DataTable dataTable = new DataTable();
            SqlQuery.RunCommand(query, dataTable.Load);
            return "EditProduct";
        }
        public string DeleteProduct(int ProductId)
        {
            string query = $"exec deleteItem {ProductId}";
            DataTable dataTable = new DataTable();
            SqlQuery.RunCommand(query, dataTable.Load);
            return "Product deleted";
        }
    }
}