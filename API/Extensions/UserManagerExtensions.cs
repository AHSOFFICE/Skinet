<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
=======
using System.Security.Claims;
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class UserManagerExtensions
    {                                  
     public static async Task<AppUser> FindUserByClaimsPrincipleWithAddress(this UserManager<AppUser> userManager,
     ClaimsPrincipal user)
     {
        var email=user.FindFirstValue(ClaimTypes.Email);
        return await userManager.Users.Include(x=> x.Address)
<<<<<<< HEAD
        .SingleOrDefaultAsync(x=> x.Email ==email);
=======
        .SingleOrDefaultAsync(x=> x.Email == email);
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
     }
    public static async Task<AppUser> FindByEmailFromClaimsPrincipal (this UserManager<AppUser> userManager,
     ClaimsPrincipal user)
     {
        return await userManager.Users.SingleOrDefaultAsync(x=>x.Email == user.FindFirstValue(ClaimTypes.Email));
     }
    }
}