using GraphQL.Types;

namespace graphqldemo.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class RoleType : ObjectGraphType<Role>
    {
        public RoleType()
        {
            Field(x => x.Id).Description("Role's id");
            Field(x => x.Name).Description("Role's name");
        }
    }
}
