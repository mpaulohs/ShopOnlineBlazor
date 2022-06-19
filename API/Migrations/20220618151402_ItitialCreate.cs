using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class ItitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashDesks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashDesks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientContactInformationTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContactInformationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencyes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencyes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItmeQualityes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItmeQualityes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnitClassifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnitClassifiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnitMeasuraments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnitMeasuraments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subdivisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdivisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Article = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductCharacteristicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductQualityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductSerieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductUnitMeasurementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ItmeQualityes_ProductQualityId",
                        column: x => x.ProductQualityId,
                        principalTable: "ItmeQualityes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductCharacteristics_ProductCharacteristicId",
                        column: x => x.ProductCharacteristicId,
                        principalTable: "ProductCharacteristics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductSeries_ProductSerieId",
                        column: x => x.ProductSerieId,
                        principalTable: "ProductSeries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductUnitMeasuraments_ProductUnitMeasurementId",
                        column: x => x.ProductUnitMeasurementId,
                        principalTable: "ProductUnitMeasuraments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientContackInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientContactInformationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContackInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientContackInformations_ClientContactInformationTypes_ClientContactInformationTypeId",
                        column: x => x.ClientContactInformationTypeId,
                        principalTable: "ClientContactInformationTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientContackInformations_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientContracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientContracts_Currencyes_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencyes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientContracts_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReciverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReciverAddres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReciverPhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DocumentStatus = table.Column<int>(type: "int", nullable: false),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExchangeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentCurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentCurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultiplicityMutalSettlements = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocumentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResponsibleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SubdivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_ClientContracts_ClientContractId",
                        column: x => x.ClientContractId,
                        principalTable: "ClientContracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Currencyes_DocumentCurrencyId",
                        column: x => x.DocumentCurrencyId,
                        principalTable: "Currencyes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Subdivisions_SubdivisionId",
                        column: x => x.SubdivisionId,
                        principalTable: "Subdivisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Users_ReciverId",
                        column: x => x.ReciverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Users_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExchangeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExchangeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentCurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentCurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultiplicityMutalSettlements = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocumentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResponsibleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SubdivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_ClientContracts_ClientContractId",
                        column: x => x.ClientContractId,
                        principalTable: "ClientContracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Currencyes_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencyes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Currencyes_DocumentCurrencyId",
                        column: x => x.DocumentCurrencyId,
                        principalTable: "Currencyes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_PriceType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Subdivisions_SubdivisionId",
                        column: x => x.SubdivisionId,
                        principalTable: "Subdivisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Users_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01bf7b02-3e87-44d0-ab84-63e2ccf9d067"), "Article_88", "Cometn_88", "c227a958-5db1-4a0a-94d5-6b63c6caefc1", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4048), "Description_88", null, "FullName_88", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_88", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("02651eed-5e9b-48ba-adcb-f5d9f63fdb23"), "Article_74", "Cometn_74", "8ef7d418-5ab8-4f44-9538-43c7fc331610", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3350), "Description_74", null, "FullName_74", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_74", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05a1b6a8-3e64-4ba7-947f-f995b5d160c0"), "Article_18", "Cometn_18", "140acb5f-8344-431f-83c2-5a042c8f8cad", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(94), "Description_18", null, "FullName_18", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_18", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0610e09f-5aa7-4e32-a563-02d607c620c3"), "Article_45", "Cometn_45", "8aa86dc9-cb4e-468a-a030-68e4538b1f4d", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1791), "Description_45", null, "FullName_45", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_45", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("094f6c76-f17a-4069-8d0e-3f4ca25c303e"), "Article_22", "Cometn_22", "594c2f07-696f-4d32-a74c-7d43d1801ee8", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(278), "Description_22", null, "FullName_22", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_22", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0feb43cf-11de-414a-ae8b-cd0f8bd4fc74"), "Article_37", "Cometn_37", "5a7f69e5-7d40-4b74-baf5-e6a8b69e4654", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1355), "Description_37", null, "FullName_37", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_37", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("106bb1b1-30ee-4921-88d9-fb5183c8bd25"), "Article_78", "Cometn_78", "27495e2d-0d84-4d35-a7cd-f8c67b49d488", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3523), "Description_78", null, "FullName_78", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_78", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ad96c91-4d70-4470-86e4-4a3973a74675"), "Article_56", "Cometn_56", "cbb1a5ef-2c96-46e5-b5dc-01d844dc047b", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2369), "Description_56", null, "FullName_56", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_56", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1cc8df28-af3d-4bfb-9269-84f3f4a31eaa"), "Article_27", "Cometn_27", "080b5cd2-62e1-47b6-a9bf-b4350e83b970", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(616), "Description_27", null, "FullName_27", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_27", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("201a2d36-1379-462e-ac2b-517fa83d2d2f"), "Article_76", "Cometn_76", "89ca8a32-41d1-4a91-a498-50737355f9b7", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3434), "Description_76", null, "FullName_76", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_76", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("203f5123-91aa-4b56-90bd-573f82a3eb2e"), "Article_65", "Cometn_65", "c177f79e-0d17-41fd-b20b-8b1245d779c0", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2852), "Description_65", null, "FullName_65", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_65", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21d90b60-0710-4a27-8f6d-d51a0449cabe"), "Article_72", "Cometn_72", "40ceba34-fcfe-467f-bb92-99f0b6ba56c7", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3173), "Description_72", null, "FullName_72", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_72", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("257efd71-0a4f-40bf-b278-2d98fda9d6e3"), "Article_67", "Cometn_67", "3f3bea1e-4be2-4765-914b-9c6c5bbf81e4", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2954), "Description_67", null, "FullName_67", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_67", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("273fc647-960d-4bcd-8160-a76bc9ab190f"), "Article_10", "Cometn_10", "9131d0af-f04d-4ccc-a5e1-cab13b6b1eee", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8697), "Description_10", null, "FullName_10", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_10", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a5927bd-ee1b-46a3-8971-f499462cb6ba"), "Article_66", "Cometn_66", "ca7851b8-fdfd-4c51-a71f-4a23cc71d2fd", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2911), "Description_66", null, "FullName_66", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_66", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e89caa6-af63-4a37-a4fd-d5b079e84be7"), "Article_1", "Cometn_1", "232c04f9-455f-4e82-8668-2aba7083b8b5", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(7865), "Description_1", null, "FullName_1", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_1", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33491488-0f3a-47b9-ad6d-b42468959845"), "Article_86", "Cometn_86", "bbf98276-5688-44de-a6ef-c7aaa9a62ec9", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3964), "Description_86", null, "FullName_86", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_86", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34fefb1b-ea34-44fc-94a0-ec3eced537d5"), "Article_12", "Cometn_12", "398c8c63-3f2d-4816-9451-cb49123107ba", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8804), "Description_12", null, "FullName_12", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_12", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("368efbf0-0331-47be-bd3c-eff84844e703"), "Article_79", "Cometn_79", "102d7df1-d0f1-4ba5-a208-cdb2cd2d886a", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3566), "Description_79", null, "FullName_79", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_79", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("369ff007-f02c-48cc-9e6a-5910c650a7bf"), "Article_64", "Cometn_64", "af5e4604-0800-402c-8e82-329ff821b6af", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2720), "Description_64", null, "FullName_64", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_64", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3789127a-eae0-4932-af25-f0bdaf672746"), "Article_97", "Cometn_97", "67422108-c81e-4d99-87db-6187c6ddb605", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4572), "Description_97", null, "FullName_97", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_97", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3af4e7a8-29b3-4cee-8dc6-c5ef0ef66d7a"), "Article_21", "Cometn_21", "43098b93-3383-4260-807f-f1ee12bfe36b", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(229), "Description_21", null, "FullName_21", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_21", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f43cc8e-e9bf-402a-9f13-863eef5334dc"), "Article_7", "Cometn_7", "8d2ebbcf-e7e0-4cfd-9a09-c8f8d0cbe896", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8526), "Description_7", null, "FullName_7", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_7", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f76610f-b16f-4a18-b617-f3b7aaaef5a9"), "Article_47", "Cometn_47", "866fd236-3f42-4c5a-86b8-e96ff99a4d11", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1891), "Description_47", null, "FullName_47", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_47", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40f9811f-6b1d-4726-a49b-2ec9880daf91"), "Article_34", "Cometn_34", "37b40e8d-dc5c-4f16-8b11-e698282e27fa", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1133), "Description_34", null, "FullName_34", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_34", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42d1ea87-01d5-48a6-bb69-24420ab4b54a"), "Article_32", "Cometn_32", "918cc70e-89d3-45b4-8e1c-e935c8c743ed", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1031), "Description_32", null, "FullName_32", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_32", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("489481fe-34c5-49e7-88aa-d19e797ada45"), "Article_77", "Cometn_77", "3e220fe7-f96d-4633-80d8-408403e90bcf", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3476), "Description_77", null, "FullName_77", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_77", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4be1bcc9-5d52-4872-afe8-e40e5d11c1ba"), "Article_17", "Cometn_17", "98ee7a9a-f01c-4823-9eba-6f6e09ad87e8", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(9996), "Description_17", null, "FullName_17", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_17", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4da87b90-625f-421e-b4e8-78f18e36e724"), "Article_59", "Cometn_59", "686f0f49-d616-4749-9b33-0f2571e09d64", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2503), "Description_59", null, "FullName_59", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_59", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("510b5640-d05e-4833-887e-6c564a784bb9"), "Article_75", "Cometn_75", "fecc8819-7ad8-47dc-8982-3b9ecbfe9ab1", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3393), "Description_75", null, "FullName_75", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_75", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53103a5a-d461-4cb6-9071-d11943a9b337"), "Article_15", "Cometn_15", "3887268f-8f49-4e35-92e8-87968260d12e", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(9604), "Description_15", null, "FullName_15", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_15", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59e6c700-f233-48d6-ad3c-752b0456cfae"), "Article_57", "Cometn_57", "eb9e387f-2e6f-48a0-8ab3-d1cbd45ca6a4", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2413), "Description_57", null, "FullName_57", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_57", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a269849-4e9f-438c-bea4-39b2fe7d952b"), "Article_62", "Cometn_62", "5138c810-4832-4111-94b9-87ddf680119e", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2634), "Description_62", null, "FullName_62", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_62", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a9df591-7cea-4102-9b6c-9b5f4a23a90b"), "Article_53", "Cometn_53", "fb9af0c1-2c64-4184-baa3-62ffbb011aee", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2147), "Description_53", null, "FullName_53", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_53", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bc4b4c6-6c45-4dfa-b231-b058ed52d25c"), "Article_55", "Cometn_55", "d1dfc156-db41-4ae1-8f5d-14623b682a84", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2317), "Description_55", null, "FullName_55", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_55", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bce7b81-3b70-4412-88b6-ab30d3529659"), "Article_9", "Cometn_9", "40c9e629-c432-428e-80a0-29ee5cc9c845", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8643), "Description_9", null, "FullName_9", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_9", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ce5ca68-2524-4744-80a0-a1251031308d"), "Article_81", "Cometn_81", "9d91e66f-f4d4-457e-8c0d-6e6596114d3b", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3650), "Description_81", null, "FullName_81", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_81", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d884d05-a43a-4013-ab5a-9d9dab081e5e"), "Article_91", "Cometn_91", "dfd88272-872c-44b6-890b-4c89debabeb7", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4178), "Description_91", null, "FullName_91", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_91", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("623ece3e-d5c5-4d25-b442-a6e197ecc3a8"), "Article_38", "Cometn_38", "fa2bf20e-1004-4fc7-826f-cea49f57fc72", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1404), "Description_38", null, "FullName_38", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_38", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62e2a5d8-864e-42e8-b811-3fe1f23f77ee"), "Article_36", "Cometn_36", "c202bc23-39d6-466f-b333-c42adc9bfa0f", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1311), "Description_36", null, "FullName_36", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_36", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("632bf7b1-9605-424b-ad5e-7916b30abd94"), "Article_33", "Cometn_33", "72cfa05e-84f1-443d-8990-e5588a2041ce", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1074), "Description_33", null, "FullName_33", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_33", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63597fb2-0efa-42df-955f-90c351dd3292"), "Article_96", "Cometn_96", "5e6fcf48-ee95-4459-9965-ee5d6022d6ab", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4531), "Description_96", null, "FullName_96", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_96", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("65d4697b-153e-48db-9d58-fd57b2c273c0"), "Article_58", "Cometn_58", "3138b9d9-43e6-42fb-9f3a-18699d784ff8", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2461), "Description_58", null, "FullName_58", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_58", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6748db0f-8dd4-423e-8201-c4838c22fa7d"), "Article_93", "Cometn_93", "17bb2a81-5fb4-44a1-9db0-9d9c898eeed9", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4398), "Description_93", null, "FullName_93", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_93", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c38d7b0-4d80-4d84-bef1-be55752cb6ed"), "Article_61", "Cometn_61", "36c735ab-378f-4a4c-a696-b011b1af6daf", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2586), "Description_61", null, "FullName_61", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_61", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("727464bf-a5b3-425b-a379-bb059acbaf3a"), "Article_20", "Cometn_20", "f52395a6-caf4-4eeb-a7ea-1f8faf99f003", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(186), "Description_20", null, "FullName_20", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_20", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73ec75c5-8a00-49cb-93e3-122d2c54da25"), "Article_51", "Cometn_51", "4edde160-9db2-4318-8d3e-35257378cc0d", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2063), "Description_51", null, "FullName_51", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_51", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("750dadfc-cf3c-43b6-a093-018134ea5cee"), "Article_5", "Cometn_5", "7deb017a-fdd1-49da-b985-8c4c944d894a", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8280), "Description_5", null, "FullName_5", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_5", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("751a2e78-abd1-47b5-bac6-4485c2e736c4"), "Article_23", "Cometn_23", "c3ee5447-c57d-4355-be12-24489f40abd0", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(337), "Description_23", null, "FullName_23", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_23", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("775a55e5-b5be-417e-88b5-42cfa928237c"), "Article_85", "Cometn_85", "7c7f2b63-dd46-4ad4-b604-80a5e0667b75", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3916), "Description_85", null, "FullName_85", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_85", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("793bc1e7-3f11-4d1e-b007-a29ab0f5c27b"), "Article_82", "Cometn_82", "04d6ff71-5082-4e80-9286-e0188748bf02", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3697), "Description_82", null, "FullName_82", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_82", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e96df6c-479d-40a0-ab34-4169c7eec1ef"), "Article_98", "Cometn_98", "f85fde64-199d-41b1-bf7d-5e8c9f65b3ab", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4620), "Description_98", null, "FullName_98", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_98", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81e71a55-cabd-45ec-bad9-0be4793688c2"), "Article_99", "Cometn_99", "01c6233c-aede-4a3e-a109-f9ab8726c56b", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4662), "Description_99", null, "FullName_99", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_99", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85787e41-5561-415b-ae85-e5a705bab8ed"), "Article_63", "Cometn_63", "5f38795e-a47c-4831-b570-28ee011285f1", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2678), "Description_63", null, "FullName_63", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_63", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8764df0b-b134-4a95-bcb8-4d71172dd73e"), "Article_41", "Cometn_41", "21967dd6-2b27-406b-9512-cced94027981", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1529), "Description_41", null, "FullName_41", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_41", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dd34606-f5b3-448d-83fc-e425f474ea68"), "Article_30", "Cometn_30", "59a7979e-557d-44ea-8427-52efbf877ed7", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(847), "Description_30", null, "FullName_30", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_30", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fdc67ed-c29f-4a76-8cde-4697d32fade2"), "Article_87", "Cometn_87", "89cc5757-46bd-4a1c-b5f7-9c968e4e7e49", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4006), "Description_87", null, "FullName_87", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_87", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95017a72-0966-4cc5-9fe5-30e2173e39cd"), "Article_3", "Cometn_3", "28c7b102-61ac-4cd1-9520-6ba6be3c900c", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8165), "Description_3", null, "FullName_3", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_3", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95045e78-132a-420e-a223-f17137fa2d0b"), "Article_80", "Cometn_80", "30630b01-8aeb-425a-8cb5-dd65f988bcf6", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3608), "Description_80", null, "FullName_80", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_80", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("991f6dc7-e67f-4db1-9c7b-bd338998bef4"), "Article_43", "Cometn_43", "82a8fca1-718c-47f2-8cb7-f0e805eaa915", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1621), "Description_43", null, "FullName_43", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_43", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99c1d7a0-0446-44f2-933c-291a9ad88f13"), "Article_49", "Cometn_49", "2661d356-cb02-46b3-9220-d8797a68de06", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1975), "Description_49", null, "FullName_49", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_49", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b060d8f-3cd4-4a1f-8418-a0bc090ebc74"), "Article_52", "Cometn_52", "8ea95540-6cbe-4c49-935b-53c029d49bcd", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2105), "Description_52", null, "FullName_52", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_52", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c301705-a9e4-434c-a173-0efaef511601"), "Article_71", "Cometn_71", "f95005c5-4cfb-4c7a-a3b5-fd58476b3d35", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3130), "Description_71", null, "FullName_71", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_71", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4de43c1-bfa4-474f-b921-7364da21de71"), "Article_8", "Cometn_8", "8b034d40-5c5e-467e-8bba-bb47c79bf58c", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8593), "Description_8", null, "FullName_8", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_8", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4f35d9c-f794-40a8-95a1-1b4d5b404913"), "Article_4", "Cometn_4", "9e5d017a-398b-4b9c-9c85-72e0230c9f71", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8227), "Description_4", null, "FullName_4", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_4", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6580181-5e56-474b-a7fd-7a3e4192736e"), "Article_11", "Cometn_11", "66eb7f77-538c-4802-830a-6904a8fff326", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8748), "Description_11", null, "FullName_11", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_11", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6d5ef40-7b74-4f57-93e0-f52b07d1befa"), "Article_39", "Cometn_39", "b5029711-eebe-4d54-b144-0e69b98a1412", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1446), "Description_39", null, "FullName_39", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_39", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa5f28cc-9ef8-4efe-89b5-2277aabe5e50"), "Article_89", "Cometn_89", "f45ff874-6577-4911-965a-25b82388d587", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4088), "Description_89", null, "FullName_89", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_89", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa8be826-7a2e-4c09-beeb-765587aae7d8"), "Article_60", "Cometn_60", "279e82dd-d225-42b6-898f-6109ded9453f", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2544), "Description_60", null, "FullName_60", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_60", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac464542-03bb-477e-97bb-fc6e5773ccca"), "Article_68", "Cometn_68", "790c12ce-8c71-4976-b832-c2c93717e9f7", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2996), "Description_68", null, "FullName_68", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_68", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aeafed9a-7e83-44c9-935d-a9a111fb271a"), "Article_28", "Cometn_28", "6c59f561-6e3c-4efb-ac2a-d042cd2b5cf2", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(678), "Description_28", null, "FullName_28", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_28", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4593d87-d325-4a05-90ab-55365d4cb865"), "Article_90", "Cometn_90", "c32cf86a-bb67-4b40-8b0a-77d736d28476", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4136), "Description_90", null, "FullName_90", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_90", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b56e83d0-df90-4395-abbe-102b569988ff"), "Article_69", "Cometn_69", "0a89febc-6408-49fb-811d-e834ae72a734", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3039), "Description_69", null, "FullName_69", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_69", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6f97f6b-e78b-4f29-96dd-e724097e1995"), "Article_26", "Cometn_26", "2654eba5-e22a-475d-b57a-9d5014e9e0b5", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(480), "Description_26", null, "FullName_26", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_26", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8caa59e-8273-478c-8b0a-3476c1e619a7"), "Article_31", "Cometn_31", "8e101c7e-ce94-4c4b-adc7-f03053cb079c", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(987), "Description_31", null, "FullName_31", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_31", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b97c2ebf-a927-41d6-ae58-fb56f35589bc"), "Article_44", "Cometn_44", "3198cf4e-1fce-4dae-bbf9-f63ea593cc16", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1664), "Description_44", null, "FullName_44", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_44", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9a81244-7510-4365-8d3d-a15169ba21bd"), "Article_29", "Cometn_29", "8ec107c4-b616-4921-ab16-cb5824f6509d", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(770), "Description_29", null, "FullName_29", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_29", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bfdcdb69-325a-4973-9611-06855b80222d"), "Article_46", "Cometn_46", "ad39a0ff-ce0b-473a-b5ad-886ba8216796", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1849), "Description_46", null, "FullName_46", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_46", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c79ce69b-92d6-47a0-b4d3-7b1b7607f6f3"), "Article_83", "Cometn_83", "38e19e68-4f45-4ddf-a6e6-707e19e2537b", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3830), "Description_83", null, "FullName_83", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_83", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8c51081-6d88-4249-9c59-21725788490c"), "Article_84", "Cometn_84", "3394be06-0f49-4ac1-816f-30a6aee0043f", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3874), "Description_84", null, "FullName_84", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_84", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb420b17-d96b-4e72-b827-c969cb99a36a"), "Article_94", "Cometn_94", "acc4b32f-9e3d-4916-9f3e-305b54ac590a", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4447), "Description_94", null, "FullName_94", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_94", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cca006a3-28f9-4f91-8a50-323d42767811"), "Article_14", "Cometn_14", "2fe679f8-a5e9-475e-85ac-ae841fdc9402", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(9525), "Description_14", null, "FullName_14", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_14", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce909ca5-07fe-47ee-88a5-b44cf64efdc9"), "Article_35", "Cometn_35", "5f337a9b-befc-45ac-ad6a-909d7329cdf0", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1177), "Description_35", null, "FullName_35", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_35", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d08d46f9-54ea-47ea-bca6-1fbd66a694cf"), "Article_48", "Cometn_48", "8182a622-febb-4909-9d6f-65cadd75d03f", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1934), "Description_48", null, "FullName_48", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_48", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d624f4c3-32b4-4c63-9f67-2cadb7c27e6b"), "Article_73", "Cometn_73", "6b08f9d5-53c8-46c9-b676-8bf878127bbd", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3295), "Description_73", null, "FullName_73", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_73", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d97a668d-5be2-45bc-986b-c3822f2000b9"), "Article_92", "Cometn_92", "89adc8c5-2ab1-4597-8492-392ba85b0991", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4342), "Description_92", null, "FullName_92", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_92", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db8a28ad-6f9a-48f7-8107-06d78ece5980"), "Article_19", "Cometn_19", "5894d16f-5f1b-4743-a581-abb1aa08e30c", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(141), "Description_19", null, "FullName_19", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_19", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcba20af-2af3-473a-9850-444debc68edb"), "Article_16", "Cometn_16", "9826970d-88b3-44f9-ac67-88483f70baf9", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(9717), "Description_16", null, "FullName_16", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_16", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e00dea13-520f-411d-85c5-ebf27ec9e234"), "Article_50", "Cometn_50", "8d110248-c893-437d-89fe-d5e29ad3c08c", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2021), "Description_50", null, "FullName_50", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_50", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e21dc251-0089-4576-9bcd-5130becdfbf8"), "Article_42", "Cometn_42", "888a57c6-3fe5-46ae-b52d-90a7e9a7f3bf", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1577), "Description_42", null, "FullName_42", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_42", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e231bf1b-5fb4-46be-bc31-c427225d57ee"), "Article_13", "Cometn_13", "620b83d0-8a9c-4bf3-8253-4a1e9720c1a2", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(9225), "Description_13", null, "FullName_13", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_13", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3a0cd8a-a760-4231-8348-b63d5d740537"), "Article_25", "Cometn_25", "74371459-b0d2-4e41-a2a8-d5a76315f599", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(431), "Description_25", null, "FullName_25", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_25", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e881222c-3109-4b53-8e7a-b67539f65807"), "Article_54", "Cometn_54", "19ee0fe0-1cfa-416e-a1f5-1ba2d1d84ef6", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(2194), "Description_54", null, "FullName_54", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_54", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9753339-3e4b-4d76-8836-ee12db22a1e6"), "Article_24", "Cometn_24", "800c046f-4be5-4317-b293-0ef2eb434bc5", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(380), "Description_24", null, "FullName_24", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_24", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f106c329-4b00-44c2-9256-01b0dcd102f5"), "Article_40", "Cometn_40", "0a6fa74a-6c3a-42c7-9d05-3569182482ac", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(1487), "Description_40", null, "FullName_40", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_40", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2b880f8-b746-49e4-9cfa-21a1188f2168"), "Article_6", "Cometn_6", "7ef63cdf-9d04-4253-b903-1217808ecfe9", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8351), "Description_6", null, "FullName_6", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_6", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f71d6710-5798-4d18-83f1-325647631d98"), "Article_2", "Cometn_2", "418182d0-26e9-44f3-94a0-a19fa018c13b", new DateTime(2022, 6, 18, 18, 14, 1, 887, DateTimeKind.Local).AddTicks(8111), "Description_2", null, "FullName_2", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_2", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f94db05c-3889-4fdf-aa40-bd63904077b6"), "Article_95", "Cometn_95", "20b815e0-47e6-47bd-940a-2aaf2362ab6a", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(4489), "Description_95", null, "FullName_95", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_95", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f986932e-b3d6-421a-b42d-750a0605da55"), "Article_70", "Cometn_70", "1ba1af51-718f-4d80-85fc-03488dc82551", new DateTime(2022, 6, 18, 18, 14, 1, 888, DateTimeKind.Local).AddTicks(3087), "Description_70", null, "FullName_70", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_70", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContackInformations_ClientContactInformationTypeId",
                table: "ClientContackInformations",
                column: "ClientContactInformationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContackInformations_ClientId",
                table: "ClientContackInformations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContracts_ClientId",
                table: "ClientContracts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContracts_CurrencyId",
                table: "ClientContracts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ClientContractId",
                table: "Documents",
                column: "ClientContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ClientId",
                table: "Documents",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentCurrencyId",
                table: "Documents",
                column: "DocumentCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_OrganizationId",
                table: "Documents",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PriceTypeId",
                table: "Documents",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ReciverId",
                table: "Documents",
                column: "ReciverId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ResponsibleId",
                table: "Documents",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_StorageId",
                table: "Documents",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SubdivisionId",
                table: "Documents",
                column: "SubdivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientContractId",
                table: "Payments",
                column: "ClientContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientId",
                table: "Payments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CurrencyId",
                table: "Payments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_DocumentCurrencyId",
                table: "Payments",
                column: "DocumentCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrganizationId",
                table: "Payments",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PriceTypeId",
                table: "Payments",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ResponsibleId",
                table: "Payments",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubdivisionId",
                table: "Payments",
                column: "SubdivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCharacteristicId",
                table: "Products",
                column: "ProductCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductQualityId",
                table: "Products",
                column: "ProductQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSerieId",
                table: "Products",
                column: "ProductSerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductUnitMeasurementId",
                table: "Products",
                column: "ProductUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInformations");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "CashDesks");

            migrationBuilder.DropTable(
                name: "ClientContackInformations");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Mesages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductUnitClassifiers");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "ClientContactInformationTypes");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "ClientContracts");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "PriceType");

            migrationBuilder.DropTable(
                name: "Subdivisions");

            migrationBuilder.DropTable(
                name: "ItmeQualityes");

            migrationBuilder.DropTable(
                name: "ProductCharacteristics");

            migrationBuilder.DropTable(
                name: "ProductSeries");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "ProductUnitMeasuraments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Currencyes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
