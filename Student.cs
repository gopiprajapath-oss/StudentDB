using System.ComponentModel.DataAnnotations;

namespace StudentDb
{
    public class Student 
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string StudentName  { get; set; }

        [EmailAddress(ErrorMessage ="Enter a valid email address")]
        public string StudentEmail { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Enter a vaild Phone Number")]
        public string StudentPhone { get; set; } = string.Empty;

        public string StudentAddress { get; set; } = string.Empty;


    }
}
