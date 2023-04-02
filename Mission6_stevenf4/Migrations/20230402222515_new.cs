using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_stevenf4.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "edited",
                table: "Responses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "lentTo",
                table: "Responses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "MovieID",
                keyValue: 1,
                column: "lentTo",
                value: "Steven");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "edited", "lentTo" },
                values: new object[] { true, "" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "MovieID",
                keyValue: 3,
                column: "lentTo",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "edited",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "lentTo",
                table: "Responses");
        }
    }
}
