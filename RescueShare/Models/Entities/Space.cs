using RescueShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc.Html;

namespace RescueShare.Models
{
    public class Space
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public SpaceType SpaceType { get; set; }
        public string Notes { get; set; }
        public string ShelterId { get; set; }

        public virtual ICollection<Dog> Dogs { get; set; }
        public virtual Shelter Shelter { get; set; }
    }
}