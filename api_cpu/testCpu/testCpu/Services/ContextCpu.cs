using Microsoft.EntityFrameworkCore;
using testCpu.Models;

namespace testCpu.Services
{
    public class ContextCpu:DbContext
    {
        public DbSet<Cpu> Cpus { get; init; }
        public DbSet<CpuProduction> CpuProductions { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_cpu2;Trusted_Connection=True;");
        }
    }
}
