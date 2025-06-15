using System;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is requiredc")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
