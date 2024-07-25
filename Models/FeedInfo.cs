using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gtfs_api.Models
{
    // feed_publisher_name
    // feed_publisher_url
    // feed_lang
    // feed_start_date
    // feed_end_date
    // feed_version
    public class FeedInfo
    {
        public string feed_publisher_name { get; set; }
        public string feed_publisher_url { get; set; }
        public string feed_lang { get; set; }
        public string feed_start_date { get; set; }
        public string feed_end_date { get; set; }
        public string feed_version { get; set; }

    }
}