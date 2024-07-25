using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    // shape_id
    // shape_pt_lat
    // shape_pt_lon
    // shape_pt_sequence
    // shape_dist_traveled
    public class Shape
    {
        [Key]
        public int shape_id { get; set; }
        public string shape_pt_lat { get; set; }
        public string shape_pt_lon { get; set; }
        public string shape_pt_sequence { get; set; }
        public string shape_dist_traveled { get; set; }


    }
}