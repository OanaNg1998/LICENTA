using IdentityServer4.EntityFramework.Options;
using JUSTMOVE.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Gym> Gym { get; set; }
        public DbSet<GymInstructors> GymInstructors { get; set; }
        public DbSet<GymTrainings> GymTrainings { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorTrainings> InstructorTrainings { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }

        public DbSet<NutritionProduct> NutritionProduct { get; set; }
        public DbSet<SaleQRCode> SaleQRCode { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Address>().HasData(new Address { Id = "1", City = "Ploiesti", County = "Prahova", Street = "Bulevardul Republicii", StreetNumber = 17 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = "2", City = "Ploiesti", County = "Prahova", Street = "Bulevardul Republicii", StreetNumber = 25 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = "3", City = "Bucuresti", County = "Bucuresti", Street = "Constantin Aricescu", StreetNumber = 12 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = "4", City = "Bucuresti", County = "Bucuresti", Street = "Padesu", StreetNumber = 2 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = "5", City = "Cluj-Napoca", County = "Cluj", Street = "Avram Iancu", StreetNumber = 492 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = "6", City = "Cluj-Napoca", County = "Cluj", Street = "Alexandru Vaida Voevod", StreetNumber = 53 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = "7", City = "Bucuresti", County = "Bucuresti", Street = "Tarnave", StreetNumber = 10 });

            modelBuilder.Entity<Gym>().ToTable("Gym");
            modelBuilder.Entity<Gym>().HasData(new Gym { Id = "1", Name = "Titan Academy", DailyOpenHour = 6, DailyClosingHour = 22, WeekendOpenHour = 8, WeekendClosingHour = 20,AddressId = "1" });
            modelBuilder.Entity<Gym>().HasData(new Gym { Id = "2", Name = "MaxGym Club", DailyOpenHour = 7, DailyClosingHour = 23, WeekendOpenHour = 7, WeekendClosingHour = 21, AddressId = "2" });
            modelBuilder.Entity<Gym>().HasData(new Gym { Id = "3", Name = "Movement Studio", DailyOpenHour = 8, DailyClosingHour = 22, WeekendOpenHour = 9, WeekendClosingHour = 18,Icon= "https://i.ibb.co/LJTxjNF/movement-studio.png", AddressId = "3" });
            modelBuilder.Entity<Gym>().HasData(new Gym { Id = "4", Name = "LotusClub Padesu", DailyOpenHour = 7, DailyClosingHour = 22, WeekendOpenHour = 7, WeekendClosingHour = 18, Icon = "https://i.ibb.co/wy6BzPJ/lotusclub-padesu.png", AddressId = "4" });
            modelBuilder.Entity<Gym>().HasData(new Gym { Id = "5", Name = "WorldClass Vivo", DailyOpenHour = 6, DailyClosingHour = 22, WeekendOpenHour = 8, WeekendClosingHour = 21, AddressId = "5" });
            modelBuilder.Entity<Gym>().HasData(new Gym { Id = "6", Name = "SerGym", DailyOpenHour = 7, DailyClosingHour = 20, WeekendOpenHour = 8, WeekendClosingHour = 20, AddressId = "6" });

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { Id = "1", FirstName = "Neagu", LastName = "Oana", AddressId = "2", Gender = "femeie", IntrestDomain = "Fitness" });

            modelBuilder.Entity<Equipment>().ToTable("Equipment");
            modelBuilder.Entity<Equipment>().HasData(new Equipment { Id = "1", ProductName = "Nike Crop Top", Category = "tshirt", Price = 100, Image= "https://i.ibb.co/j5qD0gp/new-crop-top.png",Gender="woman",Quantity=1,Brand="Nike"});
            modelBuilder.Entity<Equipment>().HasData(new Equipment { Id = "2", ProductName = "Adidas Man Shorts", Category = "shorts", Price = 200, Image = "https://i.ibb.co/GTBzGt4/adidas-man-shorts.jpg",Gender="male", Quantity = 1,Brand="Adidas" });
            modelBuilder.Entity<Equipment>().HasData(new Equipment { Id = "3", ProductName = "Nike Running Trousers", Category = "trousers", Price = 250, Image = "https://i.ibb.co/zVTD7HK/nike-trousers.jpg", Gender = "woman", Quantity = 1 ,Brand="Nike"});

            modelBuilder.Entity<NutritionProduct>().ToTable("NutritionProduct");
            modelBuilder.Entity<NutritionProduct>().HasData(new NutritionProduct { Id = "1", ProductName = "Nutrend Protein Bar", Category = "protein bar", Price = 10, Image = "https://i.ibb.co/CzWs55t/protein-bar1.png", Weight = "85g", Quantity = 1, Brand = "Nutrend" });
            modelBuilder.Entity<NutritionProduct>().HasData(new NutritionProduct { Id = "2", ProductName = "Whey Protein Powder", Category = "protein pouder", Price = 150, Image = "https://i.ibb.co/vQQ71dX/protein-powder.jpg", Weight = "500g", Quantity = 1, Brand = "Pro Nutrition" });
            modelBuilder.Entity<NutritionProduct>().HasData(new NutritionProduct { Id = "3", ProductName = "KIND Protein Bar", Category = "protein bar", Price = 11, Image = "https://i.ibb.co/swNz3r7/protein-bar2.png", Weight = "60g", Quantity = 1, Brand = "KIND" });

        }

    }
}
