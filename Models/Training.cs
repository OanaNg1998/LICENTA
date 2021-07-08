using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class Training
    {
        public string Id { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Day { get; set; }
        public virtual ICollection<GymTrainings> GymTrainings { get; set; }
        public virtual ICollection<InstructorTrainings> InstructorTrainings { get; set; }

    }
}
