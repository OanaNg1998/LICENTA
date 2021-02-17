using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.GymService
{
    public interface IGymService
    {
        public ICollection<Gym> GetGymsFromCity(string city);
        public void RemoveGymFromId(string id);
    }
}
