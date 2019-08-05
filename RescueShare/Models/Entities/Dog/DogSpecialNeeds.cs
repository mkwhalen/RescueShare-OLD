using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class DogSpecialNeeds
    {
        public bool Blind { get; set; }
        public bool Deaf { get; set; }
        public bool Wheelchair { get; set; }
        public bool TriPawd { get; set; }
        public bool Epilepsy { get; set; }
        public bool TerminalIllness { get; set; }
        public bool DailyMedication { get; set; }
    }
}
