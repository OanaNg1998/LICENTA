using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.TrainingRepository
{
    public class TrainingRepository: GenericRepository<Training>, ITrainingRepository
    {
        public TrainingRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
