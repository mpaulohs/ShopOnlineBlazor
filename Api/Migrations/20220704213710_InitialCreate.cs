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
                    EntityType = table.Column<string>(type: "TEXT", nullable: true),
                    EntityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Path = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
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
                    ShortName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
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
                name: "DocumentStatus<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatus<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItmeQualityes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: false)
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
                name: "PriceType<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceType<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                name: "ProductQuantity<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQuantity<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    ProductQualityId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductSerieId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductUnitMeasurementId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    MainImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "ClientContactInformation<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClientId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ClientContactInformationTypeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContactInformation<Guid>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientContactInformation<Guid>_ClientContactInformationTypes_ClientContactInformationTypeId",
                        column: x => x.ClientContactInformationTypeId,
                        principalTable: "ClientContactInformationTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientContactInformation<Guid>_Users_ClientId",
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
                name: "Product<Guid>ProductCharacteristic<Guid>",
                columns: table => new
                {
                    ProductCharacteristicsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product<Guid>ProductCharacteristic<Guid>", x => new { x.ProductCharacteristicsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_Product<Guid>ProductCharacteristic<Guid>_ProductCharacteristics_ProductCharacteristicsId",
                        column: x => x.ProductCharacteristicsId,
                        principalTable: "ProductCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product<Guid>ProductCharacteristic<Guid>_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
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
                    DocumentStatusId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExchangeId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DocumentTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                        name: "FK_Documents_DocumentStatus<Guid>_DocumentStatusId",
                        column: x => x.DocumentStatusId,
                        principalTable: "DocumentStatus<Guid>",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentType<Guid>_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType<Guid>",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_PriceType<Guid>_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType<Guid>",
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
                    DocumentTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                        name: "FK_Payments_DocumentType<Guid>_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType<Guid>",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_PriceType<Guid>_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceType<Guid>",
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
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("00b85098-0e25-428d-8acf-fb53d9d265a2"), null, "Molestiae ex perspiciatis sit expedita nam iusto ipsam cupiditate alias.", "86f35db1-9ecf-45b5-9c25-878309aea3ca", new DateTime(2020, 12, 5, 6, 56, 52, 481, DateTimeKind.Local).AddTicks(4092), "Bank account: suscipit", new DateTime(2021, 5, 19, 5, 27, 31, 211, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04d6a3ee-3294-4391-9d96-36ba9f542f9d"), null, "Nesciunt dolor quae quas quibusdam quaerat quos.", "4c16250c-6c34-4fda-b7ec-a6b5ae56f23c", new DateTime(2022, 5, 1, 8, 53, 10, 255, DateTimeKind.Local).AddTicks(4411), "Bank account: debitis", new DateTime(2022, 5, 13, 22, 3, 35, 23, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06c35ee6-7ade-4794-bf94-01a6a8ec87bd"), null, "Commodi iusto odio nisi odio impedit.", "9a31daaf-59f1-4bee-91e0-17a0e4098a3b", new DateTime(2019, 1, 1, 20, 44, 52, 725, DateTimeKind.Local).AddTicks(186), "Bank account: iure", new DateTime(2022, 4, 21, 15, 22, 2, 291, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("077039c8-c210-4de3-b437-95615910943a"), null, "Ut odio incidunt.", "81cc6b57-9e20-4437-b7c9-36d14741dfb7", new DateTime(2019, 3, 2, 9, 59, 48, 658, DateTimeKind.Local).AddTicks(294), "Bank account: voluptatem", new DateTime(2022, 1, 3, 0, 48, 28, 772, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08912e60-9498-4a2d-a6e8-1635ea5ddbbe"), null, "Inventore pariatur consequatur sint labore distinctio ipsa numquam.", "ac2d2101-8c24-40df-852c-80559ca0c89d", new DateTime(2018, 11, 10, 17, 11, 28, 903, DateTimeKind.Local).AddTicks(3322), "Bank account: magnam", new DateTime(2020, 12, 19, 23, 25, 55, 862, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ab90ae4-94a2-4b01-ba12-29bb57fce564"), null, "Sunt aut harum hic laboriosam adipisci non ut.", "0f2c5ac4-483b-49cf-9081-b54fb6bac113", new DateTime(2022, 7, 1, 8, 3, 57, 313, DateTimeKind.Local).AddTicks(2301), "Bank account: ipsa", new DateTime(2022, 7, 3, 11, 21, 56, 223, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("10e51f8e-f2f5-45a3-aa34-153f6b5adcdc"), null, "Totam quam nulla ut voluptate voluptatem animi.", "46fa64a9-63b2-41ff-ac23-7c75d9925fe0", new DateTime(2018, 5, 7, 23, 2, 27, 643, DateTimeKind.Local).AddTicks(3122), "Bank account: iste", new DateTime(2020, 9, 7, 23, 40, 43, 691, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1279e04e-953a-4990-9dbc-c7d740937abd"), null, "Qui dolores quo et deleniti dolor voluptas non architecto.", "523130e3-5125-4223-95c5-1a7178e04ea5", new DateTime(2021, 6, 16, 9, 7, 24, 734, DateTimeKind.Local).AddTicks(8859), "Bank account: nam", new DateTime(2022, 4, 13, 9, 1, 41, 481, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15e1fd56-3c06-4959-b8dd-e54c4d0015a8"), null, "Est voluptatem voluptatibus est nobis voluptatibus enim iusto illo sit.", "3b77de6c-cfe5-4c86-b6bc-cfdc5ce7bf35", new DateTime(2019, 5, 21, 1, 43, 33, 121, DateTimeKind.Local).AddTicks(3872), "Bank account: quia", new DateTime(2020, 2, 19, 3, 44, 19, 293, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1a7f96b2-eb4e-4571-9a00-c8ffcb44cef8"), null, "In dicta in a iusto dolor enim.", "d2d82636-acea-4aff-b577-c26c73d9da8a", new DateTime(2020, 12, 20, 8, 47, 52, 790, DateTimeKind.Local).AddTicks(8552), "Bank account: eveniet", new DateTime(2021, 4, 20, 7, 5, 5, 940, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1f67c044-c5d3-4054-a93e-1e62da6f7ab2"), null, "Aliquam est in velit sit esse nulla harum ut corrupti.", "c00be77e-8a59-47f9-8978-97dfa713dde1", new DateTime(2020, 3, 12, 22, 8, 13, 914, DateTimeKind.Local).AddTicks(8298), "Bank account: similique", new DateTime(2021, 11, 5, 7, 23, 23, 963, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2330fd70-eeb8-42da-b4d6-d8fc6756d4d3"), null, "Aut ratione exercitationem rerum velit.", "afbe18b2-88fb-4491-a3ea-65799caa446c", new DateTime(2021, 4, 22, 5, 48, 48, 688, DateTimeKind.Local).AddTicks(2732), "Bank account: odit", new DateTime(2022, 6, 25, 1, 3, 58, 860, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23ab7c1f-f09c-4c29-8351-49a11c2ddba4"), null, "Sed quidem blanditiis mollitia modi voluptas possimus quas dolor.", "597afbfd-8259-4ce8-b498-26f1f4a12e30", new DateTime(2020, 4, 14, 22, 18, 4, 560, DateTimeKind.Local).AddTicks(7509), "Bank account: eos", new DateTime(2020, 11, 16, 22, 59, 0, 814, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23b4cee8-bf5f-40f3-bdae-beefede4d8fa"), null, "Voluptatum cum est vel voluptates autem vel.", "dc843831-e36a-4fd3-81e7-35b4d40592fc", new DateTime(2018, 7, 2, 10, 3, 6, 725, DateTimeKind.Local).AddTicks(9766), "Bank account: esse", new DateTime(2021, 1, 21, 11, 28, 37, 31, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("250e508e-aff8-4b1b-bc5c-3d063ebbd7fb"), null, "Delectus consequatur velit sunt quas ipsum aperiam molestiae qui maiores.", "8eed93cc-428c-4b84-9e22-df3edc5770ef", new DateTime(2018, 8, 14, 9, 56, 29, 304, DateTimeKind.Local).AddTicks(5237), "Bank account: laudantium", new DateTime(2020, 9, 20, 22, 35, 56, 188, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2a101483-18f7-4886-8155-e66b24b9e2d0"), null, "Qui ut voluptas.", "6333fe17-cf5d-4dc3-af63-20e269500086", new DateTime(2018, 3, 25, 2, 54, 28, 616, DateTimeKind.Local).AddTicks(8208), "Bank account: minus", new DateTime(2020, 7, 6, 14, 22, 24, 187, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31a5d802-78ec-49c3-befe-d513bd937b01"), null, "Consequatur quo ipsum corrupti nam distinctio possimus dolores beatae.", "49c79aea-b574-434d-acab-213245871090", new DateTime(2018, 3, 29, 13, 2, 27, 652, DateTimeKind.Local).AddTicks(121), "Bank account: aspernatur", new DateTime(2022, 6, 28, 2, 3, 25, 622, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ab22506-1c09-4870-b489-afba95a4acee"), null, "Harum nam reprehenderit incidunt voluptas voluptatum rerum ut.", "653f5cd5-8065-498d-b92f-65b332ad828f", new DateTime(2018, 8, 25, 20, 8, 24, 9, DateTimeKind.Local).AddTicks(1470), "Bank account: laudantium", new DateTime(2021, 4, 13, 0, 33, 35, 675, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b0688d3-8595-46c2-aba0-12bddd696630"), null, "Sed officia optio voluptatum enim perspiciatis.", "ff3fcfa5-6e7f-46f7-8857-37fcbc788fd6", new DateTime(2021, 9, 13, 7, 56, 56, 79, DateTimeKind.Local).AddTicks(1240), "Bank account: alias", new DateTime(2022, 3, 17, 23, 3, 47, 689, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41d58c07-d408-4e5d-974b-9e695828c7ef"), null, "Reprehenderit et aut nostrum dolor officia recusandae.", "89646c43-c324-464c-9ea6-6eab7df1e0ac", new DateTime(2021, 8, 2, 23, 0, 23, 227, DateTimeKind.Local).AddTicks(8700), "Bank account: ut", new DateTime(2021, 11, 12, 12, 26, 43, 611, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("425d296a-69f4-456d-b459-5ab7c7f9391e"), null, "Qui deleniti omnis quisquam.", "80e85fb0-ef03-4146-b9f6-cb7697da4c4d", new DateTime(2021, 3, 12, 16, 30, 22, 900, DateTimeKind.Local).AddTicks(5482), "Bank account: repudiandae", new DateTime(2021, 10, 21, 23, 13, 54, 722, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42c2fdcd-a280-46f1-919b-ae7c7f33a680"), null, "Qui sapiente eos soluta consequatur quibusdam impedit sapiente animi repudiandae.", "c1e1b8ae-bc45-4c4d-89db-a3c7fb17b1e8", new DateTime(2020, 10, 19, 10, 18, 26, 1, DateTimeKind.Local).AddTicks(176), "Bank account: id", new DateTime(2021, 12, 19, 20, 46, 2, 652, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("44c0e351-b940-4570-9f82-fec82706c2fd"), null, "Quibusdam placeat et quisquam.", "5d32331a-f404-4751-8b8e-a729fd9a6daf", new DateTime(2021, 9, 14, 22, 57, 25, 715, DateTimeKind.Local).AddTicks(351), "Bank account: ut", new DateTime(2022, 4, 22, 16, 54, 15, 911, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4518d923-21d6-4764-8124-aeee22d73450"), null, "A quos excepturi ad pariatur cupiditate quasi sit autem est.", "f171a192-68b1-4a61-a7b0-4bd1e29334ba", new DateTime(2020, 12, 25, 5, 46, 17, 207, DateTimeKind.Local).AddTicks(8622), "Bank account: amet", new DateTime(2021, 3, 18, 3, 6, 27, 429, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c5b3e03-f3b1-4f01-90d7-19c9b457dfc7"), null, "Rerum consectetur eius saepe.", "2c153b50-236e-4cbc-9407-0e16c0ce425b", new DateTime(2022, 3, 7, 22, 22, 8, 226, DateTimeKind.Local).AddTicks(8097), "Bank account: nam", new DateTime(2022, 5, 27, 21, 54, 37, 305, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f5fdccf-8124-4810-82c3-772d62f36429"), null, "Repellat sed et rerum voluptate sapiente nam.", "a27e34ad-33a2-4e9c-80bd-c1d2e2a20e8a", new DateTime(2018, 10, 11, 3, 41, 19, 572, DateTimeKind.Local).AddTicks(1969), "Bank account: nihil", new DateTime(2020, 11, 22, 13, 13, 28, 510, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("504f04a3-a0a6-4543-9c61-fb6ce876a0f7"), null, "Sit nihil consequatur dolore maiores adipisci aut in et accusantium.", "373bb288-3991-4aa6-900f-02fde5e00b18", new DateTime(2021, 8, 6, 3, 31, 50, 951, DateTimeKind.Local).AddTicks(8262), "Bank account: quos", new DateTime(2021, 11, 23, 3, 37, 35, 195, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5298519c-a653-4655-9960-99ca630745a7"), null, "Dolor itaque quae omnis voluptatem et ut debitis quidem consequatur.", "e740b081-6812-45b8-8da0-9a0427ff1687", new DateTime(2020, 10, 22, 10, 22, 5, 677, DateTimeKind.Local).AddTicks(4589), "Bank account: molestiae", new DateTime(2021, 12, 20, 22, 56, 30, 154, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("583114c0-5d0c-4491-9076-e70fab199232"), null, "Sit laboriosam aliquam quibusdam iste.", "11144a5e-213c-4173-9f83-d7506c6b78e8", new DateTime(2018, 2, 8, 22, 13, 33, 210, DateTimeKind.Local).AddTicks(4125), "Bank account: veritatis", new DateTime(2018, 2, 27, 1, 6, 0, 70, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d8ff1e6-d8e9-4ab3-8294-8ab0e31ee3d7"), null, "Voluptatem fuga dolorem et in enim.", "ca686cce-b32b-4e86-a5bb-82c016db6299", new DateTime(2020, 11, 6, 12, 49, 49, 388, DateTimeKind.Local).AddTicks(2031), "Bank account: fugit", new DateTime(2020, 12, 23, 17, 42, 40, 281, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e5bd9fd-fda8-4efb-85e4-8429185709c5"), null, "Nam tempora molestias non.", "0633c52e-99b6-4b9a-9963-b422995856f3", new DateTime(2020, 11, 10, 10, 10, 13, 168, DateTimeKind.Local).AddTicks(4677), "Bank account: nam", new DateTime(2021, 9, 27, 14, 30, 32, 753, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6010fb35-f656-471a-91ad-8278f314b3e3"), null, "Quia eos minus iste dignissimos.", "45bb5044-eb86-4c93-adff-fbd9f4b66f81", new DateTime(2021, 1, 15, 12, 41, 40, 546, DateTimeKind.Local).AddTicks(9729), "Bank account: eius", new DateTime(2022, 6, 15, 15, 48, 53, 803, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("608b6d0f-549f-4374-a8d7-17a05c0ae562"), null, "Rerum sint modi.", "7f517a07-b106-4632-902a-c5b552ceeec6", new DateTime(2021, 6, 18, 18, 9, 2, 659, DateTimeKind.Local).AddTicks(5572), "Bank account: fuga", new DateTime(2022, 2, 24, 18, 28, 47, 476, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61027866-bd10-4d27-af2a-cf69e21bd394"), null, "Occaecati sit eos alias vitae asperiores est pariatur recusandae possimus.", "073ef45e-5b70-434d-a9a1-dc2eb11e68ba", new DateTime(2021, 5, 7, 6, 44, 21, 263, DateTimeKind.Local).AddTicks(2672), "Bank account: harum", new DateTime(2021, 6, 4, 6, 57, 41, 916, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61059668-7e6d-4a5e-89ae-e6e4759bae12"), null, "Rerum quaerat est ullam.", "a66c1159-d3a4-42ee-8944-c7f8ba0ece7a", new DateTime(2022, 4, 5, 15, 3, 12, 559, DateTimeKind.Local).AddTicks(3221), "Bank account: voluptatem", new DateTime(2022, 6, 15, 8, 22, 48, 545, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("639709a3-8464-47c9-b237-c5a6535b1e09"), null, "Odit sit eveniet quibusdam et laudantium.", "55cb491e-3df4-427e-acca-5db286a3f293", new DateTime(2018, 10, 8, 20, 34, 43, 372, DateTimeKind.Local).AddTicks(2638), "Bank account: voluptatem", new DateTime(2020, 1, 4, 5, 56, 30, 134, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6d27adac-be16-4c7c-8f86-72aaf250c06a"), null, "Id voluptatem harum.", "22e053aa-8073-4d7c-9018-ac27a6baf679", new DateTime(2019, 10, 23, 19, 13, 58, 925, DateTimeKind.Local).AddTicks(7706), "Bank account: tempora", new DateTime(2022, 7, 2, 2, 55, 52, 118, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73cab208-76fc-4c8b-87b2-505bf9432960"), null, "Fugiat quis quis quo id culpa nesciunt.", "7c753276-e8fe-4d67-afd2-b307bc896e0d", new DateTime(2020, 6, 20, 13, 38, 37, 0, DateTimeKind.Local).AddTicks(2005), "Bank account: facilis", new DateTime(2021, 4, 9, 19, 23, 37, 984, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("78679a59-720c-4e31-b79d-04e1f8219406"), null, "Qui aut libero vel iste officiis ut.", "06b17558-b997-48ca-9d32-49f2cd351805", new DateTime(2021, 11, 19, 15, 2, 30, 67, DateTimeKind.Local).AddTicks(4343), "Bank account: dicta", new DateTime(2022, 4, 25, 0, 36, 32, 665, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("788f5d6a-b33b-49d6-a2f1-1621edb480c5"), null, "Vero quasi quis eum est ipsam quos consequatur dolore.", "c80c81a5-bb25-43eb-933a-eb635ede1fed", new DateTime(2017, 12, 2, 10, 37, 46, 432, DateTimeKind.Local).AddTicks(4686), "Bank account: qui", new DateTime(2020, 7, 6, 6, 19, 12, 241, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7daf1d6b-f728-46de-92f9-913ed649df3f"), null, "Placeat quo et hic qui eius voluptas.", "5641bb2c-3608-4cc0-a6a8-6a242cf39260", new DateTime(2018, 4, 20, 8, 58, 26, 741, DateTimeKind.Local).AddTicks(2163), "Bank account: corrupti", new DateTime(2019, 9, 16, 9, 22, 11, 316, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("82dd6366-c20d-42d5-a56c-24567a571a3d"), null, "Quis molestiae accusamus esse sit tenetur.", "3d583614-594d-4cd5-9792-7d6e965f6292", new DateTime(2018, 1, 15, 19, 0, 21, 1, DateTimeKind.Local).AddTicks(6364), "Bank account: occaecati", new DateTime(2020, 4, 7, 15, 32, 17, 166, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("830ca1ba-bb79-4288-8200-434f749cb1f4"), null, "Harum voluptas esse iure.", "f1b6db33-4289-49fb-bc34-e05d7550964e", new DateTime(2022, 6, 8, 18, 27, 28, 402, DateTimeKind.Local).AddTicks(9063), "Bank account: natus", new DateTime(2022, 6, 13, 23, 45, 27, 984, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("85c364f8-f9a7-47f3-8491-68b378d2a2ab"), null, "Qui sed fugiat assumenda sunt rerum minima officia molestiae.", "a7487ece-0677-4639-84ed-a2ceb6b029e4", new DateTime(2020, 3, 8, 4, 44, 56, 956, DateTimeKind.Local).AddTicks(5124), "Bank account: officiis", new DateTime(2021, 2, 19, 12, 19, 50, 457, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86455ea4-67c0-471d-8bb1-f29686ecd58e"), null, "Adipisci quas non porro pariatur soluta dicta et.", "d26766c9-df20-4c60-a22e-acfa94707305", new DateTime(2020, 11, 13, 22, 58, 53, 995, DateTimeKind.Local).AddTicks(5157), "Bank account: magnam", new DateTime(2021, 1, 11, 18, 23, 42, 589, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("88025efb-609e-4287-a13d-7acb68e76ce3"), null, "Est quam non aut illum accusantium.", "919b17eb-130b-4e02-9c2c-ea678c49f5cd", new DateTime(2022, 2, 8, 3, 22, 5, 520, DateTimeKind.Local).AddTicks(6462), "Bank account: dolore", new DateTime(2022, 3, 29, 0, 48, 48, 895, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("899151cc-d5cc-4088-9dd5-1b9df8151c87"), null, "Voluptate quis nobis architecto sed deleniti quibusdam aut numquam inventore.", "0fc76d77-919c-4b75-b049-ff20bdad7cbc", new DateTime(2017, 11, 9, 23, 45, 42, 43, DateTimeKind.Local).AddTicks(4388), "Bank account: earum", new DateTime(2017, 12, 28, 11, 48, 0, 935, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90cc7acd-5718-4fa8-816d-40a4f9321ef9"), null, "Sunt quos eum quia dolore.", "864f6a85-1dc8-48e3-b38b-59236a634caa", new DateTime(2021, 2, 16, 13, 52, 53, 655, DateTimeKind.Local).AddTicks(1023), "Bank account: et", new DateTime(2022, 6, 10, 0, 4, 22, 56, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91578e4b-b946-4720-93ac-53241335c581"), null, "Earum illo laboriosam voluptatem blanditiis similique aut necessitatibus rem.", "45a1fe65-de0b-4ef2-a002-ae6f265c8e03", new DateTime(2020, 1, 25, 6, 6, 11, 804, DateTimeKind.Local).AddTicks(6120), "Bank account: voluptatibus", new DateTime(2020, 7, 27, 15, 30, 34, 358, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("951deb2c-1384-4aab-ac41-fbf896c2bd18"), null, "Ducimus qui omnis vero necessitatibus sapiente aut sed ab.", "b3f8b308-0043-4733-a74b-df209b6da3f6", new DateTime(2017, 9, 11, 4, 9, 41, 715, DateTimeKind.Local).AddTicks(5819), "Bank account: voluptatibus", new DateTime(2017, 11, 24, 18, 31, 53, 755, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("951ed4d9-37d8-4db1-b8dd-c51581339a32"), null, "Occaecati repudiandae iure ducimus et magni.", "514c56e3-438b-43ef-9062-ca4f48f0f38e", new DateTime(2021, 7, 3, 19, 54, 5, 248, DateTimeKind.Local).AddTicks(6384), "Bank account: nihil", new DateTime(2021, 11, 19, 7, 14, 56, 933, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("998870b1-38f3-47a7-8fbd-ee3b52e37d4b"), null, "Reprehenderit modi cum dolorem neque quis unde adipisci.", "6fe4c0aa-74ba-49f8-af01-b4a6154b43cd", new DateTime(2021, 10, 2, 15, 43, 34, 825, DateTimeKind.Local).AddTicks(1921), "Bank account: dolorum", new DateTime(2022, 7, 1, 6, 15, 3, 279, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99a8096e-98c2-46b6-8f90-3051598eff87"), null, "Aut deserunt distinctio pariatur nemo architecto omnis.", "8d46d746-ade3-46fd-8dc1-46f401f2fc83", new DateTime(2020, 9, 14, 0, 1, 31, 178, DateTimeKind.Local).AddTicks(1752), "Bank account: fuga", new DateTime(2021, 2, 5, 22, 51, 36, 730, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a29b97f0-ea63-4a32-b64e-837490a72170"), null, "Consequatur et delectus asperiores nobis odit.", "59e077d8-c6f3-4f65-a65a-4f418c7e476f", new DateTime(2019, 12, 23, 1, 0, 36, 47, DateTimeKind.Local).AddTicks(5521), "Bank account: occaecati", new DateTime(2020, 8, 14, 9, 46, 23, 262, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a4ded1cc-f6ed-4736-b038-08af155a017c"), null, "Est consequuntur et dolores totam porro eos qui.", "3ba815eb-5ba7-42b0-9f58-bbafa23aec1f", new DateTime(2021, 7, 6, 19, 13, 19, 876, DateTimeKind.Local).AddTicks(7096), "Bank account: consequatur", new DateTime(2021, 8, 31, 21, 43, 2, 296, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a595ebcd-b5a5-40ce-90d5-f55b181c6744"), null, "Assumenda distinctio consectetur quibusdam inventore doloremque nesciunt ab.", "7d3efbc6-1a08-42ba-b445-03df1e440f55", new DateTime(2021, 2, 3, 16, 38, 4, 785, DateTimeKind.Local).AddTicks(5053), "Bank account: praesentium", new DateTime(2022, 2, 11, 20, 46, 44, 277, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6bd9dec-f2f3-438a-934c-e902d8150989"), null, "Perspiciatis nihil eos.", "8eaa8986-cc99-41ac-b062-67f4fe98a880", new DateTime(2019, 2, 1, 23, 36, 42, 645, DateTimeKind.Local).AddTicks(7486), "Bank account: quibusdam", new DateTime(2021, 1, 2, 17, 31, 23, 140, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6ca71c1-114e-4690-af60-91ef1c512bfe"), null, "Eligendi qui nemo recusandae quo hic.", "625c5109-b17f-47be-8ed4-b83bb72f9960", new DateTime(2017, 7, 24, 20, 5, 25, 253, DateTimeKind.Local).AddTicks(990), "Bank account: distinctio", new DateTime(2021, 3, 29, 6, 38, 10, 215, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a880e281-f1cf-4b8c-a1f2-21ff493066f7"), null, "Id et minima ipsa consectetur autem.", "137eb0ff-75b5-4724-97b9-911aab8f808c", new DateTime(2020, 8, 24, 21, 44, 17, 668, DateTimeKind.Local).AddTicks(2711), "Bank account: qui", new DateTime(2021, 3, 25, 13, 41, 48, 498, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a8aab7d8-8408-42c4-a309-91f9ac12bbaa"), null, "Fuga maiores aperiam et.", "c537a19f-ed50-4b22-a0ec-75f547cef054", new DateTime(2020, 7, 20, 8, 59, 19, 445, DateTimeKind.Local).AddTicks(2471), "Bank account: officia", new DateTime(2020, 11, 16, 7, 12, 29, 317, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a942033f-d56f-4c12-98cb-2d11b3598c8f"), null, "Sunt sed deserunt quia laborum quia qui quo ut molestias.", "0ac98641-00c7-4c18-97ef-d4b0859f77cf", new DateTime(2022, 3, 9, 5, 2, 27, 729, DateTimeKind.Local).AddTicks(4620), "Bank account: quia", new DateTime(2022, 6, 26, 13, 1, 19, 290, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab849181-4c94-475a-a837-e187c652e67d"), null, "Consequatur quibusdam dolor mollitia ipsam officia.", "e4d9757c-084a-4882-9491-b688c42e86d7", new DateTime(2020, 3, 22, 12, 17, 1, 568, DateTimeKind.Local).AddTicks(1124), "Bank account: repudiandae", new DateTime(2022, 4, 10, 8, 13, 50, 642, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad66a06f-40d1-4991-930d-bef8cf964bbf"), null, "Iure beatae ut consectetur nihil porro provident praesentium.", "f90850e3-3d66-4b39-b6eb-2277026ccd39", new DateTime(2022, 6, 8, 11, 58, 3, 355, DateTimeKind.Local).AddTicks(3664), "Bank account: a", new DateTime(2022, 6, 16, 0, 32, 14, 361, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b0e9da76-05b8-4740-b347-b3215dc98b42"), null, "Consequuntur enim minima voluptas.", "a59a88e9-fcad-41a8-8b1b-f6c173619a41", new DateTime(2022, 5, 16, 20, 50, 11, 315, DateTimeKind.Local).AddTicks(3915), "Bank account: animi", new DateTime(2022, 6, 17, 12, 40, 55, 118, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b28d1ae8-1095-4d8e-9e9b-9ec625685e06"), null, "Minus suscipit architecto.", "905a9c1a-f427-4de0-806a-f134119b845d", new DateTime(2019, 4, 24, 14, 22, 52, 538, DateTimeKind.Local).AddTicks(1340), "Bank account: ut", new DateTime(2021, 5, 13, 2, 53, 2, 394, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b4fbcad0-1db8-49a8-bac1-eec362ef0164"), null, "Dolores in labore enim praesentium pariatur cupiditate sit eaque veniam.", "d16491e1-2f73-4842-ba69-4bb5946d2f1d", new DateTime(2021, 5, 27, 2, 41, 32, 521, DateTimeKind.Local).AddTicks(3121), "Bank account: totam", new DateTime(2021, 12, 5, 11, 54, 32, 898, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b75410ce-babe-4d0a-9b08-f50ff223c41f"), null, "Porro et impedit.", "71af1628-8d4d-498e-8a70-852a2b92d045", new DateTime(2017, 10, 29, 8, 38, 27, 836, DateTimeKind.Local).AddTicks(7209), "Bank account: dolor", new DateTime(2018, 3, 10, 6, 43, 23, 502, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("baf924db-ab0b-4aa2-8e3b-aa0368302890"), null, "Adipisci voluptas ipsam enim.", "cb0d7d07-e248-41c8-82a6-46f2552a2a57", new DateTime(2020, 8, 5, 6, 51, 29, 267, DateTimeKind.Local).AddTicks(1565), "Bank account: quia", new DateTime(2022, 2, 27, 19, 50, 12, 437, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc475b23-e7aa-4d0f-b274-4a71aa2ee9fc"), null, "Iusto hic voluptas eaque quia esse.", "bfa2c417-390a-40e1-a15e-1d253ff85ded", new DateTime(2019, 11, 24, 22, 14, 29, 505, DateTimeKind.Local).AddTicks(7327), "Bank account: et", new DateTime(2021, 7, 25, 8, 12, 14, 3, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf6d192d-9099-408e-89e3-751696ec3a2f"), null, "Tempore atque exercitationem voluptatem voluptatem quasi earum.", "487d2750-23ab-430b-bd40-d23f31178664", new DateTime(2022, 6, 20, 1, 16, 54, 757, DateTimeKind.Local).AddTicks(7638), "Bank account: quis", new DateTime(2022, 6, 20, 16, 28, 50, 978, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bfb53f6e-6577-44c0-ac87-cc9d7a1fca9f"), null, "Rerum est quaerat tempora ab voluptate atque voluptatem nisi.", "e2e63c53-61a7-4b1c-ba27-44eb78a8a9e8", new DateTime(2018, 11, 12, 14, 39, 40, 552, DateTimeKind.Local).AddTicks(2726), "Bank account: dolore", new DateTime(2020, 11, 25, 1, 31, 34, 425, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1267550-ddd9-40bc-90d6-18f22ad84887"), null, "Laudantium distinctio pariatur sed consectetur quisquam et mollitia nemo.", "a784a1a4-d3b2-4c54-b884-ca36c0b341ed", new DateTime(2021, 7, 9, 10, 35, 32, 363, DateTimeKind.Local).AddTicks(264), "Bank account: consequuntur", new DateTime(2022, 3, 10, 2, 56, 31, 697, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2450815-e150-42a7-9215-969de9341c65"), null, "Unde commodi veritatis est dolorem voluptates nihil.", "d5506371-72f6-4b17-9a6e-8390400eccf6", new DateTime(2021, 11, 20, 14, 6, 27, 674, DateTimeKind.Local).AddTicks(6764), "Bank account: eum", new DateTime(2022, 6, 17, 19, 14, 55, 446, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c48b527f-4e3b-4662-8ba4-2435925f52f0"), null, "Asperiores iusto et veritatis.", "f977ff86-dc78-4555-bf3c-020ada9b41cd", new DateTime(2019, 10, 30, 0, 17, 45, 792, DateTimeKind.Local).AddTicks(5050), "Bank account: velit", new DateTime(2020, 2, 12, 13, 13, 59, 470, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c664797d-55d5-4a82-97d5-904f8aa82b75"), null, "Nihil magni deserunt placeat unde adipisci ullam.", "1814b31b-0aa1-4796-9908-5d3b12f6e7df", new DateTime(2017, 10, 18, 9, 57, 53, 344, DateTimeKind.Local).AddTicks(8676), "Bank account: officiis", new DateTime(2018, 7, 17, 5, 58, 9, 479, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c6faf6a6-e21c-418d-8583-5c97e86e6f1a"), null, "Architecto recusandae veritatis repudiandae ut atque enim labore.", "0e4cfaa8-42f3-4f9b-97dc-ac826296c3c9", new DateTime(2018, 12, 10, 15, 20, 3, 991, DateTimeKind.Local).AddTicks(1537), "Bank account: expedita", new DateTime(2019, 7, 22, 14, 46, 24, 740, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c81d6727-1914-418d-a5c6-2c888d88b489"), null, "Dolor ab non consectetur itaque.", "f1bfc979-d5d5-4a41-abdb-a0b45878e139", new DateTime(2019, 5, 21, 0, 59, 55, 121, DateTimeKind.Local).AddTicks(5279), "Bank account: nobis", new DateTime(2020, 3, 25, 0, 42, 26, 749, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8540a46-c0a7-4445-ac65-d1598fc7cd1b"), null, "Ut quia voluptates est inventore laborum eos ducimus.", "ec59a17b-7f14-4bbc-836c-d278ac33c824", new DateTime(2021, 2, 18, 18, 0, 56, 533, DateTimeKind.Local).AddTicks(9732), "Bank account: officiis", new DateTime(2022, 7, 1, 3, 3, 46, 734, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8c0ae98-c5b9-46d2-ae12-aca01fb8f68e"), null, "Reiciendis neque voluptatem et voluptatem.", "79363349-9b8e-42cb-ad8e-fae90af4bd41", new DateTime(2018, 4, 12, 1, 2, 47, 30, DateTimeKind.Local).AddTicks(5630), "Bank account: et", new DateTime(2018, 7, 15, 20, 58, 50, 45, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cb5bb7c3-cfc2-47e7-a536-624ee0f89f63"), null, "Porro optio sint repudiandae et distinctio deserunt.", "ee9a01ab-d18e-4cf7-9c2c-4a2aeebc2a2f", new DateTime(2021, 12, 4, 16, 21, 35, 421, DateTimeKind.Local).AddTicks(6261), "Bank account: libero", new DateTime(2021, 12, 18, 13, 13, 29, 274, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd3eee93-8dff-490c-aa8a-2283dec73687"), null, "Aut nobis expedita animi voluptatibus.", "e3888a94-608e-41b6-ad24-54534cbeaf44", new DateTime(2019, 5, 13, 1, 43, 26, 562, DateTimeKind.Local).AddTicks(7854), "Bank account: aut", new DateTime(2021, 4, 5, 11, 39, 32, 82, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1b99ddb-6baa-421e-97e9-e2f129b8148d"), null, "Porro dolorem non.", "130e8333-3345-465f-806b-7595e21ac36d", new DateTime(2017, 8, 22, 15, 6, 26, 969, DateTimeKind.Local).AddTicks(364), "Bank account: officiis", new DateTime(2019, 9, 29, 18, 37, 44, 694, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d277412c-f416-4dd0-90e2-8972870b112f"), null, "Accusantium voluptatum beatae aut molestias et rerum quae.", "7d9f29ee-1d2b-4d57-88ed-5733efc53f40", new DateTime(2020, 7, 1, 13, 9, 27, 860, DateTimeKind.Local).AddTicks(893), "Bank account: et", new DateTime(2020, 8, 27, 8, 55, 31, 871, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d28d5e59-d595-436d-9d66-1b3f6f14e65f"), null, "Aspernatur soluta corporis nemo voluptates reiciendis at veniam ab.", "31c9e82d-465a-46e7-b222-f1d0fe41b3ef", new DateTime(2020, 4, 6, 17, 55, 42, 399, DateTimeKind.Local).AddTicks(1823), "Bank account: minima", new DateTime(2020, 12, 12, 15, 55, 31, 942, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d37acd26-3853-4948-85cb-0718aa1d9a6e"), null, "Voluptates accusantium accusantium et error quam quo.", "671218c2-f3ed-4ccc-bbff-13b12fdbd569", new DateTime(2019, 9, 22, 4, 3, 48, 452, DateTimeKind.Local).AddTicks(6021), "Bank account: quod", new DateTime(2021, 7, 21, 1, 28, 30, 539, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d3968208-9971-4363-8282-48945ee70c96"), null, "Aspernatur est voluptas cupiditate est et suscipit.", "9a6cec1f-c75d-4a72-9527-dc953c99e702", new DateTime(2017, 8, 11, 6, 22, 38, 243, DateTimeKind.Local).AddTicks(5587), "Bank account: magnam", new DateTime(2018, 11, 13, 19, 40, 2, 894, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d84d29a2-030a-4b0d-9ee9-1115037fb20d"), null, "Numquam repellat qui inventore.", "77f230f1-1bbc-41f1-871b-72663c5ee2ed", new DateTime(2018, 6, 21, 23, 45, 36, 563, DateTimeKind.Local).AddTicks(2464), "Bank account: doloribus", new DateTime(2019, 8, 21, 15, 36, 16, 438, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d85abbd3-5688-4351-a4c0-6aa937b25adb"), null, "Consequatur voluptatem voluptas pariatur iure dolor velit eum provident minima.", "38596128-2639-43cf-a1ce-4efbf3abaae5", new DateTime(2019, 10, 29, 22, 54, 18, 383, DateTimeKind.Local).AddTicks(3571), "Bank account: qui", new DateTime(2020, 11, 7, 3, 58, 16, 898, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dbcc72bc-97e7-49da-b938-2fffc9008134"), null, "Qui reprehenderit vitae accusamus ut recusandae sapiente earum nihil.", "c83a03b9-c186-4db9-9ac9-9538e55054b0", new DateTime(2019, 12, 19, 4, 41, 20, 778, DateTimeKind.Local).AddTicks(9684), "Bank account: magnam", new DateTime(2021, 4, 28, 21, 57, 33, 335, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dd0e0281-17b8-4272-9975-af16cc5f721f"), null, "Quae consectetur ut laboriosam qui omnis magni.", "d605cf1c-9809-4a8c-a5ff-e8850738b129", new DateTime(2021, 12, 27, 0, 10, 55, 603, DateTimeKind.Local).AddTicks(4618), "Bank account: incidunt", new DateTime(2022, 3, 3, 6, 33, 14, 415, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e05ac238-ae09-4d20-b7c5-35a9ebdc8515"), null, "Recusandae molestiae dolores quia fugiat est.", "7900b6e6-c913-4e54-bb59-d7476ef9ed38", new DateTime(2019, 3, 28, 4, 44, 30, 859, DateTimeKind.Local).AddTicks(9483), "Bank account: quis", new DateTime(2021, 5, 27, 16, 9, 45, 577, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e273b405-aec7-4595-9d1a-af18e7a806fa"), null, "Minima et fugiat est occaecati.", "a398d505-5ea5-48a7-ad25-0c6f87335591", new DateTime(2022, 6, 29, 11, 0, 53, 21, DateTimeKind.Local).AddTicks(5592), "Bank account: ipsam", new DateTime(2022, 7, 3, 10, 56, 8, 14, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2f59413-9205-4d53-8e6f-7e151dca051c"), null, "Optio asperiores quos est voluptatibus.", "fb0d2d63-6464-4187-8f79-b88daa264fd5", new DateTime(2018, 3, 27, 22, 6, 34, 839, DateTimeKind.Local).AddTicks(6177), "Bank account: minus", new DateTime(2019, 4, 15, 22, 41, 34, 867, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7088452-84c4-4615-a79d-1d09aabf0762"), null, "Ex libero nihil totam ab officiis ea est vero in.", "a1ff6f42-a261-40d9-bad8-00c4ad2fc5e8", new DateTime(2021, 6, 7, 21, 27, 58, 381, DateTimeKind.Local).AddTicks(5609), "Bank account: numquam", new DateTime(2021, 12, 10, 13, 15, 55, 157, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e768100b-7fd2-468d-9108-6d0097ddfc2f"), null, "Rem dolores reiciendis.", "d95224db-64cc-4bf7-8e75-24b2d2a53be2", new DateTime(2022, 5, 31, 12, 6, 35, 773, DateTimeKind.Local).AddTicks(72), "Bank account: quasi", new DateTime(2022, 6, 21, 11, 47, 49, 383, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e996cc2c-3c55-4993-8601-6db77d548dba"), null, "Consectetur temporibus fuga officiis omnis.", "d23cfb70-1a07-4250-a98e-94b6bd69eca2", new DateTime(2019, 6, 2, 6, 33, 39, 369, DateTimeKind.Local).AddTicks(9474), "Bank account: aut", new DateTime(2022, 1, 12, 12, 56, 48, 242, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ead39c67-380a-4259-82fe-900aa2c2b48d"), null, "Placeat omnis suscipit illo voluptas et aut.", "b4b6d99e-c338-4c02-b1b8-a77261c779e9", new DateTime(2022, 3, 25, 12, 17, 28, 763, DateTimeKind.Local).AddTicks(7608), "Bank account: sit", new DateTime(2022, 6, 19, 13, 55, 45, 7, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3da64eb-05ab-4dd9-b0c6-880b9b194c12"), null, "Unde consequuntur nihil quia aliquam delectus eos dolorem non est.", "ad3b4c58-ff7d-4e76-9329-f38c1529c7b0", new DateTime(2019, 3, 12, 4, 9, 16, 475, DateTimeKind.Local).AddTicks(4883), "Bank account: voluptas", new DateTime(2019, 4, 3, 11, 33, 41, 139, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f893a51b-ba69-4fc5-91b6-725f74b40d30"), null, "Eaque omnis aut quia a.", "d00b8759-efa4-4aec-b879-6cf392a33f73", new DateTime(2017, 8, 11, 21, 3, 45, 273, DateTimeKind.Local).AddTicks(3855), "Bank account: libero", new DateTime(2022, 6, 7, 11, 57, 25, 648, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe58631d-8ff8-4785-9e87-ca4d3f35c784"), null, "Et aut laudantium sint consequuntur nam.", "7bdb0fb8-f1a2-4756-8897-175b6b64778d", new DateTime(2021, 1, 26, 14, 44, 19, 665, DateTimeKind.Local).AddTicks(1745), "Bank account: possimus", new DateTime(2022, 4, 24, 18, 42, 26, 473, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("00bd09a4-e164-4a8d-8c34-1de0572451c1"), "Itaque optio beatae explicabo libero.", "5a10985f-97e8-47cd-b0fd-9225c6966de9", new DateTime(2018, 8, 23, 11, 34, 51, 346, DateTimeKind.Local).AddTicks(1277), "Bank Shields - Kub", new DateTime(2019, 1, 25, 7, 6, 6, 814, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05f27a93-7e07-4d56-9f6f-54b5deee0267"), "Voluptatibus delectus et aliquam error suscipit quasi molestias.", "65de5604-5e3c-4a37-a3b2-d39225b6aee7", new DateTime(2021, 2, 19, 5, 22, 13, 151, DateTimeKind.Local).AddTicks(7847), "Bank Hackett LLC", new DateTime(2021, 6, 27, 9, 27, 55, 506, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0678b91b-69ad-4de0-86d5-ade2439a9c45"), "Architecto hic iure.", "935996a7-fdaf-4553-a5d1-1852c9007d15", new DateTime(2018, 10, 14, 0, 45, 59, 792, DateTimeKind.Local).AddTicks(8661), "Bank Doyle - Adams", new DateTime(2021, 3, 31, 19, 44, 0, 784, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07d53a22-75d9-46de-804d-cd3677d9bcc5"), "Dolore aspernatur eum.", "0b6e002e-4c37-4205-8796-2553c293a9e5", new DateTime(2019, 9, 14, 19, 6, 47, 945, DateTimeKind.Local).AddTicks(1998), "Bank Gutkowski and Sons", new DateTime(2021, 9, 8, 1, 42, 59, 581, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a9a0a33-7acc-4ec6-be1c-6284b499004e"), "Dolor dolorum ut et mollitia aspernatur et quia commodi itaque.", "bd69f454-11f3-4511-877e-3c4ab62a108f", new DateTime(2020, 8, 17, 2, 46, 12, 208, DateTimeKind.Local).AddTicks(4075), "Bank Quitzon Inc", new DateTime(2022, 5, 24, 20, 0, 55, 245, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("115a3bbb-2cd2-4cf6-a7dd-ed36fdeaa806"), "Facere omnis sit autem et.", "fa26834a-8db2-40b6-91b4-2a248db40410", new DateTime(2019, 6, 6, 1, 49, 50, 154, DateTimeKind.Local).AddTicks(9850), "Bank O'Reilly Group", new DateTime(2020, 11, 21, 10, 0, 39, 275, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15a0489f-88ac-401d-96b0-2d9de5909517"), "Possimus et voluptas facilis omnis ducimus quod esse voluptatibus aut.", "9cca419f-25da-4199-b8f6-cc0e73299978", new DateTime(2019, 4, 10, 16, 26, 11, 929, DateTimeKind.Local).AddTicks(7961), "Bank Leffler LLC", new DateTime(2021, 8, 17, 5, 40, 4, 590, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("170e2cbd-a45d-4fae-984c-98b7cfd31aa4"), "Deserunt provident occaecati eum quas sunt.", "18ce0bfa-bf76-4225-bf1a-b5461b119c6a", new DateTime(2020, 5, 10, 0, 6, 11, 747, DateTimeKind.Local).AddTicks(8246), "Bank Graham, Pfannerstill and Baumbach", new DateTime(2020, 8, 15, 3, 7, 12, 353, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1a007b53-4663-4f6b-b0bd-e5722d6cfe1d"), "Aut architecto inventore quidem voluptate fugiat praesentium officiis.", "2faeecdb-2b23-40c3-9302-40bc1dfd60dc", new DateTime(2020, 5, 30, 14, 4, 10, 190, DateTimeKind.Local).AddTicks(8598), "Bank Zulauf Inc", new DateTime(2020, 6, 4, 12, 55, 49, 562, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1bb7c45e-522f-4e66-996c-40eb3cdca223"), "Quaerat accusantium omnis laboriosam accusamus modi tempora.", "7a69cc18-993c-4628-8571-f086876db888", new DateTime(2019, 7, 10, 1, 22, 17, 743, DateTimeKind.Local).AddTicks(5243), "Bank Welch - Ankunding", new DateTime(2021, 9, 15, 10, 33, 3, 573, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23518b1f-30f7-4326-885e-588ce241023b"), "Laudantium quia nobis distinctio omnis modi et distinctio alias rerum.", "d577465c-b830-43e4-8fbb-1bb30b72ad5a", new DateTime(2022, 2, 3, 13, 20, 43, 222, DateTimeKind.Local).AddTicks(6943), "Bank Graham Group", new DateTime(2022, 5, 25, 23, 4, 9, 840, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("25510da3-dfcc-4b2b-8d91-8b5a332b952b"), "Corrupti suscipit et.", "3d8fdca9-e372-4280-af22-a3231c77c7e3", new DateTime(2018, 8, 4, 3, 24, 11, 392, DateTimeKind.Local).AddTicks(6540), "Bank Larson, Hamill and Rice", new DateTime(2020, 2, 2, 20, 54, 10, 427, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("27b0cf34-c6af-4d03-abd9-93e0e65420d1"), "Explicabo corporis ut cupiditate officiis nulla voluptatibus.", "d476ee2e-951b-44d7-bb5d-df3c86d02d58", new DateTime(2021, 5, 18, 9, 32, 33, 545, DateTimeKind.Local).AddTicks(6024), "Bank Bogan, Bashirian and Fay", new DateTime(2022, 3, 11, 2, 43, 4, 444, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32212cbc-2cfd-43cf-977d-7fed2be055d7"), "Et placeat recusandae.", "84e0d06a-7127-40c6-b8b6-4e5ca2ece2f5", new DateTime(2022, 6, 2, 21, 15, 37, 62, DateTimeKind.Local).AddTicks(4358), "Bank Weimann - Wiegand", new DateTime(2022, 6, 17, 7, 33, 21, 455, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32f21fc7-6592-4b51-a9e6-9a7de6ea5b99"), "Voluptate et unde et.", "13eaab87-5541-4c79-9b14-cb81d9c605cc", new DateTime(2021, 9, 30, 21, 36, 29, 38, DateTimeKind.Local).AddTicks(1856), "Bank Ferry Group", new DateTime(2022, 4, 20, 2, 57, 59, 549, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3477e3c9-6651-4c04-8280-af5a5be8f49c"), "Accusamus quaerat quo quasi necessitatibus quo.", "b6f5dca9-3f8b-4f69-94c5-b32bd09dc7bd", new DateTime(2021, 6, 8, 7, 28, 14, 203, DateTimeKind.Local).AddTicks(2196), "Bank Kozey Inc", new DateTime(2022, 2, 2, 16, 39, 27, 250, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("359878c3-0263-4e56-8fe4-807e2498dc80"), "Provident ipsa vero totam est dolore voluptates.", "0dd39ef9-aea6-47a1-9e7a-75ff096bb297", new DateTime(2017, 9, 20, 6, 57, 58, 607, DateTimeKind.Local).AddTicks(6480), "Bank Treutel, Zulauf and Dare", new DateTime(2018, 11, 15, 10, 41, 42, 553, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("37abd1b0-c309-4fb3-a82d-0ae753443315"), "Molestias et qui.", "0da35e48-2117-4857-9754-3557c471228e", new DateTime(2020, 12, 5, 11, 29, 17, 45, DateTimeKind.Local).AddTicks(5380), "Bank Halvorson - Runolfsdottir", new DateTime(2022, 3, 15, 8, 54, 2, 541, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f170d69-4378-4e07-bb15-7035c9f7f954"), "Numquam sit ut voluptate quas ratione perferendis qui omnis.", "0b4ae0b5-c0f1-4b30-80ce-8d2f476b040d", new DateTime(2019, 11, 9, 22, 22, 14, 118, DateTimeKind.Local).AddTicks(7759), "Bank Rippin - Goldner", new DateTime(2020, 5, 30, 13, 36, 50, 623, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42d95fe1-7f93-4c28-9bae-18ea1ed3bdb9"), "Sint minus et.", "5e56bfd6-6693-43e2-b1fc-9be9e7e2acee", new DateTime(2020, 8, 15, 10, 11, 50, 388, DateTimeKind.Local).AddTicks(4915), "Bank Bins - Sanford", new DateTime(2021, 12, 1, 8, 36, 49, 739, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("446b80dd-30a8-4007-9d80-a975a7ca3cb3"), "Repudiandae quia beatae et itaque.", "fbbc159a-11c9-46d0-818f-46dedaa75cfe", new DateTime(2021, 7, 24, 5, 43, 6, 216, DateTimeKind.Local).AddTicks(8262), "Bank Brekke Inc", new DateTime(2022, 6, 16, 2, 28, 45, 392, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4529c713-48e3-4587-9753-49d6a31ea673"), "Maxime dolorem odio nam.", "108af54e-7947-4096-aeb9-d233a9db5a69", new DateTime(2017, 8, 12, 15, 43, 37, 303, DateTimeKind.Local).AddTicks(7724), "Bank Schaden - Price", new DateTime(2019, 7, 26, 8, 57, 11, 630, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49df5195-80d3-4a41-a4f3-d3566aa04302"), "Cupiditate explicabo vero.", "b0b85b4d-e00b-484c-8072-36e181df4f5d", new DateTime(2019, 7, 15, 6, 44, 58, 158, DateTimeKind.Local).AddTicks(9175), "Bank Hayes - Barton", new DateTime(2022, 4, 6, 21, 52, 53, 379, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c1045ce-b9c4-4ed4-bb35-022ac1489b4f"), "Dolore autem similique ut neque veniam unde.", "be10f463-c1d4-435e-8f74-e4cc8981c446", new DateTime(2019, 9, 8, 15, 39, 40, 312, DateTimeKind.Local).AddTicks(9398), "Bank Stanton and Sons", new DateTime(2021, 6, 27, 13, 13, 11, 200, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4fc7c147-412a-42c4-a3d8-aa839f951f9a"), "Magni ipsum nihil facilis ipsam officiis quos.", "26bdf47e-fa4a-4ac6-8294-06ec97f3a498", new DateTime(2020, 9, 14, 6, 22, 40, 582, DateTimeKind.Local).AddTicks(8642), "Bank Gottlieb Group", new DateTime(2021, 8, 22, 13, 8, 39, 386, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54b41fea-a5b4-4b24-9210-a555a394e6fe"), "Dolor ratione rerum rerum quia cupiditate quos sequi beatae sed.", "7ea8599f-cc48-454f-a271-8b4d562c0aad", new DateTime(2022, 4, 20, 10, 43, 54, 743, DateTimeKind.Local).AddTicks(5554), "Bank Stokes - Rohan", new DateTime(2022, 6, 19, 12, 18, 47, 321, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54c398c9-9b1b-46ac-86a9-65b2006b82ae"), "Atque nulla sint.", "eda293e4-5f77-45e1-b8c3-8dce1a544e3d", new DateTime(2022, 1, 20, 11, 38, 50, 471, DateTimeKind.Local).AddTicks(6665), "Bank McCullough - Schiller", new DateTime(2022, 3, 2, 22, 55, 57, 64, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5893d2a2-50f5-4b40-9b5e-5252f449ac56"), "Facere magnam enim necessitatibus.", "0cf329da-51bd-4860-89b5-ce77be3dd2e2", new DateTime(2020, 11, 20, 19, 58, 0, 809, DateTimeKind.Local).AddTicks(3335), "Bank Little - Veum", new DateTime(2021, 10, 28, 5, 15, 45, 186, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("592e75a8-7088-4ece-8caf-d64f73454451"), "Dolore asperiores impedit qui nesciunt voluptatem perferendis architecto commodi ab.", "33ce1510-4850-4c1a-9c82-c8605c38bcd4", new DateTime(2018, 4, 10, 14, 57, 46, 589, DateTimeKind.Local).AddTicks(8921), "Bank Bradtke, Roob and Wunsch", new DateTime(2019, 6, 19, 21, 52, 26, 266, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c5b2405-a10a-4d9a-afb4-3ae9c5ad3891"), "Eum rerum nesciunt ut esse at est perferendis.", "91c199dc-a68f-453f-8bc6-eac692218631", new DateTime(2019, 8, 20, 8, 16, 59, 870, DateTimeKind.Local).AddTicks(3299), "Bank Emmerich - Stokes", new DateTime(2020, 12, 19, 21, 23, 51, 878, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d1aa352-d970-4713-8e6d-608d293344d9"), "Cum qui odit occaecati eaque tempore harum dicta blanditiis.", "51308724-e3ba-4536-b3c5-19b0d89abfa3", new DateTime(2022, 7, 4, 19, 44, 59, 712, DateTimeKind.Local).AddTicks(9139), "Bank Langworth - Hickle", new DateTime(2022, 7, 4, 21, 36, 21, 375, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69c38e26-16bb-4ca0-87fe-3de2367b7247"), "Vero inventore asperiores eius.", "93e7f481-aa17-46eb-805a-d36b9fab26de", new DateTime(2019, 2, 17, 23, 26, 21, 113, DateTimeKind.Local).AddTicks(2494), "Bank Rau - Carroll", new DateTime(2020, 1, 2, 23, 23, 39, 861, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a14bdfb-8b10-40c5-a4be-7ce56e68355c"), "Error perferendis nemo voluptas accusamus amet qui minus.", "38ab1876-767a-4f0b-b3b8-a7be11ded0a6", new DateTime(2018, 1, 19, 10, 58, 37, 261, DateTimeKind.Local).AddTicks(7916), "Bank Hilpert Inc", new DateTime(2022, 1, 5, 16, 41, 22, 594, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6dacff8c-8929-44d9-9d5e-b400d886d2c0"), "Recusandae ut aut velit quo quisquam reiciendis est.", "c94c9951-07a9-4a63-8ce8-860827be4b67", new DateTime(2022, 1, 1, 15, 39, 4, 313, DateTimeKind.Local).AddTicks(2527), "Bank Bradtke, Dooley and Murazik", new DateTime(2022, 1, 10, 4, 3, 0, 453, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e5c130b-94e5-47b3-8e65-e5589762214c"), "Labore doloribus incidunt.", "076f755e-ddc5-48e1-85a6-76602cbffa41", new DateTime(2020, 10, 11, 0, 41, 51, 173, DateTimeKind.Local).AddTicks(6842), "Bank Kulas - Krajcik", new DateTime(2021, 10, 4, 3, 9, 52, 570, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("713d6f6c-8aa0-4389-b325-29674a3528ab"), "Ea voluptas odit non qui excepturi.", "a470e63a-15e2-4ac4-82b8-7fe5807ff283", new DateTime(2020, 9, 13, 12, 32, 40, 780, DateTimeKind.Local).AddTicks(6357), "Bank Mueller, Bashirian and Flatley", new DateTime(2021, 5, 13, 19, 38, 43, 345, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("714b8c6c-ade5-44ae-8bb6-548b7acf479c"), "Est rerum ullam quia rerum rerum.", "9be01471-c742-4693-8c0d-3720a2aabccc", new DateTime(2021, 11, 8, 15, 41, 35, 828, DateTimeKind.Local).AddTicks(5825), "Bank Blick, Abernathy and Runolfsdottir", new DateTime(2022, 5, 3, 12, 14, 54, 152, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73a0d091-8a3e-4d86-8c64-62e9f169771f"), "Aliquid corporis corrupti quo tenetur dolor omnis quos.", "915f2df5-608a-4de4-bf4a-3aa2c52f7866", new DateTime(2020, 2, 28, 9, 0, 34, 947, DateTimeKind.Local).AddTicks(9307), "Bank Keeling - Kuvalis", new DateTime(2021, 9, 16, 0, 38, 11, 592, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73ad72ee-dccb-4f98-a7f1-55543604bd7f"), "Nobis illo ducimus vel.", "772c5e43-0861-420c-95b6-d1d721728de5", new DateTime(2019, 9, 17, 12, 28, 54, 674, DateTimeKind.Local).AddTicks(1802), "Bank Hilll Group", new DateTime(2019, 9, 19, 5, 54, 38, 943, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75e92101-505a-4396-9431-c92c0a5cf3f1"), "Voluptatem quasi non qui inventore aliquid doloremque qui maxime et.", "297a7c51-044d-4f71-bd41-42f175d31fde", new DateTime(2021, 12, 17, 18, 39, 23, 48, DateTimeKind.Local).AddTicks(7400), "Bank Connelly Inc", new DateTime(2022, 2, 8, 23, 9, 16, 771, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("76b26ae0-7ac4-45ed-8810-aeae47481232"), "Debitis et dignissimos dolor dolores corporis harum sed doloremque.", "b555e283-7ef4-43b6-b3ac-4bef104e9991", new DateTime(2020, 2, 4, 15, 28, 6, 675, DateTimeKind.Local).AddTicks(1480), "Bank Schaden, Feest and Pouros", new DateTime(2021, 6, 30, 6, 44, 52, 93, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b6a13d3-2572-47ad-9c0e-e0faa314c7fb"), "Harum officiis qui omnis ut doloribus error.", "f079ab25-44db-4f9a-b662-725fd4bce556", new DateTime(2021, 3, 27, 23, 6, 9, 973, DateTimeKind.Local).AddTicks(7608), "Bank Bechtelar LLC", new DateTime(2021, 5, 17, 3, 26, 10, 296, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c018be3-be70-49dd-a066-eac37b2628a3"), "Consequatur maxime facere sint modi debitis enim.", "caa2fb87-7643-4f61-ab2c-059f0e132e76", new DateTime(2019, 12, 30, 18, 42, 48, 466, DateTimeKind.Local).AddTicks(4088), "Bank Wyman, Harvey and Pagac", new DateTime(2022, 5, 25, 0, 58, 38, 26, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c55e303-e33e-4170-9583-215b4573a0dd"), "Culpa rerum quis ipsam et ad.", "0cc4d64a-a183-45d3-9b0f-d3ad7c0c461c", new DateTime(2022, 2, 24, 15, 38, 23, 407, DateTimeKind.Local).AddTicks(5341), "Bank Bradtke - Zulauf", new DateTime(2022, 4, 18, 19, 0, 58, 289, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7cb6bd53-413f-42e8-ac3d-52cea2863af5"), "Veniam sed earum aut quae consectetur.", "2ff5d112-73cc-4036-ba77-eee5079fa840", new DateTime(2021, 1, 2, 15, 42, 13, 37, DateTimeKind.Local).AddTicks(2768), "Bank Bednar Inc", new DateTime(2021, 1, 5, 9, 24, 39, 54, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("80eaa782-5b75-4a7b-a383-57842377b399"), "Dolorem voluptatem fuga nulla temporibus deserunt neque.", "698868f0-f05b-4fae-b834-3e19dc544d90", new DateTime(2018, 10, 30, 21, 51, 5, 939, DateTimeKind.Local).AddTicks(881), "Bank Keebler Group", new DateTime(2021, 7, 14, 15, 43, 18, 581, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("82cb4be8-6181-408c-8f04-54cf8029b31f"), "Consequatur voluptatum possimus consequatur porro eum necessitatibus sequi.", "874024bc-7516-484c-97f6-c0d386223cb7", new DateTime(2017, 11, 11, 14, 49, 50, 377, DateTimeKind.Local).AddTicks(4266), "Bank Lemke, Nienow and Carter", new DateTime(2019, 5, 28, 20, 18, 49, 301, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("851fb04f-4537-41c4-ad41-a121be3c68ce"), "Repellendus qui minima.", "4d973075-59a8-42ac-853a-1a0a8cba24b7", new DateTime(2020, 6, 17, 18, 8, 8, 147, DateTimeKind.Local).AddTicks(2232), "Bank Blick LLC", new DateTime(2021, 1, 10, 22, 33, 16, 63, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91765199-eac6-4071-95f3-dd440d89b8e5"), "Ut debitis et voluptate.", "49374447-5b0c-46e5-ab1b-68e68aadd0d9", new DateTime(2018, 7, 14, 3, 9, 17, 185, DateTimeKind.Local).AddTicks(7755), "Bank Swaniawski, Green and Effertz", new DateTime(2020, 12, 21, 23, 36, 26, 340, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("93ec7842-aa17-481e-856e-b7ee14745545"), "Blanditiis esse sit.", "082dd480-691a-4def-afde-550e09e97da0", new DateTime(2022, 1, 30, 3, 21, 53, 753, DateTimeKind.Local).AddTicks(9983), "Bank Heathcote, Hudson and Herzog", new DateTime(2022, 3, 27, 3, 49, 38, 292, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("96f3cedf-f53b-41af-a7a1-11a7dab54589"), "Exercitationem inventore voluptate suscipit architecto porro sint eius.", "0bc80a35-5a5b-4d4b-9d0d-996da7b7b3a6", new DateTime(2017, 12, 21, 15, 12, 58, 488, DateTimeKind.Local).AddTicks(8742), "Bank Leuschke, Reynolds and Ward", new DateTime(2021, 12, 12, 19, 44, 1, 851, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("982876fb-9fac-40cd-9275-1a97d7fee381"), "Et architecto doloribus ipsum.", "a4917363-e6b5-4198-925c-4f763b85cb26", new DateTime(2020, 7, 2, 5, 24, 55, 276, DateTimeKind.Local).AddTicks(6848), "Bank Gislason Inc", new DateTime(2021, 5, 21, 16, 15, 45, 511, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("98e98bc8-75c0-4446-95c2-5f14dbd2bca8"), "Aut quibusdam dolores magni maxime.", "99c2374f-d560-4db4-b7c8-d9e537a4959c", new DateTime(2022, 1, 15, 21, 38, 4, 964, DateTimeKind.Local).AddTicks(4158), "Bank Heathcote Group", new DateTime(2022, 2, 3, 22, 5, 17, 19, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99c893ec-a5b8-4259-95b0-2a0c17da345e"), "Aut vitae eos voluptatum ipsa cum quaerat.", "84f50a2d-13c9-4839-b238-54cbaf6388e5", new DateTime(2018, 3, 28, 17, 37, 39, 157, DateTimeKind.Local).AddTicks(6235), "Bank Mertz - Halvorson", new DateTime(2018, 7, 25, 18, 52, 24, 963, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f28f6a1-fe23-4c50-9038-7bcd202b2407"), "Voluptas provident et et omnis in nemo numquam aut.", "3b42781b-c12c-49eb-9187-21a40e057567", new DateTime(2018, 7, 7, 4, 15, 30, 323, DateTimeKind.Local).AddTicks(9863), "Bank Streich - Kunze", new DateTime(2019, 2, 13, 4, 7, 49, 669, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a063eb70-1646-43db-a028-d8b612221e2d"), "Qui aut dignissimos voluptates.", "9d2b749b-c00c-494b-929d-99288316245b", new DateTime(2020, 6, 28, 5, 15, 16, 812, DateTimeKind.Local).AddTicks(9611), "Bank Ziemann, Muller and D'Amore", new DateTime(2020, 9, 6, 3, 54, 49, 684, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a0e4b956-3baf-4aed-b21e-e5d513555215"), "Sit beatae quisquam laudantium saepe quidem aut consequuntur.", "5d3f9364-ce1e-4494-b0a5-25726e90d036", new DateTime(2019, 11, 20, 14, 7, 27, 357, DateTimeKind.Local).AddTicks(1586), "Bank Gerhold Group", new DateTime(2020, 4, 19, 0, 36, 31, 894, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a80b5b5c-b821-460e-b960-8f43b7c38bb1"), "Officiis at vero ut laborum voluptatibus nostrum.", "ad1034a0-1df0-428f-8e9f-2723c3ca6f63", new DateTime(2020, 9, 25, 22, 15, 19, 330, DateTimeKind.Local).AddTicks(9078), "Bank Padberg Inc", new DateTime(2021, 9, 6, 20, 24, 0, 235, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab0bcf5a-73e9-4263-b5a6-468f983b3315"), "Et cupiditate non laudantium.", "8e76e9e6-d6bf-4f05-b3e3-2eb535c6001d", new DateTime(2021, 9, 27, 1, 26, 43, 753, DateTimeKind.Local).AddTicks(5966), "Bank Ruecker and Sons", new DateTime(2022, 1, 27, 16, 3, 23, 442, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3893e65-0ed6-4f68-8ba6-031e6c9a1858"), "Ea quia quasi error non aut culpa dicta dolorem est.", "9d23d14f-d5c4-4805-8ff3-828bdc3dd7f1", new DateTime(2018, 6, 24, 17, 54, 21, 740, DateTimeKind.Local).AddTicks(3845), "Bank Graham, Ullrich and Hand", new DateTime(2020, 5, 9, 21, 34, 56, 963, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b5a9ebb8-600b-4db0-8c07-ad00b9d195d2"), "Incidunt neque sint saepe doloribus doloribus possimus numquam unde.", "9c9ab0de-b4ce-4ea2-9c0e-2c9f52ffafa3", new DateTime(2022, 3, 22, 1, 34, 45, 365, DateTimeKind.Local).AddTicks(2404), "Bank Bogisich - Auer", new DateTime(2022, 6, 28, 3, 24, 7, 215, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b7bf6eac-769e-4301-b352-c2c4b4229488"), "Accusamus molestiae voluptatibus reprehenderit.", "454215d8-7ec7-4c18-badb-b3d315dfc514", new DateTime(2017, 9, 17, 6, 41, 14, 568, DateTimeKind.Local).AddTicks(3), "Bank Vandervort, Dicki and Shanahan", new DateTime(2020, 11, 27, 11, 58, 48, 694, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9769006-f2ff-4895-bd9b-e42e5a613055"), "Quia nulla veniam voluptatem ut.", "cb507107-2f96-4d5a-a729-c5577bebcd1d", new DateTime(2020, 5, 30, 17, 11, 42, 699, DateTimeKind.Local).AddTicks(6729), "Bank Cummerata, Wisozk and Hickle", new DateTime(2021, 12, 24, 22, 27, 53, 761, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9a25d5d-ebe3-47f0-ae6d-e391c72c79d4"), "Labore quaerat facilis impedit doloremque voluptatem sunt sed.", "92523731-eb85-4dfb-a5b9-789520db656e", new DateTime(2019, 8, 13, 20, 3, 50, 787, DateTimeKind.Local).AddTicks(8310), "Bank Luettgen - Treutel", new DateTime(2021, 4, 30, 0, 9, 44, 8, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9aa49a3-ff01-45ad-b1d6-dec50aa8eea5"), "Quod facilis doloremque.", "6cd70e9e-09fa-4e44-af61-14715c34aa32", new DateTime(2020, 11, 6, 16, 23, 26, 376, DateTimeKind.Local).AddTicks(2510), "Bank Abbott, Conroy and Yundt", new DateTime(2021, 11, 21, 22, 51, 21, 934, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdbdc890-953b-4df3-8432-b8aafd068a02"), "Mollitia tenetur expedita et dolorem.", "49f42fa2-7a52-475c-a88a-8acf59704eaa", new DateTime(2018, 4, 20, 12, 8, 36, 431, DateTimeKind.Local).AddTicks(8418), "Bank Bednar Group", new DateTime(2020, 5, 18, 7, 57, 1, 666, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c02ae5b0-dafc-4fb6-ab32-53b4a64cef14"), "Asperiores ut hic iure voluptate velit corporis omnis.", "5955ad68-26e4-48ab-90ba-5a08d8828ab5", new DateTime(2017, 10, 29, 14, 29, 45, 98, DateTimeKind.Local).AddTicks(8837), "Bank Flatley, Hettinger and Cronin", new DateTime(2020, 4, 9, 20, 34, 1, 922, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c4288333-140c-47c5-a624-8f289f0c4e09"), "Ducimus autem ut fuga animi consequatur rerum.", "835c15fa-c6b4-4bc6-bec6-0ba0d8302361", new DateTime(2021, 11, 2, 10, 46, 52, 602, DateTimeKind.Local).AddTicks(1847), "Bank Connelly, Connelly and Dicki", new DateTime(2022, 4, 28, 17, 2, 54, 369, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c481df08-e45d-43cb-a23b-f341433ced83"), "Doloremque voluptatum aperiam ut sit hic at veniam adipisci sapiente.", "32a362fc-bc16-4997-a633-7466b873a466", new DateTime(2020, 8, 24, 7, 5, 29, 495, DateTimeKind.Local).AddTicks(4200), "Bank Ward, Mohr and Erdman", new DateTime(2020, 12, 2, 15, 40, 14, 445, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c735139d-d766-4a7f-8752-7b17d08a1779"), "Tempore ad iste est enim nihil explicabo assumenda qui.", "6f788199-3ee2-415b-82ea-ecdee416b8de", new DateTime(2018, 5, 12, 1, 8, 28, 649, DateTimeKind.Local).AddTicks(5573), "Bank Runte - Little", new DateTime(2022, 3, 13, 8, 1, 1, 484, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cab74e65-d4a3-4a80-9439-44b08d6730e1"), "Libero eligendi ullam inventore omnis non dolores labore repudiandae.", "b6846045-8747-48d5-93e9-ea5842a50fb4", new DateTime(2018, 11, 19, 2, 5, 8, 505, DateTimeKind.Local).AddTicks(2296), "Bank Gusikowski, Reilly and Mohr", new DateTime(2021, 12, 12, 7, 10, 17, 377, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cc6f9ca7-766e-4b7e-8d21-e6cc1520d4a6"), "Excepturi unde quam veritatis optio sit autem labore sed.", "a8431138-e326-43f5-bde7-4288ce4f71de", new DateTime(2022, 5, 31, 22, 50, 56, 291, DateTimeKind.Local).AddTicks(2109), "Bank Ledner - Sipes", new DateTime(2022, 6, 7, 7, 16, 55, 29, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cfd35231-1376-41ab-929a-ec24feefac1f"), "Sit dolorem laborum temporibus et fugit ex ut.", "e2a081ae-615c-4e57-9a09-5d18bd85f508", new DateTime(2022, 6, 29, 17, 35, 48, 84, DateTimeKind.Local).AddTicks(3054), "Bank Lind, Fritsch and Jaskolski", new DateTime(2022, 7, 2, 17, 33, 5, 834, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d01a27cd-8f3f-4b07-9a68-5338828e4ae2"), "Sequi praesentium ab repudiandae.", "d574f8e5-a28b-440e-8b2d-bba1185d3a55", new DateTime(2019, 6, 10, 10, 58, 32, 85, DateTimeKind.Local).AddTicks(9173), "Bank Lueilwitz - Feest", new DateTime(2020, 12, 11, 0, 4, 37, 369, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d3f921d4-df91-4d2f-9ff2-f87a75624936"), "Quas sed fuga officia accusantium laudantium consequatur suscipit sed.", "eaaf4429-66a1-4195-abc2-7bb0b2dd9909", new DateTime(2022, 4, 10, 11, 31, 26, 45, DateTimeKind.Local).AddTicks(3080), "Bank Herman - MacGyver", new DateTime(2022, 6, 4, 12, 9, 11, 954, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d401e541-e181-40f2-9dd7-70738ac7fa79"), "Cupiditate quia et dolor tempora ex et rerum.", "69baa430-c12b-4869-9028-66c3c5370119", new DateTime(2020, 5, 18, 11, 56, 7, 470, DateTimeKind.Local).AddTicks(4080), "Bank Koch - Kulas", new DateTime(2021, 12, 11, 23, 28, 31, 322, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d48b78fa-1a5e-41e5-8648-40e46fcdf1ce"), "Architecto eos aperiam nulla veniam qui commodi.", "24972b88-8c8b-4682-a586-e3c0a6c16155", new DateTime(2020, 1, 3, 18, 57, 14, 877, DateTimeKind.Local).AddTicks(6345), "Bank Will and Sons", new DateTime(2021, 11, 18, 11, 48, 25, 442, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d4f791b0-5eaf-4056-97f0-a804011e846f"), "Amet sed atque alias culpa impedit.", "8d61dd45-e359-4323-a435-f661e34e868e", new DateTime(2019, 5, 14, 16, 16, 33, 938, DateTimeKind.Local).AddTicks(9881), "Bank Kerluke, Schinner and Quigley", new DateTime(2020, 2, 6, 0, 34, 36, 11, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d56b720a-5527-4a09-9310-f6b8eec16c01"), "Iste aliquam omnis.", "e777fa14-1bd6-4a85-a2bb-94dd479aea8c", new DateTime(2022, 2, 11, 11, 49, 40, 546, DateTimeKind.Local).AddTicks(4657), "Bank Ward, Herman and Schuster", new DateTime(2022, 5, 28, 4, 33, 53, 34, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d5f26ae6-796a-4b58-82a1-a28a6b926d0b"), "Sapiente cumque non repellendus libero sed enim unde.", "bd1e7102-16a7-48a5-9750-ba3af2d14f6a", new DateTime(2021, 12, 2, 8, 23, 18, 359, DateTimeKind.Local).AddTicks(2321), "Bank Jerde LLC", new DateTime(2022, 4, 9, 4, 16, 30, 404, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da375a15-3def-443d-aecf-ea8b2d2f3946"), "Magnam commodi fugiat ad nihil saepe eligendi.", "0c7bc3c6-8967-4272-893b-8c44d317c882", new DateTime(2019, 6, 20, 3, 30, 59, 376, DateTimeKind.Local).AddTicks(7579), "Bank D'Amore, Hills and Dickens", new DateTime(2021, 1, 5, 23, 31, 23, 162, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dbb511b3-4c1a-4b8b-b951-1e168cfdac40"), "Reprehenderit sunt maiores ipsa voluptatum aspernatur impedit.", "37fc3e9f-6927-42bc-a3be-f0f161ce727d", new DateTime(2017, 8, 27, 7, 2, 4, 759, DateTimeKind.Local).AddTicks(8146), "Bank Abbott, Walker and Schoen", new DateTime(2019, 7, 8, 23, 27, 40, 319, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dc445165-cd30-4b59-94e1-a33e4857fe2b"), "Qui iste omnis inventore eos est ducimus enim natus ut.", "a7e6abca-825f-4fa0-b898-a1e83067925d", new DateTime(2020, 2, 5, 21, 7, 40, 500, DateTimeKind.Local).AddTicks(3222), "Bank Hagenes - Heaney", new DateTime(2020, 4, 15, 21, 14, 14, 960, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ddf8c597-0ef3-4978-8c79-49c9554d3a2e"), "Ipsam quisquam aut iure eos voluptatem.", "14eb2c58-49f0-484f-97b7-5eeb49c94452", new DateTime(2020, 3, 30, 2, 6, 42, 418, DateTimeKind.Local).AddTicks(1199), "Bank Keeling, Morar and Connelly", new DateTime(2020, 8, 14, 9, 14, 52, 55, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e08eb1ce-2fce-42bf-9ed1-af58cd36c0a7"), "Impedit et unde nulla quaerat quam rerum perspiciatis in.", "e1446cc6-6671-4bb3-9c32-c2cd047a8a81", new DateTime(2020, 2, 27, 5, 30, 15, 51, DateTimeKind.Local).AddTicks(7036), "Bank Crist - Waelchi", new DateTime(2021, 10, 15, 9, 41, 35, 139, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e249c067-30a2-440c-804b-c3c37ed7bec1"), "Libero eum suscipit esse nesciunt nobis natus.", "a91aadb6-ccf3-4d21-98bd-c787de45edd5", new DateTime(2018, 6, 4, 10, 38, 18, 265, DateTimeKind.Local).AddTicks(8198), "Bank Kozey Inc", new DateTime(2020, 2, 1, 12, 13, 25, 345, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2fe3c20-39a7-43cd-830f-7a21dc3454d3"), "Ipsa et animi molestiae et ipsum recusandae ipsa autem iure.", "5e440386-ea89-4199-8263-383fb12646a9", new DateTime(2018, 8, 7, 8, 8, 21, 252, DateTimeKind.Local).AddTicks(4085), "Bank Jacobson, Shields and Wilkinson", new DateTime(2020, 8, 19, 19, 32, 53, 549, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e78733ab-915f-41f5-929d-84fd34af1c3c"), "Ut laboriosam perspiciatis ut.", "ebcb7796-dae8-4cbf-84ea-193e3e2554ec", new DateTime(2021, 3, 24, 13, 17, 44, 671, DateTimeKind.Local).AddTicks(4253), "Bank Schaefer, Bednar and Spinka", new DateTime(2022, 7, 4, 9, 47, 21, 914, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7b526f9-dded-4cb2-8c89-0da077ba5561"), "Corporis similique eos harum quam illo ut qui.", "30440ba9-2a53-4bc4-a828-746836f4a4cb", new DateTime(2019, 12, 12, 6, 22, 4, 838, DateTimeKind.Local).AddTicks(4808), "Bank Towne, Adams and Miller", new DateTime(2022, 5, 31, 10, 9, 9, 640, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e949e1c0-c070-43f3-833c-eeeb2bd08009"), "Ut consequatur ea sit recusandae ipsam.", "163e845e-e4af-4911-81e1-71a7557c86a6", new DateTime(2020, 12, 26, 20, 19, 43, 813, DateTimeKind.Local).AddTicks(7236), "Bank Cummerata, Keeling and Streich", new DateTime(2022, 3, 31, 12, 39, 34, 366, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ebfa4790-adc1-42ee-a01e-7b7a34030b39"), "Voluptates unde et est repudiandae corrupti et possimus non.", "f9d0fd49-4858-47a4-888e-b52e94b49728", new DateTime(2019, 1, 12, 10, 44, 53, 499, DateTimeKind.Local).AddTicks(3638), "Bank Dickinson Group", new DateTime(2020, 2, 9, 18, 31, 50, 197, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec4866d7-a4ce-457b-b94b-5e450486a841"), "Vel quia aperiam.", "aa7e2496-405a-45c9-9ced-374544dcfb4c", new DateTime(2018, 10, 2, 14, 48, 29, 646, DateTimeKind.Local).AddTicks(4471), "Bank Howell, Hagenes and Schowalter", new DateTime(2020, 2, 20, 23, 5, 6, 596, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef6abf10-cf99-44c2-9316-02d7b350f59b"), "Est voluptates laudantium.", "d6c2579d-91d8-42c7-a79d-8e1681dbf112", new DateTime(2021, 8, 25, 18, 51, 16, 498, DateTimeKind.Local).AddTicks(7933), "Bank Koepp - Jacobson", new DateTime(2021, 11, 1, 20, 58, 23, 177, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3cf24a0-3c32-410f-a3c1-46e3c41a08bb"), "Rerum est odit velit aspernatur nostrum.", "05bb2472-f55d-4f61-9711-391265d6f6ed", new DateTime(2017, 9, 1, 22, 55, 41, 409, DateTimeKind.Local).AddTicks(4858), "Bank Murray - Haley", new DateTime(2018, 2, 9, 22, 35, 13, 843, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f4fa91e7-ff6e-4612-a784-a2d82ab2dcd6"), "Temporibus quia dolorem inventore et porro omnis et.", "643fe311-d850-4ff9-aa26-c15c6ee98099", new DateTime(2021, 12, 15, 22, 26, 36, 732, DateTimeKind.Local).AddTicks(102), "Bank O'Reilly - Grady", new DateTime(2022, 4, 3, 15, 56, 24, 436, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f860e62e-cdda-4cc1-826b-95665ec335d6"), "Autem laudantium enim et.", "b2176a79-ae5c-45c9-9ab9-42b52bdd4fec", new DateTime(2018, 8, 10, 6, 53, 50, 204, DateTimeKind.Local).AddTicks(7801), "Bank Carroll - Pacocha", new DateTime(2019, 11, 14, 3, 26, 52, 184, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f9581f3d-4ca7-44fa-8172-80b06ea349c5"), "Id rerum saepe et aliquam quidem voluptas et.", "edacea2e-7b04-46e7-bdb8-f33f3cda4877", new DateTime(2018, 12, 24, 8, 46, 23, 368, DateTimeKind.Local).AddTicks(5572), "Bank Kuhic Inc", new DateTime(2020, 9, 4, 20, 42, 39, 209, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc07847a-b1ce-4099-a5d1-b9e53a67cf3a"), "Rerum totam dolores in corrupti repudiandae vero sapiente.", "0b49c6b3-ee72-4752-98a7-26db82525a64", new DateTime(2021, 10, 2, 3, 12, 30, 35, DateTimeKind.Local).AddTicks(3321), "Bank Ritchie LLC", new DateTime(2022, 5, 3, 5, 34, 10, 85, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fdf0dc10-8f42-4de3-b938-a4d32c4d7f98"), "Iste voluptas dolores neque quaerat et.", "6c1222ca-bd2e-4be2-8736-d546a0b6ba64", new DateTime(2019, 3, 29, 3, 47, 31, 935, DateTimeKind.Local).AddTicks(26), "Bank Stark and Sons", new DateTime(2020, 9, 7, 5, 25, 6, 31, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe085536-9ef8-458f-8ed9-4813e315046e"), "Neque est voluptatem alias eaque amet et beatae ratione.", "32055ff0-2253-48fe-9b03-d8977281d8b7", new DateTime(2021, 9, 21, 4, 47, 48, 114, DateTimeKind.Local).AddTicks(6288), "Bank Hand - Jacobs", new DateTime(2022, 1, 14, 9, 35, 29, 831, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("018a4261-4297-432e-8bb5-33eaaaac6e31"), "Doloremque non voluptates incidunt est ipsa.", "66c6f9d0-00a5-4bb5-aa89-62aabd38bf79", new DateTime(2020, 1, 1, 7, 17, 23, 24, DateTimeKind.Local).AddTicks(2590), "Cash desk: similique", new DateTime(2020, 11, 19, 4, 16, 10, 323, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0948c8e6-6a17-4361-9c57-0a72aa674269"), "Odio dignissimos aut ut hic nobis vel.", "eafe4423-df67-4d1e-aa5b-38b9990bde28", new DateTime(2019, 4, 7, 14, 28, 29, 820, DateTimeKind.Local).AddTicks(5996), "Cash desk: nihil", new DateTime(2021, 10, 12, 8, 30, 6, 317, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("09d7d5fb-f8ee-4649-adb4-b1c19a7396e1"), "Ad ut doloribus.", "ca9cc57f-73b3-49a2-86c8-12145b6dbc49", new DateTime(2020, 5, 19, 11, 42, 50, 765, DateTimeKind.Local).AddTicks(814), "Cash desk: quia", new DateTime(2022, 2, 11, 11, 33, 0, 645, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ed372b7-75db-4952-9e0b-4ae14194c320"), "Non rerum id et magni quia officiis sint at et.", "41d42f71-a31f-4ac5-95c3-41ba8e6b784c", new DateTime(2020, 11, 16, 8, 42, 57, 158, DateTimeKind.Local).AddTicks(6151), "Cash desk: saepe", new DateTime(2022, 4, 12, 13, 37, 53, 16, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("120599f3-8bc0-4e3b-99ca-2fb164e932d9"), "Quos sint fuga qui ipsa eos.", "bc32c6c7-6890-402e-8b7c-caf1df6ac0ea", new DateTime(2017, 11, 13, 7, 48, 54, 163, DateTimeKind.Local).AddTicks(8181), "Cash desk: officia", new DateTime(2021, 4, 20, 18, 1, 51, 920, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12837ed0-8239-480d-8793-e8cfc327ee63"), "Tempore sed excepturi qui delectus.", "df89c8c1-5d4c-4c8d-b09e-4862310277db", new DateTime(2021, 4, 13, 1, 6, 20, 782, DateTimeKind.Local).AddTicks(2970), "Cash desk: dolorum", new DateTime(2022, 4, 10, 19, 23, 32, 744, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e7e2573-2cc4-49df-a4ae-4eea46ac7ff9"), "Quis deleniti asperiores autem illum excepturi dolores quis.", "1fdfa6dd-aef4-41ad-83d4-8ba0285371b8", new DateTime(2021, 3, 29, 9, 39, 31, 954, DateTimeKind.Local).AddTicks(1401), "Cash desk: sit", new DateTime(2021, 9, 24, 22, 45, 8, 954, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e9b57ca-c641-43d5-9ac5-05db590f48fa"), "Veniam laborum aliquam et.", "8be2dc9e-9671-4fc1-add9-cdc5e06101d8", new DateTime(2021, 9, 8, 1, 19, 55, 698, DateTimeKind.Local).AddTicks(6325), "Cash desk: autem", new DateTime(2022, 4, 28, 23, 44, 42, 885, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22137222-ce56-4d7d-b5e2-0f2e621a55ee"), "Et minima voluptatem delectus explicabo sed fugit.", "01b37abb-57da-4804-a4fe-7fe67d233966", new DateTime(2019, 4, 8, 15, 22, 52, 447, DateTimeKind.Local).AddTicks(6594), "Cash desk: error", new DateTime(2020, 11, 18, 17, 33, 1, 827, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("250fe354-5fa0-47a9-863e-8dbb6f14b20e"), "Sapiente debitis nostrum quis distinctio.", "509a324f-4d48-4e10-af55-1fb0447d0bc8", new DateTime(2018, 1, 1, 5, 39, 56, 795, DateTimeKind.Local).AddTicks(4682), "Cash desk: maiores", new DateTime(2020, 1, 9, 17, 11, 3, 587, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("256d0e48-46c2-41bd-9851-e094db705dff"), "Reiciendis voluptates consequatur officiis exercitationem consequatur optio dolorem placeat qui.", "ece44d42-2856-4744-82e3-087cb8545355", new DateTime(2020, 7, 7, 19, 34, 40, 805, DateTimeKind.Local).AddTicks(5513), "Cash desk: est", new DateTime(2021, 10, 14, 3, 14, 20, 10, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26d7a2b4-0707-4474-b514-3608946e2336"), "Fugiat totam delectus.", "b5ebb100-7c29-4340-882a-a7f16fc5faed", new DateTime(2020, 4, 27, 15, 54, 55, 19, DateTimeKind.Local).AddTicks(9779), "Cash desk: rerum", new DateTime(2021, 2, 14, 16, 59, 0, 294, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("276b8f10-a200-4c73-8e68-cad767c76d02"), "Explicabo magni sed officiis expedita maxime tempore deserunt qui corrupti.", "002c1dc5-ade9-4948-be62-2d7d290e62d6", new DateTime(2021, 6, 2, 11, 55, 57, 12, DateTimeKind.Local).AddTicks(8662), "Cash desk: ut", new DateTime(2022, 1, 5, 10, 52, 2, 275, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("27d3b5a0-7eaa-41be-8cc3-2c49437d00e2"), "Sit reprehenderit neque quo dignissimos placeat suscipit impedit.", "2a2b5036-242f-471e-a5b0-d616a91ab7ca", new DateTime(2021, 3, 8, 12, 56, 31, 311, DateTimeKind.Local).AddTicks(4398), "Cash desk: enim", new DateTime(2021, 11, 20, 11, 2, 26, 440, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("29bb277f-e86d-4267-a5e3-edc044fe34a0"), "Qui harum esse omnis.", "88f18c6e-7800-4b5b-822c-5d321fb8a67a", new DateTime(2021, 4, 21, 14, 13, 47, 668, DateTimeKind.Local).AddTicks(8423), "Cash desk: eum", new DateTime(2021, 12, 26, 13, 32, 23, 340, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("29c93220-76e0-4187-a1bf-fd4b7fe79ff7"), "Voluptatem voluptatem enim voluptatem dignissimos ipsum.", "d289a802-b750-4fb5-aefb-89b6452eb863", new DateTime(2021, 1, 25, 8, 28, 33, 748, DateTimeKind.Local).AddTicks(8990), "Cash desk: tempore", new DateTime(2022, 3, 13, 5, 24, 16, 32, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2da98240-94c5-44a8-ba75-0ca37a17d2c9"), "Sed dicta qui aut harum molestiae consequatur voluptates ipsa.", "1eb89f45-cc16-4a90-ae55-ad4cdb0172e1", new DateTime(2021, 10, 5, 22, 21, 47, 743, DateTimeKind.Local).AddTicks(3467), "Cash desk: atque", new DateTime(2022, 6, 3, 0, 39, 45, 65, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2dced654-f54e-442d-b886-aa3121c947e8"), "Temporibus molestiae velit dolores temporibus.", "a13cf912-576a-4018-9e37-36949aee06d4", new DateTime(2020, 2, 10, 5, 37, 45, 435, DateTimeKind.Local).AddTicks(6238), "Cash desk: et", new DateTime(2020, 4, 10, 6, 29, 51, 103, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f2937d9-30db-4e4f-90b3-0684f8f4dda2"), "Aliquid possimus quisquam laborum blanditiis.", "fd654e31-cc21-46e4-91c3-26c12f8b82ff", new DateTime(2022, 2, 25, 8, 6, 44, 988, DateTimeKind.Local).AddTicks(5004), "Cash desk: debitis", new DateTime(2022, 6, 10, 22, 37, 5, 647, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f9c5612-f245-4603-81a1-014f4a454e1b"), "Alias dolore minima dolor praesentium.", "34542598-a7d1-4e90-a525-7bd6cc5adeab", new DateTime(2017, 9, 9, 18, 0, 22, 419, DateTimeKind.Local).AddTicks(6294), "Cash desk: nisi", new DateTime(2022, 3, 8, 2, 26, 5, 326, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30e24fde-a988-40b6-8322-054d67b62634"), "Amet deleniti fuga voluptas id accusantium.", "7230f728-f583-47e4-a792-db6d9f566e98", new DateTime(2017, 8, 16, 10, 38, 12, 819, DateTimeKind.Local).AddTicks(9398), "Cash desk: ipsa", new DateTime(2021, 12, 11, 20, 47, 44, 18, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3152ba73-da26-4a6d-b286-58ba331ed9e9"), "Molestias qui odit.", "96231579-ef73-4573-88f2-c07a30b673a3", new DateTime(2020, 6, 6, 2, 38, 13, 274, DateTimeKind.Local).AddTicks(7955), "Cash desk: quod", new DateTime(2022, 2, 25, 7, 40, 16, 789, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3304f298-ad54-4f7c-b49c-4aecb26aeb82"), "Est perferendis qui laborum veniam sint ab magnam iusto.", "9595fcd1-f323-4bf1-a4e9-2b6bff77fb07", new DateTime(2021, 7, 27, 17, 23, 22, 590, DateTimeKind.Local).AddTicks(9264), "Cash desk: maxime", new DateTime(2021, 8, 7, 5, 15, 4, 868, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("39ebb60d-b1b9-4e42-bddc-b58bdbf69bde"), "Mollitia aliquid odio minus iste provident assumenda dolor.", "52e538aa-aaec-4525-8d07-852a4f57ba46", new DateTime(2020, 2, 13, 1, 2, 23, 117, DateTimeKind.Local).AddTicks(5136), "Cash desk: corporis", new DateTime(2021, 10, 6, 3, 1, 52, 330, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d3677d0-f978-49eb-ba4f-45eb1624fc9e"), "Sint aut et qui.", "34b24bc4-6809-40bc-ac95-2fd35891586b", new DateTime(2022, 3, 1, 9, 13, 10, 332, DateTimeKind.Local).AddTicks(8944), "Cash desk: earum", new DateTime(2022, 5, 8, 20, 48, 9, 660, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("418eed70-4555-4caa-a3ed-0ad6720fe9c4"), "Voluptas optio beatae earum at qui ullam impedit eos.", "24cbd156-13e7-4610-8188-36738d82d643", new DateTime(2021, 12, 21, 14, 15, 46, 751, DateTimeKind.Local).AddTicks(4130), "Cash desk: similique", new DateTime(2022, 3, 13, 1, 26, 42, 173, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4372b900-ea10-4ac9-8292-5a6ac7b5d190"), "Aut in accusamus unde.", "02b96607-9618-44dd-ace3-44589b720ba5", new DateTime(2022, 1, 19, 1, 19, 11, 49, DateTimeKind.Local).AddTicks(2081), "Cash desk: aut", new DateTime(2022, 3, 18, 18, 6, 36, 455, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b8c0546-0993-4dae-bf2e-111a1537a58d"), "Veritatis molestiae est architecto similique quo omnis ut voluptatem illum.", "198ba1a6-7c3c-4551-894f-eb5ae687edc2", new DateTime(2020, 4, 6, 19, 24, 36, 591, DateTimeKind.Local).AddTicks(3618), "Cash desk: numquam", new DateTime(2020, 7, 14, 12, 10, 19, 680, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c60f629-9e3b-49b2-bcdd-58cb34025125"), "Qui et aut.", "b51e1948-c35e-4df9-87f6-36223d5a0951", new DateTime(2022, 5, 21, 19, 47, 33, 571, DateTimeKind.Local).AddTicks(1565), "Cash desk: nihil", new DateTime(2022, 7, 3, 9, 42, 6, 210, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52362ba7-c366-4e6e-8a7e-adc432027236"), "Sit aut dolores.", "1b5305d6-9b1a-4be1-9190-aa271b70b7f3", new DateTime(2019, 4, 4, 19, 45, 58, 374, DateTimeKind.Local).AddTicks(8150), "Cash desk: ipsam", new DateTime(2021, 7, 10, 2, 55, 45, 517, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53084d5c-bf11-4bf3-a297-d221617e179b"), "Accusamus itaque ut nulla doloremque et a.", "a9581c6a-b951-4457-8349-5b0b0b66aa85", new DateTime(2018, 4, 9, 4, 41, 0, 162, DateTimeKind.Local).AddTicks(1363), "Cash desk: doloribus", new DateTime(2020, 6, 26, 14, 20, 54, 998, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55574774-e1bb-48b2-b965-d1d7e3aceb03"), "Non sequi possimus.", "80f17636-fb37-4cd4-9d8c-aca3200ec6cb", new DateTime(2022, 5, 5, 6, 28, 35, 923, DateTimeKind.Local).AddTicks(5303), "Cash desk: temporibus", new DateTime(2022, 6, 9, 6, 1, 3, 805, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55a354b2-e3cf-4211-891f-4a2f5574077a"), "Et esse animi qui et officiis quasi modi officiis.", "b52ec7a0-20f5-4e43-8602-b2f9544d2554", new DateTime(2022, 7, 4, 0, 31, 8, 916, DateTimeKind.Local).AddTicks(53), "Cash desk: nihil", new DateTime(2022, 7, 4, 20, 9, 28, 235, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5bbbef4d-0074-46ee-854b-fa764251683a"), "Laborum eius et quo inventore unde placeat.", "0e9a1e09-e47f-4090-8264-3cd14a0011e2", new DateTime(2018, 7, 13, 20, 1, 15, 786, DateTimeKind.Local).AddTicks(2746), "Cash desk: temporibus", new DateTime(2021, 10, 30, 11, 9, 54, 805, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5db21629-7aca-4b7b-9400-86cc334f3f20"), "Sunt voluptatum nobis nam.", "9b87e094-2a13-448b-9178-082870008a3b", new DateTime(2020, 5, 2, 21, 3, 24, 17, DateTimeKind.Local).AddTicks(8353), "Cash desk: et", new DateTime(2020, 9, 4, 14, 42, 29, 476, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e5c7b93-f0bb-419a-99fc-71dacd47a0d6"), "Voluptatem eum temporibus repudiandae esse.", "96c0dc8d-ab97-4b4d-a8b7-475f92617e1b", new DateTime(2020, 4, 21, 13, 0, 1, 243, DateTimeKind.Local).AddTicks(1805), "Cash desk: inventore", new DateTime(2020, 8, 30, 3, 16, 2, 974, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("617d99ee-3589-4b78-b3c3-2ce00eb0822f"), "Et dolorem numquam dolorem voluptatem aut dignissimos reiciendis ea saepe.", "8836d5b5-f0d3-49f2-a4bb-1b7662d9d51d", new DateTime(2020, 10, 17, 11, 10, 23, 617, DateTimeKind.Local).AddTicks(6756), "Cash desk: similique", new DateTime(2021, 3, 20, 17, 31, 31, 135, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61967370-8b17-4643-b799-27571d16658b"), "Et quis quo similique quod qui eligendi.", "2a57613f-0074-412b-9083-4d26f803d902", new DateTime(2017, 12, 15, 9, 13, 19, 330, DateTimeKind.Local).AddTicks(6746), "Cash desk: et", new DateTime(2019, 1, 5, 13, 56, 13, 131, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("62b97593-7a00-47a4-8493-47c0b9b113d5"), "Recusandae impedit laboriosam.", "bb6469c4-20e5-4204-ad12-ce641ddec666", new DateTime(2022, 1, 16, 18, 20, 56, 740, DateTimeKind.Local).AddTicks(2880), "Cash desk: dolorem", new DateTime(2022, 5, 29, 4, 35, 7, 297, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("639f7717-98f0-4fb4-aa98-14a20863f641"), "Non ut dolor mollitia et.", "a9d43d97-d466-46c9-8707-df920613d192", new DateTime(2019, 5, 22, 15, 10, 53, 211, DateTimeKind.Local).AddTicks(1795), "Cash desk: vel", new DateTime(2020, 7, 21, 20, 41, 55, 754, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("677cd772-b382-4c0d-8ec3-d24767d492c9"), "Eveniet itaque voluptas.", "cf9b458f-54d6-40a5-8bb7-c32fc070edfc", new DateTime(2021, 9, 30, 19, 28, 29, 710, DateTimeKind.Local).AddTicks(2170), "Cash desk: nihil", new DateTime(2022, 6, 1, 3, 7, 48, 384, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7151f9d5-aec9-488b-947e-f84006963dc4"), "Optio consequuntur unde exercitationem consequatur totam pariatur sint ea.", "e151683f-c0f0-4c8b-ba74-685485a71a41", new DateTime(2021, 5, 19, 9, 14, 14, 940, DateTimeKind.Local).AddTicks(2901), "Cash desk: eligendi", new DateTime(2022, 1, 30, 10, 35, 59, 88, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72ba7e61-98b8-4728-9af7-76ae8a82e601"), "Qui non excepturi beatae.", "188711d6-25f7-4a43-9573-87011f70db2f", new DateTime(2018, 4, 12, 9, 43, 46, 473, DateTimeKind.Local).AddTicks(7075), "Cash desk: laborum", new DateTime(2018, 10, 12, 18, 22, 58, 774, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("79044bc8-eed4-4e12-a422-d2491ad3f354"), "Nesciunt esse ducimus ipsa reprehenderit voluptatibus cupiditate necessitatibus.", "55bb1d79-5529-48b3-8225-57dd517926d8", new DateTime(2020, 1, 4, 23, 9, 43, 933, DateTimeKind.Local).AddTicks(2810), "Cash desk: adipisci", new DateTime(2020, 12, 5, 17, 59, 26, 276, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b15171a-f1e5-4e70-b320-94acee823ecb"), "Natus asperiores temporibus vel est rerum.", "9cac02bb-2753-427d-a0b4-0d0ab4ed2633", new DateTime(2018, 2, 5, 16, 15, 47, 745, DateTimeKind.Local).AddTicks(4268), "Cash desk: nostrum", new DateTime(2020, 11, 23, 11, 32, 5, 41, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c8cc52b-511f-4778-a018-02adadc662ec"), "Quo necessitatibus aut aspernatur ut molestiae autem labore porro est.", "4985055c-7b9c-49f9-b7a5-35b4247f70cc", new DateTime(2019, 6, 23, 22, 32, 56, 261, DateTimeKind.Local).AddTicks(2077), "Cash desk: aut", new DateTime(2020, 4, 7, 8, 40, 25, 628, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7d9060ad-9941-4592-9f81-ce12d6b507f7"), "Dolorum distinctio consequatur veritatis eaque dignissimos.", "98cdb4b8-91d5-4a8b-bfc3-60b368ca7f47", new DateTime(2020, 11, 23, 17, 54, 56, 328, DateTimeKind.Local).AddTicks(243), "Cash desk: unde", new DateTime(2021, 1, 24, 20, 32, 22, 282, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e3949c5-2c75-4b05-b861-5330d287d862"), "Vel architecto rerum doloribus qui.", "a87518e9-aad0-4345-9034-7838bc965a67", new DateTime(2018, 2, 11, 15, 6, 50, 316, DateTimeKind.Local).AddTicks(7298), "Cash desk: hic", new DateTime(2022, 2, 26, 16, 38, 32, 471, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e4bd089-c9c2-466b-bc4c-8ac023b9c571"), "Dolorem corporis consequatur sapiente natus ut aut.", "73af0e58-b528-4a6a-8680-06301e7313b2", new DateTime(2018, 12, 30, 2, 30, 49, 691, DateTimeKind.Local).AddTicks(7974), "Cash desk: sint", new DateTime(2019, 7, 14, 10, 32, 7, 432, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e8c92d3-6e04-43e6-bb26-093b89fd1924"), "Autem consequatur repudiandae voluptatem beatae recusandae est optio consequatur.", "81311111-c66e-4155-a912-e8f62a65c27f", new DateTime(2017, 12, 5, 6, 41, 41, 850, DateTimeKind.Local).AddTicks(8272), "Cash desk: officia", new DateTime(2019, 5, 6, 1, 5, 53, 215, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8270cfc2-e1bc-4890-9f8b-629c08b5ac19"), "Distinctio ullam magnam repellat et.", "06b41241-e8ab-4044-a865-05661780a999", new DateTime(2021, 4, 27, 9, 15, 32, 545, DateTimeKind.Local).AddTicks(2991), "Cash desk: temporibus", new DateTime(2021, 11, 27, 2, 13, 49, 422, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84ff407d-a309-431e-b7c8-dc237b0251ee"), "Dolorem eos ullam fugit tenetur sunt eos.", "2c958129-1078-4367-a608-8ba40eacf2f8", new DateTime(2018, 12, 22, 16, 1, 12, 577, DateTimeKind.Local).AddTicks(6409), "Cash desk: beatae", new DateTime(2019, 3, 22, 8, 8, 5, 857, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("88f66538-498e-45fb-b054-77774fde0d08"), "Accusantium quo ut ea cupiditate eos enim non.", "381070f1-d5cb-4f85-bbb8-00d9a0a15683", new DateTime(2019, 1, 21, 8, 40, 48, 374, DateTimeKind.Local).AddTicks(4401), "Cash desk: possimus", new DateTime(2022, 1, 21, 9, 44, 7, 775, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a9f2fa7-0d93-46ea-b1ed-acd23ac34811"), "Inventore atque voluptatem pariatur.", "f2b07d49-2ddf-4527-a751-3416daacca50", new DateTime(2020, 5, 28, 3, 46, 58, 774, DateTimeKind.Local).AddTicks(5036), "Cash desk: occaecati", new DateTime(2020, 8, 30, 1, 21, 1, 970, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90d74313-89b9-4958-a951-0900f4f33161"), "Enim et perferendis doloribus voluptatem excepturi quia assumenda necessitatibus.", "3c631f7d-b488-4362-8c61-71048fde6997", new DateTime(2017, 9, 27, 15, 23, 11, 234, DateTimeKind.Local).AddTicks(1294), "Cash desk: alias", new DateTime(2022, 4, 2, 21, 44, 38, 69, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92b5fae2-7b70-4b52-9c7f-ab5d7fd1567e"), "Voluptate et rem ipsam.", "32eab46f-7915-4ea4-9b29-762f9c63ed85", new DateTime(2020, 11, 13, 9, 39, 9, 106, DateTimeKind.Local).AddTicks(1841), "Cash desk: voluptatum", new DateTime(2022, 1, 16, 21, 53, 22, 322, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("95bb6b59-f004-4b50-8ccb-d816eb5219dd"), "Modi odio nobis alias rerum ipsam nobis et aut quibusdam.", "ff222713-6ad0-480e-9cb2-d2b6e993546f", new DateTime(2021, 12, 3, 23, 55, 2, 896, DateTimeKind.Local).AddTicks(9091), "Cash desk: quod", new DateTime(2022, 3, 20, 21, 13, 34, 201, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("96646111-8027-4caa-9b0f-45b5ea61b137"), "Dolorem quam omnis excepturi ad dolores sapiente repudiandae incidunt qui.", "dbaf7b45-db56-44f6-bb73-b5eb87f42b7c", new DateTime(2021, 8, 15, 17, 28, 8, 360, DateTimeKind.Local).AddTicks(4835), "Cash desk: quia", new DateTime(2021, 12, 22, 16, 34, 45, 384, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a474a4f-18fe-4f2f-9bbf-37fcd9659dcb"), "Recusandae libero qui quasi eos doloribus deserunt qui quod.", "a4cb6149-7a39-4873-b3fa-4cba3bb54892", new DateTime(2020, 7, 18, 0, 15, 48, 351, DateTimeKind.Local).AddTicks(219), "Cash desk: ipsa", new DateTime(2021, 10, 10, 17, 45, 11, 617, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e4a81f6-2523-4bcf-8962-c61f5af05105"), "Aut tempora ipsam.", "38b2d3bf-3e04-4de7-8cae-a56de0839d67", new DateTime(2018, 3, 19, 9, 23, 3, 358, DateTimeKind.Local).AddTicks(1980), "Cash desk: fugit", new DateTime(2021, 3, 7, 10, 33, 20, 49, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a0ccb3e4-4701-4383-b145-db2eb9374b7e"), "Velit vero et dolorem rerum omnis eos iusto ratione nesciunt.", "ddb0284d-015d-4655-9684-5eceba5c7db1", new DateTime(2019, 6, 12, 5, 35, 3, 961, DateTimeKind.Local).AddTicks(8927), "Cash desk: harum", new DateTime(2022, 5, 14, 4, 38, 53, 323, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2ea4a9e-e288-4b14-8370-cbf16dcf48f0"), "Facere est dolore et numquam natus autem vel ratione.", "2e50ecb7-c540-4020-8a87-6911bc7cbefd", new DateTime(2019, 6, 8, 15, 27, 4, 947, DateTimeKind.Local).AddTicks(7759), "Cash desk: soluta", new DateTime(2021, 1, 11, 4, 13, 38, 212, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5c95fb9-0750-4fe7-89c0-a53fdb06f5f2"), "Officia maxime impedit deleniti molestias laudantium quidem qui.", "0d31da78-73f5-4a5d-8a9b-4224a326dc6c", new DateTime(2021, 1, 30, 4, 31, 9, 996, DateTimeKind.Local).AddTicks(5595), "Cash desk: sit", new DateTime(2021, 6, 14, 22, 27, 38, 434, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5c99b65-e079-47ea-a484-fcbfc8c9523c"), "Enim dolorum quam et voluptatem.", "25209504-1b92-4ff5-b857-896ebe9c4751", new DateTime(2021, 6, 28, 6, 6, 0, 116, DateTimeKind.Local).AddTicks(4747), "Cash desk: odio", new DateTime(2022, 2, 15, 23, 42, 57, 399, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("abaae07c-d9ea-4890-a0f2-73e631417c2f"), "Ex quisquam ratione et.", "b39d4d88-9477-4b98-a7c1-f893ed5c8c0e", new DateTime(2018, 8, 22, 23, 36, 6, 449, DateTimeKind.Local).AddTicks(8706), "Cash desk: assumenda", new DateTime(2019, 1, 29, 13, 47, 16, 153, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("acd46281-8a91-470e-a5b5-d342a1c5212c"), "Quae earum ut praesentium harum.", "b0f6c38b-721b-4ccd-b820-bcc495c86841", new DateTime(2022, 6, 29, 19, 21, 42, 728, DateTimeKind.Local).AddTicks(874), "Cash desk: impedit", new DateTime(2022, 6, 30, 9, 4, 46, 816, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b23ee6ff-41e1-473e-ac39-1515e1989235"), "Molestiae ipsa nemo quisquam ea voluptas ratione molestiae similique.", "15101349-3154-44b6-93aa-08b22cef45b9", new DateTime(2019, 9, 29, 3, 58, 16, 45, DateTimeKind.Local).AddTicks(8532), "Cash desk: vero", new DateTime(2022, 2, 7, 23, 30, 20, 438, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3d52be3-0c36-4144-8772-813e2df2c1ea"), "Non aut numquam voluptatibus cum ullam inventore.", "9f201f0f-9d94-4e5c-bbb4-bdf5ca41812b", new DateTime(2018, 12, 23, 11, 23, 26, 53, DateTimeKind.Local).AddTicks(452), "Cash desk: facilis", new DateTime(2019, 4, 30, 15, 55, 11, 355, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b53b2ca8-6a5c-4b90-b948-c934ed716393"), "Cupiditate fuga quidem quisquam totam nam earum occaecati.", "2c0c9165-19f5-43d3-8841-39e3eb1919eb", new DateTime(2018, 3, 20, 18, 18, 36, 776, DateTimeKind.Local).AddTicks(3499), "Cash desk: voluptas", new DateTime(2021, 3, 9, 13, 10, 53, 151, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b5541e56-5eb9-44f8-8235-a6a7ba91f868"), "Blanditiis non vel ratione cum sapiente placeat similique occaecati.", "c410091b-5055-474a-8cc5-c8f8851ba1b2", new DateTime(2020, 12, 30, 10, 42, 33, 920, DateTimeKind.Local).AddTicks(677), "Cash desk: at", new DateTime(2021, 9, 9, 20, 24, 51, 459, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8af2ef0-4bd5-4eb8-90d0-e75f83a66a08"), "Quasi consequatur numquam explicabo ullam eos eos cupiditate soluta.", "a6e59a63-3fe6-4262-a563-c10b1014af79", new DateTime(2021, 10, 9, 2, 1, 36, 284, DateTimeKind.Local).AddTicks(8302), "Cash desk: unde", new DateTime(2022, 4, 11, 14, 33, 54, 752, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9b98840-288b-426f-9475-1802c2e1eb7c"), "Est numquam cumque iste odio nihil eos sapiente.", "822bec48-df06-4aca-a102-db95bd567b45", new DateTime(2021, 8, 2, 16, 33, 19, 741, DateTimeKind.Local).AddTicks(6387), "Cash desk: itaque", new DateTime(2021, 12, 9, 8, 33, 33, 999, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc224edb-0eec-42fb-af78-04683aad02f8"), "Nihil dignissimos rerum recusandae iste quia libero necessitatibus ut.", "bba71d43-2b20-4dcf-891a-06357b0c9ae9", new DateTime(2020, 11, 8, 23, 24, 16, 638, DateTimeKind.Local).AddTicks(6682), "Cash desk: velit", new DateTime(2021, 2, 26, 16, 58, 35, 495, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc2fb478-14c7-460e-bc6c-c8bef419ca79"), "Quod sint nam.", "2f947972-d1b7-4f29-a789-25e21f157da9", new DateTime(2017, 12, 7, 22, 21, 22, 202, DateTimeKind.Local).AddTicks(6360), "Cash desk: necessitatibus", new DateTime(2021, 2, 15, 7, 50, 37, 474, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd34f798-ce59-4dc6-bcde-8a188cab712a"), "Dolores soluta et.", "050e1fe0-4756-4046-bf33-e672d1c2149a", new DateTime(2021, 9, 23, 14, 24, 51, 279, DateTimeKind.Local).AddTicks(7829), "Cash desk: aut", new DateTime(2022, 1, 3, 21, 35, 16, 448, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c736906f-a3bf-4fb0-9cd4-32c4ed95aa2c"), "Pariatur quo amet consequuntur sunt enim porro vel est.", "b0e8dcfa-a8ca-4ed8-8c92-e0f0cf30369e", new DateTime(2022, 1, 1, 7, 3, 37, 461, DateTimeKind.Local).AddTicks(3370), "Cash desk: illum", new DateTime(2022, 3, 3, 5, 1, 8, 560, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cb230c96-368d-4888-ad1c-d148fa62f8cf"), "Dolorem earum autem adipisci.", "8b455070-ce72-4a15-afdc-4242638d9be0", new DateTime(2022, 2, 27, 10, 47, 6, 346, DateTimeKind.Local).AddTicks(5079), "Cash desk: ea", new DateTime(2022, 6, 11, 3, 48, 8, 64, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cc537ac3-ce1f-4c33-8fe4-e5eb5557a48d"), "Magni amet id molestiae quidem sunt.", "3ef43ab1-456d-4cbc-8de2-971721127417", new DateTime(2020, 12, 13, 8, 50, 33, 216, DateTimeKind.Local).AddTicks(5683), "Cash desk: labore", new DateTime(2020, 12, 28, 12, 42, 52, 329, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd639956-2c4a-4f02-8264-9f5572e67021"), "Magni qui ad quis et alias.", "b4916054-3f71-4337-9718-75c0bfd21f9a", new DateTime(2020, 10, 20, 0, 22, 52, 653, DateTimeKind.Local).AddTicks(1908), "Cash desk: officiis", new DateTime(2022, 4, 13, 2, 44, 53, 766, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf6052d4-c977-48c3-98db-066c55fa9e29"), "Ratione consequuntur harum exercitationem adipisci aliquam.", "bcc47917-9305-41df-a1ee-83436b981927", new DateTime(2020, 5, 12, 22, 53, 30, 933, DateTimeKind.Local).AddTicks(4003), "Cash desk: magni", new DateTime(2021, 10, 18, 3, 40, 12, 178, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d2e873d4-0aa4-4e4e-ac16-27d140494bae"), "Quis at qui placeat.", "8b7f1618-8fdf-4b37-bfa9-aa28420d0c91", new DateTime(2020, 7, 2, 3, 25, 52, 223, DateTimeKind.Local).AddTicks(7603), "Cash desk: excepturi", new DateTime(2021, 8, 7, 19, 14, 3, 256, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9a688b5-0df1-4d58-acdd-b7d6bcb7549c"), "In qui voluptate aperiam sint maiores accusantium ducimus nulla animi.", "3286224f-8f3d-4236-a12a-5ffaed338bda", new DateTime(2018, 1, 29, 15, 10, 23, 802, DateTimeKind.Local).AddTicks(7587), "Cash desk: corrupti", new DateTime(2018, 11, 10, 15, 30, 6, 693, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9e84b0b-a070-4e94-bec6-e52fb0fdfada"), "Vel magnam rerum quia magni eligendi harum quia.", "a5704694-9198-4e6d-afdf-fec9cdc544ba", new DateTime(2018, 1, 24, 12, 39, 2, 530, DateTimeKind.Local).AddTicks(6904), "Cash desk: optio", new DateTime(2018, 10, 11, 18, 27, 55, 403, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ddd52b18-391d-4c9e-b7e5-635bff09846e"), "Quisquam quo maxime non.", "6cc98144-3933-433a-a876-716bf52dce00", new DateTime(2022, 4, 22, 10, 58, 26, 611, DateTimeKind.Local).AddTicks(848), "Cash desk: repudiandae", new DateTime(2022, 6, 26, 15, 10, 47, 330, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3cd9d01-6c6d-45d0-b912-6cd126deecb5"), "Optio dicta fuga sit.", "78dad04c-20e3-4c31-91c8-87048927da76", new DateTime(2020, 2, 12, 3, 7, 42, 350, DateTimeKind.Local).AddTicks(4903), "Cash desk: consequatur", new DateTime(2022, 2, 1, 12, 33, 6, 833, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e614cd4f-5cf2-47c7-aa59-053c44d948a1"), "Amet vel recusandae exercitationem et sunt rerum ab.", "49e9d263-9124-4a3a-8f82-c7c2a546e48c", new DateTime(2018, 8, 2, 7, 2, 16, 144, DateTimeKind.Local).AddTicks(6583), "Cash desk: enim", new DateTime(2022, 4, 27, 3, 49, 9, 848, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e66da5fa-d43a-482f-9202-d7a26c81ea77"), "Similique praesentium accusantium ducimus.", "88125549-5715-40d7-8af8-ebd92544de53", new DateTime(2017, 11, 19, 3, 21, 30, 205, DateTimeKind.Local).AddTicks(1394), "Cash desk: laudantium", new DateTime(2021, 9, 23, 13, 26, 23, 840, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eb5a0ff6-52c2-4728-bcfd-a5597d852744"), "Sequi sint eius ut.", "b881da34-ee85-42ee-bec1-6aa117263c3d", new DateTime(2021, 4, 17, 7, 23, 10, 552, DateTimeKind.Local).AddTicks(7926), "Cash desk: possimus", new DateTime(2022, 2, 4, 17, 14, 16, 330, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed65ba87-6d65-4843-90bf-929d9b2a0fe3"), "Et harum explicabo.", "4af56d8b-fd53-4757-8ed8-72a0eba852c1", new DateTime(2021, 8, 26, 17, 31, 43, 364, DateTimeKind.Local).AddTicks(7620), "Cash desk: veritatis", new DateTime(2021, 11, 26, 6, 38, 24, 704, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee3aceed-7627-4fa3-9870-2f0d28d964b0"), "Asperiores tempore sit dolorem quibusdam.", "031795cb-4dd4-4c9b-93ad-dab9e0742ca2", new DateTime(2017, 9, 13, 7, 12, 0, 85, DateTimeKind.Local).AddTicks(6498), "Cash desk: perspiciatis", new DateTime(2020, 1, 21, 13, 2, 43, 489, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef06f5ca-9c1e-4f51-860e-74d6f984b44c"), "Et perferendis expedita rerum ex dolore.", "9ff72b40-fe50-477c-b46e-e8fe8301e525", new DateTime(2019, 4, 4, 0, 41, 56, 56, DateTimeKind.Local).AddTicks(760), "Cash desk: totam", new DateTime(2020, 12, 8, 2, 30, 7, 124, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f232bf53-4f89-4428-9aea-fc4ffe06c1dd"), "Molestias repellendus qui veritatis ut saepe neque.", "db1e1b14-86d7-4f0b-bb4f-5d57bba2bc39", new DateTime(2021, 2, 10, 7, 43, 0, 25, DateTimeKind.Local).AddTicks(8650), "Cash desk: autem", new DateTime(2021, 6, 10, 2, 30, 58, 560, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f268a759-f35d-4310-82de-9ec7d2a03a0e"), "Labore quisquam autem atque eaque aspernatur est.", "a5a0b8ca-b60c-4a5c-bd4e-5620c82bba1c", new DateTime(2020, 6, 4, 4, 19, 5, 136, DateTimeKind.Local).AddTicks(2800), "Cash desk: molestiae", new DateTime(2020, 12, 22, 22, 5, 44, 460, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f300007b-9133-4fab-b69c-410266e82201"), "Non dolorem est aperiam nihil.", "a9c394bf-2f0b-4528-9ac4-994839632184", new DateTime(2019, 4, 12, 9, 48, 50, 334, DateTimeKind.Local).AddTicks(4153), "Cash desk: facilis", new DateTime(2022, 2, 11, 1, 14, 5, 990, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f352f07b-d868-43b3-a0f5-f4a005a3bc8d"), "Ut quod aut dolor perferendis minima est.", "a19aafe2-067a-486f-b1a3-a5c6ecb79838", new DateTime(2021, 5, 7, 12, 20, 2, 672, DateTimeKind.Local).AddTicks(5054), "Cash desk: assumenda", new DateTime(2021, 7, 10, 15, 33, 0, 647, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f47728a2-0204-4ba0-9c2f-86b555a6a4f5"), "Expedita quisquam tenetur.", "c2fa84f1-ac5a-413c-be7d-a1bd3fd3c564", new DateTime(2022, 4, 2, 13, 18, 13, 5, DateTimeKind.Local).AddTicks(7952), "Cash desk: hic", new DateTime(2022, 4, 25, 6, 42, 13, 461, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6731902-cd85-49aa-a6ec-b13504db30d6"), "Natus excepturi et ipsum voluptas aliquam ad.", "64822c60-c413-4314-943b-a72c6159acf3", new DateTime(2021, 7, 30, 7, 41, 25, 833, DateTimeKind.Local).AddTicks(5971), "Cash desk: et", new DateTime(2022, 6, 8, 1, 18, 4, 532, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fbe60f9b-50f0-4392-9da3-ff91ef4ea926"), "Maxime non amet voluptatem quod facilis.", "0e7d9691-a077-4760-b2b6-858b28124875", new DateTime(2021, 12, 26, 4, 8, 27, 110, DateTimeKind.Local).AddTicks(144), "Cash desk: accusamus", new DateTime(2022, 4, 10, 13, 40, 2, 322, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc01547b-ff17-4a48-bf4c-b982506a9884"), "Qui enim eum aliquam non consequatur.", "3b3fdf21-31b8-4ee9-b614-2708187b412d", new DateTime(2019, 8, 14, 21, 26, 51, 245, DateTimeKind.Local).AddTicks(7906), "Cash desk: non", new DateTime(2020, 5, 30, 13, 14, 19, 907, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe2e2f8f-eb3a-43be-a2b4-98ab7b06c5e9"), "Ad dolorum porro aut possimus aliquid.", "9d7fc0cb-b5de-42a3-af82-d1b807833a9f", new DateTime(2020, 4, 20, 2, 50, 30, 732, DateTimeKind.Local).AddTicks(9960), "Cash desk: voluptas", new DateTime(2021, 7, 29, 2, 33, 35, 445, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.InsertData(
                table: "ClientContactInformationTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("608ab8bf-77ce-4e89-a58d-27dbfe495c44"), "Est omnis eum at alias est.", "fbdb4d99-2da3-4e12-b7c6-d5e37648f73c", new DateTime(2018, 2, 5, 22, 23, 48, 269, DateTimeKind.Local).AddTicks(3975), "phone", new DateTime(2021, 5, 14, 18, 3, 38, 213, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.InsertData(
                table: "ClientContactInformationTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6303f356-a10f-4006-8106-70fe87ee4944"), "Quia quia nihil qui voluptatem.", "40522c7b-eb21-4721-9f45-3770fc87430b", new DateTime(2019, 1, 26, 12, 28, 19, 918, DateTimeKind.Local).AddTicks(2384), "mobile", new DateTime(2021, 6, 24, 1, 14, 14, 443, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.InsertData(
                table: "ClientContactInformationTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc998fa3-1422-4724-9d69-0b46d99d753a"), "Voluptate ut dolor quas est quibusdam adipisci quis voluptate.", "8e15d1a0-01e2-40db-9883-22e457044883", new DateTime(2021, 4, 1, 21, 1, 44, 345, DateTimeKind.Local).AddTicks(4107), "adress", new DateTime(2022, 5, 27, 19, 6, 7, 437, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("034d56ec-c66b-48e8-b423-d15a321baf5f"), "084", "белізький долар", "d63c8f9c-a8cb-428e-a3d1-3993420e161f", new DateTime(2017, 9, 3, 20, 9, 27, 272, DateTimeKind.Local).AddTicks(7878), "Belize Dollar", "BZD", "BZ$", new DateTime(2020, 5, 21, 23, 11, 13, 571, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("038c4731-df94-4245-9b69-90f255cd9ba7"), "328", "гайанський долар", "6d8ed89b-d195-42d0-a3cd-94e90d38c2e4", new DateTime(2021, 3, 24, 19, 2, 52, 971, DateTimeKind.Local).AddTicks(6763), "Guyana Dollar", "GYD", "$", new DateTime(2021, 8, 12, 16, 59, 25, 275, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("03ce0f21-9deb-4381-859f-b99d8c4ebcdd"), "344", "гонконгівський долар", "45599a49-a9e6-4c24-81c3-7cf7c72b9cf1", new DateTime(2020, 10, 25, 1, 2, 59, 91, DateTimeKind.Local).AddTicks(2126), "Hong Kong Dollar", "HKD", "$", new DateTime(2020, 10, 28, 16, 10, 20, 879, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("04bebfdf-1ffb-4976-9a49-f058096747ba"), "704", "донг", "fa09106d-66ec-430b-8e18-40d54301eff1", new DateTime(2022, 1, 14, 16, 34, 51, 873, DateTimeKind.Local).AddTicks(8215), "Viet Nam Dong", "VND", "₫", new DateTime(2022, 4, 17, 1, 46, 44, 790, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("055d4c1e-2974-4b3b-9048-8a9bd3bc967d"), "352", "ісландська крона", "2cb9c4f1-0ffa-4a3d-9983-26c603e3f99c", new DateTime(2019, 10, 24, 11, 57, 45, 806, DateTimeKind.Local).AddTicks(7103), "Iceland Krona", "ISK", "kr", new DateTime(2020, 7, 27, 0, 49, 53, 697, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("0f089bb0-9b50-4111-848f-534d7e418d82"), "096", "брунейський долар", "b4bc6ac4-5e16-4df4-86f4-9fc47a7e4718", new DateTime(2019, 9, 13, 22, 45, 27, 289, DateTimeKind.Local).AddTicks(6104), "Brunei Darussalam Dollar", "BND", "$", new DateTime(2019, 10, 4, 12, 16, 38, 410, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("0f20902a-917b-47c9-8fca-cabb3e8b2476"), "643", "російський рубль", "caf9a9dd-7a5f-4de5-b75c-b105149407dc", new DateTime(2018, 4, 12, 20, 25, 5, 194, DateTimeKind.Local).AddTicks(5912), "Russia Ruble", "RUB", "₽", new DateTime(2018, 7, 8, 6, 26, 7, 111, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("11d05489-cb65-498d-91d7-b279553312e5"), "807", "денар", "796e555b-0aff-4fb9-9b22-ca76a36a22df", new DateTime(2022, 3, 27, 21, 54, 24, 421, DateTimeKind.Local).AddTicks(8416), "Macedonia Denar", "MKD", "ден", new DateTime(2022, 4, 12, 6, 6, 49, 553, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("171efccc-9f00-4e0e-8f61-a3c87595f2ea"), "156", "юань Женьміньбі", "5bdd857a-e365-4223-aef9-e0a441dd7b7f", new DateTime(2018, 4, 17, 20, 40, 30, 693, DateTimeKind.Local).AddTicks(5090), "China Yuan Renminbi", "CNY", "¥", new DateTime(2022, 5, 10, 3, 58, 12, 750, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1754972d-cc88-4091-b39e-11bd58afb8fc"), "496", "тугрик", "9dc5fe03-7635-41e2-8f51-89c545217d02", new DateTime(2022, 3, 8, 10, 54, 34, 384, DateTimeKind.Local).AddTicks(4583), "Mongolia Tughrik", "MNT", "₮", new DateTime(2022, 6, 26, 16, 9, 50, 659, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("17879405-cdee-4587-bd60-fb84c09526fa"), "480", "маврикійська рупія", "0b0cb4af-25d5-4950-ba1a-d7fa3b9b8889", new DateTime(2018, 2, 13, 10, 11, 48, 152, DateTimeKind.Local).AddTicks(1644), "Mauritius Rupee", "MUR", "₨", new DateTime(2019, 7, 20, 13, 12, 34, 110, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1b2875bf-b432-4585-af1d-72b375c3073b"), "978", "євро", "726df7b8-f046-4002-938b-710d2087ee9b", new DateTime(2019, 9, 24, 3, 47, 1, 863, DateTimeKind.Local).AddTicks(8897), "Euro Member Countries", "EUR", "€", new DateTime(2022, 1, 30, 4, 41, 32, 657, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1c1356a9-8539-4719-9ee2-1e8f866aaecd"), "356", "індійська рупія", "5db39e6b-da50-4dab-b470-30dbcd64c5db", new DateTime(2018, 2, 20, 3, 6, 29, 947, DateTimeKind.Local).AddTicks(7538), "India Rupee", "INR", "₹", new DateTime(2020, 2, 11, 19, 26, 30, 88, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1c3bee6e-dfa7-4ce4-84d3-32d970cf24d9"), "208", "данська крона", "1011270c-2d25-418c-be4a-25caced71111", new DateTime(2020, 9, 10, 6, 13, 32, 783, DateTimeKind.Local).AddTicks(8923), "Denmark Krone", "DKK", "kr", new DateTime(2021, 11, 13, 20, 14, 59, 723, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1c7c0f70-86fd-452f-abc3-77358131201d"), "214", "домініканське песо", "30347dea-79a5-4cee-b21b-e6d78b112db1", new DateTime(2020, 11, 2, 16, 32, 28, 943, DateTimeKind.Local).AddTicks(9045), "Dominican Republic Peso", "DOP", "RD$", new DateTime(2021, 5, 29, 12, 19, 37, 112, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1cd065ab-e43f-4ef1-bdd4-1d8ecd54a14a"), "203", "чеська крона", "5f5381fc-9cf7-4927-bdd7-558d4121223d", new DateTime(2017, 8, 23, 21, 29, 15, 949, DateTimeKind.Local).AddTicks(638), "Czech Republic Koruna", "CZK", "Kč", new DateTime(2020, 2, 11, 15, 5, 39, 229, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1e2f0df2-7d69-469a-a861-0ac3f390a62d"), "937", "болівар", "e7230896-cac9-4c35-8a32-1a7a43c743ba", new DateTime(2022, 2, 9, 13, 19, 57, 364, DateTimeKind.Local).AddTicks(6287), "Venezuela Bolívar", "VEF", "Bs", new DateTime(2022, 6, 1, 20, 28, 16, 106, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1f804642-00de-44ff-9d8a-b0c23eb4a162"), "170", "колумбійське песо", "778292ac-145f-454f-9fc3-d31d12087943", new DateTime(2020, 7, 28, 12, 25, 40, 613, DateTimeKind.Local).AddTicks(803), "Colombia Peso", "COP", "$", new DateTime(2021, 2, 11, 6, 34, 39, 755, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2034bd97-c2e3-4fb6-893d-127859cf2592"), "052", "барбадоський долар", "6f7fa6fa-4912-4f37-b19d-5db255e59abd", new DateTime(2021, 7, 11, 4, 38, 9, 790, DateTimeKind.Local).AddTicks(2200), "Barbados Dollar", "BBD", "$", new DateTime(2021, 12, 1, 11, 5, 35, 560, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("21da6f0e-e157-4b2b-a802-ee6fcb34bb4a"), "604", "соль", "58be09de-e5a5-4c6f-8e1d-e3f88c896af1", new DateTime(2020, 10, 5, 22, 19, 9, 152, DateTimeKind.Local).AddTicks(7768), "Peru Sol", "PEN", "S/.", new DateTime(2021, 12, 2, 22, 24, 7, 683, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("22480ea6-c5bd-4c7a-b3de-5598015d396f"), "558", "золота кордоба", "1e46ebb7-f3ed-4f08-95f6-499d1e9c39d8", new DateTime(2020, 11, 9, 23, 51, 18, 326, DateTimeKind.Local).AddTicks(2273), "Nicaragua Cordoba", "NIO", "C$", new DateTime(2022, 7, 2, 9, 49, 10, 101, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2258d0f0-6f90-4441-ba1a-2c1ef816ae60"), "124", "канадський долар", "2ca76169-098d-468c-b0a1-3c03f3061448", new DateTime(2018, 2, 8, 19, 56, 37, 681, DateTimeKind.Local).AddTicks(9822), "Canada Dollar", "CAD", "$", new DateTime(2020, 6, 2, 5, 3, 2, 453, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("24a53e49-d235-4dd8-97c9-7b4854e38148"), "090", "долар Соломонових Островів", "1dd5e9b6-0c23-498a-89d2-2e3338671269", new DateTime(2022, 1, 23, 22, 19, 44, 754, DateTimeKind.Local).AddTicks(3608), "Solomon Islands Dollar", "SBD", "$", new DateTime(2022, 2, 18, 1, 41, 33, 331, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2511a201-fc51-4cc8-ac29-68f0dd0887d0"), "044", "багамський долар", "b41b27f6-faf2-4875-aba9-fd1f932c8fb9", new DateTime(2021, 6, 17, 16, 12, 24, 70, DateTimeKind.Local).AddTicks(5614), "Bahamas Dollar", "BSD", "$", new DateTime(2022, 3, 6, 22, 57, 39, 397, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("255afa99-43e3-4f94-87f0-26c11ff0205e"), "340", "лемпіра", "08ac680c-70fa-4b8b-b1b4-b690da946281", new DateTime(2021, 7, 15, 23, 4, 20, 984, DateTimeKind.Local).AddTicks(1753), "Honduras Lempira", "HNL", "L", new DateTime(2021, 10, 2, 9, 26, 59, 435, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("26e26b02-d79a-4c37-b47a-f64d25dfab07"), "600", "гуарані", "199a58bc-156c-46c5-a043-041f087a3b4d", new DateTime(2018, 7, 30, 17, 38, 57, 210, DateTimeKind.Local).AddTicks(9605), "Paraguay Guarani", "PYG", "Gs", new DateTime(2019, 9, 7, 10, 29, 58, 388, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("29ff8cdc-ae66-4391-9c6f-e369ea73d1ee"), "408", "північнокорейська вона", "85d9c2e7-0423-47ca-9901-a5c9603e9ba9", new DateTime(2018, 9, 28, 2, 28, 41, 977, DateTimeKind.Local).AddTicks(268), "Korea (North) Won", "KPW", "₩", new DateTime(2022, 1, 28, 10, 49, 49, 584, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2c5ff3fd-699f-44ea-b6ea-bc71f3467447"), "417", "сом", "811d3579-5082-4dfd-a1bb-76f407f42a98", new DateTime(2020, 5, 31, 10, 2, 22, 96, DateTimeKind.Local).AddTicks(633), "Kyrgyzstan Som", "KGS", "лв", new DateTime(2021, 10, 5, 8, 3, 49, 4, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2f85d48c-1aa3-4754-9ade-f6ec40007051"), "578", "норвезька крона", "e3e64c78-dce1-4d09-9cba-2d1cd1f15453", new DateTime(2022, 6, 3, 12, 51, 56, 859, DateTimeKind.Local).AddTicks(3158), "Norway Krone", "NOK", "kr", new DateTime(2022, 6, 18, 9, 5, 38, 570, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("3533eae9-3cff-4279-8ed2-ecc537b54b20"), "586", "пакистанська рупія", "2315f863-962d-42ec-a06f-3fa3e14bdfe0", new DateTime(2019, 2, 28, 8, 17, 13, 632, DateTimeKind.Local).AddTicks(2776), "Pakistan Rupee", "PKR", "₨", new DateTime(2021, 1, 22, 11, 37, 11, 294, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("357baaca-175c-4328-90c3-b634c11cee41"), "116", "ріел", "32d5e6ab-e4ed-46b7-a5c6-b8dd57e791f7", new DateTime(2022, 4, 11, 14, 27, 31, 335, DateTimeKind.Local).AddTicks(1492), "Cambodia Riel", "KHR", "៛", new DateTime(2022, 5, 21, 11, 53, 42, 685, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("37fae1c0-33db-446b-98e4-d631b6156cab"), "818", "єгипетський фунт", "c737e31c-d7cb-44a2-94a7-7faf0509879e", new DateTime(2020, 1, 20, 16, 36, 39, 128, DateTimeKind.Local).AddTicks(4089), "Egypt Pound", "EGP", "£", new DateTime(2021, 6, 22, 16, 54, 52, 168, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("3ef3473e-57f3-48d8-a7a4-e7a5f925d8aa"), "690", "сейшельська рупія", "a18fe66d-2747-476c-8011-92f16c257695", new DateTime(2022, 6, 27, 21, 0, 12, 29, DateTimeKind.Local).AddTicks(7463), "Seychelles Rupee", "SCR", "₨", new DateTime(2022, 7, 3, 1, 38, 22, 100, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("49124d99-b369-4dd5-9b39-2e5b1235edea"), "968", "сурінамський долар", "ab2c6703-f96c-40a7-b2f4-f09a54db0c87", new DateTime(2020, 6, 22, 22, 9, 42, 9, DateTimeKind.Local).AddTicks(2877), "Suriname Dollar", "SRD", "$", new DateTime(2022, 4, 29, 1, 31, 45, 315, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("4a6663ad-8ac2-4cd2-9cf7-7e38559c9aba"), "949", "турецька ліра", "ae21daa0-a862-4710-b54f-a7663d14f51d", new DateTime(2021, 2, 28, 0, 32, 2, 470, DateTimeKind.Local).AddTicks(2976), "Turkey Lira", "TRY", "₺", new DateTime(2021, 11, 27, 5, 33, 12, 999, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("4df80bf4-640d-4e38-915f-a49b695f94b6"), "222", "сальвадорський колон", "aa8b0431-9885-4187-b24e-1963d593f6a3", new DateTime(2019, 4, 3, 4, 1, 38, 402, DateTimeKind.Local).AddTicks(2012), "El Salvador Colon", "SVC", "$", new DateTime(2021, 10, 24, 8, 37, 24, 836, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("53ec1bd8-d6f3-4745-bade-04799810b645"), "392", "єна", "66f7f21d-bde8-481a-85c3-e9a4b08d3b3c", new DateTime(2019, 7, 7, 15, 29, 46, 585, DateTimeKind.Local).AddTicks(1095), "Japan Yen", "JPY", "¥", new DateTime(2020, 11, 27, 12, 33, 47, 550, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("571a2029-ce9f-4e36-b3c9-a3a5f8c16142"), "886", "єменський ріал", "3a62116e-5c05-473f-b751-fe118d8c9232", new DateTime(2019, 8, 24, 22, 48, 16, 318, DateTimeKind.Local).AddTicks(930), "Yemen Rial", "YER", "﷼", new DateTime(2022, 5, 5, 8, 23, 53, 15, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("5b8f9a4b-7fb2-4fdf-a1b9-afcf0ada4ed0"), "933", "білоруський рубль", "f3841f5f-e32a-46e1-a008-fa68c26fc63c", new DateTime(2022, 5, 2, 2, 0, 41, 285, DateTimeKind.Local).AddTicks(1293), "Belarus Ruble", "BYN", "Br", new DateTime(2022, 5, 25, 13, 4, 15, 32, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("603abd1f-0d74-4b50-80ed-a3de1d52b468"), "780", "долар Тринідаду і Тобаго", "f339c0b8-dd45-4018-ac63-c84b93af8b20", new DateTime(2020, 10, 1, 18, 45, 28, 644, DateTimeKind.Local).AddTicks(5087), "Trinidad and Tobago Dollar", "TTD", "TT$", new DateTime(2021, 9, 29, 8, 3, 55, 57, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("63d9d97f-dfe8-4e15-b636-266d36d21545"), "516", "намібійський долар", "e51f6cf0-5830-401f-8012-c5009b80dc6c", new DateTime(2017, 11, 28, 0, 6, 48, 319, DateTimeKind.Local).AddTicks(7772), "Namibia Dollar", "NAD", "$", new DateTime(2021, 9, 5, 3, 36, 53, 456, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("647f9ed2-a0c6-4081-aa8f-9639a4521983"), "388", "ямайський долар", "709e9917-dc47-4ce7-b851-49c0fea4367b", new DateTime(2019, 4, 11, 12, 24, 34, 465, DateTimeKind.Local).AddTicks(6744), "Jamaica Dollar", "JMD", "J$", new DateTime(2019, 9, 18, 16, 34, 9, 638, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("695c85ed-42cd-4e46-9b6f-b8f1848ded6f"), "634", "катарський ріал", "64804ed7-2577-4531-99d0-ba958e8593d2", new DateTime(2019, 1, 2, 22, 1, 13, 441, DateTimeKind.Local).AddTicks(4430), "Qatar Riyal", "QAR", "﷼", new DateTime(2019, 12, 2, 12, 17, 1, 451, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("6fbc0c0f-2730-4044-a36f-c501d721244a"), "458", "малайзійський ринггіт", "109de907-f7b6-442b-85e9-9941992b7e70", new DateTime(2020, 8, 1, 17, 47, 0, 729, DateTimeKind.Local).AddTicks(6465), "Malaysia Ringgit", "MYR", "RM", new DateTime(2022, 3, 27, 18, 30, 37, 816, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("70b2a42d-a9b5-460f-99d4-a7542791bd59"), "784", "дирхам ОАЕ", "9001b6d0-4ea2-404d-bb7f-fabb4a3240b7", new DateTime(2021, 7, 12, 9, 34, 52, 667, DateTimeKind.Local).AddTicks(3374), "UAE-Dirham", "AED", "د.إ", new DateTime(2021, 12, 22, 0, 42, 22, 638, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("71b1c221-e521-4271-9543-02aa55547a01"), "860", "узбецький сум", "d16b10eb-eb30-4c3f-8c3a-cd1cad08f951", new DateTime(2017, 7, 20, 17, 22, 5, 646, DateTimeKind.Local).AddTicks(5721), "Uzbekistan Som", "UZS", "лв", new DateTime(2019, 3, 20, 10, 15, 12, 738, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("737bf46b-150d-4595-8a7d-0ed994e1ff74"), "410", "вона", "68674ec4-200c-486c-a3f9-e29419389ef8", new DateTime(2020, 10, 9, 9, 57, 37, 965, DateTimeKind.Local).AddTicks(4930), "Korea (South) Won", "KRW", "₩", new DateTime(2021, 7, 7, 20, 58, 22, 110, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("7613a69d-e875-48ef-b5c7-692f469f4477"), "533", "арубський флорин", "33ed60ae-072d-496e-9814-11f12c760bab", new DateTime(2019, 11, 7, 18, 1, 53, 283, DateTimeKind.Local).AddTicks(8767), "Aruba Guilder", "AWG", "ƒ", new DateTime(2020, 6, 4, 5, 25, 51, 179, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("763451c9-15c1-4036-82d6-a84224cfa034"), "682", "саудівський ріял", "c902b2d1-dcb9-4d4d-a3a9-a70f822b12cb", new DateTime(2022, 5, 25, 22, 13, 56, 498, DateTimeKind.Local).AddTicks(9697), "Saudi Arabia Riyal", "SAR", "﷼", new DateTime(2022, 6, 13, 10, 18, 36, 361, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("7b916a6b-2572-426e-a472-63097e58fb19"), "068", "болівіано", "3eebc367-c249-4ec8-aba5-b5e55fef9a22", new DateTime(2018, 4, 28, 14, 13, 21, 45, DateTimeKind.Local).AddTicks(5956), "Bolivia Bolíviano", "BOB", "$b", new DateTime(2020, 5, 25, 0, 28, 51, 756, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("7f076adf-d55f-4fe5-a5c9-7363589a28a3"), "946", "румунський лей", "292c1c98-78fb-4678-9a8e-47d317200220", new DateTime(2019, 4, 16, 5, 20, 20, 829, DateTimeKind.Local).AddTicks(1414), "Romania Leu", "RON", "lei", new DateTime(2022, 4, 21, 4, 20, 39, 110, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("843ee505-5c45-4c0c-bc25-93578ce5b1bb"), "756", "швейцарський франк", "84c3258a-7291-4961-abbd-d3858c1b012e", new DateTime(2018, 1, 18, 10, 36, 1, 885, DateTimeKind.Local).AddTicks(4308), "Switzerland Franc", "CHF", "CHF", new DateTime(2019, 7, 6, 11, 35, 45, 680, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("919d6be6-9cf1-470f-a398-8a4af399c39c"), "320", "кетсаль", "3dee5b0e-dc10-45a6-aad9-b5c370309836", new DateTime(2019, 8, 20, 20, 45, 37, 455, DateTimeKind.Local).AddTicks(8276), "Guatemala Quetzal", "GTQ", "Q", new DateTime(2021, 5, 19, 13, 33, 4, 77, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("990c569e-62c4-4da9-96f5-bf961aff4ff5"), "398", "теньге", "234f0d53-1348-4ac8-a838-8198518525f2", new DateTime(2021, 11, 13, 11, 48, 16, 135, DateTimeKind.Local).AddTicks(9471), "Kazakhstan Tenge", "KZT", "лв", new DateTime(2022, 1, 9, 11, 49, 55, 447, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a3425a60-c6a6-441d-8fd0-97e300cab524"), "422", "ліванський фунт", "3a345a13-2926-4ff8-b72d-f33e321f2ce3", new DateTime(2017, 12, 21, 0, 10, 41, 816, DateTimeKind.Local).AddTicks(7377), "Lebanon Pound", "LBP", "£", new DateTime(2018, 3, 23, 15, 25, 24, 151, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a55db9e8-5007-4fcc-8677-01b2c222b14e"), "975", "болгарський лев", "d2b9c28d-3c09-46a1-9f38-f9b9e989c7e6", new DateTime(2019, 5, 8, 13, 53, 6, 351, DateTimeKind.Local).AddTicks(4618), "Bulgaria Lev", "BGN", "лв", new DateTime(2019, 5, 16, 6, 54, 40, 75, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a6c55527-d276-41df-a7af-ad45cdf5d653"), "980", "гривня", "b18ebd7b-c646-491f-839e-6cd151cf86e0", new DateTime(2018, 12, 22, 5, 55, 14, 498, DateTimeKind.Local).AddTicks(4370), "Ukraine Hryvnia", "UAH", "₴", new DateTime(2021, 12, 29, 21, 32, 48, 137, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a70fc384-0f89-4a2b-833f-a178416fe9e5"), "191", "куна", "407b19e8-b931-4796-8077-12d0a2efbb4f", new DateTime(2019, 10, 19, 19, 47, 19, 172, DateTimeKind.Local).AddTicks(9357), "Croatia Kuna", "HRK", "kn", new DateTime(2022, 5, 4, 3, 15, 9, 391, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a8c01da6-f0ba-4b1e-9433-aa6c5e3764dd"), "985", "злотий", "4fcac18a-79c1-45ea-8079-66f2c12acaa8", new DateTime(2021, 12, 17, 19, 3, 52, 28, DateTimeKind.Local).AddTicks(8222), "Poland Zloty", "PLN", "zł", new DateTime(2022, 3, 17, 10, 54, 3, 708, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a9a61807-2f6e-490b-9d89-6cb9c0f370bf"), "072", "пула", "3648dd6b-bc12-4924-8025-5c702afba354", new DateTime(2022, 2, 20, 22, 23, 9, 196, DateTimeKind.Local).AddTicks(4600), "Botswana Pula", "BWP", "P", new DateTime(2022, 4, 2, 11, 48, 35, 210, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ad03e778-48dd-436d-8027-38e79fb392c5"), "702", "сінгапурський долар", "c78b84e3-ab81-44f2-aeec-ca98582f8701", new DateTime(2018, 10, 21, 4, 44, 3, 927, DateTimeKind.Local).AddTicks(5227), "Singapore Dollar", "SGD", "$", new DateTime(2020, 3, 22, 4, 10, 14, 638, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ad70d4fb-dd40-43da-9c6a-4d13b84c665a"), "858", "уругвайське песо", "f446b0e0-ec7c-4407-ab1c-81ef63fac5a2", new DateTime(2018, 11, 15, 9, 32, 5, 650, DateTimeKind.Local).AddTicks(6031), "Uruguay Peso", "UYU", "$U", new DateTime(2021, 8, 9, 13, 23, 36, 43, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ae15f987-43fb-450b-ab98-a6db225f7519"), "840", "долар США", "8dcc467e-261a-413f-a03a-6c6ff10c32ec", new DateTime(2021, 6, 10, 4, 20, 7, 230, DateTimeKind.Local).AddTicks(1223), "United States Dollar", "USD", "$", new DateTime(2022, 2, 21, 17, 9, 3, 475, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("b9fec0e3-91b9-4ce6-a6d1-d9b75de650e6"), "360", "рупія", "fea6167f-54a0-45b7-a3e5-60b79fef8a4a", new DateTime(2020, 8, 28, 19, 11, 54, 960, DateTimeKind.Local).AddTicks(7181), "Indonesia Rupiah", "IDR", "Rp", new DateTime(2022, 2, 21, 14, 11, 7, 138, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ba989e60-7c69-4efd-8101-5e5b4ea681b8"), "524", "непальська рупія", "838c8761-c7c8-4293-be02-cc99698ca599", new DateTime(2020, 7, 3, 14, 59, 17, 277, DateTimeKind.Local).AddTicks(6232), "Nepal Rupee", "NPR", "₨", new DateTime(2022, 6, 6, 17, 12, 2, 189, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c0c9ff01-1c9e-40c4-abb9-98d8b01f36fc"), "826", "фунт стерлінгів", "77c69f16-cb31-437d-902c-27436be8d873", new DateTime(2018, 8, 27, 1, 29, 42, 643, DateTimeKind.Local).AddTicks(6363), "United Kingdom Pound", "GBP", "£", new DateTime(2021, 1, 2, 0, 31, 36, 706, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c5172e85-a30c-4273-92d9-f3f4eaa972ad"), "376", "новий ізраїльський шекель", "48bdc6bb-aac8-4fdc-91a6-417c2b519ff6", new DateTime(2018, 1, 25, 22, 35, 11, 756, DateTimeKind.Local).AddTicks(7485), "Israel Shekel", "ILS", "₪", new DateTime(2021, 6, 22, 3, 36, 14, 544, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c5dc93c6-a9fa-4f66-a783-3e70f92b3b7d"), "512", "ріал Оману", "555224fd-789e-49af-9b6d-bb5fff9b7280", new DateTime(2018, 7, 6, 19, 4, 1, 677, DateTimeKind.Local).AddTicks(1923), "Oman Rial", "OMR", "﷼", new DateTime(2020, 2, 15, 6, 12, 47, 964, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c77b831c-93e0-410d-b71f-d04ee8b42d31"), "752", "шведська крона", "75314c83-3df9-4599-a9ac-7f1ffe21956b", new DateTime(2017, 8, 20, 13, 27, 41, 422, DateTimeKind.Local).AddTicks(3682), "Sweden Krona", "SEK", "kr", new DateTime(2020, 12, 3, 14, 7, 17, 146, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c8025a64-f4bc-4664-bf31-790372ac1c7f"), "764", "бат", "4064754d-1627-4ffe-9c0c-cd88e89a43d9", new DateTime(2020, 5, 1, 1, 52, 42, 147, DateTimeKind.Local).AddTicks(9197), "Thailand Baht", "THB", "฿", new DateTime(2020, 8, 3, 18, 57, 33, 65, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c9f705ee-d3bd-4b9d-a380-e0269a3fbd14"), "188", "костариканський колон", "84f12733-2e06-4464-858d-24de02cee167", new DateTime(2019, 2, 13, 17, 38, 22, 868, DateTimeKind.Local).AddTicks(5794), "Costa Rica Colon", "CRC", "₡", new DateTime(2022, 6, 13, 16, 51, 6, 686, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("d3fc46d1-2399-4cbc-b99e-bde1aca57c72"), "484", "мексиканське песо", "a325eda2-2501-4c61-a798-0923122a0ca4", new DateTime(2020, 7, 4, 17, 8, 40, 877, DateTimeKind.Local).AddTicks(2164), "Mexico Peso", "MXN", "$", new DateTime(2022, 3, 25, 18, 35, 39, 952, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("d888a886-d1cb-42e9-bad8-9cd0705b3db9"), "901", "новий тайванський долар", "8fd581ed-2d77-4918-a38e-0e58c4c28704", new DateTime(2019, 6, 27, 20, 50, 28, 953, DateTimeKind.Local).AddTicks(7825), "Taiwan New Dollar", "TWD", "NT$", new DateTime(2022, 2, 7, 19, 47, 26, 913, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("de4ed54e-e409-4aaf-a17e-9334d4d8e464"), "036", "австралійський долар", "4543ca3e-0625-413f-a319-fd85881c0b5f", new DateTime(2021, 8, 24, 18, 33, 20, 318, DateTimeKind.Local).AddTicks(2252), "Australia Dollar", "AUD", "$", new DateTime(2021, 11, 22, 0, 39, 33, 573, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("dfb924fa-495e-4212-a14c-118ebe1b44e7"), "951", "східнокарибський долар", "375c5865-be55-441e-9973-57721075f36a", new DateTime(2019, 2, 10, 1, 11, 37, 452, DateTimeKind.Local).AddTicks(5797), "East Caribbean Dollar", "XCD", "$", new DateTime(2022, 5, 11, 2, 19, 40, 37, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("e14abbd5-743b-4711-bfde-db9dbe3a400d"), "348", "форинт", "3de25edb-aef6-4ddf-8d93-fa52a2b36820", new DateTime(2018, 2, 1, 22, 42, 47, 0, DateTimeKind.Local).AddTicks(6080), "Hungary Forint", "HUF", "Ft", new DateTime(2019, 5, 17, 19, 59, 59, 257, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("e4d2e8fa-e3cd-49c4-b0d6-d623d27a966c"), "554", "новозеландський долар", "5acf91dd-6216-402f-b7a1-b43c1a075652", new DateTime(2018, 8, 25, 22, 59, 37, 470, DateTimeKind.Local).AddTicks(9889), "New Zealand Dollar", "NZD", "$", new DateTime(2021, 2, 11, 5, 28, 54, 648, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("e8f36678-de6c-4019-b71f-2a03c69a4bb0"), "590", "бальбоа", "f6906b36-f808-48fa-867a-53824da4561e", new DateTime(2021, 12, 27, 23, 26, 18, 149, DateTimeKind.Local).AddTicks(7552), "Panama Balboa", "PAB", "B/.", new DateTime(2022, 6, 10, 12, 34, 15, 766, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ea870d53-2dfb-4ee1-a136-c1953f9eab67"), "941", "сербський динар", "59e7a4d2-cb87-43ff-9d69-2da79cf8be44", new DateTime(2022, 4, 28, 13, 27, 13, 348, DateTimeKind.Local).AddTicks(1360), "Serbia Dinar", "RSD", "Дин.", new DateTime(2022, 5, 25, 9, 24, 6, 921, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("eb622b23-3577-4b9a-a9a5-c2e40b1e7364"), "242", "фіджійський долар", "f7c15c40-f6d0-4f32-8552-22c7ea58bfa4", new DateTime(2021, 2, 28, 0, 25, 3, 454, DateTimeKind.Local).AddTicks(7129), "Fiji Dollar", "FJD", "$", new DateTime(2022, 3, 17, 6, 42, 9, 105, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ec5789d7-8177-46c4-8bf9-f5e3c2d43850"), "710", "ренд", "591120e6-c899-4ed3-a20e-436817d3855a", new DateTime(2022, 3, 21, 10, 41, 8, 237, DateTimeKind.Local).AddTicks(3457), "South Africa Rand", "ZAR", "R", new DateTime(2022, 4, 18, 20, 33, 49, 811, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f079040f-0aa0-4042-8120-6d3c7405b6a7"), "032", "аргентинське песо", "a05c6b7c-bdc9-4601-b49a-fadce2877781", new DateTime(2022, 5, 30, 15, 9, 40, 168, DateTimeKind.Local).AddTicks(9438), "Argentina Peso", "ARS", "$", new DateTime(2022, 6, 12, 12, 2, 36, 882, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f14cdcc5-92c7-4c9f-be3f-525b20c26fbd"), "152", "чилійське песо", "eec1d105-7fc3-495f-8f7a-7fb2288d4946", new DateTime(2020, 3, 12, 7, 8, 37, 389, DateTimeKind.Local).AddTicks(830), "Chile Peso", "CLP", "$", new DateTime(2020, 9, 7, 6, 56, 49, 159, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f726130a-a240-40d6-8fd4-a1333f43bd7a"), "144", "рупія Шрі-Ланки", "6a70c404-3421-4d21-881d-08caf44c845a", new DateTime(2022, 4, 17, 1, 3, 33, 77, DateTimeKind.Local).AddTicks(7423), "Sri Lanka Rupee", "LKR", "₨", new DateTime(2022, 6, 11, 6, 26, 53, 47, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("fb73ead2-fae7-4538-8e32-b36f5bbb19a7"), "944", "азербайджанський манат", "b1800ab8-4e96-4193-9687-9944551dd598", new DateTime(2020, 3, 21, 3, 9, 38, 507, DateTimeKind.Local).AddTicks(5960), "Azerbaijan Manat", "AZN", "₼", new DateTime(2021, 3, 25, 17, 19, 27, 745, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("fba394e1-e413-41e3-925f-4ced67b9e39a"), "608", "філіппінське песо", "39947bd0-c32d-45df-a8a7-fbcf69912eb4", new DateTime(2019, 6, 28, 7, 53, 52, 743, DateTimeKind.Local).AddTicks(5626), "Philippines Peso", "PHP", "₱", new DateTime(2022, 3, 22, 17, 5, 29, 969, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("fcbcf5a6-d7f5-4a95-a7b8-17e6a28773c8"), "986", "бразильський реал", "d09afdcf-7ad7-4b3a-878f-c631631a4bdd", new DateTime(2020, 8, 16, 11, 22, 30, 195, DateTimeKind.Local).AddTicks(375), "Brazil Real", "BRL", "R$", new DateTime(2021, 2, 13, 19, 13, 10, 440, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("feaff150-fda6-4cb5-9201-dc4b61e86d0f"), "364", "іранський ріал", "19454705-2f96-4706-8e70-a5f1af4731ff", new DateTime(2019, 9, 24, 0, 54, 54, 872, DateTimeKind.Local).AddTicks(3869), "Iran Rial", "IRR", "﷼", new DateTime(2022, 2, 8, 8, 18, 33, 872, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ffd5a59d-87ba-4b00-8da4-d8adffa978aa"), "936", "ганське седі", "786d612b-5af6-4dd7-b7d9-760456f5a907", new DateTime(2018, 2, 27, 16, 10, 28, 409, DateTimeKind.Local).AddTicks(7797), "Ghana Cedi", "GHS", "¢", new DateTime(2018, 4, 30, 1, 35, 1, 279, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42e0b9b6-7c99-4e47-a083-755364fcb427"), "Aliquam quisquam quia incidunt inventore magnam.", "f05fe29f-04f3-49c4-9046-2896e726cf05", new DateTime(2020, 9, 9, 18, 6, 54, 292, DateTimeKind.Local).AddTicks(6644), "rejected", new DateTime(2021, 9, 29, 13, 26, 0, 562, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("51a1850a-e743-4843-a22e-cb24dd2f5676"), "Quae consequatur quo facilis pariatur illo itaque rerum officiis.", "7297915e-34f9-4cc3-9735-ac8cf8e29d0c", new DateTime(2020, 9, 14, 12, 49, 39, 82, DateTimeKind.Local).AddTicks(4708), "whaiting for paymetn", new DateTime(2022, 6, 5, 19, 0, 25, 529, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71b0dab7-674a-4abe-ae3d-951cbf9a03ff"), "Maxime sed illo.", "b76e758f-d1ce-4aa4-bbf5-2682d06d3efa", new DateTime(2019, 10, 30, 11, 31, 6, 722, DateTimeKind.Local).AddTicks(5003), "accepted", new DateTime(2022, 7, 4, 12, 22, 32, 384, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("817d580b-ee2f-4bed-b803-c0bf9bc50d45"), "Inventore aut dolores veritatis id adipisci quos.", "1f98fcde-6c75-4620-aadd-243711f6edc9", new DateTime(2018, 11, 23, 16, 11, 5, 238, DateTimeKind.Local).AddTicks(6511), "send", new DateTime(2020, 3, 20, 1, 56, 19, 193, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8da597fa-3a13-414a-9091-6376917847b5"), "Nihil molestias consectetur atque facere at.", "e379bb04-fd92-4f8d-bd56-9e01ef41077c", new DateTime(2017, 10, 14, 2, 13, 6, 281, DateTimeKind.Local).AddTicks(4699), "delivered", new DateTime(2018, 2, 6, 2, 41, 45, 543, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9fa5c731-0e8d-485c-a448-806a7b210009"), "Illum eum et neque veniam.", "4cf06453-aa7b-4f53-a19c-74489f672e20", new DateTime(2021, 7, 29, 6, 13, 39, 438, DateTimeKind.Local).AddTicks(9716), "new", new DateTime(2022, 6, 27, 14, 46, 17, 173, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1a0197af-c1e0-4a78-be0c-0067c6fa5399"), "Voluptate sit in inventore in et non.", "beb9ef62-c343-4851-bdeb-e64e3937eb36", new DateTime(2021, 11, 17, 7, 33, 49, 469, DateTimeKind.Local).AddTicks(4235), "send", new DateTime(2022, 2, 11, 23, 22, 9, 764, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f09c887-4557-4e70-961c-5fce5c34dd96"), "Eveniet qui quod maxime reprehenderit qui inventore.", "505ede8d-0d5b-4473-929d-64652d681dd5", new DateTime(2018, 10, 15, 11, 7, 26, 250, DateTimeKind.Local).AddTicks(8412), "rejected", new DateTime(2020, 7, 7, 13, 56, 5, 121, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("76d8984f-9bc4-4625-8b4a-97e0851d7c31"), "Temporibus cumque ducimus voluptatum nostrum harum provident.", "cc7acc9b-dd54-42a0-9565-7f870fb1445b", new DateTime(2022, 2, 14, 19, 24, 2, 671, DateTimeKind.Local).AddTicks(2526), "delivered", new DateTime(2022, 3, 22, 23, 37, 8, 370, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba755f8a-5bfc-4ebf-b60e-3f132f07df18"), "Quis at aut.", "4e24528c-71df-4ad1-b624-584a298cab23", new DateTime(2021, 11, 2, 14, 13, 33, 682, DateTimeKind.Local).AddTicks(2849), "accepted", new DateTime(2021, 12, 3, 15, 54, 58, 10, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dbf4e7e8-9699-4170-89d9-6c0bce298052"), "Quis aperiam nihil tenetur ut beatae ut accusamus quam.", "b8454fdb-8699-4bfe-b1bb-18e2d28d48f2", new DateTime(2020, 8, 25, 2, 16, 10, 117, DateTimeKind.Local).AddTicks(6599), "whaiting for paymetn", new DateTime(2022, 3, 21, 2, 32, 39, 136, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e331a013-2cd0-4a11-becc-1ad3865beb39"), "Quo ad vero aliquid assumenda.", "d8580217-1800-4536-90a5-c3a39c6309ae", new DateTime(2021, 5, 31, 8, 58, 25, 585, DateTimeKind.Local).AddTicks(5559), "new", new DateTime(2022, 5, 8, 3, 53, 13, 494, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01ad978c-7007-47fd-95e8-94dbca272f1d"), "Numquam aliquid sint.", "4c463b1b-1cc6-4b25-ba38-111d66aff399", new DateTime(2021, 7, 27, 8, 59, 9, 650, DateTimeKind.Local).AddTicks(2794), "Product quaity: omnis", new DateTime(2021, 9, 8, 12, 31, 14, 239, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01c5b4a6-baae-45a2-9cd1-6c2c67caff8f"), "Totam quis non aperiam omnis et est et ab.", "fbec005c-2f77-4711-afa7-f49fcd3ec09b", new DateTime(2019, 1, 13, 4, 56, 28, 421, DateTimeKind.Local).AddTicks(7111), "Product quaity: atque", new DateTime(2019, 1, 26, 11, 25, 9, 900, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0273f62e-a9b0-4b6b-80e8-8cd58790eb75"), "Vitae unde error alias.", "4fef1edc-5747-400b-92a2-cd3e45d9edf3", new DateTime(2018, 10, 30, 15, 34, 7, 541, DateTimeKind.Local).AddTicks(7072), "Product quaity: repellat", new DateTime(2019, 1, 21, 22, 16, 32, 616, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04f5f5d9-2857-40ef-85f5-2c032d037411"), "Officiis nesciunt labore ipsam soluta.", "3a9528e3-015f-46e8-9b0a-69b1c64f9394", new DateTime(2017, 11, 30, 16, 57, 23, 489, DateTimeKind.Local).AddTicks(9664), "Product quaity: enim", new DateTime(2022, 5, 26, 18, 19, 53, 476, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("064b50a0-8d5c-40cd-b934-72dbe03a81b8"), "Et et dolorum.", "8e134717-d076-4b75-b7ef-8f7222535e82", new DateTime(2021, 6, 7, 14, 15, 11, 20, DateTimeKind.Local).AddTicks(1835), "Product quaity: et", new DateTime(2022, 3, 31, 8, 45, 43, 393, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0b4e8860-60f4-4752-a86d-b08f4b20b731"), "Doloremque debitis a odio at debitis perferendis repellat.", "df176804-cb4d-4325-82d4-e9145e528669", new DateTime(2017, 10, 19, 21, 20, 39, 109, DateTimeKind.Local).AddTicks(3040), "Product quaity: magnam", new DateTime(2020, 1, 30, 23, 37, 51, 789, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0c6ad5b7-6cf7-4666-84db-5411c06139d6"), "Amet odio tenetur similique.", "9dede878-ba43-40f1-85a8-4174d4878940", new DateTime(2018, 3, 4, 6, 19, 41, 468, DateTimeKind.Local).AddTicks(8224), "Product quaity: voluptate", new DateTime(2020, 9, 13, 9, 4, 34, 599, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ff9b528-2e63-4cb6-86f1-2a2c40ed4bc9"), "Recusandae exercitationem provident doloremque voluptate id laborum eos aut.", "236c5df3-5578-49ce-933d-1d48856b2b53", new DateTime(2020, 7, 18, 9, 18, 18, 773, DateTimeKind.Local).AddTicks(556), "Product quaity: porro", new DateTime(2021, 11, 17, 10, 54, 30, 388, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("123f4f97-53bc-452f-95da-539063f25a97"), "Mollitia fuga enim consequatur et molestiae odit dicta ut et.", "6682c2b3-c1b5-4a2a-b2c9-04585735d381", new DateTime(2021, 12, 17, 14, 18, 27, 228, DateTimeKind.Local).AddTicks(4796), "Product quaity: laudantium", new DateTime(2022, 2, 3, 21, 29, 18, 139, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19661a69-5e56-4e97-b56f-699e82d32555"), "Odit sed quo est a ea qui totam consequatur.", "d5ae2537-16c4-48f9-afd8-2478821180d1", new DateTime(2017, 10, 27, 21, 43, 23, 242, DateTimeKind.Local).AddTicks(841), "Product quaity: ut", new DateTime(2019, 8, 4, 13, 36, 56, 765, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b85f084-8732-4226-85d0-d06773612444"), "Recusandae dolorem enim nostrum ipsam.", "d362dd34-8a6a-41ac-9875-a8d62344a900", new DateTime(2020, 12, 1, 19, 3, 13, 28, DateTimeKind.Local).AddTicks(211), "Product quaity: totam", new DateTime(2022, 4, 5, 19, 25, 38, 961, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ee81288-c72f-4c0c-89ce-ee688e4c94c9"), "Est rem rerum adipisci veniam porro dolorem nihil voluptas officiis.", "87d43de5-035b-4b6a-bca2-c1a2dd4f687f", new DateTime(2020, 12, 9, 9, 58, 11, 603, DateTimeKind.Local).AddTicks(5788), "Product quaity: quos", new DateTime(2022, 5, 8, 4, 35, 43, 421, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1fb187c7-8122-44bf-8a9d-4ae050637c02"), "Laudantium dolores porro voluptatibus.", "4964f5ce-dd92-4870-9093-8c9f3d8b75df", new DateTime(2021, 1, 11, 1, 28, 51, 972, DateTimeKind.Local).AddTicks(3783), "Product quaity: nisi", new DateTime(2022, 4, 18, 23, 34, 25, 792, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("21d145a2-4b05-4060-82ac-91dca5c2fe73"), "Cum eveniet impedit facilis amet.", "e3367865-451e-4541-82bb-f17c1ac65c7a", new DateTime(2020, 4, 13, 18, 33, 12, 629, DateTimeKind.Local).AddTicks(9612), "Product quaity: officiis", new DateTime(2020, 7, 16, 6, 50, 13, 182, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("234ea0fd-5e68-4025-9989-9abd01e0debe"), "Autem tempore dolores beatae culpa.", "c281b048-c78f-4104-afc4-f8e03ae6fd30", new DateTime(2017, 11, 4, 1, 52, 25, 374, DateTimeKind.Local).AddTicks(1428), "Product quaity: iusto", new DateTime(2021, 6, 17, 11, 46, 43, 834, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2399d062-2d01-4289-bca0-65e6b5b58d46"), "Temporibus nam tempore ducimus quidem ea nisi voluptates quod ut.", "c31bcd4d-3de8-4ad0-a7b7-83ac09044acb", new DateTime(2018, 6, 17, 3, 2, 49, 951, DateTimeKind.Local).AddTicks(6182), "Product quaity: consequuntur", new DateTime(2020, 1, 29, 19, 42, 21, 247, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24191075-98d4-4065-80b8-902882d677ca"), "Explicabo aut assumenda.", "8803539c-dffc-4c14-a00b-8560984b8b02", new DateTime(2022, 2, 21, 4, 22, 27, 691, DateTimeKind.Local).AddTicks(4754), "Product quaity: distinctio", new DateTime(2022, 5, 3, 11, 11, 48, 660, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("28b83acc-32fa-4d10-b46d-2f42b72a180a"), "Consectetur dolores dolores autem fugit voluptate.", "bfc60721-98b8-49c1-934b-0279caa529c3", new DateTime(2021, 7, 15, 2, 9, 14, 336, DateTimeKind.Local).AddTicks(7192), "Product quaity: fugiat", new DateTime(2022, 2, 22, 14, 34, 55, 207, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2d314852-a11c-41cd-89e4-cce7a2f101c8"), "Aut aut optio saepe.", "6572dd61-5705-4f69-a65a-d968e228975b", new DateTime(2019, 9, 29, 1, 12, 33, 691, DateTimeKind.Local).AddTicks(3779), "Product quaity: quisquam", new DateTime(2020, 11, 6, 13, 35, 42, 234, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2d7a3017-67e6-4b83-982b-fcd55f2364ae"), "Consequuntur sed aut porro veritatis error voluptates veniam.", "d3bcfcaf-1991-4451-9783-a2cc3558c915", new DateTime(2018, 6, 3, 14, 53, 20, 354, DateTimeKind.Local).AddTicks(3774), "Product quaity: corporis", new DateTime(2022, 5, 2, 21, 22, 11, 440, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31a19f4f-9370-4a5c-b28b-26791d2e2559"), "Ut nam totam minus voluptatem rem minima impedit.", "3e10a00a-a292-4492-9199-56580c44b737", new DateTime(2022, 6, 17, 13, 3, 40, 933, DateTimeKind.Local).AddTicks(8514), "Product quaity: reiciendis", new DateTime(2022, 7, 4, 12, 39, 52, 119, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32cbde2c-4956-43c9-980c-3a09459b4743"), "Atque qui consequatur nam aut.", "d6952519-c563-41af-aa49-59496c173e1e", new DateTime(2021, 5, 4, 10, 2, 57, 470, DateTimeKind.Local).AddTicks(5863), "Product quaity: dolor", new DateTime(2021, 7, 11, 18, 7, 51, 807, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3393ca84-e2de-464b-8aa0-4b0589c55f17"), "Accusamus quas molestias repudiandae dolorem tempora.", "6d47112f-a9c7-4d8a-9bb0-587da8b135e3", new DateTime(2018, 3, 13, 18, 20, 45, 59, DateTimeKind.Local).AddTicks(6160), "Product quaity: veritatis", new DateTime(2021, 10, 12, 13, 30, 11, 793, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("33f9a5c4-c44e-4879-a825-deae5be9be9e"), "Sed numquam veniam sit.", "dd963bdd-4601-4959-a897-91cf6a5357d0", new DateTime(2022, 2, 17, 0, 3, 57, 789, DateTimeKind.Local).AddTicks(7567), "Product quaity: possimus", new DateTime(2022, 5, 3, 21, 41, 49, 360, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34fd7360-60ae-45d5-8b31-a33d76f23313"), "Totam quo perspiciatis.", "16e58876-142b-4ea6-9836-b0e5316b41e8", new DateTime(2018, 10, 9, 13, 37, 54, 269, DateTimeKind.Local).AddTicks(2803), "Product quaity: facilis", new DateTime(2020, 12, 31, 6, 19, 35, 773, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3779a777-9651-4a4f-8501-0e0bb3517735"), "Labore sint necessitatibus id maiores explicabo quisquam quod.", "52d9b5fe-16dd-47a5-90e8-aafdeeba978b", new DateTime(2019, 5, 7, 3, 34, 24, 817, DateTimeKind.Local).AddTicks(2431), "Product quaity: consequatur", new DateTime(2021, 3, 18, 7, 41, 52, 446, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("400cf275-5b8f-46bd-a004-0bcb981b1797"), "Porro nihil sed dolores et unde expedita.", "7d30ad4a-812a-496b-905a-4456d1cd2739", new DateTime(2022, 7, 3, 0, 51, 49, 763, DateTimeKind.Local).AddTicks(7429), "Product quaity: aspernatur", new DateTime(2022, 7, 3, 23, 1, 57, 795, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47e730ac-fd1f-4a73-bb0c-223cd4f160e6"), "Minima eius praesentium optio velit ut voluptatem saepe illum vel.", "f760e771-bf7a-408b-b7a9-1e75c68e24aa", new DateTime(2020, 1, 30, 18, 16, 19, 111, DateTimeKind.Local).AddTicks(8722), "Product quaity: aliquam", new DateTime(2022, 6, 22, 0, 2, 54, 662, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("487ee25a-750a-4d7f-bf8f-4d8a1b4ecee1"), "Et recusandae magni sed tenetur quam.", "50f22994-b4c1-4d5a-b354-30a75dcd4879", new DateTime(2022, 5, 10, 23, 25, 26, 919, DateTimeKind.Local).AddTicks(376), "Product quaity: ut", new DateTime(2022, 5, 24, 17, 50, 14, 676, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4a98fe77-ceae-4742-8ab6-55a2a92f7e5c"), "Odit necessitatibus ea nulla.", "e636f473-5f03-43b5-b825-0ce5d2e889a4", new DateTime(2017, 11, 27, 11, 53, 44, 246, DateTimeKind.Local).AddTicks(6457), "Product quaity: quia", new DateTime(2020, 9, 26, 13, 33, 42, 76, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4ad9c349-e622-45ae-b604-ae8a230d9ab8"), "Ad voluptate labore dicta quam exercitationem quo assumenda.", "e074ad42-189b-4ae2-8f86-dc07df521413", new DateTime(2017, 11, 26, 8, 3, 51, 656, DateTimeKind.Local).AddTicks(8961), "Product quaity: et", new DateTime(2020, 7, 18, 13, 45, 23, 697, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4be50ca4-eb95-4fc4-ace1-f69a8a08e006"), "Illo ipsam rerum ex non eius ut quis.", "7ba487b8-5002-40f6-b070-eb7a427d3ce2", new DateTime(2020, 11, 21, 11, 20, 35, 264, DateTimeKind.Local).AddTicks(6062), "Product quaity: fugit", new DateTime(2021, 2, 9, 16, 3, 35, 700, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4d09d3ac-9f68-49d8-8f44-9cf230d0fad7"), "Itaque quibusdam dicta ea minus illum quaerat in minima qui.", "5821074d-c9f6-4940-86ba-9e7aa4fa259c", new DateTime(2021, 5, 27, 19, 55, 16, 266, DateTimeKind.Local).AddTicks(2053), "Product quaity: voluptates", new DateTime(2021, 7, 29, 3, 28, 5, 784, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4d679f33-27ac-4729-b0fb-f35e4dc07128"), "Aliquam praesentium est a quo optio amet iusto.", "e9254e54-7d41-456d-b951-ee1fb9a2e67c", new DateTime(2020, 1, 25, 3, 46, 20, 973, DateTimeKind.Local).AddTicks(3567), "Product quaity: ut", new DateTime(2021, 1, 16, 16, 44, 17, 871, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f41283b-a21e-4dfd-969c-f43fb438aa0f"), "Molestias occaecati labore eos aut voluptate eius aliquam.", "ce6de056-3a4f-4720-8f7e-e3bf5d987b26", new DateTime(2022, 4, 9, 15, 16, 36, 910, DateTimeKind.Local).AddTicks(1554), "Product quaity: quidem", new DateTime(2022, 6, 12, 10, 47, 4, 341, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("513e8a9f-0c21-4073-92d2-fae8c6e78db4"), "Dolor veritatis sed tenetur at tempora eligendi ad nam.", "e0909605-7341-471d-ac2d-80a1b5cafc4f", new DateTime(2019, 8, 26, 13, 49, 7, 5, DateTimeKind.Local).AddTicks(9514), "Product quaity: incidunt", new DateTime(2022, 3, 6, 20, 25, 40, 17, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52014fe1-bcb1-41bf-9396-be3acdf0a452"), "Officia sequi sed quidem exercitationem autem asperiores animi animi.", "2205ad9b-532a-4c9a-b1be-97a2a4f8fc40", new DateTime(2020, 11, 29, 1, 6, 46, 148, DateTimeKind.Local).AddTicks(7306), "Product quaity: exercitationem", new DateTime(2021, 7, 31, 12, 29, 3, 644, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("541f70fb-9be2-4940-9ff7-5af5f854a0f7"), "Natus omnis adipisci sit ipsam.", "997c1be1-426b-4aa7-a32a-787507b5f983", new DateTime(2022, 5, 24, 13, 33, 31, 820, DateTimeKind.Local).AddTicks(8105), "Product quaity: distinctio", new DateTime(2022, 6, 28, 3, 9, 54, 156, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59ad7860-54b4-426e-a9a7-5c2798e9368c"), "Porro quia nostrum voluptatem vero commodi nam qui.", "0a0730da-a891-49e9-933e-b1e27d1d6b58", new DateTime(2018, 2, 1, 21, 20, 13, 950, DateTimeKind.Local).AddTicks(8112), "Product quaity: doloremque", new DateTime(2020, 8, 24, 0, 43, 55, 675, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("63d078de-75e0-4f78-95c3-06522d0c76e4"), "Officia dolores ipsa repudiandae.", "ccab5d27-8187-4d27-a44d-a9be6343db54", new DateTime(2018, 1, 13, 11, 55, 22, 72, DateTimeKind.Local).AddTicks(8730), "Product quaity: rerum", new DateTime(2019, 6, 8, 17, 30, 13, 788, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6413b097-2c04-4c82-ba65-7695771514e6"), "Accusamus voluptatem provident.", "db18e09f-e9ac-46f0-bb74-cb558dd38e55", new DateTime(2018, 4, 18, 13, 33, 4, 811, DateTimeKind.Local).AddTicks(3300), "Product quaity: nemo", new DateTime(2019, 1, 23, 21, 13, 40, 409, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("64c5065e-25d9-4695-a79b-a83d30c6d16a"), "Voluptatem ratione soluta nihil blanditiis aut aliquam culpa.", "2289b973-ba43-4434-ace8-03cc1e7e5728", new DateTime(2017, 7, 9, 6, 3, 20, 596, DateTimeKind.Local).AddTicks(6413), "Product quaity: provident", new DateTime(2021, 5, 1, 3, 55, 38, 46, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65331762-58dc-45d2-a658-6ea5610f29bc"), "Praesentium corporis rerum nisi reprehenderit sunt rerum placeat occaecati odit.", "d4264060-7fe1-45a3-ba29-0310f26bb328", new DateTime(2019, 1, 12, 17, 40, 36, 515, DateTimeKind.Local).AddTicks(6300), "Product quaity: maiores", new DateTime(2022, 1, 31, 19, 46, 36, 954, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("658d6e62-2cc5-4e33-8704-23522dbe1083"), "Voluptatum fuga consequuntur molestiae et illo quam dolores.", "1c76caad-07ae-448e-bbaf-d45b2013527a", new DateTime(2017, 9, 19, 9, 50, 7, 404, DateTimeKind.Local).AddTicks(2767), "Product quaity: natus", new DateTime(2017, 11, 5, 1, 42, 40, 101, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("675c490a-113a-4178-a551-b6eff275cd79"), "Enim ut nobis est.", "8e6214e4-4167-4d8e-b1ef-6c6d411919b5", new DateTime(2021, 6, 2, 9, 50, 12, 385, DateTimeKind.Local).AddTicks(436), "Product quaity: amet", new DateTime(2021, 9, 29, 5, 48, 1, 499, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a0e1be8-c8ff-4288-9adc-52bb147affd4"), "Neque id et laboriosam explicabo nemo hic quis.", "65b619a3-692a-4706-ac20-7bcf3ceedf0f", new DateTime(2019, 1, 30, 11, 5, 11, 688, DateTimeKind.Local).AddTicks(5027), "Product quaity: quaerat", new DateTime(2022, 5, 6, 12, 4, 21, 55, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b5932e3-26bd-40f0-8156-72838b15fd22"), "Odit nemo saepe consequatur ad.", "0754d899-98ae-406d-834c-f1568723304e", new DateTime(2019, 5, 15, 8, 52, 33, 721, DateTimeKind.Local).AddTicks(284), "Product quaity: et", new DateTime(2019, 6, 27, 4, 54, 29, 90, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6f1eeb7c-a3b5-4295-aebc-29ccad479b61"), "Facere quos ipsa tempore pariatur ducimus impedit illo aliquam delectus.", "81f46daf-297c-4c5f-a8ed-bbae09139512", new DateTime(2017, 9, 2, 17, 14, 49, 251, DateTimeKind.Local).AddTicks(1324), "Product quaity: aut", new DateTime(2021, 8, 31, 22, 16, 48, 245, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("706a0ffe-f1e1-4917-b193-d4c35a63cac1"), "Illo earum porro iure et earum recusandae temporibus placeat quia.", "12af5b9e-4d34-4fdb-a523-17814c8555ce", new DateTime(2022, 4, 16, 20, 57, 59, 986, DateTimeKind.Local).AddTicks(2879), "Product quaity: voluptatum", new DateTime(2022, 4, 18, 12, 24, 39, 451, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7173a4bb-3c46-421b-b7b9-8b293480241e"), "Accusamus aut dolorem praesentium culpa in sed nesciunt quia.", "bf2c933e-72e4-4f93-b418-250e44fd236d", new DateTime(2021, 1, 21, 11, 52, 22, 880, DateTimeKind.Local).AddTicks(8359), "Product quaity: qui", new DateTime(2021, 5, 7, 1, 42, 25, 86, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("730a87dc-2c49-4eca-af6c-149f97e917af"), "In commodi quis qui voluptas ipsum mollitia iure est.", "f1df705d-54b0-4c2d-899b-f3cab1525437", new DateTime(2017, 12, 26, 19, 7, 37, 865, DateTimeKind.Local).AddTicks(7181), "Product quaity: est", new DateTime(2021, 1, 7, 2, 9, 37, 825, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("775666de-55a8-4220-9550-d16af1a6c4ed"), "Fugiat consequatur dolorum ratione deleniti.", "bc81b111-3c26-471d-a5f7-b0877a5e1ff3", new DateTime(2017, 12, 17, 18, 20, 1, 946, DateTimeKind.Local).AddTicks(1868), "Product quaity: non", new DateTime(2022, 1, 31, 11, 30, 41, 917, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("827d08de-97a6-45b5-9442-1c068265740e"), "Consectetur et iste quam autem reprehenderit.", "19a22ea6-5869-43dd-9e24-daabc203ee67", new DateTime(2017, 12, 1, 3, 34, 34, 210, DateTimeKind.Local).AddTicks(8008), "Product quaity: accusamus", new DateTime(2019, 12, 20, 8, 48, 51, 314, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86b636e5-4e50-4b03-b572-1518e3890ee8"), "Repellat numquam sed ab eos in impedit dignissimos dolorem.", "980dd85b-90bb-4349-8ac5-58b09f33727f", new DateTime(2021, 6, 30, 18, 20, 47, 860, DateTimeKind.Local).AddTicks(8672), "Product quaity: molestiae", new DateTime(2021, 12, 5, 20, 45, 59, 23, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9bd4ffe8-a49d-4f0e-bb0a-ec82d6650f84"), "Rem placeat ea dignissimos.", "15b1868d-2a12-47db-80b9-d16aff62f996", new DateTime(2020, 1, 6, 18, 47, 1, 108, DateTimeKind.Local).AddTicks(3839), "Product quaity: sapiente", new DateTime(2020, 12, 7, 11, 49, 58, 226, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d75d072-39c8-4f36-83ab-cfe1c8f2f18f"), "Quo veritatis iure accusantium deleniti qui porro.", "2fdc68d4-b075-4691-8c53-cc05e1e36129", new DateTime(2020, 8, 10, 4, 23, 17, 975, DateTimeKind.Local).AddTicks(9439), "Product quaity: blanditiis", new DateTime(2021, 7, 20, 7, 56, 50, 375, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e01775b-1517-4861-ab3a-796ba15f4c25"), "Unde nihil fuga aut nulla consequatur.", "116d988d-93c6-47ee-b86c-0fa349f1dd00", new DateTime(2017, 10, 14, 3, 43, 42, 865, DateTimeKind.Local).AddTicks(2771), "Product quaity: ipsa", new DateTime(2018, 8, 15, 1, 38, 5, 997, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e36bb45-6a2f-40b9-bf5d-0bd0ec5f7513"), "Sit repudiandae neque debitis ut nostrum nihil voluptates vero.", "800321ee-fec1-4831-b58d-2afa495ea717", new DateTime(2017, 12, 3, 3, 28, 41, 874, DateTimeKind.Local).AddTicks(9524), "Product quaity: et", new DateTime(2019, 4, 12, 13, 33, 17, 131, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a04f8c5d-74b7-4587-9e51-2e8143fe933e"), "Libero aut beatae.", "c74624d7-acc7-434a-84ed-5f1ae4f6dda0", new DateTime(2021, 2, 19, 22, 34, 22, 693, DateTimeKind.Local).AddTicks(2286), "Product quaity: quaerat", new DateTime(2022, 3, 18, 4, 21, 35, 653, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a133a7b2-edee-4b46-9545-da55eccb7943"), "Iusto laborum quod molestias.", "059dcaff-29cf-4267-a504-8ef397262049", new DateTime(2019, 2, 21, 13, 45, 12, 55, DateTimeKind.Local).AddTicks(3886), "Product quaity: exercitationem", new DateTime(2021, 12, 28, 19, 49, 46, 517, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2706d07-5f40-4d24-869e-76e16631adf9"), "Blanditiis recusandae aperiam id placeat voluptatem.", "47579712-9ab8-46ff-82f6-aac258f37681", new DateTime(2020, 4, 4, 16, 12, 25, 229, DateTimeKind.Local).AddTicks(9595), "Product quaity: inventore", new DateTime(2020, 4, 5, 1, 31, 38, 457, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2abf683-5df7-4a22-985a-fb3bda630da8"), "Totam maxime veniam hic.", "175c007c-54b4-4899-8460-eb0f34c977e2", new DateTime(2017, 8, 31, 8, 30, 54, 408, DateTimeKind.Local).AddTicks(2299), "Product quaity: autem", new DateTime(2021, 5, 10, 8, 3, 54, 379, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a3a884f8-1045-45f0-b23a-d25e1cd2b0aa"), "Et inventore dolorem nihil in.", "6e873967-1194-4762-b343-43da2921c121", new DateTime(2021, 2, 4, 2, 58, 46, 378, DateTimeKind.Local).AddTicks(4885), "Product quaity: cumque", new DateTime(2021, 8, 25, 0, 54, 33, 905, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a78d0157-6ebf-4cbf-b26f-bae7b78c7001"), "Maxime aut velit.", "1dfc4906-7cc3-4e80-ab29-6bc3c5565ca3", new DateTime(2017, 12, 16, 13, 0, 30, 746, DateTimeKind.Local).AddTicks(4848), "Product quaity: omnis", new DateTime(2018, 7, 7, 5, 43, 52, 873, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae8cb128-6751-4b2c-8469-c36e390229df"), "Quas veniam non eum aut ratione odit.", "f22a63b7-e453-4704-a36c-4e3e2c69c808", new DateTime(2018, 6, 23, 6, 45, 35, 452, DateTimeKind.Local).AddTicks(3274), "Product quaity: deserunt", new DateTime(2021, 3, 14, 14, 23, 40, 940, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae8de582-861f-44e4-9f02-ad8850ed16da"), "Quidem voluptas corrupti omnis placeat ipsa repellat ut itaque.", "e5ea6c71-484b-4946-b79e-5d7fe637ef35", new DateTime(2022, 3, 4, 9, 2, 27, 356, DateTimeKind.Local).AddTicks(2892), "Product quaity: est", new DateTime(2022, 3, 13, 15, 39, 29, 541, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aed77700-11ca-4720-8554-c49289f8f68a"), "Assumenda quibusdam nulla culpa.", "a3c4ed66-9003-402b-8ace-0f80d5b9a8ad", new DateTime(2021, 7, 5, 18, 37, 4, 562, DateTimeKind.Local).AddTicks(6540), "Product quaity: beatae", new DateTime(2022, 5, 7, 16, 4, 41, 548, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b247ef90-318c-4272-90d5-6a409a2b2f06"), "Magnam soluta et iusto ex fugit iste.", "490b0bf8-ac9d-4e31-8866-fb7778971835", new DateTime(2022, 6, 14, 23, 3, 5, 62, DateTimeKind.Local).AddTicks(4655), "Product quaity: corrupti", new DateTime(2022, 6, 30, 11, 30, 5, 984, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9532dfa-fbc9-42ae-9c2b-3c8e4f5b9c66"), "Non voluptatem quia labore quos est sint.", "5a5d933a-05f3-46c6-878c-6b3b9acff6fa", new DateTime(2022, 4, 16, 20, 3, 49, 630, DateTimeKind.Local).AddTicks(7230), "Product quaity: quae", new DateTime(2022, 6, 12, 8, 29, 2, 602, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9dc67bc-91f1-453c-8483-e42804a06b09"), "Distinctio deleniti saepe omnis numquam eveniet iste aut debitis.", "d5c6ae06-7aec-40b7-912a-9b6f2b9d90c8", new DateTime(2020, 4, 1, 15, 3, 47, 452, DateTimeKind.Local).AddTicks(4568), "Product quaity: consequatur", new DateTime(2021, 8, 5, 8, 5, 54, 774, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba1f40bd-3b27-4abe-975a-bf97b301c8b3"), "Assumenda sunt non illo dolorum est voluptatem architecto et.", "7125ff04-cc0e-4c95-bb75-a1aadd85921f", new DateTime(2021, 1, 12, 3, 25, 8, 790, DateTimeKind.Local).AddTicks(6952), "Product quaity: rem", new DateTime(2021, 3, 5, 3, 54, 41, 344, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc67726a-e639-4385-8b41-704d2d176f63"), "Sit consectetur vel.", "3098c81a-800a-4b65-8fdd-52da3be97310", new DateTime(2019, 10, 2, 14, 44, 44, 40, DateTimeKind.Local).AddTicks(2210), "Product quaity: magnam", new DateTime(2022, 5, 3, 1, 36, 46, 125, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd45b0df-140a-4b03-b3df-5637a5820ccd"), "Necessitatibus optio sint molestias sint.", "cfc03da9-980e-4412-a632-056031dd5f26", new DateTime(2019, 11, 2, 7, 52, 36, 203, DateTimeKind.Local).AddTicks(3607), "Product quaity: quod", new DateTime(2021, 10, 19, 5, 12, 42, 510, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0190189-c73a-490c-84de-cece45f72103"), "Et dolores optio quia id eos.", "e19a7946-9ba8-495b-bfd4-6f6ef6438f65", new DateTime(2017, 12, 18, 8, 45, 5, 574, DateTimeKind.Local).AddTicks(9528), "Product quaity: quas", new DateTime(2019, 2, 6, 5, 31, 7, 183, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0ac9e66-359d-4310-8302-32b44777cf2d"), "Impedit et qui dolores.", "5a237a1b-5a54-4b50-8f6e-86fa4362aee9", new DateTime(2020, 12, 7, 9, 24, 21, 620, DateTimeKind.Local).AddTicks(2612), "Product quaity: est", new DateTime(2021, 4, 3, 17, 13, 27, 185, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c808424d-f8bc-49df-9d25-b53b0d950865"), "Earum doloremque atque ipsam ratione non reiciendis nemo aut facere.", "1db3db31-2f6d-48f8-abc4-132871dc27d0", new DateTime(2020, 3, 23, 20, 53, 35, 522, DateTimeKind.Local).AddTicks(1758), "Product quaity: vel", new DateTime(2021, 9, 17, 15, 11, 31, 492, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ca390f19-1c29-474d-a4b2-3d92f641f0d8"), "Temporibus totam voluptatum quae eligendi sit.", "0f978ae5-48e1-43f6-a66c-9920d3a57fc2", new DateTime(2020, 5, 19, 20, 15, 39, 981, DateTimeKind.Local).AddTicks(3048), "Product quaity: et", new DateTime(2021, 9, 1, 6, 46, 57, 877, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ca59678c-f3c6-48b8-849d-7a94cafd46d3"), "Repellat exercitationem autem eos aut est possimus ea voluptatem molestiae.", "632e2056-c8c2-4340-886c-17e2abe2abe3", new DateTime(2020, 7, 26, 3, 46, 28, 723, DateTimeKind.Local).AddTicks(3062), "Product quaity: sapiente", new DateTime(2022, 2, 6, 19, 22, 55, 707, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cdf7fdde-13f0-4211-843a-7648a07d93c3"), "Impedit iste odio quo.", "6690bd68-68a7-41a0-a515-29b19b8451a6", new DateTime(2022, 6, 25, 2, 43, 41, 583, DateTimeKind.Local).AddTicks(8045), "Product quaity: laudantium", new DateTime(2022, 7, 2, 9, 6, 28, 651, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d2790546-84c9-4f07-bd14-f8b80320badc"), "Itaque sint magnam et dolorum saepe aut.", "bbf607bd-d1a2-4f5e-854b-697ef9562a82", new DateTime(2020, 4, 30, 14, 7, 56, 407, DateTimeKind.Local).AddTicks(515), "Product quaity: vel", new DateTime(2022, 4, 28, 2, 43, 14, 675, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d3c7b2c5-5e08-4d3f-92c9-20e9cc275ff3"), "Reprehenderit et suscipit aut amet consequuntur repudiandae dolor quis.", "37974b4f-2594-486b-922e-1714657da59f", new DateTime(2021, 5, 25, 6, 29, 55, 637, DateTimeKind.Local).AddTicks(3948), "Product quaity: in", new DateTime(2021, 10, 28, 20, 29, 55, 280, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d43e788a-4d08-4ea4-bd1a-9e7054341e82"), "Eaque autem laboriosam delectus aut qui itaque.", "09673a52-4ec6-4751-a32a-9b789029c71b", new DateTime(2020, 2, 22, 3, 11, 38, 983, DateTimeKind.Local).AddTicks(3709), "Product quaity: qui", new DateTime(2022, 1, 23, 20, 50, 42, 539, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d790b5bd-f70b-4906-8ac5-4cbc8eb15cd1"), "Eligendi ab aspernatur deleniti omnis rem rem.", "424217a6-0f14-42fb-be52-1cd8490f2688", new DateTime(2017, 7, 10, 15, 13, 13, 495, DateTimeKind.Local).AddTicks(2582), "Product quaity: qui", new DateTime(2018, 2, 9, 12, 8, 11, 657, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d82216f5-42a0-4ef1-952c-51f206492ec0"), "Exercitationem assumenda sit.", "fc4fd0e4-14bb-448a-b76b-6a8944f7b52b", new DateTime(2021, 11, 16, 14, 25, 27, 294, DateTimeKind.Local).AddTicks(4606), "Product quaity: non", new DateTime(2022, 2, 27, 5, 51, 28, 260, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8d2d8f3-97bc-40c3-aafd-50922d57d6da"), "Suscipit aut sed sed.", "b1b9ad64-b134-4ed2-8c7d-3eba295be67a", new DateTime(2017, 10, 21, 12, 46, 3, 67, DateTimeKind.Local).AddTicks(2198), "Product quaity: possimus", new DateTime(2021, 9, 25, 15, 58, 50, 63, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9e235cc-a0ab-4b16-a9c3-82694755c1c1"), "Inventore nihil est sint voluptatum.", "aaf30fac-6fd5-445b-bbe4-48672922f803", new DateTime(2022, 4, 6, 5, 8, 25, 494, DateTimeKind.Local).AddTicks(5125), "Product quaity: provident", new DateTime(2022, 4, 9, 15, 15, 26, 96, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("daf3e6d7-3df3-4215-bd94-bc8d7bbfcb29"), "Occaecati id nemo.", "8bbf70c9-69ef-459c-bf45-f63069938ba3", new DateTime(2020, 8, 27, 4, 1, 11, 764, DateTimeKind.Local).AddTicks(4567), "Product quaity: vel", new DateTime(2021, 7, 16, 15, 46, 26, 585, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dd7fd4a8-65ab-4c83-bc77-f75b3ba4dbf8"), "Distinctio et sint hic saepe.", "95ee68e2-c72d-4643-b2c9-f1fdbc1e4718", new DateTime(2018, 5, 12, 19, 20, 23, 785, DateTimeKind.Local).AddTicks(6638), "Product quaity: corporis", new DateTime(2020, 4, 1, 20, 16, 55, 944, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1b6ebfd-6deb-477d-a49b-0d5fdaf348c5"), "Quae explicabo velit quas.", "85d59166-cbea-4ac1-9b7c-d1a4b1d04ca7", new DateTime(2019, 12, 30, 12, 12, 1, 131, DateTimeKind.Local).AddTicks(4314), "Product quaity: possimus", new DateTime(2020, 11, 1, 22, 11, 50, 995, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2107b29-99bd-433e-be5c-32ea5cae9b16"), "Ullam vero quo labore magnam.", "fbd616f4-c556-4dc0-a4f1-f931dcbfdb0a", new DateTime(2021, 4, 29, 18, 41, 17, 151, DateTimeKind.Local).AddTicks(2419), "Product quaity: voluptates", new DateTime(2022, 3, 22, 5, 34, 23, 848, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2dc4dc6-0e99-4b21-8ab7-6da8a8d49cff"), "Quisquam nesciunt in doloribus quia harum maxime.", "659425ee-91b6-4fbb-b9f1-abac32c1590c", new DateTime(2019, 4, 23, 20, 40, 1, 869, DateTimeKind.Local).AddTicks(6650), "Product quaity: quidem", new DateTime(2019, 8, 13, 8, 31, 37, 653, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2e003a0-d94c-47e4-9bc1-56cf0bb56a50"), "Dolorem vero sed quo quia.", "cff4062c-03e3-48a4-9365-365394c0c0f1", new DateTime(2021, 2, 7, 0, 21, 35, 882, DateTimeKind.Local).AddTicks(4309), "Product quaity: deserunt", new DateTime(2022, 4, 29, 0, 33, 58, 95, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3a7e61b-97cb-45f5-a275-5a18780a4a6f"), "Dolorem sed ullam ipsum et impedit in.", "a6ace4fc-9265-4776-9338-8ef9ac2351f8", new DateTime(2021, 10, 1, 0, 7, 53, 745, DateTimeKind.Local).AddTicks(7083), "Product quaity: quae", new DateTime(2022, 6, 21, 6, 18, 10, 64, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eb27b18b-56c6-4b12-8d76-cf64a87bd9c3"), "Est natus omnis dicta sed ea.", "2ee08ab2-e015-4361-bb75-10c9cd40f6ea", new DateTime(2020, 2, 14, 1, 20, 52, 703, DateTimeKind.Local).AddTicks(8027), "Product quaity: maiores", new DateTime(2020, 9, 1, 4, 56, 48, 961, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec3cb8db-69f0-46a7-a3db-995e1a51653b"), "Architecto id dolor reprehenderit aut in.", "a66378a4-4adc-424b-8a51-8a19e0bf7742", new DateTime(2020, 6, 27, 3, 7, 17, 256, DateTimeKind.Local).AddTicks(199), "Product quaity: officia", new DateTime(2022, 5, 10, 3, 8, 55, 489, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef0cc6fc-0f54-4d30-b8a8-4308319aea62"), "Qui tempore non sit quo eveniet consequatur molestias.", "788b9d68-536c-4fa3-80ab-9ce46492d9dc", new DateTime(2019, 7, 7, 21, 2, 52, 49, DateTimeKind.Local).AddTicks(7122), "Product quaity: soluta", new DateTime(2020, 11, 25, 23, 29, 41, 454, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef684080-0e6b-43a8-95e2-c4e50628cde8"), "Occaecati omnis sed nostrum velit ut nihil deleniti dolor.", "e33cf674-dde8-4635-baad-72d124fac4c2", new DateTime(2018, 8, 22, 2, 28, 2, 718, DateTimeKind.Local).AddTicks(4851), "Product quaity: et", new DateTime(2021, 2, 25, 19, 22, 3, 23, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("efd0b3e0-004b-4695-bd0c-886b22860cb9"), "Sapiente voluptatem deleniti.", "0625a6dd-e8f9-4fff-9cf0-e2765e449db6", new DateTime(2021, 12, 6, 17, 0, 39, 263, DateTimeKind.Local).AddTicks(3400), "Product quaity: dolore", new DateTime(2022, 2, 6, 18, 33, 31, 95, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f17d9bc7-aeb2-4994-ae70-2f58535f5596"), "Sit in quibusdam asperiores quae hic vero dolorem.", "0d1c58d0-223e-407d-9dc4-8b434d77bb7e", new DateTime(2017, 9, 3, 13, 39, 4, 88, DateTimeKind.Local).AddTicks(9929), "Product quaity: magni", new DateTime(2018, 11, 5, 23, 52, 54, 419, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fd640549-35b3-435a-91cf-cc9207781448"), "Repellendus laboriosam et.", "54a89cdf-8935-4446-850f-e8775a0f6f07", new DateTime(2018, 6, 9, 7, 58, 59, 325, DateTimeKind.Local).AddTicks(1817), "Product quaity: accusantium", new DateTime(2021, 12, 25, 18, 19, 38, 487, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("000ffd39-84d0-48a9-9aba-c2bfbba32eb4"), "Consequatur veniam incidunt voluptatem qui et odio sed.", "b6516c08-ed5d-48e9-ab30-95a10f6fefa7", new DateTime(2019, 2, 18, 19, 37, 21, 457, DateTimeKind.Local).AddTicks(8659), "Organization Larson LLC", new DateTime(2019, 11, 14, 21, 57, 17, 387, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01300bad-c4e0-4afd-9839-f182bf0a8740"), "Eveniet nulla voluptas neque dolores eos molestias recusandae.", "47b1d1f6-a2ed-4846-93a6-8f5e08d90133", new DateTime(2017, 10, 1, 3, 53, 6, 922, DateTimeKind.Local).AddTicks(3914), "Organization Rutherford - Kihn", new DateTime(2021, 8, 11, 12, 3, 54, 268, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04176834-f217-42ea-be5f-9b00b1682863"), "Eius enim dolore.", "8ec4d468-f9b6-48f0-b06f-6172ef7dceb9", new DateTime(2020, 1, 8, 16, 16, 10, 266, DateTimeKind.Local).AddTicks(7364), "Organization Robel - Krajcik", new DateTime(2021, 2, 23, 7, 53, 21, 566, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07a0c543-220c-42e1-80a4-4665f90305df"), "Quidem velit provident non qui itaque iusto.", "a4dfcd61-74dd-4f6c-b49e-0b65c885c902", new DateTime(2021, 2, 23, 0, 27, 0, 927, DateTimeKind.Local).AddTicks(5738), "Organization Bosco, Stokes and Hyatt", new DateTime(2021, 4, 20, 1, 14, 25, 277, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0987b37e-7b29-44f8-8289-c46771419da0"), "Quibusdam repellendus quo veritatis repellendus ut dolores et.", "b2c353cf-5c4c-42b8-a63c-506900acdd5d", new DateTime(2019, 1, 5, 1, 54, 55, 243, DateTimeKind.Local).AddTicks(4249), "Organization Huel, Ratke and Hane", new DateTime(2019, 3, 29, 21, 49, 24, 678, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a8a2635-4864-4520-8279-69b3db496436"), "Commodi facilis eum architecto et voluptatem qui.", "f6f81d87-39f8-4c1d-a607-aacdadcc7a43", new DateTime(2021, 4, 19, 7, 46, 7, 620, DateTimeKind.Local).AddTicks(9078), "Organization Labadie - Hintz", new DateTime(2021, 7, 25, 18, 30, 44, 813, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0bf68205-495f-4b29-8da7-73c34372cceb"), "Vel enim ea qui dolores.", "9623a7b8-124c-439f-b081-5a1a9053a51a", new DateTime(2018, 12, 18, 3, 52, 3, 694, DateTimeKind.Local).AddTicks(6052), "Organization Cremin Inc", new DateTime(2021, 5, 21, 9, 38, 5, 257, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0c2d1c29-3c8d-432f-b43a-27d08ddfdce2"), "Dolor earum ratione cum excepturi est assumenda sequi.", "b570099c-5512-49fd-a451-d3ce24ed8a01", new DateTime(2018, 5, 5, 0, 45, 23, 859, DateTimeKind.Local).AddTicks(7511), "Organization Erdman - Wisozk", new DateTime(2022, 1, 20, 10, 34, 31, 97, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ccac8c0-f1b7-4aa6-b293-9cc323fc17b3"), "Vel voluptatem neque non sit assumenda quia iste iste.", "27a50fed-aa7c-41a8-841b-71e16e6876f3", new DateTime(2019, 6, 30, 22, 35, 3, 724, DateTimeKind.Local).AddTicks(5927), "Organization Strosin - Muller", new DateTime(2022, 3, 17, 7, 59, 11, 935, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12b7b5fa-2667-4321-ab45-dcff2e09dab7"), "Error id quisquam autem in rerum dolorum.", "61100842-9c5c-4452-a60b-8139c100d3c5", new DateTime(2020, 7, 24, 14, 4, 7, 417, DateTimeKind.Local).AddTicks(3073), "Organization Huel Inc", new DateTime(2021, 1, 7, 17, 57, 40, 37, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("13010e30-94ce-4b41-aeba-023132c5bf22"), "Quia voluptatem commodi mollitia iusto tenetur consectetur.", "d0b83e5a-f5c0-45fd-9e7c-e48accb61b9c", new DateTime(2020, 4, 20, 0, 15, 14, 46, DateTimeKind.Local).AddTicks(2244), "Organization Ondricka, Ryan and Wolff", new DateTime(2022, 2, 11, 2, 41, 37, 743, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("177edcd3-9303-4531-ae1c-d6aad83d80f4"), "Culpa laudantium et.", "97370a1d-6185-41f7-a385-c6e30441f6b3", new DateTime(2020, 5, 31, 1, 14, 45, 866, DateTimeKind.Local).AddTicks(3946), "Organization Auer Group", new DateTime(2020, 10, 25, 23, 10, 48, 499, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2033a047-6828-4da9-b2fe-f2da83877625"), "Dicta qui qui quidem.", "f737faee-b7db-4f89-85b9-1316191aa93c", new DateTime(2018, 8, 2, 22, 46, 14, 781, DateTimeKind.Local).AddTicks(4674), "Organization Mills - Grant", new DateTime(2019, 2, 8, 1, 24, 35, 607, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2c074acf-1fd9-4901-9253-0c082449eb7e"), "A et ut ullam et reiciendis ipsum rerum.", "86320c98-31ab-4953-8011-82b260594b03", new DateTime(2020, 4, 26, 15, 15, 50, 378, DateTimeKind.Local).AddTicks(7464), "Organization O'Keefe, Hermann and Deckow", new DateTime(2021, 3, 11, 11, 44, 37, 789, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e398e79-3128-4728-9256-61b4dce9672b"), "Eum dolores fugiat.", "5794289e-cf2b-4ec5-a1fe-e96a6769e671", new DateTime(2020, 2, 13, 5, 43, 50, 568, DateTimeKind.Local).AddTicks(21), "Organization Torp and Sons", new DateTime(2020, 11, 11, 9, 6, 51, 350, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f2e9675-7a37-43d0-8765-cff46d390eb4"), "Quae sit saepe illum est amet aut quasi modi eligendi.", "1d13b95b-259b-4573-b991-cfc6384e4aae", new DateTime(2018, 9, 17, 16, 55, 39, 466, DateTimeKind.Local).AddTicks(3421), "Organization Shanahan - Gibson", new DateTime(2021, 10, 14, 11, 13, 5, 149, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31b96f02-fa6d-4d2b-9a09-071c769b85a3"), "Et repellendus beatae.", "dbc52a23-2a23-4ce2-8eb2-0539a90a26b3", new DateTime(2018, 5, 29, 22, 18, 15, 900, DateTimeKind.Local).AddTicks(2076), "Organization Schumm Group", new DateTime(2021, 8, 23, 13, 2, 36, 111, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38d6fb6c-2789-4a6a-a4ba-2673a4315bde"), "Non magnam ea sint corrupti iusto.", "aaaa24ec-c0f5-4ebb-8c8d-c233b71e186c", new DateTime(2017, 7, 31, 11, 4, 45, 45, DateTimeKind.Local).AddTicks(4078), "Organization Grady, McKenzie and Kovacek", new DateTime(2021, 9, 28, 10, 44, 55, 130, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("39d854e8-a018-49cb-8ebd-47601d0250ff"), "Ut sint alias qui corporis magnam occaecati sit qui.", "ca058494-33f0-4a91-b54a-78c9e2cd9329", new DateTime(2021, 9, 4, 4, 13, 42, 405, DateTimeKind.Local).AddTicks(1269), "Organization Rice Group", new DateTime(2021, 12, 30, 14, 3, 46, 503, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a176434-67ae-4b1b-916b-55d5c0685afc"), "Libero corrupti iusto.", "a64914a1-c0df-439e-917c-3c7d02a9df3f", new DateTime(2020, 10, 21, 3, 54, 2, 169, DateTimeKind.Local).AddTicks(8493), "Organization Jakubowski - Collier", new DateTime(2022, 5, 18, 10, 1, 44, 251, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d08f585-68da-4c91-bcb2-367488b642c9"), "Repellat et repellat necessitatibus tempore.", "0e03f5ef-cb9d-413d-95ea-5480b5ba3e50", new DateTime(2017, 10, 29, 6, 20, 8, 174, DateTimeKind.Local).AddTicks(5926), "Organization Gulgowski Inc", new DateTime(2020, 6, 19, 0, 14, 33, 874, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e7c69ce-c2e6-433d-b7b6-7e3aebbfafae"), "Ratione unde reprehenderit cumque.", "4f4c1b96-ac3f-4593-b63d-fd8f210eea30", new DateTime(2022, 4, 4, 20, 39, 0, 841, DateTimeKind.Local).AddTicks(5726), "Organization Jakubowski, Wunsch and Ritchie", new DateTime(2022, 7, 2, 14, 53, 23, 583, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e94e4da-d9ad-422a-bfdc-6746df53b37a"), "Itaque expedita totam ad quis esse magni quia.", "204b9f35-444e-459f-9f73-257284f2f66d", new DateTime(2021, 11, 14, 21, 54, 28, 447, DateTimeKind.Local).AddTicks(1914), "Organization Steuber - Corwin", new DateTime(2021, 11, 19, 22, 55, 22, 355, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3eae161a-0a42-4b44-a62e-17669b0bf497"), "Esse magnam fugit saepe et hic odio dicta.", "fd4beada-dcbf-4960-912a-2f1c88d5c360", new DateTime(2019, 10, 29, 9, 51, 27, 740, DateTimeKind.Local).AddTicks(4418), "Organization Reichert, Dach and Hayes", new DateTime(2022, 4, 29, 11, 48, 22, 549, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f6e8de5-f8c0-424c-8f0e-52cc1c12ba8c"), "Suscipit illum magnam officiis tenetur possimus eveniet eius numquam.", "0800131f-e8e0-4fde-95de-fc3724ddd20d", new DateTime(2020, 4, 29, 2, 25, 23, 993, DateTimeKind.Local).AddTicks(7529), "Organization Larkin - Muller", new DateTime(2021, 4, 27, 14, 55, 57, 445, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("40c4d73b-8e68-4130-8264-e9389c7a4417"), "Sed quo rerum molestias.", "c21a340f-d2d3-49ca-bce9-733e93a04cd2", new DateTime(2021, 8, 29, 6, 6, 49, 411, DateTimeKind.Local).AddTicks(9389), "Organization Sporer Group", new DateTime(2021, 10, 13, 21, 6, 35, 384, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("445cb1c6-b4c2-4c69-9310-12fce49817ae"), "Veritatis vero vel eum et suscipit et itaque eligendi.", "02410264-bb5b-46bc-8fbf-a6e8565db817", new DateTime(2018, 1, 20, 6, 41, 1, 804, DateTimeKind.Local).AddTicks(8530), "Organization Spinka Group", new DateTime(2021, 3, 5, 10, 28, 53, 197, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47d58a09-5e17-4c46-937c-aa05c48b03ab"), "Commodi sequi quia quasi tenetur pariatur ea alias.", "6800112e-a810-459c-bf7b-f35ea7321c8f", new DateTime(2022, 6, 20, 18, 36, 21, 306, DateTimeKind.Local).AddTicks(6969), "Organization Jast - Reilly", new DateTime(2022, 6, 23, 0, 48, 52, 864, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4a6b412b-61b3-413d-8b75-30ee5712dfb9"), "Dolore neque impedit id itaque ducimus id sequi consequatur.", "ee34ff6c-7e6f-4b0d-9874-71f700936f1c", new DateTime(2019, 11, 3, 0, 10, 22, 719, DateTimeKind.Local).AddTicks(5696), "Organization Durgan, Bechtelar and Wilkinson", new DateTime(2021, 7, 16, 6, 23, 46, 481, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4cdd8cb3-e808-4671-81f8-e5a226c837f8"), "Quis perferendis quia ad sed pariatur occaecati provident facilis.", "a6b52e7b-f48a-4ba6-ab57-10fc39fde7c4", new DateTime(2020, 7, 28, 13, 58, 30, 182, DateTimeKind.Local).AddTicks(5943), "Organization Spencer, Luettgen and Kiehn", new DateTime(2020, 9, 15, 15, 35, 9, 354, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f32f880-76b3-4d22-88f2-6381c18bbc79"), "Aut accusantium et iusto sit.", "de7d79d2-33a1-43d0-9980-48224d87785c", new DateTime(2021, 12, 20, 1, 24, 4, 163, DateTimeKind.Local).AddTicks(9808), "Organization Simonis Group", new DateTime(2022, 5, 21, 5, 48, 23, 522, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a33c6e6-0aae-43ca-955a-f20f80248b9c"), "Consectetur in facilis incidunt et sunt suscipit placeat.", "9614b08a-e42a-410f-b9d0-ab67e5f85c60", new DateTime(2021, 12, 14, 2, 39, 14, 544, DateTimeKind.Local).AddTicks(3194), "Organization Kuhn Group", new DateTime(2022, 1, 13, 1, 26, 3, 900, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5addff49-5da4-42b0-94db-ae9ae4668a28"), "Consectetur odit minus sint similique corrupti laborum consequatur qui minus.", "f19a619b-87ef-494a-94b5-96a9e6a1f621", new DateTime(2022, 1, 4, 13, 1, 34, 332, DateTimeKind.Local).AddTicks(1842), "Organization Mraz - Ritchie", new DateTime(2022, 5, 10, 19, 55, 11, 425, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c81d293-81b3-45d1-ad0a-93efa42abec9"), "Minus fuga cumque voluptatem eum sequi ut incidunt.", "2b1f1b07-1274-49a5-9476-90c498fd8ab5", new DateTime(2021, 7, 8, 6, 7, 30, 933, DateTimeKind.Local).AddTicks(8854), "Organization Feil LLC", new DateTime(2021, 11, 11, 0, 48, 16, 242, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d237e17-8fc8-42dc-93cc-83ed2cc693cc"), "Omnis similique autem consectetur reprehenderit fuga.", "19a33dce-8e88-40c0-be35-3387a313e2ae", new DateTime(2017, 8, 13, 23, 42, 17, 309, DateTimeKind.Local).AddTicks(9075), "Organization Ondricka, Kerluke and Wuckert", new DateTime(2020, 12, 9, 2, 32, 46, 753, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("681ec0f0-eb77-4566-bee8-90f0f11c03e4"), "Nam distinctio nemo aspernatur sint ut eveniet molestias.", "de2dd522-0aeb-4f1d-96d7-03b8e2ec95b1", new DateTime(2017, 8, 10, 6, 14, 49, 603, DateTimeKind.Local).AddTicks(5629), "Organization Roob - Farrell", new DateTime(2017, 12, 14, 11, 27, 48, 12, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a17784e-6464-490d-b920-13050834fb19"), "Similique rem fugit voluptatem sed aut sed reprehenderit.", "098d5918-4026-4a9c-a892-379f68817578", new DateTime(2020, 8, 22, 5, 17, 8, 750, DateTimeKind.Local).AddTicks(5824), "Organization Wolff Group", new DateTime(2020, 9, 9, 18, 39, 24, 900, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a44ad29-b27b-45e8-ab48-c9091d0c4d00"), "Quia tenetur iste at.", "ad80c94f-0db4-4508-bf2f-9a815058f5e4", new DateTime(2021, 2, 9, 1, 8, 8, 59, DateTimeKind.Local).AddTicks(9386), "Organization Haag - Stehr", new DateTime(2021, 8, 1, 10, 42, 24, 865, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c91c9e6-734a-4696-87b0-0218b310b361"), "Vitae qui magni excepturi.", "670ae1a0-a9db-4ba8-9cd9-90ae80db2895", new DateTime(2018, 9, 18, 15, 50, 49, 162, DateTimeKind.Local).AddTicks(2926), "Organization Leffler LLC", new DateTime(2019, 10, 6, 8, 56, 40, 224, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6fd907fe-5b28-4a18-a291-1faf715e106f"), "Suscipit tempore deserunt ut id odit vitae est aspernatur animi.", "e56b2c6e-fa8c-442a-a00a-045e4d5e4fc4", new DateTime(2019, 11, 26, 13, 23, 50, 586, DateTimeKind.Local).AddTicks(8089), "Organization Gibson, Hane and Jenkins", new DateTime(2020, 8, 29, 1, 13, 21, 347, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("723acd90-8710-4cb5-be48-e89eda383cdf"), "Commodi dicta dolores repudiandae illum.", "59f96775-97d3-43ca-8e25-bfa53be3959c", new DateTime(2019, 8, 16, 7, 55, 53, 140, DateTimeKind.Local).AddTicks(7513), "Organization Waters LLC", new DateTime(2022, 6, 17, 9, 10, 1, 571, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72dd0e77-adce-4bfb-9ad2-852605a7e164"), "Velit laborum voluptas sit et omnis.", "7a372e59-5601-46d7-80b7-470a22c28dc5", new DateTime(2019, 9, 12, 16, 6, 50, 36, DateTimeKind.Local).AddTicks(777), "Organization Little LLC", new DateTime(2021, 3, 26, 13, 33, 20, 978, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74381ea8-09d3-4613-9b8e-0f6db557e95c"), "Totam sed doloremque ipsam est libero.", "289be879-d95e-486a-a10d-5b19dc63e9ef", new DateTime(2017, 11, 19, 2, 12, 28, 766, DateTimeKind.Local).AddTicks(4802), "Organization Flatley and Sons", new DateTime(2020, 7, 6, 20, 58, 13, 122, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7491c93c-5d6f-4266-b8a0-b0ec42debf66"), "Numquam omnis vel quo iure perspiciatis a perspiciatis tenetur ea.", "f53f1b14-faf3-4f71-abe7-cc11ab7b43a0", new DateTime(2017, 8, 1, 19, 42, 22, 921, DateTimeKind.Local).AddTicks(7527), "Organization Wiegand, Beier and Barton", new DateTime(2022, 1, 2, 2, 39, 37, 101, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b35a6c8-ed0e-498d-9f82-a8229cd108c4"), "Dolores ut minus cum.", "11265be0-7a99-41c6-a77b-16d4eb1540e6", new DateTime(2018, 2, 4, 6, 41, 53, 229, DateTimeKind.Local).AddTicks(7928), "Organization Price LLC", new DateTime(2020, 1, 5, 10, 3, 12, 57, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b7eb59e-afaf-430c-bc36-accb2696352a"), "Earum quia voluptatum eum.", "6d655a14-889a-4951-ba9a-fe9d929a210d", new DateTime(2017, 10, 13, 10, 31, 49, 825, DateTimeKind.Local).AddTicks(6624), "Organization Bashirian - Ruecker", new DateTime(2019, 9, 22, 13, 49, 28, 840, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("81451b6b-50cb-4a20-a870-c71a29720fe1"), "Veniam itaque neque consequatur sunt deleniti.", "0bf7440c-e7a2-4156-b0d8-f5635d96d214", new DateTime(2020, 5, 7, 17, 20, 28, 186, DateTimeKind.Local).AddTicks(6393), "Organization Bayer LLC", new DateTime(2021, 12, 4, 18, 21, 44, 771, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("821c9cf1-aadd-4bf9-b9d9-ef80592a6a1e"), "Unde neque et eius ullam numquam et quaerat accusamus magni.", "8d8df7c7-d127-4536-80e3-81f014b29320", new DateTime(2020, 4, 3, 1, 0, 11, 777, DateTimeKind.Local).AddTicks(8455), "Organization Berge - Schmitt", new DateTime(2020, 10, 21, 18, 41, 0, 71, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("83da2d76-cf44-4449-aabd-5f958e898abb"), "Quaerat nihil sed labore quasi placeat voluptates.", "4b2b7733-f976-4e86-bb63-1923ffd62f3b", new DateTime(2022, 2, 15, 13, 49, 50, 224, DateTimeKind.Local).AddTicks(9733), "Organization McDermott, Kreiger and Pacocha", new DateTime(2022, 2, 21, 21, 59, 45, 427, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("861499da-865d-4419-8850-da9418272344"), "Vitae quis sed et temporibus.", "5bc8150b-9f2f-422b-9bbe-e5e1791bfb7f", new DateTime(2022, 1, 30, 13, 6, 50, 610, DateTimeKind.Local).AddTicks(4692), "Organization Bogan - Torphy", new DateTime(2022, 3, 23, 23, 10, 52, 922, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("88f64b34-8add-4613-a2ca-d74c2ccc18cc"), "Nemo sed quae tempora reiciendis consequuntur magnam magni.", "09e990f8-bde9-4316-a58c-06d680bcd23e", new DateTime(2018, 7, 7, 6, 38, 34, 606, DateTimeKind.Local).AddTicks(1270), "Organization Bogan - Koelpin", new DateTime(2022, 3, 14, 5, 36, 18, 5, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8994f78d-5541-4925-8222-7034149599c1"), "Quas sit a debitis quia rerum cumque animi esse quia.", "1284a012-2a33-496f-bb77-d83279316dfc", new DateTime(2018, 3, 11, 10, 48, 25, 849, DateTimeKind.Local).AddTicks(6232), "Organization Mueller, Swift and Terry", new DateTime(2019, 4, 15, 5, 3, 25, 132, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9378533c-d23f-4054-8a6a-79b5d8008646"), "Nesciunt illo minima molestias corporis quo natus sit at est.", "30162a62-5b00-4d71-a220-1d6e12c8d81f", new DateTime(2021, 4, 29, 11, 19, 50, 453, DateTimeKind.Local).AddTicks(4159), "Organization Altenwerth - Gorczany", new DateTime(2022, 5, 12, 7, 26, 43, 278, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94ba9dad-ea77-4a4d-9002-158e8d5342b5"), "Fugiat omnis qui tempore.", "6a36dcca-2cc0-4fae-8686-882d0008de32", new DateTime(2017, 10, 24, 16, 46, 26, 295, DateTimeKind.Local).AddTicks(8310), "Organization Rutherford, Corkery and Abshire", new DateTime(2018, 2, 28, 5, 28, 15, 136, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97bf9140-afad-4f18-a9af-251c7477c172"), "Quidem velit et impedit iusto.", "d0e29752-b4c5-496d-84ff-14eb5d0c1dc9", new DateTime(2017, 11, 12, 19, 27, 2, 895, DateTimeKind.Local).AddTicks(7500), "Organization Marvin - Feeney", new DateTime(2019, 5, 14, 22, 15, 26, 303, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("999c8a7b-7f5c-47d4-a95b-11d5dd40b522"), "Vero nesciunt autem est animi.", "589337dc-0462-4e09-a892-89800172e76c", new DateTime(2022, 6, 20, 4, 40, 53, 398, DateTimeKind.Local).AddTicks(7021), "Organization Bogisich - O'Conner", new DateTime(2022, 7, 2, 6, 27, 11, 324, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99caf9ba-6e86-4fd7-afc9-0a356c0d4961"), "Totam ab et repudiandae molestiae dignissimos.", "c7ee82a3-253c-439b-a611-7bd3cb6fb561", new DateTime(2020, 5, 30, 0, 9, 57, 108, DateTimeKind.Local).AddTicks(3209), "Organization Johnson LLC", new DateTime(2022, 3, 23, 9, 40, 10, 94, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99e8d9fa-3332-45cc-a797-d0bcc60828ff"), "Ullam quia asperiores ut est facilis magnam dolore.", "bb871c97-ca93-452e-803f-c14b0fa6d3c7", new DateTime(2021, 11, 2, 12, 50, 38, 570, DateTimeKind.Local).AddTicks(5464), "Organization Schmeler LLC", new DateTime(2022, 2, 26, 9, 16, 16, 996, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a34bdd1-5c73-43c9-8411-6be53b97f3e7"), "Aspernatur tempora labore.", "b2d9c637-7f9c-4d3f-86f5-841f1e8081d4", new DateTime(2017, 7, 26, 13, 25, 6, 329, DateTimeKind.Local).AddTicks(466), "Organization Green Inc", new DateTime(2018, 1, 16, 18, 37, 25, 814, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d8e90ec-1e72-4bcc-9a64-9b01fbc666be"), "Dolores minima provident fugit.", "d481aa0d-c423-4d9b-9146-5e4379a38ec9", new DateTime(2018, 2, 28, 11, 41, 30, 429, DateTimeKind.Local).AddTicks(4188), "Organization Buckridge, Kreiger and Mraz", new DateTime(2018, 5, 20, 18, 7, 6, 624, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a0d2ef84-cd3e-4d1f-a7c3-6780c679afa6"), "Aut ullam omnis natus quia.", "03b0d468-b509-4dd3-bd82-470caddfad52", new DateTime(2021, 6, 14, 8, 11, 33, 780, DateTimeKind.Local).AddTicks(118), "Organization Sipes Inc", new DateTime(2021, 9, 18, 0, 33, 22, 818, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a1ba9577-4701-4d7b-8de6-7abe9f791c24"), "Non dolor cupiditate ut expedita facilis voluptatem vero.", "be9e1d86-f04a-4ec8-bf16-d2f4440b00c7", new DateTime(2019, 4, 7, 18, 7, 8, 689, DateTimeKind.Local).AddTicks(5060), "Organization Mayert, Fadel and Kreiger", new DateTime(2021, 2, 26, 11, 56, 50, 837, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a429e6ac-545e-464e-9502-d1cd2a4d9bb6"), "Provident dolores ea tempora voluptatem sunt eius nihil.", "1925e194-bcf8-4cff-ab27-dbb34423730e", new DateTime(2019, 3, 1, 7, 58, 3, 257, DateTimeKind.Local).AddTicks(6335), "Organization Wiegand, Jacobs and Gerhold", new DateTime(2020, 3, 28, 15, 17, 42, 180, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7856999-a30a-4992-81a2-d93b17f89ed6"), "Ut nostrum repudiandae.", "16397cb2-36b8-4a15-91af-6b5fcadb270b", new DateTime(2019, 8, 23, 13, 14, 47, 185, DateTimeKind.Local).AddTicks(1944), "Organization Waelchi Inc", new DateTime(2022, 4, 13, 20, 47, 12, 167, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a81debfc-3ca0-41a4-a59a-f5403324be61"), "Asperiores fugit expedita numquam blanditiis vel rerum porro.", "7e1c91e3-970c-4795-bf9e-74296ca4663d", new DateTime(2019, 6, 27, 9, 20, 37, 990, DateTimeKind.Local).AddTicks(3861), "Organization VonRueden Inc", new DateTime(2022, 4, 2, 2, 41, 55, 326, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9607397-914d-473e-a7fd-d3ed6493c73f"), "Ut fugiat dicta ducimus est sint eum error.", "a57295ca-a835-4fde-bc9b-9a39879387bb", new DateTime(2019, 1, 16, 22, 56, 34, 252, DateTimeKind.Local).AddTicks(6062), "Organization VonRueden, Ritchie and Armstrong", new DateTime(2020, 3, 21, 14, 58, 57, 935, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa69adfc-aa74-4f13-8407-c61a21bce62e"), "Eveniet at ut reprehenderit totam dolore minima.", "21fa7f6e-2633-42c8-9868-dd3e01fc42c7", new DateTime(2019, 11, 24, 9, 40, 12, 525, DateTimeKind.Local).AddTicks(5670), "Organization Upton Inc", new DateTime(2020, 12, 2, 1, 29, 13, 346, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa8a4f95-0429-4678-bf66-5a44c89abd4e"), "Qui assumenda veniam.", "e5d242f4-9e91-4ddb-8e39-0fd56e4b5ffe", new DateTime(2020, 8, 18, 3, 30, 55, 28, DateTimeKind.Local).AddTicks(9983), "Organization Crist - Harber", new DateTime(2021, 12, 18, 17, 17, 6, 158, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b27c8a88-44bd-41b1-93ff-787a9d81cde7"), "Consequatur occaecati sed officiis voluptatem alias qui dolor necessitatibus.", "41bdc1f5-2c05-4686-ada7-b98257af5663", new DateTime(2020, 1, 30, 20, 6, 48, 169, DateTimeKind.Local).AddTicks(3124), "Organization Langosh - Jacobi", new DateTime(2022, 5, 25, 17, 42, 23, 842, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b69a28fc-44fc-4205-bca5-f955902abdb9"), "In culpa sit reprehenderit sit sit qui ut et.", "ae57f764-9be5-4207-958b-81107632f192", new DateTime(2020, 3, 26, 14, 19, 12, 544, DateTimeKind.Local).AddTicks(8102), "Organization Wuckert LLC", new DateTime(2021, 1, 6, 4, 44, 58, 93, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb77d287-5d39-4059-a564-a8a41e44204a"), "Fugit aut dicta harum hic veniam consequatur distinctio.", "72f920d6-fc93-43a1-bee5-f0140b067cee", new DateTime(2020, 1, 30, 17, 19, 56, 249, DateTimeKind.Local).AddTicks(2626), "Organization Murazik - Lindgren", new DateTime(2020, 7, 3, 9, 53, 10, 55, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb98cdc6-bf16-4773-b20f-d2668a9a763c"), "Accusantium natus sit qui cum quia laudantium dolores iusto.", "d98566dd-9309-4b67-9922-62e28a9b4e75", new DateTime(2017, 11, 16, 18, 29, 44, 838, DateTimeKind.Local).AddTicks(7122), "Organization Stark, Cruickshank and Toy", new DateTime(2019, 3, 27, 0, 2, 9, 846, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0353f39-10f9-4c34-93a0-5562af16dfb8"), "Provident sed quo tempora.", "bce70758-8ff4-4adf-aa79-bb3eadafff15", new DateTime(2019, 12, 31, 11, 29, 51, 599, DateTimeKind.Local).AddTicks(7956), "Organization Batz, Bechtelar and Dooley", new DateTime(2021, 8, 2, 5, 55, 50, 901, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1d94b83-0cf6-4e9b-a69b-79c424a951ae"), "Voluptatibus iusto nisi ut enim.", "b22794f5-ad42-4ed6-9d4d-ecaf8261db50", new DateTime(2018, 11, 27, 6, 44, 39, 212, DateTimeKind.Local).AddTicks(2670), "Organization Runte, Bins and Larkin", new DateTime(2022, 4, 18, 20, 36, 11, 440, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7dbf03e-b8f5-4215-80de-182a1ff4e76b"), "Odit voluptatem et dignissimos dolor deserunt error.", "bdd9bae5-ea6e-43a8-b6e9-69c178f27f8a", new DateTime(2017, 12, 7, 22, 6, 35, 574, DateTimeKind.Local).AddTicks(3854), "Organization Bogan - Reichel", new DateTime(2019, 12, 3, 10, 33, 24, 861, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c834c297-a9fd-4d22-83a7-b7635c4cfc62"), "Sapiente est facilis qui possimus laboriosam reprehenderit rerum.", "98b16039-246a-473e-92f0-10f2359f13e7", new DateTime(2020, 1, 25, 17, 20, 24, 236, DateTimeKind.Local).AddTicks(7424), "Organization Bins LLC", new DateTime(2021, 6, 9, 11, 52, 49, 26, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c9384526-26c9-4760-95e1-20fd010e1cdf"), "Perspiciatis omnis provident fugiat exercitationem veniam.", "20ef490c-1dfd-4287-b716-9d9262499ccd", new DateTime(2018, 11, 7, 0, 43, 33, 47, DateTimeKind.Local).AddTicks(5689), "Organization Green - Price", new DateTime(2021, 11, 7, 9, 23, 4, 625, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cbc26377-18e8-4735-b732-770d1df5b254"), "Quam qui enim eos.", "7abe6928-ceed-4df2-b19b-695e457f9b11", new DateTime(2017, 8, 6, 18, 22, 43, 981, DateTimeKind.Local).AddTicks(7728), "Organization Lang, Smitham and Jerde", new DateTime(2020, 3, 1, 4, 42, 39, 856, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf140b54-a9b8-468c-bc69-d9bf460d2d8c"), "Qui eum sit repellat repellendus autem.", "3562ae71-7451-4966-a7fa-a22deb431f9d", new DateTime(2020, 12, 21, 5, 25, 20, 809, DateTimeKind.Local).AddTicks(7068), "Organization Weimann, Fay and Hagenes", new DateTime(2020, 12, 31, 1, 27, 2, 399, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cfab2627-0f9e-4c57-a666-56d1b8f3e97c"), "Illo amet numquam.", "d87910af-86ca-493c-822c-6067bbf8119b", new DateTime(2020, 11, 18, 12, 39, 45, 978, DateTimeKind.Local).AddTicks(9106), "Organization Windler Inc", new DateTime(2022, 3, 26, 14, 7, 7, 192, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d10c4ae6-f496-4d17-bfa3-1e4f1d8e6732"), "Aut iusto quam quis nihil.", "704dc559-2295-4878-bc1a-cf43a4b791da", new DateTime(2020, 2, 10, 2, 23, 43, 894, DateTimeKind.Local).AddTicks(668), "Organization Schroeder - Dietrich", new DateTime(2020, 4, 13, 1, 58, 50, 804, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1642fe5-598d-477f-bc3d-abf532f75b8c"), "Nesciunt veritatis ex odit deleniti.", "603834e7-0839-43d2-aed8-3d17a9593cf4", new DateTime(2018, 4, 22, 8, 20, 37, 794, DateTimeKind.Local).AddTicks(9486), "Organization Kiehn, Wiza and Auer", new DateTime(2019, 4, 11, 20, 25, 26, 300, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d29049d0-99bf-419b-b3cf-39aaad442fe2"), "Rerum aliquid error autem autem ut ipsa odit voluptatem impedit.", "dfae76b0-8ad3-40cb-9ea0-2db5e11ce0bc", new DateTime(2018, 3, 29, 18, 50, 16, 804, DateTimeKind.Local).AddTicks(7523), "Organization Kshlerin Inc", new DateTime(2019, 3, 7, 20, 3, 42, 463, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d52a85a2-e332-4de9-8aea-79aeb9759a5a"), "Nesciunt nihil a aut aut.", "93dfd496-f2a3-431e-b9a5-bf6a29cf2319", new DateTime(2022, 1, 7, 2, 55, 59, 608, DateTimeKind.Local).AddTicks(5707), "Organization Maggio, Keebler and Kling", new DateTime(2022, 4, 5, 20, 48, 42, 584, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8ebfe98-4d6e-430a-969b-08470b77c9f9"), "Dolorem sit ut vel aut earum tempora voluptatum voluptas incidunt.", "832ed9d7-39a4-4465-95d6-466ff6c17c2b", new DateTime(2021, 3, 23, 20, 13, 19, 454, DateTimeKind.Local).AddTicks(2014), "Organization Block - Daniel", new DateTime(2022, 2, 10, 3, 38, 36, 712, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9e131a3-08c9-4c2b-a4b8-2bd60af20789"), "Enim ab aut repellat ea omnis omnis maiores iure.", "1f6e5fb2-2d8a-42d2-a59f-8c0c064f13be", new DateTime(2021, 10, 2, 23, 35, 54, 361, DateTimeKind.Local).AddTicks(4047), "Organization Bernier LLC", new DateTime(2022, 5, 3, 5, 5, 30, 986, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db44c422-ddbd-4064-9d83-94ae81531e20"), "Hic qui qui unde adipisci quibusdam animi in omnis.", "7df50ba0-9a74-4456-bc00-18649e0945ae", new DateTime(2021, 2, 23, 13, 16, 25, 764, DateTimeKind.Local).AddTicks(7763), "Organization Nicolas - Berge", new DateTime(2022, 5, 13, 17, 13, 26, 148, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db70b102-cad0-4c61-9223-a85861122b28"), "Quisquam soluta facilis quos quaerat accusamus iure iste.", "0aa3447d-c31d-4070-a17e-101141a7545e", new DateTime(2017, 12, 28, 14, 10, 41, 281, DateTimeKind.Local).AddTicks(6430), "Organization Reynolds Inc", new DateTime(2021, 4, 4, 9, 9, 54, 87, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dbc10092-4653-4368-b692-4a06e563330e"), "Et quod quod.", "27f8b925-d077-4e84-81b7-a55ec8744573", new DateTime(2017, 8, 9, 9, 15, 6, 30, DateTimeKind.Local).AddTicks(3719), "Organization Schimmel LLC", new DateTime(2022, 3, 19, 8, 27, 10, 412, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dd9cf2e7-e6a7-4112-962f-53c4a8b8ad7d"), "Officia enim exercitationem nemo similique.", "ccfd6902-3e70-464b-94b6-0f7298d49194", new DateTime(2020, 10, 18, 14, 26, 50, 277, DateTimeKind.Local).AddTicks(2434), "Organization Hintz, Zieme and Treutel", new DateTime(2021, 3, 13, 17, 6, 51, 567, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1943191-3d83-494d-96af-75c744d6d772"), "Hic perferendis sed voluptatem.", "9863fd6d-43c6-4e68-b9c1-772ed5474b6f", new DateTime(2022, 5, 28, 21, 55, 2, 428, DateTimeKind.Local).AddTicks(7395), "Organization Hermiston - Armstrong", new DateTime(2022, 7, 1, 15, 36, 46, 972, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e4c91607-d4f6-4f73-9632-80496ec5cd9a"), "Id sapiente ut minima nihil iure soluta eos rerum.", "eda549cb-4ac1-4273-87bb-efdff4c236ff", new DateTime(2022, 6, 1, 22, 16, 49, 46, DateTimeKind.Local).AddTicks(6040), "Organization Von LLC", new DateTime(2022, 7, 2, 7, 0, 30, 709, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6cbb0ba-6a4e-42e6-a7d1-5ab7b4a7512c"), "Nesciunt nihil dolor aspernatur explicabo quo animi rerum.", "398859f2-6964-46af-a205-aebd5bcdbe9e", new DateTime(2021, 5, 20, 23, 18, 54, 400, DateTimeKind.Local).AddTicks(3224), "Organization Rempel - Keeling", new DateTime(2021, 6, 26, 10, 15, 10, 554, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ebdef61c-69e2-45b1-960f-2fa12c73acf2"), "Eaque illum aut doloribus rerum perspiciatis modi omnis.", "5fd49dd7-fba4-4573-aa03-56a56cf8bec3", new DateTime(2020, 5, 15, 0, 54, 24, 628, DateTimeKind.Local).AddTicks(3934), "Organization O'Hara, Hauck and Harris", new DateTime(2020, 9, 15, 2, 53, 28, 855, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee49253a-042b-4397-9941-3a4c901f7a85"), "Ipsum eum quia porro tempore.", "49960733-2425-4421-ac6c-6c83d4fb769f", new DateTime(2020, 7, 28, 10, 38, 48, 273, DateTimeKind.Local).AddTicks(9813), "Organization Block, Raynor and Thompson", new DateTime(2020, 9, 6, 10, 23, 16, 13, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f032ceb6-2288-42b1-84fc-43a401a03208"), "Aperiam fuga soluta.", "ca4398c0-a34c-42c5-bf21-bbdf7e188da2", new DateTime(2018, 10, 27, 2, 34, 6, 252, DateTimeKind.Local).AddTicks(4906), "Organization Hilll Inc", new DateTime(2021, 5, 17, 15, 34, 35, 313, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f39d6f8c-d372-4279-b2e3-851f2bb676a2"), "Velit ducimus perferendis corporis.", "aa98b691-c114-4c3a-832d-3ec6a3fe9081", new DateTime(2020, 6, 22, 3, 38, 8, 387, DateTimeKind.Local).AddTicks(2585), "Organization Schneider, Larkin and Jakubowski", new DateTime(2022, 4, 3, 10, 43, 31, 801, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f4f10e71-683f-4196-a4af-a555bd65fb0d"), "Impedit et tempora ut et ut et.", "57e73138-6a25-44eb-94cf-ecac8630c28c", new DateTime(2022, 4, 8, 19, 46, 28, 150, DateTimeKind.Local).AddTicks(5590), "Organization Rodriguez - Leffler", new DateTime(2022, 4, 22, 19, 40, 15, 925, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fadc8158-ee91-4581-9795-aeeb9ea02b9c"), "Eos provident cum perspiciatis.", "8031eb03-7df5-4cd9-8981-1766b9653b46", new DateTime(2019, 4, 28, 10, 51, 15, 815, DateTimeKind.Local).AddTicks(9535), "Organization Graham - Lowe", new DateTime(2021, 8, 26, 0, 26, 37, 17, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fd33de8a-86b1-4ac7-aa96-83a5ec9e82f2"), "Dolorem ab quae voluptatibus sed.", "d5bada14-189b-495a-a005-fe6c9290df62", new DateTime(2018, 7, 11, 3, 35, 27, 825, DateTimeKind.Local).AddTicks(5786), "Organization Hirthe, Mohr and Morar", new DateTime(2021, 9, 7, 15, 5, 39, 488, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.InsertData(
                table: "PriceType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("154ca864-aaf0-406f-bf9d-5bf78ab9cee9"), "Dolor ex nihil quasi corrupti qui omnis.", "9b30d766-d231-49dd-8e31-d1a080f16b9c", new DateTime(2018, 11, 23, 9, 37, 30, 187, DateTimeKind.Local).AddTicks(9808), "all", new DateTime(2022, 2, 22, 0, 15, 49, 71, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.InsertData(
                table: "PriceType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d4987b29-bd78-4d5f-ad30-27034f458525"), "Nulla aut commodi.", "8263902a-ed05-4682-8148-9f293c75d34a", new DateTime(2019, 4, 4, 15, 8, 30, 232, DateTimeKind.Local).AddTicks(4686), "opt", new DateTime(2021, 7, 2, 15, 47, 0, 152, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.InsertData(
                table: "PriceType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f786a11b-24e9-46b4-b72f-75eb751fca30"), "Autem corporis accusamus eos sit.", "ca152b46-1f2e-4c4f-8514-8542ebb20d80", new DateTime(2019, 4, 11, 13, 33, 49, 828, DateTimeKind.Local).AddTicks(8407), "big opt", new DateTime(2019, 6, 5, 12, 25, 52, 670, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("00dd6c38-f359-4c9a-be9d-6c3ccf00d0f9"), "Nihil ut facere accusantium officia aut omnis qui quod voluptatem.", "f80539f4-7209-4137-bed9-33b2fd02e41f", new DateTime(2019, 12, 18, 0, 39, 56, 464, DateTimeKind.Local).AddTicks(890), "indigo", new DateTime(2021, 8, 10, 23, 46, 48, 609, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06cf8e26-31c1-4246-abaa-97a451b00641"), "Possimus aliquam corrupti ducimus.", "b4733a80-2ed8-4fbd-b7e2-d0a7aa38bb16", new DateTime(2019, 4, 8, 20, 51, 0, 382, DateTimeKind.Local).AddTicks(5329), "ivory", new DateTime(2021, 7, 12, 11, 16, 29, 828, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("085b3aff-7c3f-473e-b7c5-c9d1ec1a1199"), "Sapiente eligendi sit aut id exercitationem enim nostrum iste eligendi.", "c1bb1328-1a5b-4e76-a6cb-261b509b0e93", new DateTime(2020, 12, 31, 7, 7, 53, 93, DateTimeKind.Local).AddTicks(2670), "indigo", new DateTime(2022, 6, 25, 22, 42, 55, 969, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("093a5c1a-f844-4564-b0ee-b56691e98c57"), "Aut ea quasi quas praesentium.", "e4dde444-4fc2-4143-b282-20c22b68d885", new DateTime(2018, 4, 15, 13, 5, 54, 752, DateTimeKind.Local).AddTicks(5623), "violet", new DateTime(2022, 6, 6, 19, 20, 31, 131, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0e9e8dd5-fd8a-4cda-aca8-e59e0824b19e"), "Quod cumque voluptate dolor eum fugit expedita et magni.", "4e60789b-b18a-4c45-b7fa-173b7ec36702", new DateTime(2018, 4, 6, 10, 45, 36, 5, DateTimeKind.Local).AddTicks(4692), "green", new DateTime(2022, 4, 29, 16, 39, 7, 925, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ff0ae48-65be-4b5d-ac45-2fd2bd7a782d"), "Id omnis assumenda voluptas sequi.", "6959fd0f-0cfc-401a-be2d-42ba9ca35dd8", new DateTime(2021, 9, 15, 1, 46, 2, 779, DateTimeKind.Local).AddTicks(6549), "red", new DateTime(2022, 6, 4, 9, 43, 50, 845, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("133e4c6e-f5f9-47ba-b3fe-8d13b01260c5"), "Ut sit autem nemo.", "4be8d732-6b31-41af-b361-419b39db834b", new DateTime(2018, 9, 4, 13, 14, 0, 162, DateTimeKind.Local).AddTicks(1383), "ivory", new DateTime(2019, 6, 20, 6, 46, 2, 122, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("14c6e674-d07c-4b28-b0cf-4e2bdcb9dbd8"), "Est numquam est corrupti assumenda atque laborum aut quas.", "c55d5f33-365d-4131-abdf-204ec364fb42", new DateTime(2017, 12, 15, 3, 15, 46, 761, DateTimeKind.Local).AddTicks(6891), "white", new DateTime(2019, 2, 2, 18, 34, 4, 416, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15aa7309-f298-425f-93cf-e49c8e499dce"), "Corporis itaque consequatur non molestias velit.", "4e9f484c-6488-4933-9e3f-5af9e87aba60", new DateTime(2019, 3, 21, 9, 12, 13, 586, DateTimeKind.Local).AddTicks(5791), "orange", new DateTime(2021, 3, 29, 18, 24, 19, 760, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("16488f30-a459-41df-a2c7-fea06de547fb"), "Id assumenda porro hic quia quis vero ratione magni.", "a0761850-3b3d-4466-a615-f7a112f58f05", new DateTime(2019, 3, 6, 11, 15, 16, 291, DateTimeKind.Local).AddTicks(3496), "red", new DateTime(2021, 12, 4, 13, 42, 4, 849, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17404e84-4728-46c5-8f64-5439a5e712ac"), "Sint recusandae dolorem.", "245c1e8e-64de-4251-819d-e8a922941113", new DateTime(2022, 6, 26, 21, 38, 43, 26, DateTimeKind.Local).AddTicks(2177), "turquoise", new DateTime(2022, 7, 2, 19, 38, 54, 922, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b59d83a-e3f0-4eec-8846-7957ff40c74a"), "Labore qui quibusdam quibusdam enim accusamus sed quia velit animi.", "a6f9cb2d-9699-415b-9693-56851abfbd85", new DateTime(2021, 10, 8, 22, 36, 43, 219, DateTimeKind.Local).AddTicks(7508), "turquoise", new DateTime(2022, 1, 20, 5, 29, 38, 428, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b84f51c-8b06-4331-8aea-560567d769a9"), "Sequi dolorum nostrum et recusandae eveniet tempora.", "7f092be1-b6bd-441e-8f6b-5e97e4f2ff97", new DateTime(2018, 3, 26, 0, 59, 4, 423, DateTimeKind.Local).AddTicks(1874), "red", new DateTime(2018, 12, 3, 6, 22, 51, 335, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("219d3720-60f7-4e64-8058-ddba571db12a"), "Cupiditate ducimus repellat ullam illum veniam quod fugiat.", "3470e718-fe7a-4eb3-9af2-a6605c07d474", new DateTime(2020, 12, 29, 12, 28, 8, 586, DateTimeKind.Local).AddTicks(7536), "white", new DateTime(2021, 8, 13, 13, 46, 42, 632, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("252d2917-385e-486a-9e90-118e3adfcc82"), "Excepturi dolore unde.", "618c7836-1245-4ad3-ba32-728c69c341e2", new DateTime(2019, 10, 21, 14, 11, 34, 639, DateTimeKind.Local).AddTicks(7759), "gold", new DateTime(2022, 7, 4, 19, 23, 27, 934, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2a5675ec-f1fc-4970-acbc-25ebc63cbbc1"), "Accusamus est illo ea quidem quas delectus sed quo.", "682c7e75-e5dd-4748-a6b9-525d398accbd", new DateTime(2019, 4, 29, 2, 10, 35, 180, DateTimeKind.Local).AddTicks(9756), "maroon", new DateTime(2020, 4, 2, 6, 10, 26, 932, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2aa93efc-4733-4178-8e27-b107b9465cb9"), "Voluptate reprehenderit sed quos voluptatem accusantium laboriosam magnam nihil assumenda.", "95336398-a013-42f1-a095-b18a2b8e7997", new DateTime(2021, 12, 30, 20, 20, 18, 849, DateTimeKind.Local).AddTicks(7057), "fuchsia", new DateTime(2022, 5, 24, 23, 19, 15, 537, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e066da2-66c3-4b38-90a9-ec41b912b7d2"), "Alias dolores hic voluptate omnis nesciunt possimus.", "6a6e8076-2cf9-4205-97cd-875a5594de23", new DateTime(2019, 1, 10, 20, 31, 19, 1, DateTimeKind.Local).AddTicks(9648), "green", new DateTime(2019, 5, 24, 22, 3, 11, 361, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3013be45-a27a-4443-a191-0f33294bca65"), "Cupiditate delectus eius accusamus qui.", "a21f045f-4d91-4977-a095-bac327b3ce96", new DateTime(2017, 9, 7, 12, 5, 53, 918, DateTimeKind.Local).AddTicks(7348), "salmon", new DateTime(2018, 3, 19, 0, 47, 56, 322, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30ea3ce1-73fc-404f-b1e6-ca3b919d7413"), "Placeat modi rerum.", "d696d3a9-a21e-47af-b435-d0f52bbeec97", new DateTime(2019, 11, 26, 18, 16, 6, 501, DateTimeKind.Local).AddTicks(2731), "green", new DateTime(2022, 4, 12, 13, 36, 36, 256, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("314a5c26-b9e4-4670-b23a-c41ca88e70a5"), "Quae aut laudantium ab atque non ab cupiditate.", "700b8847-2e57-43f5-8934-62bf9a68fc03", new DateTime(2018, 3, 27, 5, 57, 32, 960, DateTimeKind.Local).AddTicks(3700), "white", new DateTime(2018, 8, 4, 17, 11, 19, 56, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31bb9d60-9eb0-4c61-8062-69a471392ff1"), "Natus ut quis magni eligendi impedit quod et sunt commodi.", "98db293b-eb45-4f02-9cbe-627367ba93a5", new DateTime(2021, 8, 4, 0, 17, 52, 155, DateTimeKind.Local).AddTicks(7188), "silver", new DateTime(2021, 11, 12, 3, 57, 31, 910, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3275afd2-f333-4400-ab14-7a1f7c4bea80"), "Hic pariatur quia quae.", "58a6c3c9-f8b2-41e4-b784-f08ea94dff95", new DateTime(2021, 7, 12, 10, 27, 37, 100, DateTimeKind.Local).AddTicks(4894), "plum", new DateTime(2022, 3, 1, 12, 40, 45, 392, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35b64765-4775-4754-bc70-856412ecafb0"), "Repellat nesciunt dolores eum illum.", "02580cca-8a55-4e48-aa69-e89548109cb5", new DateTime(2020, 1, 9, 1, 32, 47, 687, DateTimeKind.Local).AddTicks(3576), "orchid", new DateTime(2020, 5, 1, 16, 47, 46, 135, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a954bcd-b039-4b57-a20f-022688b82bf4"), "Placeat ipsam praesentium in dolores.", "36562ef8-c1a1-4e2b-8f08-9f2997aa575d", new DateTime(2018, 1, 27, 20, 46, 10, 439, DateTimeKind.Local).AddTicks(8450), "tan", new DateTime(2018, 5, 29, 16, 4, 37, 996, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3db03071-777d-4598-b1df-5f6ccc2cfe46"), "Distinctio quam exercitationem rem asperiores labore.", "4330fdec-099d-48a3-9e9d-854a3a06f031", new DateTime(2018, 2, 1, 10, 33, 4, 183, DateTimeKind.Local).AddTicks(7701), "grey", new DateTime(2022, 4, 21, 0, 54, 14, 947, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3eba3fc0-2b5d-4a7b-8559-1a9b3a888a73"), "Quis quibusdam voluptates.", "10cb604b-8373-419a-ace1-be1fd4f75a7e", new DateTime(2021, 11, 9, 0, 44, 9, 634, DateTimeKind.Local).AddTicks(9838), "red", new DateTime(2022, 3, 10, 1, 40, 24, 723, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("40c059bb-564b-49a2-887d-d1e12ed4da07"), "Ut voluptate vitae similique nobis vitae nihil adipisci tempora.", "c40db21b-61e0-4a15-b48a-0c8dcac865d6", new DateTime(2017, 12, 29, 18, 26, 21, 118, DateTimeKind.Local).AddTicks(9209), "teal", new DateTime(2021, 4, 27, 19, 43, 14, 118, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41df03ee-d7f9-48b6-9c6f-17d01f317a28"), "Architecto labore qui nam qui excepturi quia.", "95ccb21a-e493-46cd-b6d1-9230a4454261", new DateTime(2020, 11, 11, 2, 7, 49, 50, DateTimeKind.Local).AddTicks(6374), "black", new DateTime(2021, 1, 5, 5, 5, 6, 635, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("424407f4-8515-4ec9-8672-47e8d2ce0a62"), "Tenetur pariatur cumque adipisci et non ut a voluptatibus.", "30021877-cd44-4695-87d1-c7e1996b960d", new DateTime(2019, 6, 17, 22, 25, 52, 586, DateTimeKind.Local).AddTicks(7085), "purple", new DateTime(2022, 6, 13, 19, 42, 44, 51, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("490c0bd6-7388-4205-aab7-188540a14276"), "Qui officia facere enim sed architecto iste velit.", "19ef369d-9d00-411e-a50f-db5d12236798", new DateTime(2022, 2, 24, 14, 18, 55, 267, DateTimeKind.Local).AddTicks(5703), "green", new DateTime(2022, 4, 30, 9, 6, 16, 682, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49ea7826-82c7-4749-9afb-d072dd4fa8e0"), "Itaque quia non qui aut autem sit dolores unde porro.", "755b2763-1511-4c95-b139-984c09eeb478", new DateTime(2020, 12, 29, 4, 4, 42, 935, DateTimeKind.Local).AddTicks(7904), "green", new DateTime(2021, 5, 20, 4, 36, 35, 329, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4a21cfad-39d7-4284-a5c4-95c2799479f2"), "Sint sed voluptas perferendis temporibus iure quia exercitationem.", "b28615a8-7114-47ec-8867-1059602d373f", new DateTime(2021, 9, 12, 9, 29, 55, 580, DateTimeKind.Local).AddTicks(3860), "yellow", new DateTime(2022, 4, 29, 9, 1, 40, 543, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4af08064-11ac-447a-9d7e-a30e1413d2df"), "Id maxime accusamus.", "db414b0c-4ac7-4b7a-8d38-07fedb40cfb4", new DateTime(2020, 9, 24, 14, 27, 52, 550, DateTimeKind.Local).AddTicks(3007), "cyan", new DateTime(2021, 4, 30, 13, 57, 14, 106, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c677738-e012-4bd1-bbb0-ee507bb3f314"), "Non voluptate ullam ipsa qui quo ut.", "4c1885df-94d3-4722-880f-2693dfbf589b", new DateTime(2019, 11, 19, 21, 44, 59, 277, DateTimeKind.Local).AddTicks(3449), "mint green", new DateTime(2020, 10, 13, 12, 41, 15, 958, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5785ccb8-1688-4a9f-be8e-c89e6c994be0"), "Eveniet ullam facere sit ullam temporibus et quibusdam illum iure.", "34a9c8d6-285c-4fdb-b042-9088a99ac08c", new DateTime(2018, 7, 5, 13, 19, 16, 310, DateTimeKind.Local).AddTicks(6660), "orchid", new DateTime(2022, 6, 30, 11, 21, 4, 236, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5934debf-bd0d-43fa-8657-3670f2b91e95"), "Rerum neque debitis est voluptatibus.", "e45fa510-1fb0-4e0d-a58f-7a92a6ff9887", new DateTime(2019, 5, 29, 8, 4, 7, 300, DateTimeKind.Local).AddTicks(9543), "lavender", new DateTime(2020, 10, 14, 0, 43, 52, 735, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c6859bf-ca73-455d-b0d9-64a2338f467b"), "Eius in voluptatem perspiciatis rem adipisci quia est atque.", "42b4b408-be74-4680-ba44-4fe39d3afc0b", new DateTime(2021, 5, 15, 15, 31, 57, 990, DateTimeKind.Local).AddTicks(6807), "turquoise", new DateTime(2022, 5, 4, 0, 25, 26, 584, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c714fed-3445-467c-9407-5c9e8d709eb5"), "Ipsum sequi nemo aperiam aut.", "5e95efdc-f030-4d38-a8fe-7f583171ff90", new DateTime(2021, 11, 10, 9, 48, 4, 590, DateTimeKind.Local).AddTicks(2783), "salmon", new DateTime(2022, 1, 18, 8, 33, 29, 496, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ebfd127-fe9b-48ec-b8be-4308d67d91ec"), "Ex suscipit esse accusantium culpa aut ratione illum.", "405c66b4-b17f-4c7b-9496-ddd9fbbb3ad5", new DateTime(2022, 4, 8, 11, 31, 43, 878, DateTimeKind.Local).AddTicks(2506), "pink", new DateTime(2022, 6, 3, 17, 37, 59, 44, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6333bf79-20f6-49a7-9c14-b6fed6ac941e"), "Voluptatem omnis eos voluptates ut.", "93b0e76a-5737-4bf5-9bcd-3f4442383da0", new DateTime(2021, 9, 19, 23, 43, 58, 473, DateTimeKind.Local).AddTicks(4518), "olive", new DateTime(2022, 1, 13, 14, 51, 18, 483, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69609430-35e0-4fcc-9d35-66d8953bb2c1"), "Nobis dicta quo quibusdam architecto ex quo et.", "ad38130d-55c6-40a7-83ef-cbce606b1064", new DateTime(2020, 1, 3, 12, 3, 5, 190, DateTimeKind.Local).AddTicks(4357), "magenta", new DateTime(2021, 2, 28, 8, 56, 21, 627, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71ddaa91-876c-46ed-b323-fd83b4f4c61a"), "Molestias perspiciatis sit est molestiae et aut distinctio numquam et.", "f81fdb16-0014-4a54-8e25-ebd732ec5fa4", new DateTime(2022, 1, 15, 21, 56, 25, 188, DateTimeKind.Local).AddTicks(329), "indigo", new DateTime(2022, 2, 26, 23, 47, 44, 12, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73ae5ae6-6ba5-465d-bd09-d8887a753de8"), "Incidunt qui quia.", "08f373ea-6fd5-4adc-a6ef-7114aa8f1d28", new DateTime(2020, 2, 9, 20, 52, 16, 770, DateTimeKind.Local).AddTicks(7817), "purple", new DateTime(2021, 3, 16, 15, 51, 44, 643, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73bb3c47-0545-4e96-bc2a-09c94887db47"), "Deserunt accusantium sint ducimus inventore architecto temporibus omnis.", "0bd2859e-8033-4516-89ea-8b9f4d221cb4", new DateTime(2020, 8, 17, 22, 25, 38, 933, DateTimeKind.Local).AddTicks(2560), "lime", new DateTime(2021, 10, 6, 20, 15, 1, 502, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("762ce890-9bfd-491c-b590-400df6f210fa"), "Dignissimos libero sint quos eligendi.", "80235a46-b90b-40be-97e0-b634a039a334", new DateTime(2021, 7, 16, 11, 0, 2, 445, DateTimeKind.Local).AddTicks(3873), "plum", new DateTime(2021, 8, 22, 6, 30, 58, 607, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7648bdd2-48f5-4136-825c-a92d7fcdec39"), "Quas laudantium eos.", "f38d969b-6710-4c0d-a65b-b241be428a47", new DateTime(2019, 1, 24, 7, 48, 39, 397, DateTimeKind.Local).AddTicks(9888), "fuchsia", new DateTime(2019, 9, 11, 7, 31, 24, 322, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7dc15d1b-cc49-4ad2-b45e-930cbf03e32e"), "Molestiae quisquam quis esse quis numquam unde quia.", "7da6d79b-ead9-4cda-b714-1ea5775cdcaf", new DateTime(2019, 7, 6, 20, 49, 14, 112, DateTimeKind.Local).AddTicks(3884), "fuchsia", new DateTime(2020, 8, 20, 7, 51, 9, 272, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e3f4559-62a5-455a-b838-7844ef81c237"), "Aliquid aspernatur harum unde consequuntur.", "5c6e4db9-d416-4984-9614-82e289361c2b", new DateTime(2021, 9, 18, 6, 10, 27, 88, DateTimeKind.Local).AddTicks(3362), "lavender", new DateTime(2021, 10, 20, 15, 28, 3, 924, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e6f2d22-7945-4c11-96a7-a5d4efeeb72b"), "Mollitia velit voluptatibus sapiente officiis aliquam odit voluptas quasi.", "0ed5c7e6-9464-421e-8e52-ffa6e4b3b704", new DateTime(2017, 11, 10, 19, 51, 25, 695, DateTimeKind.Local).AddTicks(3249), "violet", new DateTime(2019, 7, 25, 16, 21, 35, 824, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("813cf264-5994-4e5f-87a7-b80683b850a8"), "Facilis ut deserunt.", "fdc71aba-86dc-4e9c-894a-e50007448c01", new DateTime(2022, 2, 14, 12, 40, 47, 872, DateTimeKind.Local).AddTicks(3205), "orchid", new DateTime(2022, 6, 19, 16, 32, 44, 978, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84f53f8e-f65e-4990-9cf3-3f07004c9ad6"), "Aut corporis dolor ut neque in adipisci.", "e132a57e-833e-4d34-98dd-c40dfa9b4fd3", new DateTime(2021, 4, 29, 13, 46, 43, 887, DateTimeKind.Local).AddTicks(9612), "lavender", new DateTime(2021, 8, 31, 3, 2, 9, 193, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("85052dfc-6dae-48fd-8a99-d0fcde0dc687"), "Ut facere enim vitae.", "730c9ebf-d508-494f-949c-0b79e603096b", new DateTime(2021, 3, 25, 11, 21, 32, 246, DateTimeKind.Local).AddTicks(9527), "blue", new DateTime(2022, 2, 4, 20, 3, 45, 953, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("868b235b-8af3-4b66-92c7-2a4ed72095bf"), "Labore saepe alias et.", "1a37168d-e0dc-4c06-845a-c4d2930edabf", new DateTime(2021, 12, 25, 6, 22, 0, 225, DateTimeKind.Local).AddTicks(4593), "azure", new DateTime(2022, 1, 13, 12, 48, 35, 201, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("877a678c-470d-4ea3-8698-4286f2e93165"), "Voluptatem sit rem tempora.", "4469a96e-cad0-48f8-a69c-3e7c07202dfc", new DateTime(2018, 1, 29, 18, 41, 46, 482, DateTimeKind.Local).AddTicks(2435), "orange", new DateTime(2020, 8, 6, 13, 47, 17, 886, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89b1cc38-2751-4967-bc20-db01c9ac5936"), "Delectus repellendus vitae consequatur mollitia sunt consequatur veritatis iste.", "1cc82c58-a34e-43a1-9c4b-28389e283fee", new DateTime(2020, 2, 27, 19, 13, 4, 268, DateTimeKind.Local).AddTicks(112), "pink", new DateTime(2020, 5, 4, 5, 52, 29, 365, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a8c9fd5-56af-4961-97ee-957b9d6f60cc"), "Qui nisi consequatur sed rerum asperiores praesentium.", "f9ae3668-8788-4a1b-a850-1587e1591723", new DateTime(2019, 9, 26, 10, 44, 24, 683, DateTimeKind.Local).AddTicks(9304), "sky blue", new DateTime(2020, 8, 2, 22, 51, 23, 324, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ce4cbdd-c60e-4f8c-b419-33abeed3bf34"), "Reprehenderit voluptatem sed.", "80408b4a-10bd-4fe8-bc0c-63244a8becf3", new DateTime(2021, 12, 21, 12, 17, 24, 96, DateTimeKind.Local).AddTicks(1903), "purple", new DateTime(2022, 7, 3, 0, 45, 41, 449, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9107270c-b22b-4b6a-bca4-dc0ff8d8193f"), "Excepturi et et ad.", "c7ddb174-eed7-4bd6-9ff6-68c3a24208d1", new DateTime(2018, 1, 3, 3, 50, 15, 478, DateTimeKind.Local).AddTicks(3095), "fuchsia", new DateTime(2021, 9, 11, 17, 36, 0, 488, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91f2d03c-f71d-4d5e-813c-655dcfaec545"), "Voluptatum reprehenderit sit eos laboriosam consectetur qui repudiandae.", "cbc3263e-52c0-4576-8829-55a9bc4898d6", new DateTime(2021, 9, 6, 10, 40, 29, 128, DateTimeKind.Local).AddTicks(1600), "purple", new DateTime(2021, 11, 13, 8, 15, 3, 477, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9253cb29-5f9d-43f9-9025-31dee8e444c9"), "Culpa qui voluptatem.", "0563ec3f-2124-48fe-900b-390187c351f7", new DateTime(2021, 4, 19, 6, 27, 55, 56, DateTimeKind.Local).AddTicks(1659), "olive", new DateTime(2021, 12, 7, 8, 49, 44, 713, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92819655-f08b-4656-8f3b-9f2670c7a82c"), "Et voluptatem modi rerum quibusdam sed nostrum modi.", "5b4b9202-efc5-42d4-b142-493e50dc569b", new DateTime(2020, 2, 8, 4, 55, 52, 937, DateTimeKind.Local).AddTicks(829), "gold", new DateTime(2020, 10, 5, 20, 14, 55, 287, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92c0ad96-65be-4c26-a8c5-24c1bc60e406"), "Rerum ea nobis ratione impedit non explicabo maiores fugiat porro.", "8305e543-f919-4665-bde8-f45f2137b8a1", new DateTime(2022, 7, 1, 17, 31, 25, 801, DateTimeKind.Local).AddTicks(6851), "cyan", new DateTime(2022, 7, 1, 21, 56, 21, 706, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("95493d24-833f-40ed-8c88-a038c6b9b25c"), "Corporis sapiente consectetur.", "78371312-b1d2-4cb7-99b8-0119e595f2b1", new DateTime(2020, 12, 16, 8, 37, 53, 185, DateTimeKind.Local).AddTicks(5395), "ivory", new DateTime(2022, 6, 28, 0, 41, 44, 893, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97af5f8e-7cf3-477d-b0b9-96696ab60bb8"), "Quidem minima voluptates consequatur odit corrupti.", "c7103a00-0935-42d8-aacf-e20b1a4e3a82", new DateTime(2018, 6, 10, 10, 51, 43, 403, DateTimeKind.Local).AddTicks(1712), "indigo", new DateTime(2021, 7, 27, 1, 0, 38, 826, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("98aaff14-161e-4717-8cf1-55c0589b7801"), "Et aperiam sit incidunt placeat.", "7258f861-0e62-482a-9e1a-ad9835a29a02", new DateTime(2021, 12, 26, 9, 3, 1, 396, DateTimeKind.Local).AddTicks(6131), "teal", new DateTime(2022, 4, 20, 12, 41, 31, 918, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9bfa568a-893e-47fe-bb16-b9edd299473d"), "Blanditiis accusamus est quo voluptatem corrupti corrupti molestiae voluptas totam.", "a13a85c1-8b8b-4cd8-88d5-b423ee3b2dbf", new DateTime(2018, 7, 10, 21, 26, 15, 538, DateTimeKind.Local).AddTicks(2569), "mint green", new DateTime(2019, 2, 27, 11, 37, 26, 203, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5ad099a-9461-48da-a403-ccb55cb94171"), "Et ullam sed aliquid a facere sit rerum unde non.", "19e8f1b3-da2c-4476-a5d3-95f92c230ea4", new DateTime(2020, 11, 10, 18, 49, 13, 80, DateTimeKind.Local).AddTicks(9279), "pink", new DateTime(2021, 7, 22, 16, 24, 50, 433, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6da07a0-c413-4329-9326-1a90c5eb9ce9"), "Reiciendis beatae molestias voluptatum facilis.", "739b0dbe-15a2-40bc-a91a-8d99f4d0ed89", new DateTime(2021, 2, 10, 17, 34, 39, 593, DateTimeKind.Local).AddTicks(3798), "yellow", new DateTime(2021, 11, 10, 18, 7, 12, 939, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7e5297c-67fc-42cb-ba7d-c69592042f7e"), "Numquam dolore quaerat atque excepturi nihil asperiores aut cum.", "43ccd8c9-204b-4358-9dfa-356e3bab49d5", new DateTime(2022, 6, 20, 22, 0, 14, 560, DateTimeKind.Local).AddTicks(300), "yellow", new DateTime(2022, 6, 21, 17, 40, 43, 533, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab5c43ad-a861-451d-a5d6-43bb259a6e7f"), "Aut nesciunt sit saepe laboriosam ut.", "4fba7b6c-2f98-40f6-a0e3-3d9586ec0ff1", new DateTime(2018, 8, 14, 21, 29, 20, 596, DateTimeKind.Local).AddTicks(2376), "ivory", new DateTime(2019, 7, 4, 1, 17, 28, 298, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b5cd6160-890f-4532-959a-246b49c66445"), "Pariatur officiis et cupiditate.", "28e14d78-9372-4566-bdb3-215e4d382d8e", new DateTime(2019, 1, 27, 13, 40, 22, 256, DateTimeKind.Local).AddTicks(1723), "olive", new DateTime(2019, 3, 18, 15, 28, 34, 6, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b641a88c-7e55-4dbc-833c-946f35992705"), "Quisquam provident quas illo assumenda modi.", "51d03caf-e2f1-42b4-bdb3-b2af2cb94074", new DateTime(2020, 7, 7, 20, 33, 27, 412, DateTimeKind.Local).AddTicks(168), "magenta", new DateTime(2022, 5, 9, 11, 26, 58, 220, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b7c33b66-ecfa-4beb-a8b8-71a8485789f1"), "Illum pariatur laudantium et qui ullam.", "b1b0e4e6-4305-4b92-aae5-14cbe2b0ba1d", new DateTime(2019, 12, 1, 10, 10, 7, 232, DateTimeKind.Local).AddTicks(5057), "black", new DateTime(2020, 7, 7, 23, 28, 56, 678, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8bfec89-5154-44df-b579-a942b0e570c7"), "Qui laborum aut ut repellat illo.", "5449e1cb-626a-4927-8419-ead3e56d55dc", new DateTime(2021, 2, 14, 20, 19, 25, 170, DateTimeKind.Local).AddTicks(9085), "ivory", new DateTime(2021, 8, 13, 4, 34, 25, 185, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9953c07-64cd-4413-8ac3-2e80338a9689"), "Consequuntur fugit harum est quo voluptatibus.", "14a11989-c1a1-44fa-b261-5647af9a5df4", new DateTime(2018, 12, 14, 16, 2, 16, 263, DateTimeKind.Local).AddTicks(7209), "olive", new DateTime(2020, 3, 23, 8, 10, 13, 614, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("be355275-ed54-48d2-a49b-d918e4ded308"), "Excepturi ea quidem deserunt iste.", "e7ed415e-3c02-42df-97e3-297b747f38d5", new DateTime(2018, 2, 10, 1, 33, 41, 507, DateTimeKind.Local).AddTicks(7123), "green", new DateTime(2020, 12, 19, 2, 52, 19, 677, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2390826-cd5d-4dd9-82e8-3e708f1f17c7"), "Ratione cupiditate illo tenetur esse nisi.", "4fe3d613-3194-42f7-b334-885705ff96f6", new DateTime(2022, 2, 23, 6, 24, 21, 334, DateTimeKind.Local).AddTicks(3699), "purple", new DateTime(2022, 5, 12, 15, 37, 0, 839, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c76ceebe-22a4-4402-a578-fc74b7e50fb6"), "Quia assumenda et.", "e12fd6c7-a44d-4d0d-a06b-fda41a232e65", new DateTime(2020, 11, 17, 17, 23, 24, 213, DateTimeKind.Local).AddTicks(936), "violet", new DateTime(2021, 12, 15, 6, 23, 37, 657, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cbee3c9f-d3d7-4270-b226-0d363333b7b8"), "Velit et consectetur veniam consequuntur aut repellat.", "4dd73391-285a-43ca-941a-a89ba10aa0a3", new DateTime(2021, 10, 29, 5, 33, 50, 181, DateTimeKind.Local).AddTicks(1761), "sky blue", new DateTime(2022, 6, 28, 18, 22, 38, 202, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d10f3d18-eeec-4439-a3f3-141734742ba2"), "Atque sit non impedit et perspiciatis qui quidem animi.", "35b043f8-7cd3-4d7c-a93a-8aa2fcc8c306", new DateTime(2021, 5, 4, 19, 23, 33, 446, DateTimeKind.Local).AddTicks(4229), "plum", new DateTime(2021, 12, 26, 22, 10, 11, 695, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d11af466-64a0-419d-b818-09bc2fcb24cc"), "Sint id magnam.", "dec36a3f-d838-4ca2-b803-02f761acd488", new DateTime(2018, 7, 14, 3, 31, 59, 694, DateTimeKind.Local).AddTicks(4531), "olive", new DateTime(2019, 12, 6, 12, 21, 22, 299, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d12c4a93-a935-411b-b5c5-6474aee1e761"), "Est sunt enim reiciendis est aperiam.", "98380d2b-8396-46bf-983f-a32b17cfa735", new DateTime(2020, 5, 3, 9, 25, 21, 601, DateTimeKind.Local).AddTicks(8682), "purple", new DateTime(2022, 3, 23, 3, 17, 5, 83, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d651c979-59e6-4cba-af34-b3e535d7b73b"), "At vitae vel velit tempora assumenda dolores suscipit qui.", "6fed1b95-8d96-43ce-92de-156cc5853b88", new DateTime(2020, 10, 29, 19, 38, 56, 368, DateTimeKind.Local).AddTicks(7928), "gold", new DateTime(2022, 6, 3, 4, 29, 36, 334, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7257813-ff28-488f-ac9e-6c6f272c2c1f"), "Est eveniet est dolorem ut ipsa.", "7b3e119f-204e-4520-9a27-ade0c1c1dcf8", new DateTime(2017, 7, 21, 10, 34, 4, 963, DateTimeKind.Local).AddTicks(313), "purple", new DateTime(2018, 10, 5, 16, 42, 38, 266, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7bc9ace-d0bf-4766-af15-bd2ccb36cf68"), "Et unde velit.", "97d3c1cf-e842-45e3-b955-fc05732911c4", new DateTime(2017, 9, 25, 22, 33, 9, 734, DateTimeKind.Local).AddTicks(65), "teal", new DateTime(2021, 6, 5, 9, 37, 27, 127, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d95d177a-fdad-441c-b5c0-ad78406f371e"), "Occaecati incidunt amet ut velit neque odio nihil.", "2b554e3f-b9fe-4245-8e2f-42672271509a", new DateTime(2021, 12, 27, 6, 22, 30, 517, DateTimeKind.Local).AddTicks(4775), "olive", new DateTime(2022, 1, 21, 0, 39, 58, 736, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db8ea68d-6543-4fa6-a38a-1b04407cede3"), "Rerum repudiandae similique aliquam.", "c3f6eabf-b2d3-4bcb-aa9f-6d75f28ea2fd", new DateTime(2022, 5, 17, 8, 56, 27, 724, DateTimeKind.Local).AddTicks(3598), "orange", new DateTime(2022, 6, 22, 1, 33, 53, 506, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dba83b1f-7dff-4918-aaec-a188fd941a10"), "Tempore illo illum accusamus vel dolor quos.", "7b985a8e-aa1b-4999-a639-d88961165a75", new DateTime(2020, 8, 12, 0, 53, 48, 871, DateTimeKind.Local).AddTicks(686), "grey", new DateTime(2022, 4, 5, 15, 51, 51, 402, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e044bb53-ac35-4931-9174-d00a5e305a51"), "Odio repellat aut consectetur harum.", "2f15e77a-d018-45f6-83a4-a45b483f299c", new DateTime(2020, 2, 27, 17, 4, 44, 55, DateTimeKind.Local).AddTicks(8252), "green", new DateTime(2021, 5, 3, 18, 59, 12, 983, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2aa736e-12f2-4339-ba57-613e778ec51c"), "Eveniet laudantium cum facilis quia vel molestiae ut id dicta.", "21c56d08-134f-4515-bdbe-1fd2231e25f8", new DateTime(2017, 12, 21, 1, 2, 16, 944, DateTimeKind.Local).AddTicks(1562), "pink", new DateTime(2021, 6, 6, 14, 24, 28, 449, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e661ee5c-35aa-4cfa-80cf-9413eaffa0a1"), "Autem at tempore rem.", "e0832524-29ab-4387-a627-714b96374bf4", new DateTime(2021, 4, 13, 16, 38, 10, 386, DateTimeKind.Local).AddTicks(1146), "salmon", new DateTime(2021, 12, 26, 9, 22, 3, 157, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6e706c3-6ea1-4ee6-9d70-6d3ba0ba7b5b"), "Et qui voluptatem voluptate iure.", "1549fa76-4d2b-4113-afb5-75826910e856", new DateTime(2020, 11, 16, 16, 7, 13, 551, DateTimeKind.Local).AddTicks(5050), "azure", new DateTime(2021, 9, 9, 2, 25, 18, 667, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e91e0c42-03d2-40c2-8d48-ae8910e1af2d"), "Dolores voluptate dolor harum quia voluptate velit.", "9f3eb9c1-ca92-4ce3-bd4e-a9c908e1acf0", new DateTime(2019, 5, 18, 6, 26, 25, 15, DateTimeKind.Local).AddTicks(3848), "fuchsia", new DateTime(2022, 5, 22, 11, 54, 18, 10, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("edecd485-4f1e-47da-bdc5-cbf2e6d80a76"), "Libero quibusdam eos et in consectetur assumenda.", "41153f75-2ce2-4b9c-87b3-59c2ef080179", new DateTime(2020, 7, 3, 13, 17, 56, 885, DateTimeKind.Local).AddTicks(540), "tan", new DateTime(2021, 8, 30, 23, 41, 44, 136, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eea82f6a-c1d8-45f8-899b-a48652293ac1"), "Quo temporibus dignissimos porro odit eveniet sint architecto voluptate consequatur.", "7c4b96b2-9408-480c-b2d7-0c3126397e69", new DateTime(2021, 12, 6, 0, 27, 0, 822, DateTimeKind.Local).AddTicks(1802), "green", new DateTime(2021, 12, 30, 13, 32, 12, 520, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eee5a423-a8ac-485d-b54e-1d722072f612"), "Expedita autem aliquam molestiae odio perspiciatis.", "ecd1153e-8257-4d8a-9775-f75e0bfe9de6", new DateTime(2021, 7, 19, 16, 48, 47, 439, DateTimeKind.Local).AddTicks(8190), "magenta", new DateTime(2021, 8, 11, 2, 38, 46, 361, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb4bc64a-bfce-4923-b6a2-ae83cd07499e"), "Sint beatae tempora neque libero ea dolore.", "adb75644-8d6f-4d2c-8b7a-da0e4a52cb3b", new DateTime(2021, 2, 14, 14, 45, 18, 988, DateTimeKind.Local).AddTicks(3807), "grey", new DateTime(2021, 2, 27, 18, 10, 8, 204, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe6a7fc4-0663-44e1-9d58-876f55013253"), "Doloribus eum qui eveniet nam officiis enim aspernatur expedita esse.", "ef9668e7-de09-455b-80d8-30cc96221085", new DateTime(2021, 5, 30, 14, 4, 21, 350, DateTimeKind.Local).AddTicks(3130), "ivory", new DateTime(2022, 5, 27, 23, 17, 47, 633, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe8c1e62-d647-496c-9d2c-1152132e42dc"), "Quia ipsam tempore est.", "7f86706c-bf00-4c4e-9842-d909f0c72b7b", new DateTime(2019, 12, 25, 20, 50, 36, 324, DateTimeKind.Local).AddTicks(1266), "maroon", new DateTime(2021, 9, 21, 5, 47, 22, 163, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04834b49-be8b-4126-9639-35d5380dc580"), "Molestiae sed pariatur modi quidem.", "e88b49cc-3b15-4559-9fba-1b165589dad8", new DateTime(2019, 10, 19, 1, 20, 45, 772, DateTimeKind.Local).AddTicks(5562), "Product quanity: modi", new DateTime(2021, 4, 27, 6, 48, 52, 182, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05945cc6-a04e-4472-9a99-ce89aefdf2a3"), "Est velit quia sed dolorem suscipit magni voluptate ipsum.", "61e24a05-1590-4656-bcff-eee387c9514e", new DateTime(2020, 11, 22, 6, 12, 31, 657, DateTimeKind.Local).AddTicks(1491), "Product quanity: quo", new DateTime(2021, 6, 8, 21, 36, 31, 850, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07e415ea-6093-4669-b3dd-e3990e312dab"), "Est odit mollitia sed saepe quae dolores.", "dc991f33-a5c5-4cee-8c41-87e394cb38ab", new DateTime(2017, 9, 2, 9, 59, 36, 508, DateTimeKind.Local).AddTicks(8310), "Product quanity: voluptatum", new DateTime(2019, 6, 25, 21, 50, 35, 858, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ee3671c-cfda-4690-94c6-b7017569cf79"), "Necessitatibus incidunt fuga ratione voluptas quaerat repudiandae deleniti in.", "4d528d15-55ad-4a30-a436-1795988c65b6", new DateTime(2022, 6, 9, 2, 0, 21, 492, DateTimeKind.Local).AddTicks(6371), "Product quanity: maxime", new DateTime(2022, 6, 11, 13, 50, 45, 739, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1203811d-ceb3-4a14-a475-0b7a80a23d83"), "In quam sed hic corporis qui.", "2ceecdd2-ac88-4112-bcb7-8ac1964ed0f3", new DateTime(2019, 12, 14, 10, 25, 59, 217, DateTimeKind.Local).AddTicks(7812), "Product quanity: cum", new DateTime(2021, 12, 31, 21, 0, 19, 178, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("133d8e97-650f-4b70-9348-67780da68511"), "Ea totam quia sed similique occaecati illum sed delectus.", "5f236129-f407-46a7-a194-7485389a5132", new DateTime(2020, 10, 30, 8, 3, 29, 564, DateTimeKind.Local).AddTicks(5547), "Product quanity: non", new DateTime(2022, 3, 29, 3, 31, 13, 506, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("166db7c5-22bd-4296-911d-6c7fdaa962cf"), "Est nemo est repudiandae.", "650a1382-5570-4f73-8f68-1db292fc01ef", new DateTime(2018, 6, 9, 18, 51, 18, 783, DateTimeKind.Local).AddTicks(1235), "Product quanity: est", new DateTime(2018, 8, 22, 6, 53, 39, 799, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1856907c-9c5f-46d7-8860-f6aa014c62fd"), "Nulla ea adipisci qui.", "ba32c408-cd99-4713-92c0-9f26ac203227", new DateTime(2017, 11, 8, 1, 36, 19, 427, DateTimeKind.Local).AddTicks(8920), "Product quanity: perspiciatis", new DateTime(2018, 4, 9, 12, 5, 20, 489, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b223051-45e7-4ffd-bf08-22e7f4c9f1fc"), "Quia perferendis dolores omnis numquam dolorem est facere qui sapiente.", "2a77749a-388b-4723-b3f8-1a0a3fd50c89", new DateTime(2020, 1, 13, 15, 27, 54, 631, DateTimeKind.Local).AddTicks(2390), "Product quanity: aspernatur", new DateTime(2020, 8, 8, 18, 54, 34, 889, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c0f85d2-909b-4ef4-860a-1252675a42fe"), "Ut quasi tenetur quis.", "7ef284a9-5210-4957-b77b-ad52dae36f1a", new DateTime(2021, 6, 2, 16, 0, 43, 71, DateTimeKind.Local).AddTicks(2390), "Product quanity: totam", new DateTime(2021, 7, 16, 13, 47, 31, 445, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1f11bd21-9b1d-4f17-abd2-bab64361a7cc"), "Magni molestiae aut quia suscipit maiores consequatur consequuntur sit quidem.", "04585a49-c7c8-458d-adc3-0135a1c75c30", new DateTime(2019, 10, 3, 18, 1, 29, 620, DateTimeKind.Local).AddTicks(9215), "Product quanity: reiciendis", new DateTime(2019, 11, 3, 23, 8, 15, 993, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("243c6776-cf35-42b9-aa7f-3a56bf392881"), "Incidunt vel et sequi quia modi repudiandae dolores temporibus labore.", "a8b47685-1c15-4742-a2d1-e6d95dddbc38", new DateTime(2019, 9, 26, 10, 38, 55, 435, DateTimeKind.Local).AddTicks(9664), "Product quanity: aliquam", new DateTime(2020, 6, 28, 14, 25, 41, 56, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24722dba-c0e2-40b1-92ff-2c4e5d60a5d5"), "Quae voluptate aut.", "5d8d5171-ed0b-4c71-a972-faacea7c0078", new DateTime(2017, 8, 11, 13, 38, 18, 535, DateTimeKind.Local).AddTicks(1830), "Product quanity: non", new DateTime(2018, 2, 23, 1, 46, 35, 143, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26d83173-7727-4f23-bd23-6ee22adab9e4"), "Architecto omnis perferendis omnis.", "f4c46ded-c1f9-4260-8a44-73a568f4680b", new DateTime(2020, 5, 16, 11, 48, 41, 623, DateTimeKind.Local).AddTicks(3197), "Product quanity: illo", new DateTime(2020, 6, 29, 15, 52, 6, 310, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("271cdb5d-aca6-4ecd-b6d0-73b642d75750"), "Modi voluptate architecto amet.", "4ce257d0-700d-46bf-bc04-6f1dab2b1be9", new DateTime(2021, 12, 7, 12, 29, 25, 292, DateTimeKind.Local).AddTicks(5600), "Product quanity: adipisci", new DateTime(2022, 1, 19, 20, 19, 49, 732, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2abdfafa-1a6b-42ac-a151-6725558dfd7d"), "Aspernatur dolor vel.", "850f08d7-f0a8-4560-a268-a9841c124c93", new DateTime(2022, 2, 17, 7, 50, 56, 667, DateTimeKind.Local).AddTicks(9383), "Product quanity: sint", new DateTime(2022, 3, 17, 6, 25, 28, 883, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2fb253f5-063a-48bb-982a-905b36610cd9"), "Id quis tempore voluptate sit et porro nulla vitae placeat.", "914fc22e-49b0-4c94-944d-2551ecbd7509", new DateTime(2022, 4, 24, 12, 34, 51, 610, DateTimeKind.Local).AddTicks(674), "Product quanity: voluptate", new DateTime(2022, 5, 5, 2, 14, 27, 819, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30e1714b-78c9-4ebb-af4b-419b6aaad5c0"), "Sit dolor laborum ipsa et quae mollitia.", "839fc44b-a912-4054-89e0-5dc66dd5dbbc", new DateTime(2022, 4, 28, 16, 32, 54, 5, DateTimeKind.Local).AddTicks(2819), "Product quanity: ea", new DateTime(2022, 5, 13, 9, 44, 32, 404, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("37e49eee-5efe-48c5-9d6b-c9cee387f43a"), "Repellendus magnam itaque illum quasi et occaecati molestiae iure ea.", "9f036f33-8874-4c06-a128-e6570957324d", new DateTime(2019, 9, 8, 23, 8, 4, 184, DateTimeKind.Local).AddTicks(1722), "Product quanity: id", new DateTime(2019, 11, 21, 16, 54, 22, 891, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b8ffc7b-bbeb-4924-b173-264a667e4277"), "Eaque fugit quod.", "18192029-3756-4905-9290-43190a6de07a", new DateTime(2021, 6, 18, 8, 1, 27, 803, DateTimeKind.Local).AddTicks(7299), "Product quanity: repellat", new DateTime(2021, 10, 1, 19, 11, 8, 323, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3c4b31c4-d855-41e7-8315-e8f566d29199"), "Ut ut sunt.", "a0eefbbb-717a-45de-a525-73ceadfe9490", new DateTime(2018, 1, 27, 23, 55, 35, 823, DateTimeKind.Local).AddTicks(2063), "Product quanity: dolor", new DateTime(2020, 7, 10, 1, 4, 37, 795, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e5fcca7-7fab-4d9a-9020-d267a7d134e5"), "Sit ut aut.", "0642dea1-0960-46d1-93b6-b42f79a886ec", new DateTime(2020, 4, 29, 22, 5, 49, 562, DateTimeKind.Local).AddTicks(639), "Product quanity: omnis", new DateTime(2021, 5, 20, 3, 10, 0, 183, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e710cdf-c500-4824-bc0d-3dead2910c73"), "Fuga corrupti quo corrupti maiores fugiat ducimus doloremque est.", "9ffde8db-9256-4558-93c3-909d6c74a897", new DateTime(2019, 5, 25, 19, 46, 57, 878, DateTimeKind.Local).AddTicks(6679), "Product quanity: quaerat", new DateTime(2021, 2, 11, 18, 17, 26, 630, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3eba770d-0a1d-4a4b-a189-556912fc7d09"), "Pariatur ipsam ea assumenda odit ipsa et praesentium.", "5004f9be-2edc-4352-8259-efceb62beb4e", new DateTime(2017, 9, 25, 21, 19, 40, 47, DateTimeKind.Local).AddTicks(2708), "Product quanity: magni", new DateTime(2019, 6, 19, 15, 47, 11, 770, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4189178f-9636-418f-94cd-73730422d347"), "Nam ut qui aspernatur soluta pariatur suscipit.", "2c70bb8c-9bd2-4505-87fc-b4b379568122", new DateTime(2022, 2, 13, 14, 18, 51, 451, DateTimeKind.Local).AddTicks(7978), "Product quanity: cumque", new DateTime(2022, 5, 26, 23, 18, 48, 313, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("453a4b52-3642-437e-b07d-e424f11d15df"), "Dolor nostrum dolores illum dolor distinctio omnis commodi dolorum.", "f4d057fc-a5de-4a13-b2ea-f1da30678b88", new DateTime(2020, 7, 1, 9, 0, 14, 550, DateTimeKind.Local).AddTicks(6678), "Product quanity: voluptatem", new DateTime(2021, 3, 31, 22, 30, 11, 209, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4def0df2-5dc2-4787-a3c4-edf94f6b8f39"), "Soluta esse ut qui sunt repudiandae qui repellat.", "87a4087c-b041-4266-b24a-87c21e6bbff9", new DateTime(2020, 8, 18, 10, 3, 17, 501, DateTimeKind.Local).AddTicks(3515), "Product quanity: distinctio", new DateTime(2022, 5, 26, 15, 17, 10, 347, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4ed7851e-29c4-457e-97db-f7d1c7b5b60f"), "Quia tenetur et esse eum id.", "c3aefeb4-97a6-452a-a2dc-a0f510bccdb4", new DateTime(2020, 5, 24, 1, 17, 42, 884, DateTimeKind.Local).AddTicks(2363), "Product quanity: in", new DateTime(2020, 8, 31, 4, 40, 4, 610, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52b5676f-6b8a-475c-807f-21be731e62e2"), "Quibusdam porro facilis molestiae.", "ac2a2768-0ee7-42f2-9c50-3e7af7071ab2", new DateTime(2020, 4, 21, 23, 14, 50, 802, DateTimeKind.Local).AddTicks(4620), "Product quanity: laudantium", new DateTime(2020, 8, 24, 12, 47, 8, 447, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53269d2f-97cf-4baa-9d33-5e5300d86c57"), "Possimus et illo qui dicta a ipsa ducimus qui.", "6da419ee-d7a7-449a-b689-d41506309fd2", new DateTime(2021, 6, 7, 20, 29, 27, 598, DateTimeKind.Local).AddTicks(1731), "Product quanity: nemo", new DateTime(2021, 6, 19, 13, 18, 35, 824, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5404cf54-0804-4f7b-b94f-18f9b8a019f6"), "Soluta eos illum.", "992a32f7-8734-4135-b018-c6b0f0573bef", new DateTime(2020, 9, 8, 18, 18, 57, 775, DateTimeKind.Local).AddTicks(6776), "Product quanity: vel", new DateTime(2020, 11, 16, 20, 21, 49, 363, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54b9b17c-9b29-40d3-a0da-e81c8f0ff71b"), "Laborum harum enim.", "729dc4b2-de1e-42d1-9643-7d5ba1a30cee", new DateTime(2019, 9, 23, 9, 57, 22, 890, DateTimeKind.Local).AddTicks(7688), "Product quanity: aliquam", new DateTime(2020, 5, 2, 14, 54, 42, 978, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55c07451-37aa-4663-90fa-8f9bf51a366c"), "Ipsum ullam ipsum et laboriosam iusto et rerum.", "402440cd-5aa3-4894-879e-72f38577a0be", new DateTime(2020, 4, 23, 8, 26, 34, 120, DateTimeKind.Local).AddTicks(6576), "Product quanity: nostrum", new DateTime(2020, 5, 23, 12, 44, 21, 327, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55eea28d-b808-433f-aa24-51949076a128"), "Odio dicta veniam dolorem quia repudiandae debitis deleniti placeat possimus.", "abea8861-ea57-4b1a-9e8a-7fb611d6db55", new DateTime(2021, 12, 12, 2, 47, 29, 772, DateTimeKind.Local).AddTicks(4037), "Product quanity: ut", new DateTime(2022, 4, 27, 12, 50, 13, 746, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("56a86dad-c252-4e99-83d5-b79c6b355ab6"), "Rerum autem voluptates modi id.", "29f7c0d2-a04c-4f2c-9fb6-ec3c5d3748df", new DateTime(2017, 12, 11, 2, 46, 6, 212, DateTimeKind.Local).AddTicks(8260), "Product quanity: voluptas", new DateTime(2018, 5, 4, 0, 35, 57, 311, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b490820-df42-4e9e-b049-e5604ad77110"), "Possimus unde et molestias.", "26a57634-0eda-4321-830d-02f5802a0494", new DateTime(2018, 7, 3, 21, 12, 23, 14, DateTimeKind.Local).AddTicks(8318), "Product quanity: nisi", new DateTime(2021, 11, 3, 6, 43, 38, 772, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61d45ff7-0011-4c08-84ff-08674835dd89"), "Et delectus qui tempore ducimus ut rem sint impedit.", "8fa2c7af-9bfc-4e89-9884-a1eb50b137e5", new DateTime(2018, 8, 20, 9, 11, 45, 974, DateTimeKind.Local).AddTicks(6939), "Product quanity: neque", new DateTime(2021, 7, 21, 12, 6, 47, 520, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("64afcd13-6b74-44a0-a386-c5759f924e1d"), "Laudantium ipsum nobis commodi dolor est culpa laborum.", "1d89f2ee-c7ec-4eb4-b361-528ff7c6af9e", new DateTime(2020, 3, 18, 1, 59, 23, 471, DateTimeKind.Local).AddTicks(9683), "Product quanity: eveniet", new DateTime(2021, 1, 21, 16, 11, 45, 694, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6656147c-e119-4eb2-8229-18a0ad9df28c"), "Similique doloremque dolore.", "28e314b9-7e94-48ad-afbe-bdbce9598e9f", new DateTime(2017, 10, 17, 8, 9, 46, 208, DateTimeKind.Local).AddTicks(4858), "Product quanity: vero", new DateTime(2021, 3, 14, 11, 32, 58, 819, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a9dea99-d2c8-48e6-9bc6-0efb6c7d25bd"), "Ab sit cumque quae tenetur dolore in.", "af3af055-f1f0-45e4-a398-48d71d45328b", new DateTime(2022, 2, 13, 2, 24, 47, 891, DateTimeKind.Local).AddTicks(8003), "Product quanity: quia", new DateTime(2022, 5, 25, 15, 53, 38, 400, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c69452e-3735-4edc-9094-6e626f847e14"), "Ut quo doloribus quidem quidem repellat maxime molestiae ut.", "2686a9e5-dbfc-4ed7-892d-0c487a355d18", new DateTime(2017, 7, 19, 5, 28, 39, 44, DateTimeKind.Local).AddTicks(4493), "Product quanity: ut", new DateTime(2017, 9, 10, 2, 53, 36, 156, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6d8196b4-28de-400a-ba04-3d40de1b386e"), "Est atque asperiores est sit dolore dolor aut.", "936e2104-26ec-4c30-81cf-8a8314d50b83", new DateTime(2021, 10, 25, 16, 50, 29, 384, DateTimeKind.Local).AddTicks(5671), "Product quanity: voluptatem", new DateTime(2022, 4, 16, 5, 27, 53, 389, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6da9ae38-4d50-4431-9cf7-02a79ba41b58"), "Sapiente ex unde esse quia voluptas.", "fbb47d8b-413a-4578-9784-0e567ff2916d", new DateTime(2017, 9, 16, 6, 7, 44, 650, DateTimeKind.Local).AddTicks(8316), "Product quanity: doloribus", new DateTime(2019, 8, 6, 15, 46, 34, 812, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71b96537-a624-4cfd-9ae3-855816cf2268"), "Sit temporibus omnis est cupiditate in molestiae a at.", "6c70f293-4383-4a3b-a0f7-d7394b28c562", new DateTime(2018, 11, 29, 6, 24, 23, 677, DateTimeKind.Local).AddTicks(3442), "Product quanity: a", new DateTime(2022, 4, 30, 16, 51, 52, 681, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72982571-c431-42ba-a3e0-47d22ccacd60"), "Quam architecto vel et non quaerat.", "4f95f666-6c17-4792-9304-766028ae6aa0", new DateTime(2022, 3, 11, 21, 46, 48, 191, DateTimeKind.Local).AddTicks(2587), "Product quanity: nihil", new DateTime(2022, 4, 22, 8, 35, 3, 486, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7315e271-a6f1-40f5-8593-e630b7750bb5"), "Autem magni rerum aliquam exercitationem et eum.", "8ce6737a-dbfe-4bc7-8d77-1e865fbfeb58", new DateTime(2019, 12, 13, 18, 28, 11, 855, DateTimeKind.Local).AddTicks(9500), "Product quanity: omnis", new DateTime(2021, 10, 24, 9, 30, 3, 594, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73c52aba-3230-4480-87f9-4bd90dc5f1c8"), "Facere consequatur dicta labore qui et et.", "a88c5098-1f4e-44e6-83ad-3ac31005d498", new DateTime(2020, 10, 17, 1, 19, 23, 436, DateTimeKind.Local).AddTicks(3931), "Product quanity: in", new DateTime(2022, 5, 3, 6, 40, 49, 942, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77de9ee9-34b3-49e8-b676-e4c566d5cfcf"), "Ut aut eveniet asperiores atque ut consequatur.", "77f778c7-957a-417e-a9b4-b9eb8ad11e2d", new DateTime(2019, 10, 28, 6, 54, 11, 944, DateTimeKind.Local).AddTicks(7491), "Product quanity: quasi", new DateTime(2021, 5, 28, 4, 36, 38, 389, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c583669-e479-4ed0-81a2-cbfa43415e77"), "Repellendus cum ipsam est soluta id.", "6cf757d9-f6a9-4141-ac95-074ecaa6e9f5", new DateTime(2020, 8, 1, 15, 31, 53, 818, DateTimeKind.Local).AddTicks(4787), "Product quanity: eius", new DateTime(2021, 8, 13, 1, 58, 57, 652, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e2a2391-0cfd-4e0a-b9f9-ef8763a5ceb0"), "Occaecati animi perspiciatis neque aut facilis perferendis.", "938564b2-02c2-478e-a823-f15797dc323c", new DateTime(2018, 4, 22, 15, 28, 32, 523, DateTimeKind.Local).AddTicks(3455), "Product quanity: maiores", new DateTime(2021, 4, 9, 3, 52, 38, 639, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("81014399-5af7-4caa-b558-d12fae02c394"), "Magni consequatur illo.", "cafb2d93-f632-4c36-be36-4fc488b3c599", new DateTime(2022, 4, 2, 10, 24, 49, 533, DateTimeKind.Local).AddTicks(4868), "Product quanity: odio", new DateTime(2022, 5, 13, 4, 44, 2, 587, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8280389b-0a4d-4b87-8976-39a1e81b562e"), "Dolorem qui ut consequatur et magni quas.", "66eae337-b419-4c0f-9a20-c38005e47c53", new DateTime(2020, 6, 23, 23, 0, 29, 57, DateTimeKind.Local).AddTicks(5501), "Product quanity: ipsum", new DateTime(2022, 2, 8, 3, 45, 45, 637, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("893caecf-74b2-4315-b833-ecea63851d0e"), "Repellat ex est saepe.", "e1e1f27f-c11d-44d5-b10f-913ffa0efc04", new DateTime(2020, 5, 5, 17, 40, 33, 415, DateTimeKind.Local).AddTicks(8210), "Product quanity: sunt", new DateTime(2021, 6, 9, 16, 53, 17, 55, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a7ae4b7-e89e-43f4-a889-4143344de6ca"), "Saepe natus sunt a quia labore enim dolorem non est.", "158aee45-c880-443a-9f4d-f85ace88467e", new DateTime(2019, 6, 24, 16, 7, 45, 643, DateTimeKind.Local).AddTicks(7807), "Product quanity: illo", new DateTime(2019, 12, 17, 14, 20, 20, 581, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8bbb108c-fbef-494b-bccd-1e27b0c31373"), "Doloribus error consequatur.", "478ceb0e-1746-4802-9e39-d84f45977c56", new DateTime(2021, 4, 28, 12, 5, 51, 330, DateTimeKind.Local).AddTicks(865), "Product quanity: sed", new DateTime(2022, 6, 8, 20, 4, 50, 611, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d5fef41-1380-4051-a5d4-64ecc05791ee"), "Debitis impedit enim at vel voluptatem.", "78f01b24-2c58-4d94-b99c-6da50afe2a2c", new DateTime(2021, 6, 4, 22, 8, 53, 539, DateTimeKind.Local).AddTicks(8215), "Product quanity: nam", new DateTime(2022, 4, 6, 16, 49, 11, 779, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8fff090a-1fa7-4495-bcd8-09be412463a9"), "Assumenda omnis repellat cum saepe qui ut ut.", "db8aef29-d7e6-4f61-9947-59d0ce48883d", new DateTime(2021, 11, 28, 0, 5, 59, 185, DateTimeKind.Local).AddTicks(6502), "Product quanity: minima", new DateTime(2022, 4, 25, 12, 42, 4, 30, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92a91333-58f8-4378-abd7-04923eb364ac"), "Ut doloribus vel explicabo rerum.", "a3ee74cf-e490-4e08-a4a4-fd411af26d82", new DateTime(2019, 3, 13, 1, 15, 4, 399, DateTimeKind.Local).AddTicks(5823), "Product quanity: autem", new DateTime(2020, 8, 20, 15, 54, 4, 171, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("93888626-fd36-430d-be19-8bfed3564811"), "Consequuntur et aliquam.", "e571203c-f6c2-48bf-910b-c34bbaf1e918", new DateTime(2018, 12, 30, 16, 5, 28, 739, DateTimeKind.Local).AddTicks(8093), "Product quanity: laboriosam", new DateTime(2021, 4, 8, 2, 35, 16, 345, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94adc0a8-f007-461a-a6c7-3e669f323de4"), "Dicta est veritatis beatae necessitatibus assumenda aut.", "88fc64e4-4a01-4e1a-aee9-3a7fb5a3eeae", new DateTime(2021, 9, 29, 23, 5, 5, 278, DateTimeKind.Local).AddTicks(3666), "Product quanity: minima", new DateTime(2022, 6, 25, 19, 49, 53, 787, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9585a17b-67bb-45d8-8cbb-dd8e87753930"), "Voluptas totam ipsam illum.", "7b824b48-a407-4853-a6f2-87a60206b83f", new DateTime(2018, 8, 22, 5, 43, 41, 980, DateTimeKind.Local).AddTicks(2212), "Product quanity: adipisci", new DateTime(2019, 8, 7, 2, 42, 59, 975, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("95939f28-004e-46c0-b0aa-a4ea28b5abb1"), "Rerum harum optio non itaque voluptas porro quis id.", "1f3341c0-64b5-4042-b36f-e319b68543fc", new DateTime(2018, 3, 23, 19, 9, 35, 968, DateTimeKind.Local).AddTicks(6144), "Product quanity: impedit", new DateTime(2021, 7, 19, 11, 53, 27, 204, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e351409-1145-4809-92ad-5dc9882c429e"), "Nemo qui distinctio libero nemo cupiditate voluptas eum sint sequi.", "b247d621-d34b-4d12-99c0-86491c28bcca", new DateTime(2017, 9, 27, 9, 15, 20, 365, DateTimeKind.Local).AddTicks(5421), "Product quanity: nihil", new DateTime(2017, 12, 12, 7, 29, 11, 3, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a3e64405-0532-4f42-8222-5c46f820e7f4"), "Molestiae fugiat libero deserunt qui doloribus mollitia.", "936ebd9a-1afa-464e-a23d-705150f3d36f", new DateTime(2019, 12, 17, 20, 29, 54, 939, DateTimeKind.Local).AddTicks(3236), "Product quanity: commodi", new DateTime(2021, 7, 31, 4, 49, 28, 737, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a69658de-eafe-43be-9ec5-72fdd93a1267"), "Id molestiae repudiandae rerum sit quisquam nihil corporis.", "f888c601-e87c-49bb-be9f-020a15e74129", new DateTime(2021, 10, 1, 16, 58, 51, 439, DateTimeKind.Local).AddTicks(6139), "Product quanity: saepe", new DateTime(2021, 10, 3, 18, 48, 51, 710, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6e473e5-e0cb-45c1-9d8e-3a02e02786cc"), "Voluptas laudantium dolorem eaque atque natus autem porro.", "cf091ee0-6398-4c43-ac94-e60c64f06849", new DateTime(2018, 10, 24, 4, 59, 8, 858, DateTimeKind.Local).AddTicks(7975), "Product quanity: dolorum", new DateTime(2022, 4, 15, 14, 53, 48, 804, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b089e2ca-4ff4-467e-b2f8-7576a43037ba"), "Explicabo consequatur recusandae libero enim quidem.", "6a8e9ff7-27cc-4704-a3cb-6d1871649571", new DateTime(2017, 7, 11, 6, 35, 45, 452, DateTimeKind.Local).AddTicks(8925), "Product quanity: esse", new DateTime(2021, 10, 28, 9, 3, 22, 833, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b2895f7e-fb3a-4e34-aa52-0b43d4341886"), "Sequi dicta repellendus.", "0a31e4cf-44c8-42e9-8ee8-97cf769297e7", new DateTime(2018, 6, 6, 1, 45, 18, 100, DateTimeKind.Local).AddTicks(892), "Product quanity: omnis", new DateTime(2019, 3, 14, 0, 18, 22, 270, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3ad7389-4f63-4771-ab62-1c3177fc7de2"), "Ut suscipit est.", "85cd3460-6792-4be0-bcb0-7534a1157bdf", new DateTime(2021, 3, 7, 4, 23, 2, 143, DateTimeKind.Local).AddTicks(7210), "Product quanity: voluptas", new DateTime(2022, 4, 18, 14, 8, 51, 717, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b4766729-d33b-4977-912f-43a6576889ae"), "Inventore pariatur laborum rerum qui magni amet vero esse.", "82ba4262-92cb-45b6-b650-04004bee274d", new DateTime(2018, 6, 17, 15, 7, 48, 894, DateTimeKind.Local).AddTicks(5640), "Product quanity: possimus", new DateTime(2020, 4, 16, 12, 57, 27, 746, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b4b56bc6-f9b4-414b-ae65-53d0bebb5d98"), "Vel animi aliquam dolor corporis ipsa maiores rerum ea nesciunt.", "71e7bd37-7451-440c-8b69-25c34d85c584", new DateTime(2018, 11, 30, 2, 30, 1, 356, DateTimeKind.Local).AddTicks(6748), "Product quanity: cupiditate", new DateTime(2021, 5, 4, 22, 7, 24, 424, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9a637c0-a4ef-43a2-a268-b048849db3cf"), "Autem ut voluptates itaque enim sint cupiditate rerum impedit hic.", "14799f81-34f1-41d9-abee-2088b301ddb9", new DateTime(2022, 3, 18, 5, 27, 6, 77, DateTimeKind.Local).AddTicks(1692), "Product quanity: dicta", new DateTime(2022, 4, 28, 4, 50, 31, 470, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb8fd9a2-03d1-4cc8-85a8-74706073af47"), "A placeat ut omnis.", "f3ab8332-4294-4aa4-87d1-0c7a157b0900", new DateTime(2018, 8, 26, 11, 13, 13, 183, DateTimeKind.Local).AddTicks(8808), "Product quanity: nesciunt", new DateTime(2020, 12, 6, 16, 21, 28, 443, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bbec775e-1413-4cea-a981-24897f6ca374"), "Rem odit magnam ut ex consequatur neque.", "016bf99a-7bdc-4184-9ca8-6794252f8d68", new DateTime(2022, 4, 13, 19, 32, 58, 257, DateTimeKind.Local).AddTicks(4551), "Product quanity: iusto", new DateTime(2022, 5, 7, 12, 1, 28, 198, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1c004bc-2246-4711-896d-e0a4a6d1b358"), "Et est quas quo non.", "812a191f-1b6a-47a5-bf90-3b28822a2c69", new DateTime(2019, 9, 6, 3, 46, 42, 357, DateTimeKind.Local).AddTicks(2473), "Product quanity: hic", new DateTime(2022, 4, 18, 17, 40, 28, 357, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ccfbd3a2-a0da-493e-9155-af22e02eddea"), "Doloremque quia maxime ea sed ut aut praesentium.", "7503c2ba-e668-4cdd-8539-cd38c861bd6a", new DateTime(2020, 5, 12, 4, 41, 6, 76, DateTimeKind.Local).AddTicks(4361), "Product quanity: esse", new DateTime(2021, 11, 5, 16, 22, 3, 737, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf998a95-24e6-4c96-bd03-805816f702cc"), "Qui recusandae exercitationem doloremque molestiae laudantium commodi.", "5170a11a-b7f3-4144-b0f6-46daff3d53a8", new DateTime(2020, 7, 27, 22, 49, 49, 44, DateTimeKind.Local).AddTicks(5921), "Product quanity: suscipit", new DateTime(2021, 12, 19, 10, 57, 44, 839, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1c87842-19f7-4e56-ac1c-df6b5f8d98bc"), "Aut voluptatem dolores incidunt eos.", "09e58a58-bfb2-49d9-994c-a6d7a603f41e", new DateTime(2019, 3, 5, 7, 11, 5, 256, DateTimeKind.Local).AddTicks(9554), "Product quanity: est", new DateTime(2021, 7, 27, 6, 10, 28, 681, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1d7d143-18f8-4c6e-b448-095cfae6d719"), "Est magnam atque id.", "7d2a7df7-8f57-4489-939a-1e8a99f81aa3", new DateTime(2021, 4, 6, 22, 24, 31, 506, DateTimeKind.Local).AddTicks(1524), "Product quanity: quis", new DateTime(2021, 5, 20, 7, 3, 34, 992, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d751d182-051c-43dc-ad42-5e78bd135d93"), "Et ut ullam enim non est et voluptas.", "5ed1ad49-3df4-4d7a-ba53-4d2ea978ae49", new DateTime(2020, 10, 28, 11, 4, 11, 645, DateTimeKind.Local).AddTicks(1184), "Product quanity: ea", new DateTime(2021, 3, 14, 7, 27, 54, 315, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9deb749-6738-43f9-a0fb-0ef12363f20b"), "Sunt iste enim architecto eaque voluptas at et velit.", "3805027d-1578-4aab-9666-2d242d56a00e", new DateTime(2022, 5, 4, 9, 35, 46, 463, DateTimeKind.Local).AddTicks(8646), "Product quanity: velit", new DateTime(2022, 6, 16, 21, 2, 54, 151, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dbac4fa4-afb0-4a26-adfb-cf6d16ed4b08"), "Voluptatem fuga et fuga velit ducimus perspiciatis eligendi deleniti et.", "41ef546d-0ec8-4267-807b-789613b745f6", new DateTime(2021, 8, 31, 11, 28, 33, 829, DateTimeKind.Local).AddTicks(8955), "Product quanity: cumque", new DateTime(2022, 4, 7, 17, 23, 48, 689, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dc71419e-57aa-48be-ab42-e4a0520405ca"), "Accusantium dolor odio omnis nostrum provident accusamus.", "1d18330e-0023-4a28-9c5e-b3c682e4039c", new DateTime(2020, 2, 19, 3, 24, 33, 259, DateTimeKind.Local).AddTicks(5941), "Product quanity: nam", new DateTime(2021, 3, 31, 17, 55, 9, 423, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de3c0212-4412-4c32-81f8-d39b06386a29"), "Est explicabo et non ipsa veritatis.", "e627bbf9-d3a7-4533-b0e1-524f03247807", new DateTime(2018, 5, 25, 4, 26, 32, 62, DateTimeKind.Local).AddTicks(286), "Product quanity: ab", new DateTime(2021, 10, 7, 14, 49, 11, 607, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("def60371-d717-4eb9-ab28-448e27598216"), "Aliquid voluptatum accusamus eum.", "f6736e0c-28ac-4032-8133-c4c8d756698a", new DateTime(2021, 3, 28, 13, 18, 14, 496, DateTimeKind.Local).AddTicks(8749), "Product quanity: voluptas", new DateTime(2021, 9, 17, 16, 31, 14, 905, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e006231c-ac7b-4426-889d-5b528a9350b4"), "Tempore voluptatibus asperiores.", "8e25a391-0326-477b-960e-745d3677a1a6", new DateTime(2021, 8, 11, 14, 22, 51, 425, DateTimeKind.Local).AddTicks(4086), "Product quanity: explicabo", new DateTime(2022, 2, 20, 4, 48, 39, 145, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1bcd732-b665-4256-9dd8-bd57fa2cb8bc"), "Qui cumque ipsa qui ratione a sed suscipit accusantium.", "f4e17100-7ecf-45f4-8e3a-c45a96de8cf9", new DateTime(2017, 11, 10, 17, 30, 36, 412, DateTimeKind.Local).AddTicks(2177), "Product quanity: modi", new DateTime(2020, 8, 30, 13, 18, 25, 994, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5b5cff4-d13d-4cf4-a0a5-273768ed07c0"), "Dolor quae quia sit blanditiis eos sit qui.", "9bdc9e08-c97c-44fa-9fbf-d4b86c8b3953", new DateTime(2021, 4, 29, 0, 27, 1, 651, DateTimeKind.Local).AddTicks(9041), "Product quanity: qui", new DateTime(2021, 10, 18, 3, 40, 52, 870, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e70653b5-8352-4db0-8e44-76a9868584da"), "Omnis et possimus est repudiandae eum perferendis qui eum aut.", "e4bbc26a-bc1d-4097-a8cb-68623757031d", new DateTime(2017, 9, 9, 15, 8, 32, 83, DateTimeKind.Local).AddTicks(3403), "Product quanity: rem", new DateTime(2018, 6, 30, 4, 58, 1, 526, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7f7cc4f-2d9e-4861-ba64-5891630b07e9"), "Quos libero voluptatem fugit.", "80218df5-3bb7-4e6d-8e28-340bb94ca232", new DateTime(2018, 1, 19, 13, 5, 39, 451, DateTimeKind.Local).AddTicks(4643), "Product quanity: eius", new DateTime(2019, 1, 9, 17, 0, 39, 649, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e912ce50-5c9d-42b3-b73d-f86667bee2b2"), "Enim aut ea aut consequatur molestiae.", "a3fbd68d-fa68-4a9d-8df0-d473f67166e1", new DateTime(2018, 12, 10, 21, 30, 0, 58, DateTimeKind.Local).AddTicks(6164), "Product quanity: voluptas", new DateTime(2019, 5, 19, 21, 9, 20, 132, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eab33d8c-c2f4-4e51-8d6f-36d88d4a96a4"), "Nihil fugit minus dolorem culpa et.", "9eff6f69-5a7d-42b8-b391-c9ad25c4e97e", new DateTime(2019, 9, 21, 17, 16, 8, 534, DateTimeKind.Local).AddTicks(6018), "Product quanity: molestiae", new DateTime(2021, 6, 29, 11, 54, 10, 555, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ecb6681e-23e2-40d3-9c1b-1c76e4a24da8"), "Et veniam assumenda voluptas nihil blanditiis ea ut.", "0787de55-5c24-4499-9ba4-13d2616d4be7", new DateTime(2021, 7, 12, 13, 4, 2, 332, DateTimeKind.Local).AddTicks(6092), "Product quanity: ut", new DateTime(2022, 7, 3, 18, 33, 20, 966, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("efcfcd1e-87d4-4fcb-b84e-fa8630e43e05"), "Voluptates quo ut facere amet voluptas qui id ut illo.", "83b770b1-eaed-42d7-87ea-898051200b86", new DateTime(2019, 8, 9, 11, 1, 3, 707, DateTimeKind.Local).AddTicks(2101), "Product quanity: rem", new DateTime(2022, 2, 26, 8, 10, 42, 181, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f167a52a-b460-4850-ab94-a2886a0b19f4"), "Accusantium minus praesentium.", "6500ed57-5cb8-4d94-a011-86eca0200a11", new DateTime(2020, 10, 28, 21, 44, 6, 280, DateTimeKind.Local).AddTicks(863), "Product quanity: odit", new DateTime(2021, 1, 3, 1, 25, 22, 662, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f308c380-9aaf-4e51-95ea-17b69bf42596"), "Ut sequi et quidem quia.", "037ccf5b-a5db-49c2-996a-2f8237177055", new DateTime(2021, 6, 19, 16, 22, 35, 272, DateTimeKind.Local).AddTicks(3932), "Product quanity: blanditiis", new DateTime(2022, 4, 18, 11, 40, 7, 333, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f43beb69-7a3e-4b35-b8ce-82056b212a65"), "Id sed dolore amet dolorum dolorem fugit veritatis officiis.", "262e831b-92d4-41c1-8074-4423803248a5", new DateTime(2021, 2, 25, 22, 43, 35, 919, DateTimeKind.Local).AddTicks(4739), "Product quanity: quia", new DateTime(2021, 4, 7, 16, 20, 29, 139, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7164f23-4975-4e30-beca-d1b0ea3b1bed"), "Corrupti magni in ut est fugit ut suscipit doloribus.", "d7d08b65-70cc-4486-ab6d-6460200c9f8e", new DateTime(2018, 8, 2, 14, 44, 43, 388, DateTimeKind.Local).AddTicks(1049), "Product quanity: eligendi", new DateTime(2021, 7, 27, 15, 11, 43, 119, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fd088a69-710f-4186-9c8c-79861a3addc9"), "Debitis et sint consequatur consequatur.", "c1d5a99b-16b5-4e1d-86c3-96c3683f806c", new DateTime(2019, 2, 13, 1, 25, 32, 49, DateTimeKind.Local).AddTicks(3154), "Product quanity: debitis", new DateTime(2022, 7, 3, 20, 19, 39, 109, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fdff6b17-242b-4c78-8826-880db014ab9a"), "Exercitationem vero cupiditate.", "e205cdf9-b1ce-4710-99d8-f0452861ca17", new DateTime(2021, 9, 29, 5, 21, 18, 865, DateTimeKind.Local).AddTicks(761), "Product quanity: ab", new DateTime(2022, 6, 4, 2, 21, 12, 547, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("082ec883-a957-459f-b0ce-513da817e2af"), "In veritatis quidem accusantium velit nemo qui doloribus ullam.", "c9eae86c-737d-4153-b0c0-a2b1883f9334", new DateTime(2020, 2, 21, 20, 5, 46, 125, DateTimeKind.Local).AddTicks(3588), "Product serie: 5587777578901", new DateTime(2020, 8, 8, 10, 48, 33, 723, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0adbbf49-89c8-413e-9bfc-800815ec4f30"), "At sed modi est porro dolor quis omnis rerum eveniet.", "50949b47-167d-4db9-992f-fc44a21812fe", new DateTime(2019, 10, 8, 3, 6, 11, 411, DateTimeKind.Local).AddTicks(9834), "Product serie: 0677269531523", new DateTime(2022, 6, 17, 19, 13, 39, 426, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("13dc5804-e835-4248-8861-859caabe74a5"), "Ipsam natus non quos ab.", "06b3aec0-a5a5-47cb-ae43-f3c9401d1619", new DateTime(2020, 4, 10, 5, 45, 7, 851, DateTimeKind.Local).AddTicks(8566), "Product serie: 9091241097509", new DateTime(2022, 1, 10, 10, 41, 53, 984, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("143f957d-9a47-4bb3-9f39-d924b82bb036"), "Tempora dicta et id molestiae corrupti.", "e377481f-91f7-49bd-8f76-7518a2062f9c", new DateTime(2020, 6, 25, 9, 49, 10, 418, DateTimeKind.Local).AddTicks(8635), "Product serie: 6944284404564", new DateTime(2021, 11, 8, 8, 54, 20, 281, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15fd1122-df10-4eed-9785-2268c35dc74e"), "Tempore dolorem facere sed assumenda sed voluptates et.", "d7b550db-6057-47d8-aeaa-601f1569240c", new DateTime(2022, 2, 14, 3, 56, 34, 855, DateTimeKind.Local).AddTicks(2852), "Product serie: 2870847205122", new DateTime(2022, 3, 20, 23, 56, 14, 69, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19409269-8759-44ac-a12e-d3e7e17d3679"), "Quis porro suscipit provident omnis accusamus.", "76b940f4-213e-4792-bdda-e90b89bdb555", new DateTime(2022, 3, 24, 18, 57, 9, 472, DateTimeKind.Local).AddTicks(6371), "Product serie: 6833116698885", new DateTime(2022, 6, 9, 10, 58, 42, 628, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1969c688-e76d-437f-81d4-db2223c7c814"), "Et vitae rerum.", "2a775d0d-8559-404a-9da6-539ad413328d", new DateTime(2017, 9, 14, 5, 18, 59, 218, DateTimeKind.Local).AddTicks(1172), "Product serie: 7401870824902", new DateTime(2022, 3, 23, 17, 1, 5, 409, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ad7554c-bbda-43b1-9999-eac44e9f8a04"), "Corrupti eveniet molestiae nesciunt vitae maxime consequatur veniam quo optio.", "2ee020bc-4c87-4054-9314-a3379e8bdd81", new DateTime(2021, 7, 15, 8, 26, 27, 148, DateTimeKind.Local).AddTicks(8255), "Product serie: 3292032575008", new DateTime(2022, 2, 3, 22, 58, 31, 89, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2099c88e-a455-4ed8-a6c1-e39f6d5c1f40"), "Excepturi consectetur sunt veniam debitis praesentium.", "55c2937a-4b95-4e7b-9027-4b9e9926e152", new DateTime(2018, 10, 14, 12, 9, 0, 66, DateTimeKind.Local).AddTicks(6344), "Product serie: 2244421842124", new DateTime(2020, 11, 27, 9, 29, 37, 651, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22aaa69d-1681-44ae-9ea8-f7ac089d0aa2"), "Eum optio tempore et et.", "0d417ece-a9e5-4909-96d3-db65e6b52c28", new DateTime(2020, 6, 30, 17, 25, 7, 44, DateTimeKind.Local).AddTicks(3086), "Product serie: 4476821180263", new DateTime(2021, 3, 10, 8, 20, 42, 155, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24574117-d510-4dd2-8fd4-0d9cb77130cd"), "Itaque aperiam quod libero error facilis vero tempore blanditiis.", "df6c6ad4-91dd-4cbf-a498-e1c8bbdc2a61", new DateTime(2022, 1, 30, 7, 41, 50, 394, DateTimeKind.Local).AddTicks(4668), "Product serie: 6862534094375", new DateTime(2022, 2, 2, 9, 52, 4, 405, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("27bdcd81-07bc-4ba8-b805-215a441183b2"), "Recusandae porro ratione laborum dicta tempora sit.", "9ae41b92-8459-48a5-85c5-472f2b7b1ca8", new DateTime(2021, 6, 10, 12, 44, 13, 74, DateTimeKind.Local).AddTicks(3474), "Product serie: 8372623080335", new DateTime(2022, 4, 24, 3, 19, 36, 183, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("29b75f4d-7e28-4310-b226-c3acb80136c8"), "Officiis harum culpa eum voluptas laborum consequatur.", "a66ee9b3-ae49-4abc-a1ac-01c6dfedb670", new DateTime(2018, 11, 3, 5, 34, 41, 468, DateTimeKind.Local).AddTicks(5089), "Product serie: 2186321906578", new DateTime(2021, 6, 1, 7, 26, 50, 588, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2a79c384-3d84-4662-9bcd-33c0c7412f55"), "Omnis eligendi ea ab libero eos dolore.", "b9d198fa-ddc3-4f7b-aac8-fe0162c8772b", new DateTime(2022, 2, 14, 0, 50, 44, 510, DateTimeKind.Local).AddTicks(5833), "Product serie: 0456828942921", new DateTime(2022, 3, 30, 19, 5, 42, 839, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2c213f45-7494-4bd1-a245-817a5c33e00d"), "Asperiores illo aperiam ipsum aut sint qui qui facilis modi.", "f287ba42-446f-44ae-8974-3c59ea56bb20", new DateTime(2018, 3, 29, 3, 45, 35, 496, DateTimeKind.Local).AddTicks(800), "Product serie: 0659612298666", new DateTime(2020, 2, 28, 17, 51, 34, 179, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2d3936aa-df30-4313-b02e-5eabeee77ad9"), "Provident autem perferendis cupiditate dolores et ut officiis iusto et.", "bfc3e44d-d9a0-44bf-96a8-eef93a4baa91", new DateTime(2018, 10, 16, 5, 48, 9, 195, DateTimeKind.Local).AddTicks(4390), "Product serie: 6939889420316", new DateTime(2021, 12, 8, 12, 48, 50, 460, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34f1b490-ffa7-441a-91aa-42e223ba1647"), "Aliquam qui placeat voluptatem tempore at nostrum.", "54dd8b19-dd35-4969-9cde-fb6458f9dc66", new DateTime(2018, 2, 23, 19, 10, 50, 863, DateTimeKind.Local).AddTicks(7212), "Product serie: 1160195677124", new DateTime(2022, 2, 15, 17, 8, 46, 624, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3527670b-3034-488a-a27c-1582dfed4f7f"), "Provident quasi eveniet quod et velit est ullam.", "62356ec6-cdf2-4d17-86ee-e8323d10f4f7", new DateTime(2019, 1, 9, 13, 4, 4, 936, DateTimeKind.Local).AddTicks(4903), "Product serie: 4054040109434", new DateTime(2021, 12, 6, 18, 2, 33, 333, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("36771686-c10e-437a-a49e-e8d1260a6cfa"), "Architecto numquam accusantium dolor tempora quaerat labore totam.", "70938658-7941-44a5-a21a-e6f64ae92061", new DateTime(2020, 10, 11, 21, 14, 53, 379, DateTimeKind.Local).AddTicks(6943), "Product serie: 0470811231410", new DateTime(2022, 5, 2, 8, 42, 7, 781, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3bfea30e-7dc7-4e7b-931d-c6cc674df245"), "Soluta quas laborum eos.", "5dd25c10-4cb3-41e6-b6eb-c3699dba7250", new DateTime(2022, 1, 30, 17, 15, 47, 84, DateTimeKind.Local).AddTicks(3502), "Product serie: 6618522395852", new DateTime(2022, 5, 13, 14, 51, 25, 351, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3c1a5f33-d939-4aad-9a26-954c22125117"), "Sed sit rerum est aperiam vero voluptas enim.", "74a707ca-05f6-487d-9999-e1443ace4d26", new DateTime(2021, 10, 29, 1, 29, 41, 550, DateTimeKind.Local).AddTicks(6517), "Product serie: 0168307085349", new DateTime(2022, 2, 14, 5, 7, 5, 246, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("422f0dff-c0b6-4aab-91b2-86c4c99d9b9c"), "Corporis provident tempora.", "389e8665-e1d9-4272-8799-5a5bf5495fb5", new DateTime(2018, 4, 14, 6, 30, 55, 697, DateTimeKind.Local).AddTicks(9701), "Product serie: 7835099924219", new DateTime(2019, 9, 25, 6, 15, 31, 50, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("43776b00-246d-44d4-839f-8486fb6e625d"), "Perspiciatis enim sit ut quibusdam atque.", "e3dffbf5-ac58-4d2c-a14c-2bdb1b430c91", new DateTime(2020, 3, 17, 7, 4, 59, 364, DateTimeKind.Local).AddTicks(219), "Product serie: 5103548692210", new DateTime(2021, 6, 20, 0, 59, 53, 825, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("471150a9-e8aa-4c31-9d8d-167af6b715d4"), "Odit veritatis alias consequatur.", "14aa7c50-429d-4523-a6d1-7a3fc20104d8", new DateTime(2018, 7, 31, 20, 51, 7, 151, DateTimeKind.Local).AddTicks(7348), "Product serie: 9200094753351", new DateTime(2020, 3, 10, 7, 25, 58, 795, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4762f05d-42e9-48eb-b84c-906ba1d9fe3f"), "Quo ea veniam dolor quia qui consectetur est a.", "3b6693c9-4907-44da-a8b8-b63c24e08b36", new DateTime(2020, 7, 6, 9, 55, 28, 983, DateTimeKind.Local).AddTicks(6104), "Product serie: 1470305942807", new DateTime(2020, 9, 28, 10, 54, 18, 215, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4927ded2-d312-4b92-980c-e7efd1963874"), "Animi et voluptas libero in.", "39efa793-1e48-4817-ae36-f2bd018a22c4", new DateTime(2021, 12, 6, 1, 49, 32, 663, DateTimeKind.Local).AddTicks(7779), "Product serie: 9415591501163", new DateTime(2021, 12, 16, 1, 25, 2, 193, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4bcafa11-2fa5-4969-a16a-b24f26058416"), "Autem veritatis porro quas adipisci impedit tempora et.", "37312cf6-3e54-4d1b-94b5-84e96b3fe78b", new DateTime(2019, 4, 10, 17, 0, 47, 418, DateTimeKind.Local).AddTicks(7122), "Product serie: 6762311528027", new DateTime(2021, 6, 16, 12, 16, 37, 686, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4cb33e60-249f-402a-a4a5-7a3cfeb7716e"), "Numquam nobis cupiditate excepturi quod eos iste.", "641f40b3-f07a-43ac-b48a-de93c706fb60", new DateTime(2018, 10, 20, 10, 57, 1, 659, DateTimeKind.Local).AddTicks(8949), "Product serie: 6647526429935", new DateTime(2021, 4, 25, 12, 49, 57, 998, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f18caf6-7bcd-4421-a657-5bceda2cb593"), "Adipisci corporis iusto quaerat et dolores asperiores earum quia.", "74730ff5-870e-4451-a8c9-842837029002", new DateTime(2022, 6, 4, 20, 27, 59, 448, DateTimeKind.Local).AddTicks(2112), "Product serie: 6870300544399", new DateTime(2022, 6, 18, 23, 23, 43, 336, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5216bcf5-3f63-4f26-b4b1-4ad2fc28d4c8"), "Eos non consequuntur.", "8edea42c-6ef7-4b85-87e5-4b8f8cc1c77a", new DateTime(2020, 10, 2, 9, 50, 18, 144, DateTimeKind.Local).AddTicks(8443), "Product serie: 0077606836517", new DateTime(2021, 6, 24, 22, 1, 3, 475, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("547207ed-cdc9-4a77-97d3-289fefabfb33"), "Molestiae non dolores minima dolor sed ut.", "308aa728-5abf-4137-be43-a1a1e940ad4d", new DateTime(2018, 12, 18, 13, 21, 58, 737, DateTimeKind.Local).AddTicks(1655), "Product serie: 1759044410953", new DateTime(2019, 12, 27, 13, 55, 21, 742, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5507421e-a0d5-4ece-967d-468dd39f5175"), "Rem consequatur nihil debitis aut necessitatibus dolores quo.", "c857b9c4-e69b-49c3-901b-96c9866820ea", new DateTime(2018, 9, 29, 6, 2, 53, 505, DateTimeKind.Local).AddTicks(2092), "Product serie: 9197521117919", new DateTime(2022, 2, 10, 12, 11, 32, 380, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("57c33869-117b-46cf-b937-4c62cf73a29b"), "Corporis ratione sed ut omnis dolore.", "345cf70f-4600-4b50-8765-345cde638222", new DateTime(2019, 9, 3, 6, 18, 4, 524, DateTimeKind.Local).AddTicks(1893), "Product serie: 8495007251845", new DateTime(2021, 12, 6, 16, 24, 9, 743, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b373b80-5859-4df1-ba43-a66fc321b402"), "Sint provident temporibus consequuntur est officia.", "47fa34b1-4300-4512-bc49-9d1f42697016", new DateTime(2022, 4, 28, 3, 15, 58, 217, DateTimeKind.Local).AddTicks(4175), "Product serie: 5804239591408", new DateTime(2022, 6, 20, 6, 6, 12, 363, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c87390b-2ecf-4cc4-8b32-f7e1aa84fb88"), "Non assumenda et qui rem est voluptas.", "7100d945-692f-4d29-b1bb-895dfe8bb04c", new DateTime(2018, 9, 25, 12, 28, 31, 258, DateTimeKind.Local).AddTicks(1062), "Product serie: 8081807282778", new DateTime(2021, 3, 14, 10, 0, 7, 601, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("633a19ba-c920-4d52-9b54-2a88ee04c3bc"), "Placeat nisi excepturi optio consequuntur dolorum veritatis porro ut.", "81221d43-8423-4b5c-afa2-af51930d44dc", new DateTime(2018, 10, 19, 10, 40, 8, 964, DateTimeKind.Local).AddTicks(3706), "Product serie: 4328670168087", new DateTime(2019, 6, 26, 2, 59, 43, 683, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6774d410-55cb-44e7-a836-c051e0e033c5"), "Eaque ea eius expedita nihil quia molestiae fugiat.", "ad7431df-81ab-4da4-8966-26ecd372d80c", new DateTime(2022, 3, 25, 19, 42, 51, 580, DateTimeKind.Local).AddTicks(8462), "Product serie: 6112826612009", new DateTime(2022, 6, 8, 14, 51, 48, 5, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6ab51ce8-0edc-4f30-931f-0806f081c091"), "Quo et ducimus possimus quo blanditiis.", "a6a63140-27d1-45fa-a5f7-54ee3573a00d", new DateTime(2021, 1, 26, 23, 12, 44, 890, DateTimeKind.Local).AddTicks(4861), "Product serie: 1584627100439", new DateTime(2021, 10, 30, 21, 55, 45, 809, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b05c69e-e5c2-4248-bdf2-a7b263c8dca9"), "Rerum iure voluptate.", "6371ad0b-1863-4612-b935-70f6c200b7ac", new DateTime(2018, 6, 17, 20, 31, 29, 503, DateTimeKind.Local).AddTicks(5119), "Product serie: 9599070904895", new DateTime(2019, 12, 4, 8, 6, 44, 819, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b783e94-af2d-4a46-898c-037d6ff95a43"), "Commodi eos deleniti.", "518db5aa-9474-4931-a76c-c1b18ba872bf", new DateTime(2020, 5, 25, 16, 9, 15, 254, DateTimeKind.Local).AddTicks(5677), "Product serie: 3407974594882", new DateTime(2020, 11, 28, 23, 15, 39, 324, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6cd9917f-d4e5-4658-b77c-051f605fa3e3"), "Quia officia repellendus impedit aspernatur eos perspiciatis expedita.", "9d072bf8-66cb-4cd6-b673-16e54995181e", new DateTime(2019, 11, 30, 17, 56, 39, 450, DateTimeKind.Local).AddTicks(3694), "Product serie: 7811753895408", new DateTime(2021, 11, 21, 16, 0, 22, 109, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6d601853-62d5-4982-aa04-ea0b908550a7"), "Veniam facilis et eligendi facilis laborum magnam enim esse officia.", "0c27bfc1-00e0-46b7-9795-1c14679227b0", new DateTime(2021, 10, 16, 21, 58, 38, 679, DateTimeKind.Local).AddTicks(7862), "Product serie: 3863212551541", new DateTime(2022, 3, 18, 10, 44, 53, 262, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e046fcf-f6f5-48ab-9dcf-447dab69fe02"), "Debitis ut veniam voluptatibus modi possimus non.", "f691360b-9524-4c45-b451-bcc283fdc46a", new DateTime(2021, 1, 9, 4, 25, 50, 526, DateTimeKind.Local).AddTicks(9169), "Product serie: 6409372299045", new DateTime(2021, 5, 27, 4, 55, 6, 383, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6eaf5457-27df-4e09-b101-844826fc9b24"), "Est consequuntur praesentium rerum.", "c87a1984-29a0-41ca-a41d-b1c7b58bff09", new DateTime(2022, 2, 25, 8, 28, 21, 614, DateTimeKind.Local).AddTicks(3525), "Product serie: 4025304637710", new DateTime(2022, 3, 29, 3, 51, 33, 797, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6ec66595-4923-44cf-843a-e45519109208"), "Molestias voluptatem facere.", "7996d853-cd22-42c7-a463-6130ec9e20f0", new DateTime(2021, 2, 20, 14, 2, 21, 417, DateTimeKind.Local).AddTicks(7010), "Product serie: 0240480888297", new DateTime(2022, 4, 6, 5, 42, 13, 606, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6f277c27-431b-47f5-a092-f9972ad20a53"), "Aliquam aut hic in porro tenetur eos est blanditiis deserunt.", "baca46f9-a467-46ac-b688-ac8045bf953f", new DateTime(2018, 10, 26, 19, 7, 48, 444, DateTimeKind.Local).AddTicks(2458), "Product serie: 8345422178077", new DateTime(2021, 6, 4, 5, 2, 11, 401, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71a48f62-8997-4eb0-b8b6-51b0e4c7c419"), "Qui qui temporibus dolorem et qui non.", "7899f8f6-1d65-48f0-b77c-2b0449be58b1", new DateTime(2018, 1, 22, 12, 26, 28, 970, DateTimeKind.Local).AddTicks(7911), "Product serie: 3946379355006", new DateTime(2018, 9, 4, 11, 17, 4, 380, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("735dcdf4-6f01-4fe1-bf0e-beef8822307f"), "Totam in eaque voluptas omnis rerum magni.", "8c7328a0-affa-48a6-ac29-ca2d6fa87c07", new DateTime(2018, 7, 5, 10, 1, 13, 916, DateTimeKind.Local).AddTicks(9711), "Product serie: 4861683038577", new DateTime(2018, 10, 8, 11, 8, 49, 887, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("791aa596-f6f3-4de4-9361-5174f2412fd9"), "Aut sunt sunt placeat molestiae modi dolores id suscipit et.", "2deb6f86-498a-4e98-bc77-da0a94c7a603", new DateTime(2020, 5, 20, 3, 21, 43, 190, DateTimeKind.Local).AddTicks(780), "Product serie: 7663495039349", new DateTime(2022, 5, 7, 16, 48, 21, 546, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7929534c-0ff3-464e-a2fb-ab1df50bff28"), "Neque vel excepturi ducimus.", "9b34d136-f1b3-440b-b55a-0297f41e880b", new DateTime(2019, 10, 29, 12, 23, 49, 235, DateTimeKind.Local).AddTicks(3905), "Product serie: 4139218368858", new DateTime(2020, 2, 14, 19, 16, 54, 955, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b49abf8-3986-4f2c-bdcb-13d476c7d3d0"), "Voluptas mollitia aut rem vitae repudiandae facilis dolorem voluptates provident.", "f461c003-0fab-41c5-af84-83c9d05bf347", new DateTime(2019, 3, 24, 9, 29, 20, 558, DateTimeKind.Local).AddTicks(5946), "Product serie: 0917697410060", new DateTime(2019, 8, 19, 17, 46, 13, 577, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7eafaa4e-3959-4649-a39b-97c2b60cbd65"), "Perspiciatis ducimus assumenda labore possimus doloremque nemo porro qui quibusdam.", "e62d79e3-a070-4a00-bc9a-46ce6c6e6c8c", new DateTime(2018, 10, 15, 13, 59, 30, 876, DateTimeKind.Local).AddTicks(3080), "Product serie: 9711468881988", new DateTime(2020, 3, 2, 19, 31, 37, 967, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7f25782c-c064-4ec0-828b-a66c913f9810"), "Iure occaecati ipsam sequi ea.", "c990c0e1-b332-4880-a18b-c6e19466a764", new DateTime(2019, 12, 18, 6, 15, 12, 737, DateTimeKind.Local).AddTicks(4810), "Product serie: 4918866079640", new DateTime(2020, 2, 27, 20, 35, 50, 848, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("806f4de6-af0d-426d-a7df-53b939799c43"), "Sequi laudantium sunt nobis et neque cupiditate aliquid est.", "f9dd034b-aa4c-4544-8e8f-53d9480301c5", new DateTime(2018, 4, 7, 22, 17, 45, 164, DateTimeKind.Local).AddTicks(7679), "Product serie: 2035433376475", new DateTime(2020, 9, 17, 16, 8, 40, 67, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("840f6715-51d1-4380-8bc7-8c8696677e24"), "Laboriosam et perspiciatis.", "b6c541ac-2858-462e-a06f-447a675854c2", new DateTime(2022, 5, 9, 13, 17, 53, 572, DateTimeKind.Local).AddTicks(9155), "Product serie: 5779073213154", new DateTime(2022, 6, 29, 11, 26, 7, 869, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84b8d783-568a-49ff-b0e8-201e4c9085dd"), "Natus velit dolor inventore dicta.", "4441d194-5ebd-4e19-9e26-1ff8a7376bd3", new DateTime(2017, 8, 1, 6, 0, 12, 708, DateTimeKind.Local).AddTicks(6230), "Product serie: 0981739940624", new DateTime(2021, 5, 24, 8, 15, 10, 413, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84e09ba3-f262-4190-b72d-c08c6ace86af"), "Tenetur unde nam sed quis distinctio.", "c1ee80fc-1ffa-4ce3-a4e8-0f166e8cc261", new DateTime(2019, 12, 24, 21, 13, 9, 561, DateTimeKind.Local).AddTicks(9865), "Product serie: 0187434135604", new DateTime(2021, 6, 19, 11, 36, 55, 379, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e836310-88b8-4df8-916d-011c6e5dcac4"), "Cumque sint accusamus nulla.", "1d14c91d-c166-48dd-87d3-100abaf3d790", new DateTime(2017, 9, 26, 10, 48, 44, 609, DateTimeKind.Local).AddTicks(1088), "Product serie: 6287867860938", new DateTime(2019, 1, 1, 21, 8, 27, 306, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90d00271-0992-4279-acdc-d52e4c7603e9"), "Aut reiciendis distinctio accusantium voluptate.", "25452b3e-6979-4517-aac7-a947f831746c", new DateTime(2020, 6, 11, 4, 43, 16, 364, DateTimeKind.Local).AddTicks(1521), "Product serie: 5308344550843", new DateTime(2020, 8, 4, 4, 35, 21, 585, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("919e414a-1cda-4167-bf46-66e3da4b1b16"), "Asperiores accusamus cumque praesentium.", "042d4da8-2410-454c-be3d-45078c173087", new DateTime(2019, 11, 14, 5, 47, 30, 658, DateTimeKind.Local).AddTicks(1096), "Product serie: 4679011242448", new DateTime(2022, 2, 4, 17, 23, 3, 241, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("95d203a0-d370-4d1c-8183-3e378868c1b6"), "Excepturi et provident.", "af5ad89d-fa90-4e6e-b6ab-b806430be799", new DateTime(2017, 11, 9, 22, 47, 47, 699, DateTimeKind.Local).AddTicks(618), "Product serie: 0529592228697", new DateTime(2022, 1, 5, 4, 36, 49, 957, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9611ddfb-bbf2-4700-bc00-a49db829c369"), "Veniam delectus doloribus.", "f4ce3936-cfe0-41c4-b052-1d038703fc2f", new DateTime(2021, 8, 11, 4, 20, 8, 107, DateTimeKind.Local).AddTicks(8077), "Product serie: 4122707228443", new DateTime(2022, 3, 12, 0, 51, 21, 852, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("998f46ca-a531-4984-aee9-32c8b224a037"), "Voluptates fugit quis nam.", "97c45952-9861-4aee-b96e-21cb2523ea6b", new DateTime(2019, 5, 24, 19, 24, 34, 763, DateTimeKind.Local).AddTicks(1435), "Product serie: 9692140074747", new DateTime(2020, 1, 9, 21, 32, 59, 503, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9bcc4c90-e6cc-465e-80f7-1061bcebbe2e"), "Voluptate est fuga quia vitae aut quod.", "71ae9e20-4c4a-4c63-b73c-b7853c1e73cd", new DateTime(2019, 12, 28, 19, 39, 3, 846, DateTimeKind.Local).AddTicks(1474), "Product serie: 5933825345948", new DateTime(2021, 9, 16, 12, 37, 15, 185, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9bfd0539-dbba-4a72-b5d4-b7608b71ac86"), "Laudantium hic porro.", "2fc92baf-7a45-4595-9dbb-d1c48d391651", new DateTime(2021, 4, 26, 3, 8, 18, 997, DateTimeKind.Local).AddTicks(157), "Product serie: 6394942656123", new DateTime(2021, 12, 28, 21, 59, 14, 931, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e011af9-cb14-4977-bc05-33a2f9881d36"), "Aut doloribus ipsam provident autem explicabo expedita.", "29d74655-6eec-4a50-a444-2f358c3a656f", new DateTime(2020, 4, 3, 9, 44, 38, 707, DateTimeKind.Local).AddTicks(9608), "Product serie: 1627960376700", new DateTime(2020, 7, 11, 10, 45, 34, 228, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a47ea8d8-de52-42a8-951c-1dee53fcef74"), "Iusto ex iure temporibus molestiae voluptates aut porro aut ut.", "be9d90c6-c510-4819-8a68-6a4baf7e9fa8", new DateTime(2021, 8, 9, 8, 27, 41, 88, DateTimeKind.Local).AddTicks(5554), "Product serie: 4582661359186", new DateTime(2022, 2, 5, 17, 6, 8, 571, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9050fd7-4707-4db1-80cf-ca5c4768469f"), "Id praesentium perspiciatis.", "f5acdc3e-c472-4126-ace0-bc62b8dda4c9", new DateTime(2017, 8, 22, 9, 16, 40, 242, DateTimeKind.Local).AddTicks(913), "Product serie: 8199998090710", new DateTime(2018, 2, 24, 0, 59, 18, 685, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b35b25a2-7050-454a-86b6-0dff60936ea5"), "Voluptatem vel culpa laborum laudantium quisquam.", "3a2f952a-a620-49c4-8ffb-11f8c47c5fb0", new DateTime(2018, 8, 23, 10, 35, 18, 521, DateTimeKind.Local).AddTicks(4986), "Product serie: 8173377981899", new DateTime(2018, 10, 17, 20, 7, 6, 76, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b43d517a-ab6d-4864-88f2-81caa5cbb4a8"), "Occaecati natus asperiores quam qui fugit quibusdam officia asperiores iste.", "9b55f952-4658-435b-9c71-8f95171d2c50", new DateTime(2021, 3, 19, 10, 40, 18, 116, DateTimeKind.Local).AddTicks(2229), "Product serie: 8109042520001", new DateTime(2022, 1, 28, 15, 45, 25, 740, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0dc806b-60ba-4315-a3fe-3d484aa2f3f5"), "Commodi aperiam enim dolorem pariatur temporibus voluptas earum nisi.", "ce1e770c-13af-4408-88e7-7cb13889fbc6", new DateTime(2021, 12, 11, 16, 32, 52, 159, DateTimeKind.Local).AddTicks(5143), "Product serie: 9178383200520", new DateTime(2022, 2, 11, 10, 48, 24, 857, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c14b3b16-dec2-4b3d-a48f-f276f1c2701d"), "Alias ut dolorem.", "6fc7593f-fa13-4f97-b951-ff58d2bad8ff", new DateTime(2022, 4, 13, 2, 9, 22, 878, DateTimeKind.Local).AddTicks(8863), "Product serie: 3862340737551", new DateTime(2022, 5, 8, 11, 45, 26, 241, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1c32be4-dd87-4d26-a1e6-bb73c65c2f7d"), "Ipsam cum sunt.", "cdff3427-9882-42df-95a2-4332ad7d68c0", new DateTime(2019, 5, 9, 22, 36, 34, 862, DateTimeKind.Local).AddTicks(6072), "Product serie: 4606671203151", new DateTime(2021, 4, 6, 12, 2, 54, 601, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c4ae2d59-07b2-40b6-b500-3c12e39f7a81"), "Minus rem possimus consequatur est est est nihil natus sed.", "0e7b366a-2082-4d9b-94fc-578c46d1af81", new DateTime(2022, 7, 1, 2, 58, 48, 401, DateTimeKind.Local).AddTicks(1042), "Product serie: 1873337747271", new DateTime(2022, 7, 2, 20, 11, 57, 479, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c70e05a4-7120-4155-a343-1b72ead0e987"), "Nesciunt voluptas non blanditiis et itaque incidunt.", "5856bf21-b697-4e91-bfa8-e991dd921210", new DateTime(2018, 4, 17, 6, 12, 57, 126, DateTimeKind.Local).AddTicks(4881), "Product serie: 8393652225634", new DateTime(2021, 10, 4, 6, 4, 39, 225, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7490636-a9dc-4e79-af1e-da36ec031c8b"), "Occaecati tenetur amet dolor nulla nisi accusamus sunt rerum maxime.", "318d4559-8a27-4648-a282-35d67c42eba0", new DateTime(2017, 8, 27, 20, 45, 47, 760, DateTimeKind.Local).AddTicks(8008), "Product serie: 6515141865448", new DateTime(2021, 4, 8, 7, 15, 24, 520, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c74d5491-741c-4dd9-afb5-41a20b0b9309"), "Optio mollitia delectus.", "f85ef6c4-d046-462e-be6d-675496fac4b3", new DateTime(2021, 6, 7, 11, 56, 40, 189, DateTimeKind.Local).AddTicks(7204), "Product serie: 3290311205509", new DateTime(2022, 6, 27, 6, 16, 3, 681, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd2db96e-9fd9-4991-bfb6-cc93c0131294"), "Dolore adipisci maiores dignissimos sunt animi sit.", "680df732-29ef-4922-be1d-2029184890fd", new DateTime(2018, 7, 21, 7, 11, 34, 810, DateTimeKind.Local).AddTicks(1128), "Product serie: 5074361828103", new DateTime(2020, 11, 15, 2, 46, 22, 959, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd8511d1-679e-4c0e-b0b1-fb7f9419c40c"), "Qui eaque sunt esse fuga consequatur sed.", "221c280b-2205-4e01-8160-6e1634f1569d", new DateTime(2021, 4, 7, 4, 34, 43, 428, DateTimeKind.Local).AddTicks(2079), "Product serie: 6880869452240", new DateTime(2021, 10, 30, 1, 20, 40, 491, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cec7396c-8072-4d33-896f-71190ad608b2"), "Sunt officiis ab sit.", "1ef665f6-2979-4a67-89bc-f29fd25751d9", new DateTime(2019, 7, 30, 19, 47, 42, 225, DateTimeKind.Local).AddTicks(3225), "Product serie: 3753640153953", new DateTime(2021, 11, 23, 21, 18, 5, 682, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d0cb8e17-c362-4595-a6d7-7e945a285834"), "Occaecati sed ea.", "8e11d520-378c-4436-8020-2d8bb69b53fa", new DateTime(2021, 12, 15, 1, 57, 33, 535, DateTimeKind.Local).AddTicks(3162), "Product serie: 5498564521959", new DateTime(2021, 12, 28, 15, 37, 35, 301, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d31f9714-9e6a-45da-adaf-aad538eb4480"), "Tempore enim consequatur error sed voluptatem consectetur magni et.", "c65e965f-a67c-4822-bf2a-f9cbb8d2c374", new DateTime(2019, 5, 21, 18, 12, 14, 262, DateTimeKind.Local).AddTicks(9879), "Product serie: 0130018009020", new DateTime(2020, 4, 26, 13, 59, 43, 167, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db38ec87-a9ee-412c-8a9c-684185ce35f1"), "Odit qui doloremque sed corporis ab similique.", "1d368473-915f-4476-8efe-0486ce698fdd", new DateTime(2018, 1, 24, 2, 45, 26, 965, DateTimeKind.Local).AddTicks(9072), "Product serie: 7475704940489", new DateTime(2018, 5, 11, 22, 41, 27, 556, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dd4d6179-cd6f-4331-ba05-a22103908759"), "Repellat sed autem occaecati est corrupti cupiditate.", "32e05524-cfe0-43f2-bd55-8df89849ef8d", new DateTime(2019, 12, 4, 3, 14, 32, 350, DateTimeKind.Local).AddTicks(8965), "Product serie: 8171782703792", new DateTime(2020, 6, 28, 17, 30, 9, 765, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e0356ca3-c6a3-4f27-b05a-cfbbd79e88c6"), "Consequatur aut corrupti aut vel consequatur reprehenderit ab accusamus.", "71c38d0b-cf21-45a2-9646-56f357e070f2", new DateTime(2017, 8, 12, 6, 34, 27, 184, DateTimeKind.Local).AddTicks(1053), "Product serie: 0257471744319", new DateTime(2020, 6, 16, 16, 15, 48, 720, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e200332e-a77b-40dd-a28b-7c8f35c442c4"), "Consequatur animi sequi qui enim et in.", "a278a83d-1c2a-47a0-a872-7899b3e11da5", new DateTime(2021, 9, 24, 3, 20, 38, 813, DateTimeKind.Local).AddTicks(3099), "Product serie: 9919302454262", new DateTime(2022, 4, 4, 1, 47, 12, 969, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3b188d4-5271-4170-9ff1-b71b9b14fcf4"), "Error veniam dolores placeat reprehenderit.", "2625ee63-590e-41b0-8900-d6c57e8baf7f", new DateTime(2021, 2, 9, 5, 30, 58, 174, DateTimeKind.Local).AddTicks(8986), "Product serie: 3866633730427", new DateTime(2021, 6, 9, 20, 45, 47, 192, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3e39eff-7558-4cea-aa27-f50c33fd5733"), "In molestiae vitae sunt consequatur pariatur nihil cum expedita consequatur.", "82cacb21-9847-44aa-bb24-c577670d3654", new DateTime(2020, 10, 10, 2, 10, 57, 385, DateTimeKind.Local).AddTicks(5396), "Product serie: 7923242006414", new DateTime(2022, 3, 3, 22, 13, 48, 619, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6418c72-7d74-424e-8b4a-0b4990af3aec"), "Facilis qui qui.", "0c12d133-be3a-4512-97c2-bba85ffbeb16", new DateTime(2018, 12, 19, 6, 57, 50, 495, DateTimeKind.Local).AddTicks(1041), "Product serie: 2683337895655", new DateTime(2021, 12, 2, 10, 19, 5, 169, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e797bd2c-855d-4031-982b-5ecbfdc8d757"), "Est eveniet blanditiis ex nam dolorum blanditiis nulla quia.", "e1724096-bd55-4daf-9461-b3f745bf0350", new DateTime(2022, 2, 23, 20, 40, 38, 670, DateTimeKind.Local).AddTicks(6835), "Product serie: 3140369416566", new DateTime(2022, 4, 11, 3, 48, 41, 593, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ea20ecb2-84a6-4743-b6c0-87a124bdb7c6"), "Iusto pariatur enim vitae ut.", "61224f1c-05a4-4699-a4eb-bcc66ba6254b", new DateTime(2020, 8, 4, 0, 39, 51, 992, DateTimeKind.Local).AddTicks(1375), "Product serie: 1065590819301", new DateTime(2021, 10, 22, 15, 31, 42, 72, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec4a6fc3-141b-460d-a9b4-461ab2e45279"), "Et veritatis nihil et consequatur repellat omnis voluptas ipsum harum.", "751c8985-83bb-4e83-a57a-d8a64e1196e8", new DateTime(2022, 1, 30, 21, 22, 32, 250, DateTimeKind.Local).AddTicks(6044), "Product serie: 8019880104908", new DateTime(2022, 6, 22, 21, 55, 3, 762, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef5f7066-59c3-45b1-b74b-e42e1e5f84ca"), "Similique voluptatum assumenda qui a est dignissimos amet error et.", "c9d605e1-75d5-4b96-8f54-ab935ab0268f", new DateTime(2021, 10, 7, 10, 28, 17, 320, DateTimeKind.Local).AddTicks(1824), "Product serie: 8353021916693", new DateTime(2022, 2, 12, 0, 21, 0, 467, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f190bdad-5032-4363-9d67-c0887f197582"), "Hic qui nulla dolorum.", "fa145525-348d-4b94-8f86-480d057ae6f5", new DateTime(2019, 9, 22, 23, 38, 11, 613, DateTimeKind.Local).AddTicks(4068), "Product serie: 5540923728513", new DateTime(2021, 3, 21, 14, 45, 50, 547, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f238c0b2-e965-4002-a9a0-d91c3ed2507d"), "Sed vel quo provident maxime officia quia corporis.", "8472332a-1585-45f4-80f4-ee3e19452b51", new DateTime(2019, 6, 28, 16, 38, 29, 42, DateTimeKind.Local).AddTicks(7024), "Product serie: 0111689576400", new DateTime(2020, 1, 6, 1, 9, 59, 660, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f30beec8-c87e-449d-90ad-2e869bbb7228"), "Nihil dolorem suscipit ipsum voluptas labore labore.", "088349c7-ce36-4394-923b-fd503116af3e", new DateTime(2019, 4, 15, 13, 43, 15, 969, DateTimeKind.Local).AddTicks(8480), "Product serie: 2800978403487", new DateTime(2019, 9, 28, 22, 25, 52, 405, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa6fd3ba-ade3-44ba-b04d-ab21c4ea9678"), "Nihil velit quis possimus harum culpa error.", "92060a78-ee35-4429-b549-5ae5cbac8d6b", new DateTime(2018, 2, 24, 17, 16, 47, 417, DateTimeKind.Local).AddTicks(2400), "Product serie: 4239850876855", new DateTime(2022, 2, 12, 14, 16, 14, 848, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb834887-94fb-4691-b8e4-342aee78967c"), "Quia architecto sequi.", "e63cf60d-5390-4a61-b14b-8716bcf90912", new DateTime(2018, 3, 19, 22, 12, 34, 471, DateTimeKind.Local).AddTicks(2652), "Product serie: 8170144946624", new DateTime(2020, 5, 25, 17, 32, 25, 9, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fdfb63ef-ea84-4c59-809a-343fd9d9ee60"), "Dolores nesciunt repellat asperiores.", "baa1054c-2b3e-4e20-ba64-7eb5e2ca42fd", new DateTime(2019, 8, 15, 10, 55, 15, 144, DateTimeKind.Local).AddTicks(1117), "Product serie: 4496876539137", new DateTime(2022, 6, 14, 5, 20, 35, 57, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("feee4536-96ba-4435-ba58-e5c2d633b67c"), "Qui quisquam eos aut.", "e894b2cc-9883-4693-a17c-6388c65e0e63", new DateTime(2019, 1, 13, 7, 31, 21, 338, DateTimeKind.Local).AddTicks(5006), "Product serie: 8363990014535", new DateTime(2020, 5, 25, 8, 55, 16, 781, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("007b6ff8-b2e6-444b-abfe-a20b386cef50"), "Aliquam cupiditate dolore est aut quis ducimus est.", "c86ef4b3-a0b6-4841-823e-b305b985742c", new DateTime(2018, 3, 10, 15, 35, 52, 913, DateTimeKind.Local).AddTicks(6157), "Product type: nobis", new DateTime(2022, 4, 7, 9, 51, 40, 981, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0147b3fe-ed20-406d-b179-7c672e111fc9"), "Voluptas numquam voluptatem et.", "bb55fab8-896e-4ebc-8db3-46561571f26d", new DateTime(2019, 2, 10, 7, 20, 49, 917, DateTimeKind.Local).AddTicks(4985), "Product type: modi", new DateTime(2022, 1, 3, 5, 37, 5, 758, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("02e3c620-db05-427c-a73a-29c1527b1023"), "Voluptatem deserunt et fugit omnis delectus iste.", "526f6145-0930-46bc-a4af-0f656c96b737", new DateTime(2022, 4, 27, 12, 48, 26, 731, DateTimeKind.Local).AddTicks(4740), "Product type: provident", new DateTime(2022, 5, 18, 21, 3, 57, 720, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0549c739-045c-4626-aa00-48308a17c78b"), "Quia esse cum et totam magnam odio.", "53627a4d-2440-4093-b025-2a97b2b6324f", new DateTime(2021, 1, 22, 14, 20, 31, 887, DateTimeKind.Local).AddTicks(2458), "Product type: aut", new DateTime(2021, 11, 28, 2, 15, 7, 192, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05fb5005-b50b-44aa-8c9e-d09c14d7201c"), "At tempore et aut et.", "c6a095d6-90d1-46b4-9aec-1a2f6e9384bd", new DateTime(2022, 5, 31, 0, 9, 21, 471, DateTimeKind.Local).AddTicks(2364), "Product type: non", new DateTime(2022, 7, 2, 5, 45, 35, 913, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("077c6826-64fb-4b79-8f21-a7a51c71847e"), "Qui omnis temporibus et voluptatem.", "21e35827-20bc-4b37-ab24-1cb0f6ae8c10", new DateTime(2020, 10, 21, 12, 41, 37, 189, DateTimeKind.Local).AddTicks(9284), "Product type: placeat", new DateTime(2021, 11, 4, 1, 3, 33, 818, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("092a9bbe-e3f2-4b30-8fbf-8f364e991df6"), "Enim est repudiandae quas sunt aut.", "5e381348-0af0-4d43-947b-4b9cc43794b8", new DateTime(2019, 5, 13, 14, 44, 33, 291, DateTimeKind.Local).AddTicks(5576), "Product type: repellendus", new DateTime(2021, 12, 31, 3, 48, 7, 420, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("10d4d77b-b5e2-4f6d-bbd0-3b1c627b3ef2"), "Maxime voluptate facere quos porro qui et occaecati necessitatibus.", "5d8d20d0-dafb-46aa-a9cb-e7a37904c56a", new DateTime(2019, 4, 7, 18, 9, 27, 958, DateTimeKind.Local).AddTicks(4573), "Product type: aspernatur", new DateTime(2021, 8, 10, 19, 41, 43, 506, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1301fcf1-7fbe-4d16-9687-015b710b02b5"), "Natus rem ut omnis dolor inventore.", "940ad505-8b6d-46f1-b239-906044590a30", new DateTime(2020, 5, 11, 4, 19, 29, 24, DateTimeKind.Local).AddTicks(627), "Product type: commodi", new DateTime(2020, 6, 6, 13, 31, 49, 859, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("148647de-a063-47aa-8e54-6762c10eba12"), "Id est iusto aspernatur omnis voluptas quo voluptatem veritatis.", "15e201bb-51f6-437f-a881-78d6c3601a56", new DateTime(2018, 8, 20, 20, 18, 37, 486, DateTimeKind.Local).AddTicks(2225), "Product type: eius", new DateTime(2019, 4, 8, 10, 25, 20, 11, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15277290-1c78-44a0-848f-4d87b071e4d9"), "Veniam dolorem et dolor nihil.", "97939b31-f5b2-4c97-b184-5a4949b88e1b", new DateTime(2020, 9, 18, 16, 33, 2, 288, DateTimeKind.Local).AddTicks(5064), "Product type: est", new DateTime(2021, 2, 21, 11, 33, 33, 916, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15506dfb-7cff-46be-903a-964fa5a12ed8"), "Eveniet enim incidunt.", "5354d225-2dfd-440e-9943-cd77a845d9e6", new DateTime(2021, 9, 14, 8, 31, 3, 645, DateTimeKind.Local).AddTicks(7645), "Product type: natus", new DateTime(2022, 4, 2, 9, 52, 36, 3, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1be0bfa6-c222-49d1-9923-81b6c3aeb2e2"), "Quasi pariatur perspiciatis ullam.", "6e71b010-cab8-42df-a60e-0ed860262f85", new DateTime(2021, 10, 6, 13, 7, 56, 913, DateTimeKind.Local).AddTicks(1896), "Product type: ut", new DateTime(2022, 1, 21, 0, 40, 59, 480, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22e9161d-8900-412b-9590-7db25650510a"), "Tempora ut sunt.", "3c139369-9b89-4940-86f6-d621b6fd76d4", new DateTime(2019, 4, 22, 19, 23, 35, 977, DateTimeKind.Local).AddTicks(9436), "Product type: non", new DateTime(2021, 11, 29, 12, 25, 7, 486, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23f123ec-7b87-4750-9a2e-13f563db63d2"), "Numquam molestiae odio dolore dolores natus et debitis eos.", "9d96852a-8bb4-4502-8d72-6a8b0d8d79ee", new DateTime(2018, 9, 30, 20, 51, 35, 884, DateTimeKind.Local).AddTicks(5166), "Product type: iusto", new DateTime(2021, 2, 3, 7, 57, 5, 461, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2acf1ae5-6724-4552-8a3a-987c73d4e739"), "Ea nam cum.", "dd3a17bd-bfaf-46da-a583-5e1c3e717940", new DateTime(2018, 12, 6, 0, 41, 3, 444, DateTimeKind.Local).AddTicks(9246), "Product type: exercitationem", new DateTime(2020, 2, 23, 17, 40, 39, 663, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2bc9a213-d602-47c3-8dae-0e4dbf4f91b9"), "Accusamus doloribus iste ut dolor.", "a6b9a3e5-633f-470f-a9e3-9b9fcbe29e57", new DateTime(2021, 9, 16, 11, 32, 18, 699, DateTimeKind.Local).AddTicks(2182), "Product type: libero", new DateTime(2021, 10, 30, 14, 55, 50, 807, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2bea861e-a9bb-44d2-a92b-c5e926c0e91f"), "Eveniet quis omnis et hic voluptas voluptatum eos porro beatae.", "dda462de-c990-4972-a47a-b2a507e371bd", new DateTime(2020, 4, 19, 6, 30, 12, 854, DateTimeKind.Local).AddTicks(6772), "Product type: pariatur", new DateTime(2020, 11, 16, 18, 19, 16, 909, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2bf637d3-a9c9-4f3a-a206-053f7e34d2a2"), "Autem cum eligendi sequi et possimus id.", "3a5d393e-93d7-4861-b996-2c5825a4dfdf", new DateTime(2018, 7, 24, 6, 12, 57, 720, DateTimeKind.Local).AddTicks(8884), "Product type: placeat", new DateTime(2020, 8, 25, 7, 1, 28, 770, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("300f8799-90c8-43f9-84dd-9a43ce3f7146"), "Et enim qui illum consequatur fuga nihil.", "980f5ccb-4f3c-4f05-9129-c94d9e38828c", new DateTime(2022, 2, 15, 3, 28, 56, 25, DateTimeKind.Local).AddTicks(6507), "Product type: est", new DateTime(2022, 3, 17, 18, 13, 36, 879, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3115ce11-f54b-4ffa-84e8-038443e19db8"), "Aut odit minima aut architecto minima odio.", "895d7667-4d6d-4d88-a11a-d099b9112d0c", new DateTime(2020, 3, 3, 20, 51, 18, 480, DateTimeKind.Local).AddTicks(7191), "Product type: laborum", new DateTime(2021, 8, 15, 5, 5, 35, 796, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("317d24a4-d198-46b4-bfb5-ea7727b5b2e2"), "Maiores vero provident.", "4a517162-b368-48a2-b7e5-1d3afd90fd7a", new DateTime(2019, 4, 26, 4, 52, 5, 492, DateTimeKind.Local).AddTicks(285), "Product type: nam", new DateTime(2021, 2, 9, 14, 49, 56, 943, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32383615-5910-4dd8-9777-294b67327f9d"), "Et quis consequuntur accusamus voluptas explicabo.", "1ec6b059-70a7-4a3e-a083-4d26f4536625", new DateTime(2022, 3, 10, 16, 8, 1, 70, DateTimeKind.Local).AddTicks(4088), "Product type: quam", new DateTime(2022, 4, 28, 10, 56, 42, 3, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34e59fae-7d73-4887-be1f-95450cfc7c02"), "Commodi quisquam voluptas animi sed.", "81bd6300-6da5-4c7e-aec7-0ab065ceeecd", new DateTime(2019, 2, 25, 22, 56, 58, 746, DateTimeKind.Local).AddTicks(3484), "Product type: ut", new DateTime(2021, 11, 12, 5, 57, 37, 315, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35201d74-a32c-4594-bcdf-e9061e47d424"), "Cupiditate consequatur in nihil laudantium vel voluptatem optio vel eos.", "282b5efb-9cc4-471c-bd45-932e3b2f49a2", new DateTime(2022, 5, 25, 5, 51, 17, 310, DateTimeKind.Local).AddTicks(1519), "Product type: corporis", new DateTime(2022, 6, 30, 5, 13, 12, 311, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("40d3fa0f-b811-4595-9d90-f91295719f5c"), "Provident sequi sit corporis quae et ratione.", "f74350dc-9e46-481a-b781-559aac044d50", new DateTime(2019, 10, 17, 17, 3, 39, 522, DateTimeKind.Local).AddTicks(7469), "Product type: nulla", new DateTime(2021, 1, 25, 4, 9, 19, 903, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42e7367d-21da-40cc-94a0-6d50671c338f"), "Non vitae quo tempora ipsum praesentium.", "e888f1e5-2cf7-4646-a5aa-3cc461c33fbe", new DateTime(2021, 1, 9, 23, 27, 29, 815, DateTimeKind.Local).AddTicks(4918), "Product type: ipsum", new DateTime(2022, 6, 8, 16, 29, 47, 679, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("444a4264-d27f-46ff-b806-e59260b1d936"), "Repudiandae impedit et ea dolores alias sunt repellat alias totam.", "f276b779-201d-4260-928c-c82c983a3429", new DateTime(2018, 10, 29, 17, 1, 20, 326, DateTimeKind.Local).AddTicks(750), "Product type: ab", new DateTime(2019, 9, 24, 23, 39, 3, 789, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("44af0c22-3136-4376-b79a-671404a20b73"), "Consectetur fugit ex tenetur est consequatur vitae consequatur impedit.", "6763ce65-bfc4-4f97-bf56-49761fd0169f", new DateTime(2018, 10, 7, 7, 1, 49, 392, DateTimeKind.Local).AddTicks(342), "Product type: facere", new DateTime(2019, 7, 23, 6, 53, 19, 756, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("45139692-b1a1-49bb-a074-4895bace6bee"), "Placeat dolore quia illum.", "e3c5999c-b70c-4945-ab21-c099c1135ca9", new DateTime(2018, 5, 28, 15, 21, 29, 65, DateTimeKind.Local).AddTicks(8546), "Product type: esse", new DateTime(2022, 2, 6, 12, 57, 1, 394, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4769e6ae-92c6-4a75-b6cd-c0d4ebcf6c0c"), "Error alias reprehenderit est consequatur architecto facilis autem porro dolorem.", "55aad8e0-ddf2-47c9-88e7-96d4dd5bfaec", new DateTime(2017, 11, 28, 14, 14, 46, 24, DateTimeKind.Local).AddTicks(4285), "Product type: aut", new DateTime(2020, 2, 25, 2, 14, 37, 476, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f2d5904-8402-48b2-a28c-59dd6900f4a8"), "Qui illo accusantium maxime sint unde magnam dolores.", "028ccd2a-ae38-47c6-bd4c-aee0383a5d89", new DateTime(2021, 9, 21, 17, 29, 32, 783, DateTimeKind.Local).AddTicks(5197), "Product type: officia", new DateTime(2021, 10, 13, 10, 53, 1, 377, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("527770b0-5893-4068-be21-93ba4f66f784"), "Omnis non enim dolore quod corrupti in aliquam ut.", "2800fd8c-7ffd-4005-af6d-d0cd6e3016b7", new DateTime(2020, 7, 10, 12, 3, 31, 285, DateTimeKind.Local).AddTicks(7240), "Product type: minima", new DateTime(2022, 4, 2, 19, 5, 45, 875, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5474e2b8-70e6-4d30-8432-d43f61b9b2bb"), "Quos ea magni in distinctio rerum voluptatem officia quas.", "0d3500eb-448c-4845-8a3b-bef066ff7119", new DateTime(2018, 3, 23, 8, 30, 17, 77, DateTimeKind.Local).AddTicks(670), "Product type: laborum", new DateTime(2019, 8, 19, 23, 29, 42, 308, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5479b8e9-21a2-4f62-aba6-c56138a424ab"), "Voluptatibus voluptatem quibusdam voluptatem fugit quisquam non sunt.", "9a94bf0d-eceb-4150-bf4a-ab1a6b9afe1b", new DateTime(2018, 6, 18, 18, 27, 24, 345, DateTimeKind.Local).AddTicks(129), "Product type: qui", new DateTime(2021, 10, 26, 0, 23, 44, 603, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b7ede71-a763-42e6-aa7a-9955bc490971"), "Repellendus consectetur laborum quibusdam deserunt.", "2880abc4-5101-4f1e-a804-b452062d20f5", new DateTime(2021, 12, 19, 0, 13, 54, 359, DateTimeKind.Local).AddTicks(694), "Product type: enim", new DateTime(2022, 4, 26, 15, 26, 17, 834, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c6bc58a-c29d-4c29-a819-48f98b45e3e6"), "Facere molestias quasi ut deserunt doloremque et perspiciatis sed enim.", "5a344d35-e4ba-443b-ba65-c5b2714964b3", new DateTime(2020, 5, 29, 15, 54, 30, 305, DateTimeKind.Local).AddTicks(233), "Product type: repellendus", new DateTime(2020, 10, 9, 19, 23, 42, 499, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65de7260-e4a9-4186-94aa-adb2186987ca"), "Aut sed hic amet provident quia odit autem.", "0709d2e8-a794-4a8a-af99-9c58be231ef7", new DateTime(2017, 10, 22, 17, 9, 56, 786, DateTimeKind.Local).AddTicks(9584), "Product type: aspernatur", new DateTime(2021, 7, 21, 15, 47, 30, 858, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("66262ba9-329a-48ce-89c5-d7c9c39e7952"), "Et minima ea non est.", "532d4388-d2d6-430f-82e7-dd7b8647b1d1", new DateTime(2021, 10, 13, 5, 53, 28, 568, DateTimeKind.Local).AddTicks(1218), "Product type: necessitatibus", new DateTime(2022, 3, 3, 0, 40, 43, 497, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b84fbd1-3fc2-42db-b9a3-1bb74fcdf3c1"), "Maiores dignissimos sed.", "2065ccc0-6e8f-4f75-9de7-ba45c5885399", new DateTime(2018, 5, 24, 13, 36, 57, 89, DateTimeKind.Local).AddTicks(7542), "Product type: vel", new DateTime(2018, 12, 18, 1, 54, 42, 273, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c087df0-cf62-4f12-9b22-aca1f0dab271"), "Et distinctio aperiam sit qui tenetur adipisci doloremque corporis.", "7398d18b-41e0-4954-ab00-27cc0bdd5b84", new DateTime(2021, 1, 4, 5, 46, 51, 879, DateTimeKind.Local).AddTicks(7941), "Product type: rem", new DateTime(2022, 4, 26, 10, 32, 50, 614, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e43afba-07dc-44c2-82b4-f2d4bdee4d04"), "Voluptatem ipsam unde.", "50d71774-3f91-404f-9337-87677e6469fa", new DateTime(2019, 5, 11, 16, 5, 32, 88, DateTimeKind.Local).AddTicks(3854), "Product type: earum", new DateTime(2021, 3, 31, 2, 51, 2, 883, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71b754f9-1cfb-4b28-b755-6e949d60121d"), "Ea quae saepe perspiciatis magnam est odio sit vel dolor.", "cc9898ce-1556-4fb5-8692-fe1d70392332", new DateTime(2019, 7, 4, 15, 20, 49, 194, DateTimeKind.Local).AddTicks(9014), "Product type: soluta", new DateTime(2020, 8, 22, 15, 56, 21, 160, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72caf9e9-283e-439f-91aa-f91eb443912c"), "Error vel incidunt et fugit et quisquam odit optio qui.", "bb06b1f5-5cec-4985-9182-5da655c3e77a", new DateTime(2019, 5, 26, 5, 39, 3, 25, DateTimeKind.Local).AddTicks(7144), "Product type: consequatur", new DateTime(2021, 3, 25, 6, 9, 20, 839, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("754c3cf1-dc5a-4841-bec1-5699f738aae5"), "Odio expedita tenetur ea.", "36726f87-474a-4fbf-ba30-5a6298d86122", new DateTime(2018, 5, 23, 1, 42, 49, 31, DateTimeKind.Local).AddTicks(6517), "Product type: dolorum", new DateTime(2018, 10, 28, 0, 57, 26, 27, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("765e8c2d-e71f-494b-ac46-d87aa87de333"), "Sequi atque quis.", "c7897cf8-89e2-4a5a-8770-9b0cbf561e14", new DateTime(2018, 3, 28, 10, 17, 50, 264, DateTimeKind.Local).AddTicks(7011), "Product type: natus", new DateTime(2018, 4, 3, 4, 35, 9, 987, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7dca0885-9dff-4976-85cc-b618f413d402"), "Distinctio reiciendis et.", "11f2df97-620b-410b-85a8-75d8c5065217", new DateTime(2017, 7, 8, 8, 32, 5, 129, DateTimeKind.Local).AddTicks(2434), "Product type: non", new DateTime(2018, 2, 22, 11, 55, 3, 726, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7fd5ddb7-d75d-4d5d-9558-471fd6b89555"), "Sint sunt explicabo soluta dolor animi reprehenderit autem et.", "6bb73618-8789-469a-ae47-c5abbd248f9f", new DateTime(2020, 7, 11, 19, 57, 51, 230, DateTimeKind.Local).AddTicks(4198), "Product type: ut", new DateTime(2022, 2, 25, 2, 36, 14, 447, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8032ddde-c689-4ecf-9669-d93dc1b1dd6a"), "Ut ab eum sunt debitis aut vero aut delectus quis.", "6ce83915-95e3-4c67-8090-42a8a7d36ba8", new DateTime(2022, 6, 14, 23, 32, 30, 384, DateTimeKind.Local).AddTicks(600), "Product type: rerum", new DateTime(2022, 6, 26, 21, 44, 28, 891, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("833b0f8b-35a8-4c87-afe4-1b56abc16634"), "Et eligendi ut ut ut.", "918185e1-442c-4a05-aee1-b9cdf653d454", new DateTime(2018, 3, 20, 15, 27, 36, 122, DateTimeKind.Local).AddTicks(7494), "Product type: debitis", new DateTime(2021, 11, 17, 1, 11, 11, 980, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("877ded3b-453b-42fc-b53e-91724457ea2a"), "Quia et cupiditate enim.", "7051acbf-e393-40c4-badd-da0576226108", new DateTime(2018, 7, 4, 22, 12, 23, 191, DateTimeKind.Local).AddTicks(6862), "Product type: in", new DateTime(2019, 1, 13, 2, 8, 36, 832, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8b97f03d-55ab-4163-acaf-926c57b62d6a"), "Expedita modi est est.", "74dfb32a-a928-4298-bf38-6238b9560b02", new DateTime(2021, 10, 6, 2, 44, 14, 706, DateTimeKind.Local).AddTicks(5557), "Product type: maxime", new DateTime(2021, 11, 16, 15, 7, 50, 746, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e18e9ed-5a17-4f70-a263-8ee17a53b77f"), "Consequatur harum quia quae perferendis tempore dolorem et aut est.", "23fab24e-fc75-4f23-ad3f-769c95a66136", new DateTime(2018, 4, 11, 8, 23, 10, 482, DateTimeKind.Local).AddTicks(3955), "Product type: ea", new DateTime(2018, 5, 20, 10, 29, 31, 636, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90dd68e3-bda7-48cc-ad7a-c21035246d01"), "Mollitia et autem repudiandae repellat quis vel placeat.", "1242a5d3-010a-4331-a8f2-f4ff640b0f8e", new DateTime(2019, 1, 29, 20, 54, 26, 329, DateTimeKind.Local).AddTicks(6793), "Product type: unde", new DateTime(2022, 2, 15, 19, 0, 3, 502, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("952ad65f-e1e8-4662-8def-023d4f4583e0"), "Saepe perspiciatis dicta magni placeat repellendus.", "1f6a8948-64b7-4eaa-ac51-6b669c38115d", new DateTime(2022, 4, 13, 9, 3, 50, 885, DateTimeKind.Local).AddTicks(6095), "Product type: earum", new DateTime(2022, 6, 17, 0, 33, 33, 624, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97c660ac-d7ea-478b-a6cc-eb31ff929709"), "Temporibus consequuntur id quo.", "037a6116-e288-4b2d-986b-349303178f71", new DateTime(2020, 2, 11, 17, 44, 11, 198, DateTimeKind.Local).AddTicks(9371), "Product type: quisquam", new DateTime(2021, 2, 8, 3, 0, 49, 184, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("98b7cc63-49df-4c9f-a6ec-0fb9b9d99f55"), "Ea nisi nulla ipsum et sit nisi velit illum rerum.", "2360a3e0-3ab5-4268-bfae-cddb48875dbf", new DateTime(2021, 8, 28, 17, 0, 22, 454, DateTimeKind.Local).AddTicks(5551), "Product type: suscipit", new DateTime(2022, 4, 4, 10, 40, 54, 299, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99fb39bc-8079-44dd-81e1-f901f6a17765"), "Explicabo perferendis saepe ut sint.", "351e3762-04f9-4f7b-988e-44e20ca7248e", new DateTime(2022, 1, 16, 12, 43, 15, 815, DateTimeKind.Local).AddTicks(7037), "Product type: et", new DateTime(2022, 2, 3, 3, 17, 15, 927, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9b814153-6257-4a86-83f3-a31a48588036"), "Quis ab quis libero delectus non dolorem illum ratione.", "03953fc9-3bf0-4c0e-9323-d6dbfb8668a8", new DateTime(2018, 2, 6, 21, 43, 25, 41, DateTimeKind.Local).AddTicks(7299), "Product type: qui", new DateTime(2019, 7, 23, 6, 33, 51, 897, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9cbac571-1d2b-4f1e-b52f-a3bb20bca68a"), "Maxime blanditiis aliquid.", "ecdeeec8-fa28-4291-9274-84b4ad973105", new DateTime(2020, 6, 6, 0, 41, 33, 96, DateTimeKind.Local).AddTicks(8158), "Product type: deleniti", new DateTime(2022, 5, 18, 21, 6, 37, 312, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d780757-b320-454a-ae6b-d946507c6eb9"), "Ullam eos deleniti similique aut.", "7184778a-9120-49ca-af71-418d61fa7349", new DateTime(2019, 3, 3, 20, 59, 47, 598, DateTimeKind.Local).AddTicks(3551), "Product type: voluptates", new DateTime(2020, 1, 7, 18, 43, 13, 197, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e38eeac-4b0a-419c-84ed-6a59975a2cd8"), "Veritatis qui ullam ut a.", "0c0ae93c-1e47-4e30-9a99-2e8d6c617688", new DateTime(2019, 6, 5, 10, 16, 43, 453, DateTimeKind.Local).AddTicks(6209), "Product type: non", new DateTime(2019, 8, 11, 6, 37, 57, 48, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f053b73-86fb-4595-8cbc-256c3d05728e"), "Est rerum similique eos aut debitis sit ratione.", "1f059327-d922-4a80-9141-12dc68872918", new DateTime(2018, 7, 11, 6, 3, 57, 822, DateTimeKind.Local).AddTicks(2095), "Product type: repellat", new DateTime(2019, 2, 26, 7, 49, 8, 715, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f86d385-448e-4dd0-8b43-3e66a517955e"), "Est dolore est.", "2a028fe8-9b93-49f3-a390-fa16d1fc6c1f", new DateTime(2021, 12, 16, 18, 37, 16, 845, DateTimeKind.Local).AddTicks(4696), "Product type: aperiam", new DateTime(2022, 6, 1, 19, 49, 52, 588, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9fc18bc5-82b6-4233-bb13-db405f36bd23"), "Voluptatem et ut temporibus illo rerum et.", "9bca44c8-9eb7-4d69-a7a5-ddca8b26c398", new DateTime(2021, 3, 23, 23, 16, 44, 225, DateTimeKind.Local).AddTicks(2144), "Product type: quas", new DateTime(2021, 7, 22, 19, 25, 29, 105, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a034cee4-c95a-4509-a0ab-dd022e4c977c"), "Voluptas doloribus incidunt atque et iure voluptas corporis cupiditate.", "590c8804-6567-4879-abb1-1d693c0d2c87", new DateTime(2019, 4, 20, 14, 16, 51, 549, DateTimeKind.Local).AddTicks(3268), "Product type: corporis", new DateTime(2022, 5, 26, 15, 37, 36, 197, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a326b51c-27e0-475d-b5bc-78ae92d18d97"), "Quis sapiente magnam illum quia dolor placeat non.", "aa6a9e16-b2e5-47d3-8508-a69e8adab764", new DateTime(2017, 10, 16, 3, 46, 12, 829, DateTimeKind.Local).AddTicks(4892), "Product type: eveniet", new DateTime(2019, 10, 31, 13, 28, 0, 884, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5ce6316-b238-4907-8819-5e939ed90c1d"), "Fuga omnis ipsam expedita asperiores possimus minus iure.", "0ac45262-47ab-44b9-8c14-5af1d872a302", new DateTime(2017, 9, 26, 16, 6, 7, 571, DateTimeKind.Local).AddTicks(5552), "Product type: illum", new DateTime(2019, 7, 3, 13, 28, 12, 889, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aafa9760-aa50-43a3-8324-0ec4b7d32e02"), "Dignissimos ut sit earum.", "e01d6adc-cbcc-4f72-8114-08009ab00696", new DateTime(2019, 4, 26, 3, 30, 8, 604, DateTimeKind.Local).AddTicks(2474), "Product type: consequuntur", new DateTime(2020, 2, 26, 19, 55, 32, 774, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("add4a6ab-db9d-4f97-9f99-9dbd6ef5397b"), "Est quo in enim est facilis.", "b8d778ab-82d8-4f30-9b1d-9009e576f8c8", new DateTime(2019, 3, 10, 3, 4, 57, 832, DateTimeKind.Local).AddTicks(6276), "Product type: totam", new DateTime(2022, 4, 19, 15, 59, 5, 194, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae1b2761-59e6-4769-a26a-5a0ed5a7fe1b"), "Velit molestias consequatur impedit.", "3bfec930-341c-466e-ab6a-16df83a84b8b", new DateTime(2019, 1, 20, 1, 4, 6, 799, DateTimeKind.Local).AddTicks(2644), "Product type: illo", new DateTime(2021, 6, 28, 15, 53, 28, 766, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b2890247-eb0b-4a40-b72b-eab82be92761"), "Nam sequi ratione labore pariatur est est dolores ratione excepturi.", "5c0b1c4f-68e7-4fcd-a4d4-efa06beda768", new DateTime(2022, 5, 3, 5, 18, 12, 410, DateTimeKind.Local).AddTicks(6161), "Product type: eum", new DateTime(2022, 5, 12, 20, 29, 14, 974, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8d44abd-aa19-46ae-9c64-5e9ed5d3efd9"), "Provident ab voluptas.", "a90c45d4-990a-4faa-ba6a-1ab09efd6c42", new DateTime(2021, 3, 26, 22, 32, 13, 230, DateTimeKind.Local).AddTicks(8290), "Product type: voluptates", new DateTime(2021, 6, 29, 11, 41, 41, 649, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0e14479-7211-4878-b788-15aaf0b6df23"), "Laboriosam adipisci sit voluptatem sed distinctio tempore vel.", "1499632a-42c9-4785-98fb-8b76da0b5d83", new DateTime(2021, 8, 15, 12, 57, 5, 311, DateTimeKind.Local).AddTicks(1878), "Product type: non", new DateTime(2022, 2, 24, 17, 23, 27, 772, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c3153113-0f85-4f5d-b3eb-c3e3cf878b3f"), "Et deserunt minus qui in corporis beatae voluptas.", "ff7ab2ab-d842-48ea-b453-23ed25f2c549", new DateTime(2019, 12, 8, 16, 6, 48, 652, DateTimeKind.Local).AddTicks(3949), "Product type: quo", new DateTime(2021, 10, 16, 3, 39, 27, 996, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c337303e-5364-4c4b-850c-43fa46a4f1ab"), "Magnam adipisci architecto maxime omnis qui molestiae vel.", "ed349d66-a333-4a44-8563-6c7e8d0cb82f", new DateTime(2017, 10, 3, 16, 58, 11, 595, DateTimeKind.Local).AddTicks(2468), "Product type: et", new DateTime(2018, 6, 7, 9, 36, 59, 25, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c33ea0d4-e83a-431f-984f-a99d786e9102"), "Quisquam consequuntur dicta ducimus.", "64afe30a-77f4-47d1-af76-0e2821e50843", new DateTime(2018, 3, 27, 11, 2, 36, 233, DateTimeKind.Local).AddTicks(3363), "Product type: ut", new DateTime(2020, 5, 12, 17, 21, 58, 286, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8fa99a1-56f8-4535-8cd6-f045151cb7db"), "Accusamus aut ipsum doloribus.", "9a7e2b08-80bd-4d6f-8260-b64f95d8a718", new DateTime(2017, 12, 4, 3, 11, 35, 548, DateTimeKind.Local).AddTicks(9784), "Product type: mollitia", new DateTime(2018, 4, 14, 4, 19, 28, 325, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c9df067a-4c0c-4be3-9ea9-262385c57349"), "Ut repellat aut assumenda pariatur eveniet quam veritatis recusandae.", "b51f982d-e656-4ad2-84c1-9970b958220b", new DateTime(2019, 2, 5, 4, 54, 50, 275, DateTimeKind.Local).AddTicks(3070), "Product type: cupiditate", new DateTime(2020, 9, 5, 4, 52, 29, 736, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cac1dae9-737a-4464-a015-5f524f1aeccb"), "Dolorem molestiae consequatur molestias qui.", "27f9892e-374d-444c-a0df-eda93170c232", new DateTime(2021, 6, 8, 1, 40, 12, 683, DateTimeKind.Local).AddTicks(9829), "Product type: beatae", new DateTime(2022, 1, 7, 20, 25, 43, 478, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d05ceba8-445b-44c9-baeb-71a34d66c01d"), "Aut qui dicta voluptatum molestiae rem quo omnis neque autem.", "db48b0e1-d2fe-4bad-9640-30099d90e943", new DateTime(2020, 11, 8, 15, 17, 35, 678, DateTimeKind.Local).AddTicks(5704), "Product type: veritatis", new DateTime(2021, 7, 29, 4, 58, 5, 128, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d0e90404-a1da-4544-856e-286c14942563"), "Temporibus commodi enim dolor libero eveniet nisi minima.", "4e65f265-f7d9-4160-ad00-63cbd088b70e", new DateTime(2020, 5, 30, 3, 48, 39, 30, DateTimeKind.Local).AddTicks(1314), "Product type: esse", new DateTime(2021, 11, 2, 17, 46, 59, 749, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d23e0aa5-97b5-49a0-8de5-db551758e730"), "Mollitia distinctio dolore dolor aut dolorem quia officia voluptate sapiente.", "5609e8c2-5b58-45e6-a9a2-02af0073e4cb", new DateTime(2017, 12, 17, 12, 30, 13, 984, DateTimeKind.Local).AddTicks(7752), "Product type: velit", new DateTime(2021, 2, 13, 6, 21, 3, 413, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d383934f-e733-4c6d-b530-d1601cfeb9c2"), "Harum quia saepe deleniti dolorem.", "80c0ad34-4918-4b9a-9738-0bc4cd5ab532", new DateTime(2020, 1, 25, 19, 44, 1, 944, DateTimeKind.Local).AddTicks(149), "Product type: voluptate", new DateTime(2020, 12, 12, 17, 59, 41, 641, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da02fe34-a2f3-4b73-84dd-fd662981b098"), "Autem iure vel maxime ipsum enim consequatur perferendis corrupti nihil.", "ee95a708-3bdc-4dd4-abbf-f359fbf034ca", new DateTime(2021, 12, 7, 9, 37, 54, 469, DateTimeKind.Local).AddTicks(715), "Product type: deleniti", new DateTime(2021, 12, 14, 5, 29, 24, 460, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("daed2478-429c-40e2-a714-7abf1da8c1a9"), "Qui vel quo sit sint mollitia voluptas omnis.", "94ba4f1f-91af-409d-8113-89e2550e095a", new DateTime(2021, 7, 13, 20, 1, 25, 832, DateTimeKind.Local).AddTicks(4083), "Product type: velit", new DateTime(2022, 3, 6, 2, 24, 40, 681, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e0d056df-85f8-4548-a086-a48f3683e4b9"), "Tempora deserunt est accusantium repellat amet beatae qui.", "651cf2bc-626f-4d43-8604-e6fd6d8ef0f8", new DateTime(2019, 8, 28, 9, 11, 25, 947, DateTimeKind.Local).AddTicks(6770), "Product type: sint", new DateTime(2021, 6, 20, 10, 33, 26, 452, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1fb6f03-033b-4f03-80af-5aae84d718f4"), "Molestiae voluptatem consequatur.", "992aceb6-2ad9-4a99-a5e4-143b37df941b", new DateTime(2018, 9, 6, 21, 42, 6, 532, DateTimeKind.Local).AddTicks(8128), "Product type: qui", new DateTime(2021, 4, 23, 4, 9, 44, 93, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2e8b11a-6f65-49bf-9321-4fd7b2470bfe"), "Quasi quia et.", "3645e94a-c03d-49e4-8015-018faa3b5585", new DateTime(2018, 12, 22, 19, 50, 34, 728, DateTimeKind.Local).AddTicks(9107), "Product type: et", new DateTime(2019, 5, 22, 5, 16, 26, 447, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e4eb0a55-3bf4-4ebc-9bfe-b1f369e6b597"), "Ducimus est autem et sed cupiditate magni.", "9f7dc4c6-5599-4371-980a-3492e56ad996", new DateTime(2018, 1, 22, 10, 40, 25, 184, DateTimeKind.Local).AddTicks(7212), "Product type: eum", new DateTime(2020, 6, 10, 18, 35, 29, 255, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e68d0584-9cc2-46b5-bd6e-1c5cb0057738"), "Repudiandae consequatur delectus velit omnis earum dolores similique.", "ef7cb550-7487-44b1-a478-c97019964fdc", new DateTime(2021, 8, 27, 11, 48, 41, 730, DateTimeKind.Local).AddTicks(844), "Product type: eveniet", new DateTime(2021, 11, 10, 16, 58, 1, 70, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee2be358-0421-4a77-bd71-0a75b4f70cc9"), "Quia et sit.", "a4ae8c6b-c979-43ea-9f60-1b51f6dbc91a", new DateTime(2020, 3, 21, 0, 6, 10, 332, DateTimeKind.Local).AddTicks(7071), "Product type: fuga", new DateTime(2021, 3, 12, 23, 28, 48, 228, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("efd286a7-aa8f-42ed-bbf7-c9e958edbd0e"), "Hic sapiente quos dolores voluptatem suscipit nisi et facilis.", "3ed194af-ca71-4b49-a3cd-2de57c28cba8", new DateTime(2020, 7, 5, 4, 53, 13, 607, DateTimeKind.Local).AddTicks(5146), "Product type: ratione", new DateTime(2022, 1, 31, 19, 0, 21, 349, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f2ed7e34-605d-4775-9af2-bef52a7c1fed"), "Laboriosam et modi optio sint earum consequatur vel.", "a1452055-c0c6-40ad-bd84-a0457b74cb99", new DateTime(2017, 11, 20, 11, 54, 36, 322, DateTimeKind.Local).AddTicks(2146), "Product type: culpa", new DateTime(2021, 8, 17, 19, 27, 2, 367, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f329ca62-e4fd-496f-99bd-01a655d669bd"), "Debitis qui et libero commodi maxime.", "dfb55bcf-0f98-4b27-9eac-b95781fdb98c", new DateTime(2020, 12, 23, 2, 4, 57, 655, DateTimeKind.Local).AddTicks(4100), "Product type: explicabo", new DateTime(2022, 6, 11, 12, 39, 19, 163, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f994861f-c243-4127-9a26-8ddfb6475236"), "Saepe provident nisi et porro.", "b3e17a54-4b9b-46fe-a1da-dd373907b041", new DateTime(2020, 4, 3, 14, 17, 27, 374, DateTimeKind.Local).AddTicks(34), "Product type: ut", new DateTime(2021, 3, 31, 0, 50, 31, 489, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f9cb6561-7ca4-47b6-a05d-b0d9140ae7ae"), "Voluptatum et natus iste ullam doloribus quibusdam nobis aut.", "0612e309-7d14-4d5d-8011-7d6cc35c5b95", new DateTime(2017, 10, 8, 10, 30, 16, 469, DateTimeKind.Local).AddTicks(1136), "Product type: voluptatem", new DateTime(2018, 5, 20, 23, 13, 22, 861, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb530b79-3320-4b51-b527-e8cca8564908"), "Illum debitis vero aut eos rerum.", "984e5fd4-99f8-4f92-a8c2-a5e1db4e82cb", new DateTime(2019, 3, 28, 12, 16, 54, 482, DateTimeKind.Local).AddTicks(1291), "Product type: aspernatur", new DateTime(2019, 11, 25, 2, 8, 5, 564, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fbbf9aa2-cc47-46bb-ba50-19a553da7fc3"), "Qui facere praesentium velit est.", "1c54a16e-30c4-4263-97d9-89fc2b9ace75", new DateTime(2019, 6, 21, 10, 43, 35, 936, DateTimeKind.Local).AddTicks(3210), "Product type: dolorum", new DateTime(2022, 5, 29, 18, 18, 50, 476, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fbfde07f-1f48-473c-bb5f-a9ae57f0fc8e"), "Tempore eum accusantium nesciunt corporis dolores deserunt et quae dicta.", "45715d9e-6dc2-4f3a-a49c-d2012907ae6b", new DateTime(2018, 2, 11, 4, 53, 59, 16, DateTimeKind.Local).AddTicks(1022), "Product type: culpa", new DateTime(2020, 5, 17, 16, 37, 21, 871, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("057012e2-9467-4565-8c04-49916ef92290"), "Quae eum dignissimos nam.", "85ddeec1-568e-4331-b03e-d0d677d93d3a", new DateTime(2018, 11, 18, 13, 25, 39, 628, DateTimeKind.Local).AddTicks(8115), "Product unit classifier: voluptatem", new DateTime(2019, 11, 28, 2, 9, 26, 491, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08e5fd0c-2443-4f04-80a8-c06db85efe38"), "Ipsam dolorem sed assumenda delectus et et et nemo libero.", "8afbaa3e-b960-4abe-877e-4f6b13608298", new DateTime(2021, 8, 29, 19, 9, 16, 110, DateTimeKind.Local).AddTicks(6040), "Product unit classifier: sed", new DateTime(2021, 10, 29, 0, 45, 23, 386, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0d432dd0-fc0e-4173-a5dc-f854df240be8"), "Delectus nihil et culpa in dolores et blanditiis sint error.", "eff90864-e948-44d4-9e49-5a484e0fdb86", new DateTime(2020, 3, 5, 21, 48, 27, 951, DateTimeKind.Local).AddTicks(5489), "Product unit classifier: ut", new DateTime(2021, 2, 25, 5, 56, 37, 324, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("14a5c1f3-9580-426f-947e-b9b5e2d84607"), "Mollitia ipsam maiores et ut fugit dolorem error laboriosam est.", "622fb353-d3e2-4dfd-b609-838c205eed43", new DateTime(2019, 2, 19, 7, 32, 37, 661, DateTimeKind.Local).AddTicks(3403), "Product unit classifier: doloribus", new DateTime(2022, 5, 19, 2, 25, 10, 201, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("175734e2-808c-4508-b55f-f539b8948f06"), "Tenetur qui consequatur.", "990b1d46-e5f2-431d-9af3-801bb9c59032", new DateTime(2021, 7, 26, 19, 6, 46, 251, DateTimeKind.Local).AddTicks(8750), "Product unit classifier: sunt", new DateTime(2022, 2, 18, 22, 45, 52, 508, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1f4650fb-5955-44d7-a106-6935397cbb96"), "Veritatis eos numquam optio optio nisi quam.", "7a3b74eb-743a-4abc-b2e0-b166935ac175", new DateTime(2021, 7, 20, 20, 42, 37, 422, DateTimeKind.Local).AddTicks(3418), "Product unit classifier: at", new DateTime(2022, 4, 8, 8, 41, 16, 7, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("207620a4-e862-4e3d-b36a-df8dfccf690f"), "Quibusdam deserunt quaerat eum a facilis et beatae sint.", "27d4811b-5923-4f02-ac62-e1c37163748c", new DateTime(2018, 1, 23, 12, 7, 23, 617, DateTimeKind.Local).AddTicks(2342), "Product unit classifier: fuga", new DateTime(2019, 12, 21, 19, 26, 12, 141, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("219583e0-8585-46c8-89ae-15b3c192ce18"), "Impedit quas ratione similique nihil qui quasi.", "f0b0cfee-8aa3-494a-aacf-b0f10a3d1438", new DateTime(2019, 5, 17, 15, 25, 12, 357, DateTimeKind.Local).AddTicks(2303), "Product unit classifier: alias", new DateTime(2020, 9, 3, 10, 50, 44, 248, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2488544a-04ac-4aaf-8544-295ebce83564"), "A voluptatem consequatur voluptatum.", "be0610d9-b7b5-4a9d-bff4-9ba4bdf2f94e", new DateTime(2022, 6, 9, 4, 1, 59, 611, DateTimeKind.Local).AddTicks(5547), "Product unit classifier: autem", new DateTime(2022, 6, 19, 14, 53, 22, 283, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2601324f-a381-46be-8575-f8357260c3fb"), "Possimus provident dolorem odit consequatur amet amet.", "1d06142c-b877-4302-95ee-1486d8a55b00", new DateTime(2019, 10, 2, 14, 19, 50, 948, DateTimeKind.Local).AddTicks(9985), "Product unit classifier: illo", new DateTime(2022, 5, 3, 4, 38, 54, 866, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26039a2e-adac-4346-bdc4-7fbc3961fbab"), "Rerum dolores dolores non consequatur provident.", "27d7b0f7-5955-4a02-9764-bea092accb72", new DateTime(2018, 8, 2, 13, 41, 42, 558, DateTimeKind.Local).AddTicks(9225), "Product unit classifier: rerum", new DateTime(2022, 5, 10, 11, 4, 9, 891, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("282ac125-106d-4782-8c0b-2c7c5cd91143"), "Sit sunt repudiandae eius a et est suscipit et.", "bd1b3f50-73e4-4230-add2-7ef5ac6f7857", new DateTime(2019, 2, 6, 22, 40, 14, 808, DateTimeKind.Local).AddTicks(1872), "Product unit classifier: officiis", new DateTime(2021, 7, 20, 23, 10, 21, 739, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2ba0a7ea-881e-430d-b184-8862a54db4f4"), "At quibusdam tempora.", "9b47c744-5c1a-4abf-8e04-f1606374cc1f", new DateTime(2021, 12, 30, 4, 22, 21, 702, DateTimeKind.Local).AddTicks(3109), "Product unit classifier: perspiciatis", new DateTime(2022, 5, 11, 18, 21, 38, 542, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32325dcb-35c2-4fda-8f28-1cd4e0fdfe12"), "Maiores officia et amet iure fuga corporis.", "dcb31557-2975-4c30-aa7d-cdd514315852", new DateTime(2019, 4, 30, 11, 25, 45, 812, DateTimeKind.Local).AddTicks(2015), "Product unit classifier: aut", new DateTime(2020, 8, 23, 2, 41, 59, 680, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("327f0ad9-823f-437a-8a16-bd3bd005b3db"), "Occaecati est recusandae quae odio id et iusto est.", "f317d8da-71b8-42f1-a7ec-cbccd5b00391", new DateTime(2018, 3, 6, 15, 32, 40, 243, DateTimeKind.Local).AddTicks(8808), "Product unit classifier: pariatur", new DateTime(2020, 5, 23, 5, 25, 42, 155, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32e1ad77-ea3a-4885-8ce2-7d3a29c0cac6"), "Cum magni consequatur est mollitia est quod consequuntur.", "f95ff22a-28d1-4673-9e34-4e970544f000", new DateTime(2020, 7, 26, 1, 59, 57, 127, DateTimeKind.Local).AddTicks(320), "Product unit classifier: sed", new DateTime(2022, 6, 26, 0, 48, 12, 728, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("37959ee7-7c06-4547-907a-50ba9901add4"), "Occaecati est sit velit quo dolorum velit ut.", "5c895008-5d84-4383-91dd-519f366fcc5a", new DateTime(2022, 6, 10, 18, 5, 39, 275, DateTimeKind.Local).AddTicks(7661), "Product unit classifier: enim", new DateTime(2022, 6, 28, 2, 28, 20, 559, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38a335a1-ff06-4143-aade-5dd2673ce4ba"), "Soluta fuga dolorem quaerat corporis tempora quam dolorum dolorem.", "ecdbe1ee-7e29-4c0c-8c7b-a04f7875a9d1", new DateTime(2020, 1, 14, 8, 4, 41, 58, DateTimeKind.Local).AddTicks(4741), "Product unit classifier: quasi", new DateTime(2022, 1, 2, 13, 24, 30, 161, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("394069e4-26a0-4b4d-b99f-f88d5e2b00be"), "Itaque cumque minima.", "d931987b-a161-4ab9-a4ce-4fa053e5c65e", new DateTime(2019, 2, 19, 21, 34, 44, 888, DateTimeKind.Local).AddTicks(194), "Product unit classifier: et", new DateTime(2021, 9, 6, 17, 20, 39, 519, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3df697a9-0c37-4b77-aec4-8c03d88c6518"), "Cumque aspernatur quibusdam voluptatem quos adipisci voluptas voluptatum omnis.", "05d01d1e-cc20-4031-a9c3-8b8592f0bdb2", new DateTime(2021, 1, 19, 17, 35, 57, 16, DateTimeKind.Local).AddTicks(4376), "Product unit classifier: dolore", new DateTime(2021, 4, 2, 10, 15, 11, 547, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f262cc1-d349-4fb4-b312-188f40472e89"), "Minus earum cum in molestiae veniam aliquam quia optio.", "6c52d5ea-9045-4e4c-873f-7c7c1228d005", new DateTime(2020, 9, 2, 0, 0, 56, 415, DateTimeKind.Local).AddTicks(6205), "Product unit classifier: dolore", new DateTime(2021, 12, 13, 23, 45, 38, 603, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("424f2424-55de-4a82-bdf9-90abd27b7092"), "Cumque eius sed dicta.", "d8646b67-fef0-4140-98f6-3214bd8f5f67", new DateTime(2017, 9, 30, 23, 4, 33, 208, DateTimeKind.Local).AddTicks(9320), "Product unit classifier: voluptate", new DateTime(2020, 11, 3, 11, 50, 58, 63, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("43ef2ed3-99f9-4fe4-8e97-dd032f4ff029"), "Delectus eaque et.", "42f26dda-368b-4615-bcff-686ef059dd7f", new DateTime(2018, 4, 10, 23, 24, 2, 852, DateTimeKind.Local).AddTicks(1908), "Product unit classifier: aut", new DateTime(2019, 8, 25, 14, 13, 36, 71, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("44476771-5415-48b8-b2cd-8ec6611252ff"), "Sunt et dolorem veniam.", "c769ef43-bd21-4d47-97f1-5ed6b277abd1", new DateTime(2021, 8, 21, 7, 53, 35, 583, DateTimeKind.Local).AddTicks(9979), "Product unit classifier: velit", new DateTime(2021, 10, 12, 10, 24, 24, 707, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4fffd149-5190-4e85-b057-7df761532027"), "Fugit culpa tempora ratione.", "db55d289-b667-488f-8b9c-9a1574a2fdd0", new DateTime(2019, 2, 20, 4, 27, 42, 738, DateTimeKind.Local).AddTicks(7793), "Product unit classifier: reiciendis", new DateTime(2019, 8, 25, 1, 50, 59, 350, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("500af191-7fc8-461b-880f-9628e9819bc9"), "Suscipit non ipsam facere.", "2618511c-934e-4675-9814-2f8abb24c667", new DateTime(2021, 10, 17, 0, 36, 16, 685, DateTimeKind.Local).AddTicks(7168), "Product unit classifier: accusamus", new DateTime(2022, 5, 18, 10, 0, 21, 57, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("525e9252-5190-4ea4-ade6-1a84d7e3b3dd"), "Repudiandae veritatis laudantium quo rem fugit.", "d2dbdbb3-98da-42b9-a3c9-ec16cc49a1e5", new DateTime(2017, 9, 19, 9, 15, 26, 939, DateTimeKind.Local).AddTicks(6809), "Product unit classifier: praesentium", new DateTime(2019, 9, 16, 10, 57, 9, 822, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54dfe0a8-3fa0-40fa-99d8-0f662e379642"), "Vel molestiae ducimus.", "b0fd7aba-8652-45c6-bab4-5d1d70a2efea", new DateTime(2019, 11, 13, 10, 13, 39, 306, DateTimeKind.Local).AddTicks(2124), "Product unit classifier: reprehenderit", new DateTime(2020, 2, 20, 16, 34, 7, 737, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55c6698c-3bb6-4e71-b523-22d703f9e54f"), "Et cumque quae rerum repellat.", "73e51458-62b7-4b7d-bb15-99e93bae2ae6", new DateTime(2020, 2, 21, 10, 51, 48, 669, DateTimeKind.Local).AddTicks(43), "Product unit classifier: quas", new DateTime(2022, 5, 4, 4, 55, 56, 189, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5861aefa-6e22-442a-8610-b44dc0c6f4f3"), "Omnis aperiam ea assumenda corrupti laborum dicta.", "71465b87-af98-4307-a7be-57769c7796d4", new DateTime(2019, 7, 15, 9, 24, 20, 895, DateTimeKind.Local).AddTicks(7430), "Product unit classifier: asperiores", new DateTime(2019, 9, 25, 3, 13, 5, 720, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b7675ef-f9e0-4bf8-8909-8501a3536a0c"), "Iure qui sed magni quos similique fugit et est quia.", "775a9b38-deed-4f9a-afad-b1f02870e9a6", new DateTime(2021, 5, 17, 5, 45, 30, 295, DateTimeKind.Local).AddTicks(7328), "Product unit classifier: id", new DateTime(2022, 5, 11, 18, 57, 22, 709, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5bbdf43b-3ca7-46e4-94f0-7f5d1b961abf"), "Sit dignissimos quasi amet dolorum quia.", "f589359e-bb49-4c65-8991-5db41542de52", new DateTime(2018, 8, 15, 18, 59, 52, 867, DateTimeKind.Local).AddTicks(3975), "Product unit classifier: laborum", new DateTime(2021, 1, 25, 14, 53, 14, 261, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5bd6db7b-077a-401c-81cd-91e22131e25a"), "Voluptas autem sed modi deleniti maxime saepe qui.", "5a6b3e53-da34-4868-bc9a-cd97c53806b1", new DateTime(2019, 8, 5, 20, 24, 32, 590, DateTimeKind.Local).AddTicks(6024), "Product unit classifier: sunt", new DateTime(2019, 9, 1, 0, 31, 26, 57, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e81de8d-83b9-4a8d-9305-61a2d15dba24"), "Neque doloremque aliquid quidem sit est est sed neque.", "95136389-5412-4b18-8e89-c70b9340375c", new DateTime(2020, 1, 4, 21, 41, 38, 443, DateTimeKind.Local).AddTicks(8780), "Product unit classifier: dolore", new DateTime(2021, 9, 21, 11, 7, 12, 978, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("60752a32-8209-4eef-9287-39634ea99b66"), "Beatae ea quam qui ut earum quam est.", "ac151f48-8e50-4e57-890f-a302e8524a91", new DateTime(2019, 3, 6, 9, 36, 41, 4, DateTimeKind.Local).AddTicks(3290), "Product unit classifier: et", new DateTime(2020, 12, 10, 16, 43, 41, 46, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("635232c7-f5d2-4935-8531-ee82ed99ca93"), "Aliquid et aut magnam a placeat incidunt omnis neque aut.", "2d6759ad-fa60-410a-93ca-b287a4030c6d", new DateTime(2021, 7, 19, 3, 17, 15, 392, DateTimeKind.Local).AddTicks(6442), "Product unit classifier: iusto", new DateTime(2021, 8, 1, 1, 31, 32, 558, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65a1b57b-8827-49a7-a2c9-cbb749fe51f6"), "Voluptas nostrum aliquam vel sed nisi facere eveniet magni.", "69390bc1-4717-4f6f-a188-9464d5f2fdef", new DateTime(2020, 4, 12, 7, 14, 46, 984, DateTimeKind.Local).AddTicks(8442), "Product unit classifier: atque", new DateTime(2022, 1, 14, 18, 50, 30, 436, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("66719c99-732a-49c0-8319-db331a9c17bc"), "Veniam esse ipsa temporibus consequatur.", "1d0fc3b5-c5c5-4226-b21a-e4b459bae3cd", new DateTime(2020, 10, 22, 13, 26, 49, 120, DateTimeKind.Local).AddTicks(6579), "Product unit classifier: vel", new DateTime(2021, 5, 2, 16, 15, 23, 525, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("67016062-be37-428e-8f40-ae877b86e01f"), "Eius eveniet et.", "0d02a2a0-ff1c-4d5c-8e65-67e626c3dab7", new DateTime(2020, 12, 18, 13, 50, 56, 227, DateTimeKind.Local).AddTicks(5302), "Product unit classifier: repellendus", new DateTime(2021, 9, 10, 5, 18, 15, 295, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69a9e6e3-d2d0-4c04-ac98-3d9e236d7a10"), "Molestias ipsam id et ratione ipsam soluta autem voluptatem quis.", "937291ca-8f6d-47d7-a171-5732c5c22185", new DateTime(2021, 4, 4, 17, 24, 45, 195, DateTimeKind.Local).AddTicks(7065), "Product unit classifier: eius", new DateTime(2021, 7, 21, 8, 45, 54, 554, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69e88ba5-04d4-4c99-912b-84220fc53270"), "At distinctio ut et dicta dolore assumenda nobis est soluta.", "4e5038d4-5d51-47d2-ba3a-95e4fde726d0", new DateTime(2018, 3, 4, 5, 49, 11, 311, DateTimeKind.Local).AddTicks(6408), "Product unit classifier: nemo", new DateTime(2018, 6, 27, 13, 29, 45, 104, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b85aad6-ad9a-488b-a5d8-76bfb86e0215"), "Iusto et nisi.", "49bdbb8b-55f7-41d1-be5b-65603a1a1ed5", new DateTime(2020, 1, 29, 20, 8, 49, 886, DateTimeKind.Local).AddTicks(428), "Product unit classifier: animi", new DateTime(2021, 3, 5, 16, 8, 20, 55, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6bcfb4cc-fdc4-4578-951b-a0d47c296313"), "Ut et temporibus sit adipisci voluptatem sit consequuntur velit.", "ec520dc2-318b-48ca-adde-4bc67fa7c216", new DateTime(2018, 5, 13, 11, 6, 27, 756, DateTimeKind.Local).AddTicks(2332), "Product unit classifier: impedit", new DateTime(2019, 10, 12, 9, 2, 58, 256, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c0be97b-9162-463c-8a07-9de8d09b8cb6"), "Perspiciatis tenetur numquam qui eius natus ea.", "9750fb8a-c477-44e3-8dc4-2086291c0644", new DateTime(2021, 1, 9, 18, 2, 32, 570, DateTimeKind.Local).AddTicks(7802), "Product unit classifier: eveniet", new DateTime(2022, 2, 23, 22, 11, 7, 373, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6d91cf60-ba1b-4a96-9640-70ead698da06"), "Nemo itaque quis sit qui distinctio eaque laborum.", "801c841c-ffb6-4059-9429-4c6789c7158e", new DateTime(2017, 11, 17, 4, 53, 41, 971, DateTimeKind.Local).AddTicks(2051), "Product unit classifier: aut", new DateTime(2018, 5, 25, 6, 21, 27, 656, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7138f7db-6528-4612-a224-e884e1466487"), "Aut voluptatibus soluta.", "c04cdf65-ffb3-4f0a-8fef-94cf6397676a", new DateTime(2021, 1, 20, 23, 4, 3, 284, DateTimeKind.Local).AddTicks(6976), "Product unit classifier: culpa", new DateTime(2021, 3, 27, 16, 49, 31, 964, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7caa9777-7b28-45c2-bb5f-fca583b3af51"), "Corporis sed molestias omnis quia aspernatur incidunt fugit ipsa.", "f344e8ad-b265-46d1-b823-0c49a9b84f12", new DateTime(2021, 1, 7, 14, 40, 39, 598, DateTimeKind.Local).AddTicks(3834), "Product unit classifier: aliquam", new DateTime(2021, 8, 19, 21, 22, 35, 486, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7d3e136d-0960-48c6-8be8-2440a05034be"), "Exercitationem ad cum.", "0fb4f15c-a6ac-449a-a84a-f6d7cb92361a", new DateTime(2019, 6, 12, 13, 53, 50, 960, DateTimeKind.Local).AddTicks(4783), "Product unit classifier: et", new DateTime(2021, 3, 25, 3, 43, 5, 219, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7eae4e27-424c-4c45-9ecd-02d863026a52"), "Mollitia placeat nihil qui architecto voluptatem atque voluptatem.", "84aee31e-c33c-45d6-8e1d-130bb09a0f4a", new DateTime(2017, 11, 21, 10, 55, 1, 319, DateTimeKind.Local).AddTicks(6646), "Product unit classifier: unde", new DateTime(2019, 3, 30, 1, 43, 7, 376, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8473b5ff-ff13-4ddb-9e38-764d1e8f2f5c"), "Eum est inventore voluptates nemo illum enim quisquam.", "a2160165-bb75-4d02-ba32-514c9d0e3e93", new DateTime(2017, 9, 1, 20, 49, 20, 40, DateTimeKind.Local).AddTicks(7723), "Product unit classifier: libero", new DateTime(2017, 10, 13, 11, 57, 54, 76, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86f4d37b-0752-4bcd-8d02-9628b1488572"), "Accusantium quos explicabo odit a.", "edf1a997-373a-4d47-a377-75b2c27947b8", new DateTime(2017, 11, 17, 18, 12, 33, 357, DateTimeKind.Local).AddTicks(8076), "Product unit classifier: vel", new DateTime(2019, 9, 30, 11, 47, 22, 486, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a11e964-ca5e-4929-a9ff-d26c9c95f757"), "Quia possimus ratione ut dignissimos quod nesciunt.", "5c9cb3ab-49d7-4125-b7e0-a88947d19e3a", new DateTime(2020, 3, 31, 23, 42, 49, 952, DateTimeKind.Local).AddTicks(4552), "Product unit classifier: animi", new DateTime(2021, 5, 23, 4, 12, 15, 970, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e78f746-2f73-4dcb-bc15-8dafd1e67344"), "Illum similique eos vitae.", "ebb1e7ae-48e4-46ed-8277-478163ac9649", new DateTime(2019, 6, 12, 9, 51, 21, 987, DateTimeKind.Local).AddTicks(7671), "Product unit classifier: debitis", new DateTime(2022, 3, 11, 8, 18, 36, 717, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f0b9225-0c80-4f7b-bc01-a72b59398b50"), "Libero fugiat fugiat quasi voluptatem nobis.", "fb6082a2-4af8-4f75-90f6-49c544894c88", new DateTime(2022, 1, 23, 5, 4, 15, 800, DateTimeKind.Local).AddTicks(6266), "Product unit classifier: praesentium", new DateTime(2022, 5, 3, 1, 26, 18, 470, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90368959-393d-4c90-b17c-ffa48fde843e"), "Quia ut quibusdam ut veritatis beatae.", "720e5bfd-8e43-4970-aed3-bf6b7a5b51d6", new DateTime(2018, 7, 22, 9, 34, 59, 351, DateTimeKind.Local).AddTicks(8644), "Product unit classifier: rem", new DateTime(2022, 4, 12, 2, 52, 37, 86, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92109dfc-4337-499e-88f6-211da511b279"), "Sed fugiat quos quos voluptate consequuntur rerum et molestiae qui.", "4a8f732e-4d59-4e2a-b510-c68eb1d02264", new DateTime(2021, 7, 13, 6, 37, 5, 743, DateTimeKind.Local).AddTicks(6732), "Product unit classifier: veniam", new DateTime(2021, 9, 10, 12, 42, 57, 735, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92ba4815-9da0-415d-85e8-5ae5f6e27889"), "Perspiciatis voluptatem velit pariatur eligendi nesciunt enim consequatur aut.", "3d6cef0f-de2e-4f84-9b34-6f9ee141e594", new DateTime(2022, 1, 1, 18, 51, 2, 2, DateTimeKind.Local).AddTicks(1829), "Product unit classifier: quo", new DateTime(2022, 3, 23, 23, 33, 17, 654, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9ce5bc87-abb3-4c1d-a102-f777f4748001"), "Minus minus aliquam culpa blanditiis non quaerat architecto.", "0b6bab56-ef2f-49d2-ad08-0d8c5721e94e", new DateTime(2022, 2, 24, 23, 21, 14, 395, DateTimeKind.Local).AddTicks(7801), "Product unit classifier: dolor", new DateTime(2022, 6, 30, 21, 49, 5, 521, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e409024-3b7d-42c6-8fd9-e206397c9b47"), "Neque est perferendis sed eligendi ipsa nemo eaque.", "72e65b85-d4df-48bb-a82e-7c01790195fd", new DateTime(2019, 4, 13, 11, 3, 20, 770, DateTimeKind.Local).AddTicks(877), "Product unit classifier: quis", new DateTime(2020, 9, 3, 15, 1, 17, 206, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a0cf4adf-0e9b-4b90-b29b-57245008321a"), "Qui quasi vel tenetur repellat non architecto.", "ce2c5063-d31b-45da-b2dc-fb4a15984f7a", new DateTime(2018, 3, 31, 6, 37, 56, 187, DateTimeKind.Local).AddTicks(1604), "Product unit classifier: eius", new DateTime(2022, 4, 5, 12, 1, 5, 710, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2f14494-9997-4322-b1d6-bf07fb32c853"), "Quia ea voluptatum omnis porro quae dolorum.", "7c8689a5-fd9e-407a-b91a-ce4efc534d73", new DateTime(2019, 10, 10, 23, 38, 49, 78, DateTimeKind.Local).AddTicks(2361), "Product unit classifier: eaque", new DateTime(2020, 12, 14, 21, 21, 24, 207, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a476bbad-83ae-4613-97d4-8cec02d68108"), "Et facere quam aspernatur asperiores et aut facilis ut.", "3a1024a2-8dfc-4311-b4ec-dc82c98c1793", new DateTime(2017, 11, 25, 14, 52, 36, 938, DateTimeKind.Local).AddTicks(2053), "Product unit classifier: accusamus", new DateTime(2020, 2, 6, 19, 25, 36, 152, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a63c1f03-2407-4dd7-b984-1b5926a61012"), "In cupiditate laborum aut assumenda est.", "166cdbb6-b726-43ac-b93e-bd7db8a3f91d", new DateTime(2019, 9, 5, 22, 17, 12, 874, DateTimeKind.Local).AddTicks(6737), "Product unit classifier: facere", new DateTime(2019, 12, 13, 19, 40, 7, 616, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad7b1dec-8cb4-4214-a1b1-502bec0b110a"), "Architecto consectetur velit adipisci sed illo labore.", "d2e0b6dd-1b21-4583-bf62-a08600a508fb", new DateTime(2018, 6, 27, 22, 6, 36, 782, DateTimeKind.Local).AddTicks(2051), "Product unit classifier: qui", new DateTime(2021, 11, 5, 12, 50, 14, 143, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("afe1915e-5bd9-4a92-94d2-18a93df6f5ba"), "Soluta et maxime minus.", "4150e84b-7705-4b45-8c71-eaccc9636a88", new DateTime(2020, 7, 8, 10, 50, 8, 553, DateTimeKind.Local).AddTicks(9076), "Product unit classifier: excepturi", new DateTime(2021, 9, 7, 18, 15, 49, 812, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1877c74-cba2-4543-bdf9-7a9454125d95"), "Quae officia iusto vel nisi quibusdam.", "1ecec1cf-ca30-4c4b-b9cf-1068cb1be9f6", new DateTime(2020, 3, 9, 16, 5, 8, 777, DateTimeKind.Local).AddTicks(5244), "Product unit classifier: unde", new DateTime(2020, 6, 22, 11, 6, 46, 638, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1d41b3a-60a2-4a69-859b-dbb0beb581b8"), "Consequatur eius dolores vel nihil.", "4540e2f0-509d-48a8-9b17-bd8e5e94685f", new DateTime(2019, 6, 19, 6, 7, 46, 227, DateTimeKind.Local).AddTicks(372), "Product unit classifier: est", new DateTime(2019, 11, 11, 6, 19, 58, 908, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b22f1d78-3b13-4002-a405-5671ac25a22b"), "Ab et aut voluptatem reiciendis rem.", "c3f70e47-9498-4df3-8d95-70c1109ba217", new DateTime(2021, 6, 1, 9, 47, 3, 554, DateTimeKind.Local).AddTicks(3474), "Product unit classifier: sint", new DateTime(2022, 5, 1, 8, 18, 23, 32, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3dda430-c980-408f-a198-9c680083bfc7"), "Aut velit qui.", "50d7d55a-47a8-4c7d-b15f-0939327123df", new DateTime(2019, 8, 12, 15, 5, 43, 384, DateTimeKind.Local).AddTicks(1455), "Product unit classifier: culpa", new DateTime(2021, 8, 14, 9, 38, 58, 428, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b5f1da3d-3e37-4c2a-939a-11c2c5c91f38"), "Ut omnis sunt.", "64b52b98-9c90-42f1-acd4-e447ecafbedd", new DateTime(2021, 11, 17, 7, 31, 5, 604, DateTimeKind.Local).AddTicks(3817), "Product unit classifier: tenetur", new DateTime(2022, 6, 15, 20, 44, 22, 552, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6ba30a0-8f3e-47ac-a5e5-6b9ef3580dc8"), "Alias numquam quis quaerat inventore sequi porro qui non molestiae.", "f44bc08a-4aeb-4752-b7be-be7700c5cf1d", new DateTime(2022, 1, 18, 4, 44, 0, 527, DateTimeKind.Local).AddTicks(7976), "Product unit classifier: eaque", new DateTime(2022, 2, 25, 6, 49, 19, 780, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8dc3317-b4b7-4d16-b173-aaa4fb03466a"), "Quis voluptas suscipit voluptatem.", "08b65740-9f10-4e94-8c1d-b33b72e3bc4f", new DateTime(2018, 9, 30, 17, 18, 37, 508, DateTimeKind.Local).AddTicks(9080), "Product unit classifier: sit", new DateTime(2019, 6, 14, 9, 43, 59, 851, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba931c0e-8c74-420b-b868-5028f1d4c7c8"), "Cum aut reiciendis.", "20b9eb6a-c46b-4960-995e-a1e0b5e9a867", new DateTime(2020, 4, 9, 10, 11, 15, 140, DateTimeKind.Local).AddTicks(3398), "Product unit classifier: accusamus", new DateTime(2022, 5, 1, 20, 11, 3, 450, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd0eeb82-42bd-48d5-838c-df2615c866cb"), "Assumenda iste vitae dolorem enim.", "37c6669e-5570-4ad3-98da-85b1ed4c8396", new DateTime(2019, 6, 20, 12, 48, 23, 5, DateTimeKind.Local).AddTicks(8083), "Product unit classifier: iure", new DateTime(2021, 6, 4, 12, 50, 2, 88, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdf33229-1a4b-4bde-956c-20959ffe186c"), "Earum ut enim minus.", "6733218b-f8b7-42ca-9803-0c6b7a640e1e", new DateTime(2020, 9, 25, 16, 56, 28, 110, DateTimeKind.Local).AddTicks(8772), "Product unit classifier: id", new DateTime(2021, 7, 25, 2, 20, 1, 341, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2a6525c-be39-4805-a940-e44469ef5cfb"), "Possimus tempora et natus minima consequatur quo.", "9c820925-121e-42b4-ab08-1e4b9e59fbe3", new DateTime(2020, 11, 19, 1, 48, 53, 429, DateTimeKind.Local).AddTicks(120), "Product unit classifier: quis", new DateTime(2022, 5, 5, 11, 14, 21, 999, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c3875197-1b44-4557-96f1-166c681ce5a4"), "Ea laborum nulla quis voluptate laborum et eum doloremque.", "a881b7e2-5318-43d3-9c18-feca3e56603c", new DateTime(2019, 2, 10, 15, 17, 39, 372, DateTimeKind.Local).AddTicks(4904), "Product unit classifier: fugit", new DateTime(2020, 12, 24, 14, 37, 9, 583, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c6bee53f-4585-4274-94c3-ba79030150b6"), "Ipsam quae voluptatem.", "7f31a91b-d6cf-443c-8116-690daefd2d4b", new DateTime(2018, 2, 17, 15, 23, 39, 346, DateTimeKind.Local).AddTicks(4573), "Product unit classifier: et", new DateTime(2020, 10, 8, 5, 46, 39, 847, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8f78ba5-93e6-4874-915f-471e3396c965"), "Dolor numquam cupiditate a alias explicabo et suscipit et et.", "1562d9ee-9ea7-4f37-9e83-1c640d5b35f3", new DateTime(2020, 12, 1, 13, 8, 3, 441, DateTimeKind.Local).AddTicks(8588), "Product unit classifier: quia", new DateTime(2022, 1, 30, 6, 54, 15, 137, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c988141d-5479-43f8-9325-95abebcb15e7"), "Laborum possimus assumenda cupiditate.", "d83f1e01-a6dc-401c-a25b-61d0f608e428", new DateTime(2017, 8, 10, 1, 55, 2, 802, DateTimeKind.Local).AddTicks(5871), "Product unit classifier: quo", new DateTime(2018, 6, 14, 0, 30, 45, 145, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf776783-11c2-4a07-9673-4893a72d1477"), "Nisi qui sed cumque quos ipsa voluptas quas.", "d618aa9e-d5d8-426d-979b-2ee5eed84b16", new DateTime(2018, 10, 24, 4, 1, 30, 75, DateTimeKind.Local).AddTicks(4103), "Product unit classifier: dolorum", new DateTime(2019, 9, 6, 22, 1, 12, 804, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d28c744d-3feb-4913-acb4-04f78ab6ab78"), "Vel magnam ut.", "bc46b7bf-5a73-457f-8968-235c18066376", new DateTime(2018, 10, 30, 8, 22, 20, 841, DateTimeKind.Local).AddTicks(1676), "Product unit classifier: quasi", new DateTime(2019, 9, 20, 4, 38, 50, 782, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d5c1ef5f-dc35-45a8-8e12-0c110bd0f244"), "Magnam sed in et possimus.", "2bf6ca85-6857-4b5f-8aec-5d0bb45d48e7", new DateTime(2021, 5, 7, 0, 9, 31, 278, DateTimeKind.Local).AddTicks(3502), "Product unit classifier: qui", new DateTime(2021, 12, 16, 1, 52, 5, 624, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7198550-de97-4acc-877f-fba7601e4f7f"), "Blanditiis voluptas quia laudantium voluptatem.", "e23bdbc1-4044-45ea-bb2f-ed52453f1a0e", new DateTime(2020, 10, 9, 11, 58, 34, 46, DateTimeKind.Local).AddTicks(3483), "Product unit classifier: reprehenderit", new DateTime(2022, 3, 25, 1, 25, 15, 416, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7be33fe-5fdd-4b39-903e-8a40b1068a94"), "Voluptates laborum sed et nulla in dolore non quia.", "4e00f6b5-9af1-46ee-82f8-497a9d2690a2", new DateTime(2020, 7, 12, 13, 27, 26, 898, DateTimeKind.Local).AddTicks(9280), "Product unit classifier: ratione", new DateTime(2021, 3, 25, 5, 19, 8, 627, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dae934c4-edd8-49ab-9724-2ac67e0de427"), "Qui pariatur reprehenderit dolorum voluptatem dicta consequatur quod.", "7d7c69fe-3c4e-454e-9a33-79c1b1572557", new DateTime(2019, 9, 13, 16, 17, 26, 642, DateTimeKind.Local).AddTicks(2234), "Product unit classifier: eos", new DateTime(2022, 7, 3, 19, 39, 0, 643, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dd823a0f-edf1-42bc-9da7-7226533e8e4f"), "Rerum esse aspernatur quia doloribus distinctio laudantium sequi.", "ad9b189c-55f7-46c2-b7fa-894234328a48", new DateTime(2018, 12, 5, 3, 22, 43, 125, DateTimeKind.Local).AddTicks(2140), "Product unit classifier: deserunt", new DateTime(2020, 11, 13, 14, 47, 35, 307, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3d9567a-58e0-4572-86a5-38866266ae0f"), "Sed et autem blanditiis aut molestias voluptatem.", "5e005ba6-3b32-47c8-aa8c-5efddab1ee56", new DateTime(2018, 6, 29, 18, 23, 21, 27, DateTimeKind.Local).AddTicks(1498), "Product unit classifier: eligendi", new DateTime(2020, 7, 27, 5, 45, 56, 27, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6fe3f4c-1549-4e1f-99e0-248adb363ae2"), "Non cumque sed sint maxime ea.", "31461b71-36d2-454e-bffb-84b7729c3494", new DateTime(2018, 6, 19, 15, 3, 12, 316, DateTimeKind.Local).AddTicks(1235), "Product unit classifier: voluptatum", new DateTime(2018, 12, 1, 8, 29, 6, 824, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7bd0e22-8ee0-4e8c-a809-3a399d38bc0e"), "Sequi commodi iure et voluptatibus aut maxime.", "8ea9416e-1212-4599-812a-fa887c146c6b", new DateTime(2018, 5, 9, 0, 12, 30, 321, DateTimeKind.Local).AddTicks(9483), "Product unit classifier: eum", new DateTime(2020, 8, 5, 11, 38, 51, 167, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8cf150b-9223-4602-bbf1-47d1d45f000f"), "Nulla quia sint.", "3ec674c4-d29e-420b-838e-4915bb3c147e", new DateTime(2018, 1, 28, 19, 25, 27, 529, DateTimeKind.Local).AddTicks(8727), "Product unit classifier: totam", new DateTime(2020, 8, 20, 15, 31, 34, 979, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eba56871-ba56-4cf4-9e97-04312a03cf48"), "Consequatur magnam et dolores velit quo perferendis dolores.", "74bdb6be-9f47-4974-9c6c-17f913843f89", new DateTime(2018, 3, 25, 18, 11, 17, 586, DateTimeKind.Local).AddTicks(5626), "Product unit classifier: rerum", new DateTime(2020, 3, 5, 18, 54, 53, 913, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f164d98c-0550-4670-b46c-b6050bf86fab"), "Est harum nihil facilis.", "a34f3079-1571-402e-b681-d98f8a1b37ea", new DateTime(2018, 6, 28, 6, 20, 13, 448, DateTimeKind.Local).AddTicks(4997), "Product unit classifier: ea", new DateTime(2021, 7, 15, 16, 11, 38, 9, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3c2939a-b8c7-4d4a-988a-b30c3a5872c1"), "Eos unde qui rem facilis ducimus veniam tenetur fugit.", "2ba98f05-0dde-45fc-b1eb-2b97d7af00a3", new DateTime(2020, 6, 29, 20, 37, 25, 130, DateTimeKind.Local).AddTicks(2795), "Product unit classifier: aspernatur", new DateTime(2021, 10, 18, 20, 55, 56, 15, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f68081a6-fd10-47a2-a2b9-a599b75b44d3"), "Dignissimos doloremque ut ipsam unde et.", "67df867d-6551-4fd6-a383-a1149650af3b", new DateTime(2021, 11, 2, 2, 57, 1, 211, DateTimeKind.Local).AddTicks(4923), "Product unit classifier: sint", new DateTime(2022, 5, 20, 18, 3, 56, 473, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("faeeba83-f936-4832-ba72-144ca6afc0eb"), "Quasi molestiae perspiciatis sunt perspiciatis maiores vel dolores aut numquam.", "062c9716-9a1f-40c6-9be6-0584f6d88474", new DateTime(2020, 9, 2, 10, 41, 23, 281, DateTimeKind.Local).AddTicks(274), "Product unit classifier: veniam", new DateTime(2021, 4, 16, 7, 5, 29, 299, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fbd6852c-4f9b-4ebb-86d1-5a01d08cddd6"), "Quo quo amet.", "4cae50c4-e808-483e-9f40-6c3895c7a6a8", new DateTime(2017, 9, 20, 3, 24, 56, 235, DateTimeKind.Local).AddTicks(1110), "Product unit classifier: impedit", new DateTime(2021, 9, 16, 10, 28, 48, 379, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fed2bdd0-5b57-4756-a3ee-6518e8121256"), "Ea culpa voluptas qui.", "4d937f23-71e4-431b-8fdc-be79624cf91b", new DateTime(2020, 4, 24, 22, 45, 2, 894, DateTimeKind.Local).AddTicks(7880), "Product unit classifier: repellendus", new DateTime(2022, 2, 21, 12, 57, 57, 317, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff102c64-9dd7-401b-8958-b1366352b7a0"), "Architecto natus distinctio quisquam hic iste quod quaerat.", "136362c9-6e7c-437f-a4b5-92b5c0c2d3da", new DateTime(2020, 11, 2, 15, 4, 21, 587, DateTimeKind.Local).AddTicks(3357), "Product unit classifier: reprehenderit", new DateTime(2022, 5, 30, 6, 9, 2, 254, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ffbf016d-6a37-427a-aeac-0c8f77a77ebd"), "Asperiores nam numquam est et quidem voluptatem.", "01233eb9-a587-4739-a4d0-2598a7aaf9d0", new DateTime(2017, 11, 6, 0, 59, 22, 946, DateTimeKind.Local).AddTicks(7395), "Product unit classifier: nihil", new DateTime(2020, 2, 24, 6, 55, 0, 838, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0088b2c0-5ff3-4993-a8ae-d65eb036ff40"), "Distinctio asperiores dolor.", "4efcf488-2051-4e95-b644-9de62a51c079", new DateTime(2018, 3, 5, 0, 21, 30, 735, DateTimeKind.Local).AddTicks(8806), "Product unit measurement: ad", new DateTime(2021, 8, 21, 7, 14, 7, 579, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("041937bf-b7ed-4605-b184-d8cb86a23e73"), "Autem sint vero.", "3094f03a-322e-4ed9-a225-fd1abb870825", new DateTime(2021, 4, 11, 9, 30, 15, 935, DateTimeKind.Local).AddTicks(9548), "Product unit measurement: a", new DateTime(2021, 4, 12, 16, 15, 54, 475, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0b4bdcb8-9bb1-47ce-bcfc-c1960c80b4cf"), "Perferendis excepturi corrupti dolor exercitationem aut doloribus sapiente odit iste.", "f0f56144-304e-436e-871d-0c4b50f53e9a", new DateTime(2020, 7, 17, 1, 47, 21, 989, DateTimeKind.Local).AddTicks(2174), "Product unit measurement: esse", new DateTime(2021, 5, 6, 1, 21, 7, 689, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0b5b1933-730a-426b-bc14-2f54af59f6fb"), "Laboriosam commodi aut aut officia rerum.", "e1d053af-1028-43b3-a755-69953e2e265e", new DateTime(2020, 5, 19, 16, 23, 56, 397, DateTimeKind.Local).AddTicks(8470), "Product unit measurement: rerum", new DateTime(2020, 6, 26, 5, 2, 17, 781, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0eb3eb71-0267-4ebc-9f8c-dc2f0eb14d95"), "At deleniti natus.", "2e4d5a1b-cf7e-4a00-85e3-75a1bb6d35f1", new DateTime(2019, 12, 3, 5, 51, 16, 773, DateTimeKind.Local).AddTicks(2405), "Product unit measurement: totam", new DateTime(2021, 10, 27, 4, 32, 25, 552, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0eb75793-96c3-42c7-8791-8320b285f3a8"), "Voluptate dolor eius quia ut corporis ut minima quasi.", "2d7d5d2b-e89d-4715-96cc-624ef5229349", new DateTime(2021, 5, 30, 9, 17, 55, 509, DateTimeKind.Local).AddTicks(6829), "Product unit measurement: quaerat", new DateTime(2021, 6, 5, 9, 11, 20, 315, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0fa4f9ee-26ad-49c4-863f-3173f80e25e3"), "Perspiciatis officiis cum.", "d62883fa-be68-4c0c-9bef-a399c56af07f", new DateTime(2021, 8, 26, 4, 20, 41, 165, DateTimeKind.Local).AddTicks(8644), "Product unit measurement: architecto", new DateTime(2022, 6, 18, 9, 22, 26, 757, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19441030-ed62-49fa-a317-095650e1ae9b"), "Et cumque ad.", "c4fb2675-c752-412f-a62d-6ab5d3c6817a", new DateTime(2018, 11, 29, 2, 34, 17, 226, DateTimeKind.Local).AddTicks(4825), "Product unit measurement: consectetur", new DateTime(2019, 4, 26, 7, 35, 7, 213, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1f0d74bb-55b2-40cb-b6de-2247b3dad0a0"), "Omnis minima vero molestias ad molestiae ullam temporibus officiis omnis.", "3237fe3a-40e5-4aac-ac25-cd33b6af4a24", new DateTime(2021, 6, 6, 15, 23, 52, 879, DateTimeKind.Local).AddTicks(2432), "Product unit measurement: repellat", new DateTime(2021, 6, 25, 15, 25, 30, 643, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("20a1bab3-07c4-407b-bbe9-5c85ea237912"), "Explicabo deserunt et voluptas.", "bcf31894-c787-480f-9df6-eafec9efad2a", new DateTime(2019, 4, 13, 8, 1, 26, 365, DateTimeKind.Local).AddTicks(9829), "Product unit measurement: libero", new DateTime(2020, 6, 30, 15, 55, 38, 409, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2952126b-fa53-4e10-bde8-d9e225d9165a"), "Hic rem sit eaque voluptatibus quibusdam quod.", "d42b219e-6fd2-4a56-a59c-3a03b7bd98a9", new DateTime(2021, 10, 29, 15, 1, 8, 555, DateTimeKind.Local).AddTicks(5766), "Product unit measurement: maxime", new DateTime(2022, 4, 30, 8, 52, 38, 869, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e4bcae1-cafa-4d5d-995b-fcf63f3c68ce"), "Facere cupiditate ullam id laudantium et voluptas non cupiditate voluptate.", "d29d080b-5a95-466d-80a2-30d26c93d479", new DateTime(2020, 5, 21, 15, 53, 12, 857, DateTimeKind.Local).AddTicks(3572), "Product unit measurement: sunt", new DateTime(2021, 12, 6, 2, 19, 39, 143, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e70c4d4-14d0-4ebb-b117-e60bbbba5298"), "Optio et quaerat sit eligendi eligendi.", "989c9396-982b-47e4-8fca-ac281347ca16", new DateTime(2018, 7, 30, 13, 14, 39, 88, DateTimeKind.Local).AddTicks(2798), "Product unit measurement: in", new DateTime(2021, 8, 4, 5, 42, 41, 966, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f5f3c73-56a1-4faf-b63c-ef367cad292f"), "Id in accusamus qui enim voluptas dolores nesciunt accusamus.", "90df0b58-668c-43f2-9f6e-5811ef2ece12", new DateTime(2018, 7, 29, 5, 11, 24, 900, DateTimeKind.Local).AddTicks(5691), "Product unit measurement: iusto", new DateTime(2018, 12, 24, 21, 12, 51, 809, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2facfea5-04c3-436c-9555-baaf71a3f2fb"), "Esse ipsa tenetur non minus.", "2dcbb69d-dd6a-4199-9f6c-55b2d8ea601a", new DateTime(2020, 11, 17, 15, 31, 29, 264, DateTimeKind.Local).AddTicks(5425), "Product unit measurement: dolorem", new DateTime(2021, 9, 19, 10, 33, 12, 852, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("301f3319-668b-45db-8ebe-931375ed68e0"), "Explicabo incidunt sed et sed.", "86a0993b-9aec-46d7-a6a1-80617b431c17", new DateTime(2022, 3, 15, 11, 42, 36, 850, DateTimeKind.Local).AddTicks(7967), "Product unit measurement: sequi", new DateTime(2022, 4, 15, 15, 22, 11, 696, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3046177c-9bf8-43a3-8bde-232e2236ee99"), "Repellendus velit accusantium eos porro rerum.", "e707446b-07cd-4d43-b9bd-3475bbd7f2d2", new DateTime(2017, 11, 4, 0, 11, 43, 341, DateTimeKind.Local).AddTicks(2994), "Product unit measurement: animi", new DateTime(2018, 10, 6, 19, 53, 14, 223, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30a5dcfd-f345-4f08-92ea-7fc1dfaf1aaa"), "Nihil aut nam.", "04fec119-7488-468f-94fc-452ed0d3e661", new DateTime(2022, 3, 16, 7, 57, 52, 307, DateTimeKind.Local).AddTicks(1421), "Product unit measurement: reprehenderit", new DateTime(2022, 3, 28, 5, 54, 20, 901, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32f23f6f-caf0-4799-ac44-363e2cb2a3f7"), "Aspernatur est quia voluptas.", "7416f8c7-66af-48fc-80d8-1b391ac48a9f", new DateTime(2022, 6, 7, 3, 39, 49, 975, DateTimeKind.Local).AddTicks(3356), "Product unit measurement: ut", new DateTime(2022, 6, 30, 14, 59, 59, 362, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35cd8d3b-43ae-44d8-83c8-8bf8f3b03bf1"), "Consectetur asperiores molestias nisi voluptatum.", "50364959-52a8-4177-be9d-d2da2ed9789c", new DateTime(2020, 1, 4, 12, 14, 52, 60, DateTimeKind.Local).AddTicks(4494), "Product unit measurement: voluptatum", new DateTime(2020, 10, 4, 9, 6, 44, 436, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38536370-4b3a-4df5-a1e4-c6e40380c2de"), "Expedita voluptatem vel fuga voluptatum perspiciatis aliquam quod sit voluptatem.", "e329f27e-8811-48ce-9437-b49190e18409", new DateTime(2019, 6, 1, 20, 36, 54, 269, DateTimeKind.Local).AddTicks(6035), "Product unit measurement: neque", new DateTime(2021, 7, 5, 14, 48, 54, 443, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3c67f659-2899-41a7-8360-e20d99457d34"), "Aut quibusdam omnis sed.", "c3c8deff-d835-4a99-9932-feb69423aa64", new DateTime(2019, 4, 5, 5, 44, 17, 327, DateTimeKind.Local).AddTicks(552), "Product unit measurement: laboriosam", new DateTime(2020, 4, 10, 6, 46, 14, 523, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3df701b1-f730-43ea-bc74-e74f410db08b"), "Maiores quis similique eum non.", "1358bc16-f833-43ad-952a-7d0310b4070d", new DateTime(2021, 9, 17, 16, 14, 50, 389, DateTimeKind.Local).AddTicks(8191), "Product unit measurement: et", new DateTime(2021, 10, 12, 21, 59, 39, 157, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e34e390-423b-4f83-994f-9a1019752b63"), "Asperiores vero eligendi rerum assumenda enim hic hic velit rem.", "4f9c66c2-7ece-4f8d-877d-05db64d11734", new DateTime(2020, 4, 4, 23, 56, 40, 510, DateTimeKind.Local).AddTicks(3244), "Product unit measurement: laudantium", new DateTime(2022, 1, 6, 10, 34, 31, 907, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e6ce89d-b77b-4410-a356-bde0c1e2ea67"), "Est debitis facilis molestias.", "49781159-abe0-4adf-ac4d-5d4f7d817227", new DateTime(2017, 8, 14, 12, 57, 3, 890, DateTimeKind.Local).AddTicks(9475), "Product unit measurement: deserunt", new DateTime(2019, 4, 2, 2, 4, 3, 75, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3feaa000-4b13-474d-9bd2-7a488409e0db"), "Aspernatur aut repellat velit iste.", "1abb496e-fe7b-4287-908c-65feb7593bc5", new DateTime(2019, 1, 30, 21, 46, 13, 434, DateTimeKind.Local).AddTicks(3348), "Product unit measurement: sapiente", new DateTime(2019, 2, 12, 23, 58, 23, 57, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41a5dd87-b718-4ee9-bcc4-69643809de4e"), "Similique asperiores eaque ipsam quidem.", "5a1a9b69-9bfe-45fb-9a70-460ec8dc51ce", new DateTime(2019, 9, 6, 2, 46, 43, 749, DateTimeKind.Local).AddTicks(8702), "Product unit measurement: modi", new DateTime(2019, 12, 11, 8, 5, 21, 696, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("449459a2-78cd-4583-a1ee-f05c31c5e449"), "Qui facilis eum id magnam dolore cumque.", "bd5f9477-9c56-47ad-8998-b65ba90bad7f", new DateTime(2020, 6, 17, 9, 43, 45, 493, DateTimeKind.Local).AddTicks(3631), "Product unit measurement: est", new DateTime(2020, 8, 15, 2, 35, 25, 117, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("461dc110-725d-4b11-b4e7-dbe54e7352d1"), "Fugiat dolore natus et quasi veritatis est magnam.", "f51eb11b-bc37-4577-816a-8fe77253be20", new DateTime(2018, 3, 7, 7, 45, 39, 718, DateTimeKind.Local).AddTicks(3586), "Product unit measurement: aut", new DateTime(2020, 9, 27, 4, 22, 49, 560, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4720f60c-5e72-4c37-a09d-02ab9f268cc4"), "Quos ipsa qui.", "9de0551b-d88b-4e34-80ba-bccd57c6f317", new DateTime(2021, 12, 31, 4, 22, 20, 961, DateTimeKind.Local).AddTicks(909), "Product unit measurement: omnis", new DateTime(2022, 2, 18, 15, 20, 4, 143, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4795eaf0-8940-444e-b65c-d9ba46a78488"), "Recusandae dolorum nihil velit ab.", "59a62580-8428-4488-b293-74693d63076e", new DateTime(2022, 3, 25, 18, 34, 35, 761, DateTimeKind.Local).AddTicks(2792), "Product unit measurement: voluptates", new DateTime(2022, 5, 26, 10, 44, 12, 27, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b377efb-6e2c-4726-be2c-333b5d0b5212"), "Ad qui rem perferendis fugiat dicta quia.", "5d41e1f8-135d-4ece-9b44-03df8b2b53f8", new DateTime(2018, 4, 25, 16, 28, 45, 970, DateTimeKind.Local).AddTicks(4440), "Product unit measurement: eos", new DateTime(2020, 2, 24, 3, 42, 18, 32, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4ed37d8f-c1c4-48f4-9562-08498575f082"), "Est saepe dolorem illum deleniti ducimus.", "0695cb76-afb4-4aff-9e7f-1a84bd5a0510", new DateTime(2019, 2, 20, 22, 47, 47, 197, DateTimeKind.Local).AddTicks(6816), "Product unit measurement: ipsam", new DateTime(2019, 3, 25, 4, 27, 4, 358, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f4da032-ccca-4bc2-8f81-a35a94a75857"), "Facilis commodi velit.", "0b95d3f2-2d46-4410-8b0e-c5912819f233", new DateTime(2019, 9, 18, 11, 13, 53, 162, DateTimeKind.Local).AddTicks(3938), "Product unit measurement: ut", new DateTime(2021, 7, 19, 16, 4, 19, 289, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53bc8970-7e1a-4cd9-9108-f3dc153e7e6b"), "Delectus ea pariatur eveniet id.", "f0bb8e10-63fe-405b-9f48-775adc8a1c8c", new DateTime(2018, 12, 11, 14, 33, 6, 851, DateTimeKind.Local).AddTicks(4009), "Product unit measurement: cupiditate", new DateTime(2019, 9, 11, 18, 8, 0, 67, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55526449-1785-43ba-807a-17b785feb1b8"), "Necessitatibus illum ex repudiandae aut ut dicta totam similique.", "93f20bab-d5ca-44af-ac46-00f503710de2", new DateTime(2022, 5, 17, 15, 13, 5, 411, DateTimeKind.Local).AddTicks(9287), "Product unit measurement: optio", new DateTime(2022, 6, 14, 20, 48, 29, 256, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("58661b44-aeae-4d7e-8a10-2d7c3ab21347"), "Maiores vel expedita illum dignissimos quia.", "fc6309e4-7d41-4d4f-bf00-625f0090ce02", new DateTime(2022, 6, 4, 4, 28, 55, 689, DateTimeKind.Local).AddTicks(4900), "Product unit measurement: autem", new DateTime(2022, 6, 9, 12, 1, 30, 861, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("60f38ea1-7327-4469-934a-9200186080b5"), "Consequatur quo beatae ipsa molestiae consequuntur officiis excepturi consequatur nihil.", "7e781e47-d8f2-4f8d-a7e8-511ee0274c8d", new DateTime(2022, 3, 29, 6, 27, 40, 760, DateTimeKind.Local).AddTicks(1854), "Product unit measurement: voluptas", new DateTime(2022, 5, 10, 23, 28, 14, 778, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("64387f25-43f4-485d-a0de-fe14fbf1ea10"), "Voluptas excepturi dolores.", "09cdf54f-c0e7-4b00-a396-7823a1dbc54e", new DateTime(2020, 3, 12, 4, 19, 45, 822, DateTimeKind.Local).AddTicks(2456), "Product unit measurement: itaque", new DateTime(2022, 3, 24, 12, 18, 20, 785, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6626c5db-0c1f-43cf-b8bf-bcbd3fd9e831"), "Sint aut earum eum eligendi eligendi.", "032f1808-4a69-4803-9f19-d0f8919fd372", new DateTime(2021, 11, 5, 7, 1, 21, 950, DateTimeKind.Local).AddTicks(7793), "Product unit measurement: natus", new DateTime(2022, 5, 10, 19, 24, 31, 88, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("678e13f5-477b-4fd2-8ecc-1f605797cdd1"), "Consequatur accusamus voluptates occaecati ab totam iure cum.", "d1018ed3-e7bd-408b-94f3-a5f1bc689c13", new DateTime(2020, 11, 5, 2, 12, 34, 817, DateTimeKind.Local).AddTicks(4150), "Product unit measurement: in", new DateTime(2022, 6, 6, 12, 50, 10, 360, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6bf28d48-ec34-4097-9b2a-b7a46e9302f3"), "Vel quasi corrupti reiciendis atque vero et est in repellat.", "ee8d66b1-798f-4a17-93d6-4dad0c6fb51b", new DateTime(2019, 5, 17, 3, 13, 31, 316, DateTimeKind.Local).AddTicks(9764), "Product unit measurement: dolore", new DateTime(2022, 1, 14, 23, 14, 22, 172, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72649d6e-7fdd-4995-88df-278c448aff2b"), "Tempore consequatur dicta autem maxime eum quidem minima.", "421df567-cf2d-456c-8b3e-1f5aec81514a", new DateTime(2017, 9, 5, 19, 29, 55, 496, DateTimeKind.Local).AddTicks(3723), "Product unit measurement: dolor", new DateTime(2022, 5, 13, 5, 31, 52, 291, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73424e60-9509-417d-ab47-50d1e5a857ee"), "Quo provident reiciendis aut id.", "7e9e1ae5-4f5f-40c2-9fbf-45b7ea77e526", new DateTime(2017, 8, 24, 1, 42, 7, 161, DateTimeKind.Local).AddTicks(8652), "Product unit measurement: in", new DateTime(2021, 7, 28, 12, 55, 54, 463, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7cc01867-66db-424e-a089-99ec599beae1"), "Et quas ducimus et enim qui voluptatibus.", "cccf9035-c51b-4fc3-a30a-bedf743e8b67", new DateTime(2021, 1, 8, 16, 6, 34, 471, DateTimeKind.Local).AddTicks(9970), "Product unit measurement: dolorem", new DateTime(2022, 3, 23, 5, 41, 26, 535, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e189734-cd9b-4876-aaaa-f5d761dfb94a"), "Doloremque qui qui a minus natus ea vel.", "f4e81f99-9e88-4fae-aeef-6fb4b395ef63", new DateTime(2022, 2, 9, 22, 33, 33, 119, DateTimeKind.Local).AddTicks(9067), "Product unit measurement: qui", new DateTime(2022, 5, 15, 7, 17, 31, 350, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8260a2bd-cb52-4cc4-800e-aaaa46acbf92"), "Quia iusto necessitatibus maxime et assumenda id rem.", "9493f10b-e183-4d27-8a99-0871adc03c9c", new DateTime(2018, 1, 10, 9, 47, 55, 300, DateTimeKind.Local).AddTicks(1590), "Product unit measurement: saepe", new DateTime(2021, 9, 5, 12, 52, 13, 585, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("890321e0-36d7-4ce6-ba23-0786f25c9428"), "Culpa voluptatibus suscipit nisi cum deserunt labore rerum.", "3a2a1f41-4318-4b7c-9b0a-12ffa2af5b76", new DateTime(2020, 9, 14, 17, 38, 50, 233, DateTimeKind.Local).AddTicks(2051), "Product unit measurement: aliquam", new DateTime(2021, 8, 14, 19, 52, 41, 559, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c4958be-af5c-444f-bf7b-51ff6abc0239"), "Dolor incidunt rem occaecati.", "331f72e7-1133-401b-833e-74f2eff5a705", new DateTime(2022, 4, 19, 19, 54, 41, 231, DateTimeKind.Local).AddTicks(8383), "Product unit measurement: velit", new DateTime(2022, 6, 29, 17, 11, 7, 917, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ef2183f-a8aa-4a1d-8daf-dd6c2bf3dcdf"), "Rerum sunt cumque aut ipsum aut ex velit.", "bfe5a7ad-318a-495c-9d30-b9df62172811", new DateTime(2022, 3, 10, 14, 19, 13, 689, DateTimeKind.Local).AddTicks(5588), "Product unit measurement: officiis", new DateTime(2022, 5, 11, 2, 26, 50, 615, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("903936d5-aa9c-45ea-9642-22eeda26105d"), "Ipsa id ut possimus beatae architecto sit veritatis.", "ce498d21-1ed4-4b02-835b-ed7bd116cb67", new DateTime(2018, 12, 9, 5, 19, 2, 842, DateTimeKind.Local).AddTicks(379), "Product unit measurement: et", new DateTime(2021, 9, 27, 22, 36, 10, 24, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("96e3b903-c0e8-4f02-8d32-f96bd909ee3b"), "Ea quam molestiae neque libero.", "caae41ef-92b8-42cf-8d3e-90579063c0bf", new DateTime(2020, 9, 6, 10, 8, 22, 344, DateTimeKind.Local).AddTicks(1746), "Product unit measurement: quia", new DateTime(2021, 7, 8, 1, 47, 17, 155, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("977b578e-e7ec-404d-a029-a739d7353b00"), "Assumenda est explicabo voluptas fuga et.", "5e214ec5-6172-4ea4-8c6a-34580ca351c1", new DateTime(2021, 11, 20, 21, 20, 7, 446, DateTimeKind.Local).AddTicks(893), "Product unit measurement: consequatur", new DateTime(2022, 3, 8, 20, 47, 11, 331, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9cebe445-505a-467c-8af1-e86f67e9db3a"), "Vel praesentium repudiandae et.", "9d610deb-3cee-410f-83f6-10c937ab3982", new DateTime(2019, 3, 6, 16, 4, 40, 461, DateTimeKind.Local).AddTicks(3499), "Product unit measurement: in", new DateTime(2021, 12, 24, 2, 18, 13, 265, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a20cfa73-37bc-4a4d-b8af-293e2e320abe"), "Sit fugit qui rem est.", "23094fad-efcf-4d58-825b-7e90a5e236ee", new DateTime(2018, 3, 14, 19, 24, 21, 822, DateTimeKind.Local).AddTicks(841), "Product unit measurement: magni", new DateTime(2018, 12, 26, 12, 45, 7, 739, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a41953e8-19d3-4134-8d30-2451b59b2ff0"), "Et molestiae fugit quis neque.", "2596a6da-0788-4871-88c9-c051ab653dc2", new DateTime(2022, 6, 28, 4, 41, 26, 481, DateTimeKind.Local).AddTicks(5538), "Product unit measurement: eveniet", new DateTime(2022, 6, 29, 9, 21, 48, 202, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a960e953-d3ba-4702-98df-5c0fbbb5e73c"), "In nihil sint vero perspiciatis fugiat.", "baf0b507-db1a-4432-91f2-e6d295c8206e", new DateTime(2018, 9, 9, 10, 36, 29, 993, DateTimeKind.Local).AddTicks(8902), "Product unit measurement: asperiores", new DateTime(2021, 3, 31, 18, 33, 18, 743, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa34cf9d-9c53-495b-a10f-086db5c6fd06"), "Voluptatem quaerat omnis ut.", "40fba646-75bd-4839-8882-a8bd8d575724", new DateTime(2021, 6, 17, 11, 43, 54, 81, DateTimeKind.Local).AddTicks(7189), "Product unit measurement: veniam", new DateTime(2021, 12, 4, 1, 15, 28, 53, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab7d4560-34a8-44e6-a68e-9dd2a79ac2dc"), "Libero reiciendis delectus.", "09b6684d-2a11-45dc-878a-dd4fddcb9cf9", new DateTime(2022, 4, 10, 6, 43, 51, 522, DateTimeKind.Local).AddTicks(7438), "Product unit measurement: qui", new DateTime(2022, 4, 26, 10, 47, 45, 917, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae7e6388-9b77-4105-bf01-f09c5c459f60"), "In autem veritatis enim sed labore provident qui.", "4726e532-8b87-45dd-a098-ec6642d616da", new DateTime(2021, 12, 15, 10, 18, 38, 532, DateTimeKind.Local).AddTicks(7326), "Product unit measurement: atque", new DateTime(2022, 4, 27, 11, 27, 46, 168, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("af306c49-f552-4b0d-9bcb-c88bcf77db2d"), "Harum dolores officiis voluptates cumque aut consequatur.", "0f660322-4f5c-41c4-84fe-0daaae8b3316", new DateTime(2020, 8, 22, 21, 46, 43, 376, DateTimeKind.Local).AddTicks(7804), "Product unit measurement: inventore", new DateTime(2020, 12, 16, 5, 7, 24, 747, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b139b62e-8bc2-485a-9c18-706af10cc597"), "Assumenda qui ut porro omnis et quae libero dignissimos.", "70ce2ebb-fc80-4462-9303-3b8bb1f67b49", new DateTime(2020, 8, 6, 23, 8, 55, 904, DateTimeKind.Local).AddTicks(5365), "Product unit measurement: modi", new DateTime(2020, 8, 8, 20, 22, 57, 571, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1bd27d6-4e5c-49b2-a1c0-bb71ce10e608"), "Aut reiciendis impedit aut incidunt consequatur ab numquam.", "a7009f0d-d03a-417f-9aba-de3750444e67", new DateTime(2021, 8, 28, 14, 41, 20, 892, DateTimeKind.Local).AddTicks(7808), "Product unit measurement: veniam", new DateTime(2022, 1, 26, 16, 52, 2, 728, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6395d54-3892-49f4-b0ad-d480dc470f61"), "Ipsa eos consequuntur architecto ea excepturi natus voluptatem maiores.", "4c9e1e3b-6bf2-4f30-a1ea-6ad0b541878c", new DateTime(2017, 7, 14, 6, 34, 47, 132, DateTimeKind.Local).AddTicks(7597), "Product unit measurement: omnis", new DateTime(2018, 5, 1, 21, 36, 42, 862, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b7628239-af80-492c-aa20-89b67bc0b5b4"), "Eos reprehenderit est dolorem.", "c0b9991d-7e0c-4d26-909f-26107551c8d9", new DateTime(2021, 11, 30, 10, 49, 15, 283, DateTimeKind.Local).AddTicks(2823), "Product unit measurement: quia", new DateTime(2022, 4, 15, 20, 38, 22, 359, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b80c5506-23ba-4e08-954b-ecbb9e00daa0"), "Iste cupiditate occaecati labore in voluptate autem incidunt fuga magni.", "b2418c86-0ba3-4a63-ae71-5f0f9cc1b4b4", new DateTime(2019, 9, 15, 9, 45, 16, 400, DateTimeKind.Local).AddTicks(8481), "Product unit measurement: non", new DateTime(2019, 12, 26, 9, 16, 0, 984, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8b26043-be14-4356-8e1a-ab9472389675"), "Eos recusandae rerum consequatur in laudantium.", "c332dd75-da21-4076-9c51-fcd4f8ccbfcb", new DateTime(2019, 10, 5, 18, 7, 42, 910, DateTimeKind.Local).AddTicks(1123), "Product unit measurement: eos", new DateTime(2021, 3, 12, 22, 23, 1, 69, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdd9e07c-8ef7-4b88-b299-a5c92f675952"), "Libero voluptas consequatur alias atque incidunt eos quam.", "647dd843-394c-4f5a-be25-f94662aa7411", new DateTime(2017, 11, 13, 16, 43, 2, 24, DateTimeKind.Local).AddTicks(9918), "Product unit measurement: sit", new DateTime(2018, 4, 6, 4, 37, 54, 296, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdd9e51e-71b4-4452-b305-cc197fdd8d9e"), "Rerum quaerat id vel rerum velit et.", "03982230-f2fb-4c3e-983b-cd77976432a9", new DateTime(2021, 4, 21, 18, 1, 26, 11, DateTimeKind.Local).AddTicks(8114), "Product unit measurement: quis", new DateTime(2022, 1, 13, 13, 3, 17, 428, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2c6dec0-067f-4be1-875b-b617c4328a78"), "Voluptatem et perferendis commodi.", "f92d6084-3a5d-4c2e-8457-4bba692091e3", new DateTime(2021, 1, 15, 18, 32, 18, 446, DateTimeKind.Local).AddTicks(7762), "Product unit measurement: aliquid", new DateTime(2021, 7, 30, 22, 52, 54, 245, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c529b01c-6cc9-4937-95e0-c1f26bde565e"), "Sit expedita deleniti eos odit consequuntur.", "d5ea5435-f737-46f6-a2a1-59fc788b73c4", new DateTime(2019, 7, 5, 10, 23, 59, 330, DateTimeKind.Local).AddTicks(1510), "Product unit measurement: qui", new DateTime(2022, 2, 13, 2, 2, 12, 355, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7c7f8f4-fa90-48e6-9247-1cc8d0ae1aee"), "Autem earum voluptatem velit omnis aut et hic eum dolor.", "ea23a240-458c-46f2-a3c0-4753b4224674", new DateTime(2020, 1, 13, 7, 33, 20, 54, DateTimeKind.Local).AddTicks(836), "Product unit measurement: voluptatum", new DateTime(2022, 1, 21, 2, 16, 29, 44, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8594e1f-5dc7-4cb4-8f7b-9e4f702615c7"), "Sit harum officia.", "5c389d8c-f634-44a2-99bf-fda64bbe61a5", new DateTime(2018, 5, 17, 20, 57, 0, 305, DateTimeKind.Local).AddTicks(3963), "Product unit measurement: incidunt", new DateTime(2018, 6, 20, 10, 33, 44, 572, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cc6c01e3-332e-48b7-b7f0-5ee5da6ccdd0"), "Deleniti dolore sit distinctio repudiandae perferendis tenetur.", "a3623e7f-066c-47a1-95a1-3ffe57a5a62b", new DateTime(2019, 7, 20, 8, 34, 7, 65, DateTimeKind.Local).AddTicks(1318), "Product unit measurement: dolores", new DateTime(2021, 4, 28, 14, 22, 24, 209, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cdeb6d82-ecad-49f4-943a-0832e80dd62f"), "Velit laboriosam necessitatibus id aperiam error aliquam.", "0ef0f113-08b2-4b96-b517-7c98e31736c8", new DateTime(2020, 11, 13, 17, 46, 13, 642, DateTimeKind.Local).AddTicks(4107), "Product unit measurement: et", new DateTime(2021, 4, 2, 5, 12, 4, 397, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d41a02f3-12a8-4433-b80e-a4b6c6599c76"), "Earum repudiandae error.", "64b7fcd1-05cd-47bb-bb2f-b5ef8226326c", new DateTime(2019, 12, 29, 3, 6, 59, 879, DateTimeKind.Local).AddTicks(5596), "Product unit measurement: eligendi", new DateTime(2021, 11, 5, 13, 53, 24, 380, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d74b7e9b-7003-4044-938e-ba5bcb12c9cd"), "Hic asperiores suscipit ipsum tempora id et.", "90b80bf2-edb6-459a-869f-de3194186cbb", new DateTime(2022, 1, 28, 16, 35, 42, 433, DateTimeKind.Local).AddTicks(6550), "Product unit measurement: sed", new DateTime(2022, 2, 4, 17, 11, 19, 506, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7619a35-5eec-4b54-9e8a-35da5ef5d001"), "Quibusdam magnam voluptatem dolorum.", "bc263a9e-120c-4bc0-8ba1-bb0a593abc84", new DateTime(2021, 9, 28, 21, 56, 25, 866, DateTimeKind.Local).AddTicks(61), "Product unit measurement: perferendis", new DateTime(2021, 12, 1, 14, 33, 39, 853, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d79a3575-4922-43ee-b65a-46dbf597dd7d"), "Molestiae eaque laboriosam accusantium accusantium quas ipsum necessitatibus.", "d4b4eb6c-06a6-4b31-9b63-f4da5a188338", new DateTime(2019, 11, 3, 18, 53, 30, 445, DateTimeKind.Local).AddTicks(7761), "Product unit measurement: asperiores", new DateTime(2022, 2, 25, 6, 18, 31, 774, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da20d612-969d-4e8f-a5af-ac36c3bda6cb"), "Cupiditate laboriosam distinctio aut maxime fuga labore aut consequatur.", "73b32de9-8136-4999-ba15-3ef4288c1816", new DateTime(2018, 5, 29, 1, 56, 33, 299, DateTimeKind.Local).AddTicks(971), "Product unit measurement: nisi", new DateTime(2019, 9, 22, 7, 48, 33, 278, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("daa39e29-1443-4fdd-9c20-fa33f370c732"), "Ipsum enim aperiam illum consequuntur rem sapiente.", "912f4ecd-81a1-4daa-ad3b-4f26dcac05d6", new DateTime(2017, 11, 12, 11, 22, 46, 221, DateTimeKind.Local).AddTicks(124), "Product unit measurement: est", new DateTime(2018, 10, 15, 15, 56, 25, 409, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de7d4e81-98b9-4933-8314-1dd62ff3f4e7"), "Minus dolores dolores inventore voluptates.", "702e0845-825d-43b3-82a6-677674eac612", new DateTime(2020, 12, 11, 5, 50, 51, 218, DateTimeKind.Local).AddTicks(6109), "Product unit measurement: officia", new DateTime(2021, 4, 6, 23, 56, 46, 604, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de866dc3-1c1d-45cd-89ac-d82121f38486"), "In totam in repudiandae totam id magni.", "325e2d3c-3a26-4e37-a81a-54f495313b27", new DateTime(2017, 11, 6, 13, 57, 5, 674, DateTimeKind.Local).AddTicks(658), "Product unit measurement: dolorum", new DateTime(2018, 12, 25, 22, 9, 19, 141, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1a8ea83-c734-4e22-ad85-05440c2ef585"), "Veniam neque aut aut quibusdam eum nam dicta ut.", "e16f15db-5450-4a78-8c86-681842f18196", new DateTime(2021, 12, 1, 2, 45, 53, 15, DateTimeKind.Local).AddTicks(3344), "Product unit measurement: maxime", new DateTime(2022, 1, 10, 11, 24, 0, 0, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5733dfd-737f-41f9-8ba6-f68c2d0259a0"), "Iste id vitae quis mollitia sunt fugiat magnam.", "169ef016-9ff0-4d12-ba48-19da769c742a", new DateTime(2020, 12, 22, 17, 11, 12, 599, DateTimeKind.Local).AddTicks(2415), "Product unit measurement: ducimus", new DateTime(2022, 1, 15, 14, 5, 42, 49, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8945288-3761-4e71-a007-65ec7d270df7"), "Non asperiores est ea praesentium corporis perferendis rerum magni in.", "6d310caf-f0c3-4120-b786-76e78a9e659c", new DateTime(2021, 10, 21, 3, 42, 5, 295, DateTimeKind.Local).AddTicks(5170), "Product unit measurement: vel", new DateTime(2021, 10, 29, 0, 5, 19, 97, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e97cb073-da88-4cd3-8a9e-3fcd37b49860"), "Facere optio ut dolor rerum enim et consequuntur.", "91f19b27-1ea2-424a-9a78-bc943d5c1270", new DateTime(2020, 7, 29, 22, 4, 31, 943, DateTimeKind.Local).AddTicks(7654), "Product unit measurement: quae", new DateTime(2020, 12, 12, 8, 35, 54, 213, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec5875cd-9af2-43eb-8b4e-29ee19740691"), "Consequatur dolores laborum ipsam qui ipsa culpa.", "05ff83fb-9fc1-44d4-bb86-1a86896896c8", new DateTime(2018, 12, 20, 14, 32, 54, 358, DateTimeKind.Local).AddTicks(1742), "Product unit measurement: accusantium", new DateTime(2020, 10, 12, 15, 22, 54, 319, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef4761ea-7d2d-459b-9896-c4f0f856f223"), "Unde et nulla qui qui.", "ed34d585-22c7-4456-b4fb-04d3383e52c8", new DateTime(2019, 5, 11, 8, 58, 27, 848, DateTimeKind.Local).AddTicks(5458), "Product unit measurement: ex", new DateTime(2022, 5, 27, 2, 50, 44, 160, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef9cbe19-0052-4c87-8ea7-74001b69a47b"), "Impedit laboriosam nostrum rem dolorum.", "91a6f3c5-cf7f-4eeb-8322-7c168f889dca", new DateTime(2020, 6, 24, 8, 19, 31, 314, DateTimeKind.Local).AddTicks(3815), "Product unit measurement: molestias", new DateTime(2020, 9, 5, 3, 9, 10, 199, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f011e355-545f-47ae-9afc-ddef5732f600"), "Placeat nulla consequatur et consectetur nulla laboriosam officiis quos deserunt.", "3ca4a0f6-36e6-4196-9bcc-3286d4b3f74f", new DateTime(2017, 12, 16, 6, 57, 3, 36, DateTimeKind.Local).AddTicks(3178), "Product unit measurement: qui", new DateTime(2020, 12, 18, 20, 9, 28, 747, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f231b8b4-4612-4204-878a-be90c27a2fe6"), "Occaecati perspiciatis debitis quisquam.", "2dc0b4f7-1236-48d5-97f9-5e563a8fef5b", new DateTime(2020, 11, 21, 23, 23, 19, 895, DateTimeKind.Local).AddTicks(498), "Product unit measurement: aperiam", new DateTime(2020, 12, 28, 9, 7, 35, 498, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6753c78-456b-4055-8c88-dd1a616d8939"), "Voluptatem cum ab accusantium qui dolores.", "907d61ec-4075-40bc-b9ba-3b8111cacbf7", new DateTime(2021, 2, 11, 20, 49, 53, 714, DateTimeKind.Local).AddTicks(8035), "Product unit measurement: cum", new DateTime(2022, 4, 11, 17, 10, 21, 904, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6aa24d0-84c2-495d-bc1b-94bea4be2848"), "Aliquid temporibus eum quam libero delectus eaque.", "4f29e09d-de45-4e5a-b969-ff2c58074df7", new DateTime(2022, 2, 11, 3, 31, 30, 66, DateTimeKind.Local).AddTicks(2681), "Product unit measurement: amet", new DateTime(2022, 2, 28, 20, 43, 59, 34, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f833afe1-8082-44a5-81b5-3b71a8bb8f37"), "Quis aspernatur at.", "c857e877-a89a-4242-a9de-31b841c5512e", new DateTime(2019, 5, 3, 7, 47, 10, 170, DateTimeKind.Local).AddTicks(8556), "Product unit measurement: est", new DateTime(2019, 10, 15, 16, 18, 33, 316, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa2f1171-b363-4d34-9081-8f9338fd7009"), "Vel ducimus molestiae magni rerum similique.", "8afbc297-035d-4351-bb66-573740768afb", new DateTime(2020, 10, 11, 0, 6, 59, 338, DateTimeKind.Local).AddTicks(2606), "Product unit measurement: vel", new DateTime(2020, 10, 24, 13, 55, 7, 803, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb9646a4-797a-4981-bb34-3fe114c14381"), "Ducimus perferendis et ut a exercitationem cumque tempore quo.", "d0e0a101-c4da-432f-b0d9-2ba55b44bc14", new DateTime(2021, 11, 10, 4, 15, 53, 257, DateTimeKind.Local).AddTicks(3003), "Product unit measurement: ea", new DateTime(2022, 1, 15, 2, 27, 56, 326, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc26dee6-a95b-478d-9915-0a31dad0ed27"), "Atque omnis nesciunt molestiae.", "dfd68489-cf72-4306-8e2b-0c1f82380334", new DateTime(2021, 7, 12, 17, 31, 8, 727, DateTimeKind.Local).AddTicks(2146), "Product unit measurement: sapiente", new DateTime(2021, 10, 21, 9, 17, 46, 108, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("feed2ce6-066d-4beb-af9c-2879276d5560"), "Eius sunt hic ut hic sed.", "6a4532f3-514d-4554-ada9-976b351954d8", new DateTime(2018, 3, 7, 18, 35, 41, 486, DateTimeKind.Local).AddTicks(5080), "Product unit measurement: omnis", new DateTime(2019, 6, 16, 11, 52, 46, 494, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff9a312e-5cd9-41f7-8c03-37865993c7e4"), "Voluptatem in porro.", "69ecb279-b83e-49d9-b7c0-85191bb48192", new DateTime(2019, 2, 2, 0, 10, 44, 921, DateTimeKind.Local).AddTicks(5947), "Product unit measurement: est", new DateTime(2021, 1, 9, 23, 17, 4, 838, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("00667000-044d-419b-a0f5-776cabf30853"), "Et repellat et omnis voluptas est sunt.", "54835b65-6468-449d-b9d1-9fbc5cb3c281", new DateTime(2021, 6, 21, 17, 18, 43, 261, DateTimeKind.Local).AddTicks(2308), "Storage: et", new DateTime(2021, 12, 3, 14, 7, 2, 923, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04b35bb8-0b31-442c-bd2d-8abf865d4ab0"), "Eveniet velit doloribus ad sed ut quae officia veniam.", "0bfea3e8-2260-4a75-983a-efa431e3cbc3", new DateTime(2018, 3, 29, 19, 45, 56, 334, DateTimeKind.Local).AddTicks(5125), "Storage: voluptas", new DateTime(2018, 8, 17, 8, 53, 35, 456, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0610cc91-d25e-42d6-ab74-98b608fa8f0c"), "Dolores cumque dignissimos.", "78637c8d-d215-459c-b0d3-a134c0a154b6", new DateTime(2020, 4, 10, 21, 44, 41, 985, DateTimeKind.Local).AddTicks(9532), "Storage: nostrum", new DateTime(2021, 9, 2, 16, 38, 40, 360, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("074ba8c6-831d-488c-b29c-f00aa15e7cae"), "Praesentium molestias delectus et sapiente qui est natus vitae.", "b1f9e5e8-4fff-4434-80ec-8d89a6c0092d", new DateTime(2020, 8, 16, 17, 30, 20, 818, DateTimeKind.Local).AddTicks(3294), "Storage: unde", new DateTime(2021, 2, 6, 9, 30, 49, 616, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08df19c6-9a40-4120-9412-0633eb11050c"), "Voluptatibus quia inventore dolores.", "4e9fd7a6-d63b-46a4-b85b-fa6da01769b8", new DateTime(2021, 6, 26, 18, 50, 54, 49, DateTimeKind.Local).AddTicks(6050), "Storage: deleniti", new DateTime(2021, 10, 7, 5, 54, 39, 625, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("09f82487-a7af-4f16-b452-370b32ade6b2"), "Est fuga quia fugiat nihil beatae iusto qui.", "a938fbfc-619f-4228-ac4c-55531afee8b4", new DateTime(2021, 7, 30, 7, 12, 26, 927, DateTimeKind.Local).AddTicks(6553), "Storage: autem", new DateTime(2021, 9, 8, 14, 16, 26, 438, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f995a04-19e9-4649-8f6e-2b8a2461c4f7"), "Nesciunt quis quo voluptas enim minima.", "47333e1c-d758-40f3-8d9b-d8761b923749", new DateTime(2021, 7, 4, 2, 19, 51, 127, DateTimeKind.Local).AddTicks(7204), "Storage: explicabo", new DateTime(2022, 4, 29, 21, 40, 32, 274, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0fa675b4-fc0c-46ff-a757-f00f0aae5485"), "Totam neque qui laudantium sequi vero eligendi et.", "6baaf2f2-1fa0-4494-b2f3-fc1a3e81521e", new DateTime(2019, 4, 4, 11, 43, 29, 871, DateTimeKind.Local).AddTicks(4063), "Storage: qui", new DateTime(2019, 5, 1, 15, 51, 33, 613, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("10866bb9-12cd-46ca-b50e-26c62df6a6fa"), "Quas non accusamus perspiciatis sit quis.", "984237b9-8e58-4c21-bea7-67b7e54b84d4", new DateTime(2022, 6, 25, 6, 4, 14, 903, DateTimeKind.Local).AddTicks(3105), "Storage: ab", new DateTime(2022, 6, 26, 17, 7, 22, 674, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15520388-27a7-49c7-9813-92666c14b850"), "Totam vel harum quidem perspiciatis inventore ipsam dolores quo.", "50298453-f117-448a-a601-7eb0442a0123", new DateTime(2017, 12, 21, 4, 0, 21, 8, DateTimeKind.Local).AddTicks(9946), "Storage: dignissimos", new DateTime(2019, 4, 7, 5, 35, 26, 128, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1814ca1a-76bc-480a-a2a3-6609ba17737c"), "Velit animi saepe.", "e42d7aa5-ba76-4de2-9a2d-e75c2731d7b4", new DateTime(2019, 7, 7, 9, 43, 35, 957, DateTimeKind.Local).AddTicks(3444), "Storage: eum", new DateTime(2020, 6, 20, 12, 28, 25, 301, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19b98d16-73d8-4094-89ab-1bb1df4f4234"), "Est omnis veritatis fuga iste at nobis facere.", "dcf32708-6e0e-4d97-a119-4e4aa2361f5d", new DateTime(2019, 11, 17, 3, 51, 21, 238, DateTimeKind.Local).AddTicks(3240), "Storage: reprehenderit", new DateTime(2022, 6, 7, 5, 49, 39, 488, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c4b4e15-4659-4e65-bcd3-3f30ca57271f"), "Laboriosam reprehenderit et odit non enim.", "14c9ab8e-1169-4a93-a711-0c71c15212be", new DateTime(2019, 9, 15, 20, 29, 37, 391, DateTimeKind.Local).AddTicks(1660), "Storage: quaerat", new DateTime(2021, 8, 12, 20, 23, 35, 621, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1d4967a1-3360-4fac-a2ad-0083e051e5f4"), "Mollitia neque animi sunt.", "5f5e551f-ada2-4e10-bfd8-f4aabb72ffd4", new DateTime(2020, 6, 26, 23, 4, 55, 548, DateTimeKind.Local).AddTicks(7767), "Storage: et", new DateTime(2021, 8, 22, 14, 26, 36, 386, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1effca2e-5747-419e-b22d-60380b7d3be6"), "Rerum aliquam adipisci amet corrupti asperiores expedita fugit nesciunt.", "da6dfa45-079d-478f-a087-8ed7afa62bb1", new DateTime(2021, 5, 6, 9, 44, 32, 236, DateTimeKind.Local).AddTicks(2533), "Storage: eligendi", new DateTime(2021, 10, 16, 16, 54, 14, 521, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2128c475-d5dc-412f-951a-ceba35bd9c74"), "Voluptas pariatur porro placeat dolores officiis sint accusamus enim ut.", "1bb0f540-91ec-49bf-be1f-10c15ec9b60c", new DateTime(2021, 12, 16, 18, 33, 44, 391, DateTimeKind.Local).AddTicks(9234), "Storage: rerum", new DateTime(2022, 5, 24, 4, 10, 18, 144, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("21aea87f-5437-40b4-b25b-3b46f76c57e4"), "Eaque reiciendis iure autem laborum.", "a5e9c587-842b-452f-9696-f0ff7b6be9f2", new DateTime(2019, 6, 10, 2, 43, 38, 424, DateTimeKind.Local).AddTicks(8799), "Storage: deleniti", new DateTime(2021, 6, 4, 7, 50, 51, 549, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23046da4-225b-4453-8740-dc91851e7fcf"), "Repellat eaque delectus minus ipsum aperiam.", "a81719d1-1737-4356-8cc8-1e2dc5a9ad14", new DateTime(2019, 12, 12, 8, 54, 58, 955, DateTimeKind.Local).AddTicks(4023), "Storage: molestias", new DateTime(2021, 9, 12, 16, 22, 4, 902, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2887e01e-85e1-4e69-abae-028a485f92cb"), "Aut molestiae odio neque reprehenderit.", "323b4c21-4d84-4a31-b666-dde1e8c6678c", new DateTime(2019, 12, 18, 9, 30, 0, 809, DateTimeKind.Local).AddTicks(3809), "Storage: aperiam", new DateTime(2021, 5, 1, 15, 11, 51, 806, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("33978e00-5515-4f22-be6e-3852fee56d6c"), "Laborum suscipit odit ipsam nemo et dolorem iure.", "36012c8f-425d-4866-981e-c6e43400eac4", new DateTime(2019, 10, 29, 12, 2, 0, 76, DateTimeKind.Local).AddTicks(4794), "Storage: deleniti", new DateTime(2022, 4, 8, 13, 50, 31, 288, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3705f266-d4f2-4c1c-9f75-7741ae35dc4a"), "Voluptate sint voluptatem quasi et molestiae porro.", "2d0437af-8e8b-4207-b46d-c2e93912ce61", new DateTime(2022, 1, 9, 8, 46, 23, 193, DateTimeKind.Local).AddTicks(2440), "Storage: hic", new DateTime(2022, 6, 16, 1, 42, 29, 56, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("386ed47a-4092-4b6b-b26b-3dd5b5587415"), "Officiis architecto pariatur.", "124df9bc-3396-451d-bea6-4a70326ea3f0", new DateTime(2020, 3, 14, 19, 5, 45, 836, DateTimeKind.Local).AddTicks(6162), "Storage: nostrum", new DateTime(2020, 8, 12, 19, 27, 34, 333, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3944df22-33e4-40fd-a3d1-f1b40ce30e3e"), "Repudiandae qui qui ab sint laudantium nihil nobis odio.", "013d4fe7-fce0-4ef3-95f2-ab5b933b5b2b", new DateTime(2020, 6, 29, 15, 40, 9, 852, DateTimeKind.Local).AddTicks(3409), "Storage: quo", new DateTime(2022, 2, 28, 17, 15, 36, 889, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a648158-4634-42d5-90b0-c3062461c174"), "Sunt incidunt et beatae ea perspiciatis modi perferendis quia.", "f55fe1ae-c453-482f-9ad4-12e5d8b13566", new DateTime(2021, 7, 7, 22, 31, 41, 542, DateTimeKind.Local).AddTicks(7499), "Storage: esse", new DateTime(2021, 10, 27, 23, 46, 15, 57, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a7f6c69-6f32-4d11-a5e7-a4b281493914"), "Magni perspiciatis dicta quibusdam.", "1e7a4f19-f6c1-45e6-b6a4-3d02ea9ffefb", new DateTime(2022, 3, 30, 7, 25, 28, 658, DateTimeKind.Local).AddTicks(7840), "Storage: neque", new DateTime(2022, 6, 2, 5, 1, 37, 506, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b283e70-ca26-4cba-b655-349d9b5cbbd2"), "Et ut consequatur suscipit nisi iure.", "3e47f8ef-fc30-4924-b3aa-bb816ebbeb6d", new DateTime(2020, 2, 16, 22, 49, 45, 754, DateTimeKind.Local).AddTicks(1273), "Storage: similique", new DateTime(2021, 3, 1, 14, 28, 21, 824, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("417de43c-679e-4aed-bba9-7395b2471399"), "Consequatur est et distinctio ad quis dolores commodi autem.", "0048a6a7-7789-4a8b-9bce-cd0b3722c763", new DateTime(2020, 11, 10, 20, 29, 41, 615, DateTimeKind.Local).AddTicks(9124), "Storage: ut", new DateTime(2021, 11, 23, 1, 40, 36, 427, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47e934e6-d286-463d-843f-d9fa28c98423"), "Doloremque ea voluptatem.", "d075f8e8-70c3-4b66-8ff0-2e6f099c9e7e", new DateTime(2019, 10, 25, 19, 51, 0, 518, DateTimeKind.Local).AddTicks(1799), "Storage: quis", new DateTime(2022, 4, 10, 11, 39, 5, 284, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("488e51b1-fb99-4ae6-a15e-be9021dac5f7"), "Soluta in animi laudantium.", "fafed8a2-6528-417b-b2dc-44326483254d", new DateTime(2020, 6, 13, 10, 11, 22, 618, DateTimeKind.Local).AddTicks(8959), "Storage: earum", new DateTime(2021, 4, 21, 4, 29, 5, 789, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e959280-c06e-4cc8-93d0-28915f7aa093"), "Cumque consequatur ab praesentium corporis quod quis sequi.", "a2c6e812-ccf0-400b-93f1-2d19ba6182b4", new DateTime(2020, 9, 25, 5, 43, 31, 196, DateTimeKind.Local).AddTicks(3708), "Storage: eos", new DateTime(2021, 3, 31, 20, 19, 25, 928, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("521df93d-8b79-4959-b27c-d6ae5c714016"), "Unde dolor repellendus quibusdam explicabo atque.", "c108a63a-f429-42df-950f-a525e6b387d1", new DateTime(2021, 12, 3, 8, 46, 8, 760, DateTimeKind.Local).AddTicks(2116), "Storage: cum", new DateTime(2021, 12, 29, 12, 13, 10, 209, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53ba7a17-c60c-4e29-a879-baa2a3ffe07c"), "Sit adipisci nulla earum.", "ae7f0da2-acc1-44da-bf8f-bdd423389389", new DateTime(2020, 1, 23, 23, 6, 59, 421, DateTimeKind.Local).AddTicks(1365), "Storage: reprehenderit", new DateTime(2021, 7, 13, 19, 57, 30, 71, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("560115e6-1047-472f-a930-7a22205924fa"), "Porro explicabo odio id eos beatae cupiditate iste asperiores.", "ae0251d3-3511-4e11-9fd3-180a2b84e1b2", new DateTime(2022, 1, 4, 20, 1, 43, 497, DateTimeKind.Local).AddTicks(6373), "Storage: vero", new DateTime(2022, 6, 16, 3, 10, 52, 286, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5693a10a-a5b8-4a2b-ba43-8145b122aaa7"), "Aliquid aut voluptatem quia.", "05d726b9-04ad-4237-a44c-44d423525cfc", new DateTime(2020, 5, 14, 23, 37, 33, 349, DateTimeKind.Local).AddTicks(8125), "Storage: beatae", new DateTime(2021, 10, 1, 0, 14, 42, 429, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59d5845a-7c40-4fdc-acd8-7b0cfe01de48"), "Hic quod ea et ut.", "38f33fba-28e4-4011-9820-80d3def234ac", new DateTime(2017, 9, 10, 18, 31, 59, 148, DateTimeKind.Local).AddTicks(1164), "Storage: officiis", new DateTime(2019, 1, 1, 10, 36, 15, 170, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e35ad6f-684b-4508-88a2-88715eae85d4"), "At nisi ex dolor quas et provident amet.", "ced7cecd-fddb-45b3-9f54-2d08089cc1d3", new DateTime(2017, 12, 26, 19, 7, 27, 596, DateTimeKind.Local).AddTicks(27), "Storage: officiis", new DateTime(2021, 5, 20, 4, 22, 17, 524, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5f36347a-3827-4600-bcae-e14732a4bd5e"), "Est id eaque praesentium id.", "0e7be499-3a27-4739-a643-205d69c919a0", new DateTime(2019, 12, 19, 11, 28, 4, 422, DateTimeKind.Local).AddTicks(9313), "Storage: quisquam", new DateTime(2020, 12, 15, 2, 46, 6, 876, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("606eae4c-6d6e-47da-9f37-52a69b83f85c"), "Qui distinctio perspiciatis voluptatem consequatur eos fuga.", "6921aacb-eb5c-47ab-b7f1-3434f6ad107f", new DateTime(2019, 11, 24, 12, 24, 30, 187, DateTimeKind.Local).AddTicks(9697), "Storage: enim", new DateTime(2021, 6, 9, 6, 51, 13, 971, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("624b053f-0a08-4784-8d2e-858f0ea276d9"), "Rerum earum porro non explicabo sit corrupti quasi.", "6dd7d9b0-0234-4118-b37b-abde16facde4", new DateTime(2019, 11, 13, 7, 9, 16, 834, DateTimeKind.Local).AddTicks(7764), "Storage: fuga", new DateTime(2021, 4, 5, 14, 41, 44, 115, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65aeb271-981e-4ab0-8add-7aeb76b3477c"), "Omnis non ad occaecati omnis inventore.", "2634f561-9db1-449d-a410-b6c5589f767d", new DateTime(2020, 6, 18, 20, 6, 38, 699, DateTimeKind.Local).AddTicks(7201), "Storage: aut", new DateTime(2020, 11, 5, 5, 17, 29, 824, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6610a0c3-b7cd-49b5-84a3-14caf6cd744c"), "Ad doloribus quidem veniam dolores quo excepturi qui.", "ba7e4932-d61d-4df7-84a6-d5a178eeb227", new DateTime(2021, 3, 14, 9, 19, 43, 388, DateTimeKind.Local).AddTicks(5694), "Storage: consectetur", new DateTime(2021, 4, 14, 9, 51, 28, 380, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69f277a3-6028-48cf-b68a-c3e8d002e325"), "Dolores est occaecati non.", "1dc148cb-b06b-4be8-9384-852430c7a029", new DateTime(2018, 2, 28, 10, 37, 25, 503, DateTimeKind.Local).AddTicks(8959), "Storage: optio", new DateTime(2019, 4, 25, 21, 45, 29, 893, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6acb8e50-0a1c-4198-b3fa-48f95c3c1154"), "Sunt consectetur vero.", "0e7582e9-58ec-464a-a666-08c7e41031c5", new DateTime(2019, 3, 9, 8, 18, 54, 707, DateTimeKind.Local).AddTicks(9119), "Storage: fugiat", new DateTime(2021, 8, 24, 3, 9, 0, 863, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b9511e6-f29b-4202-aa88-126cf618ec38"), "Incidunt voluptatem facere corporis.", "ab6ed456-e8aa-4d56-94b4-d68480a1f9dd", new DateTime(2018, 1, 4, 19, 27, 13, 656, DateTimeKind.Local).AddTicks(1246), "Storage: qui", new DateTime(2018, 10, 22, 16, 52, 11, 238, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c66681b-9e24-4cd8-b317-9f988fefb912"), "Natus temporibus eveniet reprehenderit cumque ut enim molestiae eos consequuntur.", "d7c370c5-a914-4ef6-8f40-1ec6cf2d39da", new DateTime(2020, 12, 24, 12, 0, 37, 64, DateTimeKind.Local).AddTicks(9719), "Storage: culpa", new DateTime(2021, 5, 21, 11, 46, 8, 950, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e301f9a-8db8-4e0f-a6ae-6747235a0699"), "Qui sunt eos.", "699e943d-54d4-499a-a2df-e4e9876cd27a", new DateTime(2019, 10, 7, 18, 3, 24, 740, DateTimeKind.Local).AddTicks(7271), "Storage: cupiditate", new DateTime(2021, 7, 14, 23, 11, 5, 28, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71cc4a80-6d2e-45f0-9a23-d769a9675b6c"), "Quisquam explicabo quis ipsum aut.", "518bca4b-5784-4b87-9aa0-b3fdd7fe5dc4", new DateTime(2020, 1, 23, 13, 35, 28, 844, DateTimeKind.Local).AddTicks(1750), "Storage: dolores", new DateTime(2020, 6, 23, 13, 2, 10, 550, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74200332-bdd2-4648-a676-8e604fd022ed"), "Et eaque nihil corporis cum.", "268fed37-f020-4e43-8203-415bbab85cc0", new DateTime(2022, 1, 23, 20, 43, 16, 678, DateTimeKind.Local).AddTicks(4300), "Storage: ex", new DateTime(2022, 5, 3, 8, 20, 9, 897, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7542e765-ee04-48ef-a50b-5cd0f0584a8f"), "Provident cupiditate dicta.", "29940dac-bd9f-4615-8609-ad3a73f407db", new DateTime(2018, 1, 22, 19, 40, 48, 675, DateTimeKind.Local).AddTicks(6791), "Storage: esse", new DateTime(2022, 6, 1, 15, 9, 50, 301, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77b41ed8-358d-4403-a6b8-3a46cd6686bd"), "At labore molestias eligendi odit ut exercitationem sint.", "a1439393-05c0-4584-96b7-a2509d4bb7e2", new DateTime(2017, 12, 30, 6, 9, 46, 407, DateTimeKind.Local).AddTicks(366), "Storage: cupiditate", new DateTime(2018, 6, 23, 5, 7, 24, 78, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c86bf05-abe3-4094-95b2-d3a2e8621d07"), "Sunt nisi laborum nisi qui illo ex et.", "bd82ef14-286e-43fb-be95-c51af0959942", new DateTime(2020, 1, 27, 5, 27, 14, 785, DateTimeKind.Local).AddTicks(3191), "Storage: eius", new DateTime(2021, 10, 11, 1, 25, 43, 275, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e326386-00d0-4410-931d-8740ad0a4a55"), "Explicabo dolor necessitatibus.", "b565d2a3-a8fb-4ec2-a66a-914c83510a8a", new DateTime(2021, 8, 10, 0, 53, 45, 112, DateTimeKind.Local).AddTicks(7632), "Storage: perspiciatis", new DateTime(2022, 5, 23, 22, 19, 14, 89, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("83d01660-df8b-4994-9037-b59ec0eba2d5"), "Est sit neque in quia aut est qui autem.", "bc2468ba-3a10-4d95-89aa-48524ea99d4a", new DateTime(2017, 8, 6, 21, 2, 52, 965, DateTimeKind.Local).AddTicks(8816), "Storage: est", new DateTime(2022, 6, 18, 18, 9, 19, 497, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d62adcf-724d-4c6e-949b-5484de603b6d"), "Nulla in corrupti saepe eaque qui est et rerum.", "b036a62d-0eac-46a9-9df6-539a8adf09a3", new DateTime(2020, 6, 6, 0, 26, 54, 410, DateTimeKind.Local).AddTicks(99), "Storage: est", new DateTime(2020, 7, 9, 16, 50, 53, 160, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d721abd-fc10-416f-96b8-9cec1fb3c9de"), "Impedit aut dolores non amet quam laboriosam incidunt.", "468bd4e3-490f-4ce9-8fef-c78f821e4554", new DateTime(2021, 2, 1, 3, 19, 25, 447, DateTimeKind.Local).AddTicks(856), "Storage: velit", new DateTime(2021, 10, 14, 3, 24, 8, 654, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8da97305-008d-4f48-a6d1-01eae4ccc42b"), "Explicabo debitis eligendi voluptatibus.", "d4910c49-1744-4f12-8db3-c4ab057fd71b", new DateTime(2019, 7, 12, 15, 5, 12, 801, DateTimeKind.Local).AddTicks(8592), "Storage: quia", new DateTime(2019, 7, 21, 0, 4, 34, 914, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9066cd3e-ac03-43a2-96df-7e929c81696b"), "Quae quos quo.", "0d981156-5723-45b3-aa52-520673d5c37b", new DateTime(2019, 7, 10, 2, 59, 56, 822, DateTimeKind.Local).AddTicks(964), "Storage: in", new DateTime(2022, 5, 29, 3, 18, 30, 848, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("922567eb-3ea9-445f-beb1-67c5dc6ff4c2"), "Id nam porro fuga voluptas atque minus velit.", "90a420b3-cc3a-4c29-bd2d-f702aa5efe95", new DateTime(2021, 1, 25, 21, 56, 16, 865, DateTimeKind.Local).AddTicks(7239), "Storage: sapiente", new DateTime(2021, 12, 3, 18, 22, 36, 493, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("972d149f-5387-47bd-a7e3-13e740f9be41"), "Et nemo sunt debitis sit ea.", "c23cfe6e-b1e6-4614-a998-0f99609a8ce8", new DateTime(2020, 12, 24, 12, 16, 47, 740, DateTimeKind.Local).AddTicks(4315), "Storage: perferendis", new DateTime(2021, 4, 5, 15, 16, 0, 634, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97cd12e4-3de2-4efd-9d66-2d0682b87853"), "Iure nemo laboriosam iusto quis.", "81369594-1937-40fa-a83f-490da70afbe7", new DateTime(2021, 6, 28, 13, 54, 10, 366, DateTimeKind.Local).AddTicks(8175), "Storage: magnam", new DateTime(2022, 3, 31, 4, 2, 57, 79, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97d9cf75-ca78-440f-ab2a-dff579a0cdef"), "Sed blanditiis et eius eum.", "a1f7e270-1adf-4bc4-a4a7-e9ed22a00a99", new DateTime(2021, 7, 2, 8, 23, 41, 598, DateTimeKind.Local).AddTicks(126), "Storage: et", new DateTime(2022, 7, 4, 17, 41, 5, 514, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99825811-a7f4-4e52-a1dc-fa7d165f5ec9"), "Et autem minus esse maxime optio sit debitis.", "a5cc0084-e139-4760-89fe-096e9a7a5df2", new DateTime(2021, 8, 23, 22, 2, 18, 659, DateTimeKind.Local).AddTicks(7825), "Storage: ex", new DateTime(2022, 6, 9, 1, 21, 3, 542, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e2800f2-e31f-40b0-b262-5fccc10bbf81"), "Debitis ipsa sint repellendus.", "07762efc-73b6-4cee-8ed5-dfc43b544333", new DateTime(2018, 2, 22, 19, 28, 2, 205, DateTimeKind.Local).AddTicks(9239), "Storage: aut", new DateTime(2018, 12, 11, 4, 51, 30, 370, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a0a01b59-693a-4659-ad9f-a659735462af"), "Nulla voluptatem accusamus eveniet.", "b03261d1-ef88-485e-82dc-2cfb0880811a", new DateTime(2021, 8, 22, 22, 0, 24, 979, DateTimeKind.Local).AddTicks(245), "Storage: maiores", new DateTime(2022, 5, 15, 3, 47, 6, 243, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2fd0fef-5fdd-400e-8ac8-71a76e394922"), "Dignissimos deleniti cumque nihil rerum repudiandae.", "952cbe0a-a600-43d5-ae9d-d7ee8218bee0", new DateTime(2021, 9, 15, 1, 24, 39, 102, DateTimeKind.Local).AddTicks(2518), "Storage: eveniet", new DateTime(2021, 12, 3, 12, 18, 54, 771, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a4803776-e715-4fb9-92a2-dc0d1ae5d4d4"), "Minima quia consequatur deserunt eum assumenda ut.", "c98c12b2-ba27-4c79-82a0-7fc368989b5e", new DateTime(2022, 4, 29, 11, 59, 18, 113, DateTimeKind.Local).AddTicks(6525), "Storage: quidem", new DateTime(2022, 6, 8, 13, 47, 31, 773, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a8f827fe-6dfd-4a48-ac3b-5949d406195a"), "Dolor provident sint dolores ipsum sed accusantium dolore.", "3db6c04f-2f2a-4483-aaff-969f87551f80", new DateTime(2017, 7, 13, 16, 21, 2, 525, DateTimeKind.Local).AddTicks(6957), "Storage: voluptatem", new DateTime(2021, 9, 26, 8, 54, 4, 540, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9eea5b1-cf8b-45bb-8bd5-5d06bf86e1b4"), "Cupiditate velit quae amet cumque aspernatur voluptatem sint.", "6d57e281-0abc-4709-90bd-75dbe692122e", new DateTime(2020, 6, 1, 8, 16, 10, 954, DateTimeKind.Local).AddTicks(7242), "Storage: nostrum", new DateTime(2020, 9, 22, 1, 53, 23, 993, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae6e0044-eb6f-4ef9-8dfe-27fe0bde7a15"), "Et natus qui et deserunt id sunt commodi.", "0359d686-1170-4f33-af02-ed53359b624f", new DateTime(2020, 4, 19, 22, 8, 3, 153, DateTimeKind.Local).AddTicks(8820), "Storage: aut", new DateTime(2021, 1, 27, 3, 5, 32, 146, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("af6e8b42-be7d-42bc-9868-92702d02cf50"), "Sed deserunt velit totam similique natus odio ratione porro odio.", "d6e00507-f23f-4f5d-9c4d-fe97ddeb6cfc", new DateTime(2017, 8, 9, 1, 40, 52, 96, DateTimeKind.Local).AddTicks(2918), "Storage: est", new DateTime(2021, 3, 14, 17, 30, 44, 853, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aff5cff0-0ad4-4f95-bcdd-0d989ceca3f7"), "In et sint aut illo.", "0bc9d695-aecf-4c08-8104-f41e67b27e71", new DateTime(2019, 7, 12, 23, 35, 52, 700, DateTimeKind.Local).AddTicks(6140), "Storage: ut", new DateTime(2020, 10, 25, 21, 38, 5, 416, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b0410ad3-7a3a-4fa2-8f1c-b00d4c414649"), "Velit amet ad illum vero quod.", "2bf86497-6f56-438d-befa-c1387f8c0435", new DateTime(2019, 5, 20, 22, 1, 1, 814, DateTimeKind.Local).AddTicks(7448), "Storage: in", new DateTime(2020, 10, 16, 22, 13, 9, 517, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3dc9dfe-33a3-4d2c-b914-16dec2761569"), "Saepe doloremque autem odit rem amet doloribus eius quidem.", "d551c72c-bf2d-4dbc-a712-7382b1ed5d07", new DateTime(2017, 7, 31, 3, 17, 47, 95, DateTimeKind.Local).AddTicks(2776), "Storage: enim", new DateTime(2021, 11, 6, 13, 35, 16, 624, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf57b67c-71ef-4b39-b1e7-6e0cde55be1f"), "Illum qui et esse ipsum mollitia.", "a841fe05-b9ec-4c8e-aff4-de05b3d9411d", new DateTime(2022, 2, 7, 2, 43, 10, 648, DateTimeKind.Local).AddTicks(4255), "Storage: et", new DateTime(2022, 2, 12, 17, 3, 34, 836, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c163a7e1-bd97-4dd2-b008-1eef38339b68"), "Eum doloribus eveniet explicabo sit commodi accusamus officia.", "5ba46850-ff79-4354-85c5-3346144df4b8", new DateTime(2019, 1, 19, 21, 21, 47, 501, DateTimeKind.Local).AddTicks(8693), "Storage: quaerat", new DateTime(2020, 2, 27, 10, 49, 9, 56, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c6e78569-9b93-4843-be1b-1c2db35612df"), "Eum voluptatibus quia.", "97815b6b-02ca-48c0-84c5-583673156b70", new DateTime(2018, 8, 15, 1, 39, 50, 340, DateTimeKind.Local).AddTicks(9711), "Storage: sit", new DateTime(2018, 10, 20, 0, 4, 38, 644, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7e7247e-86ff-4468-b465-9f0305e1edf5"), "Consequatur veniam quasi omnis voluptate rem et.", "e0144137-7201-41a8-b8c5-a2b429086463", new DateTime(2022, 5, 6, 8, 32, 37, 121, DateTimeKind.Local).AddTicks(6337), "Storage: consequuntur", new DateTime(2022, 6, 8, 14, 45, 30, 877, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8f8b833-ccd0-4e21-948c-ad99953c5b02"), "Iste accusantium quibusdam qui placeat dolor.", "b48fb201-613f-4063-b4f5-c96edd548662", new DateTime(2019, 1, 25, 12, 29, 33, 916, DateTimeKind.Local).AddTicks(5197), "Storage: eligendi", new DateTime(2020, 12, 29, 12, 59, 44, 220, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd0f3a02-fee3-45b1-aeb9-52b115a10cee"), "Voluptas commodi deleniti laudantium ipsam et quia.", "1192d9b9-907f-4c11-b236-227c3cebd582", new DateTime(2022, 3, 4, 14, 57, 15, 556, DateTimeKind.Local).AddTicks(3606), "Storage: eaque", new DateTime(2022, 6, 9, 19, 50, 21, 590, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ce97733b-67d1-4f79-9793-e67b1555e61c"), "Voluptatem sunt est est non dolorem velit.", "7004e6e6-a9c0-40ad-8fa4-5b98929d1ebf", new DateTime(2017, 8, 26, 6, 40, 47, 922, DateTimeKind.Local).AddTicks(7276), "Storage: incidunt", new DateTime(2021, 6, 15, 1, 10, 11, 727, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d299f04a-51c6-4235-b015-10f710059c6c"), "Est vel consequatur tempora repudiandae sunt quaerat nesciunt eum earum.", "41e28434-ed43-4bf4-bff7-2d1174c92dd7", new DateTime(2021, 2, 10, 12, 43, 24, 452, DateTimeKind.Local).AddTicks(5801), "Storage: fugiat", new DateTime(2021, 11, 29, 9, 27, 53, 376, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d656aee2-7db2-4bc3-b386-69a5f1c5a339"), "Aut corporis alias.", "6970255c-9159-47e9-8cb0-0613dfbb09c9", new DateTime(2017, 8, 25, 9, 1, 59, 384, DateTimeKind.Local).AddTicks(8206), "Storage: dolores", new DateTime(2021, 12, 17, 19, 33, 24, 693, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d875066a-7cd4-48cd-9b5e-4187da7ad655"), "Dignissimos sit doloribus sit error assumenda possimus enim suscipit.", "ea313f23-aaa6-4bb6-8c0f-6734949c354b", new DateTime(2020, 1, 28, 20, 55, 42, 40, DateTimeKind.Local).AddTicks(6467), "Storage: sunt", new DateTime(2021, 12, 5, 8, 44, 9, 393, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9e0f8c6-d2be-425a-9418-d9c1aed3191e"), "Sunt autem fuga nihil vel eum placeat illo.", "1567bd69-db52-4b41-8264-2a285f109770", new DateTime(2019, 9, 5, 3, 58, 5, 581, DateTimeKind.Local).AddTicks(5971), "Storage: corporis", new DateTime(2020, 2, 22, 6, 38, 37, 133, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db6cb989-e96a-4d0e-b71e-71b9a9a41e85"), "Fuga possimus consectetur numquam dolorem officia commodi saepe.", "f35cd7d3-4eac-4704-873f-81feae02734d", new DateTime(2021, 2, 18, 13, 22, 44, 56, DateTimeKind.Local).AddTicks(4912), "Storage: ut", new DateTime(2021, 7, 4, 21, 2, 30, 764, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dc575181-cf1e-4331-9a36-8a904f444f83"), "Et commodi adipisci.", "83ec2c7f-a18c-4bfa-ae21-e51ea65f4f53", new DateTime(2019, 4, 9, 8, 41, 38, 206, DateTimeKind.Local).AddTicks(5803), "Storage: distinctio", new DateTime(2019, 8, 31, 20, 19, 37, 438, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e061d788-4866-49d1-9d89-e737c6ad8bee"), "Dolores consequatur suscipit aut labore possimus voluptas autem molestiae.", "23b2156f-f1b7-42b9-823b-303e53d42877", new DateTime(2021, 7, 14, 13, 39, 40, 402, DateTimeKind.Local).AddTicks(7951), "Storage: a", new DateTime(2022, 6, 29, 21, 1, 25, 767, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1ac5f75-5b57-4027-86ab-5123fbf7b624"), "Aut qui voluptatem sint quas voluptatem.", "a25895ca-2304-4861-933c-612c042fe366", new DateTime(2018, 11, 30, 16, 34, 23, 107, DateTimeKind.Local).AddTicks(6084), "Storage: ut", new DateTime(2020, 9, 14, 0, 56, 23, 111, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e71b6d77-8e9e-40fd-979d-54a621185331"), "Adipisci ex commodi mollitia cupiditate qui aut quis repudiandae et.", "b3fe287d-33d7-4660-9e42-3622e6582359", new DateTime(2018, 9, 21, 18, 31, 25, 422, DateTimeKind.Local).AddTicks(661), "Storage: aperiam", new DateTime(2019, 8, 30, 13, 20, 37, 705, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e77b44f8-2644-4554-a348-e7263695841d"), "Sapiente omnis accusamus aliquam.", "f3afec5c-5830-46a2-ac3a-729afc5cc28b", new DateTime(2020, 8, 24, 15, 14, 18, 293, DateTimeKind.Local).AddTicks(2480), "Storage: consequatur", new DateTime(2021, 8, 3, 13, 2, 58, 211, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e92c54ba-c813-4958-803f-4462aaa43100"), "Veritatis ut voluptatum ut rerum et sit magnam harum non.", "5f197298-db40-4b0b-82be-25241fcc1f75", new DateTime(2020, 5, 31, 23, 26, 29, 905, DateTimeKind.Local).AddTicks(8749), "Storage: laboriosam", new DateTime(2021, 7, 21, 11, 21, 45, 681, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ea8b2eab-a95d-4ade-8388-16d6b0deab72"), "Officia officiis sit qui nobis aut ea.", "a9cae555-0190-4845-bb78-4308c156d400", new DateTime(2018, 11, 9, 3, 59, 42, 345, DateTimeKind.Local).AddTicks(7494), "Storage: voluptas", new DateTime(2020, 4, 21, 18, 26, 19, 796, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ebd749b9-b670-4eda-a923-8e35ea6eeffe"), "Autem placeat est sed molestiae inventore.", "cee764cc-8471-4981-beaf-5ec3f6fcb0d1", new DateTime(2020, 10, 10, 16, 48, 46, 699, DateTimeKind.Local).AddTicks(5515), "Storage: qui", new DateTime(2021, 3, 19, 12, 13, 2, 280, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed5ec290-56cb-48eb-a69b-cae569c32f69"), "Quasi explicabo maiores.", "6363cd48-a99a-45f8-ae41-1eba479aea7e", new DateTime(2021, 10, 11, 19, 9, 22, 239, DateTimeKind.Local).AddTicks(3580), "Storage: rerum", new DateTime(2022, 1, 1, 12, 3, 30, 859, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee7912db-4b76-48cd-a23a-9ac8e1505e5d"), "Dicta voluptatem consequatur doloremque eum accusamus.", "3f41dbcf-256d-4570-b6bd-733fe25e47b8", new DateTime(2019, 8, 12, 16, 11, 3, 831, DateTimeKind.Local).AddTicks(5013), "Storage: et", new DateTime(2021, 2, 23, 18, 25, 46, 31, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3858b15-38fd-4f10-af92-e34d2dda2caf"), "Eveniet vel corporis.", "a2b0079f-3da3-43f2-8759-8048bf4024d3", new DateTime(2018, 8, 10, 0, 50, 36, 734, DateTimeKind.Local).AddTicks(5974), "Storage: et", new DateTime(2022, 3, 1, 14, 20, 23, 655, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f62df3c6-3d88-4670-825e-0ae3367a9cbe"), "Sint quo est.", "2e114230-b6ad-4d19-9dd6-ab3729ac936f", new DateTime(2018, 9, 26, 11, 30, 13, 441, DateTimeKind.Local).AddTicks(570), "Storage: quaerat", new DateTime(2021, 11, 20, 23, 59, 39, 279, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f83b86bc-4276-4a65-8dcd-077d777ff32e"), "Temporibus temporibus quos qui velit doloremque quaerat.", "d42d9a43-da0f-491d-bad2-f03fd0f1729a", new DateTime(2020, 1, 19, 19, 33, 5, 563, DateTimeKind.Local).AddTicks(4052), "Storage: dicta", new DateTime(2021, 8, 3, 19, 49, 19, 624, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f881b729-b2fc-46a6-aa3f-e0da07ca3fb5"), "Voluptatem amet explicabo voluptatum exercitationem accusamus ut.", "acfa8bb6-623e-4b02-a6b4-2c8596446cd7", new DateTime(2018, 12, 13, 10, 42, 28, 961, DateTimeKind.Local).AddTicks(3829), "Storage: dolorem", new DateTime(2019, 4, 23, 5, 32, 56, 695, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff508f97-89c7-4265-8016-0e591a107a6e"), "Libero ut at laudantium veritatis.", "c425ebdd-18b2-4634-b8d2-cb2b0932f570", new DateTime(2020, 6, 28, 12, 37, 18, 241, DateTimeKind.Local).AddTicks(7107), "Storage: voluptatem", new DateTime(2021, 6, 18, 13, 40, 20, 399, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("037ca27c-4bd4-447f-b492-1ab093b1af77"), "Quos voluptas ea mollitia ut nulla saepe eius aut et.", "3491884c-48bd-4a5b-8b6f-9272fd538c5b", new DateTime(2017, 12, 29, 23, 18, 31, 22, DateTimeKind.Local).AddTicks(4568), "Subdivision: laudantium", new DateTime(2022, 4, 28, 16, 12, 35, 630, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("042b6133-e210-4324-ba48-e00782197a49"), "Consectetur autem et neque rerum rerum fugiat.", "9bf1ab65-f288-48cc-b820-1fc138fe891c", new DateTime(2019, 8, 22, 7, 33, 16, 221, DateTimeKind.Local).AddTicks(1856), "Subdivision: occaecati", new DateTime(2022, 1, 20, 8, 7, 25, 616, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("048236d5-4f29-4d53-a72c-7de189f690ad"), "Ut sapiente molestiae harum dolor voluptate minus.", "8f7241a8-1ebf-4401-bf87-81997e77a9c5", new DateTime(2021, 12, 26, 2, 28, 44, 714, DateTimeKind.Local).AddTicks(943), "Subdivision: quia", new DateTime(2022, 5, 18, 5, 41, 10, 614, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06726afa-6438-4816-a225-ab14e3a008e0"), "Excepturi voluptatem vel quae aut in provident nihil aut.", "bb8758cc-7935-4ecf-b749-9a7f931f40c4", new DateTime(2017, 11, 24, 4, 7, 42, 444, DateTimeKind.Local).AddTicks(4922), "Subdivision: et", new DateTime(2019, 4, 22, 14, 1, 22, 7, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06ac0863-91ce-4c4d-94f5-283d8a6c9f9d"), "Nihil veritatis dolore veritatis deleniti necessitatibus voluptatem veritatis doloribus.", "0f610025-c26e-4f4c-b0d2-c9fb6bf9a6a6", new DateTime(2022, 6, 4, 9, 57, 12, 903, DateTimeKind.Local).AddTicks(7407), "Subdivision: eum", new DateTime(2022, 6, 21, 2, 0, 15, 645, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06c29edd-abba-4002-b12f-c346f87f9ffd"), "Totam nobis et.", "8fa3a823-1832-403e-bc38-af528447239d", new DateTime(2019, 4, 19, 0, 59, 29, 530, DateTimeKind.Local).AddTicks(6403), "Subdivision: qui", new DateTime(2019, 12, 17, 3, 41, 57, 421, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0c3609ff-5410-4541-844c-83bb72a4a2fd"), "Molestiae maiores eum quis excepturi autem.", "51270f1c-a60a-4723-9dc9-cbead5889a9b", new DateTime(2019, 11, 3, 0, 6, 30, 111, DateTimeKind.Local).AddTicks(9400), "Subdivision: tempora", new DateTime(2020, 2, 15, 23, 36, 16, 24, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0d6be5f9-49c6-477c-a589-e7968951ab81"), "Quia velit ratione libero deserunt quidem error recusandae eligendi aut.", "c3c70cbc-1936-4b23-ae8d-8a10d4c31768", new DateTime(2022, 6, 4, 21, 3, 25, 512, DateTimeKind.Local).AddTicks(3289), "Subdivision: sint", new DateTime(2022, 6, 25, 8, 18, 39, 87, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0e17d65a-1cf1-4b31-97bb-6ea5ff2022d4"), "Fuga similique cum animi ea quia velit doloribus sapiente.", "1e53fd25-5614-495f-9039-ee6cc72cfb82", new DateTime(2021, 2, 9, 4, 11, 19, 907, DateTimeKind.Local).AddTicks(5763), "Subdivision: assumenda", new DateTime(2021, 6, 23, 16, 5, 20, 112, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f4aa519-b020-4f0b-9cf4-13d20fb4cfda"), "Voluptatum voluptatem possimus iusto est harum magnam.", "fa05b6fb-1fb0-400e-954b-f95c49b1973b", new DateTime(2021, 3, 30, 21, 52, 49, 932, DateTimeKind.Local).AddTicks(4086), "Subdivision: ducimus", new DateTime(2022, 5, 25, 20, 17, 5, 776, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("100359c2-6fc6-4b26-b6e2-f56650743183"), "Doloribus non laudantium consequuntur.", "7a9df4a8-4d3e-42d2-b715-1b99ad1e3a89", new DateTime(2020, 12, 17, 20, 43, 31, 833, DateTimeKind.Local).AddTicks(1379), "Subdivision: quia", new DateTime(2022, 3, 9, 20, 0, 46, 804, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("108ddce6-7a41-43a6-918a-c62342987826"), "Provident sequi illo qui aut nihil ad.", "7c55e286-c9a4-4dc3-940b-da46b964505b", new DateTime(2018, 11, 20, 7, 23, 52, 172, DateTimeKind.Local).AddTicks(8667), "Subdivision: eveniet", new DateTime(2022, 2, 23, 11, 39, 39, 275, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11c91b58-c85d-41a5-9b85-02daeeccb5e8"), "Commodi eaque commodi enim corporis.", "5089f071-a1ab-4b4f-8595-e3353e2bed6f", new DateTime(2017, 10, 7, 4, 34, 12, 44, DateTimeKind.Local).AddTicks(6701), "Subdivision: natus", new DateTime(2019, 9, 17, 23, 43, 37, 977, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11d4e22b-8c70-4e3a-a40b-78ab7130decc"), "Reiciendis enim aut sed facilis.", "116f59a4-65a2-46e1-b5e7-d2507560477f", new DateTime(2019, 5, 28, 19, 26, 43, 564, DateTimeKind.Local).AddTicks(684), "Subdivision: velit", new DateTime(2021, 11, 9, 4, 3, 10, 373, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("13edec37-2d09-4912-8f0f-29a2f6e34301"), "Consequatur nisi et iusto et dicta beatae quia deleniti autem.", "4558fb2b-4623-4c90-8376-eb5f37dc05f9", new DateTime(2022, 4, 20, 13, 24, 30, 53, DateTimeKind.Local).AddTicks(7703), "Subdivision: nulla", new DateTime(2022, 5, 13, 8, 9, 14, 901, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("14fab70e-e6e2-4426-8f4d-4c4417609b0e"), "Id iusto earum.", "49862487-f9a7-49b3-85bc-66a5f452c7d9", new DateTime(2018, 9, 12, 20, 36, 3, 552, DateTimeKind.Local).AddTicks(9326), "Subdivision: distinctio", new DateTime(2019, 10, 30, 21, 13, 8, 650, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("170da8f6-f25a-499d-9464-f30fbb8e28dc"), "Facere esse sit suscipit vel et ab est.", "a7076b93-9c65-4169-a76f-9181227e7274", new DateTime(2019, 7, 2, 10, 54, 35, 441, DateTimeKind.Local).AddTicks(4233), "Subdivision: sed", new DateTime(2021, 11, 28, 8, 40, 22, 337, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("185b555b-7975-490d-8fc6-f5a7232f2d97"), "Perferendis asperiores delectus recusandae laborum id cum unde corporis non.", "9d559358-1552-458d-8982-34fb46f33c0b", new DateTime(2017, 12, 13, 21, 14, 48, 261, DateTimeKind.Local).AddTicks(6437), "Subdivision: eligendi", new DateTime(2018, 2, 8, 2, 53, 28, 853, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("185d2e21-5888-47ee-ac2f-fa4ec77b08c4"), "Quia perferendis recusandae facere soluta debitis enim facere et.", "780eaef9-7b3e-44f5-8cdc-aa3e5384bd63", new DateTime(2019, 2, 12, 5, 52, 50, 965, DateTimeKind.Local).AddTicks(5645), "Subdivision: repudiandae", new DateTime(2019, 9, 29, 9, 22, 15, 972, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19f3fdd0-564a-4537-82e2-e73d29764064"), "Sit odio explicabo expedita exercitationem.", "68558435-7960-4b70-8670-d911d8d86668", new DateTime(2019, 10, 7, 17, 58, 58, 66, DateTimeKind.Local).AddTicks(3358), "Subdivision: nesciunt", new DateTime(2021, 3, 4, 7, 56, 22, 251, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b3a581c-eff8-4c27-8020-844f3ca8101b"), "Et itaque provident.", "71ab4c87-7082-4ecd-a3c4-25258120d99d", new DateTime(2019, 12, 15, 22, 42, 56, 455, DateTimeKind.Local).AddTicks(8183), "Subdivision: ut", new DateTime(2022, 5, 18, 12, 38, 13, 302, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2633520f-9c9b-4a4a-920e-e7669e956fba"), "Nobis impedit recusandae quo quia.", "6a68da41-e4d6-4470-a7f6-d74599739e13", new DateTime(2018, 12, 13, 1, 58, 49, 45, DateTimeKind.Local).AddTicks(1594), "Subdivision: corporis", new DateTime(2019, 11, 28, 13, 42, 22, 425, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2822509e-926f-4a2d-af85-b7b85768d37b"), "Et esse vel neque aut et et delectus.", "4fe0a73a-05b5-4eb9-8942-1027b350852e", new DateTime(2022, 3, 22, 4, 53, 57, 346, DateTimeKind.Local).AddTicks(8434), "Subdivision: reiciendis", new DateTime(2022, 6, 18, 4, 22, 14, 194, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a2c225c-5207-423b-9305-990c25c4d177"), "Laudantium aut tempore qui odio vel dolorem pariatur officia.", "98be309e-da1c-43a7-8dc9-ad702d9ec340", new DateTime(2022, 4, 7, 2, 23, 44, 385, DateTimeKind.Local).AddTicks(1122), "Subdivision: praesentium", new DateTime(2022, 7, 2, 2, 24, 7, 120, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a55d9af-a325-45d2-815c-c7f4f7d3730f"), "Qui optio id dicta fuga commodi id nisi asperiores.", "360aa8fd-75df-4e04-b2d8-f9155ea7ed95", new DateTime(2022, 5, 14, 0, 23, 36, 333, DateTimeKind.Local).AddTicks(4314), "Subdivision: non", new DateTime(2022, 6, 10, 14, 59, 39, 894, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3fed6755-0804-4916-94fb-15921c5eab66"), "Qui quis ducimus molestiae nulla architecto.", "b6ddecf4-9830-4d79-9db0-c1a7bdb4a9f6", new DateTime(2022, 5, 7, 9, 20, 32, 416, DateTimeKind.Local).AddTicks(7429), "Subdivision: quam", new DateTime(2022, 5, 9, 20, 49, 49, 273, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4586cb2a-c453-41a3-b1bb-55decc95ee44"), "Cum minus eum aut.", "f5989f30-c34d-4123-9248-3cf677e673de", new DateTime(2020, 5, 13, 9, 18, 3, 655, DateTimeKind.Local).AddTicks(3909), "Subdivision: quo", new DateTime(2020, 5, 27, 8, 34, 12, 195, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("461dff56-71f4-495f-bafe-2190476a1f35"), "Enim assumenda dignissimos.", "0376d209-4e98-489c-b223-8a8920accaba", new DateTime(2019, 6, 23, 8, 43, 9, 101, DateTimeKind.Local).AddTicks(6370), "Subdivision: sapiente", new DateTime(2019, 10, 29, 20, 4, 10, 166, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("48f44842-f849-4028-b5b5-adb7726699b9"), "Ut molestias beatae voluptas quisquam.", "5c3858b9-da79-4af0-9a2c-a8e27436291c", new DateTime(2021, 8, 23, 0, 32, 58, 137, DateTimeKind.Local).AddTicks(6679), "Subdivision: suscipit", new DateTime(2021, 9, 10, 22, 14, 54, 539, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("51ee00d7-b20f-43da-a314-81a23cfec043"), "In illo autem nulla et aspernatur.", "274e45ff-a021-4d90-af82-7624fbd9bd8c", new DateTime(2020, 11, 7, 19, 47, 7, 847, DateTimeKind.Local).AddTicks(212), "Subdivision: et", new DateTime(2021, 8, 29, 12, 11, 35, 21, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53951201-67f5-4225-aba1-00f32f709985"), "Quia et esse officiis dicta.", "1443f293-7ddd-412a-8483-a8009a549e94", new DateTime(2019, 9, 23, 16, 12, 48, 856, DateTimeKind.Local).AddTicks(1710), "Subdivision: sunt", new DateTime(2020, 10, 26, 14, 39, 17, 916, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("541c8a94-9790-4174-8bec-04d6bd696884"), "Aut eveniet quam et.", "2734bdbb-3408-4f5d-8543-db480141df22", new DateTime(2021, 12, 28, 0, 23, 33, 503, DateTimeKind.Local).AddTicks(8773), "Subdivision: voluptatem", new DateTime(2022, 3, 23, 7, 23, 35, 169, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("556a0a23-487e-4423-aaec-bd99abd77db5"), "Sed suscipit et necessitatibus.", "93033dcd-bf3d-4a29-8f79-95595926e1cc", new DateTime(2021, 4, 6, 23, 16, 1, 514, DateTimeKind.Local).AddTicks(9271), "Subdivision: sint", new DateTime(2021, 7, 4, 18, 51, 8, 865, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5939dfa2-0f61-4f76-bc5f-8c1b6c67f9c6"), "Et minus perferendis velit repellendus assumenda voluptatem.", "2658a219-9003-496b-94e5-e7ed54da6319", new DateTime(2018, 9, 21, 17, 55, 7, 6, DateTimeKind.Local).AddTicks(6956), "Subdivision: qui", new DateTime(2020, 9, 5, 7, 1, 47, 85, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b0da285-4bec-4ddc-9619-eb3be729fa8e"), "Sit quisquam possimus placeat qui.", "bdae8984-839f-41e6-bae2-e3298302dc92", new DateTime(2021, 11, 2, 0, 11, 48, 33, DateTimeKind.Local).AddTicks(5071), "Subdivision: odio", new DateTime(2021, 12, 31, 8, 31, 20, 683, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d4162fa-378e-41ad-8aea-952821c0a7f6"), "Blanditiis est ducimus pariatur alias a nam omnis a.", "205f20f0-53ef-4c0f-a278-044e9a311799", new DateTime(2020, 11, 14, 4, 32, 18, 255, DateTimeKind.Local).AddTicks(5651), "Subdivision: commodi", new DateTime(2021, 1, 12, 2, 46, 10, 35, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d9ebf6b-e0d1-45e7-aa78-b8d54fbe1403"), "Quis sed sit.", "c4c22245-922b-4ca1-93b7-daf3b2b20154", new DateTime(2021, 2, 2, 13, 30, 53, 313, DateTimeKind.Local).AddTicks(6920), "Subdivision: et", new DateTime(2022, 3, 3, 14, 19, 13, 652, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ec59d94-9bdd-4933-b3f1-38a5450d7e77"), "Commodi accusamus voluptates accusantium praesentium amet voluptate.", "3a06bc2f-fea2-4d89-946c-f94cf1582ce6", new DateTime(2021, 2, 22, 6, 30, 27, 349, DateTimeKind.Local).AddTicks(9941), "Subdivision: aliquam", new DateTime(2021, 12, 21, 18, 17, 42, 286, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("643c1340-e86b-4005-9dcc-69bed0e4961b"), "Vitae quo voluptas laboriosam.", "1df1328a-d60f-406d-8363-37e22fd41169", new DateTime(2018, 10, 24, 8, 34, 51, 154, DateTimeKind.Local).AddTicks(8367), "Subdivision: inventore", new DateTime(2022, 6, 5, 20, 43, 16, 178, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("66a584b7-12a0-48e2-b311-4165231e8e1c"), "Qui nesciunt et magnam hic laborum.", "7179158b-b0a3-4346-b075-6de76b8568a5", new DateTime(2019, 10, 26, 21, 31, 28, 336, DateTimeKind.Local).AddTicks(5092), "Subdivision: animi", new DateTime(2022, 3, 16, 13, 40, 57, 638, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6778a277-6e77-4ee6-88e4-85e4c29b1d33"), "Minus enim et sit rerum nesciunt omnis.", "6b3f4703-99e8-4b71-9669-4dfdfc2afb3a", new DateTime(2018, 3, 1, 0, 27, 28, 988, DateTimeKind.Local).AddTicks(1717), "Subdivision: iste", new DateTime(2018, 12, 16, 19, 46, 3, 979, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69a6ce6e-87a6-488b-864f-a402f995d342"), "Alias odit corporis.", "2fdbe3af-f16e-414a-95fa-2646e503e913", new DateTime(2019, 4, 26, 14, 41, 46, 232, DateTimeKind.Local).AddTicks(4480), "Subdivision: et", new DateTime(2022, 4, 8, 16, 31, 33, 113, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("717af02e-db63-47a7-8172-d2cc397b54b8"), "Fuga earum natus occaecati numquam omnis.", "2b6b74ac-3bc0-4805-ac55-26bb8d41464f", new DateTime(2020, 5, 6, 23, 4, 29, 901, DateTimeKind.Local).AddTicks(4229), "Subdivision: natus", new DateTime(2021, 12, 19, 3, 3, 17, 708, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("742f49c3-9ed6-4da6-aa21-250ccb69e14e"), "Veniam rerum eum neque omnis minima ut similique.", "070e3645-1dc0-4aff-89b4-297ce22e0938", new DateTime(2018, 1, 3, 1, 58, 45, 269, DateTimeKind.Local).AddTicks(2879), "Subdivision: ullam", new DateTime(2020, 9, 20, 20, 16, 23, 84, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74bbf5ce-5f32-4a63-aa8e-eb0a5b6f3443"), "Placeat asperiores reprehenderit et.", "4c3b35b2-ce51-459c-80e0-81cb50ea4206", new DateTime(2021, 12, 22, 5, 21, 7, 272, DateTimeKind.Local).AddTicks(5645), "Subdivision: sed", new DateTime(2022, 2, 13, 9, 56, 23, 257, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74cd4959-f362-4d1d-9981-c9bd7040ee90"), "Et quod aut laborum esse et laudantium et ipsam.", "2f3f93d4-c264-48a4-aa7e-000cd0ef23cb", new DateTime(2020, 3, 26, 17, 2, 25, 957, DateTimeKind.Local).AddTicks(2648), "Subdivision: nesciunt", new DateTime(2021, 12, 27, 9, 25, 48, 45, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74d87e64-475f-4bb5-a052-c70bdfadb5a5"), "Cum nam a maiores numquam sed consequuntur quisquam.", "8f928c9c-b8e8-450e-9c05-cf190fc3455e", new DateTime(2018, 2, 10, 19, 46, 24, 607, DateTimeKind.Local).AddTicks(2314), "Subdivision: sit", new DateTime(2020, 4, 5, 6, 33, 36, 859, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7a0cd1ca-c4ba-4d38-bb45-15c1a90a88d8"), "Rerum illum consequatur earum est sint quod voluptas.", "c78097e6-e3cf-424d-8c9b-684c3db2c47a", new DateTime(2018, 12, 30, 10, 49, 46, 487, DateTimeKind.Local).AddTicks(9321), "Subdivision: ea", new DateTime(2021, 3, 9, 9, 20, 18, 756, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b1a3755-b734-4c71-aebe-0e11597c1211"), "Error ex quisquam est.", "d0237529-06d1-4e3e-a845-bc112c620601", new DateTime(2021, 3, 11, 10, 55, 6, 665, DateTimeKind.Local).AddTicks(6583), "Subdivision: perferendis", new DateTime(2021, 10, 11, 21, 23, 54, 503, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7dfdbbb8-db7b-49f3-b6ef-4241325e7cfa"), "Nostrum assumenda sit autem iure iure qui.", "870b65c9-a8c3-40cc-9af7-3c69acaaaa3a", new DateTime(2020, 6, 30, 9, 29, 42, 883, DateTimeKind.Local).AddTicks(5161), "Subdivision: sed", new DateTime(2021, 6, 2, 3, 42, 50, 391, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7eb769f5-0c51-48e5-811b-3260de29e937"), "Non praesentium ut quia odit quis voluptatem exercitationem commodi non.", "6ea10143-f092-4e5d-892e-0915ebf92639", new DateTime(2021, 11, 22, 17, 25, 38, 630, DateTimeKind.Local).AddTicks(7573), "Subdivision: quis", new DateTime(2022, 3, 24, 18, 50, 45, 896, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7f2f40f9-a84d-4190-ac00-ec34c7fdbc9f"), "Rerum quasi error non esse ratione sapiente.", "b61d2a3f-a616-43e2-96ac-850dead87945", new DateTime(2021, 8, 7, 10, 4, 7, 498, DateTimeKind.Local).AddTicks(1235), "Subdivision: sit", new DateTime(2022, 6, 10, 19, 43, 43, 874, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a78c89f-50cf-46a9-a1ad-b9458793c3ff"), "Et sit sit eaque aliquid.", "29cd6dc8-9ef0-494d-b702-f1c1ceed116b", new DateTime(2019, 8, 14, 21, 49, 2, 402, DateTimeKind.Local).AddTicks(4532), "Subdivision: sequi", new DateTime(2021, 8, 23, 5, 52, 24, 564, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c627904-f568-4b50-bd70-890caeb9a051"), "Est provident illum rem impedit natus.", "eff6a6e4-8b34-4d14-811f-29b658778dd0", new DateTime(2021, 9, 11, 8, 51, 7, 19, DateTimeKind.Local).AddTicks(7049), "Subdivision: et", new DateTime(2021, 11, 17, 18, 54, 35, 97, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e6ac364-5d2b-45cf-8832-ae05499dc41c"), "Modi ut voluptate id.", "da6f8839-a5ad-411e-8467-d9def6617b1f", new DateTime(2019, 11, 29, 20, 59, 38, 298, DateTimeKind.Local).AddTicks(7292), "Subdivision: tempore", new DateTime(2022, 3, 7, 4, 23, 9, 418, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("902c67b5-4f65-498d-b769-da42d1975268"), "Qui consequuntur quas.", "33cdddad-eea4-4e41-8c01-e4006115c90a", new DateTime(2020, 10, 24, 23, 29, 43, 59, DateTimeKind.Local).AddTicks(1029), "Subdivision: ipsum", new DateTime(2020, 10, 26, 18, 54, 21, 333, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9265be65-f545-4579-b03f-364fd431dcfa"), "Ut nulla enim.", "3a122023-9325-402c-b5ad-e0ae0a711f6b", new DateTime(2022, 6, 10, 0, 12, 7, 681, DateTimeKind.Local).AddTicks(8873), "Subdivision: inventore", new DateTime(2022, 6, 16, 21, 49, 59, 752, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92bb10d6-6bec-4c88-ae24-91a726bcf481"), "Cupiditate necessitatibus animi nobis ducimus.", "ca521ddc-05a0-4b4f-bdd6-a65d1a7a0626", new DateTime(2019, 11, 9, 21, 0, 57, 995, DateTimeKind.Local).AddTicks(2459), "Subdivision: praesentium", new DateTime(2020, 12, 2, 6, 44, 53, 54, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92ef09ef-c6d3-42a6-98c2-a44c70c11533"), "Ab molestias amet.", "4ac7e518-63f9-4244-a3eb-62884fbff7cc", new DateTime(2020, 12, 27, 16, 39, 33, 463, DateTimeKind.Local).AddTicks(8678), "Subdivision: ut", new DateTime(2021, 6, 14, 4, 24, 21, 26, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97554570-4eeb-4426-9c48-d207b59120fb"), "Veritatis autem maxime est.", "65bef927-304e-4f0e-8adb-625f0a2bc548", new DateTime(2018, 11, 22, 10, 13, 5, 836, DateTimeKind.Local).AddTicks(8148), "Subdivision: rerum", new DateTime(2020, 7, 28, 19, 25, 53, 335, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99842657-a136-4da2-8802-83afefa4f950"), "In porro sed dicta aut modi quia atque aut.", "f0c096dd-bf66-4c9b-96be-d2c6da28fd6e", new DateTime(2021, 4, 18, 21, 12, 56, 684, DateTimeKind.Local).AddTicks(105), "Subdivision: animi", new DateTime(2021, 9, 7, 1, 10, 2, 624, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9ec3e2da-e62b-4835-abf3-27c7e77595bb"), "Voluptas sed autem.", "eb8f38af-0c2f-4712-9da0-d90a3ee6a9fc", new DateTime(2018, 9, 11, 4, 48, 44, 813, DateTimeKind.Local).AddTicks(8402), "Subdivision: dignissimos", new DateTime(2020, 7, 11, 10, 0, 48, 634, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9fb82d36-33c8-492d-95fb-059dd6c49863"), "Facilis asperiores magnam ratione qui quidem.", "a62f1539-fa8f-438e-8903-87c77b5c7af6", new DateTime(2020, 12, 30, 0, 55, 16, 405, DateTimeKind.Local).AddTicks(8468), "Subdivision: illo", new DateTime(2022, 6, 24, 14, 31, 40, 63, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a12a13ed-4f96-4243-85d9-926930073957"), "Dolorum suscipit sequi sed eos quidem molestias qui eius.", "e07f6529-d8c5-408b-9147-0ad4b3efab4c", new DateTime(2018, 11, 17, 0, 52, 12, 295, DateTimeKind.Local).AddTicks(4579), "Subdivision: officia", new DateTime(2020, 1, 2, 18, 40, 11, 31, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a72a017e-39c3-4a07-9d5a-0e0d9117570c"), "Ratione eum sed recusandae amet hic.", "7ae6798e-d0f2-4839-9f38-16e0f6cdbc87", new DateTime(2022, 5, 14, 6, 42, 19, 573, DateTimeKind.Local).AddTicks(2394), "Subdivision: temporibus", new DateTime(2022, 7, 4, 19, 15, 47, 908, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("abd6f85f-33c3-4188-86c0-8a28c6326665"), "Dolorem ut non corrupti neque.", "4899fe5b-2a60-4071-98b4-fe590abdb475", new DateTime(2019, 10, 11, 14, 27, 53, 397, DateTimeKind.Local).AddTicks(9242), "Subdivision: qui", new DateTime(2022, 4, 18, 5, 27, 9, 811, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae3cab7f-656f-4fcb-92a9-4d5acc8d876b"), "Eius id autem assumenda ducimus eligendi dolores dolores dolorem velit.", "d1f4f966-e8c2-45fc-8e34-100cfa6377f1", new DateTime(2021, 10, 17, 11, 21, 57, 63, DateTimeKind.Local).AddTicks(6426), "Subdivision: consequatur", new DateTime(2022, 6, 9, 22, 7, 23, 274, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aeb5724b-c707-4f43-b160-b94f117f0138"), "Beatae sed qui modi excepturi maiores dolores ratione dicta.", "30bb2d71-38c4-41ad-aae5-7a8687bc7c5f", new DateTime(2022, 4, 27, 5, 48, 13, 741, DateTimeKind.Local).AddTicks(2889), "Subdivision: sit", new DateTime(2022, 6, 22, 14, 33, 18, 782, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b0ee43e3-4bf0-4663-9be6-fae7c47dcb39"), "Consequatur non quia nesciunt et esse.", "5d5af75c-96ea-4525-8457-eae379e07c73", new DateTime(2021, 4, 10, 7, 39, 22, 242, DateTimeKind.Local).AddTicks(6182), "Subdivision: non", new DateTime(2022, 5, 29, 23, 40, 2, 250, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b41014cd-35c4-4ee3-a6f9-bf168ff09c07"), "Magnam fuga corporis consequatur dolores dolorem cupiditate vel doloribus et.", "0523b387-736a-4646-994a-39498eb94745", new DateTime(2021, 7, 21, 13, 40, 5, 293, DateTimeKind.Local).AddTicks(7126), "Subdivision: in", new DateTime(2022, 4, 16, 3, 57, 10, 950, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8d1f4a9-90c9-477b-ba5e-b578bbf4e2f6"), "Ducimus dolorem perferendis unde qui.", "ab4f6469-ffb5-4eb5-97b1-853222a0fb1b", new DateTime(2021, 9, 30, 8, 26, 33, 603, DateTimeKind.Local).AddTicks(1529), "Subdivision: quisquam", new DateTime(2022, 1, 24, 14, 33, 37, 915, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bba87caa-a1d6-44a7-990f-974f0e451732"), "Quos accusantium labore voluptatum nihil.", "dd04bc40-33c0-4d94-b370-35e00778c705", new DateTime(2018, 1, 18, 3, 22, 56, 438, DateTimeKind.Local).AddTicks(9752), "Subdivision: et", new DateTime(2019, 10, 15, 0, 5, 35, 244, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bba9abf8-1377-45c5-82ce-dfaee61f4753"), "Dolores rerum voluptatem.", "33cc8208-642f-4338-9260-98ba28bd9a0b", new DateTime(2022, 3, 15, 5, 1, 22, 555, DateTimeKind.Local).AddTicks(7328), "Subdivision: cum", new DateTime(2022, 5, 27, 11, 3, 32, 387, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd59686b-9be4-45f0-80e2-8a609e89b68a"), "Perferendis a quibusdam aperiam provident deleniti iure consequuntur ex sequi.", "392d394c-c7ef-411a-afb8-01fcdfede58d", new DateTime(2020, 8, 25, 19, 19, 49, 980, DateTimeKind.Local).AddTicks(5307), "Subdivision: repudiandae", new DateTime(2021, 9, 28, 4, 22, 25, 630, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd8165f8-c9ba-4831-b0b4-b36b6911c25d"), "Ea non perspiciatis non dolores dolores.", "56cdceba-7107-41ef-baf4-28642cb37689", new DateTime(2020, 4, 12, 12, 22, 11, 431, DateTimeKind.Local).AddTicks(564), "Subdivision: vel", new DateTime(2020, 12, 29, 20, 30, 10, 537, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0b699db-1c20-4967-8dd8-c0c59bb257bf"), "Natus porro et quos odio aperiam et libero.", "55bcbcd5-cf95-47c6-ab8a-ae7b72d68f8c", new DateTime(2019, 2, 18, 6, 1, 47, 505, DateTimeKind.Local).AddTicks(8076), "Subdivision: id", new DateTime(2022, 3, 26, 18, 48, 5, 417, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c55af23d-ed30-4e83-b2e2-00d6bfdbafc5"), "Quis velit tempora velit ea.", "51d90b86-c78d-4f7d-9d31-0099fe022c8c", new DateTime(2020, 6, 2, 16, 48, 54, 664, DateTimeKind.Local).AddTicks(1784), "Subdivision: voluptates", new DateTime(2020, 11, 29, 17, 0, 28, 909, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c5cddd9c-918c-4e68-b980-20130284a714"), "Eum et labore labore enim porro.", "1a8a275e-6ab6-4b41-9f4b-c5782b974641", new DateTime(2022, 1, 1, 12, 53, 42, 520, DateTimeKind.Local).AddTicks(9031), "Subdivision: aut", new DateTime(2022, 5, 4, 4, 51, 29, 86, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c75dd139-4de1-44cf-807d-c3838ea80b3d"), "Quia soluta tempore dolores ipsa autem delectus repellat dignissimos consequatur.", "85d14693-8440-42e6-9de4-8f085208ff43", new DateTime(2021, 10, 18, 16, 35, 34, 61, DateTimeKind.Local).AddTicks(6324), "Subdivision: hic", new DateTime(2021, 12, 23, 6, 44, 40, 171, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ce1432d3-ac60-4433-b3d7-0355fbc766dd"), "Enim rerum amet.", "8ff5d33f-3081-4074-8ede-fd126ae4f687", new DateTime(2017, 7, 27, 4, 44, 30, 203, DateTimeKind.Local).AddTicks(8991), "Subdivision: nemo", new DateTime(2019, 6, 5, 11, 53, 24, 282, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf2c87cd-1b5c-4b59-8ad4-d1b5c73d2b63"), "Illo impedit dolorem maiores perferendis alias.", "592692cc-8bd1-4ab8-8cbd-24168430d115", new DateTime(2019, 8, 20, 23, 17, 37, 810, DateTimeKind.Local).AddTicks(5116), "Subdivision: error", new DateTime(2020, 10, 18, 6, 23, 42, 825, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1357ae8-a78b-496d-a924-cccf4c5e9418"), "Eum atque error corporis quaerat nihil amet facere qui sit.", "edf04f0e-e433-4949-95db-b1054a757801", new DateTime(2019, 10, 2, 14, 0, 13, 805, DateTimeKind.Local).AddTicks(8814), "Subdivision: magnam", new DateTime(2022, 6, 7, 6, 42, 5, 317, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d35f7f8f-9437-48f4-8d72-e3240eba4972"), "Nemo consequatur illum molestiae qui inventore dolorem perspiciatis et sint.", "ab5bc0c3-e4f3-4db5-867f-eb8bb3855751", new DateTime(2018, 4, 25, 14, 28, 0, 556, DateTimeKind.Local).AddTicks(2447), "Subdivision: porro", new DateTime(2020, 4, 19, 0, 19, 58, 997, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d3f55763-f19f-45fb-b0ff-138439c0c111"), "Aut fuga dolore et doloribus beatae corporis iste delectus magni.", "8d6ba228-6289-4c27-a2d1-f50d3dc5f222", new DateTime(2019, 5, 14, 5, 1, 42, 237, DateTimeKind.Local).AddTicks(3315), "Subdivision: perferendis", new DateTime(2020, 5, 19, 12, 1, 7, 432, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d486a84d-45f8-4d87-ab61-d2e30dceb84d"), "Vero et repudiandae.", "90af1964-7bf8-4303-8ad3-dbdb991558e9", new DateTime(2018, 11, 3, 20, 36, 4, 282, DateTimeKind.Local).AddTicks(8525), "Subdivision: pariatur", new DateTime(2020, 3, 19, 10, 39, 4, 587, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7545c5e-a437-4c7f-9e3b-1dc840847f83"), "Facere architecto est debitis est.", "22b09c18-fa0b-4917-8579-11036cd7b1c7", new DateTime(2020, 7, 20, 2, 20, 41, 902, DateTimeKind.Local).AddTicks(4801), "Subdivision: voluptatem", new DateTime(2022, 3, 26, 6, 1, 10, 619, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d82887fa-3701-403c-abc4-40ab8f4f4ef4"), "Voluptas amet dolor totam vero ipsa non.", "efe7d5bc-8d57-4384-ba48-5542308fbc92", new DateTime(2022, 1, 28, 21, 47, 12, 259, DateTimeKind.Local).AddTicks(2701), "Subdivision: delectus", new DateTime(2022, 2, 3, 3, 52, 54, 336, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da0c97dd-47f9-4eda-b013-43a8237f393e"), "Veritatis rerum inventore a et veniam laboriosam placeat maiores non.", "1f0fa4ed-495f-4348-8b3e-d7a3420bc8c3", new DateTime(2021, 7, 20, 6, 28, 33, 892, DateTimeKind.Local).AddTicks(2922), "Subdivision: quia", new DateTime(2021, 8, 4, 9, 4, 56, 408, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dc85a9b1-0ecc-4647-8dc6-953b39881dde"), "Inventore tempora doloribus nemo qui perspiciatis maiores ea id.", "8c061e49-5ae1-41cc-9cf2-bd5a0bb728f3", new DateTime(2017, 9, 30, 17, 54, 0, 638, DateTimeKind.Local).AddTicks(6998), "Subdivision: quae", new DateTime(2020, 2, 9, 14, 10, 33, 383, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8dd4ed4-2ed7-40e3-b741-947e432c5d34"), "Rerum maxime minus fuga.", "986953a8-33b8-4d6f-935c-bf8ad2991a63", new DateTime(2018, 9, 19, 10, 25, 39, 433, DateTimeKind.Local).AddTicks(6157), "Subdivision: vel", new DateTime(2020, 8, 2, 23, 55, 29, 235, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed00b652-2202-41c0-93b1-7d6f1907c21f"), "Omnis et dolorem quia ut neque ut iure tenetur.", "d5f047c7-2e04-412b-ba0a-b2cb38bfa83f", new DateTime(2018, 8, 27, 17, 39, 41, 858, DateTimeKind.Local).AddTicks(581), "Subdivision: soluta", new DateTime(2020, 3, 28, 6, 52, 19, 154, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f5935fea-7c28-47de-be77-fc7333e8f7a7"), "Ratione incidunt qui quasi quidem.", "502e16f2-f475-4999-b2ee-fb6bc64dd4f3", new DateTime(2021, 11, 4, 7, 53, 57, 427, DateTimeKind.Local).AddTicks(9504), "Subdivision: at", new DateTime(2022, 4, 29, 7, 43, 12, 516, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f60fc0a3-81fe-4c8a-94a9-bfa5f0864820"), "Dolorem consequatur corporis quo repellendus aliquid error rerum voluptatem.", "e73b001e-6a97-450e-abbb-0d46e20bc154", new DateTime(2017, 8, 13, 15, 43, 24, 84, DateTimeKind.Local).AddTicks(5312), "Subdivision: id", new DateTime(2021, 5, 8, 4, 22, 58, 354, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6676a50-22fc-4426-995d-139bbfbf16e8"), "Adipisci illo est labore odit.", "0885e967-e32c-43aa-bea3-b3597a028a7f", new DateTime(2021, 6, 5, 14, 59, 19, 537, DateTimeKind.Local).AddTicks(4537), "Subdivision: voluptas", new DateTime(2021, 9, 7, 17, 30, 1, 171, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7260fe7-4059-4afe-98be-ef6001a65b17"), "Ut quis et quo facilis voluptatem nam atque.", "f640e000-7948-499e-bf92-a87e55b3dfd6", new DateTime(2018, 12, 12, 8, 5, 21, 656, DateTimeKind.Local).AddTicks(7406), "Subdivision: nam", new DateTime(2022, 2, 1, 1, 56, 51, 761, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f8df7ef1-fa2b-48ab-a04c-fd35155b4b8a"), "Aut saepe voluptatem.", "5dd0afc5-1b07-4d54-bea6-6da41b835798", new DateTime(2019, 12, 25, 20, 22, 1, 272, DateTimeKind.Local).AddTicks(9399), "Subdivision: quia", new DateTime(2021, 7, 31, 6, 47, 10, 64, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f96e3786-e0cc-4c39-8262-e4a0ab109d34"), "Saepe omnis deserunt vel laudantium ut facere et rerum.", "261cbca8-675e-4348-b347-db25955e7f14", new DateTime(2018, 12, 9, 2, 28, 46, 958, DateTimeKind.Local).AddTicks(1658), "Subdivision: sapiente", new DateTime(2021, 9, 11, 21, 12, 10, 912, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa263b40-7971-4f4b-98a2-f09fba48245b"), "Nihil amet alias in.", "4adde06b-3928-48f1-91ae-300b693d456d", new DateTime(2018, 4, 15, 7, 5, 33, 465, DateTimeKind.Local).AddTicks(7727), "Subdivision: nihil", new DateTime(2021, 8, 22, 17, 23, 5, 552, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("faf43225-303c-49f2-887a-96c9af9998bb"), "Asperiores esse quo est voluptas sit voluptas sint.", "5d3fee8c-b860-492d-9eda-120d6bced9b2", new DateTime(2018, 12, 24, 8, 22, 52, 41, DateTimeKind.Local).AddTicks(7163), "Subdivision: eum", new DateTime(2019, 10, 6, 17, 9, 46, 80, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ffc8e6e5-6164-4e46-b1e0-f55c4347f75a"), "Minima voluptatum ut.", "c9f95988-37e7-493e-812c-63556083abac", new DateTime(2018, 12, 25, 0, 41, 29, 441, DateTimeKind.Local).AddTicks(6904), "Subdivision: nobis", new DateTime(2020, 9, 25, 11, 34, 22, 728, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContactInformation<Guid>_ClientContactInformationTypeId",
                table: "ClientContactInformation<Guid>",
                column: "ClientContactInformationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContactInformation<Guid>_ClientId",
                table: "ClientContactInformation<Guid>",
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
                name: "IX_Documents_DocumentStatusId",
                table: "Documents",
                column: "DocumentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");

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
                name: "IX_Payments_DocumentTypeId",
                table: "Payments",
                column: "DocumentTypeId");

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
                name: "IX_Product<Guid>ProductCharacteristic<Guid>_ProductsId",
                table: "Product<Guid>ProductCharacteristic<Guid>",
                column: "ProductsId");

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
                name: "ClientContactInformation<Guid>");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Mesages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Product<Guid>ProductCharacteristic<Guid>");

            migrationBuilder.DropTable(
                name: "ProductQuantity<Guid>");

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
                name: "DocumentStatus<Guid>");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "ClientContracts");

            migrationBuilder.DropTable(
                name: "DocumentType<Guid>");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "PriceType<Guid>");

            migrationBuilder.DropTable(
                name: "Subdivisions");

            migrationBuilder.DropTable(
                name: "ProductCharacteristics");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Currencyes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ItmeQualityes");

            migrationBuilder.DropTable(
                name: "ProductSeries");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "ProductUnitMeasuraments");
        }
    }
}
