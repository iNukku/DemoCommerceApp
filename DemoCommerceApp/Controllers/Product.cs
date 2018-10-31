namespace DemoCommerceApp.Controllers
{
    public class Product
    {
        public Product(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}