using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorWaAuHosAgt.Server.Migrations
{
    public partial class addKeteranganCustalamat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nama",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kota",
                table: "Custalamat",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Jalan",
                table: "Custalamat",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "Custalamat",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "Custalamat");

            migrationBuilder.AlterColumn<string>(
                name: "Nama",
                table: "Customer",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kota",
                table: "Custalamat",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Jalan",
                table: "Custalamat",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
