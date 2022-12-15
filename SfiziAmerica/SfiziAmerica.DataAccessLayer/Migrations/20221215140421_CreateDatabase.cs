using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SfiziAmerica.DataAccessLayer.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "About",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForm",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForm", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BookComment",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookComment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Catering",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentCateringID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Catering", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Catering_Catering_ParentCategoryID",
                        column: x => x.ParentCategoryID,
                        principalSchema: "dbo",
                        principalTable: "Catering",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactForm",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForm", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSigin",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSigin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MailSetting",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    senderMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senderMailPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serverMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serverPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailSetting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategory",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_MenuCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuCategory_MenuCategory_MenuCategoryID",
                        column: x => x.MenuCategoryID,
                        principalSchema: "dbo",
                        principalTable: "MenuCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuSeo",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_MenuSeo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mision",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mision", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rezervation",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    ImageVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vision",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vision", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CateringMenu",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CateringID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CateringMenu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CateringMenu_Catering_CateringID",
                        column: x => x.CateringID,
                        principalSchema: "dbo",
                        principalTable: "Catering",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMenu",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMenu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryMenu_Menu_MenuID",
                        column: x => x.MenuID,
                        principalSchema: "dbo",
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMenu_MenuCategory_MenuCategoryID",
                        column: x => x.MenuCategoryID,
                        principalSchema: "dbo",
                        principalTable: "MenuCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMember",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMember", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserMember_UserRole_UserRoleID",
                        column: x => x.UserRoleID,
                        principalSchema: "dbo",
                        principalTable: "UserRole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMenu_MenuCategoryID",
                schema: "dbo",
                table: "CategoryMenu",
                column: "MenuCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMenu_MenuID",
                schema: "dbo",
                table: "CategoryMenu",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Catering_ParentCategoryID",
                schema: "dbo",
                table: "Catering",
                column: "ParentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CateringMenu_CateringID",
                schema: "dbo",
                table: "CateringMenu",
                column: "CateringID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategory_MenuCategoryID",
                schema: "dbo",
                table: "MenuCategory",
                column: "MenuCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMember_UserRoleID",
                schema: "dbo",
                table: "UserMember",
                column: "UserRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationForm",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BookComment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CategoryMenu",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CateringMenu",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ContactForm",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ContactInformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerSigin",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "HR",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MailSetting",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MenuSeo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Mision",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Rezervation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Slider",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SocialMedia",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserMember",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Vision",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MenuCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Catering",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "dbo");
        }
    }
}
