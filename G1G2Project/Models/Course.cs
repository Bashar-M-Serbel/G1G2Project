using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G1G2Project.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        public decimal CoursePrice { get; set; }
        public DateTime CourseDate { get; set; }
        public bool isActive { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }


    }
}
