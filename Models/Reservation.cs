using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class Reservation
    {
        public string Email { get; set; }
        public string OwnerName { get; set; }
        public string ClassName { get; set; }
        public DateTime ReservationDate { get; set; }
       
        public int NumberPersons { get; set; }
       

    }
}
