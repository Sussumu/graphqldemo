using GraphQL.Types;
using System.Collections.Generic;

namespace graphqldemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
    }

    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.Id).Description("User's unique identifier");
            Field(x => x.Name).Description("User's name");
            Field<ListGraphType<RoleType>>().Description("User's permissions");
        }
    }
}
