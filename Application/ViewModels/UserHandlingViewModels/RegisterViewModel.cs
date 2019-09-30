using System.ComponentModel.DataAnnotations;

namespace Application.Models.UserHandlingModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string TelephoneNumber { get; set; }

        [Required]
        public string SocialSecurityNumber { get; set; }

        [Required]
        public string StreetNameAndNumber { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
    }
}