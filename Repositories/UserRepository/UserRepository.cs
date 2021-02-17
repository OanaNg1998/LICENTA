

using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Data;
using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationUser GetByUsernameAndPassword(string username, string password)
        {
            return _table.Where(x => x.UserName == username && x.PasswordHash == password).FirstOrDefault();
        }
    }
}
