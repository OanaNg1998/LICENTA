using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class GymInstructors
    {
        public string Id { get; set; }
        public string InstructorId { get; set; }
        public string GymId { get; set; }

        public virtual Gym Gym { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
