using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnlinePWA.API.Migrations
{
    public partial class UpdatedEntitieFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Timestamp",
                table: "Mesages");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Subdivisions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Storages",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Roles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "PriceType",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Payments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Organizations",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ItmeQualityes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ItemUnitMeasuraments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ItemUnitClassifiers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ItemTypes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ItemSeries",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Items",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ItemCharacteristics",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Documents",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Currencyes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ClientContracts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ClientContactInformationTypes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ClientContackInformations",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "CashDesks",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Banks",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "BankAccounts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "AdditionalInformations",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Subdivisions",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Storages",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Roles",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "PriceType",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Payments",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Organizations",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Mesages",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "UpdatedAt",
                table: "Mesages",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ItmeQualityes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ItemUnitMeasuraments",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ItemUnitClassifiers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ItemTypes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ItemSeries",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Items",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ItemCharacteristics",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Documents",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Currencyes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ClientContracts",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ClientContactInformationTypes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "ClientContackInformations",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "CashDesks",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "Banks",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "BankAccounts",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedAt",
                table: "AdditionalInformations",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ea376af-7178-408a-8ece-dc774fe13d1a"), "70a33595-ad73-4fcc-acfe-1b0d9045875e", null, "Managers of application", null, "Managers", "MANAGERS", null },
                    { new Guid("bf225e87-abc8-45d5-b92a-7d321bff6ce4"), "270c2da2-3e63-43ff-b307-5b27db286a31", null, "Public users of application", null, "Public", "PUBLIC", null },
                    { new Guid("cfa640ca-69c7-401a-a4a6-b62e0fe5c8c6"), "1f6d63a6-6754-4eef-a058-acdb586b0ead", null, "Administrators of application", null, "Administrators", "ADMINISTRATORS", null },
                    { new Guid("e32a70c9-2b48-40ec-99e1-52b654acead5"), "5aababf8-a652-4fdc-b931-66700ce80397", null, "Clients of application", null, "Clients", "CLIENTS", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ExchangeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("4ebb3866-b572-4287-a605-ec7cc0cf02a0"), 0, "22.12.2021 23:29:21", null, "Admitistrator@ShopOnlinePWA.API.com", true, null, "Admitistrator@ShopOnlinePWA.API.com", null, false, null, null, "ADMITISTRATOR@SHOPONLINEPWA.API.COM", "ADMITISTRATOR@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEPa7vJ/gc0JD5kETwRN6u+A+I4MBPXXpR61dde7tkNyy8rwWAgPSq9oUzvHNH6etww==", null, true, "22.12.2021 23:29:21", false, null, "Admitistrator@ShopOnlinePWA.API.com" },
                    { new Guid("7a45a122-876d-4680-9947-338b29228fc1"), 0, "22.12.2021 23:29:21", null, "Client@ShopOnlinePWA.API.com", true, null, "Client@ShopOnlinePWA.API.com", null, false, null, null, "CLIENT@SHOPONLINEPWA.API.COM", "CLIENT@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEIOVMXC6bQ5dK7MqaIiQcPrT/1dsJBneOJgXtcEzEmgifm+X5XewzE9aKD2t5tQvjw==", null, true, "22.12.2021 23:29:21", false, null, "Client@ShopOnlinePWA.API.com" },
                    { new Guid("c6519e52-6dbf-4b98-8fd1-27df1aefdb70"), 0, "22.12.2021 23:29:21", null, "Manager@ShopOnlinePWA.API.com", true, null, "Manager@ShopOnlinePWA.API.com", null, false, null, null, "MANAGER@SHOPONLINEPWA.API.COM", "MANAGER@SHOPONLINEPWA.API.COM", "AQAAAAEAACcQAAAAEDOd9/OOx8+jrfxwudFDYSBlA2JK43xDlE1uzSX2RdkaAQdOr4JXuG1u0YnzPu4+yQ==", null, true, "22.12.2021 23:29:21", false, null, "Manager@ShopOnlinePWA.API.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2ea376af-7178-408a-8ece-dc774fe13d1a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf225e87-abc8-45d5-b92a-7d321bff6ce4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cfa640ca-69c7-401a-a4a6-b62e0fe5c8c6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e32a70c9-2b48-40ec-99e1-52b654acead5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ebb3866-b572-4287-a605-ec7cc0cf02a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a45a122-876d-4680-9947-338b29228fc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6519e52-6dbf-4b98-8fd1-27df1aefdb70"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Subdivisions");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PriceType");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Mesages");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Mesages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ItmeQualityes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ItemUnitMeasuraments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ItemUnitClassifiers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ItemTypes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ItemSeries");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ItemCharacteristics");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Currencyes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ClientContracts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ClientContactInformationTypes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ClientContackInformations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CashDesks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AdditionalInformations");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Users",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Subdivisions",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Storages",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Roles",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "PriceType",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Payments",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Organizations",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItmeQualityes",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemUnitMeasuraments",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemUnitClassifiers",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemTypes",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemSeries",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Items",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemCharacteristics",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Documents",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Currencyes",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ClientContracts",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ClientContactInformationTypes",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ClientContackInformations",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CashDesks",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Banks",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "BankAccounts",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "AdditionalInformations",
                newName: "Timestamp");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Mesages",
                type: "rowversion",
                rowVersion: true,
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
    }
}
