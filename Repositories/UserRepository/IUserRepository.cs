using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<ApplicationUser>
    {
        ApplicationUser GetByUsernameAndPassword(string username, string password);
    }
}
