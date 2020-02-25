using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore3AndCSharp8.Migrations
{
    public partial class CatsDemoDb_First_added_more_rows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 6,
                columns: new[] { "Name", "OwnerId" },
                values: new object[] { "Hamlet", 1 });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 76, "Hamlet", 1 },
                    { 75, "King Lear1", 2 },
                    { 74, "Hamlet1", 2 },
                    { 73, "Othello", 1 },
                    { 72, "King Lear", 1 },
                    { 71, "Hamlet", 1 },
                    { 70, "King Lear1", 2 },
                    { 69, "Hamlet1", 2 },
                    { 68, "Othello", 1 },
                    { 77, "King Lear", 1 },
                    { 67, "King Lear", 1 },
                    { 65, "King Lear1", 2 },
                    { 64, "Hamlet1", 2 },
                    { 63, "Othello", 1 },
                    { 62, "King Lear", 1 },
                    { 61, "Hamlet", 1 },
                    { 60, "King Lear1", 2 },
                    { 59, "Hamlet1", 2 },
                    { 58, "Othello", 1 },
                    { 57, "King Lear", 1 },
                    { 66, "Hamlet", 1 },
                    { 55, "King Lear1", 2 },
                    { 78, "Othello", 1 },
                    { 80, "King Lear1", 2 },
                    { 100, "King Lear1", 2 },
                    { 99, "Hamlet1", 2 },
                    { 98, "Othello", 1 },
                    { 97, "King Lear", 1 },
                    { 96, "Hamlet", 1 },
                    { 95, "King Lear1", 2 },
                    { 94, "Hamlet1", 2 },
                    { 93, "Othello", 1 },
                    { 92, "King Lear", 1 },
                    { 79, "Hamlet1", 2 },
                    { 91, "Hamlet", 1 },
                    { 89, "Hamlet1", 2 },
                    { 88, "Othello", 1 },
                    { 87, "King Lear", 1 },
                    { 86, "Hamlet", 1 },
                    { 85, "King Lear1", 2 },
                    { 84, "Hamlet1", 2 },
                    { 83, "Othello", 1 },
                    { 82, "King Lear", 1 },
                    { 81, "Hamlet", 1 },
                    { 90, "King Lear1", 2 },
                    { 54, "Hamlet1", 2 },
                    { 56, "Hamlet", 1 },
                    { 52, "King Lear", 1 },
                    { 27, "King Lear", 1 },
                    { 26, "Hamlet", 1 },
                    { 25, "King Lear1", 2 },
                    { 24, "Hamlet1", 2 },
                    { 23, "Othello", 1 },
                    { 22, "King Lear", 1 },
                    { 21, "Hamlet", 1 },
                    { 20, "King Lear1", 2 },
                    { 19, "Hamlet1", 2 },
                    { 53, "Othello", 1 },
                    { 18, "Othello", 1 },
                    { 16, "Hamlet", 1 },
                    { 15, "King Lear1", 2 },
                    { 14, "Hamlet1", 2 },
                    { 13, "Othello", 1 },
                    { 12, "King Lear", 1 },
                    { 11, "Hamlet", 1 },
                    { 10, "King Lear1", 2 },
                    { 9, "Hamlet1", 2 },
                    { 8, "Othello", 1 },
                    { 17, "King Lear", 1 },
                    { 29, "Hamlet1", 2 },
                    { 28, "Othello", 1 },
                    { 31, "Hamlet", 1 },
                    { 51, "Hamlet", 1 },
                    { 50, "King Lear1", 2 },
                    { 49, "Hamlet1", 2 },
                    { 48, "Othello", 1 },
                    { 47, "King Lear", 1 },
                    { 46, "Hamlet", 1 },
                    { 45, "King Lear1", 2 },
                    { 30, "King Lear1", 2 },
                    { 43, "Othello", 1 },
                    { 42, "King Lear", 1 },
                    { 44, "Hamlet1", 2 },
                    { 40, "King Lear1", 2 },
                    { 39, "Hamlet1", 2 },
                    { 38, "Othello", 1 },
                    { 37, "King Lear", 1 },
                    { 36, "Hamlet", 1 },
                    { 35, "King Lear1", 2 },
                    { 34, "Hamlet1", 2 },
                    { 33, "Othello", 1 },
                    { 32, "King Lear", 1 },
                    { 41, "Hamlet", 1 },
                    { 7, "King Lear", 1 }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Name" },
                values: new object[,]
                {
                    { 7, "Aurin" },
                    { 3, "Parvez" },
                    { 4, "Rina" },
                    { 5, "Adnin" },
                    { 6, "Mahin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 6,
                columns: new[] { "Name", "OwnerId" },
                values: new object[] { "Othello1", 2 });
        }
    }
}
