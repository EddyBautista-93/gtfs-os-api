using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    // agency_id,agency_name,agency_url,agency_timezone,agency_lang,agency_phone,agency_fare_url
    public class Agency
    {
        public int agency_id { get; set; }
        public string agency_name { get; set; }
        public string agency_url { get; set; }
        public string agency_timezone { get; set; }
        public string agency_lang { get; set; }
        public string agency_phone { get; set; }
        public string agency_fare_url { get; set; }

    }
}