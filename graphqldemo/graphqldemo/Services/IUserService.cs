using System.Threading.Tasks;

namespace graphqldemo.Services
{
    public interface IUserService
    {
        Task<string> Get();
    }
}
