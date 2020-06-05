using System.Text.Json.Serialization;

namespace WebApiLaeyr.Models
{
    public class TripApiModel
    {
        [JsonPropertyName("S")]
        public string Supplier { get; set; }
        [JsonPropertyName("F")]
        public string Fligth { get; set; }
        [JsonPropertyName("unknown")]
        public int Unknown { get; set; }
    }
}