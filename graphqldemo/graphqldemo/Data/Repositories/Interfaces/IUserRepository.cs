using graphqldemo.Models;
using System.Threading.Tasks;

namespace graphqldemo.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Get(int id);
    }
}
