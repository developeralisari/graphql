namespace GraphQL
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
