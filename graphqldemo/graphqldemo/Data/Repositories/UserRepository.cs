using graphqldemo.Data.Context;
using graphqldemo.Data.Repositories.Interfaces;
using graphqldemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace graphqldemo.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserContext Db { get; }

        public UserRepository(UserContext db)
        {
            Db = db;
        }

        public async Task<User> Get(int id)
        {
            return await Db.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
