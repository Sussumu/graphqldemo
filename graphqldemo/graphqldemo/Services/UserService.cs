using GraphQL;
using GraphQL.Types;
using graphqldemo.Schemas;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace graphqldemo.Services
{
    public class UserService : IUserService
    {
        public async Task<string> Get()
        {
            var schema = new Schema { Query = new UserQuery() };

            var executer = new DocumentExecuter();
            var result = await executer.ExecuteAsync(opt =>
            {
                opt.Schema = schema;
                opt.Query = @"
                    query {
                        user {
                            name
                        }
                    }
                ";
            });

            return result.Data is null
                ? null
                : JsonConvert.SerializeObject(result);
        }
    }
}
