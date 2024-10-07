namespace GraphQL
{
    public class Query
    {
        private List<Category> categories = new List<Category>
        {
            new Category
            {
                id = 1,
                Name = "Yemekler",
                Products = new List<Product>
                {
                    new Product { id = 1, Name = "Adana Kebabı", Price = 120.50M, Categoryid = 1 },
                    new Product { id = 2, Name = "İskender", Price = 150.75M, Categoryid = 1 },
                    new Product { id = 3, Name = "Lahmacun", Price = 45.00M, Categoryid = 1 }
                }
            },
            new Category
            {
                id = 2,
                Name = "İçecekler",
                Products = new List<Product>
                {
                    new Product { id = 4, Name = "Ayran", Price = 10.00M, Categoryid = 2 },
                    new Product { id = 5, Name = "Kola", Price = 15.00M, Categoryid = 2 },
                    new Product { id = 6, Name = "Su", Price = 5.00M, Categoryid = 2 }
                }
            }
        };

        // Tüm kategorileri getir
        public List<Category> GetCategories() => categories;

        // Belirli bir kategorideki ürünleri getir
        public Category GetCategoryById(int id) => categories.FirstOrDefault(c => c.id == id);
    }

}
