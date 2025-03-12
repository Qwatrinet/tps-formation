using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testasp.Models;

namespace testasp.Data
{
    public class testaspContext : DbContext
    {
        public testaspContext (DbContextOptions<testaspContext> options)
            : base(options)
        {
        }

        public DbSet<testasp.Models.Movie> Movie { get; set; } = default!;
    }
}
