using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Huerto___ENTPROG___OTIS1.DataModel.Migrations
{
    public partial class CreatedSupplierTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuppliersINV",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Representative = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersINV", x => x.SupplierID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuppliersINV");
        }
    }
}
