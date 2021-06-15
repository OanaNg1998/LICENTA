﻿// <auto-generated />
using System;
using JUSTMOVE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JUSTMOVE.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210601175531_addeddatafororder")]
    partial class addeddatafororder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            City = "Ploiesti",
                            County = "Prahova",
                            Street = "Bulevardul Republicii",
                            StreetNumber = 17
                        },
                        new
                        {
                            Id = "2",
                            City = "Ploiesti",
                            County = "Prahova",
                            Street = "Bulevardul Republicii",
                            StreetNumber = 25
                        },
                        new
                        {
                            Id = "3",
                            City = "Bucuresti",
                            County = "Bucuresti",
                            Street = "Constantin Aricescu",
                            StreetNumber = 12
                        },
                        new
                        {
                            Id = "4",
                            City = "Bucuresti",
                            County = "Bucuresti",
                            Street = "Padesu",
                            StreetNumber = 2
                        },
                        new
                        {
                            Id = "5",
                            City = "Cluj-Napoca",
                            County = "Cluj",
                            Street = "Avram Iancu",
                            StreetNumber = 492
                        },
                        new
                        {
                            Id = "6",
                            City = "Cluj-Napoca",
                            County = "Cluj",
                            Street = "Alexandru Vaida Voevod",
                            StreetNumber = 53
                        },
                        new
                        {
                            Id = "7",
                            City = "Bucuresti",
                            County = "Bucuresti",
                            Street = "Tarnave",
                            StreetNumber = 10
                        });
                });

            modelBuilder.Entity("JUSTMOVE.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AddressId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntrestDomain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            AddressId = "2",
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "c0468ef6-0f77-449f-ae17-e9aa921d5af3",
                            EmailConfirmed = false,
                            FirstName = "Neagu",
                            Gender = "femeie",
                            IntrestDomain = "Fitness",
                            LastName = "Oana",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a10b31fa-3ce3-4126-8e9a-05a2231a39d7",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("JUSTMOVE.Models.Equipment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderHistoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderHistoryId");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Brand = "Nike",
                            Category = "tshirt",
                            Gender = "woman",
                            Image = "https://i.ibb.co/j5qD0gp/new-crop-top.png",
                            Price = 100,
                            ProductName = "Nike Crop Top",
                            Quantity = 1
                        },
                        new
                        {
                            Id = "2",
                            Brand = "Adidas",
                            Category = "shorts",
                            Gender = "male",
                            Image = "https://i.ibb.co/GTBzGt4/adidas-man-shorts.jpg",
                            Price = 200,
                            ProductName = "Adidas Man Shorts",
                            Quantity = 1
                        },
                        new
                        {
                            Id = "3",
                            Brand = "Nike",
                            Category = "trousers",
                            Gender = "woman",
                            Image = "https://i.ibb.co/zVTD7HK/nike-trousers.jpg",
                            Price = 250,
                            ProductName = "Nike Running Trousers",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("JUSTMOVE.Models.Gym", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DailyClosingHour")
                        .HasColumnType("int");

                    b.Property<int>("DailyOpenHour")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeekendClosingHour")
                        .HasColumnType("int");

                    b.Property<int>("WeekendOpenHour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Gym");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AddressId = "1",
                            DailyClosingHour = 22,
                            DailyOpenHour = 6,
                            Name = "Titan Academy",
                            WeekendClosingHour = 20,
                            WeekendOpenHour = 8
                        },
                        new
                        {
                            Id = "2",
                            AddressId = "2",
                            DailyClosingHour = 23,
                            DailyOpenHour = 7,
                            Name = "MaxGym Club",
                            WeekendClosingHour = 21,
                            WeekendOpenHour = 7
                        },
                        new
                        {
                            Id = "3",
                            AddressId = "3",
                            DailyClosingHour = 22,
                            DailyOpenHour = 8,
                            Icon = "https://i.ibb.co/LJTxjNF/movement-studio.png",
                            Name = "Movement Studio",
                            WeekendClosingHour = 18,
                            WeekendOpenHour = 9
                        },
                        new
                        {
                            Id = "4",
                            AddressId = "4",
                            DailyClosingHour = 22,
                            DailyOpenHour = 7,
                            Icon = "https://i.ibb.co/wy6BzPJ/lotusclub-padesu.png",
                            Name = "LotusClub Padesu",
                            WeekendClosingHour = 18,
                            WeekendOpenHour = 7
                        },
                        new
                        {
                            Id = "5",
                            AddressId = "5",
                            DailyClosingHour = 22,
                            DailyOpenHour = 6,
                            Name = "WorldClass Vivo",
                            WeekendClosingHour = 21,
                            WeekendOpenHour = 8
                        },
                        new
                        {
                            Id = "6",
                            AddressId = "6",
                            DailyClosingHour = 20,
                            DailyOpenHour = 7,
                            Name = "SerGym",
                            WeekendClosingHour = 20,
                            WeekendOpenHour = 8
                        });
                });

            modelBuilder.Entity("JUSTMOVE.Models.GymInstructors", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GymId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstructorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.HasIndex("InstructorId");

                    b.ToTable("GymInstructors");
                });

            modelBuilder.Entity("JUSTMOVE.Models.GymTrainings", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GymId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrainingId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.HasIndex("TrainingId");

                    b.ToTable("GymTrainings");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Instructor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CareerHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("JUSTMOVE.Models.InstructorTrainings", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstructorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrainingId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("TrainingId");

                    b.ToTable("InstructorTrainings");
                });

            modelBuilder.Entity("JUSTMOVE.Models.OrderHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompleteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderHistory");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Subscription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GymId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Training", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndHour")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartHour")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("JUSTMOVE.Models.UserSubscription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GymId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubscriptionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.HasIndex("SubscriptionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSubscriptions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JUSTMOVE.Models.ApplicationUser", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Equipment", b =>
                {
                    b.HasOne("JUSTMOVE.Models.OrderHistory", null)
                        .WithMany("Equipment")
                        .HasForeignKey("OrderHistoryId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Gym", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.GymInstructors", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Gym", "Gym")
                        .WithMany("GymInstructors")
                        .HasForeignKey("GymId");

                    b.HasOne("JUSTMOVE.Models.Instructor", "Instructor")
                        .WithMany("GymInstructors")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.GymTrainings", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Gym", "Gym")
                        .WithMany("GymTrainings")
                        .HasForeignKey("GymId");

                    b.HasOne("JUSTMOVE.Models.Training", "Training")
                        .WithMany("GymTrainings")
                        .HasForeignKey("TrainingId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.InstructorTrainings", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Instructor", "Instructor")
                        .WithMany("InstructorTrainings")
                        .HasForeignKey("InstructorId");

                    b.HasOne("JUSTMOVE.Models.Training", "Training")
                        .WithMany("InstructorTrainings")
                        .HasForeignKey("TrainingId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.Subscription", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Gym", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("GymId");
                });

            modelBuilder.Entity("JUSTMOVE.Models.UserSubscription", b =>
                {
                    b.HasOne("JUSTMOVE.Models.Gym", "Gym")
                        .WithMany()
                        .HasForeignKey("GymId");

                    b.HasOne("JUSTMOVE.Models.Subscription", "Subscription")
                        .WithMany("UserSubscriptions")
                        .HasForeignKey("SubscriptionId");

                    b.HasOne("JUSTMOVE.Models.ApplicationUser", "User")
                        .WithMany("UserSubscription")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JUSTMOVE.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JUSTMOVE.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JUSTMOVE.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JUSTMOVE.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
