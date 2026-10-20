using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MusorEfCodeFirst.Models;

namespace MusorEfCodeFirst;

public class MyDbContext : DbContext
{
    private const string CONNECTION = "server=192.168.200.13;userid=student;password=student;database=ZhopaInc";
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Passes> Passes { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<Treners> Treners { get; set; }
    public DbSet<Days> Days { get; set; }
    public DbSet<BlackList> BlackList { get; set; }

    public MyDbContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(CONNECTION, new MariaDbServerVersion(ServerVersion.AutoDetect(CONNECTION)));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasAlternateKey(s => s.RoleName);
    }
}