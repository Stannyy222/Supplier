using System.ComponentModel.DataAnnotations;

namespace Supplier.App.Models
{
    public class RegisterVM
    {
        public RegisterVM()
        {
            Username = "";
            Email = "";
            Password = "";
            ConfirmPassword = ""; 
        }

        [Required]
        [MaxLength(30)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
