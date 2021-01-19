using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637465838354734483L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637465838354735543L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustID",
                keyValue: 637465838354735553L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637465838354736353L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637465838354737204L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeID",
                keyValue: 637465838354737211L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637465838354718217L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637465838354733440L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637465838354733462L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637465838354733466L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637465838354733468L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingID",
                keyValue: 637465838354733470L);

            migrationBuilder.DropColumn(
                name: "StoreEntityID",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pizza",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Order");

            migrationBuilder.AddColumn<long>(
                name: "StoreEntityID",
                table: "Order",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "CrustID", "Name", "Price" },
                values: new object[,]
                {
                    { 637465838354734483L, "Thin", 2.00m },
                    { 637465838354735543L, "Thick", 3.00m },
                    { 637465838354735553L, "Cheese-Stuffed", 4.00m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeID", "Name", "Price" },
                values: new object[,]
                {
                    { 637465838354736353L, "Medium", 12.00m },
                    { 637465838354737204L, "Large", 15.00m },
                    { 637465838354737211L, "X-Large", 18.00m }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "ToppingID", "Name", "Price" },
                values: new object[,]
                {
                    { 637465838354718217L, "Cheese", 0.99m },
                    { 637465838354733440L, "Pineapple", 1.50m },
                    { 637465838354733462L, "Ham", 1.99m },
                    { 637465838354733466L, "Pepperoni", 1.99m },
                    { 637465838354733468L, "Sausage", 1.99m },
                    { 637465838354733470L, "Sauce", 1.99m }
                });
        }
    }
}
