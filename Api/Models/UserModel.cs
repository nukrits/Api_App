using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(length:10)]
        public string FirstName { get; set; }
    }
}
