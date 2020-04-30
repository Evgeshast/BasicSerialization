using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    [Serializable()]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlAttribute("date")]
        public DateTime Date { get; set; }

        [XmlElement("book", typeof(Book))]
        public Book[] Books { get; set; }
    }
}
