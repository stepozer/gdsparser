using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InfrastuctureLayer.Gds.Sirena
{
    public class Driver
    {
        public List<Models.TripModel> Trips()
        {
            var response = @"
                <Trips>
                  <Trip>
                    <Supplier>SU</Supplier>
                    <Fligth>10</Fligth>
                  </Trip>
                  <Trip>
                    <Supplier>S7</Supplier>
                    <Fligth>11</Fligth>
                  </Trip>
                  <Trip>
                    <Supplier>N4</Supplier>
                    <Fligth>15</Fligth>
                  </Trip>
                  <Trip>
                    <Supplier>XX</Supplier>
                    <Fligth>20</Fligth>
                  </Trip>
                </Trips>
            ";
            var serializer = new XmlSerializer(typeof(GdsModels.TripsResponseModel.Trips));
            var rawTrips = (GdsModels.TripsResponseModel.Trips) serializer.Deserialize(new StringReader(response));
            var trips = new List<Models.TripModel>();
            foreach (var rawTrip in rawTrips.Trip)
            {
                trips.Add(new Models.TripModel {Supplier = rawTrip.Supplier, Fligth = rawTrip.Fligth});
            }
            return trips;
        }
    }
}