using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_views__Load_more.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
