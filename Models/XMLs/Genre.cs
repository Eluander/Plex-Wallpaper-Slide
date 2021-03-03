using System.Xml.Serialization;

namespace MyPLEX.Models.XMLs
{
    [XmlRoot(ElementName = "Genre")]
	public class Genre
	{
		[XmlAttribute(AttributeName = "tag")]
		public string Tag { get; set; }
	}
}
