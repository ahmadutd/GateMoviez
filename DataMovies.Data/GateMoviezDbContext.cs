using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GateMoviez.Domain;

namespace GateMoviez.Data
{
    public class GateMoviezDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public GateMoviezDbContext(DbContextOptions<GateMoviezDbContext> options)
            :base(options)
        {

        }
        

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
    }
}
