using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class UserRepository
    {
        private AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<User> All()
        {
            return _dbContext.Users.ToList();
        }

        public void Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChangesAsync();
        }
    }
}