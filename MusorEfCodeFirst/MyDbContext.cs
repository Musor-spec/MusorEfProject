using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace MusorEfCodeFirst;

public class MyDbContext : DbContext
{
    private const string CONNECTION = "server=192.168.200.13;userid=student;password=student;database=ZhopaInc";

    public MyDbContext()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(CONNECTION, new MariaDbServerVersion(ServerVersion.AutoDetect(CONNECTION)));
        base.OnConfiguring(optionsBuilder);
    }
/*
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity();
    } */
}