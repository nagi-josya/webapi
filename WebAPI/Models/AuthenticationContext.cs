using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class AuthenticationContext:IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options):base(options)
        {
            
        }

        public Microsoft.EntityFrameworkCore.DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
