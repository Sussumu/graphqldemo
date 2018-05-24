using graphqldemo.Models.GraphQL;
using System.Threading.Tasks;

namespace graphqldemo.Services
{
    public interface IUserService
    {
        Task<QueryResponse> Get(string query);
    }
}
