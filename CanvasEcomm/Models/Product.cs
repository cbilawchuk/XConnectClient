using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanvasEcomm.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Name { get; set; }
        public MvcHtmlString Description { get; set; }
        public double MSRP { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public string SKU { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Classification { get; set; }
        public IEnumerable<string> Images { get; set; }

    }
}