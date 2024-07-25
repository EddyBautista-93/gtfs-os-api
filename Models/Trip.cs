using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    // route_id
    // service_id
    // trip_id
    // trip_headsign
    // trip_short_name
    // direction_id
    // block_id
    // shape_id
    // wheelchair_accessible
    // bikes_allowed

    public class Trip
    {
        [Key]
        public int route_id { get; set; }
        public string service_id { get; set; }
        public string trip_id { get; set; }
        public string trip_headsign { get; set; }
        public string trip_short_name { get; set; }
        public string direction_id { get; set; }
        public string block_id { get; set; }
        public string shape_id { get; set; }
        public string wheelchair_accessible_id { get; set; }
        public string bikes_allowed { get; set; }

    }
}