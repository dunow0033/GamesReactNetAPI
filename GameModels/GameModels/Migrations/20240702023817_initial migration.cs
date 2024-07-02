using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameModels.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ImageUrl", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "https://tombraiders.net/stella/images/timeline/tomb_raider_1_box.jpg", "Tomb Raider", "1996" },
                    { 2, "https://tombraiders.net/stella/images/timeline/tomb_raider_2_box.jpg", "Tomb Raider 2", "1997" },
                    { 3, "https://tombraiders.net/stella/images/timeline/tomb_raider_3_box.jpg", "Tomb Raider 3", "1998" },
                    { 4, "https://tombraiders.net/stella/images/timeline/tomb_raider_4_box.jpg", "Tomb Raider The Last Revelation", "1999" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
