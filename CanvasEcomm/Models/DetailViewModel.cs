using CanvasEcomm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanvasEcomm.Models
{
    public class DetailViewModel
    {
        public DetailViewModel(string sku)
        {
            ProductService ps = new ProductService();
            this.Product = ps.ProductList.Where(x => x.SKU.Equals(sku)).FirstOrDefault();                        
        }

        public Product Product { get; set; }
        public bool ShowPopup { get; set; }
    }
}