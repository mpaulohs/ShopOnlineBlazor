using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EntityType = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Path = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashDesks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashDesks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientContactInformationTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContactInformationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencyes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencyes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItmeQualityes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItmeQualityes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnitClassifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnitClassifiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnitMeasuraments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnitMeasuraments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subdivisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdivisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BankId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Article = table.Column<string>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ProductTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductCharacteristicId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductQualityId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductSerieId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductUnitMeasurementId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    MainImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClientId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ClientContactInformationTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClientId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CurrencyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StorageId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReciverId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReciverAddres = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ReciverPhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    DocumentStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DocumentType = table.Column<int>(type: "INTEGER", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExchangeDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ClientId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ClientContractId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DocumentCurrencyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DocumentCurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultiplicityMutalSettlements = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocumentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResponsibleId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    SubdivisionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DocumentType = table.Column<int>(type: "INTEGER", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExchangeDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ClientId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ClientContractId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DocumentCurrencyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DocumentCurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultiplicityMutalSettlements = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocumentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResponsibleId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    SubdivisionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
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
                values: new object[] { new Guid("0378b692-1261-456a-81b3-73f8e3c97610"), "Article_8", "Cometn_8", "f1cfa07f-05e9-4203-85aa-7d835800d9d5", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6040), "Description_8", null, "FullName_8", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_8", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("061ba29d-b943-4df0-bee5-148298cbe5d2"), "Article_10", "Cometn_10", "398d6b71-3607-465c-afd7-5f1d96b29fcc", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6060), "Description_10", null, "FullName_10", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_10", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("09a0074d-86eb-42a6-968e-a0c964d4600f"), "Article_14", "Cometn_14", "79e8e466-4ecc-4de7-80aa-5491773100d8", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6110), "Description_14", null, "FullName_14", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_14", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("0b4c1c98-b0f6-4324-beb4-a82cbbcdd068"), "Article_38", "Cometn_38", "683ec1ba-9dc0-4ed0-b7a4-f677bdea4525", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6420), "Description_38", null, "FullName_38", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_38", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("0bc18075-331d-4b08-8475-a0b71bc1203d"), "Article_12", "Cometn_12", "733b6463-df4b-4c77-a806-45bc329edafe", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6090), "Description_12", null, "FullName_12", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_12", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("0bf80e13-3ee0-4401-b275-daef18821ba4"), "Article_9", "Cometn_9", "aae5718c-b4e7-4e4e-8aba-5e4f8f924829", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6050), "Description_9", null, "FullName_9", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_9", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("0d5f02f3-97a9-42fb-aace-bb3b981f1899"), "Article_63", "Cometn_63", "b9000a60-498f-46b1-b640-0e67e94d9934", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6730), "Description_63", null, "FullName_63", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_63", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("0f81f809-e2bc-409a-92a6-abd7a04c5f37"), "Article_39", "Cometn_39", "3f904cf1-33fe-4645-9905-6ea7488d122f", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6430), "Description_39", null, "FullName_39", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_39", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("0f890d78-bb97-4a3a-863b-2840b85a8b2d"), "Article_74", "Cometn_74", "cf70636b-d78a-41d8-b8b3-3fb564c1963b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6880), "Description_74", null, "FullName_74", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_74", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("1147095a-ac8b-475a-b925-d6ac4c8a7758"), "Article_32", "Cometn_32", "6b37c271-1496-4631-9c92-328010903562", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6340), "Description_32", null, "FullName_32", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_32", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("16957a49-0b81-4813-9ae8-9c4e0a06c0cd"), "Article_2", "Cometn_2", "93c96c7c-5461-47f5-a8f8-4377ec4b4a1e", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(5900), "Description_2", null, "FullName_2", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_2", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("18646a54-60b6-41f8-bc4a-44c52295f3c4"), "Article_77", "Cometn_77", "821af449-0ffc-4898-b551-e1dd9b5f0ebb", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6920), "Description_77", null, "FullName_77", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_77", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("1b46c58a-753d-4cb1-91a6-6c980703cab9"), "Article_26", "Cometn_26", "ccc24ead-910e-4dd7-820f-383fcd25a69d", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6270), "Description_26", null, "FullName_26", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_26", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("1c846e10-6087-4e02-9719-38c66b12736d"), "Article_76", "Cometn_76", "54e7f9ed-58d0-4869-a55a-470adab16c6d", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6910), "Description_76", null, "FullName_76", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_76", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("1d00be75-95d2-4247-972e-bedfaedf164c"), "Article_79", "Cometn_79", "ff1a8dea-3e70-42aa-851b-ab5db32adb3d", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6940), "Description_79", null, "FullName_79", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_79", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("1f646059-9676-49dd-926f-362cbeb60a5c"), "Article_44", "Cometn_44", "6c388e92-5ae1-499f-9e90-9ce6e2bf85b1", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6500), "Description_44", null, "FullName_44", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_44", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("20ca38da-28c2-4676-830a-012724fbefa4"), "Article_23", "Cometn_23", "ad7a0392-bfc5-4742-9f13-3b634585bc22", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6230), "Description_23", null, "FullName_23", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_23", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("231bd6de-9b40-4105-9c9a-bac9d44c540c"), "Article_48", "Cometn_48", "fdad8aee-e49d-496a-b637-33a509e7acc4", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6540), "Description_48", null, "FullName_48", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_48", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("26ea95dc-4952-45a0-949f-f0ccecba2cd5"), "Article_99", "Cometn_99", "bc177fb1-d525-432f-92dc-0542f2a54102", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7190), "Description_99", null, "FullName_99", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_99", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("2fe07c5f-12cf-463c-815b-3f42b91beeff"), "Article_60", "Cometn_60", "2364afb1-c163-4a0e-879a-f4db6dc7fc1d", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6700), "Description_60", null, "FullName_60", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_60", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("30ad012b-913a-4c66-86e3-a4420f4f961b"), "Article_5", "Cometn_5", "85437091-1930-444c-b6a9-8a301ceb32f4", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6000), "Description_5", null, "FullName_5", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_5", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("3336b14e-2d5a-40ae-9af0-227b6426d5c6"), "Article_47", "Cometn_47", "47d58831-bd4d-466f-b0ef-4dbe5136fa0d", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6530), "Description_47", null, "FullName_47", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_47", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("34cae827-7c6f-4374-ae49-4d3227693a80"), "Article_27", "Cometn_27", "5bd76e50-497a-47c3-9bfc-dfe2de942932", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6290), "Description_27", null, "FullName_27", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_27", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("36ec89ae-27ca-49f9-93f1-f81b3e84ddc5"), "Article_95", "Cometn_95", "66b36502-f06b-4532-8fec-aa5006bcea44", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7150), "Description_95", null, "FullName_95", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_95", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("385ee501-bcad-42f8-83f5-d8a0629f7b0b"), "Article_73", "Cometn_73", "b4d68ecb-ac41-415f-ac6b-a0f357c777e1", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6870), "Description_73", null, "FullName_73", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_73", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("3e677d47-32e3-4394-9738-a7b99b25ffeb"), "Article_41", "Cometn_41", "bfde1936-55d0-45a4-944d-d0a3f708f51b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6460), "Description_41", null, "FullName_41", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_41", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("3ec0e82b-3145-4a5a-910f-4df12330d7fe"), "Article_11", "Cometn_11", "a8996936-b78e-4656-b3b9-4151ed1ac6ca", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6080), "Description_11", null, "FullName_11", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_11", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("3f76a0ec-2ff3-46f7-8fa8-af30bbc15913"), "Article_91", "Cometn_91", "6ec6bcc8-0115-4f8f-aba3-acf8b25d77ea", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7100), "Description_91", null, "FullName_91", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_91", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("45d106bc-1059-41a0-86c7-090776ceb782"), "Article_80", "Cometn_80", "2aed782f-9114-4b85-9a5f-978dee91abad", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6950), "Description_80", null, "FullName_80", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_80", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("48a694b4-d5d6-4ae3-96a8-2310bb63386a"), "Article_15", "Cometn_15", "bcc85512-1bec-4660-8bdf-61e157211139", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6120), "Description_15", null, "FullName_15", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_15", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("58ee4c9b-cce8-48e1-9574-12322ecaf5f9"), "Article_75", "Cometn_75", "f7e27563-2b64-4789-87d1-251ce1495657", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6900), "Description_75", null, "FullName_75", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_75", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("598ca49b-6614-4ccf-9a77-c57876750812"), "Article_45", "Cometn_45", "86963627-4d78-4c1f-bc2c-a010dbf4fad1", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6510), "Description_45", null, "FullName_45", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_45", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("6740e273-8fdf-4b8e-8997-13f3f98d3e75"), "Article_92", "Cometn_92", "659889d5-9528-46d9-ba05-9b9e6b76236a", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7110), "Description_92", null, "FullName_92", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_92", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("6ab9f020-cc40-476d-9ab3-3c114a157c56"), "Article_18", "Cometn_18", "9d93d091-77f5-4771-aae5-b5dfddddaa99", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6170), "Description_18", null, "FullName_18", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_18", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("6c132a96-14f5-4dad-a02e-18c8a80aa612"), "Article_35", "Cometn_35", "65b81dac-13d8-41cd-9a0c-47dc05401ceb", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6390), "Description_35", null, "FullName_35", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_35", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("6de3b048-7b37-46c8-8d97-87a526cc11de"), "Article_53", "Cometn_53", "6458a758-4fff-4432-8a28-f5c25c4190c4", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6620), "Description_53", null, "FullName_53", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_53", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("6f08f4f7-509b-4aa5-8d16-90b96689c4d4"), "Article_98", "Cometn_98", "2a714304-981b-459e-b018-bf3823bf93d3", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7180), "Description_98", null, "FullName_98", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_98", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("6fcf216b-88b2-4462-99e9-6ad74c2a0ea6"), "Article_36", "Cometn_36", "5c1d31d7-26aa-4108-9009-40a8e34729d1", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6400), "Description_36", null, "FullName_36", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_36", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("75c4896b-b5f6-4cb9-88e9-343186161842"), "Article_55", "Cometn_55", "b11a5af3-42ba-45f7-94fb-ba32b30bbd42", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6640), "Description_55", null, "FullName_55", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_55", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("773b8092-8e09-47bf-88ee-f4105994d9a4"), "Article_66", "Cometn_66", "25aa5c4b-f4b7-4a7e-bcd4-6c5445eb863a", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6770), "Description_66", null, "FullName_66", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_66", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("77c15e7e-cb66-4a5d-a78a-7266abf315e7"), "Article_83", "Cometn_83", "0072a94c-cfda-40ae-a5e3-2453c61fe493", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6990), "Description_83", null, "FullName_83", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_83", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("78056b5a-2379-41e4-a42b-147802a2abad"), "Article_62", "Cometn_62", "9ef6c4bd-460c-4f41-afaf-192ba2cada05", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6720), "Description_62", null, "FullName_62", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_62", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("780ed791-082d-47f3-bea8-a00dabd6eb21"), "Article_20", "Cometn_20", "65ea0249-af73-4560-89c7-789d278298cf", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6200), "Description_20", null, "FullName_20", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_20", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("79642683-5c3a-4357-858d-ef1b1663fe9d"), "Article_33", "Cometn_33", "38207d98-dee8-4138-b011-9a02f6bab0cf", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6350), "Description_33", null, "FullName_33", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_33", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("798282c9-9c5e-41c5-a9f2-95bfceb1a448"), "Article_16", "Cometn_16", "ae46272b-4d17-4958-b5df-804f97e07508", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6150), "Description_16", null, "FullName_16", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_16", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("79e7f856-6f1a-4f40-bdf8-d3986e230550"), "Article_25", "Cometn_25", "01666be8-2226-4f88-ae37-4f2f05d1fed2", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6260), "Description_25", null, "FullName_25", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_25", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("7a7a5ade-2d0b-40de-acf3-8fb589f91a0a"), "Article_70", "Cometn_70", "0249d409-1ba2-4726-b806-a4574e0941fa", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6820), "Description_70", null, "FullName_70", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_70", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("840295fb-8e59-4274-a402-65751b1a2809"), "Article_46", "Cometn_46", "00fba7fc-ea48-43eb-98e8-d22050c5b4f0", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6520), "Description_46", null, "FullName_46", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_46", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("87014951-5947-4309-8b2e-961f69584da1"), "Article_81", "Cometn_81", "3bcb7183-f88a-4a6e-b5ad-73f656bf5d4c", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6960), "Description_81", null, "FullName_81", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_81", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("8b809e67-24c9-4152-a718-6c0a6de8d8f4"), "Article_71", "Cometn_71", "1c350231-9137-4216-b93c-8c131d486325", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6850), "Description_71", null, "FullName_71", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_71", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("8fba5871-a9a9-4b07-9f4c-50764eb28919"), "Article_52", "Cometn_52", "99075fff-2c91-4729-8e58-8ff77098ac3e", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6590), "Description_52", null, "FullName_52", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_52", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("900664c5-499b-43d1-bde8-cb93577dd5b1"), "Article_93", "Cometn_93", "b91f16cc-8e6c-4d91-bc20-a62b599b55f3", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7120), "Description_93", null, "FullName_93", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_93", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("9191c9fb-701f-46d0-9299-7ca150e608c0"), "Article_59", "Cometn_59", "f848a496-f753-4595-aa16-dc835d1d7abc", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6690), "Description_59", null, "FullName_59", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_59", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("92d7d1f1-a273-4166-9ab4-b6f83130f262"), "Article_54", "Cometn_54", "ce48e201-0af2-476d-849c-f6a475e2cdf0", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6630), "Description_54", null, "FullName_54", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_54", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("936eae25-7347-4cab-b391-96db4a7f49f3"), "Article_3", "Cometn_3", "dd268ece-fa34-45f3-bc1d-3249d6129027", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(5970), "Description_3", null, "FullName_3", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_3", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("96076f02-8025-49e7-b7d2-d3d7e76359e3"), "Article_94", "Cometn_94", "092cf593-d173-45d6-adde-6df71b9710b2", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7130), "Description_94", null, "FullName_94", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_94", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("97bbd6b8-7204-4d45-9835-67c1dcef58fe"), "Article_97", "Cometn_97", "b11cd9bd-5adf-4be3-9412-f9c31e951fae", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7170), "Description_97", null, "FullName_97", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_97", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("98f41abb-441d-4981-80e9-62911470d2f3"), "Article_86", "Cometn_86", "179d4222-d43d-419d-91ca-4f64be9f625b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7020), "Description_86", null, "FullName_86", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_86", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("99c8ebdd-2fca-4870-a74c-fe2297a98764"), "Article_7", "Cometn_7", "5f270871-be4e-4523-bdd5-482e16fcbcd1", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6030), "Description_7", null, "FullName_7", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_7", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("9cf266cd-b0f5-428d-b328-142c2adc980a"), "Article_67", "Cometn_67", "7e190b05-d747-48a2-a3f1-3aae30a2a44b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6790), "Description_67", null, "FullName_67", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_67", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("9f6e65c3-7b08-4403-833e-3ac17ba412d9"), "Article_43", "Cometn_43", "7fd15b35-6245-48c7-aaf4-56faf7f711f7", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6480), "Description_43", null, "FullName_43", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_43", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("9ff3ee50-21d3-4db6-b08f-bd075dec4a1a"), "Article_90", "Cometn_90", "0e9b9241-bb18-425e-9523-532b79bd9f69", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7070), "Description_90", null, "FullName_90", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_90", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("a273ecbb-fc63-4748-9eb4-1377d44f8230"), "Article_56", "Cometn_56", "0d08dd4d-372e-48d4-8436-ec3b36acd131", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6650), "Description_56", null, "FullName_56", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_56", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("a3a7a830-11dc-43d0-afe8-9ff5915f2132"), "Article_82", "Cometn_82", "18ed1d8f-840a-45b9-87a3-78f909a7e35a", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6980), "Description_82", null, "FullName_82", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_82", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("a69981ef-e263-46e0-86d1-0fed043267d4"), "Article_13", "Cometn_13", "7fb97aab-19b1-41e1-bfe3-d98ed0b6ccd7", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6100), "Description_13", null, "FullName_13", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_13", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("a941e926-75d1-45d3-8657-b7db90e973cb"), "Article_30", "Cometn_30", "c3837d81-085f-4e02-a321-fffdabdfa38c", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6320), "Description_30", null, "FullName_30", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_30", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("a9fd185c-16e1-485a-824f-17bc19d6526e"), "Article_57", "Cometn_57", "9f08937a-a759-45da-a5d2-27308e26f05b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6660), "Description_57", null, "FullName_57", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_57", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("aa3dfd84-de9d-40f2-a238-65a1258f466d"), "Article_29", "Cometn_29", "06835430-4e64-4e4a-bd40-02e1e3827509", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6310), "Description_29", null, "FullName_29", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_29", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("ab87e6a7-464b-4d74-8431-a66608970bc2"), "Article_88", "Cometn_88", "a6cbf49a-c958-402c-a017-e4ef32560e9b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7050), "Description_88", null, "FullName_88", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_88", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("abc5f4ff-545c-4784-a156-cbc0eba89164"), "Article_34", "Cometn_34", "aaeb6363-569d-4c8a-8b44-b58b8e88dcff", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6370), "Description_34", null, "FullName_34", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_34", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("b62859da-62af-4aea-bba7-ace4243cdcb9"), "Article_61", "Cometn_61", "9e80ac5a-76f9-4ec2-8239-973467a9a304", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6710), "Description_61", null, "FullName_61", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_61", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("b89b56d7-f93f-489d-b413-ddabad038552"), "Article_4", "Cometn_4", "f89dc034-57f4-4af7-88ab-0a2fe4b2950c", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(5990), "Description_4", null, "FullName_4", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_4", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("bca49f7e-cc5a-4c16-a25b-1168293a485c"), "Article_89", "Cometn_89", "5a56d57c-3aad-49a9-a997-e44e4f06570d", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7060), "Description_89", null, "FullName_89", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_89", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("bd2a2c17-2dca-4a7b-834a-371c2c3e6fb3"), "Article_31", "Cometn_31", "38288a0a-f446-4ec1-8cbc-e88c38d81712", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6330), "Description_31", null, "FullName_31", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_31", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("c3ecc9f3-3c76-41c4-be51-87c5a73749b2"), "Article_51", "Cometn_51", "a24cf57c-3183-430c-a087-ab13ea919570", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6580), "Description_51", null, "FullName_51", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_51", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("c6c382ad-907b-454b-8543-dca580c6190b"), "Article_28", "Cometn_28", "812c1a82-998c-4150-a49b-b8dc282b76a0", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6300), "Description_28", null, "FullName_28", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_28", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("c9b86e02-3d26-4f9c-a75e-081524975e5b"), "Article_49", "Cometn_49", "793a0ce6-d692-4b32-a797-17fed2efb813", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6550), "Description_49", null, "FullName_49", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_49", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("cb82dba7-6a60-49d3-b3d6-a315430b47e5"), "Article_72", "Cometn_72", "e6fcaa09-d613-4aa1-a543-58d3cdcc863b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6860), "Description_72", null, "FullName_72", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_72", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("cc8d8a70-6cae-4489-8173-9b5291875723"), "Article_19", "Cometn_19", "01ba8dc8-4a34-45ea-9f3d-595871d42751", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6190), "Description_19", null, "FullName_19", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_19", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("d0df6323-59aa-4bb2-b0ca-59c49bd49474"), "Article_1", "Cometn_1", "02d9e883-d3af-4899-8ecb-57586b8f6034", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(5830), "Description_1", null, "FullName_1", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_1", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("d396cca1-2f77-4349-adfe-663f9f689b06"), "Article_85", "Cometn_85", "ddc90fe9-5738-452f-b505-9814ce8e0f90", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7010), "Description_85", null, "FullName_85", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_85", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("da73f720-402b-45bc-8df1-bf2cbbc217e5"), "Article_37", "Cometn_37", "d18a03b4-df94-430c-a158-fed4274ca8f0", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6410), "Description_37", null, "FullName_37", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_37", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("da8238c7-0d6c-479a-a455-eecce11473b5"), "Article_6", "Cometn_6", "c5cbff79-ff89-401c-842f-556a764ae327", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6020), "Description_6", null, "FullName_6", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_6", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("db6d4e48-5647-487a-b1c7-04422dd00d83"), "Article_84", "Cometn_84", "7168c4a5-2a6e-4888-98e8-01663b3adbaf", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7000), "Description_84", null, "FullName_84", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_84", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("dba69738-5118-4740-941f-790b00af2032"), "Article_21", "Cometn_21", "dc67e611-3bf9-486e-b2c8-4499a8607184", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6210), "Description_21", null, "FullName_21", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_21", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("dfe3b9a3-b61c-4dff-bdb4-4518afe7b4a4"), "Article_58", "Cometn_58", "4fd48ca8-7e74-48b9-93e9-469b413120bb", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6670), "Description_58", null, "FullName_58", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_58", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e1c13316-a0d1-422a-b740-fc0bbc598c91"), "Article_96", "Cometn_96", "b5f7333d-57fa-4d7d-b83f-5900974de716", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7160), "Description_96", null, "FullName_96", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_96", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e2eb8275-1d6a-4f7e-9626-06c9888b8de1"), "Article_42", "Cometn_42", "461299dc-e3f7-4b94-af35-66df962af338", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6470), "Description_42", null, "FullName_42", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_42", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e301e0fc-70d0-4c01-ac47-27112ec738d9"), "Article_64", "Cometn_64", "73f12029-4993-4d07-a6bd-95e1ce737466", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6750), "Description_64", null, "FullName_64", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_64", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e43de900-eef1-4b4b-9e32-5316d810c9c0"), "Article_69", "Cometn_69", "4fa6628e-fb3f-46e4-adc7-157439fecd3b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6810), "Description_69", null, "FullName_69", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_69", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e597927b-8836-4191-ad24-7a6056ba554b"), "Article_24", "Cometn_24", "beb49690-d015-4f29-9d72-20e363a2f89b", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6250), "Description_24", null, "FullName_24", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_24", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e6f7c5aa-dd66-49ac-9961-4d44907d9af2"), "Article_50", "Cometn_50", "2ed7126c-27d0-445f-85de-b2bb284ae985", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6560), "Description_50", null, "FullName_50", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_50", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("e7978909-7a06-4507-b176-2f714c68141a"), "Article_78", "Cometn_78", "520232c1-633f-4665-982e-dbb4bb1a5f05", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6930), "Description_78", null, "FullName_78", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_78", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("eba2a8ba-f29e-44ca-9ac6-0fa54c527822"), "Article_17", "Cometn_17", "be3de775-4458-4441-90e3-dfc075ef7499", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6160), "Description_17", null, "FullName_17", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_17", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("ed086f71-b817-4590-ba82-ea030e6b560c"), "Article_40", "Cometn_40", "ccfa8296-573f-48ac-b4e5-30dc44d79ab2", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6450), "Description_40", null, "FullName_40", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_40", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("ed11344d-8ebf-4ad9-8288-2055d51d3d0b"), "Article_87", "Cometn_87", "6f0b6f0a-0028-4f51-b065-54507cb2d5ef", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(7040), "Description_87", null, "FullName_87", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_87", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("ef896d3f-bfe2-42f2-bdb3-12f00cf1212f"), "Article_68", "Cometn_68", "f7829c1d-c879-4ed8-a805-3746eefebeca", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6800), "Description_68", null, "FullName_68", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_68", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("f43d1aa8-d3ca-4f3e-b092-6a937b792a1f"), "Article_65", "Cometn_65", "b495b448-7acf-40c5-a441-bfafa161cab1", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6760), "Description_65", null, "FullName_65", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_65", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Comment", "ConcurrencyStamp", "CreatedAt", "Description", "ExchangeId", "FullName", "IsPublic", "MainImageUrl", "Name", "ProductCharacteristicId", "ProductQualityId", "ProductSerieId", "ProductTypeId", "ProductUnitMeasurementId", "UpdatedAt" },
                values: new object[] { new Guid("f93a55a5-f87e-4782-97c3-e3f1b1fc436d"), "Article_22", "Cometn_22", "6b798450-13d6-41cb-bb6f-b631e0e8f24a", new DateTime(2022, 6, 21, 11, 4, 28, 966, DateTimeKind.Local).AddTicks(6220), "Description_22", null, "FullName_22", true, "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg", "Name_22", null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                unique: true);

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
                unique: true);
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
