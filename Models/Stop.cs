using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    stop_id
    stop_code
    stop_name
    stop_desc
    stop_lat
    stop_lon
    zone_id
    stop_url
    location_type
    parent_station
    stop_timezone
    wheelchair_boarding

    public class Stop
    {
        [Key]
        public int stop_id { get; set; }
        public string stop_code { get; set; }
        public string stop_name { get; set; }
        public string stop_desc { get; set; }
        public string stop_lat { get; set; }
        public string stop_lon { get; set; }
        public string zone_id { get; set; }
        public string stop_url { get; set; }
        public string location_type { get; set; }
        public string parent_station { get; set; }
        public string stop_timezone { get; set; }
        public string wheelchair_boarding { get; set; }
    }
}