using System.Xml.Serialization;

namespace MyPLEX.Models.XMLs
{
    [XmlRoot(ElementName = "Role")]
	public class Role
	{
		[XmlAttribute(AttributeName = "tag")]
		public string Tag { get; set; }
	}

}
