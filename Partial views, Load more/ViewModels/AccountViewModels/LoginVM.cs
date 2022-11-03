using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Partial_views__Load_more.ViewModels.AccountViewModels
{
    public class LoginVM
    {
        [Required]
        public string UsernameOrEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
