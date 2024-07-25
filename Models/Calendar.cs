using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    // service_id,
    // monday,
    // tuesday,
    // wednesday,
    // thursday,
    // friday,
    // saturday,
    // sunday,
    // start_date,
    // end_date
    public class Calendar
    {
        [Key]
        public int service_id { get; set; }
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
        public string saturday { get; set; }
        public string sunday { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }
}