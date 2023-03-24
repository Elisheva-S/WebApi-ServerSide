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
    public class Product_entity:Base_entity
    {
        ProductQueries queries=new ProductQueries();
        public Product_entity()
        {

        }
        public List<Product> GetAllProducts()
        {
            DataTable table=queries.GetAllProducts();
            return ConvertDataTableToProductList(table);
        }

        private List<Product> ConvertDataTableToProductList(DataTable table)
        {
            List<Product> list=new List<Product>();
            foreach (DataRow dr in table.Rows)
            {
                var values = dr.ItemArray;
                var Product = new Product()
                {
                    ProductId = (int)values[0],
                    ProductName = values[1].ToString(),
                    Price = (decimal)values[2],
                    InStock= (int)values[3],
                    DepartmentId= values[4].ToString(),
                };
                list.Add(Product);
            }
            return list;
       }

        public string PostProduct(Product Product)
        {
            return queries.PostProduct(Product);
        }
        public string EditProduct(Product Product)
        {
            return queries.EditProduct(Product);
        }
        public string DeleteProduct(int id)
        {
            return queries.DeleteProduct(id);
        }
    }
}
