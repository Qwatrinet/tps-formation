using Microsoft.EntityFrameworkCore;

namespace EntityModel.Models;

public partial class LoanDbContext : DbContext
{
    public LoanDbContext()
    {
    }

    public LoanDbContext(DbContextOptions<LoanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Loan> Loans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;DataBase=LoanDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loan>(entity =>
        {
            entity.ToTable("Loan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
