using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

    }
}
