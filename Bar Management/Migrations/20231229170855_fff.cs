using Microsoft.EntityFrameworkCore.Migrations;

namespace Bar_Management.Migrations
{
    public partial class fff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NhaCungCapId",
                table: "TonKhos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TonKhos_NhaCungCapId",
                table: "TonKhos",
                column: "NhaCungCapId");

            migrationBuilder.AddForeignKey(
                name: "FK_TonKhos_NhaCungCaps_NhaCungCapId",
                table: "TonKhos",
                column: "NhaCungCapId",
                principalTable: "NhaCungCaps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TonKhos_NhaCungCaps_NhaCungCapId",
                table: "TonKhos");

            migrationBuilder.DropIndex(
                name: "IX_TonKhos_NhaCungCapId",
                table: "TonKhos");

            migrationBuilder.DropColumn(
                name: "NhaCungCapId",
                table: "TonKhos");
        }
    }
}
