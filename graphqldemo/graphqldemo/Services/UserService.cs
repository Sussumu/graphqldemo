using GraphQL;
using GraphQL.Types;
using graphqldemo.Schemas;
using System.Threading.Tasks;

namespace graphqldemo.Services
{
    public class UserService : IUserService
    {
        public async Task<object> Get(string query)
        {
            var schema = new Schema { Query = new UserQuery() };

            var executer = new DocumentExecuter();
            var result = await executer.ExecuteAsync(opt =>
            {
                opt.Schema = schema;
                opt.Query = query;
            });

            return result.Data;
        }
    }
}
