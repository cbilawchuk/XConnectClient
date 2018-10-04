using CanvasEcomm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanvasEcomm.Services
{
    public static class DataServices
    {
        private static List<DataRecord> _data = new List<DataRecord>();


        
        public static IEnumerable<DataRecord> UserExperienceData
        {
            get
            {
                return _data;
            }
        }


        public static void Add(DataRecord record)
        {
            _data.Add(record);
        }

        public static void Update(DataRecord record)
        {
            var index = _data.FindIndex(c => c.ID == record.ID);
            _data[index] = record;
        }

        public static DataRecord Find(string Id)
        {
            return _data.Find(c => c.ID.Equals(Id));
        }

        public static bool Exists(string Id)
        {
            var item = _data.Find(c => c.ID.Equals(Id));
            if(item != null)
            {
                return true;
            }
            return false;
        }

    }



   public class DataRecord
   {
        public string ID { get; set; }
        public string AssistKey { get; set; }
        public Product Product { get; set; }
        public int EngagementScore { get; set; }
    }
}