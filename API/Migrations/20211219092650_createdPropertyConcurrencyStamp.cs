using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnlinePWA.API.Migrations
{
    public partial class createdPropertyConcurrencyStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("65f518c4-94c6-48bf-a9d9-122b957ca69a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("878e3ad6-b021-46d9-984d-04df8585db47"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b91d56bb-5dcb-4a8e-9dbd-f53c2a4a4a04"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ff63a07c-c2c6-4348-af65-d450771927b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d762c53-3a31-4a9f-9a67-93e549ed3b3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6879c496-5769-442b-b844-166fb2e75b03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2ae5c95-9550-416e-a6cc-c02c395a67cd"));

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Subdivisions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "PriceType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Mesages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ItmeQualityes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ItemUnitMeasuraments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ItemUnitClassifiers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ItemTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ItemSeries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ItemCharacteristics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Currencyes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ClientContracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ClientContactInformationTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ClientContackInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "CashDesks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "BankAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AdditionalInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "ExchangeId", "Name", "NormalizedName", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("042428a2-a0b1-43b5-9023-4166634f8f2d"), "1e5468f9-53c0-4757-9963-f6513104619a", "Public users of application", null, "Public", "PUBLIC", null },
                    { new Guid("62e9bac9-8bdc-40c6-9642-b7b83717d391"), "17f487f1-1704-4c5b-8910-3414e56dd807", "Managers of application", null, "Managers", "MANAGERS", null },
                    { new Guid("92e9de7b-0da5-4f42-95f4-65ad7ff687f4"), "4e061f3d-5d62-4273-b9aa-dd2e002737d5", "Administrators of application", null, "Administrators", "ADMINISTRATORS", null },
                    { new Guid("cd401d73-4493-4c61-a89d-0b2aebe9cf4e"), "d44833e9-fbda-4575-b502-dc6b1283bbb2", "Clients of application", null, "Clients", "CLIENTS", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Timestamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("19f78532-1784-400c-89b3-1e411cf6b9fd"), 0, "19.12.2021 11:26:49", "Client@ShopOnlinePWA.API.com", true, null, "Client@ShopOnlinePWA.API.com", null, false, null, null, "CLIENT@SHOPONLINEPWA.API.COM", "CLIENT@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEG7XrYXzetwWsHY2FstHEGOj0hsSeXLfxM/JpauPJoPcBLMyimYHcgp1MltnLd66zA==", null, true, "19.12.2021 11:26:49", null, false, "Client@ShopOnlinePWA.API.com" },
                    { new Guid("c138fa92-cb8e-4e7a-ab1b-a60e1ada24e9"), 0, "19.12.2021 11:26:49", "Admitistrator@ShopOnlinePWA.API.com", true, null, "Admitistrator@ShopOnlinePWA.API.com", null, false, null, null, "ADMITISTRATOR@SHOPONLINEPWA.API.COM", "ADMITISTRATOR@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEDAY1ZGljGS/psuDlXHoyfg6nDFVljGD83Uqz4qPr/pXdh6Zo4Ctu+8eUvWDdZ5Elg==", null, true, "19.12.2021 11:26:49", null, false, "Admitistrator@ShopOnlinePWA.API.com" },
                    { new Guid("dc5ed28e-07ea-4637-be3d-37e74b1e4f82"), 0, "19.12.2021 11:26:49", "Manager@ShopOnlinePWA.API.com", true, null, "Manager@ShopOnlinePWA.API.com", null, false, null, null, "MANAGER@SHOPONLINEPWA.API.COM", "MANAGER@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEGZC9wpIqoq/iIOPtg9GsC02ZImLf1m0RdG+8zQXZ5aIB7BV0Q/6ch6pHNU9AG1uJA==", null, true, "19.12.2021 11:26:49", null, false, "Manager@ShopOnlinePWA.API.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("042428a2-a0b1-43b5-9023-4166634f8f2d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62e9bac9-8bdc-40c6-9642-b7b83717d391"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92e9de7b-0da5-4f42-95f4-65ad7ff687f4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cd401d73-4493-4c61-a89d-0b2aebe9cf4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19f78532-1784-400c-89b3-1e411cf6b9fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c138fa92-cb8e-4e7a-ab1b-a60e1ada24e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc5ed28e-07ea-4637-be3d-37e74b1e4f82"));

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Subdivisions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PriceType");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Mesages");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ItmeQualityes");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ItemUnitMeasuraments");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ItemUnitClassifiers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ItemTypes");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ItemSeries");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ItemCharacteristics");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Currencyes");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ClientContracts");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ClientContactInformationTypes");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ClientContackInformations");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "CashDesks");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AdditionalInformations");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "ExchangeId", "Name", "NormalizedName", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("65f518c4-94c6-48bf-a9d9-122b957ca69a"), "96a1a901-addc-451c-bbd5-0eae591fd208", "Clients of application", null, "Clients", "CLIENTS", null },
                    { new Guid("878e3ad6-b021-46d9-984d-04df8585db47"), "361447d7-66dc-4e84-8b10-1c57d9a18bea", "Managers of application", null, "Managers", "MANAGERS", null },
                    { new Guid("b91d56bb-5dcb-4a8e-9dbd-f53c2a4a4a04"), "d46b89ab-0f13-4844-aaed-a6473aa1daf3", "Administrators of application", null, "Administrators", "ADMINISTRATORS", null },
                    { new Guid("ff63a07c-c2c6-4348-af65-d450771927b6"), "8086a301-3986-43a3-b9b7-ed47922033de", "Public users of application", null, "Public", "PUBLIC", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Timestamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1d762c53-3a31-4a9f-9a67-93e549ed3b3e"), 0, "15.12.2021 11:49:08", "Admitistrator@ShopOnlinePWA.API.com", true, null, "Admitistrator@ShopOnlinePWA.API.com", null, false, null, null, "ADMITISTRATOR@SHOPONLINEPWA.API.COM", "ADMITISTRATOR@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEOWcx0jLtonfLrBad45fg/EGiERQBsRCIZ7pdacUsHh0HB9pTZMMF8ddzpMcsqoVrw==", null, true, "15.12.2021 11:49:08", null, false, "Admitistrator@ShopOnlinePWA.API.com" },
                    { new Guid("6879c496-5769-442b-b844-166fb2e75b03"), 0, "15.12.2021 11:49:08", "Manager@ShopOnlinePWA.API.com", true, null, "Manager@ShopOnlinePWA.API.com", null, false, null, null, "MANAGER@SHOPONLINEPWA.API.COM", "MANAGER@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEFM3fNnLfDTgOOTO1gfknnWfoFksTj1Nlyoq9Zxx++cBSu9J7xhfL9B25cUPwvJvlQ==", null, true, "15.12.2021 11:49:08", null, false, "Manager@ShopOnlinePWA.API.com" },
                    { new Guid("a2ae5c95-9550-416e-a6cc-c02c395a67cd"), 0, "15.12.2021 11:49:08", "Client@ShopOnlinePWA.API.com", true, null, "Client@ShopOnlinePWA.API.com", null, false, null, null, "CLIENT@SHOPONLINEPWA.API.COM", "CLIENT@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEBDowd7lFWoXzIUumMypVLSWTXb4XD1nwz7eU3+qHc4rsh3zBPVmP+7tKmGzI5O5hw==", null, true, "15.12.2021 11:49:08", null, false, "Client@ShopOnlinePWA.API.com" }
                });
        }
    }
}
