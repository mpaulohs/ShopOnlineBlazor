using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class UpdateDecumetnSaleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Storages_StorageId",
                table: "Documents");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b9fa6ab-fe77-4d95-8726-948de53000cc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62c51371-e728-4f01-a40c-e975a7d9beaf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6db903cf-b97b-4a32-a2d2-b6fe7cad2af5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ef94cdbd-9dad-4569-a9c2-c68e98100ffd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22c8f150-a2f4-413e-9c3a-3ab4c7eb923d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60304778-cc55-420e-bcb9-277ff5d9de51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cd768c9-941c-4fc1-ac92-460d0ebd8195"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "StorageId",
                table: "Documents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("129b7c39-4ac3-4b60-8229-dd2a74629ff3"), "f21df14d-a3b8-4e01-8be8-dc251fa3a211", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrators of application", null, "Administrators", "ADMINISTRATORS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e67cc16-c0ab-4e04-8578-a5c76330b48b"), "c524a428-81e2-4d07-a8fe-2a3dd26b117d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clients of application", null, "Clients", "CLIENTS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d52420d1-9a42-4c09-b8de-249ef951a544"), "331baeeb-4280-4516-b5a4-4667270abc1e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managers of application", null, "Managers", "MANAGERS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec3f8651-a337-4ce6-928f-e8a343434287"), "3c77da1f-1a54-47cb-8bcb-63b7c600e8d9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public users of application", null, "Public", "PUBLIC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("a0db5377-47be-4a09-b131-6ae4516c050e"), 0, "02.02.2022 17:35:42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com", true, null, "Admitistrator@Api.com", null, false, null, null, "ADMITISTRATOR@API.COM", "ADMITISTRATOR@API.COM", "AQAAAAEAACcQAAAAEGjasPozLTJvAywjBwv+xvdrYQw4naeJZCBOPZJ3KC2Gh1JxUqkXCWwx1bDmKqGSqA==", null, true, "02.02.2022 17:35:42", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com" },
                    { new Guid("d3e73f81-a7fa-4357-bb75-6ef1f3749747"), 0, "02.02.2022 17:35:42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com", true, null, "Manager@Api.com", null, false, null, null, "MANAGER@API.COM", "MANAGER@API.COM", "AQAAAAEAACcQAAAAEFDgrnAIDpm1b9MW36ro1/uGOnXZARzJ4qOO6E0RLh4q/T31SbNL3hl9GRo/MBMzrQ==", null, true, "02.02.2022 17:35:42", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com" },
                    { new Guid("de2f5926-a2bb-4dfb-af76-8aa247634585"), 0, "02.02.2022 17:35:42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com", true, null, "Client@Api.com", null, false, null, null, "CLIENT@API.COM", "CLIENT@API.COM", "AQAAAAEAACcQAAAAEJjhAvT2/WoL81y8laK8vFdf9KGqeZgS69JNnrzfkOQmxzLjYxnmGRvbxHy6yvduyg==", null, true, "02.02.2022 17:35:42", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Storages_StorageId",
                table: "Documents",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Storages_StorageId",
                table: "Documents");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("129b7c39-4ac3-4b60-8229-dd2a74629ff3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e67cc16-c0ab-4e04-8578-a5c76330b48b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d52420d1-9a42-4c09-b8de-249ef951a544"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ec3f8651-a337-4ce6-928f-e8a343434287"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0db5377-47be-4a09-b131-6ae4516c050e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3e73f81-a7fa-4357-bb75-6ef1f3749747"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de2f5926-a2bb-4dfb-af76-8aa247634585"));

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "StorageId",
                table: "Documents",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b9fa6ab-fe77-4d95-8726-948de53000cc"), "e66e255c-1b75-408c-93b8-0df0ed2d13be", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public users of application", null, "Public", "PUBLIC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62c51371-e728-4f01-a40c-e975a7d9beaf"), "7f0fc941-6858-4dc5-b526-54e7b16484b3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrators of application", null, "Administrators", "ADMINISTRATORS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6db903cf-b97b-4a32-a2d2-b6fe7cad2af5"), "255f559b-3ba6-46c5-8833-436d99911ccb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clients of application", null, "Clients", "CLIENTS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef94cdbd-9dad-4569-a9c2-c68e98100ffd"), "6c0acc84-23fb-4fe5-a7c3-267b9b305237", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managers of application", null, "Managers", "MANAGERS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("22c8f150-a2f4-413e-9c3a-3ab4c7eb923d"), 0, "27.01.2022 22:50:06", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com", true, null, "Client@Api.com", null, false, null, null, "CLIENT@API.COM", "CLIENT@API.COM", "AQAAAAEAACcQAAAAEPir/eAIHl8AaNwlIqZj7jly3aMME2k9NA2kj0PzFNn/BR3zelrPuK8h8/cn2rkMHQ==", null, true, "27.01.2022 22:50:06", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com" },
                    { new Guid("60304778-cc55-420e-bcb9-277ff5d9de51"), 0, "27.01.2022 22:50:06", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com", true, null, "Manager@Api.com", null, false, null, null, "MANAGER@API.COM", "MANAGER@API.COM", "AQAAAAEAACcQAAAAEEuU+HoCRBlJLfe+oG7OUpb1YvvRQ44E9JN4SNTcN1vv+n92U26js92siSNvHPgtdA==", null, true, "27.01.2022 22:50:06", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com" },
                    { new Guid("8cd768c9-941c-4fc1-ac92-460d0ebd8195"), 0, "27.01.2022 22:50:06", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com", true, null, "Admitistrator@Api.com", null, false, null, null, "ADMITISTRATOR@API.COM", "ADMITISTRATOR@API.COM", "AQAAAAEAACcQAAAAEKOmMxtiYcITrtUG3gqOjRuuWLHFuzsV8SWu0LBJi1f6ligwDDCfkklJClQtXRmQyg==", null, true, "27.01.2022 22:50:06", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Storages_StorageId",
                table: "Documents",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id");
        }
    }
}
