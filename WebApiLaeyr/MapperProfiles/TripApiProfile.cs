using AutoMapper;
using InfrastuctureLayer.Models;
using WebApiLaeyr.Models;

namespace WebApiLaeyr.MapperProfiles
{
    public class TripApiProfile : Profile
    {
        public TripApiProfile()
        {
            CreateMap<TripModel, TripApiModel>();
        }
    }
}