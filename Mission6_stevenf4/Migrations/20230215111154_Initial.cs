using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_stevenf4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "category", "director", "rating", "title", "year" },
                values: new object[] { 1, "Comedy", "Jared Hess", "PG", "Nacho Libre", 2006 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "category", "director", "rating", "title", "year" },
                values: new object[] { 2, "Adventure", "Christopher Nolan", "PG-13", "Interstellar", 2014 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "category", "director", "rating", "title", "year" },
                values: new object[] { 3, "Comedy", "Joel Crawford", "PG", "Puss in Boots: The Last Wish", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
