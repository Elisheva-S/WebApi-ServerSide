namespace Model
{
    public class Product : Base_Model
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public string DepartmentId { get; set; }
        public Product(int ProductId, string ProductName, int price, int inStock, string departmentId)
        {
            ProductId = ProductId;
            ProductName = ProductName;
            Price = price;
            InStock = inStock;
            DepartmentId = departmentId;
        }
        public Product() { }
    }
}
