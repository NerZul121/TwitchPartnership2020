using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitchPartnership2020.Migrations
{
    public partial class NewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banner_Advertiser_AdvertiserID",
                table: "Banner");

            migrationBuilder.DropForeignKey(
                name: "FK_Content_Banner_BannerID",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_Streamers_Content_ContentID",
                table: "Streamers");

            migrationBuilder.DropForeignKey(
                name: "FK_Thematic_Stream_StreamID",
                table: "Thematic");

            migrationBuilder.DropIndex(
                name: "IX_Thematic_StreamID",
                table: "Thematic");

            migrationBuilder.DropIndex(
                name: "IX_Streamers_ContentID",
                table: "Streamers");

            migrationBuilder.DropIndex(
                name: "IX_Content_BannerID",
                table: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Banner_AdvertiserID",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "StreamID",
                table: "Thematic");

            migrationBuilder.DropColumn(
                name: "ContentID",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Stream");

            migrationBuilder.DropColumn(
                name: "BannerID",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "CostPerTrueView",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "Platforms",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "Ranks",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "Whitelist",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "WhitelistPlatform",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "AdvertiserID",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "Whitelist",
                table: "Banner");

            migrationBuilder.AddColumn<string>(
                name: "ChannelsURL",
                table: "Stream",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Stream",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Duration",
                table: "Stream",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnconfirmedBalance",
                table: "Purse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "State",
                table: "Operation",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Content",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CostPerView",
                table: "Content",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "CostPerClick",
                table: "Content",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "CostPerAuthView",
                table: "Content",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MediaContent",
                table: "Content",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RedirectURL",
                table: "Content",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Delay",
                table: "Banner",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsContentsBlocked",
                table: "Banner",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Auth",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModeratorID",
                table: "Appeal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Moderator",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Info = table.Column<string>(nullable: true),
                    AuthID = table.Column<int>(nullable: false),
                    PurseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderator", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Moderator_Auth_AuthID",
                        column: x => x.AuthID,
                        principalTable: "Auth",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moderator_Purse_PurseID",
                        column: x => x.PurseID,
                        principalTable: "Purse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Redirect",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RedirectTime = table.Column<DateTime>(nullable: false),
                    Fingerprint = table.Column<int>(nullable: false),
                    ContentID = table.Column<int>(nullable: false),
                    StreamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redirect", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Redirect_Content_ContentID",
                        column: x => x.ContentID,
                        principalTable: "Content",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Redirect_Stream_StreamID",
                        column: x => x.StreamID,
                        principalTable: "Stream",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Streamers_AuthID",
                table: "Streamers",
                column: "AuthID");

            migrationBuilder.CreateIndex(
                name: "IX_Streamers_BannerID",
                table: "Streamers",
                column: "BannerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Streamers_PurseID",
                table: "Streamers",
                column: "PurseID");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_PurseID",
                table: "Operation",
                column: "PurseID");

            migrationBuilder.CreateIndex(
                name: "IX_Content_AdvertiserID",
                table: "Content",
                column: "AdvertiserID");

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_ModeratorID",
                table: "Appeal",
                column: "ModeratorID");

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_StreamID",
                table: "Appeal",
                column: "StreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_ViewID",
                table: "Appeal",
                column: "ViewID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertiser_AuthID",
                table: "Advertiser",
                column: "AuthID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertiser_PurseID",
                table: "Advertiser",
                column: "PurseID");

            migrationBuilder.CreateIndex(
                name: "IX_Moderator_AuthID",
                table: "Moderator",
                column: "AuthID");

            migrationBuilder.CreateIndex(
                name: "IX_Moderator_PurseID",
                table: "Moderator",
                column: "PurseID");

            migrationBuilder.CreateIndex(
                name: "IX_Redirect_ContentID",
                table: "Redirect",
                column: "ContentID");

            migrationBuilder.CreateIndex(
                name: "IX_Redirect_StreamID",
                table: "Redirect",
                column: "StreamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertiser_Auth_AuthID",
                table: "Advertiser",
                column: "AuthID",
                principalTable: "Auth",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertiser_Purse_PurseID",
                table: "Advertiser",
                column: "PurseID",
                principalTable: "Purse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_Moderator_ModeratorID",
                table: "Appeal",
                column: "ModeratorID",
                principalTable: "Moderator",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_Stream_StreamID",
                table: "Appeal",
                column: "StreamID",
                principalTable: "Stream",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_View_ViewID",
                table: "Appeal",
                column: "ViewID",
                principalTable: "View",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Content_Advertiser_AdvertiserID",
                table: "Content",
                column: "AdvertiserID",
                principalTable: "Advertiser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operation_Purse_PurseID",
                table: "Operation",
                column: "PurseID",
                principalTable: "Purse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Streamers_Auth_AuthID",
                table: "Streamers",
                column: "AuthID",
                principalTable: "Auth",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Streamers_Banner_BannerID",
                table: "Streamers",
                column: "BannerID",
                principalTable: "Banner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Streamers_Purse_PurseID",
                table: "Streamers",
                column: "PurseID",
                principalTable: "Purse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertiser_Auth_AuthID",
                table: "Advertiser");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertiser_Purse_PurseID",
                table: "Advertiser");

            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_Moderator_ModeratorID",
                table: "Appeal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_Stream_StreamID",
                table: "Appeal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_View_ViewID",
                table: "Appeal");

            migrationBuilder.DropForeignKey(
                name: "FK_Content_Advertiser_AdvertiserID",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_Operation_Purse_PurseID",
                table: "Operation");

            migrationBuilder.DropForeignKey(
                name: "FK_Streamers_Auth_AuthID",
                table: "Streamers");

            migrationBuilder.DropForeignKey(
                name: "FK_Streamers_Banner_BannerID",
                table: "Streamers");

            migrationBuilder.DropForeignKey(
                name: "FK_Streamers_Purse_PurseID",
                table: "Streamers");

            migrationBuilder.DropTable(
                name: "Moderator");

            migrationBuilder.DropTable(
                name: "Redirect");

            migrationBuilder.DropIndex(
                name: "IX_Streamers_AuthID",
                table: "Streamers");

            migrationBuilder.DropIndex(
                name: "IX_Streamers_BannerID",
                table: "Streamers");

            migrationBuilder.DropIndex(
                name: "IX_Streamers_PurseID",
                table: "Streamers");

            migrationBuilder.DropIndex(
                name: "IX_Operation_PurseID",
                table: "Operation");

            migrationBuilder.DropIndex(
                name: "IX_Content_AdvertiserID",
                table: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_ModeratorID",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_StreamID",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_ViewID",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Advertiser_AuthID",
                table: "Advertiser");

            migrationBuilder.DropIndex(
                name: "IX_Advertiser_PurseID",
                table: "Advertiser");

            migrationBuilder.DropColumn(
                name: "ChannelsURL",
                table: "Stream");

            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Stream");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Stream");

            migrationBuilder.DropColumn(
                name: "UnconfirmedBalance",
                table: "Purse");

            migrationBuilder.DropColumn(
                name: "CostPerAuthView",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "MediaContent",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "RedirectURL",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "IsContentsBlocked",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Auth");

            migrationBuilder.DropColumn(
                name: "ModeratorID",
                table: "Appeal");

            migrationBuilder.AddColumn<int>(
                name: "StreamID",
                table: "Thematic",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContentID",
                table: "Streamers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Stream",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Operation",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Content",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "CostPerView",
                table: "Content",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "CostPerClick",
                table: "Content",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BannerID",
                table: "Content",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "CostPerTrueView",
                table: "Content",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Content",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platforms",
                table: "Content",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ranks",
                table: "Content",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Content",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Whitelist",
                table: "Content",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WhitelistPlatform",
                table: "Content",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Delay",
                table: "Banner",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AdvertiserID",
                table: "Banner",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Whitelist",
                table: "Banner",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Thematic_StreamID",
                table: "Thematic",
                column: "StreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Streamers_ContentID",
                table: "Streamers",
                column: "ContentID");

            migrationBuilder.CreateIndex(
                name: "IX_Content_BannerID",
                table: "Content",
                column: "BannerID");

            migrationBuilder.CreateIndex(
                name: "IX_Banner_AdvertiserID",
                table: "Banner",
                column: "AdvertiserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Banner_Advertiser_AdvertiserID",
                table: "Banner",
                column: "AdvertiserID",
                principalTable: "Advertiser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Content_Banner_BannerID",
                table: "Content",
                column: "BannerID",
                principalTable: "Banner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Streamers_Content_ContentID",
                table: "Streamers",
                column: "ContentID",
                principalTable: "Content",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thematic_Stream_StreamID",
                table: "Thematic",
                column: "StreamID",
                principalTable: "Stream",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
