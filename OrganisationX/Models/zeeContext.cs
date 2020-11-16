using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrganisationX.Models
{
    public partial class zeeContext : DbContext
    {
        public zeeContext()
        {
        }

        public zeeContext(DbContextOptions<zeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cmpg323Project2Dataset1> Cmpg323Project2Dataset1 { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Salary> Salary { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<WorkRecord> WorkRecord { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Cmpg323Project2Dataset1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CMPG323 project 2 dataset (1)");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attrition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTravel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistanceFromHome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Education)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnvironmentSatisfaction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HourlyRate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobInvolvement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobSatisfaction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyIncome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyRate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCompaniesWorked)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Over18)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OverTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentSalaryHike)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerformanceRating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipSatisfaction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StandardHours)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockOptionLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalWorkingYears)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingTimesLastYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkLifeBalance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearsAtCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearsInCurrentRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearsSinceLastPromotion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearsWithCurrManager)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartId);

                entity.Property(e => e.DepartId)
                    .HasColumnName("departID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessTravel)
                    .HasColumnName("businessTravel")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentType)
                    .HasColumnName("department_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobLevel)
                    .HasColumnName("jobLevel")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobRole)
                    .HasColumnName("jobRole")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.EducationId)
                    .HasColumnName("educationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EducationField)
                    .HasColumnName("educationField")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EducationYears).HasColumnName("educationYears");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.Property(e => e.SalaryId)
                    .HasColumnName("salaryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HourlyRate)
                    .HasColumnName("hourlyRate")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyIncome)
                    .HasColumnName("monthlyIncome")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Overtime)
                    .HasColumnName("overtime")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_num")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MeritalStatus)
                    .HasColumnName("meritalStatus")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkRecord>(entity =>
            {
                entity.HasKey(e => e.WorkId);

                entity.Property(e => e.WorkId)
                    .HasColumnName("workID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumOfCompanies).HasColumnName("numOfCompanies");

                entity.Property(e => e.Promotions).HasColumnName("promotions");

                entity.Property(e => e.TotalWorkYears).HasColumnName("totalWorkYears");

                entity.Property(e => e.YearsInCurrentCom).HasColumnName("yearsInCurrentCom");

                entity.Property(e => e.YearsInCurrentRole).HasColumnName("yearsInCurrentRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
