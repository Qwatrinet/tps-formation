using api_cpu.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cpu.Services
{
    public class AppDbContexte : DbContext
    {
        public DbSet<Cpu> Cpus { get; init; }
        public DbSet<CpuProduction> CpuProductions { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_cpu;Trusted_Connection=True;")
                .UseSnakeCaseNamingConvention();
        }
    }
}
