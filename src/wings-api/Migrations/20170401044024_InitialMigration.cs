using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wings_api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    AgeInterestedMax = table.Column<int>(nullable: false),
                    AgeInterestedMin = table.Column<int>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    DOB = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    GenderInterested = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Onboarded = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    School = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserChatlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChatlogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserBacklogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserFriendID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    UserPotentialMatchID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBacklogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBacklogs_Users_UserFriendID",
                        column: x => x.UserFriendID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserBacklogs_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBacklogs_Users_UserPotentialMatchID",
                        column: x => x.UserPotentialMatchID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFriends",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserFriendID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFriends_Users_UserFriendID",
                        column: x => x.UserFriendID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFriends_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInterests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Interest = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInterests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInterests_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMatches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserFriendID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    UserMatchID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMatches_Users_UserFriendID",
                        column: x => x.UserFriendID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMatches_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMatches_Users_UserMatchID",
                        column: x => x.UserMatchID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPictures_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBacklogs_UserFriendID",
                table: "UserBacklogs",
                column: "UserFriendID");

            migrationBuilder.CreateIndex(
                name: "IX_UserBacklogs_UserID",
                table: "UserBacklogs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserBacklogs_UserPotentialMatchID",
                table: "UserBacklogs",
                column: "UserPotentialMatchID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFriends_UserFriendID",
                table: "UserFriends",
                column: "UserFriendID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFriends_UserID",
                table: "UserFriends",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterests_UserID",
                table: "UserInterests",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMatches_UserFriendID",
                table: "UserMatches",
                column: "UserFriendID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMatches_UserID",
                table: "UserMatches",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMatches_UserMatchID",
                table: "UserMatches",
                column: "UserMatchID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_UserID",
                table: "UserPictures",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBacklogs");

            migrationBuilder.DropTable(
                name: "UserChatlogs");

            migrationBuilder.DropTable(
                name: "UserFriends");

            migrationBuilder.DropTable(
                name: "UserInterests");

            migrationBuilder.DropTable(
                name: "UserMatches");

            migrationBuilder.DropTable(
                name: "UserPictures");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
