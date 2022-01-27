using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class UpdateProductSetNulableImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("40f1b166-ac22-4d1b-905d-e2d3c1911da7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4ac8cad2-ab38-42c7-96c9-3b325f0dfb3d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ae34ddb6-66ee-4909-bf66-e9a764c24ad0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f86502d6-679f-4bd1-acc3-ec2bcb935940"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d6e294f-a4df-4dda-a403-ef2f037a751f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba853b97-24ea-42e0-bf6f-6b5aba60f45b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcda7ac6-cf02-462d-a778-cfdbd3475161"));

            migrationBuilder.AlterColumn<string>(
                name: "MainImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "MainImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("40f1b166-ac22-4d1b-905d-e2d3c1911da7"), "38efe5a9-9f43-4f5a-be91-db647068be7d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managers of application", null, "Managers", "MANAGERS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ac8cad2-ab38-42c7-96c9-3b325f0dfb3d"), "1543ac48-a9ad-4a60-a643-d93c966deb48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clients of application", null, "Clients", "CLIENTS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae34ddb6-66ee-4909-bf66-e9a764c24ad0"), "81f70abf-7c96-4374-a594-fa60ffcc5654", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrators of application", null, "Administrators", "ADMINISTRATORS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f86502d6-679f-4bd1-acc3-ec2bcb935940"), "bc678355-c1a6-4eb1-8de5-f54b33b9a2de", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public users of application", null, "Public", "PUBLIC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0d6e294f-a4df-4dda-a403-ef2f037a751f"), 0, "27.01.2022 22:36:01", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com", true, null, "Admitistrator@Api.com", null, false, null, null, "ADMITISTRATOR@API.COM", "ADMITISTRATOR@API.COM", "AQAAAAEAACcQAAAAEN16AKhJDaYGoZJBfYTeDrGUVuNqMRP17T+4H7CFornWPhMdXzuo52IXUt9zN80JNw==", null, true, "27.01.2022 22:36:01", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com" },
                    { new Guid("ba853b97-24ea-42e0-bf6f-6b5aba60f45b"), 0, "27.01.2022 22:36:01", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com", true, null, "Client@Api.com", null, false, null, null, "CLIENT@API.COM", "CLIENT@API.COM", "AQAAAAEAACcQAAAAEGoHpdG6BcKdy0UJm6E76OyDfnRxOsiHi3OMae+Uqslrjo27FJSFiqZiETOxfP/MXQ==", null, true, "27.01.2022 22:36:01", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com" },
                    { new Guid("dcda7ac6-cf02-462d-a778-cfdbd3475161"), 0, "27.01.2022 22:36:01", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com", true, null, "Manager@Api.com", null, false, null, null, "MANAGER@API.COM", "MANAGER@API.COM", "AQAAAAEAACcQAAAAEB3wdUicK15THbgHTJlOsE2dy2hlN47BMFMZH1iLj23WH6oO5j0xI+sMDxfNVsA6LQ==", null, true, "27.01.2022 22:36:01", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com" }
                });
        }
    }
}
