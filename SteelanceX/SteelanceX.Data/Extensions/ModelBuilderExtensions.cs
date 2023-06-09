﻿#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Domain.Models;

namespace SteelanceX.Data.Extensions;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var businessRoleId = 1;
        var freelancerRoleId = 2;
        bool isActiveJob = true;
        bool IsAccepted = true;

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

        for (int i = 1; i <= 60; i++)
        {
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = i,
                UserName = "normalUser" + (i).ToString(),
                NormalizedUserName = "normalUser" + (i).ToString(),
                Email = "normaluser" + (i).ToString() + "@gmail.com",
                NormalizedEmail = "normaluser" + (i).ToString() + "@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                Firstname = (i).ToString(),
                Lastname = "Nguyen Van",
                Address = "HCM",
                IsPremium = true,
                PhoneNumber = "1234567890"
            });

            if (i > 30)
            {
                modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
                {
                    RoleId = freelancerRoleId,
                    UserId = i
                });

                modelBuilder.Entity<FreelancerProfile>().HasData(new FreelancerProfile
                {
                    Id = i,
                    AppUserId = i,
                    Description = "I am " + (i).ToString() + ", I am an individual with unique " +
                    "qualities, experiences, and aspirations. I have a distinct personality " +
                    "that shapes my thoughts, actions, and interactions with others. I " +
                    "possess a combination of strengths, weaknesses, and personal values that " +
                    "contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.",
                    Price = (i) * 100,
                    Title = "Title " + (i).ToString(),
                    ImageUrl = $"https://picsum.photos/seed/{i}/500/500"
                });

                modelBuilder.Entity<FreelancerCategory>().HasData(new FreelancerCategory
                {
                    FreelancerProfileId = i,
                    CategoryId = random.Next(1, 9)
                });
            }
            else
            {
                modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
                {
                    RoleId = businessRoleId,
                    UserId = i
                });

                modelBuilder.Entity<BusinessProfile>().HasData(new BusinessProfile
                {
                    Id = i,
                    BusinessName = "Business " + i,
                    AppUserId = i
                });
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
            if (i > 50) isActiveJob = false;

            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = i,
                IsActive = isActiveJob,
                Name = "Project " + i,
                Description = "This a simple description for project " + i + " As a Software" +
                " Developer, your primary responsibility is to design, develop, and maintain" +
                " software applications and systems. You will collaborate with a team of" +
                " developers and other stakeholders to understand requirements, create" +
                " efficient code, and deliver high-quality software solutions.",
                Offer = 99 * i,
                CreatedDate = DateTime.Now,
                ApplyExpireDate = DateTime.MaxValue,
                BusinessProfileId = random.Next(1, 31)
            });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory
            {
                JobId = i,
                CategoryId = random.Next(1, 9)
            });
        }
        #endregion

        #region Application
        int appId = 1;
        for (int i = 1; i <= 100; i++)
        {

            if (appId % 2 == 0) IsAccepted = false;
            else IsAccepted = true;
            modelBuilder.Entity<Application>().HasData(new Application
            {
                Id = appId,
                IsAccepted = IsAccepted,
                CreateDate = DateTime.Now,
                JobId = i,
                FreelancerProfileId = random.Next(31, 38)
            });
            appId++;
            if (appId % 2 == 0) IsAccepted = false;
            else IsAccepted = true;
            modelBuilder.Entity<Application>().HasData(new Application
            {
                Id = appId,
                IsAccepted = IsAccepted,
                CreateDate = DateTime.Now,
                JobId = i,
                FreelancerProfileId = random.Next(38, 46)
            });
            appId++;
            if (appId % 2 == 0) IsAccepted = false;
            else IsAccepted = true;
            modelBuilder.Entity<Application>().HasData(new Application
            {
                Id = appId,
                IsAccepted = IsAccepted,
                CreateDate = DateTime.Now,
                JobId = i,
                FreelancerProfileId = random.Next(46, 54)
            });
            appId++;
            if (appId % 2 == 0) IsAccepted = false;
            else IsAccepted = true;
            modelBuilder.Entity<Application>().HasData(new Application
            {
                Id = appId,
                IsAccepted = IsAccepted,
                CreateDate = DateTime.Now,
                JobId = i,
                FreelancerProfileId = random.Next(54, 60)
            });
            appId++;

        }
        #endregion
    }
}
