using System.Threading.Tasks;

namespace graphqldemo.Services
{
    public interface IUserService
    {
        Task<object> Get(string query);
    }
}
