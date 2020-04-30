﻿using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BasicSerialization
{
    [Serializable]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date", DataType = "date")] 
        public DateTime PublishDate { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date", DataType = "date")] 
        public DateTime RegistrationDate { get; set; }
    }

    public enum Genre
    {
        [XmlEnum(Name = "Fantasy")]
        Fantasy,
        [XmlEnum(Name = "Romance")]
        Romance,
        [XmlEnum(Name = "Horror")]
        Horror,
        [XmlEnum(Name = "Computer")]
        Computer,
        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction
    }
}



