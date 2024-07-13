using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Data
{
    /*
    Fields from routes.txt

        route_id,
        agency_id,
        route_short_name,
        route_long_name,
        route_desc,
        route_type,
        route_url,
        route_color,
        route_text_color
    
    
    */
    public class Route
    {
        [Key]
        public int route_id { get; set; }
        public string? agency_id { get; set; }
        public string? route_short_name { get; set; }
        public string? route_long_name { get; set; }
        public string? route_desc { get; set; }
        public string? route_type { get; set; }
        public string? route_url { get; set; }
        public string? route_color { get; set; }
        public string ?route_text_color { get; set; }


    }
}