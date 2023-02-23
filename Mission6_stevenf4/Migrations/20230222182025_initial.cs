using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_stevenf4.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryID = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 2, "Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 3, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 4, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 5, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 6, "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 7, "Mystery" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 8, "Romance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 9, "Thriller" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "categoryID", "director", "rating", "title", "year" },
                values: new object[] { 2, 2, "Christopher Nolan", "PG-13", "Interstellar", 2014 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "categoryID", "director", "rating", "title", "year" },
                values: new object[] { 1, 3, "Jared Hess", "PG", "Nacho Libre", 2006 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "categoryID", "director", "rating", "title", "year" },
                values: new object[] { 3, 3, "Joel Crawford", "PG", "Puss in Boots: The Last Wish", 2022 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_categoryID",
                table: "Responses",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
