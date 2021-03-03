using System.Collections.Generic;

namespace MyPLEX.Models.JSONs
{
    public class Metadata
    {
        public string ratingKey { get; set; }
        public string key { get; set; }
        public string guid { get; set; }
        public string studio { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string contentRating { get; set; }
        public string summary { get; set; }
        public int index { get; set; }
        public double rating { get; set; }
        public double userRating { get; set; }
        public int viewCount { get; set; }
        public int lastViewedAt { get; set; }
        public int lastRatedAt { get; set; }
        public int year { get; set; }
        public string thumb { get; set; }
        public string art { get; set; }
        public string banner { get; set; }
        public string theme { get; set; }
        public int duration { get; set; }
        public string originallyAvailableAt { get; set; }
        public int leafCount { get; set; }
        public int viewedLeafCount { get; set; }
        public int childCount { get; set; }
        public int addedAt { get; set; }
        public int updatedAt { get; set; }
        public List<Genre> Genre { get; set; }
        public List<Role> Role { get; set; }
        public string titleSort { get; set; }
    }
}
