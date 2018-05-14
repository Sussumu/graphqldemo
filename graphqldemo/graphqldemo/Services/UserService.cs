using graphqldemo.Models;
using System.Collections.Generic;

namespace graphqldemo.Services
{
    public class UserService : IUserService
    {
        public List<User> Get()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Loren"
                },
                new User
                {
                    Id = 2,
                    Name = "Ipsum"
                }
            };
        }
    }
}
