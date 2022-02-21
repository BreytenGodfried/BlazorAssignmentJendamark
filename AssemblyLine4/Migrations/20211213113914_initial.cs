using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssemblyLine4.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DEVICE",
                columns: table => new
                {
                    DeviceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEVICE", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "OPERATION",
                columns: table => new
                {
                    OperationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderInWhichToPerform = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DeviceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPERATION", x => x.OperationID);
                    table.ForeignKey(
                        name: "FK_OPERATION_DEVICE_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "DEVICE",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OPERATION_DeviceID",
                table: "OPERATION",
                column: "DeviceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OPERATION");

            migrationBuilder.DropTable(
                name: "DEVICE");
        }
    }
}
