using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GymTrainingRepository;
using JUSTMOVE.Repositories.TrainingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.GymTrainingService
{
    public class GymTrainingService : IGymTrainingService
    {
        private readonly IGymTrainingRepository _gymTrainingRepository;
        private readonly ITrainingRepository _trainingRepository;
        public GymTrainingService(IGymTrainingRepository gymTrainingRepository, ITrainingRepository trainingRepository)
        {
            _gymTrainingRepository = gymTrainingRepository;
            _trainingRepository = trainingRepository;

        }
        public ICollection<Training> GetGymTrainingsByGymId(string gymId)
        {
            var gymTrainings = _gymTrainingRepository.FindByGymId(gymId);
            var trainings = _trainingRepository.GetAll();
           ICollection<Training> classes = new List<Training>();
            foreach (GymTrainings gymTr in gymTrainings)
            {
                foreach(Training tr in trainings)
                {
                    if(gymTr.TrainingId==tr.Id)
                    {
                        classes.Add(tr);
                    }

                }
            }
            return classes;


        }

    }
}
