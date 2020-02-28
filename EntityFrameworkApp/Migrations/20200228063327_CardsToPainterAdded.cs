using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkApp.Migrations
{
    public partial class CardsToPainterAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Painters_painterId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_setId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "setId",
                table: "Cards",
                newName: "SetId");

            migrationBuilder.RenameColumn(
                name: "painterId",
                table: "Cards",
                newName: "PainterId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_setId",
                table: "Cards",
                newName: "IX_Cards_SetId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_painterId",
                table: "Cards",
                newName: "IX_Cards_PainterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Painters_PainterId",
                table: "Cards",
                column: "PainterId",
                principalTable: "Painters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sets_SetId",
                table: "Cards",
                column: "SetId",
                principalTable: "Sets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Painters_PainterId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_SetId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "SetId",
                table: "Cards",
                newName: "setId");

            migrationBuilder.RenameColumn(
                name: "PainterId",
                table: "Cards",
                newName: "painterId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_SetId",
                table: "Cards",
                newName: "IX_Cards_setId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_PainterId",
                table: "Cards",
                newName: "IX_Cards_painterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Painters_painterId",
                table: "Cards",
                column: "painterId",
                principalTable: "Painters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sets_setId",
                table: "Cards",
                column: "setId",
                principalTable: "Sets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
