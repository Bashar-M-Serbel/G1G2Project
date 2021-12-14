using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G1G2Project.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required]
        public string TrainerName { get; set; }
        public string TrainerBio { get; set; }

        public string TrainerCv { get; set; }

    }
}
