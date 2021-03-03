using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyPLEX.Models.XMLs
{
    [XmlRoot(ElementName = "Directory")]
	public class Directory
	{
		[XmlElement(ElementName = "Genre")]
		public List<Genre> Genre { get; set; }
		[XmlElement(ElementName = "Role")]
		public List<Role> Role { get; set; }
		[XmlAttribute(AttributeName = "ratingKey")]
		public string RatingKey { get; set; }
		[XmlAttribute(AttributeName = "key")]
		public string Key { get; set; }
		[XmlAttribute(AttributeName = "guid")]
		public string Guid { get; set; }
		[XmlAttribute(AttributeName = "studio")]
		public string Studio { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "contentRating")]
		public string ContentRating { get; set; }
		[XmlAttribute(AttributeName = "summary")]
		public string Summary { get; set; }
		[XmlAttribute(AttributeName = "index")]
		public string Index { get; set; }
		[XmlAttribute(AttributeName = "rating")]
		public string Rating { get; set; }
		[XmlAttribute(AttributeName = "userRating")]
		public string UserRating { get; set; }
		[XmlAttribute(AttributeName = "viewCount")]
		public string ViewCount { get; set; }
		[XmlAttribute(AttributeName = "lastViewedAt")]
		public string LastViewedAt { get; set; }
		[XmlAttribute(AttributeName = "lastRatedAt")]
		public string LastRatedAt { get; set; }
		[XmlAttribute(AttributeName = "year")]
		public string Year { get; set; }
		[XmlAttribute(AttributeName = "thumb")]
		public string Thumb { get; set; }
		[XmlAttribute(AttributeName = "art")]
		public string Art { get; set; }
		[XmlAttribute(AttributeName = "banner")]
		public string Banner { get; set; }
		[XmlAttribute(AttributeName = "theme")]
		public string Theme { get; set; }
		[XmlAttribute(AttributeName = "duration")]
		public string Duration { get; set; }
		[XmlAttribute(AttributeName = "originallyAvailableAt")]
		public string OriginallyAvailableAt { get; set; }
		[XmlAttribute(AttributeName = "leafCount")]
		public string LeafCount { get; set; }
		[XmlAttribute(AttributeName = "viewedLeafCount")]
		public string ViewedLeafCount { get; set; }
		[XmlAttribute(AttributeName = "childCount")]
		public string ChildCount { get; set; }
		[XmlAttribute(AttributeName = "addedAt")]
		public string AddedAt { get; set; }
		[XmlAttribute(AttributeName = "updatedAt")]
		public string UpdatedAt { get; set; }
		[XmlAttribute(AttributeName = "titleSort")]
		public string TitleSort { get; set; }
	}
}
