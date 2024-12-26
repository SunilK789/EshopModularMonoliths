using Catalog.Products.Events;

namespace Catalog.Products.Models
{
    public class Product: Aggregate<Guid>
    {
        public string Name { get; private set; } = default!;
        public List<string> Category { get; private set; } = new List<string>();
        public string Description {get; private set; }
        public string ImgaeFile { get; private set; }
        public decimal Price { get; private set; }

        public static Product Create(Guid id, string name, List<string> category, string desc, string imageFile, decimal price)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

            var product = new Product
            {
                Id = id,
                Name = name,
                Category = category,
                Description = desc,
                ImgaeFile = imageFile,
                Price = price
            };

            product.AddDomainEvent(new ProductCreatedEvent(product));

            return product;
        }

        public void Update(string name, List<string> category, string desc, string imageFile, decimal price)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);


            Name = name;
            Category = category;
            Description = desc;
            ImgaeFile = imageFile;
            Price = price;

            if(Price != price)
            {
                Price = price;
                AddDomainEvent(new ProductPriceChangedEvent(this));
            }
        }
    }
}
