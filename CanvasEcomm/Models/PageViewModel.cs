using CanvasEcomm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanvasEcomm.Models
{
    public class PageViewModel
    {
        public PageViewModel(string category, string title, string tagline)
        {
            this.Title = title;
            this.Tagline = tagline;
            this.Category = category;

            ProductService ps = new ProductService();
            if(category.Equals("Sale"))
            {
                this.Products = ps.ProductList.Where(x => x.OnSale == true);
            } else
            {
                this.Products = ps.ProductList.Where(x => x.Category.Equals(category.ToLower()));
            }            
        }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Tagline { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}