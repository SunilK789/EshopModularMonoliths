using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Seed
{
    public static class InitialData
    {
        public static IEnumerable<Product> Products =>
            new List<Product>()
            {
                Product.Create(
                    id: new Guid("f9db7701-88ff-4ade-b3b7-4c92c435ad9c"),
                    name: "iPhone X",
                    category: new List<string> { "Electronics", "Smartphones" },
                    desc: "A premium smartphone with an edge-to-edge display and Face ID.",
                    imageFile: "iphone_x.jpg",
                    price: 1999.00m
                ),
                Product.Create(
                    id: new Guid("f94054e2-c8bc-45b3-98eb-eba1f1d27f8f"),
                    name: "MacBook Pro",
                    category: new List<string> { "Electronics", "Laptops" },
                    desc: "A high-performance laptop designed for professionals.",
                    imageFile: "macbook_pro.jpg",
                    price: 2499.00m
                ),
                Product.Create(
                    id: new Guid("890e6d93-2493-425d-b221-54da785635ce"),
                    name: "Samsung Galaxy S21",
                    category: new List<string> { "Electronics", "Smartphones" },
                    desc: "A flagship smartphone with an advanced camera system.",
                    imageFile: "galaxy_s21.jpg",
                    price: 1299.00m
                ),
                Product.Create(
                    id: new Guid("52590109-8a46-4b66-908d-e202c9462fb9"),
                    name: "Sony WH-1000XM5",
                    category: new List<string> { "Electronics", "Audio" },
                    desc: "Industry-leading noise-cancelling wireless headphones.",
                    imageFile: "sony_headphones.jpg",
                    price: 399.99m
                ),
                Product.Create(
                    id: new Guid("047d735b-80e6-4239-83fd-585ca16a72e6"),
                    name: "Apple Watch Series 8",
                    category: new List<string> { "Electronics", "Wearables" },
                    desc: "A smartwatch with advanced health tracking and fitness features.",
                    imageFile: "apple_watch.jpg",
                    price: 499.00m
                )
            };
    };
    
}
