using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_views__Load_more.ViewModels.ProfileViewModels
{
    public class ProfileVM
    {
        [Required]
        public string Fullname { get; set; }
    }
}
