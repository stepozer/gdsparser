using System.Collections.Generic;

namespace InfrastuctureLayer.Gds
{
    public interface IDriver
    {
        public List<Models.TripModel> Trips();
        
        public string FareCondition();
    }
}