﻿using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.GymTrainingRepository
{
    public interface IGymTrainingRepository: IGenericRepository<GymTrainings>
    {
        public IEnumerable<GymTrainings> FindByGymId(string id);
    }
}
