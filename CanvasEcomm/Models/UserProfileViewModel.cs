using CanvasEcomm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanvasEcomm.Models
{
    public class UserProfileViewModel
    {
        public UserProfileViewModel(ProductCustomFacet facet, string tagline)
        {
            this.Title = facet.AccountID;
            this.Tagline = tagline;
            //this.Category = category;

            ProductService ps = new ProductService();

            List<Product> userProductsList = new List<Product>();

            foreach(var sku in facet.SKU_History)
            {
                userProductsList.Add(ps.ProductList.Where(x => x.SKU.ToLower().Equals(sku.ToLower())).FirstOrDefault());
            }

            this.Products = userProductsList;
                        
        }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Tagline { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}