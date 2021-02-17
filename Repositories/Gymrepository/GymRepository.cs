
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JUSTMOVE.Repositories.GymRepository
{
    public class GymRepository : GenericRepository<Gym>, IGymRepository
    {
        public GymRepository(ApplicationDbContext context) : base(context)
        {

        }
        

    }
}
