using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class Space
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public string ShelterId { get; set; }

        public virtual ICollection<Dog> Dogs { get; set; }
        public virtual Shelter Shelter { get; set; }
    }
}