using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initialpush : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UseCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseCaseIdentifier = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableId = table.Column<int>(type: "int", nullable: false),
                    WeiterId = table.Column<int>(type: "int", nullable: false),
                    BillOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillClosed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Employees_WeiterId",
                        column: x => x.WeiterId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTypes_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_UseCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UseCaseId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_UseCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_UseCases_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_UseCases_UseCases_UseCaseId",
                        column: x => x.UseCaseId,
                        principalTable: "UseCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTypeId = table.Column<int>(type: "int", nullable: false),
                    PictureSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_SubTypes_SubTypeId",
                        column: x => x.SubTypeId,
                        principalTable: "SubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetailss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetailss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetailss_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetailss_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetailss_BillId",
                table: "BillDetailss",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetailss_MenuId",
                table: "BillDetailss",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_TableId",
                table: "Bills",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_WeiterId",
                table: "Bills",
                column: "WeiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UseCases_UseCaseId",
                table: "Employee_UseCases",
                column: "UseCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UseCases_UserId",
                table: "Employee_UseCases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SubTypeId",
                table: "Menus",
                column: "SubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTypes_TypeId",
                table: "SubTypes",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetailss");

            migrationBuilder.DropTable(
                name: "Employee_UseCases");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "UseCases");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "SubTypes");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
