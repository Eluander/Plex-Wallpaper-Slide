using System.Collections.Generic;

namespace MyPLEX.Models.JSONs
{
    public class MediaContainer
    {
        public int size { get; set; }
        public bool allowSync { get; set; }
        public string art { get; set; }
        public string identifier { get; set; }
        public int librarySectionID { get; set; }
        public string librarySectionTitle { get; set; }
        public string librarySectionUUID { get; set; }
        public string mediaTagPrefix { get; set; }
        public int mediaTagVersion { get; set; }
        public bool nocache { get; set; }
        public string thumb { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string viewGroup { get; set; }
        public int viewMode { get; set; }
        public List<Metadata> Metadata { get; set; }
    }
}
