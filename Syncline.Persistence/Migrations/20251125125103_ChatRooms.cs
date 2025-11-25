using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Syncline.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChatRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChatRoomId",
                table: "ChatMessages",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChatRooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatRooms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ChatRoomId",
                table: "ChatMessages",
                column: "ChatRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatRooms_ChatRoomId",
                table: "ChatMessages",
                column: "ChatRoomId",
                principalTable: "ChatRooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatRooms_ChatRoomId",
                table: "ChatMessages");

            migrationBuilder.DropTable(
                name: "ChatRooms");

            migrationBuilder.DropIndex(
                name: "IX_ChatMessages_ChatRoomId",
                table: "ChatMessages");

            migrationBuilder.DropColumn(
                name: "ChatRoomId",
                table: "ChatMessages");
        }
    }
}
