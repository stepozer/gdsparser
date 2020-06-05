using System.Collections.Generic;
using AutoMapper;
using InfrastuctureLayer.Gds.Sirena;
using InfrastuctureLayer.Models;
using Microsoft.AspNetCore.Mvc;
using WebApiLaeyr.Models;

namespace WebApiLaeyr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TripsController : ControllerBase
    {
        private Driver _driver;
        private IMapper _mapper;

        public TripsController(Driver driver, IMapper mapper)
        {
            _driver = driver;
            _mapper = mapper;
        }

        [HttpGet]
        public List<TripApiModel> Get()
        {
            var trips = _driver.Trips();
            return _mapper.Map<List<TripApiModel>>(trips);
        }
    }
}