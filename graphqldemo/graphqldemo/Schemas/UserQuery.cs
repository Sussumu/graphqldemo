using GraphQL.Types;
using graphqldemo.Models;
using System.Collections.Generic;

namespace graphqldemo.Schemas
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery()
        {
            Field<ListGraphType<UserType>>(
                "user",
                resolve: context => new List<User>
                {
                    new User { Id = 1, Name = "Lorem", Roles = new List<Role>{ new Role { Id = 1, Name = "Administrator" }}},
                    new User { Id = 2, Name = "Ipsum", Roles = new List<Role>{ new Role { Id = 1, Name = "Manager" }, new Role { Id = 2, Name = "Analyst" }}},
                    new User { Id = 3, Name = "Dolor", Roles = new List<Role>{ new Role { Id = 1, Name = "Manager" }}},
                    new User { Id = 4, Name = "Sit", Roles = new List<Role>{ new Role { Id = 3, Name = "Client" }}},
                    new User { Id = 5, Name = "Amet", Roles = new List<Role>{ new Role { Id = 4, Name = "Guest" }}}
                });
        }
    }
}
