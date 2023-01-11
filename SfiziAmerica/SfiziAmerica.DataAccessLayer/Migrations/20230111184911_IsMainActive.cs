using Microsoft.EntityFrameworkCore.Migrations;

namespace SfiziAmerica.DataAccessLayer.Migrations
{
    public partial class IsMainActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMainActive",
                schema: "dbo",
                table: "MenuCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMainActive",
                schema: "dbo",
                table: "Catering",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMainActive",
                schema: "dbo",
                table: "MenuCategory");

            migrationBuilder.DropColumn(
                name: "IsMainActive",
                schema: "dbo",
                table: "Catering");
        }
    }
}
