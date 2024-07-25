using System.ComponentModel.DataAnnotations;

namespace gtfs_api.Models
{
    // trip_id
    // arrival_time
    // departure_time
    // stop_id
    // stop_sequence
    // stop_headsign
    // pickup_type
    // drop_off_type
    // shape_dist_traveled
    // timepoint

    public class StopTime
    {
        [Key]
        public int trip_id { get; set; }
        public string arrival_time { get; set; }
        public string departure_time { get; set; }
        public string stop_id { get; set; }
        public string stop_sequence { get; set; }
        public string stop_headsign { get; set; }
        public string pickup_type { get; set; }
        public string drop_off_type { get; set; }
        public string shape_dist_traveled { get; set; }
        public string timepoint { get; set; }

    }
}