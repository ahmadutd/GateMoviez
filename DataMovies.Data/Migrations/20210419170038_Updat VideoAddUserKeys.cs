using Microsoft.EntityFrameworkCore.Migrations;

namespace GateMoviez.Data.Migrations
{
    public partial class UpdatVideoAddUserKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Video_UpdatedBy",
                table: "Video",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Video_AspNetUsers_UpdatedBy",
                table: "Video",
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Video_AspNetUsers_UpdatedBy",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Video_UpdatedBy",
                table: "Video");
        }
    }
}
