using CanvasEcomm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanvasEcomm.Services
{
    public class ProductService
    {
        private List<Product> _products;


        public ProductService()
        {
            _products = new List<Product>();


            var p1 = new Product
            {
                ID = 1,
                Category = "men",
                Name = "Slim FitChinos",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 39.99,
                Price = 39.99,
                OnSale = false,
                SKU = "10001ABC-01",
                Size = "Small, Medium, large",
                Color = "Khaki",
                Images = new List<string> { "/images/shop/pants/1-1.jpg", "/images/shop/pants/1.jpg" }
            };
            _products.Add(p1);

            var p2 = new Product
            {
                ID = 2,
                Category = "men",
                Name = "Blue Round-Neck Tshirt",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 19.99,
                Price = 19.99,
                OnSale = false,
                SKU = "10001ABC-02",
                Size = "Small, Medium, large",
                Color = "Blue",
                Images = new List<string> { "/images/shop/tshirts/1.jpg", "/images/shop/tshirts/1-1.jpg" }
            };
            _products.Add(p2);

            var p3 = new Product
            {
                ID = 3,
                Category = "men",
                Name = "Green Trousers",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 24.99,
                Price = 20.99,
                OnSale = true,
                SKU = "10001ABC-03",
                Size = "Small, Medium, large",
                Color = "Green",
                Images = new List<string> { "/images/shop/pants/5.jpg", "/images/shop/pants/5-1.jpg" }
            };
            _products.Add(p3);


            var p4 = new Product
            {
                ID = 4,
                Category = "men",
                Name = "Black Polo Shirt",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 32.99,
                Price = 32.99,
                OnSale = false,
                SKU = "10001ABC-04",
                Size = "Medium",
                Color = "Black",
                Images = new List<string> { "/images/shop/tshirts/4.jpg", "/images/shop/tshirts/4-1.jpg" }
            };
            _products.Add(p4);

            var p5 = new Product
            {
                ID = 5,
                Category = "accessories",
                Name = "Silver Chrome Watch",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 229.99,
                Price = 129.99,
                OnSale = true,
                SKU = "10001ABC-05",
                Size = "Big",
                Color = "Silver",
                Images = new List<string> { "/images/shop/watches/1.jpg", "/images/shop/watches/1-1.jpg" }
            };
            _products.Add(p5);


            var p6 = new Product
            {
                ID = 6,
                Category = "women",
                Name = "Pink Printed Dress",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 65.99,
                Price = 65.99,
                OnSale = false,
                SKU = "10001ABC-06",
                Size = "Small, Medium",
                Color = "Pink, Light Pink",
                Images = new List<string> { "/images/shop/dress/3.jpg", "/images/shop/dress/3-1.jpg" }
            };
            _products.Add(p6);

            var p7 = new Product
            {
                ID = 7,
                Category = "women",
                Name = "Light Blue Denim Dress",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 48.99,
                Price = 32.99,
                OnSale = true,
                SKU = "10001ABC-07",
                Size = "Small, Medium, Large",
                Color = "Blue Denm",
                Images = new List<string> { "/images/shop/dress/2.jpg", "/images/shop/dress/2-2.jpg" }
            };
            _products.Add(p7);


            var p8 = new Product
            {
                ID = 8,
                Category = "women",
                Name = "Checked Short Dress",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 32.99,
                Price = 18.99,
                OnSale = true,
                SKU = "10001ABC-08",
                Size = "Small, Medium",
                Color = "Gre, White, Blue",
                Images = new List<string> { "/images/shop/dress/1.jpg", "/images/shop/dress/1-1.jpg" }
            };
            _products.Add(p8);


            var p9 = new Product
            {
                ID = 9,
                Category = "accessories",
                Name = "Unisex Sunglasses",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 19.99,
                Price = 12.99,
                OnSale = true,
                SKU = "10001ABC-09",
                Size = "Standard",
                Color = "Silver",
                Images = new List<string> { "/images/shop/sunglasses/1.jpg", "/images/shop/sunglasses/1-1.jpg" }
            };
            _products.Add(p9);

            var p10 = new Product
            {
                ID = 10,
                Category = "accessories",
                Name = "Professional Aviator Sunglasses",
                Description = new MvcHtmlString("<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>"),
                MSRP = 229.99,
                Price = 229.99,
                OnSale = false,
                SKU = "10001ABC-10",
                Size = "Standard",
                Color = "Silver",
                Images = new List<string> { "/images/shop/sunglasses/2.jpg", "/images/shop/sunglasses/2-1.jpg" }
            };
            _products.Add(p10);

            this.ProductList = _products;
        }


        public IEnumerable<Product> ProductList { get; set; }
    }
}