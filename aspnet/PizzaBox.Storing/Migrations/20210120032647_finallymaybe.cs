using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class finallymaybe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 637466884071097646L, "Thin", 2.00m },
                    { 637466884071098528L, "Thick", 3.00m },
                    { 637466884071098535L, "Cheese-Stuffed", 4.00m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466884071099618L, "Medium", 12.00m },
                    { 637466884071100450L, "Large", 15.00m },
                    { 637466884071100457L, "X-Large", 18.00m }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "ToppingID", "Name", "Price" },
                values: new object[,]
                {
                    { 637466884071082569L, "Cheese", 0.99m },
                    { 637466884071096763L, "Pineapple", 1.50m },
                    { 637466884071096785L, "Ham", 1.99m },
                    { 637466884071096789L, "Pepperoni", 1.99m },
                    { 637466884071096791L, "Sausage", 1.99m },
                    { 637466884071096794L, "Sauce", 1.99m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Name" },
                values: new object[] { 2L, "Ashley" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466884071097646L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466884071098528L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637466884071098535L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466884071099618L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466884071100450L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637466884071100457L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466884071082569L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466884071096763L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466884071096785L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466884071096789L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466884071096791L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637466884071096794L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2L);

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
    }
}
