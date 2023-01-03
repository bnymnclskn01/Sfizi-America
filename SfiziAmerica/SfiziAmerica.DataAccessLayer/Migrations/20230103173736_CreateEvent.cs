using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SfiziAmerica.DataAccessLayer.Migrations
{
    public partial class CreateEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    seoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoCopyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoTwitterKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoTwitterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoFacebookKeywrods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoFacebookDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
