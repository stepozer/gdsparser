using System.Collections.Generic;
using System.Xml.Serialization;

namespace InfrastuctureLayer.GdsModels
{
    public class TripsResponseModel
    {
        [XmlRoot(ElementName="Trip")]
        public class Trip {
            [XmlElement(ElementName="Supplier")]
            public string Supplier { get; set; }
            [XmlElement(ElementName="Fligth")]
            public string Fligth { get; set; }
        }

        [XmlRoot(ElementName="Trips")]
        public class Trips {
            [XmlElement(ElementName="Trip")]
            public List<Trip> Trip { get; set; }
        }
    }
}