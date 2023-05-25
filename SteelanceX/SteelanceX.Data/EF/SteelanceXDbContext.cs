using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SteelanceX.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Data.EF;

public class SteelanceXDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("SteelanceX"),
            b => b.MigrationsAssembly("SteelanceX.Data"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AppUser>()
            .HasOne(a => a.FreelancerProfile)
            .WithOne(a => a.AppUser)
            .HasForeignKey<FreelancerProfile>(c => c.AppUserId);
        modelBuilder.Entity<AppUser>()
            .HasOne(a => a.BusinessProfile)
            .WithOne(a => a.AppUser)
            .HasForeignKey<BusinessProfile>(c => c.AppUserId);

        modelBuilder.Entity<FreelancerCategory>()
            .HasKey(sc => new { sc.FreelancerProfileId, sc.CategoryId });

        modelBuilder.Entity<JobCategory>()
            .HasKey(sc => new { sc.JobId, sc.CategoryId });

        modelBuilder.Entity<JobProgress>().HasOne(a => a.FreelancerProfile)
            .WithMany(fp => fp.JobProgress)
            .HasForeignKey(u => u.FreelancerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<JobProgress>().HasOne(a => a.Job)
            .WithMany(fp => fp.JobProgress)
            .HasForeignKey(u => u.JobId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<JobProgress>()
            .HasOne(a => a.FreelancerProfile)
            .WithMany(fp => fp.JobProgress)
            .HasForeignKey(u => u.FreelancerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<JobProgress>()
            .HasOne(a => a.Job)
            .WithMany(fp => fp.JobProgress)
            .HasForeignKey(u => u.JobId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppRole> AppRoles { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<BusinessProfile> BusinessProfiles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FreelancerCategory> FreelancerCategories { get; set; }
    public DbSet<FreelancerProfile> FreelancerProfiles { get; set; }
    public DbSet<Job> Job { get; set; }
    public DbSet<JobCategory> JobCategories { get; set; }
    public DbSet<JobProgress> JobProgress { get; set; }

}
