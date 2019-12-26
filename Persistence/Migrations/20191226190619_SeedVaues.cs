using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedVaues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Values",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "MyProperty", "Name" },
                values: new object[] { 1, 0, "Value 101" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "MyProperty", "Name" },
                values: new object[] { 2, 0, "Value 102" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "MyProperty", "Name" },
                values: new object[] { 3, 0, "Value 103" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Values");
        }
    }
}
