using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    provCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    provName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.provCode);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    cityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cityName = table.Column<string>(type: "TEXT", nullable: true),
                    population = table.Column<int>(type: "INTEGER", nullable: true),
                    province = table.Column<string>(type: "TEXT", nullable: true),
                    ProvinceprovCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.cityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceprovCode",
                        column: x => x.ProvinceprovCode,
                        principalTable: "Provinces",
                        principalColumn: "provCode");
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 1, null, "Vancouver", 12345, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 2, null, "Victoria", 23456, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 3, null, "Surrey", 34567, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 4, null, "Edmonton", 12345, "AB" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 5, null, "Calgary", 23456, "AB" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 6, null, "Red Deer", 34567, "AB" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 7, null, "Toronto", 12345, "ON" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 8, null, "Ottawa", 23456, "ON" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "cityId", "ProvinceprovCode", "cityName", "population", "province" },
                values: new object[] { 9, null, "Kanata", 34567, "ON" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "provCode", "provName" },
                values: new object[] { "AB", "Alberta" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "provCode", "provName" },
                values: new object[] { "BC", "British Columbia" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "provCode", "provName" },
                values: new object[] { "ON", "Ontario" });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceprovCode",
                table: "Cities",
                column: "ProvinceprovCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
