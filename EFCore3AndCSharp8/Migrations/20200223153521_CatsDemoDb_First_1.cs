using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore3AndCSharp8.Migrations
{
    public partial class CatsDemoDb_First_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Name" },
                values: new object[] { 1, "Hasan" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Name" },
                values: new object[] { 2, "Faisan" });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 1, "Hamlet", 1 },
                    { 2, "King Lear", 1 },
                    { 3, "Othello", 1 },
                    { 4, "Hamlet1", 2 },
                    { 5, "King Lear1", 2 },
                    { 6, "Othello1", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 2);
        }
    }
}
