using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigAccessment1_HotelsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Information_Id = table.Column<int>(type: "int", nullable: false, defaultValue: 2000),
                    Owner_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total_Room = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Information_Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Location_Id = table.Column<int>(type: "int", nullable: false, defaultValue: 10000),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Location_Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceRanges",
                columns: table => new
                {
                    PriceRangeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRanges", x => x.PriceRangeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Hotel_Id = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Hotel_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Id = table.Column<int>(type: "int", nullable: false),
                    PriceRange_Id = table.Column<int>(type: "int", nullable: false),
                    Amenities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Information_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Hotel_Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Informations_Information_Id",
                        column: x => x.Information_Id,
                        principalTable: "Informations",
                        principalColumn: "Information_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotels_Locations_Location_Id",
                        column: x => x.Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Location_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotels_PriceRanges_PriceRange_Id",
                        column: x => x.PriceRange_Id,
                        principalTable: "PriceRanges",
                        principalColumn: "PriceRangeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Room_Id = table.Column<int>(type: "int", nullable: false, defaultValue: 1000),
                    Hotel_Id = table.Column<int>(type: "int", nullable: false),
                    Room_no = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Room_Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Hotel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reversations",
                columns: table => new
                {
                    Reservation_Id = table.Column<int>(type: "int", nullable: false, defaultValue: 3000),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reversations", x => x.Reservation_Id);
                    table.ForeignKey(
                        name: "FK_Reversations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Room_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reversations_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reversations_Users_User_Id1",
                        column: x => x.User_Id1,
                        principalTable: "Users",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Information_Id",
                table: "Hotels",
                column: "Information_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Location_Id",
                table: "Hotels",
                column: "Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_PriceRange_Id",
                table: "Hotels",
                column: "PriceRange_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reversations_RoomId",
                table: "Reversations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reversations_User_Id",
                table: "Reversations",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reversations_User_Id1",
                table: "Reversations",
                column: "User_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Hotel_Id",
                table: "Rooms",
                column: "Hotel_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reversations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "PriceRanges");
        }
    }
}
