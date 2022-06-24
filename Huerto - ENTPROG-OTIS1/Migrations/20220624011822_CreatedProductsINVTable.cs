using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Huerto___ENTPROG___OTIS1.DataModel.Migrations
{
    public partial class CreatedProductsINVTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsINV",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Unit = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsINV", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsINV");
        }
    }
}
