using System;

namespace InfrastuctureLayer.Models
{
    public class TripModel
    {
        public string Supplier { get; set; }
        public string Fligth { get; set; }

        public override string ToString()
        {
            return $"Trip: {Supplier} --> {Fligth}";
        }
    }
}