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
                    new User { Id = 1, Name = "Lorem" },
                    new User { Id = 2, Name = "Ipsum" },
                    new User { Id = 3, Name = "Dolor" },
                    new User { Id = 4, Name = "Sit" },
                    new User { Id = 5, Name = "Amet" }
                });
        }
    }
}
