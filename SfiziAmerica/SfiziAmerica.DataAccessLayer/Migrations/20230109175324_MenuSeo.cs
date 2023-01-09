using Microsoft.EntityFrameworkCore.Migrations;

namespace SfiziAmerica.DataAccessLayer.Migrations
{
    public partial class MenuSeo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "seoAuthor",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoCopyright",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoDescription",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoDesign",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoFacebookDescription",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoFacebookKeywrods",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoFacebookTitle",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoFacebookUrl",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoKeywords",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoReply",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoSubject",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoTitle",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoTwitterDescription",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoTwitterKeywords",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoTwitterTitle",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seoTwitterUrl",
                schema: "dbo",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seoAuthor",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoCopyright",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoDescription",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoDesign",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoFacebookDescription",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoFacebookKeywrods",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoFacebookTitle",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoFacebookUrl",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoKeywords",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoReply",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoSubject",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoTitle",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoTwitterDescription",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoTwitterKeywords",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoTwitterTitle",
                schema: "dbo",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "seoTwitterUrl",
                schema: "dbo",
                table: "Menu");
        }
    }
}
