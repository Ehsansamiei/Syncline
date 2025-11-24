using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Syncline.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RoomIdadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ChatMessages",
                newName: "SentAt");

            migrationBuilder.AddColumn<string>(
                name: "RoomId",
                table: "ChatMessages",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "ChatMessages");

            migrationBuilder.RenameColumn(
                name: "SentAt",
                table: "ChatMessages",
                newName: "CreatedAt");
        }
    }
}
