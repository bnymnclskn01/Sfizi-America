using Microsoft.EntityFrameworkCore.Migrations;

namespace SfiziAmerica.DataAccessLayer.Migrations
{
    public partial class CreateandRemoveIsMainActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMainActive",
                schema: "dbo",
                table: "MenuCategory");

            migrationBuilder.AddColumn<bool>(
                name: "IsMainActive",
                schema: "dbo",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMainActive",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.AddColumn<bool>(
                name: "IsMainActive",
                schema: "dbo",
                table: "MenuCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
