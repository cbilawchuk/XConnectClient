using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanvasEcomm.Models
{
    public class ProductCustomFacet
    {

        public string AssistKey { get; set; }
        public IEnumerable<string> SKU_History { get; set; }
        
    }
}