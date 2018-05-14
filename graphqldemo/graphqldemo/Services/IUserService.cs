using graphqldemo.Models;
using System.Collections.Generic;

namespace graphqldemo.Services
{
    public interface IUserService
    {
        List<User> Get();
    }
}
