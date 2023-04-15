using System.ComponentModel.DataAnnotations;

namespace HikingInvites.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage ="Please eneter your name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please eneter your email address")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please eneter your phone number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please choose location")]
        public string? Location { get; set; }
        
    }
}
