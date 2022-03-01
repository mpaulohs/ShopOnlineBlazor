using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class initiall : Migration
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
                    { new Guid("0180a664-40d1-4b3c-9e9f-9304970a5bdc"), "Article_59", "Cometn_59", "1b60264c-c17e-4e47-a7e7-ade606ebd260", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8715), "Description_59", null, "FullName_59", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_59", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0448b1da-88fe-4b08-837d-cb890f52dda0"), "Article_57", "Cometn_57", "bba7ed3e-03e6-44c8-92b5-cd35023999d2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8631), "Description_57", null, "FullName_57", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_57", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04befc75-9090-4dd0-ae2b-e5819316a3f8"), "Article_3", "Cometn_3", "78c912da-e6cb-49af-b177-4218095ca390", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7036), "Description_3", null, "FullName_3", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_3", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("055bc410-fc77-4104-a506-76e186e71884"), "Article_77", "Cometn_77", "bdde9c22-c229-446c-bb38-2ce76c2edd39", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9293), "Description_77", null, "FullName_77", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_77", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08deb869-9ed8-4c83-928a-d7492a33471c"), "Article_17", "Cometn_17", "d8f9d536-87ac-45a6-9e0c-2e9bf34556af", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7443), "Description_17", null, "FullName_17", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_17", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c843d82-3d7c-4cc0-aa1c-43510920ea87"), "Article_98", "Cometn_98", "df28abe7-57df-4dac-9218-32074fa32ad4", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9938), "Description_98", null, "FullName_98", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_98", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d70f5df-32d3-4846-ae8c-1780126f6545"), "Article_19", "Cometn_19", "955d1a9d-8057-46c2-b3bf-b74c920d74f2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7490), "Description_19", null, "FullName_19", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_19", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0df52022-aef0-45eb-af9e-bc111ffe3e41"), "Article_2", "Cometn_2", "059c9372-2c56-447d-907f-8ce58d501dff", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7000), "Description_2", null, "FullName_2", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_2", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e0ad7e8-ddd9-4846-9a4c-a1ae13931d29"), "Article_69", "Cometn_69", "b5fc5d84-6017-445c-8e47-f9fba139666d", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9013), "Description_69", null, "FullName_69", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_69", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("132f3223-1ad7-4ace-9d6e-53e14ab39dce"), "Article_80", "Cometn_80", "128524fd-eb81-494a-888d-7f9dfa654ac3", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9381), "Description_80", null, "FullName_80", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_80", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14627cdf-b2b4-4d8a-86ea-5cdb6483ff3b"), "Article_28", "Cometn_28", "66f6c2e2-f92a-4ec5-9312-d06bc2839847", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7733), "Description_28", null, "FullName_28", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_28", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15fb18b1-e728-489f-88fe-3e0f05ed9713"), "Article_83", "Cometn_83", "2b301967-59be-4099-ba15-ed341cb08f45", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9461), "Description_83", null, "FullName_83", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_83", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18ce4388-ba96-43d0-9cdb-74cab5e9910a"), "Article_12", "Cometn_12", "4dbf05cb-ea02-45ec-9e00-bd5e1a2b6736", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7321), "Description_12", null, "FullName_12", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_12", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ae8fbb0-103c-4ab5-9959-5209885d7e2a"), "Article_44", "Cometn_44", "6a68da07-2519-44be-b457-4923c33de89b", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8247), "Description_44", null, "FullName_44", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_44", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b36f107-e210-4ab2-8c2d-8628009f385c"), "Article_41", "Cometn_41", "244f6739-b037-48f2-9133-1dd3aabff13e", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8174), "Description_41", null, "FullName_41", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_41", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f528097-41b9-4621-ab9f-5067226df2df"), "Article_11", "Cometn_11", "d4fe2b96-a5da-4e09-9591-3848fc49a8e9", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7253), "Description_11", null, "FullName_11", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_11", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("215a2e4b-1df1-4c56-b584-e36d6cecd5ca"), "Article_96", "Cometn_96", "3606f5c7-ccc0-4014-8771-bd7798acaa88", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9856), "Description_96", null, "FullName_96", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_96", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("232f9522-4447-4a0f-a39a-e6e2c22a01c8"), "Article_46", "Cometn_46", "32398a55-a1db-470f-9988-4e91aeb1f5b7", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8299), "Description_46", null, "FullName_46", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_46", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24b8d88c-5303-4392-8e46-9c5ed5b3a34c"), "Article_26", "Cometn_26", "e14916af-ca9f-45fc-b748-6c06595773e8", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7692), "Description_26", null, "FullName_26", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_26", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("257ca279-9ec4-4ec2-aa10-a7d1ffb6cdf7"), "Article_29", "Cometn_29", "0ed3eb6c-559c-4023-aeed-3c5a263076e2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7757), "Description_29", null, "FullName_29", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_29", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2dbd29b6-e22f-478f-963c-035437cb9bcf"), "Article_42", "Cometn_42", "5041bc1b-772c-42ac-9763-5b3223ba2c51", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8199), "Description_42", null, "FullName_42", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_42", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2eda3c5c-4bf6-4208-9a3d-3a307b0895b6"), "Article_72", "Cometn_72", "529a9a68-8815-4010-9416-732e81df3a73", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9086), "Description_72", null, "FullName_72", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_72", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31e8b972-48b8-4405-8da3-ecfab5de6789"), "Article_14", "Cometn_14", "d04e8736-992b-4e29-bfc0-5f8ad360731f", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7376), "Description_14", null, "FullName_14", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_14", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34c2a3c3-24aa-4e3b-86ef-220e46db69b4"), "Article_40", "Cometn_40", "ea30b0f3-a5f5-4bff-9b81-746c2cba8beb", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8139), "Description_40", null, "FullName_40", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_40", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("354ac473-f0c2-4696-a2a2-8dd89dc02e78"), "Article_68", "Cometn_68", "dfaa3e49-f585-4455-9aa6-adfce34daa91", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8983), "Description_68", null, "FullName_68", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_68", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("386d537b-00fa-4164-8883-d76f69cc7646"), "Article_31", "Cometn_31", "9775e07e-89c8-47e7-b3be-b22240730033", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7849), "Description_31", null, "FullName_31", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_31", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49df5d41-0f8e-4feb-8102-6f3c4c99b28c"), "Article_39", "Cometn_39", "49a91e10-abb6-4d46-8252-ecd76e9201cb", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8071), "Description_39", null, "FullName_39", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_39", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4aec9c71-8e22-4fe8-9375-b57ab6db33e1"), "Article_20", "Cometn_20", "d611cd2d-6ca1-4a33-9fb1-7e1277e32e8b", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7511), "Description_20", null, "FullName_20", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_20", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b07f39d-63a6-4651-8c63-808fc4c6332d"), "Article_89", "Cometn_89", "3d4a758e-ab87-40b7-98fd-bcc179df9564", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9670), "Description_89", null, "FullName_89", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_89", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c61675b-1d3a-4cff-86af-124dc5bb3665"), "Article_92", "Cometn_92", "26b137a9-bc0f-495f-ae66-1767c9db992e", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9800), "Description_92", null, "FullName_92", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_92", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ee574e9-5b75-48c9-817f-42be2ff7fe3e"), "Article_36", "Cometn_36", "bd666c1b-18ed-4549-a8bd-31fd1ce51594", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7988), "Description_36", null, "FullName_36", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_36", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("531c37a3-0ac9-4f9a-a210-a5628d7bd7e0"), "Article_78", "Cometn_78", "497947b1-25c9-4a37-9141-0cfd6b61b4f0", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9331), "Description_78", null, "FullName_78", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_78", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("533a0659-53df-436f-b840-525a74e5a630"), "Article_13", "Cometn_13", "5f40e3ec-6423-4cc2-81ee-f46fe73c5881", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7355), "Description_13", null, "FullName_13", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_13", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("548c5485-d35e-4ea3-8aa2-a3baf7a7f541"), "Article_73", "Cometn_73", "6152a557-fb34-4116-834e-1202aa498590", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9115), "Description_73", null, "FullName_73", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_73", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("551621b7-de9f-4acc-b715-cbb0e71bdc7c"), "Article_93", "Cometn_93", "10240c3c-86df-4e67-956b-d874861822c3", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9817), "Description_93", null, "FullName_93", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_93", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55ff85fb-f752-4806-8705-9da52af6003f"), "Article_76", "Cometn_76", "25701f15-2404-4ba1-9a44-a87d8377897b", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9189), "Description_76", null, "FullName_76", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_76", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("57731fe1-21f3-4c87-8e9f-95141acdd6d4"), "Article_67", "Cometn_67", "3122b972-9271-45df-82a9-55ef52edf564", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8916), "Description_67", null, "FullName_67", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_67", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58371f4d-c836-48f8-8e8a-8ab9df7564d9"), "Article_23", "Cometn_23", "a75a55de-08d9-45e7-a473-8c3286088252", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7625), "Description_23", null, "FullName_23", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_23", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58af85a8-2a3b-4ec8-a8cb-f204cb05341e"), "Article_33", "Cometn_33", "dc22cde6-b44e-4c3a-a7d3-39e108b23876", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7907), "Description_33", null, "FullName_33", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_33", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59749c73-dd0a-43e4-bd3f-816f918f89c3"), "Article_97", "Cometn_97", "8de1ecb1-918f-49ef-bde5-309ac31fdf99", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9922), "Description_97", null, "FullName_97", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_97", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c064e3a-40d8-4807-9e67-66d217456a75"), "Article_15", "Cometn_15", "5c105fce-3c08-40c3-b57f-5242a149aec7", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7397), "Description_15", null, "FullName_15", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_15", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5da43698-390d-4455-af24-e31b77b1323d"), "Article_56", "Cometn_56", "46ddfd15-0796-49ca-aac2-0ad465255954", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8605), "Description_56", null, "FullName_56", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_56", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("63585fc8-6604-4d36-8fc4-9b85c9202b52"), "Article_88", "Cometn_88", "4b2fbe32-0c89-47c4-9035-a414abfedcd4", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9641), "Description_88", null, "FullName_88", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_88", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6541ce5f-377b-48b9-a7b8-2977dd25c8a1"), "Article_85", "Cometn_85", "74359088-ba46-4cec-b41b-8a15e5339ca2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9515), "Description_85", null, "FullName_85", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_85", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("669fee88-8906-4bbf-a7c0-34542b9daed3"), "Article_54", "Cometn_54", "3f5b9aac-f95f-4311-88be-8586ceab10a2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8556), "Description_54", null, "FullName_54", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_54", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b462c3e-6507-477e-8fc1-7ebbb93550ba"), "Article_9", "Cometn_9", "c5c16396-16f1-4b81-bad2-199807a6d61d", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7203), "Description_9", null, "FullName_9", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_9", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d3bcd35-f44a-4330-81fc-1eea60c975d0"), "Article_62", "Cometn_62", "8ae92cfc-85cf-4cf9-8894-16281939a0e5", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8791), "Description_62", null, "FullName_62", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_62", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f9ddee3-ec80-41e0-b87e-7685addd42e1"), "Article_7", "Cometn_7", "08a6501b-88ce-45cd-8135-4faf7914feb5", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7156), "Description_7", null, "FullName_7", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_7", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74b8fb5a-44d8-49db-b986-6da899f60757"), "Article_90", "Cometn_90", "86c57b96-cae4-4d05-8a68-80af8f649d0f", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9695), "Description_90", null, "FullName_90", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_90", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75b05c55-a919-4382-857b-55c1c6d40c4f"), "Article_58", "Cometn_58", "edeb29ab-c3da-45c2-8910-79fcb23d1c28", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8652), "Description_58", null, "FullName_58", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_58", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75fc3548-b94b-401d-9011-c7284909ce78"), "Article_5", "Cometn_5", "30a1db6a-a6a4-451b-a901-48501c79c7c1", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7094), "Description_5", null, "FullName_5", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_5", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("761a0d85-61f1-4c31-96b7-521cc30facc8"), "Article_24", "Cometn_24", "6fcb80c2-41ca-4854-968c-40d20380d6b9", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7647), "Description_24", null, "FullName_24", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_24", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76ff4136-c09e-4364-a0d0-396b4113b1da"), "Article_84", "Cometn_84", "5eb416ba-76eb-4d15-8d1b-f3c4f649a809", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9488), "Description_84", null, "FullName_84", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_84", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7709299b-390b-4d4f-b61f-ac6e047e21e9"), "Article_99", "Cometn_99", "eafc113c-703d-45ea-a3f4-9b99b026a01c", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9951), "Description_99", null, "FullName_99", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_99", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ab3d8c2-04db-44f3-99e6-b74a3631c026"), "Article_64", "Cometn_64", "658c342f-182f-4128-87f7-4499aa3e96b3", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8837), "Description_64", null, "FullName_64", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_64", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83188590-9d60-43e1-9c93-6100a4a3cf1f"), "Article_74", "Cometn_74", "3479775d-26bf-4cd1-8abd-c01779dd234f", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9139), "Description_74", null, "FullName_74", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_74", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8741c096-e48c-4864-a31d-e4c01bbfd667"), "Article_63", "Cometn_63", "9f142425-bda1-4520-a50f-203c9c0d75d6", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8815), "Description_63", null, "FullName_63", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_63", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8908211a-410c-4c44-9942-161c4b1fd4e5"), "Article_87", "Cometn_87", "77effe7b-69b2-466f-bd7d-ef95d81def63", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9609), "Description_87", null, "FullName_87", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_87", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cdccb02-f7a0-4730-b7de-02813a32a49b"), "Article_66", "Cometn_66", "d58986e3-86da-4c48-90f4-3d723f5ef555", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8892), "Description_66", null, "FullName_66", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_66", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e06e237-a9d5-431f-9696-272d1a7027c2"), "Article_53", "Cometn_53", "535ebb7b-c8d8-4a63-994c-09a4ff43191c", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8531), "Description_53", null, "FullName_53", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_53", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("911bde71-525f-4929-b06f-8d71f8b6edae"), "Article_30", "Cometn_30", "60050232-fc3f-429d-9116-bc9622136573", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7781), "Description_30", null, "FullName_30", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_30", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9427e433-2619-4247-8869-6fa6bce7eec8"), "Article_27", "Cometn_27", "9775dfa0-c3e5-47db-a7a8-302a88aca64f", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7712), "Description_27", null, "FullName_27", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_27", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94d9b6e8-8aa7-413c-903d-b134616773be"), "Article_34", "Cometn_34", "ff649fc6-54ba-4951-800f-a9117bf85990", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7936), "Description_34", null, "FullName_34", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_34", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("954322a1-585a-445a-ac94-8d4dc89651cf"), "Article_55", "Cometn_55", "6065c554-3bb0-44fe-87c2-2d8c1efe1cd6", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8579), "Description_55", null, "FullName_55", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_55", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("956cf2f1-2671-4c27-b2a3-acae113964d9"), "Article_75", "Cometn_75", "6904cc72-e105-4aca-b985-9fd05868994e", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9163), "Description_75", null, "FullName_75", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_75", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9adbe7ba-e94e-45bd-a4f5-e2775f8b118a"), "Article_21", "Cometn_21", "679baf4c-4e7b-46c9-88c8-ca2100a23949", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7535), "Description_21", null, "FullName_21", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_21", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9bf7b338-c07f-402c-a0fc-f73b94bea0f0"), "Article_10", "Cometn_10", "bf553942-66a2-4cd3-88ee-0b5b8f56968b", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7230), "Description_10", null, "FullName_10", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_10", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a272addb-cde8-4cd3-9901-238c98dd7236"), "Article_38", "Cometn_38", "aa7b1d4b-dccd-4f1b-8f97-dfd90c95ad2d", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8046), "Description_38", null, "FullName_38", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_38", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa6fc36b-e99d-43af-9f4d-e2070e4092bc"), "Article_43", "Cometn_43", "535c59db-8230-4263-82d5-6441baef6146", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8223), "Description_43", null, "FullName_43", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_43", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa86b446-c3ed-405a-9e9f-ca11c0f9d040"), "Article_61", "Cometn_61", "ad23027b-fb0a-4b52-8a68-256dbcd956f2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8769), "Description_61", null, "FullName_61", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_61", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("acce6bcc-e868-48db-9fd9-a59cd791492a"), "Article_6", "Cometn_6", "f01d570a-465a-4217-8b6b-9da7ac4695c5", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7127), "Description_6", null, "FullName_6", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_6", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1c08cd4-3ebb-4aa5-b0a7-1e5dc3aa9e7b"), "Article_45", "Cometn_45", "1cc8bd7f-d1d3-4025-9dde-e9d5cd8ec310", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8274), "Description_45", null, "FullName_45", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_45", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b36a909d-85e3-40cd-a298-2ceeed8ec684"), "Article_25", "Cometn_25", "aafe356c-70fa-4366-9764-3e206179e7f9", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7671), "Description_25", null, "FullName_25", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_25", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b43f4a3a-54ea-453c-a5c5-3a2dbfb8e6ad"), "Article_79", "Cometn_79", "f2dc43c2-c243-451c-a226-c730324908c2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9357), "Description_79", null, "FullName_79", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_79", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6037bf8-e2fa-4850-8ecc-dd6aaa181890"), "Article_52", "Cometn_52", "47fb4868-6567-44a1-b6e9-fd46e54b5c31", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8502), "Description_52", null, "FullName_52", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_52", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8900370-7816-403c-9675-82f1dcdb6c26"), "Article_51", "Cometn_51", "b930a4df-56ec-4476-86ef-72efc64a01dd", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8481), "Description_51", null, "FullName_51", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_51", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bef2579d-1e81-4da2-ac70-4eb84fba4b02"), "Article_4", "Cometn_4", "c8835bff-3de8-4327-ae92-af06a7152826", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7060), "Description_4", null, "FullName_4", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_4", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1c6dfbe-3769-4382-aae0-b29ccea2a234"), "Article_60", "Cometn_60", "262a582e-0d09-40b1-85ff-2733f3749621", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8741), "Description_60", null, "FullName_60", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_60", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4505ea5-5670-4257-be8e-607fafeb1ece"), "Article_94", "Cometn_94", "bcde1ac0-1722-4a28-b88d-1348d0127687", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9830), "Description_94", null, "FullName_94", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_94", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c56fd3ae-70be-4491-ac9c-f50cc6db2590"), "Article_18", "Cometn_18", "4f134672-ca27-4aa4-ac1e-757213d20f66", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7468), "Description_18", null, "FullName_18", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_18", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c75917d3-6107-4d81-8f86-7a4323eb3da9"), "Article_81", "Cometn_81", "04332a1e-444d-48e9-8561-020973519af4", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9410), "Description_81", null, "FullName_81", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_81", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7bcd709-70cc-4a55-8195-87f730eb9598"), "Article_16", "Cometn_16", "71d4d3c3-15c2-4600-87d2-5433a70154a4", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7419), "Description_16", null, "FullName_16", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_16", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce7b75db-e8e8-4774-8b4e-9913000818f2"), "Article_70", "Cometn_70", "5468922a-f38b-4dbc-9b9d-9ba31f3ba462", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9038), "Description_70", null, "FullName_70", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_70", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d24391c4-d406-4c64-9e63-ff48a7e06054"), "Article_35", "Cometn_35", "50441126-2d3a-4e4a-a130-f8bcf796aaa0", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7961), "Description_35", null, "FullName_35", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_35", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d88b26e9-ea50-40b9-a41d-6cc7a8a52e4a"), "Article_8", "Cometn_8", "cd39dcae-8bd5-4ad2-840f-099f6f48b843", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7178), "Description_8", null, "FullName_8", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_8", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9f73d57-ea65-4ec6-81b3-0cc097be7cbe"), "Article_95", "Cometn_95", "1be03a90-80b8-4143-82f6-d7add51773e2", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9843), "Description_95", null, "FullName_95", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_95", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da3f77c7-bac1-44ba-aed5-0fa28d8d782d"), "Article_50", "Cometn_50", "59979c37-c43e-4f2d-9726-2658da2a8d07", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8451), "Description_50", null, "FullName_50", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_50", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db7d2ed8-69ea-435d-ac97-cd6f0ba939ab"), "Article_49", "Cometn_49", "6dcfec79-ad70-4b94-a9cb-255cd1561805", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8378), "Description_49", null, "FullName_49", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_49", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc310e35-09ba-4853-b654-a35143ac3d50"), "Article_1", "Cometn_1", "289a73aa-6263-4484-940c-7010e316238f", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(6819), "Description_1", null, "FullName_1", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_1", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e09327b2-b70a-4530-b42b-610a4faa5b44"), "Article_48", "Cometn_48", "40f270f1-526a-468e-a1de-b19819f14475", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8350), "Description_48", null, "FullName_48", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_48", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9c4e77a-170f-4af7-9911-625c7808fc68"), "Article_82", "Cometn_82", "d154698e-db9a-4db4-8b09-b04d68173d19", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9435), "Description_82", null, "FullName_82", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_82", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eee652dc-b6b0-49d8-9132-5d81637bc1cb"), "Article_91", "Cometn_91", "0ca48a43-ef86-4908-8fd2-c4c39e1f6e2a", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9769), "Description_91", null, "FullName_91", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_91", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2c656aa-35b8-40f9-8bc3-d3cea66b8f13"), "Article_32", "Cometn_32", "d400ce52-7057-46eb-be9c-93c0e36f7e16", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7876), "Description_32", null, "FullName_32", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_32", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3f44c9f-ecab-496f-8341-8564dc2d3cc1"), "Article_47", "Cometn_47", "bdb6ff81-58f9-45d2-b1ff-127e4773977a", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8324), "Description_47", null, "FullName_47", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_47", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3feeb14-49a4-4f25-8f8f-76283f95ad9f"), "Article_86", "Cometn_86", "fd3b1b7c-4ac0-488a-ae07-6cd44a7a4e79", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9537), "Description_86", null, "FullName_86", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_86", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f459871f-f818-4c15-a3d2-19afa4aeb19a"), "Article_71", "Cometn_71", "3bbe4afd-bccd-458c-9788-fe6928ac6918", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(9063), "Description_71", null, "FullName_71", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_71", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f498d6f8-6d8f-49c9-b737-04f662d3fa0d"), "Article_65", "Cometn_65", "a38fc9f5-e761-4935-b5d9-282954448b11", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8864), "Description_65", null, "FullName_65", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_65", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5ec2959-fe91-4065-949e-465982e6832e"), "Article_22", "Cometn_22", "8cc59bd6-31ba-48d3-affa-cc67a35d1ef5", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(7604), "Description_22", null, "FullName_22", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_22", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9f2122d-fec0-4a4c-b16e-f0be50af30fd"), "Article_37", "Cometn_37", "5859dbab-68fd-4f5d-be24-6a9cf6bc8c15", new DateTime(2022, 3, 1, 14, 20, 13, 451, DateTimeKind.Local).AddTicks(8018), "Description_37", null, "FullName_37", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_37", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
