using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "No Internet",
                Price = new decimal (69.9),
                Description = "Camiseta no Internet",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Vader",
                Price = new decimal(79.9),
                Description = "Capacete Vade",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/3_vader.jpg",
                CategoryName = "Toy"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Storm Tropper",
                Price = new decimal(89.9),
                Description = "Boneco Storm Tropper",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg",
                CategoryName = "Toy"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "100 Gamer",
                Price = new decimal(69.9),
                Description = "Camiseta 100 Gamer",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Space X",
                Price = new decimal(69.9),
                Description = "Camiseta Space X",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/6_spacex.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Coffe",
                Price = new decimal(69.9),
                Description = "Camiseta Coffe",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/7_coffee.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Cobra Kay",
                Price = new decimal(69.9),
                Description = "Moletom Cobra Kay",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg",
                CategoryName = "Blusa"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Neil",
                Price = new decimal(109.9),
                Description = "Neil",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/9_neil.jpg",
                CategoryName = "Book"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Milennium Falcon",
                Price = new decimal(109.9),
                Description = "Milennium Falcon",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg",
                CategoryName = "Toy"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Mars",
                Price = new decimal(69.9),
                Description = "Occupy Mars",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/11_mars.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Gnu Linux",
                Price = new decimal(69.9),
                Description = "Gnu Linux Freedom",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Dragon Ball",
                Price = new decimal(69.9),
                Description = "Dragon Ball",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Nasa",
                Price = new decimal(69.9),
                Description = "Patch Nasa",
                ImageURL = "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/14_patch_nasa.jpg",
                CategoryName = "T-Shirt"
            });
        }
    }
}
