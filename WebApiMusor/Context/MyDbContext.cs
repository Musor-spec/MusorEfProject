using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using WebApiMusor.Entities;

namespace WebApiMusor.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BlackList> BlackLists { get; set; }

    public virtual DbSet<Day> Days { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Pass> Passes { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Trener> Treners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.200.13;userid=student;password=student;database=ZhopaInc", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.39-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<BlackList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("BlackList");

            entity.HasIndex(e => e.GuestId, "IX_BlackList_GuestId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.EnteredAt).HasMaxLength(6);
            entity.Property(e => e.GuestId).HasColumnType("int(11)");

            entity.HasOne(d => d.Guest).WithMany(p => p.BlackLists).HasForeignKey(d => d.GuestId);
        });

        modelBuilder.Entity<Day>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.TrenerWorkDaysId, "IX_Days_TrenerWorkDaysId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.TrenerWorkDaysId).HasColumnType("int(11)");

            entity.HasOne(d => d.TrenerWorkDays).WithMany(p => p.Days).HasForeignKey(d => d.TrenerWorkDaysId);
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.RoleId, "IX_Guests_RoleId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasColumnType("int(11)");

            entity.HasOne(d => d.Role).WithMany(p => p.Guests).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<Pass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Duration).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.GuestPaymentId, "IX_Payments_GuestPaymentId");

            entity.HasIndex(e => e.PassesId, "IX_Payments_PassesId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.GuestPaymentId).HasColumnType("int(11)");
            entity.Property(e => e.PassesId).HasColumnType("int(11)");

            entity.HasOne(d => d.GuestPayment).WithMany(p => p.Payments).HasForeignKey(d => d.GuestPaymentId);

            entity.HasOne(d => d.Passes).WithMany(p => p.Payments).HasForeignKey(d => d.PassesId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.RoleName, "AK_Roles_RoleName").IsUnique();

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Trener>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
