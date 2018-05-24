using GraphQL;
using GraphQL.Types;
using graphqldemo.Models.GraphQL;
using graphqldemo.Schemas;
using System.Linq;
using System.Threading.Tasks;

namespace graphqldemo.Services
{
    public class UserService : IUserService
    {
        public async Task<QueryResponse> Get(string query)
        {
            var schema = new Schema { Query = new UserQuery() };

            var executer = new DocumentExecuter();
            var result = await executer.ExecuteAsync(opt =>
            {
                opt.Schema = schema;
                opt.Query = query;
            });

            if (result.Errors is null || result.Data != null)
                return new SuccessfullQueryResponse(result.Data);

            if (result.Errors.Any() || result.Data is null)
                return new FailedQueryResponse(result.Errors.Select(x => x.Message));

            return new PartiallySuccessfullQueryResponse(result.Data, result.Errors.Select(x => x.Message));
        }
    }
}
