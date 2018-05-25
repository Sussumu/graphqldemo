using graphqldemo.Data.Context;
using graphqldemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace graphqldemo.Data.Seed
{
    public static class UserSeed
    {
        public static void Seed(this UserContext db)
        {
            if (db.Users.Any())
                return;

            var seed = new List<User>
            {
                new User { Id = 1, Name = "Lorem", Roles = new List<Role>{ new Role { Id = 1, Name = "Administrator" }}},
                new User { Id = 2, Name = "Ipsum", Roles = new List<Role>{ new Role { Id = 1, Name = "Manager" }, new Role { Id = 2, Name = "Analyst" }}},
                new User { Id = 3, Name = "Dolor", Roles = new List<Role>{ new Role { Id = 1, Name = "Manager" }}},
                new User { Id = 4, Name = "Sit", Roles = new List<Role>{ new Role { Id = 3, Name = "Client" }}},
                new User { Id = 5, Name = "Amet", Roles = new List<Role>{ new Role { Id = 4, Name = "Guest" }}}
            };

            db.Users.AddRange(seed);
            db.SaveChanges();
        }
    }
}
