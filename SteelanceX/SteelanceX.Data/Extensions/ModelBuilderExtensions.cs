#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Domain.Models;
using System;

namespace SteelanceX.Data.Extensions;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var businessRoleId = 1;
        var freelancerRoleId = 2;
        bool isActiveJob = true;

        Random random = new Random();

        modelBuilder.Entity<AppRole>().HasData(new AppRole
        {
            Id = businessRoleId,
            Name = "Business",
            NormalizedName = "business",
        });

        modelBuilder.Entity<AppRole>().HasData(new AppRole
        {
            Id = freelancerRoleId,
            Name = "Freelancer",
            NormalizedName = "freelancer",
        });

        var hasher = new PasswordHasher<AppUser>();

        #region Freelancers and Business

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = 1,
            UserName = "adminhcm",
            NormalizedUserName = "adminhcm",
            Email = "adminhcm@gmail.com",
            NormalizedEmail = "adminhcm@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "HCM"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = 2,
            UserName = "adminhn",
            NormalizedUserName = "adminhn",
            Email = "adminhn@gmail.com",
            NormalizedEmail = "adminhn@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "HCM"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = 3,
            UserName = "staff1",
            NormalizedUserName = "staff1",
            Email = "staff@gmail.com",
            NormalizedEmail = "staff@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "HCM"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = 4,
            UserName = "staff2",
            NormalizedUserName = "staff2",
            Email = "staff@gmail.com",
            NormalizedEmail = "staff@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "HCM"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = 5,
            UserName = "staffDis",
            NormalizedUserName = "staffdis",
            Email = "staffdis@gmail.com",
            NormalizedEmail = "staffdis@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "HCM"
        });

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = businessRoleId,
            UserId = 1
        });

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = businessRoleId,
            UserId = 2
        });

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = freelancerRoleId,
            UserId = 3
        });

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = freelancerRoleId,
            UserId = 4
        });

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = freelancerRoleId,
            UserId = 5
        });

        for (int i = 1; i <= 60; i++)
        {
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = i + 5,
                UserName = "normalUser" + (i + 5).ToString(),
                NormalizedUserName = "normalUser" + (i + 5).ToString(),
                Email = "normaluser" + (i + 5).ToString() + "@gmail.com",
                NormalizedEmail = "normaluser" + (i + 5).ToString() + "@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                Firstname = (i + 5).ToString(),
                Lastname = "Nguyen Van",
                Address = "HCM"
            });

            if(i > 30)
            {
                modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
                {
                    RoleId = freelancerRoleId,
                    UserId = i + 5
                });

                modelBuilder.Entity<FreelancerProfile>().HasData(new FreelancerProfile
                {
                    Id = i + 5,
                    AppUserId = i + 5,
                    Description = "I am " + (i + 5).ToString(),
                    ResumeUrl = "This is my resume",
                    Price = (i+5)*100,
                    Title = "Title " + (i + 5).ToString()
                });
            }
            else
            {
                modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
                {
                    RoleId = businessRoleId,
                    UserId = i + 5
                });

                modelBuilder.Entity<BusinessProfile>().HasData(new BusinessProfile
                {
                    Id = i + 5,
                    BusinessName = "Business " + i,
                    AppUserId = i + 5
                }) ;
            }
        }

        #endregion

        #region Categories

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 1,
            Name = "Web developer"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 2,
            Name = "Data scientist"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 3,
            Name = "Software engineer"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 4,
            Name = "Cloud system engineer"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 5,
            Name = "User experience designer"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 6,
            Name = "Network engineer"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 7,
            Name = "Systems analyst"
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 8,
            Name = "IT security specialist"
        });

        #endregion

        #region Job
        for (int i = 1; i <= 100; i++)
        {
            if(i > 50) isActiveJob = false;

            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = i,
                IsActive = isActiveJob,
                Name = "Project " + i,
                Description = "This a simple description for project " + i,
                Offer = 99*i,
                CreatedDate = DateTime.Now,
                ApplyExpireDate = DateTime.MaxValue,
                JobExpiredDate = DateTime.MaxValue,
                ImageUrl = "This is an image. If you do not see anything, you are so blind!!!",
                JobDescriptionFileUrl = "This is what decides that you will do the job or run!!!",
                BusinessProfileId = random.Next(6, 35)
            });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory
            {
                JobId = i,
                CategoryId = random.Next(1, 8)
            });
        }
        #endregion
    }
}
