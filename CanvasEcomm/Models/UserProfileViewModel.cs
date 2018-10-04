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
            this.Title = facet.AssistKey;
            this.Tagline = tagline;
            this.Category = "UserProfile";

            this.Items = DataServices.UserExperienceData.Where(x => x.AssistKey.Equals(facet.AssistKey));
                        
        }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Tagline { get; set; }

        public IEnumerable<DataRecord> Items { get; set; }
    }
}