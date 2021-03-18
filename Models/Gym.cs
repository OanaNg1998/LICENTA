using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class Gym
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public int DailyOpenHour { get; set; }
        public int DailyClosingHour { get; set; }
        public int WeekendOpenHour { get; set; }
        public int WeekendClosingHour { get; set; }
        public string Icon { get; set; }


        public string AddressId { get; set; }
        


        public virtual Address Address { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<GymTrainings> GymTrainings { get; set; }
        public virtual ICollection<GymInstructors> GymInstructors { get; set; }
    }
}
