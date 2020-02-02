using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TracersCafeLoyaltyScheme.Models;

namespace TracersCafeLoyaltyScheme.Data
{
    public class TracersCafeLoyaltySchemeContext : DbContext
    {
        public TracersCafeLoyaltySchemeContext (DbContextOptions<TracersCafeLoyaltySchemeContext> options)
            : base(options)
        {
        }

        public DbSet<TracersCafeLoyaltyScheme.Models.Customer> Customer { get; set; }
    }
}
