using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinishedAssignment4.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        public string StudentFirstName { get; set; }

        public string StudentLastName { get; set; }

        public string StudentAddress { get; set; }
    }
}