﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentInfoApp.Data;

#nullable disable

namespace StudentInfoApp.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentInfoApp.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("StudentInfoApp.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("Course")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<float>("Percentage")
                        .HasColumnType("real");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentInfoApp.Models.User", b =>
                {
                    b.Property<int>("UserIdnew")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserIdnew"));

                    b.Property<string>("Email_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("UserIdnew");

                    b.ToTable("User");
                });

            modelBuilder.Entity("StudentInfoApp.Models.Student", b =>
                {
                    b.HasOne("StudentInfoApp.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}