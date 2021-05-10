using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateMoviez.Data.Migrations
{
    public partial class UpdateArtistTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtistTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    CreatedUserId = table.Column<int>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true),
                    ArtistTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistTypes_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtistTypes_AspNetUsers_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    CreatedUserId = table.Column<int>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    LastName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Abaut = table.Column<string>(nullable: true),
                    ArtistTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_ArtistTypes_ArtistTypeId",
                        column: x => x.ArtistTypeId,
                        principalTable: "ArtistTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artists_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artists_AspNetUsers_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ArtistTypeId",
                table: "Artists",
                column: "ArtistTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_CreatedUserId",
                table: "Artists",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_UpdatedUserId",
                table: "Artists",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTypes_CreatedUserId",
                table: "ArtistTypes",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTypes_UpdatedUserId",
                table: "ArtistTypes",
                column: "UpdatedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "ArtistTypes");
        }
    }
}
