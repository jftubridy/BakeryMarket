using System.Collections.Generic;
using System;

namespace SweetShop.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }
        public string Name { get; set; }
        public int TreatId { get; set; }
        //public bool TaskComplete { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<FlavorTreat> Flavors { get; }


    }
}