using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-Shirt", "Camiseta no Internet", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg", "No Internet", 69.9m },
                    { 3L, "Toy", "Capacete Vade", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/3_vader.jpg", "Vader", 79.9m },
                    { 4L, "Toy", "Boneco Storm Tropper", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg", "Storm Tropper", 89.9m },
                    { 5L, "T-Shirt", "Camiseta 100 Gamer", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg", "100 Gamer", 69.9m },
                    { 6L, "T-Shirt", "Camiseta Space X", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/6_spacex.jpg", "Space X", 69.9m },
                    { 7L, "T-Shirt", "Camiseta Coffe", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/7_coffee.jpg", "Coffe", 69.9m },
                    { 8L, "Blusa", "Moletom Cobra Kay", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg", "Cobra Kay", 69.9m },
                    { 9L, "Book", "Neil", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/9_neil.jpg", "Neil", 109.9m },
                    { 10L, "Toy", "Milennium Falcon", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg", "Milennium Falcon", 109.9m },
                    { 11L, "T-Shirt", "Occupy Mars", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/11_mars.jpg", "Mars", 69.9m },
                    { 12L, "T-Shirt", "Gnu Linux Freedom", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg", "Gnu Linux", 69.9m },
                    { 13L, "T-Shirt", "Dragon Ball", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Dragon Ball", 69.9m },
                    { 14L, "T-Shirt", "Patch Nasa", "https://github.com/ViniciusOrram/Microservice-dotnet6/blob/main/ShoppingImages/14_patch_nasa.jpg", "Nasa", 69.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);
        }
    }
}
