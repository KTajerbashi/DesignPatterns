using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesses.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LOG");

            migrationBuilder.CreateTable(
                name: "Logger",
                schema: "LOG",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MethodControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MethodControllerParameters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MethodServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logger", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logger",
                schema: "LOG");
        }
    }
}
