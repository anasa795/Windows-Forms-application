using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace day2.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Posts",
                type: "date(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Posts",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date(7)",
                oldNullable: true);
        }
    }
}
