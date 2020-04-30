using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using BasicSerialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookCatalogSerializerTests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            var catalog = serializer.Deserialize(new FileStream("books.xml", FileMode.Open)) as Catalog;
            using (var stream = new FileStream("booksSerialized.xml", FileMode.Create))
            {
                serializer.Serialize(stream, catalog);
            }
        }
        
        [TestMethod]
        public void DeserializeTest()
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            var catalog = serializer.Deserialize(new FileStream("books.xml", FileMode.Open)) as Catalog;
            Assert.IsTrue(catalog.Books.Length > 0);
        }
    }
}
