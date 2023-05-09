using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
<<<<<<< HEAD
    public class AppUser : IdentityUser
=======
    public class AppUser :IdentityUser
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}