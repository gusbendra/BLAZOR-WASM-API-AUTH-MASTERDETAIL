using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorWaAuHosAgt.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a1da165-399e-49f2-9c3c-dea1ef408f5c", "c2547e5a-8817-46b9-9ed8-4b9869f1eb97", "User", "USER" },
                    { "67fb3ddd-cca6-4f16-bb4e-dbadbfc173dc", "8ef6b977-239b-474c-8e7a-74edcfbbe1ed", "Admin", "ADMIN" },
                    { "b48b6052-d3b8-4881-b310-9f05bc8972d4", "d827433b-b0d2-4d56-b446-b2177943d451", "Supervisor", "SUPERVISOR" },
                    { "2572a95c-36ec-40d2-9682-7117abe06812", "4f1c457a-6dea-4efa-9213-40bc82794518", "Manager", "MANAGER" },
                    { "b7567f89-e752-4e84-840b-55003c668e4b", "273061ff-3d14-4ced-99e4-45c8cd550101", "Depthead", "DEPTHEAD" },
                    { "a06d14d1-3a10-4aec-acc4-3de98799836b", "c3529d97-6740-4767-a953-50afd6841371", "Divhead", "DIVHEAD" },
                    { "3e586009-6ebf-4303-8da1-ab6897c0db4e", "34dc8b97-8929-410f-952f-11e6a42f01ed", "Clevel", "CLEVEL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2572a95c-36ec-40d2-9682-7117abe06812");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e586009-6ebf-4303-8da1-ab6897c0db4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67fb3ddd-cca6-4f16-bb4e-dbadbfc173dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a1da165-399e-49f2-9c3c-dea1ef408f5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06d14d1-3a10-4aec-acc4-3de98799836b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b48b6052-d3b8-4881-b310-9f05bc8972d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7567f89-e752-4e84-840b-55003c668e4b");
        }
    }
}
