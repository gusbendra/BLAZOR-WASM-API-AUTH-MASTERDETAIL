using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorWaAuHosAgt.Server.Migrations
{
    public partial class Customer_AddKolomAlamatUtama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlamatUtama",
                table: "Customer",
                nullable: true);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlamatUtama",
                table: "Customer");

           
        }
    }
}
