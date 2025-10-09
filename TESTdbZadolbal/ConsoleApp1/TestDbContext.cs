using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inventory> Inventories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> optionsBuilder.UseSqlServer("Server=localhost;Database=TestDB;User Id=sa;Password=23LAMbda0933!;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}


public class AppUserContext : DbContext
{
    public AppUserContext()
    {
        Database.EnsureCreated();
    }

    public AppUserContext(DbContextOptions<AppUserContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=UsersDB;User Id=sa;Password=23LAMbda0933!;TrustServerCertificate=True;");
    }
}

public class User
{
    [Column("User_id", TypeName = "INTEGER")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }


    [Column("User_Name", TypeName = "NVARCHAR(50)")]
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }


    [Column("User_Email", TypeName = "NVARCHAR(100)")]

    [MaxLength(100)]
    [Required]
    public string Email { get; set; }


    [Column("User_Age", TypeName = "INTEGER")]
    [Required]
    public int Age { get; set; }
}
