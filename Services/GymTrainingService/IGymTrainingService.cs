using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.GymTrainingService
{
    public interface IGymTrainingService
    {
        public ICollection<Training> GetGymTrainingsByGymId(string gymId);
    }
}
