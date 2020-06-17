using System.Collections.Generic;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApiLaeyr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private UserRepository _userRepository;

        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        [HttpGet("GetAll")]
        public List<User> All()
        {
            return _userRepository.All();
        }
        
        [HttpGet("Add")]
        public string Add()
        {
            var user = new User
            {
                Name = "Name",
                LastName = "Varan"
            };
            _userRepository.Add(user);
            return "OK";
        }
    }
}