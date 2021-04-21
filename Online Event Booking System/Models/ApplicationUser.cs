using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Event_Booking_System.Models
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
    }

}
