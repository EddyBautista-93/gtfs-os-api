using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    // service_id,
    // date,
    // exception_type
    public class CalendarDate
    {
        [Key]
        public int service_id { get; set; }
        public string date { get; set; }
        public string exception_type { get; set; }

    }
}