using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466014669034568L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466014669035428L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466014669035436L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466014669036270L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466014669037081L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466014669037088L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466014669018716L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466014669033590L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466014669033612L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466014669033616L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466014669033618L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466014669033620L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "CrustID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466042997369968L, "Thin", 2.00m },
                    { 637466042997370869L, "Thick", 3.00m },
                    { 637466042997370876L, "Cheese-Stuffed", 4.00m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466042997371679L, "Medium", 12.00m },
                    { 637466042997372517L, "Large", 15.00m },
                    { 637466042997372526L, "X-Large", 18.00m }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "ToppingID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466042997353000L, "Cheese", 0.99m },
                    { 637466042997368870L, "Pineapple", 1.50m },
                    { 637466042997368900L, "Ham", 1.99m },
                    { 637466042997368904L, "Pepperoni", 1.99m },
                    { 637466042997368906L, "Sausage", 1.99m },
                    { 637466042997368908L, "Sauce", 1.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466042997369968L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466042997370869L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466042997370876L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466042997371679L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466042997372517L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466042997372526L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466042997353000L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466042997368870L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466042997368900L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466042997368904L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466042997368906L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466042997368908L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "CrustID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466014669034568L, "Thin", 2.00m },
                    { 637466014669035428L, "Thick", 3.00m },
                    { 637466014669035436L, "Cheese-Stuffed", 4.00m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466014669036270L, "Medium", 12.00m },
                    { 637466014669037081L, "Large", 15.00m },
                    { 637466014669037088L, "X-Large", 18.00m }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "ToppingID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466014669018716L, "Cheese", 0.99m },
                    { 637466014669033590L, "Pineapple", 1.50m },
                    { 637466014669033612L, "Ham", 1.99m },
                    { 637466014669033616L, "Pepperoni", 1.99m },
                    { 637466014669033618L, "Sausage", 1.99m },
                    { 637466014669033620L, "Sauce", 1.99m }
                });
        }
    }
}
