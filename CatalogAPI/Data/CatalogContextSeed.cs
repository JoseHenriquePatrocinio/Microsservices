using CatalogAPI.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CatalogAPI.Data
{
    public class CatalogContextSeed
    {

        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Camiseta",
                    Description = "Uma camiseta confortável e estilosa.",
                    Image = "caminho/para/imagem_camiseta.jpg",
                    Price = 29.99M,
                    Category = "Roupas"
                },

                new Product()
                {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Mouse",
                     Description = "Um mouse ergonômico e preciso para uso diário.",
                     Image = "caminho/para/imagem_mouse.jpg",
                     Price = 19.99M,
                     Category = "Acessórios"
                },


            };
        }
    }
}
