﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeniorCollegeScheduler.Data;

namespace SeniorCollegeScheduler.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200228175655_AddedInstructorTable")]
    partial class AddedInstructorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SeniorCollegeScheduler.Models.DataModels.User", b =>
                {
                    b.Property<Guid>("InstructorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasMaxLength(25);

                    b.Property<string>("InstructorBio");

                    b.Property<string>("LandlinePhone")
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .HasMaxLength(25);

                    b.Property<string>("MobilePhone")
                        .HasMaxLength(10);

                    b.Property<bool>("ShareEmail");

                    b.Property<bool>("ShareLandline");

                    b.Property<bool>("ShareMobilePhone");

                    b.Property<string>("State")
                        .HasMaxLength(2);

                    b.Property<string>("StreetAddress")
                        .HasMaxLength(45);

                    b.Property<string>("ZipCode")
                        .HasMaxLength(5);

                    b.Property<string>("city")
                        .HasMaxLength(25);

                    b.HasKey("InstructorId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("SeniorCollegeScheduler.Models.ProposedClass", b =>
                {
                    b.Property<int>("ProposedID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChairsNeeded");

                    b.Property<string>("CourseDescription");

                    b.Property<bool>("DVDAndVCRPlayer");

                    b.Property<bool>("DryEraseBoard");

                    b.Property<bool>("FridayAfternoon");

                    b.Property<bool>("FridayEvening");

                    b.Property<bool>("FridayMorning");

                    b.Property<double>("HandoutCost");

                    b.Property<bool>("InternetConnection");

                    b.Property<bool>("IsReviewed");

                    b.Property<int>("LengthOfSession");

                    b.Property<int>("MaxStudentCount");

                    b.Property<bool>("MicrophoneAndSound");

                    b.Property<int>("MinStudentCount");

                    b.Property<bool>("MondayAfternoon");

                    b.Property<bool>("MondayEvening");

                    b.Property<bool>("MondayMorning");

                    b.Property<int>("NumberOfSessions");

                    b.Property<string>("OtherEquipmentNeeded");

                    b.Property<string>("PCConnectionType");

                    b.Property<bool>("Podium");

                    b.Property<string>("PreRequisite");

                    b.Property<bool>("ProjectorWithScreen");

                    b.Property<DateTime>("ProposedDate");

                    b.Property<string>("ProposedTitle");

                    b.Property<bool>("SaturdayAfternoon");

                    b.Property<bool>("SaturdayEvening");

                    b.Property<bool>("SaturdayMorning");

                    b.Property<bool>("StipendRequested");

                    b.Property<bool>("SundayAfternoon");

                    b.Property<bool>("SundayEvening");

                    b.Property<bool>("SundayMorning");

                    b.Property<int>("TablesNeeded");

                    b.Property<bool>("ThursdayAfternoon");

                    b.Property<bool>("ThursdayEvening");

                    b.Property<bool>("ThursdayMorning");

                    b.Property<bool>("TuesdayAfternoon");

                    b.Property<bool>("TuesdayEvening");

                    b.Property<bool>("TuesdayMorning");

                    b.Property<string>("UnavailableTimes");

                    b.Property<bool>("WednesdayAfternoon");

                    b.Property<bool>("WednesdayEvening");

                    b.Property<bool>("WednesdayMorning");

                    b.HasKey("ProposedID");

                    b.ToTable("ProposedClass");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
