using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCompany.Models
{
    public partial class organisationX_databaseContext : DbContext
    {
        public organisationX_databaseContext()
        {
        }

        public organisationX_databaseContext(DbContextOptions<organisationX_databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Salary> Salary { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<WorkRecord> WorkRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-2TVR481D\\SQLEXPRESS;Database=organisationX_database;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartId);

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessTravel)
                    .HasColumnName("businessTravel")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentType)
                    .HasColumnName("department_type")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.JobLevel)
                    .HasColumnName("jobLevel")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.JobRole)
                    .HasColumnName("jobRole")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_ID");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.EducationId)
                    .HasColumnName("education_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EducationField)
                    .HasColumnName("educationField")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.EducationYears)
                    .HasColumnName("educationYears")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_ID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNum);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_Num")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.EmployeeNum);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_Num")
                    .ValueGeneratedNever();

                entity.Property(e => e.HourlyRate)
                    .HasColumnName("hourlyRate")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.MonthlyIncome)
                    .HasColumnName("monthlyIncome")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.OverTime)
                    .HasColumnName("overTime")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_ID")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_Num")
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

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("maritalStatus")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkRecord>(entity =>
            {
                entity.HasKey(e => e.DepartId);

                entity.ToTable("Work_Record");

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumOfCompanies).HasColumnName("numOfCompanies");

                entity.Property(e => e.Promotions)
                    .HasColumnName("promotions")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.TotalWorkingYears).HasColumnName("totalWorkingYears");

                entity.Property(e => e.YearsInCurrentRole).HasColumnName("yearsInCurrentRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
