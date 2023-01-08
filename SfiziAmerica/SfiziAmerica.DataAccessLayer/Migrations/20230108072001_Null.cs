using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SfiziAmerica.DataAccessLayer.Migrations
{
    public partial class Null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMenu_Menu_MenuID",
                schema: "dbo",
                table: "CategoryMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMenu_MenuCategory_MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu");

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuID",
                schema: "dbo",
                table: "CategoryMenu",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMenu_Menu_MenuID",
                schema: "dbo",
                table: "CategoryMenu",
                column: "MenuID",
                principalSchema: "dbo",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMenu_MenuCategory_MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu",
                column: "MenuCategoryID",
                principalSchema: "dbo",
                principalTable: "MenuCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMenu_Menu_MenuID",
                schema: "dbo",
                table: "CategoryMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMenu_MenuCategory_MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu");

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuID",
                schema: "dbo",
                table: "CategoryMenu",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMenu_Menu_MenuID",
                schema: "dbo",
                table: "CategoryMenu",
                column: "MenuID",
                principalSchema: "dbo",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMenu_MenuCategory_MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu",
                column: "MenuCategoryID",
                principalSchema: "dbo",
                principalTable: "MenuCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
