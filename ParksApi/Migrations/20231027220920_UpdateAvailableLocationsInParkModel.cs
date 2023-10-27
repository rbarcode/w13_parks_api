using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class UpdateAvailableLocationsInParkModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e81f6c-2576-41c1-ae67-8edadbf1ea4f", "AQAAAAEAACcQAAAAEFiGGmGq1feweu0CF9R71/E3DtSIoFBn8Kak7hyxjnLKiR7xoIaAq+DaqeaS6f7yDA==", "58eda642-a978-42f1-8926-e4f49d25b70e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b1ff46b-a531-4f1e-8c2c-c738f3d2823c", "AQAAAAEAACcQAAAAECzawBnaJR0wQFyXB1nZgmCtA7bd4zQe7n1MmIc1gISi9lFxNg/pWARov37nw5OBBg==", "b52cc749-df24-4cef-9e08-c1aeae1d9f5d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12cf36ab-a9d8-45ae-9f0c-cff8b74f82cf", "AQAAAAEAACcQAAAAEGPnv0zDw5XvDeagqgU6t0KYz93P9sT0+7UjAjayg6hXIaMDyVMEvd54xj/277UuEA==", "0dea3968-c829-439f-a818-4998ad0b5d60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d16319a2-3353-45ee-8821-91390ab3f664", "AQAAAAEAACcQAAAAEKpGvHz4pAcERalJzMoeEnp3xWQJy/XouN9rPuTcdGXj1Fm0YG/NQb7S+/czY1eozQ==", "2a4fe29e-ff6c-441a-9f5e-7655239418cd" });
        }
    }
}
