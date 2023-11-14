using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace day2.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoData",
                table: "Author");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Author",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Author");

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoData",
                table: "Author",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
