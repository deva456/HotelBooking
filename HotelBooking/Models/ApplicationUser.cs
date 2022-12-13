using Microsoft.AspNetCore.Identity;
using System;

namespace Panda.HotelBooking.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
    }
    public class ApplicationRole : IdentityRole<Guid>
    {

    }
}
