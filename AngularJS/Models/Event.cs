using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJS.Models
{
    public class Event
    {
        public string name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public Location location { get; set; }
        public string imageUrl { get; set; }
        public List<Session> sessions { get; set; }
    }

    public class Location
    {
        public string address { get; set; }
        public string city { get; set; }
        public string province { get; set; }
    }

    public class Session
    {
        public string name { get; set; }
        public string creatorName { get; set; }
        public int duration { get; set; }
        public string level { get; set; }
        public string description { get; set; }
        public int upVoteCount { get; set; }
    }

}