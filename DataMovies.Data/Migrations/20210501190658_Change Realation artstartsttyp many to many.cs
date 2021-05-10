using Microsoft.EntityFrameworkCore.Migrations;

namespace GateMoviez.Data.Migrations
{
    public partial class ChangeRealationartstartsttypmanytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_ArtistTypes_ArtistTypeId",
                table: "Artists");

            migrationBuilder.DropIndex(
                name: "IX_Artists_ArtistTypeId",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "ArtistTypeId",
                table: "Artists");

            migrationBuilder.AlterColumn<string>(
                name: "ArtistTypeName",
                table: "ArtistTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Artist_ArtistTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(nullable: false),
                    ArtistTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist_ArtistTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artist_ArtistTypes_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artist_ArtistTypes_ArtistTypes_ArtistTypeId",
                        column: x => x.ArtistTypeId,
                        principalTable: "ArtistTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ArtistTypes_ArtistId",
                table: "Artist_ArtistTypes",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ArtistTypes_ArtistTypeId",
                table: "Artist_ArtistTypes",
                column: "ArtistTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist_ArtistTypes");

            migrationBuilder.AlterColumn<string>(
                name: "ArtistTypeName",
                table: "ArtistTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ArtistTypeId",
                table: "Artists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ArtistTypeId",
                table: "Artists",
                column: "ArtistTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_ArtistTypes_ArtistTypeId",
                table: "Artists",
                column: "ArtistTypeId",
                principalTable: "ArtistTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
