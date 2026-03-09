using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentDb
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }

        [Required]
        public string TeacherName { get; set; }
        
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string TeacherEmail { get; set; }

        [Phone(ErrorMessage = "Enter a vaild Phone Number")]
        public string TeacherPhone { get; set; }

        [Required]
        public string TeacherAddress { get; set; }
    }
}
