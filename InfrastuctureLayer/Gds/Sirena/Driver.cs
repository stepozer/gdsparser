using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InfrastuctureLayer.Gds.Sirena
{
    public class Driver : IDriver
    {
        private readonly Client _client;

        public Driver(Client client)
        {
            _client = client;
        }
        
        public List<Models.TripModel> Trips()
        {
            var response = _client.Request("Trips");
            var serializer = new XmlSerializer(typeof(GdsModels.TripsResponseModel.Trips));
            var rawTrips = (GdsModels.TripsResponseModel.Trips) serializer.Deserialize(new StringReader(response));
            var trips = new List<Models.TripModel>();
            foreach (var rawTrip in rawTrips.Trip)
            {
                trips.Add(new Models.TripModel {Supplier = rawTrip.Supplier, Fligth = rawTrip.Fligth});
            }
            return trips;
        }

        public string FareCondition()
        {
            throw new System.NotImplementedException();
        }
    }
}