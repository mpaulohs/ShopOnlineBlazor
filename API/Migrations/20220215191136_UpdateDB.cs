using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5bf4727e-f5cc-4fb6-9738-b87559685060"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5e424447-6035-49ef-a240-ed6ff68e2fe2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9c757c51-1fd9-4046-b4f0-4d4542d36b50"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eed62f2c-e15b-4dd0-95b8-e9c207671dec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("119ca64f-cf52-4255-98e0-9fc55b08df87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44257cef-23ad-46db-8953-d0b3c91356ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d17228b0-92c5-4629-88b3-6efff80d9508"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a4b5633-5df6-4335-8744-3c98b10e3cf9"), "2be878f1-9a97-4388-be9e-6987192d84a0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clients of application", null, "Clients", "CLIENTS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a51e957-fee8-49b3-8bc3-7e5842b87d3b"), "542e1d30-51bc-4281-90d0-60d2017cc4bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public users of application", null, "Public", "PUBLIC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47960184-91d1-4071-a462-8c56f78363fd"), "9b3bcfa1-9531-483d-b033-bdfa0e7989ac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrators of application", null, "Administrators", "ADMINISTRATORS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bace559f-d1df-4969-88ed-126655ce70b2"), "f645a209-0b11-4a6e-8c25-dcebfc3afcae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managers of application", null, "Managers", "MANAGERS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("303a01f3-d64d-4391-8b3a-4b44d488c5f9"), 0, "15.02.2022 21:11:35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com", true, null, "Manager@Api.com", null, false, null, null, "MANAGER@API.COM", "MANAGER@API.COM", "AQAAAAEAACcQAAAAEA9gyJ+vRmkiSd9N7kRo8V2FPQI7FzhK5kyrcae45lp/hVMMi+kAR1VTjs5aXjPIkg==", null, true, "15.02.2022 21:11:35", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com" },
                    { new Guid("361cf1f5-035e-4fd0-b3e1-86c6f3acb490"), 0, "15.02.2022 21:11:35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com", true, null, "Client@Api.com", null, false, null, null, "CLIENT@API.COM", "CLIENT@API.COM", "AQAAAAEAACcQAAAAEDFZ/qaVrUevrif+iTKxDg9f6G2AXiLdL5RPuFfKtMAL9rpy8o/b2fKZXDW/5MnNuA==", null, true, "15.02.2022 21:11:35", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com" },
                    { new Guid("c0e24ea1-1a33-4ff3-9c2a-141f34377699"), 0, "15.02.2022 21:11:35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com", true, null, "Admitistrator@Api.com", null, false, null, null, "ADMITISTRATOR@API.COM", "ADMITISTRATOR@API.COM", "AQAAAAEAACcQAAAAEGyaddcnBmdxIOJdfZIwI/VBRZGSY7TggDZGaZXSFYNsoLCj5ZGSzb11hFm1v6OKLA==", null, true, "15.02.2022 21:11:35", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0a4b5633-5df6-4335-8744-3c98b10e3cf9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0a51e957-fee8-49b3-8bc3-7e5842b87d3b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("47960184-91d1-4071-a462-8c56f78363fd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bace559f-d1df-4969-88ed-126655ce70b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("303a01f3-d64d-4391-8b3a-4b44d488c5f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("361cf1f5-035e-4fd0-b3e1-86c6f3acb490"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0e24ea1-1a33-4ff3-9c2a-141f34377699"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5bf4727e-f5cc-4fb6-9738-b87559685060"), "1384032d-81c1-4284-9c91-67d7d6ad7595", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clients of application", null, "Clients", "CLIENTS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e424447-6035-49ef-a240-ed6ff68e2fe2"), "16c85f60-760b-4738-ad67-ae842ca7130e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managers of application", null, "Managers", "MANAGERS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c757c51-1fd9-4046-b4f0-4d4542d36b50"), "471add4d-e9b9-43f3-955e-6bbe4c3dd96d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrators of application", null, "Administrators", "ADMINISTRATORS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eed62f2c-e15b-4dd0-95b8-e9c207671dec"), "5c47a9a9-cf88-4434-8dce-e519c1d69f09", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public users of application", null, "Public", "PUBLIC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("119ca64f-cf52-4255-98e0-9fc55b08df87"), 0, "06.02.2022 22:41:44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com", true, null, "Client@Api.com", null, false, null, null, "CLIENT@API.COM", "CLIENT@API.COM", "AQAAAAEAACcQAAAAEBz0nlvBqv+xiSlPrbhbsOjLd8ZWDwYDyh+XX7sE+bdCftWPDkLLVc9guEfyhTeFiA==", null, true, "06.02.2022 22:41:44", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client@Api.com" },
                    { new Guid("44257cef-23ad-46db-8953-d0b3c91356ff"), 0, "06.02.2022 22:41:44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com", true, null, "Admitistrator@Api.com", null, false, null, null, "ADMITISTRATOR@API.COM", "ADMITISTRATOR@API.COM", "AQAAAAEAACcQAAAAEFbEVxoePn4l9Z99U4IThr+RwLYplQNrLWobhrM/pw2oCYiPgbnQMTSReGp5yW6/vg==", null, true, "06.02.2022 22:41:44", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admitistrator@Api.com" },
                    { new Guid("d17228b0-92c5-4629-88b3-6efff80d9508"), 0, "06.02.2022 22:41:44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com", true, null, "Manager@Api.com", null, false, null, null, "MANAGER@API.COM", "MANAGER@API.COM", "AQAAAAEAACcQAAAAEBJfkQg2Jii/ede2BJrlkabbRmzfLnBihV0DsYS8vZdT2vf3KjRBjk9Ln1KBBdLZag==", null, true, "06.02.2022 22:41:44", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager@Api.com" }
                });
        }
    }
}
