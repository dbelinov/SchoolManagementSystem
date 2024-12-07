﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementSystem.Data;

#nullable disable

namespace SchoolManagementSystem.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"),
                            RoleId = new Guid("2239599d-510a-4431-916a-59eca9c6ba3d")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("Speciality")
                        .HasColumnType("int");

                    b.Property<int?>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "9b",
                            SchoolId = 1,
                            Speciality = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "10b",
                            SchoolId = 1,
                            Speciality = 1
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GradeValue")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Subject")
                        .HasColumnType("int");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.IdentityModels.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid>("AppId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsAuthenticated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGuest")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("VerificationKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"),
                            AccessFailedCount = 0,
                            AppId = new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"),
                            BirthDate = new DateTime(2024, 12, 7, 11, 16, 50, 513, DateTimeKind.Local).AddTicks(290),
                            ConcurrencyStamp = "8394d764-be65-41d7-bfe2-177a5255890b",
                            Email = "admin@scholario.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IdNumber = "2452064114",
                            IsAuthenticated = true,
                            IsGuest = false,
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            MiddleName = "Adminov",
                            NormalizedEmail = "ADMIN@SCHOLARIO.COM",
                            NormalizedUserName = "ADMIN@SCHOLARIO.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECdGJDMlcQm62cQthq4ECifB9OC9XB8p4Q2zt4KXLZk0vdTFb9tGgXzqalFERgwlmA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1fe00171-99e6-4c94-a807-8abefd2fdc4d",
                            TwoFactorEnabled = false,
                            UserName = "admin@scholario.com",
                            VerificationKey = new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f")
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Specialities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "44 Avgusta Trayana\nStara Zagora, Bulgaria",
                            Description = "The School of Informatics and Mathematics in Stara Zagora",
                            LogoUrl = "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD",
                            Name = "PPMG \"Geo Milev\"",
                            Specialities = "[1,2,4]"
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.SchoolProject", b =>
                {
                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("SchoolId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("SchoolsProjects");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid>("VerificationKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("804fd719-b585-40e1-9974-07c781c06c7b"),
                            ClassId = 1,
                            FirstName = "Ivan",
                            IdNumber = "0141012442",
                            LastName = "Ivanov",
                            MiddleName = "Ivanov",
                            VerificationKey = new Guid("747884f5-e8f5-47cd-88b1-7dcbe3240a95")
                        },
                        new
                        {
                            Id = new Guid("1272875c-7ab2-40cf-88d8-6a2a7c018e46"),
                            ClassId = 1,
                            FirstName = "Gencho",
                            IdNumber = "0543121244",
                            LastName = "Ginev",
                            MiddleName = "Petkov",
                            VerificationKey = new Guid("c1401b18-a9ef-47c0-ae88-cc24594032ad")
                        },
                        new
                        {
                            Id = new Guid("ae1ed6a9-2326-4c40-8a56-e62bd3ac0ec4"),
                            ClassId = 2,
                            FirstName = "Martin",
                            IdNumber = "0741124324",
                            LastName = "Georgiev",
                            MiddleName = "Ivanov",
                            VerificationKey = new Guid("e1528851-aed8-4e8c-a7a8-0588f0b263a1")
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.StudentProject", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("StudentsProjects");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("Subject")
                        .HasColumnType("int");

                    b.Property<Guid>("VerificationKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2384309-062b-466b-b267-6b7488197d7e"),
                            FirstName = "Maria",
                            IdNumber = "8008089119",
                            LastName = "Petrova",
                            MiddleName = "Ivanova",
                            Subject = 1,
                            VerificationKey = new Guid("47c8b8b7-9bfb-4875-b562-5a88c9b11736")
                        },
                        new
                        {
                            Id = new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"),
                            FirstName = "Stefka",
                            IdNumber = "9003021331",
                            LastName = "Gineva",
                            MiddleName = "Petkova",
                            Subject = 4,
                            VerificationKey = new Guid("1e7dbfc5-f7b7-40dd-acf2-0cf6c275e0a1")
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.TeacherClass", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("TeachersClasses");

                    b.HasData(
                        new
                        {
                            TeacherId = new Guid("a2384309-062b-466b-b267-6b7488197d7e"),
                            ClassId = 1
                        },
                        new
                        {
                            TeacherId = new Guid("a2384309-062b-466b-b267-6b7488197d7e"),
                            ClassId = 2
                        },
                        new
                        {
                            TeacherId = new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"),
                            ClassId = 1
                        },
                        new
                        {
                            TeacherId = new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"),
                            ClassId = 2
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Timetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Timetables");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.IdentityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.IdentityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Data.Models.IdentityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.IdentityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Class", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.School", "School")
                        .WithMany("Classes")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Data.Models.Timetable", "Timetable")
                        .WithMany()
                        .HasForeignKey("TimetableId");

                    b.Navigation("School");

                    b.Navigation("Timetable");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Grade", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Data.Models.Teacher", null)
                        .WithMany("Grades")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.SchoolProject", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.Project", "Project")
                        .WithMany("SchoolsProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Data.Models.School", "School")
                        .WithMany("SchoolsProjects")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Student", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.StudentProject", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.Project", "Project")
                        .WithMany("StudentsProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Data.Models.Student", "Student")
                        .WithMany("StudentsProjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Teacher", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.School", null)
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.TeacherClass", b =>
                {
                    b.HasOne("SchoolManagementSystem.Data.Models.Class", "Class")
                        .WithMany("TeachersClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Data.Models.Teacher", "Teacher")
                        .WithMany("TeachersClasses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Class", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("TeachersClasses");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Project", b =>
                {
                    b.Navigation("SchoolsProjects");

                    b.Navigation("StudentsProjects");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.School", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("SchoolsProjects");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Student", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("StudentsProjects");
                });

            modelBuilder.Entity("SchoolManagementSystem.Data.Models.Teacher", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("TeachersClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
