using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinishedAssignment4.Models
{
    public class CourseRoster
    {
        [Key]
        public int CourseRosterID { get; set; }

        public string CourseName { get; set; }

        public int NoOfHours { get; set; }
    }
}