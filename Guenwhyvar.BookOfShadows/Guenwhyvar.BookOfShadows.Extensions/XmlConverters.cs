#nullable disable
using System.Xml.Serialization;

namespace Guenwhyvar.BookOfShadows.Extensions
{
    public static class XmlConverters
    {
        public static string GetXmlString<T>(this T template)
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(template.GetType());
                serializer.Serialize(stringwriter, template);
                return stringwriter.ToString();
            }
        }
        public static T GetObjectFromXmlString<T>(this string xmlString)
        {
            using (var stringReader = new System.IO.StringReader(xmlString))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }
    }
}
