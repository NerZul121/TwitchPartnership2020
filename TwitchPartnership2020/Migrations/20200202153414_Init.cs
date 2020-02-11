using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitchPartnership2020.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertiser",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contacts = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PurseID = table.Column<int>(nullable: false),
                    AuthID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertiser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Appeal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    ViewID = table.Column<int>(nullable: false),
                    StreamID = table.Column<int>(nullable: false),
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Change_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appeal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Auth",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Summ = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    PurseID = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Purse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentBalance = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stream",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreamerID = table.Column<int>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ChangeDate = table.Column<DateTime>(nullable: true),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stream", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "View",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerID = table.Column<int>(nullable: false),
                    StreamID = table.Column<int>(nullable: false),
                    Viewers = table.Column<int>(nullable: false),
                    AuthViewers = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Platform = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(nullable: true),
                    Whitelist = table.Column<int>(nullable: true),
                    Delay = table.Column<int>(nullable: true),
                    AdvertiserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Banner_Advertiser_AdvertiserID",
                        column: x => x.AdvertiserID,
                        principalTable: "Advertiser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thematic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrition = table.Column<string>(nullable: true),
                    StreamID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thematic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Thematic_Stream_StreamID",
                        column: x => x.StreamID,
                        principalTable: "Stream",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertiserID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CostPerView = table.Column<float>(nullable: false),
                    CostPerClick = table.Column<float>(nullable: false),
                    CostPerTrueView = table.Column<float>(nullable: false),
                    Whitelist = table.Column<int>(nullable: true),
                    Platforms = table.Column<string>(nullable: true),
                    WhitelistPlatform = table.Column<int>(nullable: true),
                    Budget = table.Column<int>(nullable: false),
                    Ranks = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    UsedBudget = table.Column<int>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    BannerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Content_Banner_BannerID",
                        column: x => x.BannerID,
                        principalTable: "Banner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Streamers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerID = table.Column<int>(nullable: false),
                    TwitchURL = table.Column<string>(nullable: true),
                    PurseID = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    AuthID = table.Column<int>(nullable: false),
                    ContentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streamers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Streamers_Content_ContentID",
                        column: x => x.ContentID,
                        principalTable: "Content",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banner_AdvertiserID",
                table: "Banner",
                column: "AdvertiserID");

            migrationBuilder.CreateIndex(
                name: "IX_Content_BannerID",
                table: "Content",
                column: "BannerID");

            migrationBuilder.CreateIndex(
                name: "IX_Streamers_ContentID",
                table: "Streamers",
                column: "ContentID");

            migrationBuilder.CreateIndex(
                name: "IX_Thematic_StreamID",
                table: "Thematic",
                column: "StreamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appeal");

            migrationBuilder.DropTable(
                name: "Auth");

            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "Purse");

            migrationBuilder.DropTable(
                name: "Streamers");

            migrationBuilder.DropTable(
                name: "Thematic");

            migrationBuilder.DropTable(
                name: "View");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "Stream");

            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.DropTable(
                name: "Advertiser");
        }
    }
}
