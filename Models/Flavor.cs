using System.Collections.Generic;

namespace SweetShop.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Name { get; set; }

        public int FlavorNumber { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }
    }
}