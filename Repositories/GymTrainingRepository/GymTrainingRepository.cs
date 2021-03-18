using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.GymTrainingRepository
{
    public class GymTrainingRepository : GenericRepository<GymTrainings>, IGymTrainingRepository
    {
        public GymTrainingRepository(ApplicationDbContext context) : base(context)
        {
           

        }
        public IEnumerable<GymTrainings> FindByGymId(string id)
        {
            return GetAll().Where(x => x.GymId == id);
        }

    }
}
