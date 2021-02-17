using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class GymTrainings
    {
        public string Id { get; set; }
        public string GymId { get; set; }
        public string TrainingId { get; set; }

        public virtual Gym Gym { get; set; }
        public virtual Training Training { get; set; }
    }
}
