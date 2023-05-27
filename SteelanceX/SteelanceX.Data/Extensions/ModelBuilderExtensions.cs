using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Domain.Models;

namespace SteelanceX.Data.Extensions;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // any guid
        var businessRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
        var freelancerRoleId = new Guid("12147FE0-4571-4AD2-B8F7-D2C863EB78A5");
        var businessId1 = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
        var businessId2 = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00BF");
        var freelancerId1 = new Guid("70BD714F-9576-45BA-B5B7-F00649BE00DE");
        var freelancerId2 = new Guid("70BD814F-9576-45BA-B5B7-F00649BE00DE");
        var freelancerId3 = new Guid("73BD714F-9576-45BA-B5B7-F00649BE00DE");

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
        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = businessId1,
            UserName = "adminhcm",
            NormalizedUserName = "adminhcm",
            Email = "adminhcm@gmail.com",
            NormalizedEmail = "adminhcm@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "Hochiminh"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = businessId2,
            UserName = "adminhn",
            NormalizedUserName = "adminhn",
            Email = "adminhn@gmail.com",
            NormalizedEmail = "adminhn@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "Hochiminh"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = freelancerId1,
            UserName = "staff1",
            NormalizedUserName = "staff1",
            Email = "staff@gmail.com",
            NormalizedEmail = "staff@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "Hochiminh"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = freelancerId2,
            UserName = "staff2",
            NormalizedUserName = "staff2",
            Email = "staff@gmail.com",
            NormalizedEmail = "staff@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "Hochiminh"
        });

        modelBuilder.Entity<AppUser>().HasData(new AppUser
        {
            Id = freelancerId3,
            UserName = "staffDis",
            NormalizedUserName = "staffdis",
            Email = "staffdis@gmail.com",
            NormalizedEmail = "staffdis@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "12345678"),
            SecurityStamp = string.Empty,
            Firstname = "Toan",
            Lastname = "Bach",
            Address = "Hochiminh"
        });

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = businessRoleId,
            UserId = businessId1
        });

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = businessRoleId,
            UserId = businessId2,
        });

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = freelancerRoleId,
            UserId = freelancerId1
        });

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = freelancerRoleId,
            UserId = freelancerId2
        });

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = freelancerRoleId,
            UserId = freelancerId3
        });

        //modelBuilder.Entity<Category>().HasData(new Category
        //{
        //    Id = 1,
        //    Name = "Laptop",
        //    Prefix = "LA",
        //    IsDeleted = false,
        //});

        //modelBuilder.Entity<Category>().HasData(new Category
        //{
        //    Id = 2,
        //    Name = "Monitor",
        //    Prefix = "MO",
        //    IsDeleted = false,
        //});

        //modelBuilder.Entity<Category>().HasData(new Category
        //{
        //    Id = 3,
        //    Name = "Personal Computer",
        //    Prefix = "PC",
        //    IsDeleted = false,
        //});

        //for (int i = 1; i <= 10; i++)
        //{
        //    modelBuilder.Entity<Asset>().HasData(new Asset
        //    {
        //        Id = i,
        //        Name = "Laptop " + i,
        //        AssetCode = "LA10000" + i,
        //        Specification = $"Core i{i}, {i}GB RAM, {i}50 GB HDD, Window {i}",
        //        CategoryId = i % 2 == 0 ? 1 : 2,
        //        InstalledDate = DateTime.Now,
        //        State = i % 2 == 0 ? State.Available : State.NotAvailable,
        //        IsDeleted = i % 2 == 0 ? true : false,
        //    });
        //}

        //for (int i = 11; i <= 15; i++)
        //{
        //    modelBuilder.Entity<Asset>().HasData(new Asset
        //    {
        //        Id = i,
        //        Name = "Laptop " + i,
        //        AssetCode = "LA10000" + i,
        //        Specification = $"Core i{i}, {i}GB RAM, {i}50 GB HDD, Window {i}",
        //        CategoryId = i % 2 == 0 ? 1 : 2,
        //        InstalledDate = DateTime.Now,
        //        State = i % 2 == 0 ? State.Assigned : State.NotAvailable,
        //        IsDeleted = i % 2 == 0 ? true : false,
        //    });
        //}

        //for (int i = 1; i <= 10; i++)
        //{
        //    modelBuilder.Entity<Assignment>().HasData(new Assignment
        //    {
        //        Id = i,
        //        Note = $"Note for assignment {i}",
        //        AssignedDate = DateTime.Today,
        //        ReturnedDate = DateTime.Today.AddDays(i),
        //        AssetId = i,
        //        State = i % 2 == 0 ? Domain.Enums.Assignment.State.Accepted : Domain.Enums.Assignment.State.WaitingForAcceptance,
        //        AssignedTo = staffAbleId1,
        //        AssignedBy = adminHcmId,
        //    });
        //}

        //modelBuilder.Entity<Assignment>().HasData(new Assignment
        //{
        //    Id = 11,
        //    Note = $"Note for assignment {11}",
        //    AssignedDate = DateTime.Today,
        //    ReturnedDate = DateTime.Today.AddDays(11),
        //    AssetId = 4,
        //    State = Domain.Enums.Assignment.State.WaitingForAcceptance,
        //    AssignedTo = staffAbleId1,
        //    AssignedBy = adminHcmId,
        //});

        //for (int i = 12; i <= 15; i++)
        //{
        //    modelBuilder.Entity<Assignment>().HasData(new Assignment
        //    {
        //        Id = i,
        //        Note = $"Note for assignment {i}",
        //        AssignedDate = DateTime.Today,
        //        ReturnedDate = DateTime.Today.AddDays(i),
        //        AssetId = i,
        //        State = i % 2 == 0 ? Domain.Enums.Assignment.State.WaitingForReturning : Domain.Enums.Assignment.State.Returned,
        //        AssignedTo = staffAbleId1,
        //        AssignedBy = adminHcmId,
        //    });
        //}

        //for (int i = 1; i <= 10; i++)
        //{
        //    modelBuilder.Entity<ReturnRequest>().HasData(new ReturnRequest
        //    {
        //        Id = i,
        //        AssignedBy = staffAbleId1,
        //        AssignedDate = DateTime.Today,
        //        ReturnedDate = DateTime.Today,
        //        State = Domain.Enums.ReturnRequest.State.WaitingForReturning,
        //        AssignmentId = i,
        //    });
        //}

        //for (int i = 11; i <= 15; i++)
        //{
        //    modelBuilder.Entity<ReturnRequest>().HasData(new ReturnRequest
        //    {
        //        Id = i,
        //        AssignedBy = staffAbleId1,
        //        AssignedDate = DateTime.Today,
        //        ReturnedDate = DateTime.Today,
        //        State = Domain.Enums.ReturnRequest.State.WaitingForReturning,
        //        AssignmentId = i,
        //    });
        //}
    }
}
