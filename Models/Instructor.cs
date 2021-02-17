using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class Instructor
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string CareerHistory { get; set; }
        public int Age { get; set; }

        public virtual ICollection<GymInstructors> GymInstructors { get; set; }
        public virtual ICollection<InstructorTrainings> InstructorTrainings { get; set; }
    }
}
