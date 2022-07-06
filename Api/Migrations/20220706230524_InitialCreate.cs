﻿using System;
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
                name: "ClientContactInformationType<Guid>",
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
                    table.PrimaryKey("PK_ClientContactInformationType<Guid>", x => x.Id);
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
                        name: "FK_Products_ItmeQualityes_Id",
                        column: x => x.Id,
                        principalTable: "ItmeQualityes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_ClientContactInformation<Guid>_ClientContactInformationType<Guid>_ClientContactInformationTypeId",
                        column: x => x.ClientContactInformationTypeId,
                        principalTable: "ClientContactInformationType<Guid>",
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
                values: new object[] { new Guid("00e71a60-057e-4467-82a7-45ea7e5c5848"), null, "Sunt officia fugit ex impedit sit.", "c111763c-d028-435f-b966-326ad35e831f", new DateTime(2020, 8, 10, 6, 19, 50, 859, DateTimeKind.Local).AddTicks(4276), "Bank account: error", new DateTime(2021, 10, 26, 22, 53, 12, 977, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("014d4449-202a-45d1-b6a6-cefbc5f2f619"), null, "Error ut asperiores placeat.", "7babc324-65e4-4af8-8ff8-1daac0507b58", new DateTime(2021, 10, 20, 21, 18, 36, 434, DateTimeKind.Local).AddTicks(4011), "Bank account: natus", new DateTime(2022, 5, 14, 5, 46, 5, 253, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("048c7c2e-6ae8-4923-93d9-e1fd1ac8660a"), null, "Quia non earum saepe quo expedita quia vitae inventore.", "1dc1896d-e4a9-4474-b037-854bdae4a0fb", new DateTime(2018, 7, 12, 19, 4, 22, 482, DateTimeKind.Local).AddTicks(5114), "Bank account: placeat", new DateTime(2018, 10, 10, 6, 25, 1, 992, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05403bd3-b868-4237-ad7c-f5494b10e754"), null, "Quasi ad non qui occaecati aut sint voluptates consequuntur.", "0d407f51-f2dd-40e3-875b-b40e548ab699", new DateTime(2022, 2, 16, 11, 24, 30, 267, DateTimeKind.Local).AddTicks(5469), "Bank account: sint", new DateTime(2022, 3, 13, 6, 38, 31, 20, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0645e8f6-a6dc-4fa6-8252-4adb9da9db62"), null, "Autem beatae modi.", "f49fd233-7b73-4902-9d6d-c2c43af8ab29", new DateTime(2017, 7, 30, 2, 50, 9, 658, DateTimeKind.Local).AddTicks(7621), "Bank account: occaecati", new DateTime(2022, 1, 29, 18, 12, 30, 265, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0d9d3201-62c0-4349-8311-ce25d81a391a"), null, "Molestiae vel ea ipsam alias qui.", "130853bc-07fd-45ae-b309-e6be10538015", new DateTime(2019, 12, 17, 9, 25, 3, 663, DateTimeKind.Local).AddTicks(3975), "Bank account: et", new DateTime(2021, 11, 4, 22, 58, 59, 495, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0e4f3412-65a5-4aeb-8fb7-9b73b02eae46"), null, "Reiciendis maxime expedita nihil ipsa quam.", "21bfc2ec-4601-4fa8-9c90-82ed52bf3be6", new DateTime(2020, 2, 16, 22, 23, 22, 927, DateTimeKind.Local).AddTicks(1386), "Bank account: sed", new DateTime(2020, 7, 4, 14, 27, 41, 898, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("122d3ccc-f740-4220-88cf-9b33a855c347"), null, "Qui exercitationem doloremque dolorem quia ea et.", "88a8c14c-250d-47c3-9ef1-ba81a48083e3", new DateTime(2018, 12, 30, 11, 55, 10, 868, DateTimeKind.Local).AddTicks(8805), "Bank account: non", new DateTime(2021, 3, 7, 9, 41, 19, 318, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1333c816-759f-4aab-ae8d-d70370634990"), null, "Dicta maxime voluptatibus et doloribus deserunt dolorem quo.", "b13dacb1-71f4-47e7-a46a-8ba653f049d1", new DateTime(2022, 5, 20, 17, 9, 40, 148, DateTimeKind.Local).AddTicks(8730), "Bank account: non", new DateTime(2022, 6, 15, 16, 52, 22, 610, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("13b97903-2835-464c-946a-deb49b70dee1"), null, "Quidem ex voluptatem est possimus ipsa.", "f5290c0c-c3c7-4eeb-b55d-160f6b423db4", new DateTime(2021, 6, 3, 6, 4, 49, 440, DateTimeKind.Local).AddTicks(9378), "Bank account: eum", new DateTime(2021, 8, 19, 4, 45, 27, 682, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("13eb5be5-fe0d-42f3-9333-e2d49cca4d40"), null, "Vel temporibus itaque nesciunt quaerat similique et.", "f2784ee5-98aa-49b7-b04c-96c527ba0687", new DateTime(2020, 9, 25, 16, 3, 3, 653, DateTimeKind.Local).AddTicks(385), "Bank account: error", new DateTime(2020, 10, 12, 1, 8, 37, 812, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1acda7e7-7522-44c2-8503-8193f12b4de7"), null, "Corrupti consequatur quisquam.", "b57f2f9c-90dc-4bb1-8127-a4ad308fb7e3", new DateTime(2017, 11, 29, 0, 46, 20, 6, DateTimeKind.Local).AddTicks(6743), "Bank account: ipsa", new DateTime(2020, 11, 26, 14, 8, 12, 16, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b06c26a-63b4-45d2-bcdc-eb4b5b10ad53"), null, "Iure modi ad dignissimos consequatur sit omnis aut quae inventore.", "1cc231ef-00dc-4ffa-8e0a-1551ded00739", new DateTime(2021, 4, 3, 14, 46, 52, 745, DateTimeKind.Local).AddTicks(244), "Bank account: enim", new DateTime(2022, 2, 10, 12, 10, 16, 147, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b383303-42fe-4ac0-84af-a99319af2d42"), null, "Ea qui necessitatibus.", "ac81c56e-0e03-4c1a-bf02-2c40f733e11e", new DateTime(2019, 4, 13, 6, 55, 24, 889, DateTimeKind.Local).AddTicks(8971), "Bank account: et", new DateTime(2019, 6, 6, 20, 55, 29, 743, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1cd9b35a-ca23-4a23-aba6-ab2fc1dcc0ae"), null, "Quaerat et animi inventore animi optio maiores amet.", "9a17068e-0043-4471-91db-29f43d49e8ee", new DateTime(2017, 7, 8, 4, 4, 10, 551, DateTimeKind.Local).AddTicks(3978), "Bank account: ipsam", new DateTime(2018, 9, 30, 15, 2, 7, 830, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ec36d79-dc4e-415a-a440-7dc7e8f3909f"), null, "Dolores porro atque porro qui dolor quos quo repudiandae voluptatibus.", "d4b3e832-2818-40c4-b4f4-315d577decb8", new DateTime(2021, 12, 14, 14, 1, 43, 818, DateTimeKind.Local).AddTicks(6262), "Bank account: eos", new DateTime(2022, 6, 26, 22, 26, 35, 54, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ed6ea94-eb9a-45bd-be6f-3ae306b4b142"), null, "Error quo voluptatem odio aut placeat sed unde aut.", "a6ffc9db-ec6a-45c3-86b1-45025af35ab9", new DateTime(2021, 10, 26, 9, 5, 51, 884, DateTimeKind.Local).AddTicks(7774), "Bank account: quae", new DateTime(2022, 2, 9, 0, 43, 4, 399, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22056032-b916-493a-b0e0-b372b2a103b8"), null, "Tenetur et eos ut recusandae sit.", "3dcd8cc1-4f67-4f9b-9c5f-379aad99d5b8", new DateTime(2021, 8, 21, 6, 34, 45, 229, DateTimeKind.Local).AddTicks(9311), "Bank account: minus", new DateTime(2022, 6, 11, 6, 18, 37, 575, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("284da4cb-f0d1-4de3-b81e-988eb586ae04"), null, "Et exercitationem enim aspernatur eum.", "38454cff-fe78-47dd-914a-38f19c5f303d", new DateTime(2020, 10, 28, 4, 24, 52, 929, DateTimeKind.Local).AddTicks(2094), "Bank account: nobis", new DateTime(2021, 1, 13, 5, 17, 29, 637, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("287129de-8b45-4a2a-a3a7-5ef630428456"), null, "Quasi assumenda earum consequatur non sapiente.", "ee1acf5a-0ec1-45dc-8db2-a9c661f9af91", new DateTime(2021, 7, 14, 20, 27, 16, 583, DateTimeKind.Local).AddTicks(8321), "Bank account: amet", new DateTime(2021, 10, 22, 6, 27, 44, 373, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2b1f3220-fa9c-42fa-9597-f267d34417e3"), null, "Necessitatibus sit qui quod porro reiciendis enim velit.", "0ff93549-2392-4138-a7be-703972dc292a", new DateTime(2019, 10, 27, 1, 28, 34, 268, DateTimeKind.Local).AddTicks(1289), "Bank account: et", new DateTime(2022, 3, 23, 3, 21, 32, 552, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2bbe7c41-1ffd-4f4a-b606-f0005f9069c5"), null, "Omnis atque aperiam.", "c77b6010-ab43-4f6d-8700-e9454dd9270a", new DateTime(2020, 10, 17, 17, 54, 8, 385, DateTimeKind.Local).AddTicks(5393), "Bank account: officiis", new DateTime(2021, 11, 26, 7, 1, 23, 47, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2cd0bfa3-9525-410c-a8a8-44e9611b9e7c"), null, "Rerum dolores officiis atque.", "7583c8d0-9ffa-4a07-89db-ee9c10835bf8", new DateTime(2021, 12, 26, 11, 41, 8, 706, DateTimeKind.Local).AddTicks(6730), "Bank account: est", new DateTime(2022, 1, 12, 20, 22, 32, 825, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3272c92d-6186-436b-8ffe-8889cd3519a9"), null, "Rerum voluptatum doloribus blanditiis maiores ea est fuga incidunt.", "b83c5081-905b-4f41-8365-df566edc8886", new DateTime(2022, 6, 6, 17, 50, 9, 819, DateTimeKind.Local).AddTicks(7331), "Bank account: in", new DateTime(2022, 6, 21, 10, 28, 13, 119, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("341d5887-b396-4813-9a0d-ddb6a0e7c859"), null, "Et et dolore nulla.", "e730c6ca-c04e-43c3-80d9-e5da9907dc6f", new DateTime(2020, 9, 18, 0, 16, 50, 667, DateTimeKind.Local).AddTicks(1793), "Bank account: iste", new DateTime(2022, 6, 15, 11, 57, 56, 478, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3569c449-191c-403f-a075-1462216b8b7e"), null, "Placeat sed officiis eum eius et ipsa tenetur.", "41f8c80f-5e7f-49a3-a7ca-dff0ab6e523c", new DateTime(2020, 9, 19, 6, 29, 3, 930, DateTimeKind.Local).AddTicks(5028), "Bank account: eos", new DateTime(2021, 1, 23, 21, 17, 46, 614, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("369be8ab-32c5-4c9c-83b3-a4ad6c90970a"), null, "Occaecati vel error asperiores non dolore ut nobis quo laudantium.", "c2e9a78a-aa2c-486b-b463-fc359d2a1288", new DateTime(2018, 3, 12, 0, 37, 15, 762, DateTimeKind.Local).AddTicks(1737), "Bank account: incidunt", new DateTime(2019, 12, 17, 19, 50, 53, 342, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("372c0008-03a7-491f-a680-46e251c99349"), null, "Sed officia beatae mollitia reprehenderit inventore ea hic aut.", "76f0eea7-a766-4436-85e6-ee04ea823f58", new DateTime(2022, 6, 2, 17, 16, 38, 151, DateTimeKind.Local).AddTicks(8688), "Bank account: voluptatum", new DateTime(2022, 6, 10, 21, 51, 46, 417, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3abefc8a-efc9-4fa2-9503-d3c996090fd0"), null, "Repudiandae non quas perferendis facere nostrum est.", "75922bb8-2b25-4a7e-9c98-6f6e94eed1a1", new DateTime(2020, 7, 2, 10, 3, 45, 441, DateTimeKind.Local).AddTicks(1862), "Bank account: omnis", new DateTime(2021, 4, 17, 5, 6, 9, 487, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e23c696-ad5d-4684-b35d-8b9cd2b7f31f"), null, "Animi vel maxime est recusandae nemo doloremque accusantium et nisi.", "bc3194d9-832a-4429-9ad7-d8058cc6bb26", new DateTime(2019, 9, 5, 17, 22, 23, 944, DateTimeKind.Local).AddTicks(6872), "Bank account: quod", new DateTime(2022, 1, 26, 9, 14, 59, 934, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ef33def-e5e0-40cd-86f9-a37fdff8f50e"), null, "Nam delectus perspiciatis.", "0251c33e-7661-4bde-a56a-f8e079806c08", new DateTime(2017, 9, 16, 8, 48, 29, 158, DateTimeKind.Local).AddTicks(7054), "Bank account: quam", new DateTime(2018, 9, 7, 6, 58, 3, 576, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42fb3747-83c1-459d-b5db-12e72b2f8c09"), null, "Quae cumque minus animi enim labore doloribus cupiditate.", "3478fbf1-02c4-4320-b34f-1b06380c3cc3", new DateTime(2020, 5, 31, 15, 40, 33, 484, DateTimeKind.Local).AddTicks(4262), "Bank account: dignissimos", new DateTime(2022, 4, 24, 9, 13, 20, 542, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("43136dfb-2ed3-4153-b6f1-98ae4fcd36d9"), null, "Quia non similique.", "ef94ee61-a0ca-477c-83d7-7bb496115232", new DateTime(2017, 11, 4, 22, 38, 27, 801, DateTimeKind.Local).AddTicks(9229), "Bank account: qui", new DateTime(2018, 4, 7, 11, 24, 45, 88, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("45e5081e-06ce-4518-a068-883c3ae1e489"), null, "Perferendis illum molestias dicta eum quo alias doloribus.", "fa503d46-1f62-4f53-9491-44405f849863", new DateTime(2021, 4, 13, 6, 20, 45, 309, DateTimeKind.Local).AddTicks(306), "Bank account: fugiat", new DateTime(2021, 11, 29, 21, 50, 35, 342, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47fddbd3-6066-4d3b-a0b3-178407e4aa99"), null, "Ea nisi pariatur dolorem et dignissimos sunt.", "aaa26e7c-04fb-4d17-a4fb-dda28e9a75be", new DateTime(2019, 4, 10, 23, 24, 40, 628, DateTimeKind.Local).AddTicks(6610), "Bank account: praesentium", new DateTime(2022, 1, 4, 23, 12, 50, 814, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("480fc8ca-6575-45b8-b937-fe2c06077965"), null, "Inventore sapiente similique eveniet ullam eum consequatur omnis rerum.", "0818e936-e7bf-438c-92db-c70a60c9d90f", new DateTime(2022, 3, 23, 15, 21, 23, 377, DateTimeKind.Local).AddTicks(9812), "Bank account: nulla", new DateTime(2022, 6, 3, 13, 3, 7, 61, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4948579d-26a6-48c7-962f-90b7f92cf553"), null, "Est non repudiandae hic.", "a6d65b29-f0f2-40f5-88ad-df13dcfc4a5e", new DateTime(2017, 12, 18, 16, 56, 44, 402, DateTimeKind.Local).AddTicks(8174), "Bank account: inventore", new DateTime(2019, 10, 5, 11, 28, 47, 563, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("50513712-9952-4a29-98a2-01f88398b261"), null, "Assumenda incidunt est dolor eum sit placeat accusantium.", "3944a083-ef7c-468b-903a-880b5613bc1f", new DateTime(2019, 3, 23, 20, 58, 42, 670, DateTimeKind.Local).AddTicks(856), "Bank account: soluta", new DateTime(2019, 9, 4, 14, 18, 11, 124, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5431f35e-18cb-49bc-8002-8f5ce911961d"), null, "Illum architecto consequatur dolorem dicta error maiores.", "263c1bb4-706d-4a6e-93a5-b97ff06f92dd", new DateTime(2020, 3, 30, 22, 29, 16, 650, DateTimeKind.Local).AddTicks(1252), "Bank account: ut", new DateTime(2021, 12, 20, 10, 1, 14, 169, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54b0fd08-bc3d-44de-8590-0e5c98e366d9"), null, "Rem omnis aut esse qui.", "718ceb1b-d4d5-47d9-8a0c-f2b500da91a6", new DateTime(2019, 11, 27, 16, 45, 35, 219, DateTimeKind.Local).AddTicks(5295), "Bank account: possimus", new DateTime(2020, 10, 14, 12, 0, 46, 224, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("58bf9959-0f32-4afa-aa52-3f3065631352"), null, "Ipsa maxime dolor facilis omnis accusantium itaque.", "e65555c0-318c-4c77-9ec0-913a74eb081e", new DateTime(2019, 11, 19, 4, 10, 42, 330, DateTimeKind.Local).AddTicks(554), "Bank account: sit", new DateTime(2022, 5, 29, 23, 46, 53, 495, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c23cd17-9634-4f3a-ad4c-423f8f4239d8"), null, "Optio iusto unde et voluptatem.", "9cee14c9-e668-4de6-b5a3-e3ffeeaa6dad", new DateTime(2020, 3, 11, 17, 24, 22, 492, DateTimeKind.Local).AddTicks(2555), "Bank account: necessitatibus", new DateTime(2021, 6, 1, 15, 59, 33, 296, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5cbb7fea-e009-44ad-ae5e-b9ab9e369506"), null, "Quaerat ullam nam qui officia aut.", "b79e3967-1c78-4bc1-9478-01c34af85042", new DateTime(2018, 7, 16, 4, 37, 15, 395, DateTimeKind.Local).AddTicks(8908), "Bank account: soluta", new DateTime(2020, 4, 17, 21, 48, 13, 71, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d9f5076-1194-4dbf-b944-50b03e81d26f"), null, "Repellendus officiis est officia ratione totam dolores cumque non qui.", "286bc3eb-b419-48f2-9449-4349b4f19ea9", new DateTime(2019, 2, 12, 23, 14, 19, 80, DateTimeKind.Local).AddTicks(8989), "Bank account: aliquid", new DateTime(2019, 9, 22, 8, 37, 39, 144, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e1f1070-4568-4024-a5fa-7570f2d11020"), null, "Doloremque cumque possimus nisi velit quam ipsa.", "4910891f-ea44-40b4-9702-10c7fe4c2bd6", new DateTime(2018, 5, 13, 4, 10, 58, 299, DateTimeKind.Local).AddTicks(7430), "Bank account: enim", new DateTime(2018, 6, 10, 12, 49, 45, 509, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61d73076-ce36-43a5-9817-795462fbc456"), null, "Et occaecati dolor eius assumenda ea qui.", "967bd78e-5404-49fc-8c09-29d5f5f0e27d", new DateTime(2022, 1, 4, 4, 21, 59, 955, DateTimeKind.Local).AddTicks(7300), "Bank account: quo", new DateTime(2022, 1, 24, 17, 8, 0, 114, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6289892c-2719-415b-a45e-aad07b876dd7"), null, "Voluptas sed delectus et eos.", "3ca8f5b7-a1c4-4034-9bae-78eabbf26cc4", new DateTime(2018, 2, 23, 7, 28, 26, 412, DateTimeKind.Local).AddTicks(253), "Bank account: ut", new DateTime(2019, 6, 30, 2, 54, 38, 190, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("64e1d1dc-b5a1-41c5-a517-af84e45c0590"), null, "Labore magni voluptates molestiae vel provident.", "0b380878-4e7a-4725-9980-ea6c958b2c5e", new DateTime(2020, 11, 7, 20, 11, 17, 786, DateTimeKind.Local).AddTicks(3874), "Bank account: ut", new DateTime(2022, 5, 25, 18, 51, 28, 617, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("66722456-3d92-4a8b-9181-201bb99c10a2"), null, "Voluptatem voluptatem vel perferendis.", "0dfe7c8e-2820-479e-ba7d-9e4210fbff4b", new DateTime(2020, 7, 12, 2, 13, 59, 716, DateTimeKind.Local).AddTicks(8940), "Bank account: nesciunt", new DateTime(2021, 3, 9, 4, 18, 2, 89, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("68d310ef-9abd-4bcb-99a7-49cc26c989c5"), null, "Quam autem provident fugit sequi et laborum inventore.", "d393f18c-f309-44d7-93cf-0b05a5ab3a25", new DateTime(2021, 3, 16, 14, 14, 28, 68, DateTimeKind.Local).AddTicks(2511), "Bank account: sapiente", new DateTime(2021, 8, 14, 19, 46, 45, 463, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6f709130-51b3-4818-aad0-cc35a147d2fe"), null, "Perspiciatis vitae ipsam quas.", "7f65c543-63a9-483d-bb9a-dbef475b13f0", new DateTime(2018, 10, 15, 15, 23, 37, 303, DateTimeKind.Local).AddTicks(9486), "Bank account: aspernatur", new DateTime(2020, 1, 3, 3, 25, 8, 207, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7691535a-f5a5-4b07-bb88-6b4a3988392f"), null, "Praesentium minus sed tempora repellendus ut.", "d2bf2860-e233-45fd-a8fa-62f1a0ae4c36", new DateTime(2019, 2, 25, 7, 25, 56, 424, DateTimeKind.Local).AddTicks(5318), "Bank account: sunt", new DateTime(2021, 7, 6, 4, 55, 44, 195, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("79ebe4d8-744d-4eaa-9475-69e96f8a3694"), null, "Aut corporis similique repellat consequatur voluptatem.", "464d13b8-c24c-43f3-9b21-be3fe7bb56c3", new DateTime(2021, 7, 4, 8, 20, 1, 925, DateTimeKind.Local).AddTicks(2767), "Bank account: quia", new DateTime(2022, 1, 12, 10, 10, 14, 344, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e470c06-a557-443b-a71b-156d3f5debce"), null, "Eaque hic corporis eos vero consectetur.", "14c4c600-0577-42bb-b42b-2d2a5f49ae65", new DateTime(2019, 3, 24, 15, 52, 7, 336, DateTimeKind.Local).AddTicks(7216), "Bank account: voluptatem", new DateTime(2019, 4, 7, 8, 29, 4, 35, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7fc50e0c-78d5-4044-9133-4043027fdc1b"), null, "Quis praesentium cupiditate facilis ab et enim exercitationem mollitia.", "5bff7fff-67f7-470c-b3f1-1a051a7ab639", new DateTime(2018, 12, 22, 19, 55, 26, 507, DateTimeKind.Local).AddTicks(5080), "Bank account: in", new DateTime(2020, 7, 24, 2, 36, 0, 164, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("840c728f-0367-4ff3-a4b2-979edb1f075d"), null, "Sequi velit qui culpa in perferendis.", "1a097818-79fb-43b0-9140-a6c7daa199a0", new DateTime(2018, 8, 8, 20, 22, 20, 919, DateTimeKind.Local).AddTicks(6333), "Bank account: optio", new DateTime(2020, 9, 30, 3, 39, 58, 699, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84d47a90-55b6-4ad5-a826-867b1d5a80a9"), null, "Nesciunt quia non consectetur quasi facere vero.", "dc1ec368-edbe-4b7d-aa4b-34c998ce76bf", new DateTime(2018, 1, 10, 12, 40, 33, 768, DateTimeKind.Local).AddTicks(9820), "Bank account: totam", new DateTime(2020, 10, 26, 18, 31, 47, 660, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86811e13-024f-44dd-a8d4-de63ef36f1f8"), null, "Odit architecto blanditiis aut assumenda.", "626c0d72-784f-4dca-a5f1-f8546163efa6", new DateTime(2018, 8, 16, 9, 37, 0, 250, DateTimeKind.Local).AddTicks(1647), "Bank account: sed", new DateTime(2020, 9, 16, 10, 21, 28, 639, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("87998735-a6da-40b0-87b2-cd7991e2320b"), null, "Ut blanditiis accusantium et ut accusamus voluptatibus mollitia.", "b618f1ca-f6d7-4703-a8ec-be3cc2f5ff71", new DateTime(2020, 5, 19, 21, 31, 55, 806, DateTimeKind.Local).AddTicks(7065), "Bank account: asperiores", new DateTime(2020, 10, 25, 5, 15, 54, 874, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("885dd1ad-5ece-42be-8025-df4152592329"), null, "Sit eveniet provident quia corporis earum qui expedita dolores.", "a7bd7349-93f5-4667-aed2-47e08d50b858", new DateTime(2019, 12, 16, 19, 5, 4, 603, DateTimeKind.Local).AddTicks(7087), "Bank account: in", new DateTime(2021, 8, 24, 8, 57, 32, 563, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("888265f3-dbd6-4351-a9b2-ddc3e9e005ac"), null, "Ut perferendis esse sit.", "e281d314-71b0-44c7-bad8-999e3ce91d2e", new DateTime(2017, 12, 20, 15, 31, 20, 575, DateTimeKind.Local).AddTicks(5844), "Bank account: quia", new DateTime(2017, 12, 24, 1, 17, 38, 136, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89c9339c-1e54-4e9d-9e88-30ea858e19b4"), null, "Temporibus explicabo soluta sint officiis necessitatibus ut ullam unde est.", "8c194f14-776e-488c-aeee-b8d58763c5ca", new DateTime(2020, 5, 22, 15, 31, 36, 690, DateTimeKind.Local).AddTicks(964), "Bank account: omnis", new DateTime(2021, 10, 1, 8, 33, 51, 774, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e1a68ab-3089-40c1-a9ee-d2f2f1a2e830"), null, "Quod unde cupiditate odio ut autem.", "7257c0fb-ff25-4c8b-9b28-c85003e4407f", new DateTime(2017, 9, 8, 21, 16, 49, 733, DateTimeKind.Local).AddTicks(5452), "Bank account: velit", new DateTime(2019, 4, 22, 22, 51, 23, 922, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f5d553e-0cfa-4374-96f3-7bf9696ab531"), null, "Error delectus excepturi voluptatum incidunt labore qui.", "ef8d66b6-5da1-4ffe-bb8e-d5f6fd408e14", new DateTime(2020, 3, 29, 1, 41, 28, 122, DateTimeKind.Local).AddTicks(6012), "Bank account: neque", new DateTime(2022, 4, 2, 11, 41, 29, 206, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9013b184-f781-4697-a3d7-6ce7dc0b4e34"), null, "Dolor atque architecto suscipit eos quaerat id impedit.", "2d27d84f-1386-467f-aa29-0e88e6e107a3", new DateTime(2019, 11, 23, 10, 7, 57, 827, DateTimeKind.Local).AddTicks(8688), "Bank account: molestias", new DateTime(2020, 1, 13, 13, 4, 29, 321, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90cc48d2-5b13-4f14-8f09-c6e4145e4270"), null, "Libero veniam repellat quis quaerat totam nesciunt sunt.", "ecdf3a48-f7cc-4499-b2cf-7ed75be7613b", new DateTime(2021, 10, 23, 9, 36, 47, 224, DateTimeKind.Local).AddTicks(7870), "Bank account: voluptas", new DateTime(2022, 3, 23, 8, 48, 35, 533, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9253f59e-d574-4a71-8d3e-09ed35fb0553"), null, "Aliquam praesentium nisi.", "e5553cbd-2319-48cf-a1db-9cc119b61f7c", new DateTime(2021, 6, 17, 2, 39, 21, 890, DateTimeKind.Local).AddTicks(6843), "Bank account: omnis", new DateTime(2022, 3, 3, 9, 30, 25, 891, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("979f9589-4c36-4c63-a7de-e91373390d03"), null, "Harum exercitationem nihil doloremque et ab consectetur.", "5e1d4985-2411-4e54-83bb-c9564ee9b540", new DateTime(2021, 7, 29, 2, 13, 24, 281, DateTimeKind.Local).AddTicks(2374), "Bank account: porro", new DateTime(2022, 3, 19, 19, 11, 13, 877, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("986564b9-064c-4022-9a1d-372f47ed9d7b"), null, "Doloremque molestias distinctio nobis aliquam cumque id quam.", "446fbb98-94e2-4eea-b7ea-de9726ff0b60", new DateTime(2019, 4, 16, 6, 20, 58, 563, DateTimeKind.Local).AddTicks(3814), "Bank account: autem", new DateTime(2020, 5, 24, 7, 44, 26, 118, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e76bd09-a852-4615-aaba-54a9c6b8a1c3"), null, "Voluptatibus debitis numquam facere ipsa eum ut et voluptates.", "02704a5c-bc15-45cf-a339-6fe82eeeb036", new DateTime(2020, 1, 24, 11, 38, 25, 559, DateTimeKind.Local).AddTicks(3119), "Bank account: commodi", new DateTime(2020, 3, 11, 20, 11, 38, 908, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a8327f39-8518-48af-b03b-aabcd194726f"), null, "Et nisi fugit vitae.", "ca7161ee-cbec-41e2-86f3-a577bbcf36e7", new DateTime(2019, 2, 17, 21, 45, 37, 309, DateTimeKind.Local).AddTicks(6334), "Bank account: ut", new DateTime(2020, 12, 7, 17, 28, 12, 595, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a961bb57-4280-4a1b-bfa8-38307e558579"), null, "Velit enim facere enim blanditiis corrupti delectus placeat corrupti aut.", "f0133ae6-98c3-4ce1-a70c-8ed60b6b1433", new DateTime(2019, 10, 8, 14, 53, 31, 650, DateTimeKind.Local).AddTicks(2258), "Bank account: repudiandae", new DateTime(2020, 11, 16, 4, 13, 37, 394, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aad64d1b-f2d1-414a-afd8-229d5a35d925"), null, "Adipisci ut nobis.", "f8cad17b-8c8e-4209-a21f-f184cb536065", new DateTime(2021, 10, 3, 2, 18, 17, 93, DateTimeKind.Local).AddTicks(7065), "Bank account: velit", new DateTime(2022, 2, 1, 11, 23, 39, 367, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b08e72f0-bdb2-41fe-8e01-c6ccb0712c15"), null, "Ut perferendis quia accusantium nisi corrupti mollitia voluptas itaque aliquid.", "3705e959-5639-4624-8558-7959ce9f8086", new DateTime(2020, 7, 20, 0, 33, 8, 617, DateTimeKind.Local).AddTicks(5284), "Bank account: sunt", new DateTime(2021, 3, 27, 19, 35, 36, 731, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8543842-2f5b-417e-bbb8-efd1541fbe51"), null, "Cumque sint magnam odio quibusdam est sed minima velit consequuntur.", "a1ded430-b7e8-4f8c-8057-08c01729a81a", new DateTime(2019, 7, 17, 2, 36, 37, 849, DateTimeKind.Local).AddTicks(8150), "Bank account: error", new DateTime(2019, 8, 11, 18, 26, 18, 782, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8843a9d-b414-4254-9067-8b0366c2bd29"), null, "Libero quia dolores ea.", "02ff6810-8ee5-441e-8777-765309f2d10b", new DateTime(2019, 4, 10, 5, 15, 56, 960, DateTimeKind.Local).AddTicks(8204), "Bank account: nobis", new DateTime(2021, 7, 28, 4, 45, 36, 882, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba5d5cfa-f741-482a-b4fa-01ee11138613"), null, "Optio voluptate incidunt.", "65f9738f-a9bc-4b06-90a3-0d76deed0be2", new DateTime(2021, 10, 13, 18, 59, 27, 137, DateTimeKind.Local).AddTicks(7073), "Bank account: molestiae", new DateTime(2022, 1, 18, 14, 3, 23, 836, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf9834c9-b781-496e-a685-76498ae49988"), null, "Qui ipsa ullam quia rem.", "c3922938-a697-4249-a582-3b34980d5a18", new DateTime(2021, 5, 24, 20, 53, 46, 614, DateTimeKind.Local).AddTicks(1017), "Bank account: officia", new DateTime(2021, 12, 15, 12, 40, 59, 677, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c566f271-3d39-4661-88ec-62c56aea20a0"), null, "Eum dolorem nihil ea qui ut quis distinctio asperiores.", "72cfec8b-74cc-46ac-b6f5-d137c1e1353b", new DateTime(2020, 11, 22, 15, 46, 51, 542, DateTimeKind.Local).AddTicks(4205), "Bank account: voluptatibus", new DateTime(2020, 12, 26, 18, 54, 3, 761, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c84be721-5f44-4829-909e-99cabe3285e5"), null, "Tempore ut minima amet consequatur aut omnis ullam.", "84032cfe-7c08-4c57-96c3-191f05da4087", new DateTime(2022, 2, 11, 16, 12, 48, 492, DateTimeKind.Local).AddTicks(4013), "Bank account: ullam", new DateTime(2022, 3, 3, 1, 43, 38, 428, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8d390cc-f5d5-4ce9-9d02-f256bfb31265"), null, "Vel et eius.", "6b9bfda5-ac51-4103-8f45-226b6b5ea5a1", new DateTime(2018, 5, 31, 8, 31, 36, 112, DateTimeKind.Local).AddTicks(686), "Bank account: sed", new DateTime(2021, 12, 29, 16, 1, 55, 41, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c912ebcf-7ee3-4092-b743-10dc415bee91"), null, "Molestias et omnis corrupti.", "e7864ba1-4d34-4884-9a6f-428ee48b0456", new DateTime(2018, 5, 13, 19, 29, 42, 63, DateTimeKind.Local).AddTicks(9749), "Bank account: qui", new DateTime(2019, 6, 28, 3, 56, 49, 789, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c9a57a86-f16a-45e0-b607-93893b1fbd1f"), null, "Voluptas sunt beatae nobis voluptatem.", "5324a562-ae24-48f6-a8ed-5d0b62951b52", new DateTime(2019, 11, 7, 10, 57, 26, 730, DateTimeKind.Local).AddTicks(2824), "Bank account: sed", new DateTime(2021, 4, 28, 7, 5, 9, 272, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf084da5-c6a5-4a15-9453-66716c2b87ab"), null, "Dolore officiis dolorum cumque laboriosam id qui.", "40749eec-6c26-40be-9920-949fde08f000", new DateTime(2019, 5, 27, 3, 16, 36, 467, DateTimeKind.Local).AddTicks(4154), "Bank account: dolorem", new DateTime(2019, 10, 5, 10, 55, 19, 208, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1f9ae48-daa7-4896-a80f-377a9bbb3659"), null, "Excepturi eveniet quia id ipsam vitae vero.", "7f5c1324-a379-4a42-a84e-f4ff209cee1c", new DateTime(2017, 10, 12, 15, 18, 59, 680, DateTimeKind.Local).AddTicks(8997), "Bank account: ut", new DateTime(2021, 4, 27, 23, 47, 36, 994, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d5363057-b5b5-4816-9dae-bc1d1e8c9171"), null, "Dicta natus exercitationem qui dolorum fugiat adipisci repudiandae iste cupiditate.", "25bbd08d-bf00-4807-b218-702539d483f1", new DateTime(2019, 10, 4, 7, 44, 4, 754, DateTimeKind.Local).AddTicks(4076), "Bank account: perferendis", new DateTime(2020, 11, 26, 9, 11, 17, 131, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dba6d6b5-e02d-463c-8ea6-0acb6ead307f"), null, "Aliquid accusamus qui culpa officia vitae voluptatibus sit exercitationem.", "e229e234-47b7-4a70-86d7-98b59167ed4f", new DateTime(2018, 1, 10, 22, 14, 30, 8, DateTimeKind.Local).AddTicks(2520), "Bank account: esse", new DateTime(2020, 7, 27, 9, 29, 35, 817, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("deadfb51-5104-45a3-9f95-5e6eb89938d0"), null, "Beatae quibusdam dolorum.", "96637dfa-ef86-412c-b5f4-fca99abeb1bf", new DateTime(2018, 3, 17, 22, 40, 35, 721, DateTimeKind.Local).AddTicks(6646), "Bank account: ut", new DateTime(2020, 12, 30, 15, 12, 30, 47, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df51144c-9df4-421b-8cd7-7018cea9da96"), null, "Eaque consequatur quasi quam dolorem ad eum similique.", "97fb6b2e-105d-4597-ade9-4ebb16902487", new DateTime(2018, 5, 28, 16, 23, 58, 974, DateTimeKind.Local).AddTicks(5342), "Bank account: laborum", new DateTime(2019, 9, 24, 11, 45, 11, 127, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df642348-b53b-4352-9c44-3603856fe78b"), null, "Recusandae mollitia quia et quo.", "9b0819f4-73c3-4102-a69d-3e70c3fe49f7", new DateTime(2018, 4, 24, 21, 26, 52, 694, DateTimeKind.Local).AddTicks(8824), "Bank account: numquam", new DateTime(2021, 4, 13, 20, 27, 51, 624, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df643053-33ae-4f4b-9f16-08279fe7f27f"), null, "Ipsam corporis alias quis accusantium magni qui quia.", "b27e256b-d43f-474a-ad3e-72308d6aa55e", new DateTime(2021, 11, 24, 0, 56, 10, 340, DateTimeKind.Local).AddTicks(2405), "Bank account: delectus", new DateTime(2022, 1, 11, 11, 5, 39, 450, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e50920a1-c133-4139-bd38-e955af95b640"), null, "Doloremque nisi vero.", "c82aa7be-93e3-41cb-84c2-bf9eab0c6964", new DateTime(2018, 9, 21, 10, 7, 1, 883, DateTimeKind.Local).AddTicks(7760), "Bank account: saepe", new DateTime(2019, 5, 9, 17, 23, 11, 158, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e60f175d-5abb-47a6-976c-4899376b9b3e"), null, "Et aliquam similique asperiores tempora necessitatibus.", "968416ea-8eb9-4157-a8d4-bc3bde445457", new DateTime(2021, 3, 8, 2, 23, 18, 156, DateTimeKind.Local).AddTicks(1147), "Bank account: dolorem", new DateTime(2022, 3, 13, 12, 32, 52, 204, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e84a248e-9365-4c76-8954-c369507c7c51"), null, "Et aliquid nam repudiandae nisi.", "7a0eee29-a511-44bd-ae04-b93999448416", new DateTime(2018, 4, 6, 0, 26, 46, 776, DateTimeKind.Local).AddTicks(5764), "Bank account: enim", new DateTime(2019, 8, 20, 13, 14, 17, 833, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8919d4b-b93c-45de-b093-c56ed8d65021"), null, "Ut beatae ab.", "65f57dd7-aabb-49a1-a37c-f96d1877d402", new DateTime(2019, 6, 29, 12, 49, 51, 890, DateTimeKind.Local).AddTicks(1487), "Bank account: maiores", new DateTime(2020, 5, 30, 18, 46, 17, 80, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed5b93ba-fc44-4919-a5c2-867af4813fb2"), null, "Autem maxime sit nobis sint rerum.", "2c80286c-4b8f-4c48-88d2-a85fe5c4d551", new DateTime(2018, 9, 7, 15, 18, 19, 626, DateTimeKind.Local).AddTicks(7508), "Bank account: laudantium", new DateTime(2022, 5, 26, 18, 42, 10, 218, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f364c459-ce7c-45af-838c-60831190ca1f"), null, "Vel asperiores dolor provident qui reiciendis ullam.", "7a516bb5-38bb-43b8-971a-a54dd3b43d05", new DateTime(2017, 7, 11, 15, 24, 37, 3, DateTimeKind.Local).AddTicks(553), "Bank account: itaque", new DateTime(2021, 10, 31, 16, 11, 41, 711, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa268b70-2d77-4d79-86c4-48094fe9a824"), null, "Ipsa error odit voluptatem.", "1a5e5797-c2c6-4f74-84b9-7a0763a73431", new DateTime(2018, 10, 22, 12, 28, 54, 950, DateTimeKind.Local).AddTicks(8485), "Bank account: natus", new DateTime(2022, 6, 16, 9, 46, 15, 248, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa52d884-c94b-4073-b465-c08a970efe4d"), null, "Vitae nostrum nihil reiciendis nostrum quasi sit fuga.", "07d09b9b-a96c-4e00-979e-78bd21b69b72", new DateTime(2021, 5, 26, 16, 21, 57, 975, DateTimeKind.Local).AddTicks(7604), "Bank account: quidem", new DateTime(2021, 11, 12, 19, 43, 17, 68, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa90401f-a45e-46ac-9dec-5de1469b2bc7"), null, "Cupiditate et enim.", "f58e5490-9bca-4a26-a6d1-6be86f62ef38", new DateTime(2020, 5, 14, 13, 51, 14, 547, DateTimeKind.Local).AddTicks(1890), "Bank account: voluptatum", new DateTime(2020, 11, 30, 6, 22, 51, 307, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("039d46a9-d1da-4863-a52b-e31bc105fccc"), "Nihil tempore et iure iste rerum quod autem nobis blanditiis.", "c1a2f63f-b7dd-46e6-b98d-88c7b22e623b", new DateTime(2022, 4, 18, 6, 42, 47, 748, DateTimeKind.Local).AddTicks(3394), "Bank Abshire Group", new DateTime(2022, 7, 4, 5, 27, 44, 831, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0519c000-d000-40d8-9437-fc3546de7839"), "Voluptatem dolor qui quia.", "11b877e7-fb28-4699-9f41-21bd097b4a22", new DateTime(2019, 5, 8, 5, 44, 32, 860, DateTimeKind.Local).AddTicks(1752), "Bank Rath, Nienow and Leannon", new DateTime(2019, 12, 11, 16, 17, 33, 965, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("058e40bd-698b-4f50-bfd7-7b223827cda5"), "Tempora reiciendis quas unde quibusdam.", "4c37eb75-ca3f-427f-a214-2bcd651255a9", new DateTime(2018, 11, 25, 0, 52, 54, 11, DateTimeKind.Local).AddTicks(2587), "Bank Reinger - Prosacco", new DateTime(2019, 11, 6, 15, 44, 57, 500, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08304312-7014-423d-a110-f322acf6fbfc"), "Dolorem cupiditate iusto distinctio dolorem sit voluptatem odio.", "290b7e61-e2c0-4dd1-8e35-ddd322beae9c", new DateTime(2021, 5, 20, 22, 14, 22, 758, DateTimeKind.Local).AddTicks(553), "Bank Waters - Wunsch", new DateTime(2021, 6, 10, 16, 12, 37, 136, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f810b9b-f789-4e54-ac83-ae58643e44c4"), "Mollitia autem tempora velit inventore nostrum tempora sed qui ut.", "4caca436-627b-4e7e-be52-3d7649371ac2", new DateTime(2021, 4, 3, 5, 24, 26, 846, DateTimeKind.Local).AddTicks(2894), "Bank Treutel - Smitham", new DateTime(2022, 6, 6, 23, 31, 50, 602, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("16367232-bdd9-464e-8945-fa855dfca00d"), "Dolorem aut deserunt.", "50e4672c-5275-4f47-8f46-8acaefbe211f", new DateTime(2021, 12, 12, 22, 2, 36, 292, DateTimeKind.Local).AddTicks(6769), "Bank Douglas LLC", new DateTime(2021, 12, 18, 0, 45, 13, 627, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1766290e-93a6-41d6-9c13-a5f357ce9797"), "Odit minima facere sequi blanditiis et.", "4211e046-2e07-4c97-a240-b9d3b2158af1", new DateTime(2017, 10, 21, 13, 59, 51, 493, DateTimeKind.Local).AddTicks(4184), "Bank Rosenbaum and Sons", new DateTime(2022, 6, 26, 1, 38, 54, 527, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("185e54fa-be70-4a0c-a692-e457bcbc9f58"), "Ut sunt similique tempora harum similique nisi.", "0ec3c0a2-01f5-4a4f-a835-2d0e8d6cb107", new DateTime(2019, 2, 23, 21, 54, 25, 693, DateTimeKind.Local).AddTicks(8459), "Bank Schroeder and Sons", new DateTime(2020, 11, 9, 22, 37, 8, 963, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1da8e605-a5a9-4308-9630-ff68619fdcaf"), "Architecto voluptas quibusdam laudantium sapiente exercitationem repellendus modi.", "2152ab5e-ae37-4509-afed-5ccab2289546", new DateTime(2020, 9, 6, 10, 42, 51, 706, DateTimeKind.Local).AddTicks(5716), "Bank Senger - Daniel", new DateTime(2021, 9, 19, 19, 22, 41, 567, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ef430fa-f1b4-436a-a595-48e8f1ace858"), "Sit officia ad corrupti.", "8a3b9466-b0bf-419c-ba1f-bf995f3ef36f", new DateTime(2017, 7, 11, 18, 29, 41, 577, DateTimeKind.Local).AddTicks(1758), "Bank Fadel - Rogahn", new DateTime(2022, 6, 27, 6, 31, 46, 82, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2008fdfa-7145-4030-be00-aea78c028ac6"), "Vitae voluptatem reprehenderit nisi.", "cdc23d52-bc3c-4eba-bd7c-4577caf37c48", new DateTime(2021, 8, 29, 19, 22, 41, 586, DateTimeKind.Local).AddTicks(9148), "Bank Rolfson Inc", new DateTime(2022, 6, 2, 10, 18, 20, 593, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22395b63-c2e3-4748-ba2a-0c1b093078a3"), "Aperiam sunt eligendi dolorem iste facere enim omnis nihil magnam.", "40df09a9-28d9-423b-a052-c7bab317249b", new DateTime(2021, 5, 30, 4, 40, 30, 19, DateTimeKind.Local).AddTicks(665), "Bank Schmitt Group", new DateTime(2022, 3, 21, 4, 45, 31, 720, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2441e691-55e5-498d-beec-ad759042a897"), "In itaque dolorem sapiente expedita consequatur.", "2e00f383-b958-4d71-ba6d-83e79c276e98", new DateTime(2019, 4, 13, 22, 54, 42, 390, DateTimeKind.Local).AddTicks(6396), "Bank Emmerich, Streich and Ortiz", new DateTime(2021, 1, 6, 20, 47, 45, 530, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("28419f04-6d9b-4e81-9f36-5e7aea27db84"), "Et sit omnis provident accusamus quia non nulla vero.", "19333ac0-8e80-40b3-a536-3169a03f2329", new DateTime(2017, 8, 11, 14, 13, 47, 862, DateTimeKind.Local).AddTicks(6723), "Bank Lakin Group", new DateTime(2018, 5, 6, 5, 14, 28, 404, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2909c2c5-66f3-4e65-b518-38ef313ecfd4"), "Illum enim temporibus itaque aut odio debitis.", "f2d682bb-7d1c-43c2-a02e-8f6b2d1e7126", new DateTime(2021, 8, 31, 6, 48, 47, 9, DateTimeKind.Local).AddTicks(7818), "Bank Orn - Fadel", new DateTime(2022, 6, 14, 14, 25, 34, 194, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2adf42f6-fe88-453c-9824-cd738199469e"), "Natus natus iusto tempore aliquid eos tenetur.", "496a084c-a62c-4d0f-9c3d-0a9b792da681", new DateTime(2017, 12, 6, 21, 21, 25, 564, DateTimeKind.Local).AddTicks(4066), "Bank Kunze Group", new DateTime(2021, 6, 9, 7, 28, 11, 396, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2b96d6fd-f1cf-4faa-a9a4-f571a1fa23d0"), "Exercitationem eos harum.", "a1343a86-6c07-4288-9d7b-44501fcb850c", new DateTime(2022, 5, 7, 8, 4, 48, 305, DateTimeKind.Local).AddTicks(7338), "Bank Schmitt - Wolf", new DateTime(2022, 6, 15, 6, 11, 43, 813, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2cb1ff0f-f863-44ac-b1e8-72f609971b36"), "Inventore tempore exercitationem architecto rem sint dolor quae accusamus vero.", "3c2d3642-fb30-4fa6-81a8-d7896b88f618", new DateTime(2021, 12, 28, 1, 34, 37, 29, DateTimeKind.Local).AddTicks(2428), "Bank Yost - Ryan", new DateTime(2022, 5, 29, 23, 2, 40, 75, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3189f921-d102-467d-8836-b85d95328ac0"), "Harum cum ut eligendi reprehenderit suscipit laboriosam dicta.", "db4576f6-d0d1-4a4d-bba8-262d46c72c71", new DateTime(2020, 1, 29, 19, 39, 19, 787, DateTimeKind.Local).AddTicks(3848), "Bank Brekke - Quitzon", new DateTime(2020, 8, 7, 11, 50, 53, 403, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34704f34-040b-4348-a2bb-b206645bbed0"), "Et eligendi sed eveniet dolorum suscipit mollitia.", "38c4be54-35e2-40a4-beeb-d357110e0065", new DateTime(2020, 9, 12, 3, 23, 43, 770, DateTimeKind.Local).AddTicks(6188), "Bank Stokes, Paucek and Schmitt", new DateTime(2021, 11, 4, 21, 31, 32, 809, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34e0eecb-a1c8-4e6d-a526-3ec4c801a550"), "Omnis adipisci dolor.", "276a950d-525c-4241-a556-7912dd3fdb58", new DateTime(2018, 9, 13, 3, 47, 38, 94, DateTimeKind.Local).AddTicks(1856), "Bank West, Rath and Mertz", new DateTime(2020, 1, 8, 10, 45, 58, 446, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34f9b3e7-3fd3-4ee0-9547-d23c578eb3e7"), "Facilis libero rerum dolorem.", "e142fb93-ed57-4d9e-866b-25e6794c0ef1", new DateTime(2017, 10, 19, 23, 7, 24, 526, DateTimeKind.Local).AddTicks(5200), "Bank Cummerata, Hodkiewicz and Romaguera", new DateTime(2017, 12, 4, 13, 25, 43, 470, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3523e7f0-78ea-4258-bb55-1a9f62700e07"), "Exercitationem sit dolorem nam maiores mollitia sint aliquid et vel.", "227cb8c3-4a10-4544-aaf8-4396fa8e0b59", new DateTime(2020, 5, 6, 7, 38, 12, 160, DateTimeKind.Local).AddTicks(8871), "Bank Towne - Walter", new DateTime(2021, 8, 13, 13, 9, 23, 848, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35eca1ed-d9e5-4909-9440-4e0496e816a7"), "Unde impedit a accusantium omnis.", "03068adf-b8fd-4e5b-a964-d75b2447e8d5", new DateTime(2019, 11, 18, 18, 32, 16, 114, DateTimeKind.Local).AddTicks(6124), "Bank Flatley Inc", new DateTime(2020, 9, 9, 12, 49, 17, 175, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("389c556b-ff28-4a89-b407-e8ecd94b2d6a"), "Labore sint est voluptate.", "723c135d-7ef3-40c5-bf5e-8e4860d2dfcb", new DateTime(2019, 7, 17, 14, 16, 52, 533, DateTimeKind.Local).AddTicks(9705), "Bank Strosin, Kessler and Howell", new DateTime(2021, 7, 19, 6, 40, 14, 307, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3cf97c1c-cc43-4eb5-8f13-47b1412204f3"), "Libero aut aut molestiae enim sed voluptate animi est iure.", "3cf02bac-cc43-4965-8ef7-d0ed1db84285", new DateTime(2020, 4, 28, 6, 14, 36, 740, DateTimeKind.Local).AddTicks(480), "Bank Torp - Cremin", new DateTime(2022, 6, 12, 22, 27, 58, 600, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d81abab-4ebe-4578-a786-e2cdde7d0c29"), "Tenetur aliquam sequi est eum dolore.", "b12e43fa-7ca4-4cf2-a98e-95ba5acdfeb9", new DateTime(2021, 1, 3, 1, 16, 22, 614, DateTimeKind.Local).AddTicks(2946), "Bank Zboncak, Ernser and Ryan", new DateTime(2021, 10, 11, 9, 32, 17, 672, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ef214a1-0372-4d6c-9798-cd73405176fb"), "Non ducimus itaque voluptatibus dicta.", "14d84ecd-127d-4abf-b559-8f5bde47649f", new DateTime(2019, 3, 24, 9, 39, 0, 955, DateTimeKind.Local).AddTicks(4448), "Bank Cormier, Dickinson and Powlowski", new DateTime(2022, 4, 10, 21, 19, 35, 603, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3fe07f6c-0e8b-4cc5-8903-ddd06a56fdbb"), "Consequatur recusandae culpa ut eaque.", "618b9947-d4e5-4937-9046-ea1c2744c9a9", new DateTime(2020, 1, 30, 8, 44, 46, 277, DateTimeKind.Local).AddTicks(3585), "Bank Volkman, Dietrich and Cremin", new DateTime(2020, 2, 15, 13, 20, 2, 532, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41e5076c-fc5d-46c1-9b8b-f6a7a8b20e59"), "Ad repellendus eaque corporis dolores nihil ducimus nisi aut.", "72eee493-69db-4ad4-8a5b-770af8f8ac80", new DateTime(2017, 9, 6, 9, 46, 16, 692, DateTimeKind.Local).AddTicks(5653), "Bank Sauer and Sons", new DateTime(2020, 9, 17, 12, 38, 18, 634, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42503033-d6df-4fbe-a147-85a6774e1ac9"), "Ipsam blanditiis dolorem et voluptatem mollitia nihil velit autem.", "e912e7a0-9eca-4fce-8486-3f1b78e11682", new DateTime(2019, 11, 6, 18, 16, 20, 178, DateTimeKind.Local).AddTicks(1359), "Bank Heller, Langosh and Murray", new DateTime(2020, 1, 6, 22, 6, 19, 284, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("440019f9-cc71-4dce-8a7a-4d666d6f6092"), "Et qui minima illo quos placeat facere sit sequi atque.", "dd8a5b9b-7053-4e73-81d7-6e969717dc06", new DateTime(2021, 4, 14, 12, 32, 54, 83, DateTimeKind.Local).AddTicks(2641), "Bank Rempel - Leuschke", new DateTime(2021, 11, 1, 12, 13, 37, 222, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4587ca5e-6c7e-4c39-9c12-076af27e2672"), "Inventore nesciunt aliquam possimus explicabo sit blanditiis velit.", "4b83cdf6-ca7c-432a-a819-6179acd91c85", new DateTime(2020, 4, 10, 17, 19, 18, 919, DateTimeKind.Local).AddTicks(3839), "Bank Koch and Sons", new DateTime(2021, 3, 28, 23, 31, 45, 3, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4fa89320-9675-4344-b8e5-0bbcae981cf2"), "Ipsa maxime qui dicta quaerat necessitatibus sunt itaque.", "591a4916-4cd0-4595-9abb-03584c0561a7", new DateTime(2018, 2, 16, 0, 37, 3, 761, DateTimeKind.Local).AddTicks(4960), "Bank Hilpert Inc", new DateTime(2019, 11, 19, 19, 1, 38, 917, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("50aeafc3-e6e8-4079-9316-d93002afa9af"), "Odio veritatis assumenda autem dolor qui nobis.", "58908a23-4159-485f-ab02-af1aa3de48cd", new DateTime(2018, 4, 25, 19, 23, 8, 350, DateTimeKind.Local).AddTicks(7215), "Bank Gutkowski - Bailey", new DateTime(2021, 1, 11, 18, 23, 46, 690, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("51f61b0e-71d6-46ae-a41e-c45b74b202f6"), "Eum eos omnis est est et.", "b59fcc51-00f5-4d23-82ad-d9c0ca8f397e", new DateTime(2018, 4, 8, 15, 14, 53, 884, DateTimeKind.Local).AddTicks(2540), "Bank Beer, Rogahn and Harvey", new DateTime(2021, 1, 11, 7, 31, 20, 229, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52ef80af-c370-4aea-bfc1-2bf483eae3c0"), "Consequatur consequuntur rerum voluptatem quidem neque excepturi officia itaque.", "66479e26-a320-461d-b930-7b1c42f61b91", new DateTime(2021, 4, 24, 12, 14, 24, 792, DateTimeKind.Local).AddTicks(2700), "Bank Howell and Sons", new DateTime(2021, 7, 17, 0, 12, 19, 283, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53d87f14-5983-466e-94ba-dfe137d13505"), "Facilis voluptatem voluptatem reprehenderit neque et.", "49d38713-3953-4c64-a864-b96a2fca9306", new DateTime(2021, 11, 4, 7, 30, 5, 236, DateTimeKind.Local).AddTicks(4918), "Bank Reinger - Buckridge", new DateTime(2022, 3, 22, 22, 36, 56, 301, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("558c0180-cfd0-491b-8136-90251fce8a30"), "Ut quia mollitia ut est est qui aut voluptatem.", "5f2b6137-f9c9-4e47-a9b7-8157d73c032f", new DateTime(2021, 6, 26, 21, 48, 43, 138, DateTimeKind.Local).AddTicks(9824), "Bank Williamson Group", new DateTime(2021, 12, 6, 22, 14, 19, 858, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("583b70db-3910-4cea-83dd-1d7c63b9fab8"), "Aut omnis eveniet quas quasi ut et et aut.", "ee1629c6-e87c-4772-ae8a-983bd45d7d32", new DateTime(2022, 5, 8, 15, 9, 6, 587, DateTimeKind.Local).AddTicks(1199), "Bank Skiles Inc", new DateTime(2022, 6, 11, 3, 13, 12, 583, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("593f4d73-c0fe-4ad5-9e21-2c5ee4b50a89"), "Aut aut hic rerum occaecati suscipit delectus nemo quae.", "4c92b590-d888-4760-b305-bf693d230277", new DateTime(2020, 6, 2, 16, 52, 42, 960, DateTimeKind.Local).AddTicks(2516), "Bank Hoppe - Koss", new DateTime(2021, 1, 1, 18, 5, 44, 393, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c8112a4-8fb3-45a7-be8b-8d49679c0f1c"), "Id harum et et sed ullam quo ut a est.", "ba62298b-3e7a-45dd-8670-8892be1c9aed", new DateTime(2022, 1, 1, 11, 29, 16, 976, DateTimeKind.Local).AddTicks(7446), "Bank Metz, Streich and Glover", new DateTime(2022, 5, 7, 11, 46, 37, 958, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61820260-2818-48cc-b7e7-c1a90fa74d2e"), "Voluptatem sit vitae facilis inventore ut molestiae aut nam.", "19d9c780-c961-408c-8e6b-48fbb164efce", new DateTime(2017, 10, 16, 23, 24, 16, 171, DateTimeKind.Local).AddTicks(9049), "Bank Simonis Group", new DateTime(2019, 1, 7, 21, 58, 12, 290, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("62a338fa-d74a-46af-96df-da1353233d1f"), "Et tenetur architecto officiis qui cumque earum.", "002f4733-9bc3-48a0-88b7-56a7400db2d6", new DateTime(2022, 6, 3, 23, 31, 53, 692, DateTimeKind.Local).AddTicks(9611), "Bank Torphy - Boyle", new DateTime(2022, 6, 15, 22, 51, 10, 907, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71f6fba2-481d-4989-999e-f049fb5452ac"), "Facilis eius sunt soluta repellendus repellendus quisquam.", "242ee4fd-3a1f-46c9-a95e-f0828610294f", new DateTime(2021, 1, 1, 4, 50, 17, 210, DateTimeKind.Local).AddTicks(9380), "Bank Casper, Rosenbaum and Lubowitz", new DateTime(2022, 6, 23, 10, 31, 24, 511, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("752a0750-4dcf-4a16-919a-1bc52109da6a"), "Et dolores sit odit inventore animi dolorum placeat.", "d4284189-f696-45dd-903a-bcac79d3c499", new DateTime(2018, 6, 22, 6, 27, 5, 749, DateTimeKind.Local).AddTicks(3122), "Bank Schowalter Inc", new DateTime(2019, 5, 24, 8, 39, 37, 788, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("76c98e64-ccf1-48e9-9ccf-5fde22a0e1cc"), "Architecto ducimus architecto.", "dac8ac94-22ae-4bb0-86dd-a3554c351432", new DateTime(2021, 9, 11, 9, 58, 44, 909, DateTimeKind.Local).AddTicks(7270), "Bank Hickle, Schumm and D'Amore", new DateTime(2022, 6, 14, 19, 46, 18, 692, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("78354947-695d-4b67-a220-661e69072989"), "Natus voluptatem eum labore dolores dolores.", "fddd7608-a209-4d68-b827-fe0b98a09855", new DateTime(2017, 7, 12, 19, 21, 5, 270, DateTimeKind.Local).AddTicks(9276), "Bank Kuvalis - Mills", new DateTime(2018, 2, 22, 1, 26, 16, 228, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7a9512d3-4cbe-49c2-bdf4-e03e7acc891a"), "Minus distinctio voluptatibus corrupti.", "5b8ef771-aedf-4abd-bf75-531ba0a0c5d9", new DateTime(2018, 4, 20, 9, 52, 47, 473, DateTimeKind.Local).AddTicks(9253), "Bank Schneider - Botsford", new DateTime(2020, 7, 7, 21, 6, 39, 131, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b0495f9-09b7-4331-9410-41f5b849ce4c"), "Quisquam rerum deleniti sit.", "33b9faae-5221-4372-9e9f-52b728187587", new DateTime(2021, 3, 8, 11, 37, 27, 461, DateTimeKind.Local).AddTicks(9917), "Bank O'Conner, VonRueden and Friesen", new DateTime(2022, 3, 26, 18, 45, 36, 425, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7bc8fcf4-3888-479f-9641-3ee5de37ab36"), "Sint nobis quam non rerum et exercitationem ipsam.", "9c4c4576-3049-4fc0-b99b-ca4d684ee88b", new DateTime(2019, 11, 14, 1, 8, 0, 925, DateTimeKind.Local).AddTicks(177), "Bank Glover Group", new DateTime(2019, 12, 23, 15, 38, 39, 585, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e555be6-78fc-43f1-8a6e-a1e4892a4e00"), "Natus molestiae earum ut officia velit voluptatem vero.", "c8f22ef5-52dd-4ef2-9f8b-cf438355d65e", new DateTime(2020, 7, 6, 6, 34, 9, 404, DateTimeKind.Local).AddTicks(8375), "Bank Upton Group", new DateTime(2021, 11, 6, 14, 50, 44, 980, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86d8e953-27ea-444f-a72f-3c18e004e2e3"), "Rerum qui nesciunt.", "e0e7cf40-3466-41ca-a811-f66bfbbc894e", new DateTime(2020, 3, 8, 0, 33, 56, 953, DateTimeKind.Local).AddTicks(6854), "Bank Jacobs, Wunsch and Satterfield", new DateTime(2020, 11, 3, 22, 58, 47, 19, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c61d703-94f6-4c5d-ab63-f0cf27abf999"), "Assumenda voluptas ratione assumenda voluptatibus voluptas culpa dolorem autem.", "09689986-b1c5-4992-b890-847fc778ce6f", new DateTime(2018, 6, 20, 19, 25, 25, 462, DateTimeKind.Local).AddTicks(9104), "Bank Hilpert, Swift and Hane", new DateTime(2020, 4, 25, 19, 3, 45, 371, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e362a0f-fb9d-4aa2-811e-565ff624515e"), "Incidunt tenetur architecto ducimus est expedita quia earum vel.", "95bdf612-bf10-4a36-92e8-548355ec31e8", new DateTime(2017, 10, 2, 14, 24, 30, 552, DateTimeKind.Local).AddTicks(7416), "Bank Jast LLC", new DateTime(2018, 4, 27, 15, 15, 17, 685, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8fd54f98-ba0e-44b2-b900-75faa11783b0"), "Qui omnis magni non est qui nemo sapiente voluptates molestiae.", "6e6a3f1c-f60a-4789-827d-65826adc2b7c", new DateTime(2018, 12, 13, 6, 16, 50, 369, DateTimeKind.Local).AddTicks(7999), "Bank Reynolds, Anderson and Lowe", new DateTime(2022, 5, 13, 17, 33, 49, 60, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("905fd0b9-cd7b-4a72-a3e8-83645d6d76f4"), "Et earum non sint exercitationem fuga placeat dolores quidem assumenda.", "ecf5a291-f812-4d76-85c2-5875a95fae55", new DateTime(2019, 6, 24, 4, 36, 42, 765, DateTimeKind.Local).AddTicks(6722), "Bank Koss and Sons", new DateTime(2022, 5, 19, 19, 7, 19, 685, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9ef792c2-8bb1-482b-82e6-3b2ba7727474"), "Voluptas qui ex minus eos dolor.", "63236fb6-de4a-4fac-bcc2-a11e5bf2f3e3", new DateTime(2020, 5, 9, 0, 58, 31, 203, DateTimeKind.Local).AddTicks(84), "Bank Tillman - Effertz", new DateTime(2021, 9, 15, 7, 40, 29, 401, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a386d1ed-1591-4a1b-af71-dc94a649fa76"), "Quo nesciunt est soluta deleniti.", "d76fb210-3b5b-4496-8c6c-cf3c6cb6f49d", new DateTime(2020, 12, 4, 14, 59, 36, 129, DateTimeKind.Local).AddTicks(3609), "Bank Rohan - Dietrich", new DateTime(2022, 1, 31, 0, 53, 25, 109, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a404f075-2cb5-446f-8633-77be21026b03"), "Non aut impedit adipisci.", "225d9785-e4a2-433f-839d-f51ae81f1cea", new DateTime(2021, 10, 29, 9, 14, 26, 890, DateTimeKind.Local).AddTicks(2332), "Bank Gleason Group", new DateTime(2022, 6, 29, 11, 31, 48, 943, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a48f7dcd-668f-4ec9-8cdb-f78759bc0b37"), "Quod officiis culpa velit eos id.", "4d37463f-f6f4-4243-ad86-ca24a12f482b", new DateTime(2019, 8, 29, 21, 46, 3, 716, DateTimeKind.Local).AddTicks(7252), "Bank Dare Inc", new DateTime(2022, 5, 31, 14, 57, 48, 815, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6821012-1fb9-4173-8508-6c175e327834"), "Ut facere et nostrum eligendi est voluptas reiciendis perferendis.", "67d5b874-2b0c-44f5-b8ac-b9757be8403a", new DateTime(2020, 11, 3, 16, 14, 56, 131, DateTimeKind.Local).AddTicks(4110), "Bank Rohan - Klein", new DateTime(2022, 5, 16, 9, 31, 7, 123, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a76f07dc-ab53-4837-9ad5-a46ee3399743"), "Adipisci magni quis aut error cupiditate consequuntur.", "7395ad72-876a-4ec8-b3d2-ed8f43baed74", new DateTime(2018, 12, 14, 5, 19, 45, 226, DateTimeKind.Local).AddTicks(4051), "Bank Wehner Inc", new DateTime(2021, 9, 6, 12, 9, 25, 905, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aabec7b8-a51b-41bc-b9cc-9bef532ff27c"), "Est sed minus doloribus quibusdam est inventore libero.", "9ab4da47-f741-4279-b020-dc593bd0f3e3", new DateTime(2020, 1, 14, 19, 26, 27, 551, DateTimeKind.Local).AddTicks(1166), "Bank Reynolds and Sons", new DateTime(2020, 6, 19, 22, 7, 36, 91, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad0210cf-c9a1-497b-bb75-f63415c3cda4"), "Et modi ab non voluptas ipsum sunt dolorum quidem deleniti.", "98675a7f-439e-4cd6-b464-62ea715da0be", new DateTime(2022, 6, 27, 9, 30, 41, 800, DateTimeKind.Local).AddTicks(6607), "Bank Kerluke, Lueilwitz and Kuhlman", new DateTime(2022, 6, 27, 11, 7, 22, 606, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("adb9b2ba-71c7-4e07-9785-cc3fcb4148a1"), "Commodi et consequatur aut quam aspernatur molestias ut.", "0807c1b7-4c58-45a8-b3f0-c39133be88dd", new DateTime(2018, 9, 10, 1, 20, 30, 293, DateTimeKind.Local).AddTicks(9659), "Bank Yost, Blick and VonRueden", new DateTime(2018, 12, 27, 12, 23, 37, 136, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1ef00e4-2c01-4911-af49-26e673354950"), "Voluptatem qui libero repudiandae.", "2e510058-eb3f-45e1-85d4-c80217506d93", new DateTime(2018, 10, 29, 15, 25, 52, 109, DateTimeKind.Local).AddTicks(6590), "Bank Grimes - Heathcote", new DateTime(2021, 7, 27, 8, 47, 43, 205, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b568c633-d8bf-450a-a2c7-2909a86d7cb1"), "Saepe et sint hic velit sed.", "502decd3-f491-4dbf-84e7-8e2899ea82e6", new DateTime(2020, 6, 24, 20, 24, 9, 990, DateTimeKind.Local).AddTicks(8360), "Bank Volkman, O'Conner and Mueller", new DateTime(2020, 11, 22, 21, 3, 41, 209, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b60c29b9-445c-4fbb-92ae-d76a326d0335"), "Nostrum et ullam corporis necessitatibus aut cumque unde.", "b82a5afe-da12-4243-bc2a-3dafb38cf4a1", new DateTime(2022, 3, 26, 0, 14, 34, 381, DateTimeKind.Local).AddTicks(913), "Bank Abbott Group", new DateTime(2022, 4, 5, 5, 22, 18, 256, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8a1b680-ce7e-45cb-b8d3-1d53cfae6ae9"), "Aut tenetur qui qui reiciendis non aut ut ipsa.", "3d363b1a-a29d-41ac-b71f-970eec163745", new DateTime(2021, 2, 27, 21, 37, 16, 793, DateTimeKind.Local).AddTicks(2133), "Bank Kutch Group", new DateTime(2021, 9, 11, 14, 50, 56, 723, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb258edb-70bd-4c2e-aa22-4027178a73f1"), "Non et maxime qui minima similique ut quia.", "b0f99893-4f3c-4913-8119-cfc540c54e3a", new DateTime(2018, 8, 31, 0, 49, 17, 418, DateTimeKind.Local).AddTicks(983), "Bank Cole Group", new DateTime(2020, 9, 21, 8, 57, 2, 332, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc0d4c7b-52d1-47be-96d0-014f652f303e"), "Ex iure adipisci optio itaque impedit earum tempore et.", "2c7a7efa-5d26-459a-ac58-61ed7c2c0f10", new DateTime(2017, 9, 6, 12, 25, 0, 782, DateTimeKind.Local).AddTicks(7490), "Bank Jenkins, Becker and Lang", new DateTime(2021, 10, 7, 18, 37, 6, 635, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bceec2c6-d60c-4c54-a3d3-2126560b7bd6"), "Praesentium quasi ut.", "a0af831d-ebe2-409c-8104-02730222f28a", new DateTime(2017, 10, 21, 23, 10, 4, 260, DateTimeKind.Local).AddTicks(9711), "Bank Weimann, Herman and Witting", new DateTime(2018, 11, 29, 0, 20, 41, 363, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdab7dd3-b25a-40a7-b503-6c618816c7cf"), "Voluptas dolores beatae iusto atque enim.", "88543e1c-fadc-4eb2-b62c-78e133e543c8", new DateTime(2022, 6, 23, 5, 42, 38, 299, DateTimeKind.Local).AddTicks(7178), "Bank Towne Group", new DateTime(2022, 7, 3, 20, 10, 35, 333, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bddaeaf0-e43e-49bc-a0f1-1db221abff60"), "Quod velit maiores qui.", "145b4a94-47e3-4904-923b-d585bc0e1aa1", new DateTime(2018, 9, 13, 22, 4, 25, 428, DateTimeKind.Local).AddTicks(6908), "Bank Casper Inc", new DateTime(2019, 9, 7, 23, 39, 47, 261, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bffcf831-af44-42c3-8f2d-a1c7d5f17190"), "Qui accusantium eligendi repellendus aut repudiandae numquam dolores aut.", "31182096-d3e9-49eb-aeb6-b763a36c0d3a", new DateTime(2019, 2, 7, 3, 18, 53, 719, DateTimeKind.Local).AddTicks(6165), "Bank Okuneva - Wilderman", new DateTime(2019, 5, 8, 1, 20, 13, 878, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7053942-6d7a-4e86-9b53-c13c7452b0ba"), "Et autem qui repudiandae officiis pariatur sit eum ducimus eveniet.", "0b6cb684-bd13-4359-914c-9ff56efa199a", new DateTime(2022, 3, 26, 17, 51, 37, 115, DateTimeKind.Local).AddTicks(3935), "Bank Fahey Inc", new DateTime(2022, 6, 13, 16, 40, 18, 878, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7d098a3-0df8-4552-ade5-44c34ea8e3a4"), "Autem culpa dolores.", "5655301f-d344-4528-ab4f-234ed54a5179", new DateTime(2018, 3, 7, 18, 40, 51, 39, DateTimeKind.Local).AddTicks(7534), "Bank Erdman - Mayert", new DateTime(2020, 8, 23, 8, 33, 48, 271, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ca822eb8-750d-4a5c-8537-3dba5980fcdc"), "Ea illo et nemo ut accusantium sint rerum dolor deleniti.", "7334ab98-3c22-4a77-8302-3cc8ac97ee50", new DateTime(2020, 4, 21, 1, 6, 7, 998, DateTimeKind.Local).AddTicks(3282), "Bank Brown - Predovic", new DateTime(2020, 7, 20, 22, 9, 15, 194, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cb5a38dd-b441-4baa-a39c-8a7123075cd2"), "Asperiores doloribus nostrum voluptates possimus.", "1fcd6919-fb2c-4c85-9377-3095831b975c", new DateTime(2018, 10, 6, 13, 44, 18, 191, DateTimeKind.Local).AddTicks(2066), "Bank Price - Veum", new DateTime(2021, 1, 31, 18, 54, 48, 17, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cccab50b-aea6-4e31-a8bc-257dfb83c470"), "Aliquam est qui aut amet.", "186da506-4c64-4d45-9295-2cf247d322e5", new DateTime(2021, 9, 1, 16, 42, 59, 927, DateTimeKind.Local).AddTicks(1434), "Bank Bode Group", new DateTime(2022, 5, 22, 11, 28, 20, 980, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd9a192d-826d-4fa0-86c7-8dab68e3184c"), "Nam qui aliquam in.", "8bb85503-e22d-4868-8ec0-008d126dfd57", new DateTime(2022, 3, 5, 15, 16, 17, 435, DateTimeKind.Local).AddTicks(4883), "Bank Weimann - Rath", new DateTime(2022, 6, 2, 10, 47, 17, 6, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ce559323-5a9e-44a0-8dca-a4bfb1341ba2"), "A veritatis eos aut repellat molestiae dignissimos.", "7dcc93db-30c9-4add-b6e6-6766cedb0434", new DateTime(2020, 3, 21, 15, 57, 48, 328, DateTimeKind.Local).AddTicks(829), "Bank Deckow - Boyer", new DateTime(2021, 1, 5, 8, 8, 34, 419, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ceba447f-ed35-4ec6-8d14-8bc726af619d"), "Quia dolorem modi recusandae sunt et.", "47bb231c-be22-4cc9-b56d-ad13c6fe2c9d", new DateTime(2018, 6, 22, 19, 55, 52, 698, DateTimeKind.Local).AddTicks(6756), "Bank Reilly - Koch", new DateTime(2022, 4, 22, 15, 8, 23, 62, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dbbc67fd-2727-4c00-9698-8f54950f8ddc"), "Qui veritatis sequi eum consequuntur iusto pariatur.", "d580d0a5-ca07-4761-9962-c3d4a12de8d5", new DateTime(2019, 6, 28, 17, 40, 30, 805, DateTimeKind.Local).AddTicks(2644), "Bank Hessel Group", new DateTime(2020, 5, 22, 15, 13, 22, 901, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de4aae89-64fd-4442-a53e-8512fa9bb251"), "Architecto aut quia.", "960c25b6-0187-4482-bf93-350c1fd00372", new DateTime(2019, 11, 6, 8, 3, 40, 358, DateTimeKind.Local).AddTicks(9612), "Bank Johnson, Mann and Hyatt", new DateTime(2019, 11, 6, 12, 54, 18, 945, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df5b1ad0-45e9-4b00-bd47-8a2774cac511"), "Dolorum perferendis modi sapiente.", "7d2e42fb-1e10-44e2-9a12-ee8c8bacb765", new DateTime(2021, 1, 31, 19, 59, 31, 279, DateTimeKind.Local).AddTicks(8786), "Bank Schuppe, Koch and Ankunding", new DateTime(2022, 2, 12, 23, 39, 22, 366, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df8e1184-31f4-4e2b-bd67-213b56ecebfd"), "Dolore nisi mollitia aliquid ut perspiciatis.", "69ecf79d-d2e6-44c0-9edb-3752666e5342", new DateTime(2018, 7, 24, 10, 43, 35, 998, DateTimeKind.Local).AddTicks(1802), "Bank Thompson, Gaylord and Swaniawski", new DateTime(2021, 12, 12, 19, 17, 12, 388, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e376282c-f513-4f8c-a3a6-6b3be4469fb2"), "Aspernatur et qui voluptate sit consequatur quos quod.", "a402428c-e074-4654-986e-6952387de31c", new DateTime(2019, 5, 19, 7, 36, 50, 146, DateTimeKind.Local).AddTicks(6504), "Bank Dicki, Becker and Dibbert", new DateTime(2021, 4, 26, 17, 18, 37, 881, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e484eca3-1abf-4f93-be4f-9785cbe93787"), "Magni aspernatur laboriosam suscipit culpa.", "a5472421-e0dd-479b-85d4-a9808ff9d613", new DateTime(2019, 9, 14, 8, 37, 14, 580, DateTimeKind.Local).AddTicks(6848), "Bank Ortiz - Bins", new DateTime(2022, 6, 1, 10, 18, 35, 912, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e95d24aa-70df-4581-af4a-5a35b6d11e24"), "Voluptas pariatur dolorem et.", "9832ac7b-df38-4555-9eb9-c7dac5931869", new DateTime(2020, 9, 11, 16, 49, 32, 949, DateTimeKind.Local).AddTicks(505), "Bank McGlynn and Sons", new DateTime(2022, 4, 23, 17, 42, 30, 852, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eadc2123-4d3d-47d4-824a-77554b9f8fd8"), "Enim dignissimos porro sunt occaecati.", "2a8c015e-c8ec-40ab-9429-3828fcf44f91", new DateTime(2022, 1, 18, 22, 27, 29, 686, DateTimeKind.Local).AddTicks(7376), "Bank Grady - Schmitt", new DateTime(2022, 7, 1, 12, 29, 7, 873, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec828fce-03ab-42bd-88ec-f37a9511c006"), "Odit neque ipsa eaque fuga et.", "24c96db8-71ef-4d5c-a28b-9ef94bce21e4", new DateTime(2020, 4, 3, 1, 27, 13, 316, DateTimeKind.Local).AddTicks(7256), "Bank Strosin, Littel and Feest", new DateTime(2021, 1, 29, 3, 39, 39, 402, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f106b25a-0e63-4a80-8cdc-eed1f712786f"), "Neque provident vel aut sunt tenetur laudantium qui.", "e381a018-194b-40a5-82c5-67a8db883365", new DateTime(2020, 12, 21, 2, 7, 6, 245, DateTimeKind.Local).AddTicks(6845), "Bank Jast Group", new DateTime(2021, 10, 5, 19, 38, 38, 102, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f107437f-0691-4fd2-9035-7e59453fcc37"), "Aut doloribus dolorem id praesentium eum praesentium.", "324e2cff-df14-4c2f-a541-868eaeb7f8a5", new DateTime(2021, 6, 7, 9, 3, 42, 498, DateTimeKind.Local).AddTicks(2479), "Bank Bartell Inc", new DateTime(2021, 7, 27, 19, 51, 8, 996, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f16acdc6-fb97-48ba-9afb-3499cbabc36d"), "Quia at libero consectetur voluptas voluptatum.", "6e77176e-97d3-42a3-92ea-57d012fc7974", new DateTime(2021, 9, 13, 23, 6, 9, 895, DateTimeKind.Local).AddTicks(1204), "Bank Bogisich, Wolff and Brakus", new DateTime(2022, 5, 23, 17, 1, 44, 158, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f64333cd-5362-4979-b1d3-f38044e14ff0"), "Consequuntur similique eius optio temporibus voluptatem et et quo architecto.", "6d6d312e-5ebf-4a1b-a074-c760382c03bf", new DateTime(2018, 10, 26, 5, 32, 29, 828, DateTimeKind.Local).AddTicks(7817), "Bank Heathcote Inc", new DateTime(2020, 11, 27, 2, 58, 56, 773, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb595329-0819-40f6-a565-020bcbbc660f"), "Qui sapiente delectus consequatur non iste molestias ea adipisci.", "348efe24-b505-486b-838c-17e4ca03dac9", new DateTime(2020, 4, 10, 23, 0, 42, 463, DateTimeKind.Local).AddTicks(7478), "Bank Runolfsson - Lowe", new DateTime(2022, 1, 2, 20, 2, 8, 162, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb6ec15d-6cd0-475d-a980-bf0326db923b"), "Facere et ut magnam rerum velit neque eos.", "98bd708e-5341-4f82-998d-68fce095db1c", new DateTime(2020, 12, 23, 12, 43, 31, 352, DateTimeKind.Local).AddTicks(3329), "Bank Pfeffer, Simonis and Doyle", new DateTime(2021, 1, 30, 1, 5, 19, 128, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fd0ecccb-7857-4260-9cc8-1be3fdb57e8d"), "Numquam qui modi quasi reiciendis.", "13dd60dd-c909-48a3-9e6c-307ec3320160", new DateTime(2019, 1, 5, 9, 33, 18, 473, DateTimeKind.Local).AddTicks(4104), "Bank Larkin - Klein", new DateTime(2020, 4, 10, 22, 34, 9, 95, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("00d77616-26e1-4995-9eab-53e59f6f10d2"), "Impedit sit nesciunt numquam exercitationem laborum debitis.", "b87597fe-9d10-418a-8d51-7aab1f04e3ab", new DateTime(2022, 3, 15, 15, 26, 0, 903, DateTimeKind.Local).AddTicks(598), "Cash desk: accusantium", new DateTime(2022, 5, 3, 11, 31, 57, 593, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("030097b7-fda9-4b25-bd7a-48a86a8ab379"), "Facilis ea enim cumque dolor ea magni.", "7c2cf59a-bedd-45d3-8d3f-504fd00cbdd6", new DateTime(2017, 9, 25, 10, 48, 2, 557, DateTimeKind.Local).AddTicks(5804), "Cash desk: repudiandae", new DateTime(2018, 6, 15, 19, 36, 26, 619, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05a787c9-6ce6-4f1a-9f3f-e61230b68962"), "Quo ut at fuga earum in magni in adipisci veritatis.", "0857f6ea-141e-4e1a-a16f-67aba95fbf06", new DateTime(2018, 8, 23, 18, 14, 39, 769, DateTimeKind.Local).AddTicks(452), "Cash desk: enim", new DateTime(2021, 12, 26, 0, 38, 38, 878, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a3a9aff-d5cc-4775-82e5-a775f949f949"), "Dolorem voluptatum et libero eius qui.", "a75aaf2f-96f3-4462-a523-66a3255fe3a0", new DateTime(2018, 12, 25, 21, 13, 39, 612, DateTimeKind.Local).AddTicks(494), "Cash desk: est", new DateTime(2021, 10, 29, 6, 18, 29, 554, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0bac4864-7b89-4639-983a-c6b0b37acd27"), "Laborum ut molestiae ducimus dolores ad.", "54451045-1fb7-4b39-be1d-b22036c0364a", new DateTime(2019, 10, 9, 22, 30, 5, 438, DateTimeKind.Local).AddTicks(5783), "Cash desk: ea", new DateTime(2022, 2, 12, 14, 48, 50, 274, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1053a005-1fce-4429-b7de-99c492f7f4f6"), "Et nesciunt voluptas pariatur reprehenderit aliquam repellat.", "380faf3d-3ef9-4f44-a313-ab322e81ac5b", new DateTime(2018, 6, 17, 13, 40, 50, 150, DateTimeKind.Local).AddTicks(894), "Cash desk: et", new DateTime(2021, 9, 19, 15, 24, 37, 428, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("10e9cb66-9678-4fcf-99cc-32ee8c7c5ea5"), "Voluptatem reiciendis dolorem aliquam ad impedit consequatur aliquam.", "c6a18630-5ac8-472c-baf4-25538235db93", new DateTime(2021, 2, 23, 13, 6, 28, 174, DateTimeKind.Local).AddTicks(5167), "Cash desk: neque", new DateTime(2022, 1, 12, 15, 39, 36, 357, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11871dd2-5416-49ed-9d32-574a24aaca2e"), "Et occaecati ea non enim eius et atque eaque sit.", "d588a285-0610-429d-9f51-8a4a29958b84", new DateTime(2017, 9, 30, 20, 34, 29, 152, DateTimeKind.Local).AddTicks(4529), "Cash desk: voluptatem", new DateTime(2019, 1, 3, 16, 46, 24, 939, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1400ec52-fe1f-4a92-95f4-2b0a5662f020"), "Corrupti nihil optio nemo aut.", "ade18d90-0fed-4e9a-ae11-5c600e148917", new DateTime(2018, 4, 8, 6, 12, 14, 183, DateTimeKind.Local).AddTicks(9624), "Cash desk: modi", new DateTime(2019, 10, 22, 2, 20, 25, 932, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c414d9a-4a90-47d5-8de5-a001c5c44a19"), "Alias unde aut.", "66fa0b85-b948-4011-9992-f3f633b00061", new DateTime(2018, 10, 30, 20, 19, 7, 290, DateTimeKind.Local).AddTicks(6113), "Cash desk: et", new DateTime(2020, 4, 28, 22, 41, 45, 119, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23c6787f-7715-4142-8038-c09f3ee41240"), "Saepe officiis dolore quibusdam iste ab ea omnis voluptas dignissimos.", "df4ef609-695e-4d93-85f0-a48c5f3bf117", new DateTime(2022, 5, 22, 23, 34, 46, 675, DateTimeKind.Local).AddTicks(3260), "Cash desk: molestias", new DateTime(2022, 7, 6, 0, 30, 31, 465, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2580434e-d6c5-47ff-9493-ee280d1a1d47"), "Sint est et a voluptatem sint beatae.", "dd80e06f-c787-4713-877a-4d08b2db624d", new DateTime(2020, 2, 17, 23, 21, 52, 909, DateTimeKind.Local).AddTicks(8335), "Cash desk: quos", new DateTime(2021, 2, 20, 15, 22, 12, 283, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26c848f7-b135-48d4-b822-1e008f94415a"), "Quo labore quibusdam sunt molestiae delectus.", "ad73a792-b966-4089-90c0-8cc8677bc2aa", new DateTime(2019, 11, 26, 16, 17, 43, 405, DateTimeKind.Local).AddTicks(8232), "Cash desk: quia", new DateTime(2022, 1, 15, 23, 0, 12, 108, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("283d52f0-f197-42cf-b678-afc6eeb9ed10"), "Doloribus sit sunt.", "4fdf52c9-3d5b-4b88-8b98-e3b8419222ff", new DateTime(2022, 5, 21, 4, 6, 46, 775, DateTimeKind.Local).AddTicks(941), "Cash desk: explicabo", new DateTime(2022, 5, 22, 2, 26, 51, 808, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2c8fdf56-5dac-4179-932e-00433270bad4"), "Eos quas similique nihil.", "28fc4663-0dc8-4285-9243-33c250dcb0e3", new DateTime(2020, 6, 17, 20, 36, 15, 412, DateTimeKind.Local).AddTicks(7070), "Cash desk: nisi", new DateTime(2021, 12, 4, 1, 1, 17, 58, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f9dca21-9201-47e9-b6d0-acf4dd8e9e33"), "Quis sed aut veritatis quasi velit.", "90ddb79b-7ba6-44eb-9960-880e5271df89", new DateTime(2018, 8, 1, 13, 43, 30, 494, DateTimeKind.Local).AddTicks(5739), "Cash desk: nam", new DateTime(2020, 2, 27, 19, 38, 56, 185, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3072e453-1e55-4011-9bea-5c638058ee6c"), "Ut consectetur odio expedita ad voluptatem qui dolor corporis nihil.", "a30b4066-f3b2-4011-9d4a-5cd377a19822", new DateTime(2021, 11, 28, 1, 36, 39, 953, DateTimeKind.Local).AddTicks(4503), "Cash desk: quae", new DateTime(2022, 5, 20, 0, 18, 42, 568, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30fe938f-37c9-4c75-ad65-ae986bbbeb6d"), "Fuga eligendi dolor qui corporis.", "836d42fe-93ee-4100-b92e-1550ed1466b8", new DateTime(2022, 6, 2, 18, 6, 57, 947, DateTimeKind.Local).AddTicks(2806), "Cash desk: aut", new DateTime(2022, 7, 6, 23, 15, 49, 15, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("334641be-ffb8-4c29-8e77-23e402cf08b8"), "Aspernatur ipsam est doloribus molestiae aliquam.", "0659d573-917e-401b-b963-904b53ec491c", new DateTime(2021, 4, 27, 13, 16, 18, 477, DateTimeKind.Local).AddTicks(2667), "Cash desk: tempora", new DateTime(2022, 4, 1, 13, 4, 56, 970, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("357f8229-cd20-4c4e-a426-5c0ad8310095"), "Aut asperiores velit aspernatur commodi rerum accusantium expedita.", "96ec0026-057c-4253-85eb-17accf55263e", new DateTime(2018, 1, 31, 23, 19, 59, 168, DateTimeKind.Local).AddTicks(2912), "Cash desk: autem", new DateTime(2021, 9, 3, 21, 36, 11, 340, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35f0bb7c-ceea-4c56-8e96-d3d0036daac3"), "Veniam quia asperiores fuga aut voluptas.", "28e23fe3-7b50-4fb7-8e89-c1d044cb51ad", new DateTime(2020, 8, 27, 5, 0, 10, 462, DateTimeKind.Local).AddTicks(936), "Cash desk: et", new DateTime(2020, 12, 16, 6, 50, 13, 911, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3acd3301-fdcd-461f-a5cb-88c362396aaf"), "Aut incidunt nam et ipsam.", "74e107bf-f333-44d4-bce7-797fb7b1d042", new DateTime(2017, 8, 20, 19, 33, 4, 824, DateTimeKind.Local).AddTicks(6918), "Cash desk: ea", new DateTime(2021, 4, 14, 15, 0, 34, 187, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3cee0448-82e1-4122-a4d2-16fc55c2b5c8"), "Voluptatem nam rerum velit blanditiis id autem et labore recusandae.", "fe6403bc-72d8-467c-8bc5-37750e1929bd", new DateTime(2022, 1, 7, 4, 38, 55, 274, DateTimeKind.Local).AddTicks(3654), "Cash desk: autem", new DateTime(2022, 4, 13, 1, 43, 7, 487, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ebd5ffe-83e7-4239-86dd-1876fab7a587"), "Aspernatur repudiandae aut sapiente vero quo modi id blanditiis.", "2846b9ed-9a03-48ef-a766-95ed7adaed45", new DateTime(2019, 6, 30, 19, 18, 44, 675, DateTimeKind.Local).AddTicks(8176), "Cash desk: aspernatur", new DateTime(2019, 7, 15, 11, 15, 3, 704, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4521bfb5-961b-4b34-b4a1-305a2b48e54f"), "Voluptas aut itaque nulla libero sunt delectus explicabo.", "ad73b3c3-2b38-48ee-9f60-9e81510e5395", new DateTime(2019, 3, 30, 2, 47, 54, 129, DateTimeKind.Local).AddTicks(2679), "Cash desk: autem", new DateTime(2022, 6, 26, 18, 54, 51, 656, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("456d8f21-1dd2-4aed-92fb-5d386b17b9e2"), "Nisi nulla inventore rerum et et magni ut nostrum.", "7393518d-6884-4b15-b01d-3aff5b5da7da", new DateTime(2020, 7, 25, 14, 19, 23, 965, DateTimeKind.Local).AddTicks(7733), "Cash desk: autem", new DateTime(2022, 5, 15, 11, 52, 38, 711, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("462484a6-1070-40c9-8d4b-b2b703a987ad"), "Distinctio deserunt praesentium est quaerat possimus enim.", "b36a6ffc-6992-4731-81f9-a6aeb9abde81", new DateTime(2019, 9, 22, 7, 11, 38, 912, DateTimeKind.Local).AddTicks(253), "Cash desk: delectus", new DateTime(2020, 2, 14, 5, 27, 40, 710, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4827aa77-d267-4ecd-b25a-c56181adedba"), "Soluta saepe occaecati adipisci velit voluptates corporis.", "e4ecd398-f46b-4018-83bf-bd154d52f156", new DateTime(2019, 2, 18, 11, 24, 13, 983, DateTimeKind.Local).AddTicks(642), "Cash desk: eveniet", new DateTime(2019, 11, 29, 17, 45, 25, 538, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4922e559-f373-415f-8663-6a0e5fcfe948"), "Pariatur labore provident accusantium eum.", "41b4d3c6-aa2c-416c-b78b-c5a14f946648", new DateTime(2022, 5, 28, 13, 2, 31, 177, DateTimeKind.Local).AddTicks(7021), "Cash desk: blanditiis", new DateTime(2022, 6, 19, 4, 49, 44, 746, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("492f5a29-8fbe-43c0-87e6-d0a5fa89be28"), "Qui voluptatem sit qui quia est error voluptas et ad.", "3c16ab31-ad81-4387-a31e-027e31fac677", new DateTime(2017, 7, 21, 17, 1, 21, 133, DateTimeKind.Local).AddTicks(2427), "Cash desk: ut", new DateTime(2020, 7, 27, 19, 45, 51, 23, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e9dc065-a00e-41eb-8946-69cffc46c1c7"), "Autem et molestiae et et possimus rerum.", "c47b33a7-9244-4b7a-b555-fb4c584ea624", new DateTime(2019, 2, 5, 4, 7, 41, 768, DateTimeKind.Local).AddTicks(2961), "Cash desk: alias", new DateTime(2022, 6, 20, 10, 4, 58, 772, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("512c4af2-e04d-4231-ab1b-fe814b86adff"), "Maiores numquam sed occaecati sequi et at omnis consequatur.", "b40c6b58-2c8a-4c43-82ed-b6da7083f655", new DateTime(2018, 2, 15, 5, 24, 29, 72, DateTimeKind.Local).AddTicks(662), "Cash desk: et", new DateTime(2020, 10, 5, 2, 36, 43, 841, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52879aa0-dff0-4aa9-8a68-35d1a646ef9a"), "Iure incidunt voluptas porro amet omnis dolorem molestiae voluptas.", "6d45ca26-1e4e-4833-8737-ab16438939e5", new DateTime(2021, 2, 9, 14, 34, 44, 832, DateTimeKind.Local).AddTicks(8682), "Cash desk: veniam", new DateTime(2021, 10, 18, 14, 26, 5, 451, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52d96b4e-af57-4380-888a-51e35fbe479f"), "Voluptatum quia blanditiis.", "4e662480-08b1-4359-9259-3b40d99530e7", new DateTime(2021, 7, 10, 15, 50, 37, 714, DateTimeKind.Local).AddTicks(8825), "Cash desk: ut", new DateTime(2022, 6, 16, 14, 43, 56, 484, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55a654ae-7c50-4794-b73f-245e16a2a9bf"), "Quis quidem est beatae nemo sit.", "8511650c-6ffb-453b-8e3b-d3ee6e0aaf27", new DateTime(2021, 6, 13, 21, 53, 57, 299, DateTimeKind.Local).AddTicks(1836), "Cash desk: deserunt", new DateTime(2022, 3, 3, 16, 19, 37, 62, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b0f7695-cf58-46c6-b30c-214f674170e6"), "Blanditiis minima et optio quod eius consequuntur minus.", "09657ee1-b883-4c3c-b46f-196adffc7f1f", new DateTime(2018, 3, 19, 23, 56, 10, 569, DateTimeKind.Local).AddTicks(1009), "Cash desk: nemo", new DateTime(2022, 3, 12, 14, 6, 27, 401, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6418a80c-c45b-487b-b9ab-eb12dd561a03"), "Dolor mollitia est sed molestiae.", "3badaf92-c61a-4ee9-8b80-7a5546287bf5", new DateTime(2021, 2, 14, 15, 27, 15, 114, DateTimeKind.Local).AddTicks(6227), "Cash desk: laboriosam", new DateTime(2022, 5, 12, 20, 59, 20, 703, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65784199-f248-4bed-8eea-95e79b778411"), "Culpa veniam magnam adipisci dicta dolorum.", "3a021568-b8f2-4e7b-8cbe-427b3d899b66", new DateTime(2018, 5, 24, 15, 29, 42, 357, DateTimeKind.Local).AddTicks(978), "Cash desk: qui", new DateTime(2021, 3, 10, 13, 10, 29, 690, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("658d6d64-46f0-4296-908b-c54ecacbfefd"), "Et corporis enim ut sequi repudiandae atque.", "37b76880-089b-4edc-840f-78f0c236f3ae", new DateTime(2020, 7, 31, 11, 6, 43, 717, DateTimeKind.Local).AddTicks(4740), "Cash desk: vel", new DateTime(2021, 12, 7, 6, 13, 3, 643, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("659cf74b-3249-4d75-bb34-e96e6357c1dd"), "Error debitis cumque quae.", "8c643ed1-029a-4a99-8ef8-ebcd30808f13", new DateTime(2020, 6, 24, 13, 52, 11, 701, DateTimeKind.Local).AddTicks(1658), "Cash desk: odit", new DateTime(2021, 7, 17, 12, 44, 44, 183, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a3784ca-030a-404a-bbb5-b01bf0c63ae7"), "Iusto molestias aliquam.", "9319ef5a-69af-4059-a7b4-f05a887ff5cd", new DateTime(2018, 2, 19, 6, 59, 46, 687, DateTimeKind.Local).AddTicks(8484), "Cash desk: et", new DateTime(2022, 5, 31, 2, 53, 35, 748, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6f2ee9aa-547c-4d82-81f3-981079f21d60"), "Iusto dolor aut et aut itaque et id aut consequatur.", "08ae6708-7c18-4390-82dd-a2a2b0915371", new DateTime(2018, 6, 6, 2, 20, 6, 887, DateTimeKind.Local).AddTicks(4991), "Cash desk: et", new DateTime(2019, 5, 8, 14, 49, 9, 787, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("70430dba-2b32-44ec-bedd-7cadbe396390"), "Molestias vitae animi ut dolorem aut architecto reprehenderit quidem sed.", "400aa62c-75c6-4d25-8f46-2689c5a8571a", new DateTime(2019, 1, 11, 8, 51, 0, 638, DateTimeKind.Local).AddTicks(8224), "Cash desk: corporis", new DateTime(2020, 4, 1, 3, 19, 50, 238, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75dabc5c-3cf8-448c-b867-5b31e563e940"), "Qui qui impedit molestiae modi.", "356c5edf-b5ec-4d23-8172-2a8b2cb734fe", new DateTime(2019, 11, 4, 5, 0, 59, 872, DateTimeKind.Local).AddTicks(8550), "Cash desk: ab", new DateTime(2022, 3, 29, 22, 13, 16, 131, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77db7346-4382-450b-a9a0-3c3e96cecf82"), "Iusto officia facere voluptatem tenetur veniam aut nisi consequatur culpa.", "5654d0ba-b0b6-4e9e-847b-cc47ca50a508", new DateTime(2020, 10, 16, 3, 48, 11, 488, DateTimeKind.Local).AddTicks(1815), "Cash desk: aliquid", new DateTime(2022, 5, 12, 9, 27, 37, 801, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("780aa3b6-d654-426f-a701-ceb21921041b"), "Rerum repellat dolorem dolorem quos repellat assumenda.", "9ebbc0d4-363a-49b2-a8e9-00531e95d57c", new DateTime(2019, 3, 22, 18, 46, 25, 893, DateTimeKind.Local).AddTicks(5694), "Cash desk: quia", new DateTime(2020, 1, 27, 3, 43, 14, 159, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7a023cf8-dd4d-44f8-9818-64f2245457b2"), "Consectetur quia dignissimos vel voluptatum possimus inventore.", "2861af67-44c8-42f2-93d8-44d08fc9b05c", new DateTime(2017, 11, 3, 1, 39, 7, 264, DateTimeKind.Local).AddTicks(8409), "Cash desk: suscipit", new DateTime(2018, 4, 27, 18, 9, 5, 793, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7cc63838-af01-484e-8403-490f087a4e71"), "Numquam eum ipsum dolorum veniam molestiae id dolorem quae.", "c6b7d1da-b675-4956-b1bf-2020ac260bc0", new DateTime(2019, 4, 16, 18, 19, 7, 894, DateTimeKind.Local).AddTicks(4933), "Cash desk: ut", new DateTime(2020, 2, 13, 5, 33, 40, 645, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("800a70e3-1ccb-4591-b1b6-48e08999bf01"), "Illum nesciunt non hic debitis.", "f5d855f9-e1ab-4e4d-8c03-4c0cf0a33b8c", new DateTime(2021, 5, 3, 7, 30, 9, 288, DateTimeKind.Local).AddTicks(7301), "Cash desk: at", new DateTime(2021, 9, 22, 19, 31, 2, 920, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("83f79734-95a9-4982-9884-0051d6df9130"), "Incidunt ullam voluptatibus reprehenderit qui molestias voluptatum consectetur ad incidunt.", "840c0773-b906-46e0-9b09-0466e8987c3b", new DateTime(2019, 8, 3, 1, 1, 35, 491, DateTimeKind.Local).AddTicks(8754), "Cash desk: animi", new DateTime(2020, 7, 22, 18, 48, 52, 221, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8622b673-2daf-41cf-8292-f85d4e9001a9"), "Repudiandae harum reprehenderit odio et mollitia veritatis sed non.", "46dd13f8-9acb-4497-89d3-6401d8bf04c7", new DateTime(2020, 12, 13, 8, 24, 55, 122, DateTimeKind.Local).AddTicks(468), "Cash desk: voluptatum", new DateTime(2021, 9, 27, 5, 59, 40, 109, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("87dba5bd-13a4-499b-939b-4089e24a34e4"), "Repellendus voluptas vel.", "9e4d6aa2-5ad3-4be9-8bb0-b39522e2dbc8", new DateTime(2018, 10, 9, 4, 48, 11, 889, DateTimeKind.Local).AddTicks(7052), "Cash desk: et", new DateTime(2019, 11, 5, 6, 10, 51, 950, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("881c5b95-c70d-440c-a4ab-639c21d51cfe"), "Eius consequatur ut quo omnis maiores et repellendus suscipit eligendi.", "33a5f3a1-615d-4d0a-8330-182905e37e87", new DateTime(2021, 2, 5, 18, 12, 59, 463, DateTimeKind.Local).AddTicks(4510), "Cash desk: officiis", new DateTime(2021, 12, 20, 0, 27, 20, 704, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("895e63e9-4051-42a5-bda0-60dc4c3c482e"), "Et reiciendis ut dolor repellat odio possimus saepe dolorem occaecati.", "4b889dfb-d6c1-4bf1-a9e6-9ce2bf42590f", new DateTime(2018, 2, 10, 3, 34, 28, 978, DateTimeKind.Local).AddTicks(8773), "Cash desk: unde", new DateTime(2021, 5, 20, 15, 5, 15, 766, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89b61f30-b040-49f9-a2f3-b66f169e4af5"), "Aperiam repudiandae rerum quaerat odit non.", "235f499f-07ce-4877-aeac-0278a48ed057", new DateTime(2022, 3, 7, 20, 31, 11, 26, DateTimeKind.Local).AddTicks(8043), "Cash desk: rerum", new DateTime(2022, 3, 19, 22, 28, 11, 797, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91d2e1e4-0534-482b-9e35-308ab7e725ff"), "Deleniti error nobis et non ipsa officiis aut.", "84e9b1df-f6dc-40ff-a324-064dc7e4d21f", new DateTime(2017, 7, 24, 1, 15, 57, 731, DateTimeKind.Local).AddTicks(9169), "Cash desk: cupiditate", new DateTime(2019, 5, 30, 18, 48, 8, 304, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("948e626a-39d2-41c8-94e9-522a617feba3"), "Ut maiores rerum molestias.", "d4eb707b-c79e-431e-a4d1-97680f438501", new DateTime(2020, 10, 10, 20, 3, 32, 83, DateTimeKind.Local).AddTicks(4745), "Cash desk: molestiae", new DateTime(2021, 4, 22, 0, 19, 41, 185, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94de4902-a147-4c27-99ec-9635aef9ac9c"), "Quo quo eligendi inventore beatae quo aperiam quos totam.", "0e224d39-98bd-4da8-9f6c-b24e961d025d", new DateTime(2019, 4, 19, 15, 27, 23, 68, DateTimeKind.Local).AddTicks(9408), "Cash desk: quia", new DateTime(2022, 2, 13, 11, 39, 40, 317, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9847583f-b1db-4cac-a71b-558d05a8dc68"), "Alias nihil velit et.", "253708d5-8cc2-4a87-9b18-d20d3a3a9b50", new DateTime(2018, 10, 16, 0, 17, 54, 211, DateTimeKind.Local).AddTicks(8741), "Cash desk: quo", new DateTime(2021, 2, 10, 5, 9, 21, 752, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a898d3a-9e3c-4cda-a8c7-e4ad3aea6eec"), "Molestias quia aut expedita sint.", "85fca211-7f17-4cbd-a4ff-9395768822c2", new DateTime(2022, 3, 7, 3, 44, 9, 332, DateTimeKind.Local).AddTicks(5647), "Cash desk: recusandae", new DateTime(2022, 3, 10, 16, 21, 52, 248, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9ad217cd-eacb-42e3-a068-28a24a2cc613"), "Saepe repellat sunt dicta nostrum omnis minus vitae.", "5239a482-b257-4890-bfef-beafefab7534", new DateTime(2017, 10, 12, 21, 6, 16, 985, DateTimeKind.Local).AddTicks(5562), "Cash desk: similique", new DateTime(2022, 1, 21, 15, 0, 11, 147, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a678be00-2350-4f44-b447-6611a0542039"), "Vel dolores id et.", "70523c04-14c0-4f2c-9e1c-5d003526e58a", new DateTime(2018, 9, 2, 1, 4, 39, 837, DateTimeKind.Local).AddTicks(7686), "Cash desk: ea", new DateTime(2020, 4, 14, 22, 8, 33, 485, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7e67957-f30e-4ea4-a839-9551d8a7ba94"), "Voluptate architecto sed minus eum qui itaque officia.", "066c6b3c-479d-49f8-967f-52fbae652cb2", new DateTime(2019, 6, 3, 12, 0, 34, 676, DateTimeKind.Local).AddTicks(6690), "Cash desk: quam", new DateTime(2020, 4, 7, 1, 31, 15, 71, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a810c005-4cbe-4629-befc-b003d90ce59d"), "Aut excepturi sint dolorem fugit iusto.", "b084e95a-7fd7-4143-bac2-bdaf64fb0263", new DateTime(2017, 7, 21, 0, 36, 59, 475, DateTimeKind.Local).AddTicks(3685), "Cash desk: fugit", new DateTime(2018, 2, 21, 14, 19, 47, 200, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a847e98c-1103-48b2-9ccc-5cb5c83e90b6"), "Et cupiditate consequatur soluta.", "955bdd82-b3ba-49b7-9f5d-14e9eb307483", new DateTime(2018, 8, 24, 20, 46, 56, 159, DateTimeKind.Local).AddTicks(1540), "Cash desk: accusantium", new DateTime(2019, 3, 16, 18, 29, 31, 430, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("adc919c7-5d2c-4935-9f69-b0a8e3e41f3e"), "Officiis cupiditate ea incidunt molestiae et dolores dolor reprehenderit nostrum.", "491ed3bb-f22a-4eb2-916d-1b9aaab08b48", new DateTime(2021, 5, 18, 23, 54, 54, 642, DateTimeKind.Local).AddTicks(1016), "Cash desk: similique", new DateTime(2022, 2, 17, 15, 19, 7, 407, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b14f706c-f063-467d-94f5-8b5df20faac9"), "Alias impedit reiciendis cupiditate quam expedita.", "b7e7df0a-3998-408b-a2fd-e3e3ea1e82ca", new DateTime(2020, 6, 19, 2, 46, 57, 420, DateTimeKind.Local).AddTicks(4180), "Cash desk: est", new DateTime(2021, 3, 17, 4, 53, 54, 589, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b801f705-5695-404a-b3b7-34e0d5e076a6"), "Voluptate ea qui voluptatibus.", "c2340292-3bb8-4e73-93ed-799b78d9832e", new DateTime(2020, 5, 19, 5, 28, 4, 724, DateTimeKind.Local).AddTicks(1285), "Cash desk: dolor", new DateTime(2022, 1, 13, 18, 42, 7, 613, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b880c54d-39ee-4851-a14f-3273c9877aae"), "Ipsa consectetur dolorum error.", "000def58-911a-47a9-9754-0bb01d5732f4", new DateTime(2021, 2, 5, 7, 15, 40, 157, DateTimeKind.Local).AddTicks(9050), "Cash desk: odit", new DateTime(2021, 5, 12, 11, 47, 10, 127, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9e45578-9f98-4540-b791-73d5bd8d7802"), "Aut aut unde voluptas.", "8eb99f49-f2cd-4ce1-bbe2-fd5bf4f0fecd", new DateTime(2019, 1, 31, 5, 43, 3, 945, DateTimeKind.Local).AddTicks(5621), "Cash desk: nihil", new DateTime(2019, 8, 6, 20, 22, 17, 452, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba47fa6e-5523-4b51-a733-8afa13d1c65d"), "Assumenda architecto voluptatibus libero qui libero occaecati qui.", "eead2332-23f6-4436-963f-0e7a04bc30bf", new DateTime(2021, 7, 5, 21, 3, 39, 526, DateTimeKind.Local).AddTicks(849), "Cash desk: aut", new DateTime(2022, 2, 13, 16, 10, 55, 926, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf582c63-fb6d-4714-b3fa-d84cecaa9127"), "Quos dolor asperiores id temporibus quasi.", "4dc2d2f6-d77c-4fe9-a65b-442c0bf21523", new DateTime(2019, 8, 29, 6, 30, 8, 53, DateTimeKind.Local).AddTicks(1461), "Cash desk: sed", new DateTime(2022, 4, 22, 13, 6, 30, 701, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bfba37c0-b871-412e-b8a5-1958bf557e79"), "Optio voluptates magni atque commodi.", "b25aa7bf-0d94-4ace-a742-a4804a68ced8", new DateTime(2018, 1, 29, 20, 55, 42, 927, DateTimeKind.Local).AddTicks(6350), "Cash desk: provident", new DateTime(2019, 5, 8, 17, 23, 20, 637, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c5640914-06c9-46ad-9a26-306541b02e75"), "Maiores omnis dignissimos dolore harum.", "f15657ad-671d-435e-b24d-36f337a84a26", new DateTime(2018, 10, 23, 9, 43, 24, 22, DateTimeKind.Local).AddTicks(8858), "Cash desk: accusantium", new DateTime(2022, 6, 26, 2, 26, 29, 125, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c875b9c9-5234-442b-9bb7-426e39b5ae32"), "Deserunt sapiente quo possimus deserunt voluptatibus rem sit.", "d4e6c444-de9b-48af-8fe8-e90dd13c9e89", new DateTime(2021, 4, 11, 16, 4, 27, 713, DateTimeKind.Local).AddTicks(2064), "Cash desk: quam", new DateTime(2021, 10, 8, 9, 38, 13, 450, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c997396d-74ac-429f-9c8f-ee293fb56b6a"), "Vitae commodi quasi porro a ipsum consequatur nesciunt.", "32ee9bb6-8220-4b7f-9f66-1586578f8d09", new DateTime(2019, 1, 27, 11, 43, 26, 86, DateTimeKind.Local).AddTicks(9645), "Cash desk: sed", new DateTime(2019, 10, 24, 20, 20, 2, 243, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ca10261e-02dd-4119-9139-73c949e12df8"), "Cumque earum id nisi facilis quae accusantium natus ipsum dolorum.", "da0f378a-b635-47ef-a3b1-bbff102ac9ba", new DateTime(2019, 8, 30, 21, 10, 37, 577, DateTimeKind.Local).AddTicks(6233), "Cash desk: qui", new DateTime(2021, 4, 28, 18, 57, 57, 570, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd8b176d-2d59-49b8-9fb4-af2114c9d167"), "Est eum amet molestiae non autem delectus eum velit.", "e94bbc1b-f298-4af8-9ce9-d5d5ed982c10", new DateTime(2021, 6, 20, 18, 39, 28, 981, DateTimeKind.Local).AddTicks(7906), "Cash desk: dolorum", new DateTime(2021, 12, 28, 19, 32, 45, 38, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cdfad4a0-917a-4b89-b2ef-97e92c741a81"), "Alias hic hic sequi voluptatem hic nesciunt minima.", "d7648e38-d8da-4609-b92f-f0330d0a57c9", new DateTime(2017, 7, 17, 4, 5, 28, 156, DateTimeKind.Local).AddTicks(6290), "Cash desk: dolorum", new DateTime(2019, 8, 28, 6, 58, 49, 486, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d07aa0dc-0df1-47d5-b059-cf9d681ff0a2"), "Consequatur ut voluptatem autem quidem qui esse dolore.", "d8681a19-e5e5-485d-951b-5ef354b50989", new DateTime(2018, 10, 24, 3, 45, 23, 300, DateTimeKind.Local).AddTicks(5049), "Cash desk: cupiditate", new DateTime(2019, 4, 23, 17, 10, 54, 628, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d3e9fa09-7576-47d1-a276-d20547bcd90e"), "Suscipit velit dolorem.", "1d4f9f0f-e034-411b-9213-1d24a79900be", new DateTime(2020, 8, 31, 4, 11, 40, 753, DateTimeKind.Local).AddTicks(766), "Cash desk: fugit", new DateTime(2021, 10, 29, 21, 46, 21, 873, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d4fd13c9-a068-4c4b-b961-fc668289623a"), "Quis nam et sed.", "2cb33cb2-9c47-41e7-a592-794bbea3d2cd", new DateTime(2021, 12, 11, 10, 41, 15, 931, DateTimeKind.Local).AddTicks(3876), "Cash desk: similique", new DateTime(2022, 2, 7, 2, 18, 36, 866, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7aeab3a-94f2-4c9d-88e4-3d76359497f5"), "Amet voluptas et doloremque sint totam ut.", "14df62e3-b76f-4800-b018-e2b7ed82c53e", new DateTime(2019, 9, 26, 7, 5, 3, 178, DateTimeKind.Local).AddTicks(1196), "Cash desk: asperiores", new DateTime(2020, 5, 25, 8, 57, 13, 513, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8bee37c-7884-44c2-a74c-60e32b9cf984"), "Incidunt sint blanditiis non vero enim aut sit et.", "b61eea01-4673-4e3a-8417-be952d4f7166", new DateTime(2021, 2, 4, 0, 55, 24, 856, DateTimeKind.Local).AddTicks(5710), "Cash desk: tenetur", new DateTime(2022, 5, 7, 14, 42, 29, 84, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("deee66f0-b190-42b5-be4e-53094b000afb"), "Rerum facilis cupiditate quia.", "0373b415-72f4-4ec8-8942-2647b17913ba", new DateTime(2018, 7, 12, 14, 16, 50, 909, DateTimeKind.Local).AddTicks(6885), "Cash desk: vel", new DateTime(2020, 4, 7, 14, 49, 52, 608, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e165cb7f-aaa5-4ef7-bb35-65fd46e2df63"), "Debitis consequatur voluptate impedit optio dolores dolor nam id nobis.", "d13c162d-1d62-47ee-8e43-13332437e3bb", new DateTime(2020, 8, 29, 8, 29, 0, 752, DateTimeKind.Local).AddTicks(4615), "Cash desk: pariatur", new DateTime(2022, 2, 15, 13, 41, 18, 520, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e352fe31-0bd7-4dc8-a228-99d80a1953f1"), "Et molestiae ipsa.", "ea48b727-db3c-4b1e-81af-217c518d990a", new DateTime(2021, 11, 17, 3, 15, 40, 254, DateTimeKind.Local).AddTicks(5616), "Cash desk: aut", new DateTime(2022, 2, 18, 10, 7, 40, 607, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e421247b-d318-4f18-a6ac-be4ae5dd37c7"), "Repellat ab voluptatem molestias numquam quo.", "9b8c3d8f-df29-4a5f-a93e-3f222a47c3bb", new DateTime(2019, 3, 29, 8, 23, 8, 452, DateTimeKind.Local).AddTicks(6173), "Cash desk: sit", new DateTime(2019, 7, 4, 9, 11, 12, 61, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e48314f8-8c9a-4cf4-95b5-21fe1f6aaf76"), "Pariatur totam commodi aut aut reprehenderit rerum.", "1fd41587-c77d-41c0-8755-f4b0208fdf2b", new DateTime(2019, 8, 9, 2, 48, 39, 852, DateTimeKind.Local).AddTicks(5690), "Cash desk: et", new DateTime(2021, 11, 4, 20, 35, 49, 917, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e77706b0-b43d-4e34-89b5-74b6032a071b"), "Aperiam eos inventore molestiae similique minima reiciendis.", "42670c88-8df7-4438-9b3b-ccd5c95414e8", new DateTime(2022, 3, 14, 8, 25, 44, 103, DateTimeKind.Local).AddTicks(3776), "Cash desk: sint", new DateTime(2022, 5, 22, 20, 21, 36, 302, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e93966fb-de71-45f4-aaac-3198ed33be4f"), "Qui ab quis et et.", "4b5cd455-ab07-432e-9250-80194a7bef9e", new DateTime(2019, 4, 1, 12, 14, 28, 931, DateTimeKind.Local).AddTicks(3870), "Cash desk: adipisci", new DateTime(2021, 11, 14, 5, 3, 4, 488, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ea77d2c2-d9f5-47fe-ba97-527053941e0e"), "In in rerum voluptatibus.", "0e9a74b1-856f-4c87-9826-fbdfc3567c1b", new DateTime(2019, 11, 13, 7, 58, 49, 731, DateTimeKind.Local).AddTicks(9380), "Cash desk: sed", new DateTime(2021, 5, 14, 5, 43, 26, 692, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec8b585c-24db-4570-af8b-c289b54f4a4e"), "Quis saepe incidunt blanditiis nesciunt in modi perferendis ullam in.", "783a9deb-ad8d-4a8f-a157-c1e4d43d01e4", new DateTime(2020, 9, 11, 3, 3, 51, 828, DateTimeKind.Local).AddTicks(2900), "Cash desk: autem", new DateTime(2021, 12, 13, 20, 53, 30, 844, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f177b1a6-9e3f-4316-ac36-a4344d8db561"), "At modi ea qui iusto consequatur quae nisi.", "4b0c3c42-69f0-4f7c-8108-49caf242ba80", new DateTime(2020, 4, 20, 8, 19, 29, 191, DateTimeKind.Local).AddTicks(873), "Cash desk: incidunt", new DateTime(2022, 2, 20, 9, 21, 47, 131, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3b33655-bfc8-43d5-b6cf-0e888c8c5298"), "Alias id suscipit similique totam accusantium quia animi quia consequatur.", "1292f65d-8e90-4b40-9095-361b9b6cf1e7", new DateTime(2018, 7, 4, 5, 43, 35, 306, DateTimeKind.Local).AddTicks(7606), "Cash desk: eum", new DateTime(2022, 5, 24, 23, 14, 21, 389, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7da8956-ef18-4729-b7f8-9e249196e135"), "Veritatis nobis voluptatem ut reiciendis possimus dicta sapiente soluta eum.", "24aa7289-25e2-4934-8ac2-9ea4eab77049", new DateTime(2019, 5, 26, 10, 29, 17, 279, DateTimeKind.Local).AddTicks(6882), "Cash desk: labore", new DateTime(2020, 3, 8, 21, 46, 42, 702, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe7cefa5-92f1-44f2-91ae-9e109d80470c"), "Ut dolorem dolores est exercitationem temporibus pariatur et et.", "8b1682f5-8090-41c4-b379-114676834798", new DateTime(2017, 10, 12, 6, 31, 26, 599, DateTimeKind.Local).AddTicks(3470), "Cash desk: quae", new DateTime(2021, 12, 14, 23, 5, 16, 8, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff483374-9c8e-425c-ad6a-6dc8dcdf0d13"), "Nulla tenetur sit voluptatem quis voluptates.", "02874402-ba98-4ca9-8d42-96a61d108f65", new DateTime(2019, 11, 8, 22, 0, 8, 763, DateTimeKind.Local).AddTicks(7191), "Cash desk: laboriosam", new DateTime(2022, 6, 24, 4, 1, 6, 695, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff4892ba-508e-4f15-89db-404164f49fce"), "Molestiae rem rem excepturi est et ipsum sequi.", "3c7558f4-2b2f-425a-b460-c6d112efccc5", new DateTime(2022, 4, 1, 9, 33, 7, 581, DateTimeKind.Local).AddTicks(974), "Cash desk: ad", new DateTime(2022, 5, 27, 10, 9, 27, 431, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.InsertData(
                table: "CashDesks",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ffc5b07b-6fc4-487c-8ff9-fd97ddb03a7d"), "Voluptatem quo quis.", "da8e8226-0690-4046-8d25-1d8f57e8d0e2", new DateTime(2021, 9, 24, 17, 49, 21, 310, DateTimeKind.Local).AddTicks(7857), "Cash desk: veniam", new DateTime(2022, 2, 19, 11, 16, 11, 464, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.InsertData(
                table: "ClientContactInformationType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), "Sed quis cupiditate saepe mollitia.", "c71432df-7e4d-4985-8b84-b67cde833c75", new DateTime(2018, 6, 26, 16, 35, 16, 760, DateTimeKind.Local).AddTicks(1213), "mobile", new DateTime(2019, 1, 4, 7, 36, 19, 472, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.InsertData(
                table: "ClientContactInformationType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), "Cumque ea maiores autem et fuga similique omnis rerum illum.", "a6d5051d-f843-44c0-bb6b-7375f6110805", new DateTime(2020, 9, 7, 3, 14, 44, 349, DateTimeKind.Local).AddTicks(2764), "adress", new DateTime(2022, 6, 23, 17, 50, 26, 883, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.InsertData(
                table: "ClientContactInformationType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), "Blanditiis eos dolor alias provident repellendus.", "36e6826c-3431-4a64-b078-ccaa71ed32e2", new DateTime(2018, 6, 24, 21, 15, 11, 545, DateTimeKind.Local).AddTicks(9965), "phone", new DateTime(2020, 3, 27, 0, 7, 20, 502, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("01bf48ef-26c9-4b2b-bb40-547858f7f35b"), "458", "малайзійський ринггіт", "d9fa50f8-aab8-47f5-8a61-dfcad3e3855c", new DateTime(2019, 11, 17, 17, 39, 41, 212, DateTimeKind.Local).AddTicks(4665), "Malaysia Ringgit", "MYR", "RM", new DateTime(2020, 11, 13, 9, 56, 24, 257, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("02c70c82-2f3a-4137-b927-bab6a71a0765"), "702", "сінгапурський долар", "6a4ad149-695c-4ff0-a3e9-1c2d687d3605", new DateTime(2018, 7, 14, 18, 10, 1, 63, DateTimeKind.Local).AddTicks(4761), "Singapore Dollar", "SGD", "$", new DateTime(2018, 7, 16, 14, 7, 26, 70, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("02d26779-f96d-48cf-b565-c4a1335c5411"), "533", "арубський флорин", "4d760b47-533e-4860-aff8-65fe82bbfb2e", new DateTime(2019, 7, 5, 2, 2, 9, 649, DateTimeKind.Local).AddTicks(5988), "Aruba Guilder", "AWG", "ƒ", new DateTime(2021, 8, 27, 7, 12, 4, 391, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("03f5fb70-2488-4239-b508-d2ba4ccc27e8"), "710", "ренд", "d8619e14-57cd-4f90-9e87-4052b3e6ecbc", new DateTime(2021, 8, 15, 21, 52, 35, 997, DateTimeKind.Local).AddTicks(3376), "South Africa Rand", "ZAR", "R", new DateTime(2022, 3, 27, 3, 33, 18, 757, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("0664d56d-a522-4cb6-b0ae-fb5eb183c2c9"), "052", "барбадоський долар", "831297d5-96dd-42b8-8eea-dfaaf1f1a00f", new DateTime(2021, 6, 7, 13, 21, 58, 322, DateTimeKind.Local).AddTicks(2064), "Barbados Dollar", "BBD", "$", new DateTime(2021, 7, 1, 16, 50, 4, 320, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("09e47700-c4be-42d8-90f7-4256fcdb1f44"), "975", "болгарський лев", "7bc428a8-2471-4d22-adc5-d1b462493691", new DateTime(2019, 10, 18, 17, 3, 54, 365, DateTimeKind.Local).AddTicks(1280), "Bulgaria Lev", "BGN", "лв", new DateTime(2020, 10, 22, 3, 50, 45, 904, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("0f2bc46b-2de9-4c5b-8b3f-de236666702e"), "978", "євро", "4d4267f7-9065-42c7-acb3-53f2bde97fe4", new DateTime(2020, 8, 18, 4, 51, 46, 91, DateTimeKind.Local).AddTicks(6165), "Euro Member Countries", "EUR", "€", new DateTime(2022, 4, 3, 20, 32, 3, 602, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("0f7e4c19-0f65-4611-9941-c550006e6492"), "578", "норвезька крона", "89856315-5aa0-4fa3-9fd9-a9b91ed7708f", new DateTime(2017, 10, 28, 15, 9, 6, 348, DateTimeKind.Local).AddTicks(8873), "Norway Krone", "NOK", "kr", new DateTime(2018, 5, 9, 16, 46, 58, 575, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1021da9c-4cfb-4dbf-b3bd-4f6ee5b2af45"), "116", "ріел", "d6ae7d6c-77c7-430b-a78b-a15f1f2bf482", new DateTime(2020, 8, 25, 4, 37, 36, 835, DateTimeKind.Local).AddTicks(372), "Cambodia Riel", "KHR", "៛", new DateTime(2021, 7, 25, 3, 19, 13, 208, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("183468c0-0d7b-4f0a-adbe-a327e9ac9dd5"), "090", "долар Соломонових Островів", "51056d6b-161e-4cbb-84d4-d652d8fb0004", new DateTime(2018, 12, 27, 3, 32, 5, 853, DateTimeKind.Local).AddTicks(3154), "Solomon Islands Dollar", "SBD", "$", new DateTime(2020, 4, 4, 23, 10, 8, 455, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1a80bb52-1cf7-41af-a6fe-b91cf0c2129f"), "208", "данська крона", "7f228180-8a92-4850-879c-148aaaba612b", new DateTime(2018, 12, 22, 18, 1, 8, 522, DateTimeKind.Local).AddTicks(5356), "Denmark Krone", "DKK", "kr", new DateTime(2019, 4, 6, 7, 3, 49, 661, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1bfbc096-83eb-4160-9a6e-2ca1fa6a9bb3"), "886", "єменський ріал", "ed88812c-bb49-4f7e-b300-3f4b64bb9080", new DateTime(2018, 4, 10, 22, 11, 52, 239, DateTimeKind.Local).AddTicks(398), "Yemen Rial", "YER", "﷼", new DateTime(2018, 11, 23, 13, 31, 47, 657, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1d3bf488-2160-4796-b0d8-14c03d28bbe2"), "144", "рупія Шрі-Ланки", "df9a3421-320f-4506-bbd0-3cf78d844782", new DateTime(2019, 5, 30, 1, 13, 42, 384, DateTimeKind.Local).AddTicks(3703), "Sri Lanka Rupee", "LKR", "₨", new DateTime(2020, 6, 28, 9, 55, 31, 85, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("1fcb9fd7-98df-4305-a030-632a8a43978e"), "752", "шведська крона", "ed9e331a-60f2-4bea-95a9-f2da74ef4803", new DateTime(2019, 6, 7, 12, 5, 59, 66, DateTimeKind.Local).AddTicks(8349), "Sweden Krona", "SEK", "kr", new DateTime(2020, 11, 22, 3, 23, 45, 785, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("238a420c-1ca7-4bec-8902-74b0ddd795e6"), "152", "чилійське песо", "e3d67abc-abbd-41e0-8600-6c4c6658ef86", new DateTime(2018, 7, 14, 19, 42, 42, 807, DateTimeKind.Local).AddTicks(8069), "Chile Peso", "CLP", "$", new DateTime(2019, 8, 1, 9, 28, 5, 315, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("255ccba0-3293-4e5b-acde-bac5ef176fd8"), "944", "азербайджанський манат", "5f357baa-3de5-4f1d-b90a-0935ccff7872", new DateTime(2022, 1, 25, 0, 36, 49, 70, DateTimeKind.Local).AddTicks(5214), "Azerbaijan Manat", "AZN", "₼", new DateTime(2022, 4, 18, 17, 34, 27, 968, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("25cd79ff-6519-4c52-bf38-ecec68800db5"), "682", "саудівський ріял", "17e1f923-7727-4a2d-ac79-b0aa1aae8451", new DateTime(2017, 9, 1, 23, 54, 24, 837, DateTimeKind.Local).AddTicks(2398), "Saudi Arabia Riyal", "SAR", "﷼", new DateTime(2019, 4, 8, 20, 21, 26, 271, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2660bd95-efa0-402e-bd7f-1dea07a788e3"), "484", "мексиканське песо", "83562a03-cb15-455a-b0ed-4b9674ae0a52", new DateTime(2018, 6, 1, 9, 56, 6, 556, DateTimeKind.Local).AddTicks(5468), "Mexico Peso", "MXN", "$", new DateTime(2019, 10, 31, 3, 21, 39, 276, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("26e2527c-2136-4ceb-8954-4d06b8a30d08"), "968", "сурінамський долар", "0f44ea64-bf4b-4409-8ddc-91e52fce4c72", new DateTime(2018, 3, 24, 8, 56, 8, 811, DateTimeKind.Local).AddTicks(4665), "Suriname Dollar", "SRD", "$", new DateTime(2020, 12, 18, 1, 32, 21, 279, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2774ab38-b371-44a3-a2d8-828469baf994"), "558", "золота кордоба", "3c42f76e-d4c3-4d1c-b9ef-36f78e626b1e", new DateTime(2021, 8, 17, 19, 43, 51, 495, DateTimeKind.Local).AddTicks(1385), "Nicaragua Cordoba", "NIO", "C$", new DateTime(2022, 5, 18, 15, 10, 44, 733, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2b0cd830-1df8-4634-9218-7ad6db4c642b"), "496", "тугрик", "090faf76-56c6-48a2-bf66-a056c8889f5a", new DateTime(2018, 5, 12, 18, 23, 13, 183, DateTimeKind.Local).AddTicks(3944), "Mongolia Tughrik", "MNT", "₮", new DateTime(2020, 7, 22, 17, 56, 25, 55, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("2b9d71b3-3487-4909-a162-f24591b08782"), "946", "румунський лей", "5ef6884e-221a-4deb-bb1c-f1f8f2b71c1a", new DateTime(2019, 9, 24, 17, 25, 12, 601, DateTimeKind.Local).AddTicks(5635), "Romania Leu", "RON", "lei", new DateTime(2020, 1, 2, 0, 8, 25, 240, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("32f5a59b-870b-41c4-b439-12a26380fbe2"), "191", "куна", "75a46dd2-92f3-4a20-82d7-acc7aa7f2327", new DateTime(2020, 3, 25, 14, 8, 23, 186, DateTimeKind.Local).AddTicks(2043), "Croatia Kuna", "HRK", "kn", new DateTime(2020, 11, 12, 14, 58, 1, 187, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("392975d9-013d-47aa-8ae9-c085c567a8f7"), "901", "новий тайванський долар", "22f5b99a-1025-42f1-979c-11a5123e3fc4", new DateTime(2020, 9, 22, 16, 33, 22, 336, DateTimeKind.Local).AddTicks(6892), "Taiwan New Dollar", "TWD", "NT$", new DateTime(2021, 4, 15, 15, 45, 9, 79, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("3c4fcfb1-0099-45e1-9dde-fd6241aff4dd"), "936", "ганське седі", "fb9bb0e6-f369-46b0-b76a-c99dcda1b553", new DateTime(2019, 7, 12, 7, 53, 22, 884, DateTimeKind.Local).AddTicks(3273), "Ghana Cedi", "GHS", "¢", new DateTime(2022, 6, 13, 14, 4, 52, 786, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("40c042a0-fb5d-4bfa-a517-0f5e9564c619"), "840", "долар США", "abe76d55-e4aa-4ebd-90c8-fe11ce6e4781", new DateTime(2019, 7, 19, 5, 22, 59, 865, DateTimeKind.Local).AddTicks(2969), "United States Dollar", "USD", "$", new DateTime(2021, 4, 23, 16, 1, 24, 775, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("41c551a0-d9b4-4808-aa34-c2ed8bbaea42"), "860", "узбецький сум", "140a1404-0f9f-440e-8196-be7bb63fe78b", new DateTime(2020, 8, 5, 15, 43, 59, 87, DateTimeKind.Local).AddTicks(6990), "Uzbekistan Som", "UZS", "лв", new DateTime(2021, 5, 26, 15, 25, 6, 389, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("43360fc0-9fb2-4694-8c0d-06d28b06bbd4"), "764", "бат", "345d22bc-3cf7-4bbe-b361-22151ac9998a", new DateTime(2019, 11, 15, 17, 23, 33, 7, DateTimeKind.Local).AddTicks(3383), "Thailand Baht", "THB", "฿", new DateTime(2021, 12, 11, 14, 19, 34, 189, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("4483e109-6152-45b9-982c-bf970a9a9ef8"), "554", "новозеландський долар", "3ebf07fa-0b8b-47b5-8cb9-aa0442d32974", new DateTime(2018, 7, 26, 22, 25, 18, 827, DateTimeKind.Local).AddTicks(1582), "New Zealand Dollar", "NZD", "$", new DateTime(2019, 1, 13, 3, 25, 25, 316, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("4f1bc337-8597-46e4-a743-305ee710123c"), "364", "іранський ріал", "fdb3c7f1-9bfc-44fa-a36f-c9ec667af347", new DateTime(2021, 10, 2, 2, 47, 19, 474, DateTimeKind.Local).AddTicks(4830), "Iran Rial", "IRR", "﷼", new DateTime(2021, 10, 9, 15, 25, 25, 164, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("5316d3eb-3c0e-4821-89bf-6b91ccad8074"), "807", "денар", "4ab58d5d-20cc-463f-932b-4761b8b3a995", new DateTime(2020, 8, 3, 18, 57, 59, 2, DateTimeKind.Local).AddTicks(5095), "Macedonia Denar", "MKD", "ден", new DateTime(2020, 10, 20, 11, 1, 3, 547, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("571120d6-e62c-49e6-bd83-837737530bab"), "600", "гуарані", "211b70c5-de9b-47b1-aa58-bd4f3a01e62c", new DateTime(2019, 5, 3, 5, 24, 31, 190, DateTimeKind.Local).AddTicks(7266), "Paraguay Guarani", "PYG", "Gs", new DateTime(2021, 5, 19, 9, 12, 35, 664, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("577ca05b-7db7-4609-ac8c-19be3a06eed3"), "422", "ліванський фунт", "1fbd4d3d-37f5-4eac-81dc-080b19a6bc32", new DateTime(2021, 1, 6, 12, 3, 15, 164, DateTimeKind.Local).AddTicks(3621), "Lebanon Pound", "LBP", "£", new DateTime(2021, 1, 8, 23, 19, 15, 106, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("5968201f-eafe-494d-ba71-e4f2c8eff5a4"), "360", "рупія", "59623a30-d45d-4855-b79e-242a2700426b", new DateTime(2021, 11, 26, 3, 36, 9, 988, DateTimeKind.Local).AddTicks(7860), "Indonesia Rupiah", "IDR", "Rp", new DateTime(2022, 4, 28, 0, 22, 47, 917, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("60e7babe-d503-449e-8815-9805363c6afe"), "858", "уругвайське песо", "368bc2a2-2e0a-4381-8886-a14084624b0c", new DateTime(2019, 9, 19, 13, 57, 23, 455, DateTimeKind.Local).AddTicks(2422), "Uruguay Peso", "UYU", "$U", new DateTime(2021, 10, 16, 17, 47, 23, 807, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("61517f33-3156-4ca7-b216-9b61492bb253"), "388", "ямайський долар", "538bad57-684e-4c99-98ee-d7026ccdb58c", new DateTime(2019, 5, 25, 14, 11, 14, 917, DateTimeKind.Local).AddTicks(8003), "Jamaica Dollar", "JMD", "J$", new DateTime(2019, 5, 26, 12, 33, 36, 966, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("63491dd6-1fd8-44d3-9cf1-3c0669934448"), "320", "кетсаль", "ee08936f-9b23-4f29-a47d-d3a2f2ebe147", new DateTime(2021, 8, 14, 5, 31, 5, 937, DateTimeKind.Local).AddTicks(6916), "Guatemala Quetzal", "GTQ", "Q", new DateTime(2021, 10, 31, 8, 34, 14, 392, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("635a37a7-7cf1-4c5a-b8e4-b8dc80152619"), "044", "багамський долар", "ceb03d8e-6f87-4ab6-925a-38b3f90921cb", new DateTime(2022, 4, 14, 21, 42, 48, 804, DateTimeKind.Local).AddTicks(6513), "Bahamas Dollar", "BSD", "$", new DateTime(2022, 4, 21, 23, 14, 26, 532, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("637c1379-d8b1-4cd2-b019-6a5d61593b6b"), "036", "австралійський долар", "703aa1c5-7014-4e32-9fe5-7a7a71b77f62", new DateTime(2020, 9, 17, 19, 40, 2, 532, DateTimeKind.Local).AddTicks(7073), "Australia Dollar", "AUD", "$", new DateTime(2022, 7, 2, 17, 3, 19, 842, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("65d9b862-e91e-4f34-8677-5b25e2496182"), "188", "костариканський колон", "4e3f27f2-de29-4404-a6bc-e13f54059a8e", new DateTime(2022, 3, 4, 6, 43, 21, 852, DateTimeKind.Local).AddTicks(8025), "Costa Rica Colon", "CRC", "₡", new DateTime(2022, 6, 25, 9, 57, 11, 831, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("6b048264-52b7-4a10-ae42-10dbc6306ad4"), "480", "маврикійська рупія", "566d7f54-192d-4765-a9c4-8757a11095dc", new DateTime(2020, 3, 23, 19, 5, 34, 823, DateTimeKind.Local).AddTicks(5626), "Mauritius Rupee", "MUR", "₨", new DateTime(2020, 6, 19, 18, 0, 32, 615, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("6bd72496-ffcd-49ea-8500-f635f2aba7e9"), "352", "ісландська крона", "3e5d214d-5df9-4c88-9891-f6ba9f1e0854", new DateTime(2020, 10, 28, 14, 9, 58, 773, DateTimeKind.Local).AddTicks(6466), "Iceland Krona", "ISK", "kr", new DateTime(2022, 7, 3, 17, 41, 26, 905, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("6c43a208-4229-4973-b7cd-65851a65af96"), "096", "брунейський долар", "7369f6bd-a81a-45e4-b53a-7ccbedcac40e", new DateTime(2021, 5, 10, 9, 45, 57, 988, DateTimeKind.Local).AddTicks(1923), "Brunei Darussalam Dollar", "BND", "$", new DateTime(2021, 11, 21, 10, 47, 52, 689, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("71ee996e-a637-41b9-8912-ccaf3a19e5cb"), "980", "гривня", "d61267c5-83b8-4316-9987-fa0f77ba3482", new DateTime(2021, 6, 3, 18, 2, 21, 707, DateTimeKind.Local).AddTicks(4771), "Ukraine Hryvnia", "UAH", "₴", new DateTime(2022, 3, 26, 16, 56, 57, 607, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("720e152a-d33a-49dd-b653-e4e13be97837"), "780", "долар Тринідаду і Тобаго", "67999fcc-8cf8-48fd-b488-1e7a671030db", new DateTime(2021, 12, 24, 22, 20, 34, 190, DateTimeKind.Local).AddTicks(6831), "Trinidad and Tobago Dollar", "TTD", "TT$", new DateTime(2022, 4, 14, 21, 31, 5, 119, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("75c90c61-fe8c-4866-92de-4eaa3beaa7a2"), "328", "гайанський долар", "9d1debb4-1acc-4988-bc5e-440723a7870e", new DateTime(2017, 7, 17, 19, 49, 0, 791, DateTimeKind.Local).AddTicks(1738), "Guyana Dollar", "GYD", "$", new DateTime(2018, 7, 24, 3, 33, 41, 9, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("7a20bb06-89d7-4e8f-9ee1-5c7b37974031"), "242", "фіджійський долар", "428c8959-bb22-4b16-9424-83c879c31bd7", new DateTime(2018, 6, 22, 15, 7, 56, 952, DateTimeKind.Local).AddTicks(1276), "Fiji Dollar", "FJD", "$", new DateTime(2019, 3, 24, 20, 8, 57, 810, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("7ff11533-c1af-4570-84ba-d72d69db1606"), "170", "колумбійське песо", "4e363504-4e13-460f-9f76-6623dc99fbbf", new DateTime(2017, 10, 10, 0, 17, 32, 795, DateTimeKind.Local).AddTicks(9384), "Colombia Peso", "COP", "$", new DateTime(2022, 5, 16, 4, 12, 38, 667, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("8248a0b0-69ae-4ba9-a7a5-1b0f3882a427"), "826", "фунт стерлінгів", "fd5a5c30-c9f9-44b8-ad85-4d100e0c08fe", new DateTime(2019, 5, 23, 5, 7, 34, 71, DateTimeKind.Local).AddTicks(2225), "United Kingdom Pound", "GBP", "£", new DateTime(2020, 3, 1, 4, 30, 58, 673, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("839f4baf-8172-405c-9b73-818fb6e0bf62"), "704", "донг", "f305c5bd-8834-418e-8644-b24179673bc5", new DateTime(2017, 11, 21, 22, 33, 58, 261, DateTimeKind.Local).AddTicks(2123), "Viet Nam Dong", "VND", "₫", new DateTime(2021, 10, 5, 23, 55, 28, 512, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("85ec3c4c-65e1-4002-b2c8-2a6976440010"), "818", "єгипетський фунт", "a0f5805e-c75f-4c62-a61e-da09e466f3ff", new DateTime(2019, 2, 1, 14, 57, 16, 908, DateTimeKind.Local).AddTicks(9288), "Egypt Pound", "EGP", "£", new DateTime(2021, 11, 20, 16, 39, 46, 441, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("8b214c2f-d27a-454f-801c-511a4fb270b5"), "068", "болівіано", "da62044a-4749-47a1-9fae-c24d7ae20deb", new DateTime(2017, 7, 7, 16, 51, 0, 257, DateTimeKind.Local).AddTicks(5832), "Bolivia Bolíviano", "BOB", "$b", new DateTime(2017, 10, 25, 1, 51, 7, 655, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("924e76aa-9b94-4939-bfc7-de84556f9962"), "951", "східнокарибський долар", "958dd474-7f7a-4599-8b7a-04958ea1221e", new DateTime(2021, 11, 18, 22, 7, 57, 169, DateTimeKind.Local).AddTicks(8659), "East Caribbean Dollar", "XCD", "$", new DateTime(2022, 5, 16, 11, 0, 57, 124, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("93f577fb-7ae4-4e02-a6a2-daef3e3efdd9"), "986", "бразильський реал", "a136fcae-3df3-40a8-868d-f5aaee71a2a7", new DateTime(2021, 12, 5, 4, 9, 38, 358, DateTimeKind.Local).AddTicks(4072), "Brazil Real", "BRL", "R$", new DateTime(2022, 3, 16, 17, 5, 48, 0, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("9e7842bd-688e-4c0f-8a08-3c8ac651fc1f"), "410", "вона", "f4cb2fc9-b1f9-4fd7-9935-3cf4bf664a91", new DateTime(2019, 7, 10, 7, 5, 15, 670, DateTimeKind.Local).AddTicks(9051), "Korea (South) Won", "KRW", "₩", new DateTime(2022, 6, 16, 4, 31, 29, 300, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("9f523d09-a646-46c1-86bb-82e16cbf9892"), "590", "бальбоа", "a86345f1-e8e7-4771-b484-6561ffab1a63", new DateTime(2018, 7, 22, 4, 44, 19, 17, DateTimeKind.Local).AddTicks(3168), "Panama Balboa", "PAB", "B/.", new DateTime(2018, 12, 18, 13, 44, 12, 389, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("9f93b945-db5d-4e88-bee3-14faf28a48ea"), "608", "філіппінське песо", "dd7b19a8-1238-43a0-94e0-a3903df7532c", new DateTime(2018, 8, 16, 9, 26, 22, 210, DateTimeKind.Local).AddTicks(5498), "Philippines Peso", "PHP", "₱", new DateTime(2020, 1, 14, 5, 12, 8, 203, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a1e16846-b4fa-47dd-ad5b-6789baeab5f9"), "156", "юань Женьміньбі", "f5382e39-5d1b-4aa1-bf78-31c46f2b18a1", new DateTime(2020, 7, 19, 4, 44, 5, 453, DateTimeKind.Local).AddTicks(1251), "China Yuan Renminbi", "CNY", "¥", new DateTime(2021, 5, 25, 3, 10, 22, 820, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a370a723-a187-4de5-9cfa-e100466376ff"), "634", "катарський ріал", "f9f5704c-2139-450f-ad37-408e8bc6afd2", new DateTime(2022, 3, 12, 1, 31, 52, 934, DateTimeKind.Local).AddTicks(7751), "Qatar Riyal", "QAR", "﷼", new DateTime(2022, 6, 28, 5, 20, 1, 964, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("a827e482-1b7b-4cbf-ac13-c277b60f7bbd"), "524", "непальська рупія", "686292e4-ec33-49ab-82e0-1fe2b393ba00", new DateTime(2018, 7, 20, 3, 44, 34, 287, DateTimeKind.Local).AddTicks(6066), "Nepal Rupee", "NPR", "₨", new DateTime(2018, 9, 17, 4, 4, 56, 333, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("aa7bc708-24f6-4aa2-ade6-c3ed27d07bad"), "392", "єна", "566128fa-662a-4cca-bd8f-fdabcc4f0137", new DateTime(2018, 11, 7, 12, 50, 10, 647, DateTimeKind.Local).AddTicks(5984), "Japan Yen", "JPY", "¥", new DateTime(2020, 3, 6, 15, 8, 51, 586, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("aaed2eb9-93eb-42f4-9fb7-c088374778c2"), "356", "індійська рупія", "c45b350e-2910-4ad6-8252-b948e02945c7", new DateTime(2020, 4, 15, 9, 55, 24, 356, DateTimeKind.Local).AddTicks(1446), "India Rupee", "INR", "₹", new DateTime(2020, 9, 4, 18, 29, 12, 496, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("abf94bd1-21f8-4978-8d51-1d3c4e77ffb0"), "417", "сом", "ddbb65e8-0f7f-4ae2-8653-052a5d3d0e7a", new DateTime(2019, 9, 7, 23, 59, 10, 209, DateTimeKind.Local).AddTicks(421), "Kyrgyzstan Som", "KGS", "лв", new DateTime(2021, 12, 18, 16, 0, 47, 912, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("aea2cc66-7a13-4097-a75e-bb50e413eba9"), "949", "турецька ліра", "b5991c7f-8e48-41f2-bac8-53bf026e9f75", new DateTime(2020, 8, 1, 4, 4, 9, 414, DateTimeKind.Local).AddTicks(6028), "Turkey Lira", "TRY", "₺", new DateTime(2020, 10, 15, 0, 10, 33, 810, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("b7a9a128-31fd-4cce-9d94-0cc9abdba338"), "586", "пакистанська рупія", "c5f3349c-9ce9-4327-9c11-c6ffc5dcecf8", new DateTime(2018, 10, 19, 21, 34, 28, 27, DateTimeKind.Local).AddTicks(2686), "Pakistan Rupee", "PKR", "₨", new DateTime(2019, 6, 1, 11, 37, 33, 128, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("b94fb873-0e65-4bf3-a7fa-7c4a0dddda65"), "214", "домініканське песо", "9d721ba7-4006-4cce-b6c0-772107ef5fc3", new DateTime(2019, 8, 9, 12, 6, 48, 503, DateTimeKind.Local).AddTicks(9240), "Dominican Republic Peso", "DOP", "RD$", new DateTime(2019, 11, 28, 18, 6, 2, 847, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ba13a2fa-6682-4fe3-8cf6-7ad83b18a02b"), "784", "дирхам ОАЕ", "d2b092c7-999b-4b40-9797-1cdfae90d636", new DateTime(2021, 5, 7, 14, 10, 1, 478, DateTimeKind.Local).AddTicks(5570), "UAE-Dirham", "AED", "د.إ", new DateTime(2021, 6, 23, 22, 15, 15, 323, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("bd97de5d-4f9a-4785-8297-5d55b739412a"), "756", "швейцарський франк", "8ee9fedc-a76e-4cea-8362-c0f2989f87c1", new DateTime(2019, 1, 6, 20, 24, 52, 828, DateTimeKind.Local).AddTicks(9331), "Switzerland Franc", "CHF", "CHF", new DateTime(2019, 10, 17, 3, 12, 25, 475, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c0ef84d4-9514-4a16-a84e-0824eea8d1c9"), "690", "сейшельська рупія", "d78bfca2-f982-43ce-8e79-f6b46fb993f9", new DateTime(2020, 8, 9, 3, 50, 17, 896, DateTimeKind.Local).AddTicks(4316), "Seychelles Rupee", "SCR", "₨", new DateTime(2021, 11, 3, 12, 58, 32, 951, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c5b247ff-f3bf-452a-b00c-6bfc367e410a"), "937", "болівар", "4f9c76c3-59d2-4953-956f-f5a065c62a47", new DateTime(2020, 5, 12, 23, 28, 4, 794, DateTimeKind.Local).AddTicks(9910), "Venezuela Bolívar", "VEF", "Bs", new DateTime(2021, 11, 13, 20, 41, 14, 952, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("c5d4ff81-4e46-4476-91a1-cdc2c74f8e7c"), "398", "теньге", "d73fe4df-c687-4e75-b69c-12b09d3f2232", new DateTime(2019, 3, 16, 5, 41, 20, 1, DateTimeKind.Local).AddTicks(4620), "Kazakhstan Tenge", "KZT", "лв", new DateTime(2020, 10, 13, 21, 35, 50, 337, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("cc7b497a-83e1-4c09-8204-c2b2b7e7e3d8"), "348", "форинт", "4599b0f8-ab01-4cd9-9692-e9433ab47d9a", new DateTime(2020, 11, 29, 6, 55, 17, 603, DateTimeKind.Local).AddTicks(9355), "Hungary Forint", "HUF", "Ft", new DateTime(2022, 6, 5, 17, 55, 30, 266, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("cc9c15eb-9bd1-4c5f-8fa2-7a8d20dc6f50"), "941", "сербський динар", "62dcbe7c-d98e-4a5a-809e-a4b3c948e5f5", new DateTime(2021, 9, 17, 23, 1, 18, 478, DateTimeKind.Local).AddTicks(4797), "Serbia Dinar", "RSD", "Дин.", new DateTime(2022, 5, 10, 13, 16, 53, 697, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("cf7d15ae-eb12-4577-b38a-f0a34f29716b"), "376", "новий ізраїльський шекель", "07fabd78-08ca-43ea-a660-a3a575cd41f2", new DateTime(2017, 10, 25, 13, 5, 58, 502, DateTimeKind.Local).AddTicks(7483), "Israel Shekel", "ILS", "₪", new DateTime(2018, 11, 7, 6, 5, 34, 904, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("d1d40928-891b-473b-b4ed-8f0940943dc0"), "985", "злотий", "93d8c003-7584-4da3-8e83-181b7a6ec02c", new DateTime(2018, 8, 12, 17, 46, 37, 540, DateTimeKind.Local).AddTicks(9039), "Poland Zloty", "PLN", "zł", new DateTime(2018, 11, 24, 10, 52, 43, 813, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("d4dd37b4-0cf8-4756-9670-85a84c79ff53"), "643", "російський рубль", "f9c5487b-7df7-44b5-bd59-9d1764809036", new DateTime(2021, 12, 9, 1, 58, 22, 886, DateTimeKind.Local).AddTicks(145), "Russia Ruble", "RUB", "₽", new DateTime(2022, 2, 16, 11, 54, 58, 212, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("d5195608-45f7-4144-bc32-4f4e8bced4fa"), "072", "пула", "fdfeff5f-b10a-49f5-9d85-c0a78f038011", new DateTime(2019, 11, 20, 10, 0, 12, 697, DateTimeKind.Local).AddTicks(8593), "Botswana Pula", "BWP", "P", new DateTime(2022, 2, 12, 3, 14, 13, 903, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("de99be90-fc2d-45c3-938d-16935f0850dc"), "222", "сальвадорський колон", "62cf1983-3450-49c8-93c9-3187080b6e2a", new DateTime(2018, 6, 19, 16, 56, 32, 926, DateTimeKind.Local).AddTicks(68), "El Salvador Colon", "SVC", "$", new DateTime(2021, 6, 12, 2, 52, 37, 684, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("dee4efa7-4895-4d9d-891c-4d1d334b1c2f"), "203", "чеська крона", "195cd62e-31e9-4b72-90f9-49ae329f3c1e", new DateTime(2019, 2, 20, 10, 41, 50, 557, DateTimeKind.Local).AddTicks(3297), "Czech Republic Koruna", "CZK", "Kč", new DateTime(2020, 1, 7, 3, 20, 45, 418, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("e7c77830-cf3e-4233-9cba-26a76a89abdd"), "512", "ріал Оману", "60e40244-00db-44f3-ab85-7ac97f465c5f", new DateTime(2020, 8, 3, 1, 16, 23, 600, DateTimeKind.Local).AddTicks(5027), "Oman Rial", "OMR", "﷼", new DateTime(2020, 8, 8, 15, 11, 36, 757, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ecf909c7-609c-4772-b064-abcd7cb11600"), "032", "аргентинське песо", "31c1248b-c127-41f1-8034-467a035d4acd", new DateTime(2020, 1, 2, 1, 48, 47, 215, DateTimeKind.Local).AddTicks(2642), "Argentina Peso", "ARS", "$", new DateTime(2020, 3, 2, 16, 15, 28, 845, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ed60c5e2-af3c-4186-aeab-34c49d8b880c"), "124", "канадський долар", "4253584e-42a2-4ff5-a53e-7600d93cc04b", new DateTime(2019, 6, 12, 22, 7, 34, 226, DateTimeKind.Local).AddTicks(5359), "Canada Dollar", "CAD", "$", new DateTime(2022, 1, 5, 19, 1, 27, 212, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ee62f082-552d-4b20-a151-b07dadea00eb"), "340", "лемпіра", "b4a67938-7032-41aa-b751-eae39c2c158b", new DateTime(2019, 1, 19, 3, 15, 33, 527, DateTimeKind.Local).AddTicks(7669), "Honduras Lempira", "HNL", "L", new DateTime(2019, 12, 5, 3, 53, 12, 211, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("ef1d8a05-7944-45f0-a2d1-60db9ad84e90"), "933", "білоруський рубль", "a43362f2-40d5-4eeb-8202-917a6634d57f", new DateTime(2021, 3, 1, 8, 31, 0, 172, DateTimeKind.Local).AddTicks(2652), "Belarus Ruble", "BYN", "Br", new DateTime(2022, 1, 21, 4, 36, 0, 440, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f249167d-0258-4924-ad05-04fb380e71cb"), "408", "північнокорейська вона", "0024348a-2259-4f6d-b806-c6ac5c809f4e", new DateTime(2019, 9, 30, 8, 0, 57, 665, DateTimeKind.Local).AddTicks(5343), "Korea (North) Won", "KPW", "₩", new DateTime(2021, 12, 18, 19, 49, 23, 934, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f7cb88c6-50dd-4d09-ad7f-f8f6f3d0ca4b"), "604", "соль", "a95b0564-f04e-4f83-bdd0-0abefbadc72a", new DateTime(2019, 5, 9, 9, 46, 20, 111, DateTimeKind.Local).AddTicks(9583), "Peru Sol", "PEN", "S/.", new DateTime(2021, 1, 30, 10, 47, 36, 357, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f8ba2183-2533-492b-ac79-09fe07ff006b"), "516", "намібійський долар", "7aa16daf-6042-4c8c-a636-760a90066db6", new DateTime(2019, 4, 12, 11, 26, 12, 975, DateTimeKind.Local).AddTicks(852), "Namibia Dollar", "NAD", "$", new DateTime(2019, 11, 13, 14, 44, 16, 979, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("f97ca05c-7b23-4644-b90b-416041deb5a9"), "084", "белізький долар", "6d733890-5d38-4572-ab06-d32ac3c34204", new DateTime(2019, 1, 3, 20, 9, 22, 776, DateTimeKind.Local).AddTicks(3681), "Belize Dollar", "BZD", "BZ$", new DateTime(2020, 1, 5, 15, 23, 16, 724, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.InsertData(
                table: "Currencyes",
                columns: new[] { "Id", "Code", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "ShortName", "Symbol", "UpdatedAt" },
                values: new object[] { new Guid("fdd1d197-589b-42a7-a8d6-67a115269478"), "344", "гонконгівський долар", "56dc25b1-af04-4b72-9e5a-159eb30f5be5", new DateTime(2020, 2, 21, 7, 43, 14, 905, DateTimeKind.Local).AddTicks(7822), "Hong Kong Dollar", "HKD", "$", new DateTime(2022, 1, 4, 18, 28, 3, 999, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07acd96b-be9d-4217-8139-2f29977a3004"), "Saepe architecto exercitationem.", "5a609fcd-d103-48ec-af6b-5ed89e080a26", new DateTime(2019, 4, 12, 4, 50, 11, 493, DateTimeKind.Local).AddTicks(3291), "rejected", new DateTime(2022, 6, 10, 15, 6, 58, 21, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("29d39b91-0217-4bbc-bffb-418cd071a90b"), "Earum ipsum officia sed eum omnis enim dolores quod quisquam.", "85f9baf4-9f3b-44e8-85d8-8750a9e9906f", new DateTime(2020, 5, 19, 10, 13, 28, 857, DateTimeKind.Local).AddTicks(6711), "accepted", new DateTime(2020, 10, 31, 17, 5, 53, 405, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b65823b-857c-460b-923b-512237244b48"), "Harum molestiae laboriosam.", "c09035c4-6ec0-4f72-abd7-315928b8d76f", new DateTime(2019, 6, 25, 3, 49, 31, 680, DateTimeKind.Local).AddTicks(8418), "new", new DateTime(2019, 11, 25, 14, 38, 41, 324, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ff8c7b2-b3ed-4b95-98ee-82b07fde83fd"), "Porro odio labore culpa omnis est error.", "d96a0887-be4b-4a84-8cbf-f41f0e6270f2", new DateTime(2019, 2, 5, 0, 13, 53, 357, DateTimeKind.Local).AddTicks(2424), "whaiting for paymetn", new DateTime(2020, 8, 19, 4, 32, 50, 791, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("695973ef-8be2-4e6c-a6fc-cadea3c102d9"), "Sit quo adipisci omnis earum dolores ea est incidunt.", "97c41382-8dcb-4ebc-b54d-cd3e17922704", new DateTime(2020, 1, 1, 1, 15, 38, 440, DateTimeKind.Local).AddTicks(2497), "send", new DateTime(2020, 5, 24, 17, 27, 50, 188, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.InsertData(
                table: "DocumentStatus<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("895d8fef-6b80-4d6b-a4be-e17159d1feff"), "Voluptas et facilis eum ut sed.", "06f21287-5781-4456-b3c9-d409b460d302", new DateTime(2021, 12, 16, 12, 33, 5, 37, DateTimeKind.Local).AddTicks(753), "delivered", new DateTime(2022, 6, 30, 4, 57, 58, 908, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06dfafa4-9df2-492d-86ff-a79d7d77d90b"), "Asperiores tempora sit tenetur est sit ut.", "01325b89-5805-4fb7-9c91-58bd7588d2ef", new DateTime(2020, 9, 19, 15, 50, 17, 20, DateTimeKind.Local).AddTicks(2506), "new", new DateTime(2021, 2, 20, 20, 44, 21, 86, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ba947c9-07bb-4545-9aa2-caa3da92b79f"), "Soluta cupiditate magni.", "c07b7113-4c0b-4544-8ec1-6a94d2661c7c", new DateTime(2021, 7, 18, 23, 24, 59, 184, DateTimeKind.Local).AddTicks(2499), "accepted", new DateTime(2021, 10, 19, 14, 40, 14, 994, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1182e988-cb67-4384-932a-475ae3a629ba"), "Explicabo veritatis perferendis voluptatem sunt sunt facere ut.", "dfdc6677-16a3-479d-a44b-44900ee90f12", new DateTime(2022, 5, 23, 6, 54, 49, 498, DateTimeKind.Local).AddTicks(1954), "whaiting for paymetn", new DateTime(2022, 6, 25, 1, 12, 45, 502, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("672a1cb1-59e2-40c7-b231-5071e5361d6f"), "Molestias vel molestiae.", "62541ee4-49f5-4479-83c1-160c32c078cc", new DateTime(2020, 5, 12, 20, 21, 38, 840, DateTimeKind.Local).AddTicks(1273), "rejected", new DateTime(2020, 11, 25, 17, 48, 1, 310, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb102802-ed82-4f2f-98c5-b0698dcd136b"), "Occaecati animi et quo et saepe saepe corporis et sequi.", "6a45b29b-ffd9-4f36-9e43-7e1dd1d17d8b", new DateTime(2018, 4, 23, 21, 8, 11, 372, DateTimeKind.Local).AddTicks(9816), "send", new DateTime(2019, 5, 3, 8, 5, 36, 32, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.InsertData(
                table: "DocumentType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf2ea1b5-6241-4ebb-87ee-bd2fb17f0373"), "In amet sequi error reprehenderit quas.", "12795dc8-860e-4c58-9519-15382f9ed9ba", new DateTime(2017, 7, 17, 12, 57, 2, 9, DateTimeKind.Local).AddTicks(827), "delivered", new DateTime(2022, 5, 15, 12, 39, 33, 306, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06426630-ac10-4928-b608-906444fc41ca"), "Adipisci impedit id fuga est porro fugit vel minus pariatur.", "d91e6a72-c341-41ff-b75d-a2e54dc17794", new DateTime(2021, 10, 2, 20, 10, 16, 368, DateTimeKind.Local).AddTicks(7214), "Product quaity: voluptatum", new DateTime(2022, 6, 11, 0, 59, 47, 349, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07733441-138a-488f-8705-d81feabd1869"), "Molestias repellendus quia quis consequatur cupiditate facilis nulla.", "4ec1b089-35f2-4b67-8cad-ecb539ab9789", new DateTime(2019, 4, 25, 5, 13, 7, 641, DateTimeKind.Local).AddTicks(6402), "Product quaity: asperiores", new DateTime(2019, 9, 13, 12, 7, 54, 206, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f475b9d-008e-4a6a-8bcd-0bd3b7a57fb1"), "Qui repellendus sunt voluptatum ut sapiente facere.", "bb94d0ff-029f-4cc2-a071-2efc7dd2a2df", new DateTime(2022, 4, 3, 22, 52, 2, 701, DateTimeKind.Local).AddTicks(6585), "Product quaity: quod", new DateTime(2022, 7, 6, 20, 21, 2, 371, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("110dd4e4-539e-453a-91cd-e9981f8758a3"), "Hic earum recusandae voluptatem autem voluptas iste ea repudiandae qui.", "9772abf6-dbf5-486a-b9be-23879a1d23d0", new DateTime(2018, 6, 4, 15, 7, 54, 535, DateTimeKind.Local).AddTicks(8072), "Product quaity: provident", new DateTime(2021, 2, 10, 14, 13, 46, 940, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1330aeb1-be6c-44ab-9f1a-e2fc40762b62"), "Quia odit omnis et repellat et deleniti qui inventore.", "0a38ca6c-b44a-4b4c-965d-432669500994", new DateTime(2021, 12, 23, 5, 14, 47, 190, DateTimeKind.Local).AddTicks(6606), "Product quaity: repudiandae", new DateTime(2022, 1, 7, 4, 8, 36, 25, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1567e6e7-b001-4ffd-9538-9f5bc407568e"), "Aut laboriosam voluptatem nostrum.", "1a02dc33-4a6a-45c9-bafc-8b244861bd72", new DateTime(2022, 4, 30, 18, 1, 35, 867, DateTimeKind.Local).AddTicks(77), "Product quaity: libero", new DateTime(2022, 5, 1, 23, 54, 17, 862, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("18e13c83-dd6e-4518-b34e-5e7aeeb6b78a"), "Exercitationem occaecati quis iure rerum tempora quia ea provident et.", "77d41140-9c49-4ac8-b252-2dcc06226f2c", new DateTime(2018, 7, 15, 14, 15, 28, 83, DateTimeKind.Local).AddTicks(6737), "Product quaity: at", new DateTime(2018, 9, 16, 13, 25, 13, 224, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1a80dc96-31ce-4b28-a8b2-09c6e60f0f27"), "Necessitatibus repudiandae sit eligendi ea aspernatur maiores numquam.", "c1e9b191-8ab3-4aa1-ab7b-fcb2d0110b0f", new DateTime(2018, 12, 5, 11, 48, 8, 712, DateTimeKind.Local).AddTicks(219), "Product quaity: est", new DateTime(2020, 1, 28, 11, 55, 42, 386, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ad0ee87-b60a-445e-afef-e805b3b71031"), "Ex iure aut est et quia rem sit eius iste.", "9cc259b9-18b3-416e-bc32-9772f75f8e90", new DateTime(2018, 10, 28, 20, 53, 39, 307, DateTimeKind.Local).AddTicks(1317), "Product quaity: et", new DateTime(2020, 5, 6, 11, 58, 39, 379, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b9a4ea5-5f73-4fa9-aa4a-bc7dc900c69f"), "Aliquam accusantium necessitatibus vel illum quis.", "32ad0b56-def9-4d67-a6d0-ba1b35bdffdd", new DateTime(2020, 4, 17, 3, 55, 18, 371, DateTimeKind.Local).AddTicks(7880), "Product quaity: voluptatibus", new DateTime(2021, 5, 21, 11, 1, 30, 164, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c923d4e-a475-4b65-ada7-7f3be9a56ddb"), "Iure voluptatem adipisci unde sed et.", "6469b05b-8d39-44b7-bc34-483441e7bded", new DateTime(2020, 8, 18, 3, 10, 59, 110, DateTimeKind.Local).AddTicks(5617), "Product quaity: eos", new DateTime(2022, 6, 24, 3, 50, 27, 103, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ec6c0c8-2475-462e-b172-77a4485cd59e"), "Cumque vero doloribus magni modi nihil.", "f2d6b1e4-23c7-493e-956d-6b67d8128a02", new DateTime(2019, 9, 22, 11, 37, 48, 942, DateTimeKind.Local).AddTicks(5201), "Product quaity: libero", new DateTime(2021, 12, 27, 7, 3, 46, 768, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2185512c-927a-4130-a563-93cee5e0ef16"), "Mollitia aut perferendis aut vel vel officia consequuntur vel velit.", "aaf6b4fd-1e51-4c3c-b401-e94d82b145f4", new DateTime(2021, 6, 22, 18, 50, 23, 462, DateTimeKind.Local).AddTicks(6707), "Product quaity: et", new DateTime(2022, 5, 9, 3, 19, 58, 580, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24f05ea3-7c7e-4e9c-8725-8d74598dcf81"), "Vel qui rerum quae est tempore quas est.", "42dc57b2-7ae3-4136-82e6-9b0caafcba02", new DateTime(2021, 1, 11, 10, 28, 20, 869, DateTimeKind.Local).AddTicks(5321), "Product quaity: in", new DateTime(2021, 6, 6, 16, 29, 46, 631, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2565a801-f3b4-4e9d-9459-f9fba954fc66"), "Omnis dolorum totam ratione autem maxime quibusdam magnam.", "efd092ed-2d83-4091-8f81-2eed043c09ac", new DateTime(2021, 1, 14, 13, 41, 15, 708, DateTimeKind.Local).AddTicks(1632), "Product quaity: voluptatum", new DateTime(2021, 6, 5, 7, 46, 23, 467, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26a89e79-daeb-4e29-b090-2afb5a0e89c9"), "Dicta quia tenetur expedita ipsam cum adipisci.", "ee62a46b-960e-4047-b26a-5520ebfadde8", new DateTime(2020, 8, 10, 16, 1, 34, 986, DateTimeKind.Local).AddTicks(8984), "Product quaity: perspiciatis", new DateTime(2020, 10, 14, 11, 58, 13, 506, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26abab05-633d-4888-9f70-7cd6b05241ed"), "Molestias non sint ipsum provident quisquam atque quo.", "622a9f8f-53d1-4698-897f-d5926239c028", new DateTime(2020, 9, 1, 18, 46, 2, 201, DateTimeKind.Local).AddTicks(9277), "Product quaity: et", new DateTime(2021, 6, 18, 6, 55, 13, 935, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2760af4c-3c00-426f-ae5e-db058be7f886"), "Dolores quis ullam debitis enim.", "ac7490f4-d9fe-4063-9ce2-f618f5ed8013", new DateTime(2017, 8, 2, 17, 53, 34, 689, DateTimeKind.Local).AddTicks(9928), "Product quaity: quisquam", new DateTime(2019, 10, 16, 12, 5, 37, 686, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("285f8ed3-c9f7-46da-8d2d-6fcef1d16a3e"), "Sed et repellendus atque.", "defc7cec-a2fa-4293-b0d0-61d287b563fd", new DateTime(2022, 6, 25, 3, 15, 38, 87, DateTimeKind.Local).AddTicks(8418), "Product quaity: voluptatem", new DateTime(2022, 7, 6, 6, 37, 34, 386, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("286503a9-65b0-46c4-9495-aa458a417b23"), "Voluptatem aliquid commodi rem architecto labore ex.", "b630b83a-4b9b-48a0-9df0-2fa03833ed62", new DateTime(2017, 7, 19, 12, 51, 58, 275, DateTimeKind.Local).AddTicks(2118), "Product quaity: sint", new DateTime(2019, 3, 31, 20, 59, 46, 198, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2c4983f7-fba3-44a5-bf4c-aec361688c60"), "Aut consequatur corporis officiis facere et.", "d063503e-f6e5-48da-bdfd-4911fe278762", new DateTime(2021, 12, 29, 17, 15, 54, 913, DateTimeKind.Local).AddTicks(8792), "Product quaity: dolores", new DateTime(2022, 1, 17, 2, 5, 45, 34, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("348258e0-0136-4577-adbd-cd9a5911abb1"), "Optio officiis quasi quo non aliquid quia.", "e68c4fb7-90a8-4ce5-abe2-391d395fba00", new DateTime(2022, 3, 7, 3, 47, 33, 288, DateTimeKind.Local).AddTicks(8017), "Product quaity: cupiditate", new DateTime(2022, 6, 13, 3, 55, 28, 952, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("34d8eadc-396c-4a50-8bb1-361c6f0ea214"), "Et eum quos in animi facilis doloremque consequatur eum libero.", "150d909c-1ce3-44da-a0c3-acefa15d1c27", new DateTime(2021, 12, 2, 8, 30, 58, 576, DateTimeKind.Local).AddTicks(885), "Product quaity: odit", new DateTime(2022, 3, 30, 3, 47, 48, 754, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("36145a1a-727e-4a6b-9fef-04f353a95a78"), "Error soluta eaque.", "f0276fab-e058-4872-b9bc-c5b7293b40d5", new DateTime(2021, 6, 9, 8, 36, 56, 208, DateTimeKind.Local).AddTicks(4412), "Product quaity: aut", new DateTime(2021, 11, 30, 7, 33, 15, 946, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3802f856-5455-4dc2-a23d-6c44928c5226"), "Sunt culpa repellat suscipit non earum soluta aperiam a.", "72c0a683-6338-4b29-b9c9-ba5021ade837", new DateTime(2017, 12, 14, 6, 28, 42, 650, DateTimeKind.Local).AddTicks(3242), "Product quaity: doloribus", new DateTime(2018, 11, 2, 21, 32, 43, 443, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38b4dbb6-eaaf-4c6e-812c-544b10385337"), "Et temporibus sapiente autem minus dolorem odit molestiae qui accusantium.", "ac5a7306-0630-47e4-b233-3753cb511b98", new DateTime(2018, 4, 23, 16, 11, 6, 690, DateTimeKind.Local).AddTicks(7109), "Product quaity: ut", new DateTime(2020, 10, 13, 22, 21, 27, 993, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3bb5faa4-c9a8-40b3-b24a-81ca8a6deb8a"), "Corporis minus sed qui et ea et maiores occaecati.", "e44edc88-b2d4-4d39-ae1c-5d2fa70ff174", new DateTime(2020, 9, 25, 4, 41, 11, 627, DateTimeKind.Local).AddTicks(7660), "Product quaity: doloribus", new DateTime(2022, 4, 23, 6, 19, 36, 169, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("430c4155-792e-496b-9e0b-0fc1126b1f88"), "Hic et numquam qui voluptatem eos.", "2851b00e-3c80-454a-8392-d010eaeefa2f", new DateTime(2022, 5, 6, 0, 39, 11, 57, DateTimeKind.Local).AddTicks(1187), "Product quaity: qui", new DateTime(2022, 5, 15, 11, 41, 21, 430, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("452ff73a-2bc8-47f6-b4cb-aff8e1b97841"), "Et accusantium ipsum incidunt aut sequi deserunt quo aut.", "31278703-b912-4584-9b99-9c9a0aaae0d2", new DateTime(2021, 12, 4, 11, 45, 12, 138, DateTimeKind.Local).AddTicks(5482), "Product quaity: dolor", new DateTime(2022, 2, 23, 3, 23, 12, 292, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49a91aa4-630d-4716-9247-2953477fb18f"), "Omnis non enim.", "52dc16ef-db15-4f7d-b402-a7dea754a117", new DateTime(2017, 9, 9, 13, 34, 26, 301, DateTimeKind.Local).AddTicks(6548), "Product quaity: non", new DateTime(2018, 10, 31, 8, 30, 1, 291, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4a81d4ef-4221-4a77-b788-f2ea1b93bd77"), "Quo non quisquam ullam accusantium eos minima numquam.", "10f7980d-b936-4b56-8360-6fa0e7370926", new DateTime(2020, 8, 12, 7, 53, 56, 722, DateTimeKind.Local).AddTicks(5162), "Product quaity: consequatur", new DateTime(2022, 5, 19, 9, 16, 53, 857, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4d7ae5da-f2f5-4308-a511-d39fc9d45646"), "Fuga et veniam voluptatem dolorem aspernatur.", "9a9d1967-4cfb-43a0-9d13-28f0d296ab00", new DateTime(2019, 10, 27, 7, 55, 46, 442, DateTimeKind.Local).AddTicks(1874), "Product quaity: expedita", new DateTime(2022, 5, 20, 5, 13, 9, 661, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("514d2ddd-46e2-4de7-8662-126df53e19fc"), "Asperiores distinctio voluptatem.", "9bf990cf-4eb9-47d1-8e01-d1af4cba7b0d", new DateTime(2020, 8, 22, 22, 52, 56, 520, DateTimeKind.Local).AddTicks(4349), "Product quaity: quos", new DateTime(2020, 10, 10, 21, 10, 44, 716, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("57f6ec81-1f28-492c-8743-292a01972b25"), "Velit saepe qui sunt repudiandae velit ut nihil quia.", "e788be20-8b26-4439-80b9-ebdbdacfa03f", new DateTime(2022, 1, 3, 18, 57, 49, 954, DateTimeKind.Local).AddTicks(640), "Product quaity: ipsa", new DateTime(2022, 1, 5, 9, 58, 49, 914, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59f88a67-3c66-433f-ad59-e5c0545deef0"), "Voluptatum ut sit quidem omnis non autem repudiandae ipsum beatae.", "31cfe49e-4fe4-4cdc-b45e-786bb9e46955", new DateTime(2018, 1, 18, 2, 2, 20, 911, DateTimeKind.Local).AddTicks(8754), "Product quaity: modi", new DateTime(2022, 2, 21, 5, 45, 18, 397, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a16b779-b077-4c8c-b566-aef05e425d99"), "Neque debitis consequatur.", "a738ae78-210c-42ac-a03b-8e483a6a16ef", new DateTime(2019, 1, 25, 6, 55, 53, 639, DateTimeKind.Local).AddTicks(5019), "Product quaity: est", new DateTime(2021, 5, 17, 19, 43, 50, 967, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a30c370-b517-4cce-96dc-375e168152ba"), "Veniam molestiae dicta numquam.", "46eecbbf-de38-46ed-9740-a05e80beb8d6", new DateTime(2021, 10, 29, 5, 51, 58, 412, DateTimeKind.Local).AddTicks(6460), "Product quaity: suscipit", new DateTime(2022, 5, 25, 6, 58, 20, 853, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5bf852e4-63ca-46a7-8df5-df861a922bf3"), "Facere quia commodi et accusantium aut assumenda.", "ab1a4e5b-ad6e-4c90-8f66-d9b4536a6949", new DateTime(2017, 11, 6, 13, 59, 33, 349, DateTimeKind.Local).AddTicks(2885), "Product quaity: et", new DateTime(2021, 10, 10, 19, 50, 52, 562, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d368c61-ff5f-4977-a0e8-e780e5e7804a"), "Officiis sunt in quia adipisci facere quod.", "64584a7b-6aeb-4486-a05e-a6158c2c85a8", new DateTime(2018, 5, 27, 17, 28, 29, 720, DateTimeKind.Local).AddTicks(7248), "Product quaity: voluptatem", new DateTime(2022, 5, 31, 9, 48, 31, 645, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5da5f836-0b3c-4712-bac0-2c1c6b6d2998"), "Ut quo maxime a laudantium porro dolor ea.", "95390f4f-eff3-49a2-800d-4e67979a6f6b", new DateTime(2021, 1, 11, 9, 1, 57, 937, DateTimeKind.Local).AddTicks(5681), "Product quaity: totam", new DateTime(2021, 8, 18, 14, 32, 49, 54, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e56d9d2-ea70-497e-8b9f-06efb77e4d3a"), "Dolorem qui accusamus.", "1dc13960-cf17-485c-bf6f-7bcaf931b5e4", new DateTime(2020, 11, 27, 21, 2, 41, 624, DateTimeKind.Local).AddTicks(367), "Product quaity: cum", new DateTime(2020, 12, 8, 15, 36, 0, 734, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("63273ce6-ee0d-4075-97ba-9b241ce95edd"), "Officiis quis ducimus ut omnis tempore eligendi vero est dolorem.", "8bb62cbc-53a7-47b6-ae24-cd373bdb1eb1", new DateTime(2018, 2, 12, 17, 40, 9, 702, DateTimeKind.Local).AddTicks(2954), "Product quaity: id", new DateTime(2022, 1, 15, 9, 42, 5, 730, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("660173f1-7f5d-43de-8637-e5b0653c8470"), "Fuga nobis assumenda atque nihil dolor voluptas.", "dbd6426a-d477-46a7-a575-46d9b82494fa", new DateTime(2022, 2, 18, 23, 0, 40, 554, DateTimeKind.Local).AddTicks(6948), "Product quaity: neque", new DateTime(2022, 3, 2, 0, 18, 6, 267, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("683e36af-0753-4980-9133-4b9434c13265"), "Dolorem pariatur omnis iste.", "1c43e9db-21a6-4fd5-9750-729088cf9837", new DateTime(2020, 1, 19, 16, 49, 25, 751, DateTimeKind.Local).AddTicks(6528), "Product quaity: voluptatem", new DateTime(2021, 8, 5, 2, 44, 39, 132, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("71e3a8f1-e840-4a61-93e9-b56c29a6702d"), "Vel odit temporibus.", "48000133-034e-44ac-8d1b-e0b017da03af", new DateTime(2017, 10, 12, 20, 46, 47, 740, DateTimeKind.Local).AddTicks(2635), "Product quaity: hic", new DateTime(2020, 2, 25, 4, 14, 31, 449, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7267bda0-8500-4e5d-9e9b-026687a7d231"), "Ducimus consequatur assumenda quos.", "8bf5a117-19e1-4e26-ab1f-9fe75236a8b2", new DateTime(2018, 11, 7, 0, 36, 55, 526, DateTimeKind.Local).AddTicks(2049), "Product quaity: cumque", new DateTime(2020, 7, 16, 14, 46, 45, 480, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73a6801a-6418-4933-9c77-b877c3b587c5"), "Reiciendis voluptas occaecati maxime asperiores quis.", "e4a4396b-84d7-4d3c-9dde-c97cfe0a4fb9", new DateTime(2021, 2, 2, 4, 14, 21, 803, DateTimeKind.Local).AddTicks(744), "Product quaity: et", new DateTime(2021, 5, 16, 4, 36, 59, 258, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75c2a6b7-3de2-4d3f-b1b7-67d5fc4636b9"), "Nam voluptatibus est modi placeat soluta aut odit incidunt.", "9c7b2bfd-c7eb-4d89-b3c8-8bbee70abc5c", new DateTime(2021, 10, 1, 15, 44, 36, 60, DateTimeKind.Local).AddTicks(2626), "Product quaity: labore", new DateTime(2022, 5, 21, 12, 53, 19, 590, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75ff00ee-c312-4a9b-895c-39d0a34d944a"), "Minus non sit.", "294a3048-0355-4af9-9dc8-658800c82996", new DateTime(2017, 10, 24, 11, 21, 14, 674, DateTimeKind.Local).AddTicks(4972), "Product quaity: atque", new DateTime(2020, 4, 13, 7, 14, 23, 422, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7818a14b-cf09-4836-a3bc-bc9b6fbdc3df"), "Totam beatae consequatur.", "b5b7c0fa-1e07-4510-b163-f22cfa4c6ba1", new DateTime(2018, 6, 11, 18, 57, 26, 121, DateTimeKind.Local).AddTicks(622), "Product quaity: adipisci", new DateTime(2019, 7, 17, 0, 31, 9, 973, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7a41bf98-df0f-4531-8b6f-254434704cda"), "Et et dicta ea omnis.", "f41a796a-7b09-48da-bb57-f4e40f1179a8", new DateTime(2018, 11, 4, 14, 39, 17, 251, DateTimeKind.Local).AddTicks(670), "Product quaity: sit", new DateTime(2022, 3, 9, 17, 2, 20, 88, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b26c1b3-bb1c-4d14-92e7-f443645362fb"), "Soluta et maiores.", "701e0fda-96af-4e1c-8115-592993f432bb", new DateTime(2019, 7, 2, 12, 55, 36, 932, DateTimeKind.Local).AddTicks(7779), "Product quaity: eum", new DateTime(2019, 11, 12, 18, 53, 44, 244, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7d23e001-73a0-4045-8237-1a5e93977d5d"), "Cupiditate ullam aut beatae quisquam.", "cb6b626e-8a5e-4bab-90cc-ed6c4c93de82", new DateTime(2020, 11, 10, 11, 35, 55, 63, DateTimeKind.Local).AddTicks(7769), "Product quaity: molestias", new DateTime(2021, 8, 7, 12, 34, 32, 461, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("81f53650-b9ae-440b-ba8c-d37c6a3475ee"), "Optio provident officia aut maiores non deserunt minus.", "8254148b-2c72-4ba9-aae6-446de5593e49", new DateTime(2019, 11, 23, 0, 0, 15, 454, DateTimeKind.Local).AddTicks(1289), "Product quaity: quas", new DateTime(2021, 4, 23, 15, 25, 51, 194, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("82a1d970-2d0d-4dd4-9b5b-d1d0312eabe7"), "Voluptatem ea illo at accusantium dolorum debitis laborum.", "e9786819-0033-4da4-b97c-cf9a4c6ad1f5", new DateTime(2021, 4, 23, 16, 11, 47, 259, DateTimeKind.Local).AddTicks(4393), "Product quaity: fuga", new DateTime(2022, 1, 15, 17, 26, 26, 620, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("83fc39e3-1d6c-4b43-b0c5-19331efb47bf"), "Suscipit hic nisi voluptatem laudantium.", "24c39618-bf64-4456-9380-8d4cd64e632b", new DateTime(2019, 9, 17, 20, 3, 19, 803, DateTimeKind.Local).AddTicks(2647), "Product quaity: quas", new DateTime(2021, 5, 21, 1, 27, 49, 491, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84936762-a8ec-4fd9-9f66-59fa95829986"), "Et et modi est aliquid molestiae exercitationem.", "d21deb08-8312-4141-86e1-8b061b767620", new DateTime(2020, 2, 21, 10, 55, 57, 393, DateTimeKind.Local).AddTicks(8980), "Product quaity: est", new DateTime(2022, 2, 10, 4, 50, 2, 53, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8da9c202-f2ee-430e-a154-ea1be9a21a2f"), "Odio sapiente in minima adipisci itaque sed qui nemo.", "11c883c7-fd84-440a-97cb-3b2ae7cefde8", new DateTime(2022, 5, 6, 11, 16, 42, 709, DateTimeKind.Local).AddTicks(8877), "Product quaity: consequatur", new DateTime(2022, 5, 21, 8, 20, 55, 871, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ef7e156-e55d-46fc-8661-88355d5b935a"), "Maiores similique atque rerum a.", "476e5091-2b98-4215-a45e-df67c51423bd", new DateTime(2020, 5, 15, 4, 59, 14, 578, DateTimeKind.Local).AddTicks(7817), "Product quaity: atque", new DateTime(2021, 5, 18, 21, 38, 56, 642, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f267c66-b3c9-4d84-ab91-c370c5a33fbf"), "Eveniet architecto voluptatem est.", "fc6f469b-1b28-4802-be2e-9ec2a6657b44", new DateTime(2020, 9, 15, 18, 11, 14, 203, DateTimeKind.Local).AddTicks(1154), "Product quaity: accusantium", new DateTime(2021, 2, 3, 18, 54, 4, 897, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f880436-0e57-4895-8123-efa320e58d49"), "Nobis sint velit libero sit minima aspernatur non.", "d1c36f24-ed49-4bf6-87bc-15d8d9628150", new DateTime(2018, 11, 6, 18, 30, 34, 633, DateTimeKind.Local).AddTicks(4594), "Product quaity: enim", new DateTime(2022, 5, 12, 11, 15, 48, 141, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("95a812d6-1bc4-4025-a0ee-b113477fd78a"), "Iste corrupti autem id quisquam autem aspernatur fugit eos magni.", "731fe22b-d645-48cc-8dfe-066f985626c2", new DateTime(2022, 6, 26, 4, 30, 52, 179, DateTimeKind.Local).AddTicks(8201), "Product quaity: et", new DateTime(2022, 6, 27, 0, 8, 38, 291, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("96a25170-e59a-4b19-ad11-15b8ab878ba0"), "Vel ducimus dignissimos molestiae aut.", "65bc6d6c-9980-4ed2-b459-75493b9f3b2c", new DateTime(2017, 11, 22, 7, 7, 17, 609, DateTimeKind.Local).AddTicks(6054), "Product quaity: dolores", new DateTime(2021, 4, 15, 20, 1, 21, 487, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("972adf90-1ba6-4351-9279-c7f736d61138"), "Quasi corporis minus temporibus.", "f0a64f4b-2bf3-4c72-b5e7-2d186f5c7e03", new DateTime(2017, 10, 17, 1, 48, 43, 782, DateTimeKind.Local).AddTicks(8691), "Product quaity: id", new DateTime(2020, 11, 14, 12, 41, 34, 614, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("98040b05-f238-42ef-a29d-162228f5a15c"), "Culpa quis fuga sint et.", "9dacdb71-3194-419a-a7ca-d03ec203f508", new DateTime(2020, 12, 25, 9, 30, 50, 515, DateTimeKind.Local).AddTicks(4877), "Product quaity: blanditiis", new DateTime(2021, 1, 24, 8, 58, 55, 946, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99961b65-bf39-4993-a3fd-051d13921dea"), "Nisi voluptas minus voluptatum.", "0e45b946-7eb6-46fa-a446-ca1ef57cad05", new DateTime(2018, 1, 18, 11, 53, 36, 142, DateTimeKind.Local).AddTicks(42), "Product quaity: iste", new DateTime(2021, 5, 7, 0, 25, 3, 337, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9cea98a2-d2e2-4d2c-a0b2-45935bf30fba"), "Aspernatur nam maiores ducimus provident dolorem quo.", "9bb1c601-31d9-4d82-a667-b7f5812146bb", new DateTime(2019, 2, 28, 6, 7, 9, 817, DateTimeKind.Local).AddTicks(8226), "Product quaity: repudiandae", new DateTime(2020, 3, 25, 6, 13, 27, 958, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d657fa8-0659-4b65-ba68-69790822c671"), "Perferendis quam corporis quo et debitis.", "f349e014-607c-46fe-bd50-f9188b6acdd3", new DateTime(2022, 5, 24, 21, 19, 56, 114, DateTimeKind.Local).AddTicks(9882), "Product quaity: ducimus", new DateTime(2022, 6, 22, 23, 53, 4, 782, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9db2d644-a422-4abb-8e55-25ac93d9ab13"), "Tenetur officiis molestiae fugit commodi quos nobis in et optio.", "938eec8e-75ac-40ad-8334-a0841bd3f07f", new DateTime(2017, 10, 27, 9, 3, 12, 521, DateTimeKind.Local).AddTicks(9706), "Product quaity: ut", new DateTime(2021, 2, 28, 2, 15, 12, 937, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a34bd247-2da9-40b3-9b53-7f02e0eabfa0"), "Eaque est illum repellendus id.", "2844d18d-81b2-4c9c-80cc-96b84b287059", new DateTime(2018, 2, 24, 6, 48, 11, 435, DateTimeKind.Local).AddTicks(4639), "Product quaity: commodi", new DateTime(2018, 11, 25, 7, 32, 39, 474, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5e522e1-a456-4cbf-9ab3-65806a718a83"), "Eligendi sed earum consequatur nesciunt unde non.", "1003117d-63e5-40f2-8862-d5d717c7e762", new DateTime(2020, 9, 25, 2, 46, 28, 247, DateTimeKind.Local).AddTicks(3246), "Product quaity: consequatur", new DateTime(2022, 3, 4, 19, 43, 34, 734, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a8924fa8-c3f6-4646-aa42-13d2f73239c3"), "Perferendis beatae eos provident quo qui voluptatem omnis.", "57dc59e9-8775-4786-a4b6-f19cc37a1026", new DateTime(2019, 7, 26, 2, 33, 11, 358, DateTimeKind.Local).AddTicks(2254), "Product quaity: voluptatibus", new DateTime(2020, 1, 9, 9, 0, 46, 438, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9cb2310-e7c8-4ca3-88e2-006c28a8d12e"), "Commodi et aliquid aut repellat qui exercitationem ut omnis magni.", "414674b7-dd7c-4d5d-af13-9782e3f7ea6f", new DateTime(2022, 2, 2, 22, 36, 55, 818, DateTimeKind.Local).AddTicks(3324), "Product quaity: repudiandae", new DateTime(2022, 4, 3, 9, 40, 7, 274, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3b7f7e7-48b5-4664-a2eb-3675d8298846"), "Quaerat ut necessitatibus aut dolor doloremque pariatur.", "7ab7fcfb-e171-458e-9b24-bd24a226ea09", new DateTime(2018, 12, 12, 0, 30, 34, 736, DateTimeKind.Local).AddTicks(94), "Product quaity: aut", new DateTime(2021, 8, 9, 1, 28, 33, 418, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b637da3d-3718-4713-938e-dde5553e562c"), "Ratione voluptatem nihil rem quo necessitatibus reiciendis.", "9bb184d7-e04f-4809-b378-1ec5af02ce08", new DateTime(2022, 1, 2, 9, 6, 17, 236, DateTimeKind.Local).AddTicks(5107), "Product quaity: mollitia", new DateTime(2022, 3, 21, 14, 14, 13, 175, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b7eaa776-358e-4a59-a81f-6b713b4b517e"), "Minima aut animi autem eum quia saepe sed.", "8a8242fa-fb1f-49b8-96b6-e4a3429e98b7", new DateTime(2021, 12, 3, 9, 46, 53, 987, DateTimeKind.Local).AddTicks(1656), "Product quaity: molestiae", new DateTime(2022, 1, 29, 1, 13, 47, 259, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b93aafa5-099b-4242-bd06-f0f645453142"), "Sit inventore eligendi minima facere molestias reprehenderit.", "9c67ec9c-ebbb-49aa-88f0-724a852f1cc6", new DateTime(2022, 2, 15, 19, 14, 44, 877, DateTimeKind.Local).AddTicks(4339), "Product quaity: et", new DateTime(2022, 5, 6, 4, 12, 36, 133, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba7ed755-8738-401f-8f21-a15b65b797ad"), "Soluta magni perspiciatis facere voluptatum aut quasi voluptatum.", "a2cae8cb-a532-4b7a-a26e-d6497d256c3a", new DateTime(2017, 10, 17, 16, 19, 49, 449, DateTimeKind.Local).AddTicks(9234), "Product quaity: vero", new DateTime(2021, 5, 6, 16, 7, 11, 323, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("badb9e16-c3c5-47ae-94a7-9bcc9d3d6de4"), "Perspiciatis est magnam dolore in fugit qui.", "b07e8687-da3c-472c-bfcb-10c454656d60", new DateTime(2019, 1, 25, 3, 33, 50, 205, DateTimeKind.Local).AddTicks(6650), "Product quaity: at", new DateTime(2020, 11, 10, 15, 25, 40, 427, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc82eda1-1b3d-4d16-8c50-deb2f28e1dcb"), "Amet quibusdam corporis dolores quibusdam sapiente et quia fugit illo.", "74b12287-5245-43a9-9172-062108fc61e6", new DateTime(2018, 1, 12, 15, 1, 21, 320, DateTimeKind.Local).AddTicks(4786), "Product quaity: sit", new DateTime(2021, 1, 29, 17, 50, 43, 828, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1808c0b-9d4b-49b5-8910-486153b5ff6e"), "Ipsam dicta labore modi nesciunt aut ea ut praesentium.", "02cb1f8f-6255-4fc7-9f3f-5a410f8c6e0a", new DateTime(2018, 8, 26, 12, 2, 1, 575, DateTimeKind.Local).AddTicks(5358), "Product quaity: quia", new DateTime(2020, 1, 11, 17, 39, 43, 414, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c89808cd-01bb-4f6e-8345-49c29e741d8c"), "Voluptatem animi consequatur natus aliquid rem expedita vel praesentium quo.", "3422519b-dc1e-49fd-b0b6-54eeef156b17", new DateTime(2019, 6, 10, 1, 56, 38, 525, DateTimeKind.Local).AddTicks(5257), "Product quaity: ut", new DateTime(2021, 11, 20, 0, 35, 11, 89, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8c93114-68ae-4dec-80e2-c8b6d65a0053"), "Reiciendis aut debitis inventore similique.", "93316db7-1837-4274-b799-f438f12c6009", new DateTime(2021, 5, 14, 17, 28, 16, 11, DateTimeKind.Local).AddTicks(3966), "Product quaity: ut", new DateTime(2021, 8, 14, 5, 5, 45, 451, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf0b9059-89e5-4a54-90ec-99df18267eb7"), "Voluptate error sint repellat porro amet dolor sed modi.", "fe291a11-f10a-43d4-b6be-693dc37c04b6", new DateTime(2020, 4, 17, 2, 24, 52, 513, DateTimeKind.Local).AddTicks(2510), "Product quaity: assumenda", new DateTime(2022, 6, 29, 16, 40, 24, 229, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d269a64b-775b-404f-9aca-bc1ca93fd609"), "Cupiditate suscipit est ut.", "e195d302-292f-4a62-8f9f-abf676eea23a", new DateTime(2021, 6, 25, 19, 40, 42, 806, DateTimeKind.Local).AddTicks(544), "Product quaity: molestiae", new DateTime(2022, 1, 3, 1, 32, 17, 978, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d94da0c3-2e34-4eb9-b4e1-8f89f146f48c"), "Sed maxime facere modi.", "4c337560-1808-4819-a996-58b5220c4b09", new DateTime(2021, 4, 2, 8, 17, 0, 220, DateTimeKind.Local).AddTicks(8348), "Product quaity: repudiandae", new DateTime(2021, 6, 21, 1, 26, 7, 693, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dacd97f4-def2-4d8d-92f2-ad66a0605a2f"), "Velit dolorem dicta maxime.", "847470c4-e49a-4bc3-bbfa-dd1a41b963d3", new DateTime(2021, 10, 2, 1, 44, 29, 183, DateTimeKind.Local).AddTicks(5663), "Product quaity: vitae", new DateTime(2022, 6, 28, 14, 15, 14, 971, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ddca6eb6-4a3e-4515-9f40-e5a734fb9156"), "Dolorem omnis sed consectetur.", "978a6f2b-7c7a-48ea-bba0-9ead4d4d5af0", new DateTime(2021, 8, 20, 15, 28, 22, 397, DateTimeKind.Local).AddTicks(7398), "Product quaity: molestiae", new DateTime(2022, 4, 16, 12, 52, 21, 13, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1f26a47-137a-4ff4-9cb8-8663332c5610"), "Aut et reprehenderit voluptate et omnis.", "1bf58c13-1bef-4412-9df1-93a31910b77e", new DateTime(2017, 7, 13, 19, 53, 55, 470, DateTimeKind.Local).AddTicks(7260), "Product quaity: sint", new DateTime(2021, 10, 7, 16, 26, 48, 583, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e46b4772-ea58-4146-a790-325b98ff7063"), "Blanditiis corrupti velit sed unde.", "89f3b3b2-5775-4d61-9042-86a35db800d5", new DateTime(2019, 8, 4, 20, 29, 8, 937, DateTimeKind.Local).AddTicks(1768), "Product quaity: vero", new DateTime(2022, 6, 19, 7, 24, 15, 565, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8a1859d-749b-440f-bf0a-76c13c172e96"), "Dolor ut explicabo aliquid sapiente est incidunt illum et.", "69cbd778-87f1-4b82-aa75-be32e46f0d07", new DateTime(2019, 10, 14, 20, 29, 12, 117, DateTimeKind.Local).AddTicks(4438), "Product quaity: quam", new DateTime(2021, 8, 5, 19, 26, 8, 300, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eaa9739a-e6b4-4fc1-820c-14470e27a3b2"), "Nisi amet quo.", "a3537b4f-cbcd-4aec-96a7-a091241baaa7", new DateTime(2020, 8, 9, 0, 37, 37, 96, DateTimeKind.Local).AddTicks(9663), "Product quaity: eos", new DateTime(2021, 12, 13, 22, 22, 4, 861, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ebf8c51d-aec8-4edf-8b73-93d3e8617e58"), "Repellat aut impedit dolor sit perferendis quibusdam est.", "3782dbbe-2231-4b17-945b-401ffce07cc3", new DateTime(2018, 1, 21, 13, 49, 10, 306, DateTimeKind.Local).AddTicks(2294), "Product quaity: quisquam", new DateTime(2021, 8, 19, 9, 16, 31, 25, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f03f4bab-83b6-4852-99bb-a01173a0f171"), "Aut eius recusandae rerum provident dolorum rem facere necessitatibus sint.", "a00befef-3850-41d5-8307-995cec000701", new DateTime(2022, 5, 6, 5, 12, 44, 677, DateTimeKind.Local).AddTicks(5791), "Product quaity: molestiae", new DateTime(2022, 5, 26, 13, 17, 31, 650, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f1bf6cbd-c9f7-4df8-b6ba-da68fe7b0c85"), "Reiciendis dolor veritatis voluptatem temporibus consequatur molestias harum illo deleniti.", "ee15111e-abc1-4255-87e3-9824f36f4ddb", new DateTime(2018, 10, 10, 19, 37, 23, 375, DateTimeKind.Local).AddTicks(9690), "Product quaity: velit", new DateTime(2021, 11, 14, 2, 19, 57, 465, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f49f266e-376d-4af5-8286-02458692d27f"), "Fuga cupiditate magnam.", "a9527e08-f103-4e02-a839-e0a157c22d79", new DateTime(2019, 3, 10, 10, 55, 43, 639, DateTimeKind.Local).AddTicks(5921), "Product quaity: fugit", new DateTime(2021, 6, 15, 0, 41, 45, 984, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f592ca7c-dd06-4e8b-a52f-7d9346814985"), "Veritatis et est ea sequi ut aut ratione dicta.", "5cd1a777-eb7b-4855-87eb-35db90eb5850", new DateTime(2019, 11, 24, 23, 25, 57, 843, DateTimeKind.Local).AddTicks(7176), "Product quaity: autem", new DateTime(2021, 3, 11, 13, 12, 7, 881, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f69ebbe6-6cd3-458d-bef3-f2e04b45af1c"), "Eaque officia omnis consequatur qui aut ratione.", "431f96e0-e490-40f9-9871-3914abea6194", new DateTime(2019, 8, 12, 15, 33, 31, 680, DateTimeKind.Local).AddTicks(5697), "Product quaity: et", new DateTime(2019, 12, 3, 2, 20, 38, 848, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6ee1cc4-0579-44b9-ab33-d2e974da9c8e"), "Voluptatem esse doloremque modi ea recusandae quidem hic quasi.", "e00de655-b10e-4f98-81ad-429e4a6b0cae", new DateTime(2022, 3, 9, 0, 54, 1, 872, DateTimeKind.Local).AddTicks(5270), "Product quaity: vel", new DateTime(2022, 4, 8, 23, 59, 32, 660, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.InsertData(
                table: "ItmeQualityes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f76ff87d-d65a-4fc3-9dfe-4aff130442b9"), "Fugiat vitae amet nihil et maxime vel aperiam dignissimos.", "0c8af1bc-e825-4734-a506-4a10d79610b8", new DateTime(2020, 6, 26, 9, 48, 20, 471, DateTimeKind.Local).AddTicks(2413), "Product quaity: velit", new DateTime(2020, 8, 29, 20, 47, 42, 317, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("076e47c4-217e-4783-94a9-2b292dc6fa6c"), "Assumenda delectus iure.", "4fdc562a-9464-4f5f-ae61-3cfc7d6c4637", new DateTime(2022, 3, 29, 6, 6, 59, 157, DateTimeKind.Local).AddTicks(6576), "Organization Hyatt - Hagenes", new DateTime(2022, 5, 27, 10, 15, 33, 117, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07ab8cea-738f-4a8a-b5ce-816f797e276a"), "Ex cum labore aperiam at.", "35402f6d-5690-4cf5-8740-d8901ea8c583", new DateTime(2022, 4, 3, 20, 18, 49, 413, DateTimeKind.Local).AddTicks(3119), "Organization Wolff, Brakus and Conroy", new DateTime(2022, 5, 8, 13, 36, 3, 600, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("09721754-a981-433c-8eb9-55a11c7bf5d9"), "Repudiandae quia quo rerum qui eaque.", "d8230e54-f0f6-4754-a018-fc19e870db57", new DateTime(2019, 2, 26, 3, 50, 20, 91, DateTimeKind.Local).AddTicks(6173), "Organization Lehner - Hamill", new DateTime(2019, 8, 15, 6, 40, 10, 688, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a0b7b80-bd31-40d0-a25b-d070c29e1e51"), "Et mollitia in temporibus esse repellat molestiae eum pariatur.", "15078d47-7165-46b9-b030-97efda21e170", new DateTime(2021, 7, 9, 4, 59, 48, 996, DateTimeKind.Local).AddTicks(4946), "Organization Tillman and Sons", new DateTime(2022, 2, 1, 9, 38, 59, 929, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a9cdd37-e53a-403b-9ccf-3ef175350893"), "Adipisci inventore voluptatum qui.", "0964e5e5-4a3a-4bca-8fb3-dc298c3e2c49", new DateTime(2022, 1, 16, 18, 42, 42, 763, DateTimeKind.Local).AddTicks(542), "Organization Harvey - Koss", new DateTime(2022, 3, 2, 8, 6, 45, 129, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11a53af6-8893-4898-a149-ed2b78a8aa68"), "Vero dolorum rerum nihil.", "5b8b417b-b4aa-4026-a0a8-d2f32694cce3", new DateTime(2021, 12, 1, 6, 17, 9, 975, DateTimeKind.Local).AddTicks(5278), "Organization Medhurst - Emmerich", new DateTime(2022, 2, 8, 12, 27, 6, 451, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("147be1bf-348c-4660-9f5a-a8b56cee7df0"), "Deserunt sed neque vitae.", "b47eeaf7-5990-496c-870e-e8d1fa7990ed", new DateTime(2017, 12, 13, 13, 15, 44, 365, DateTimeKind.Local).AddTicks(7079), "Organization Friesen, Harber and Renner", new DateTime(2018, 5, 14, 6, 14, 16, 381, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("14e0e4a9-a784-48c3-a044-4bf50a31f160"), "Veniam tenetur molestias at quis id earum blanditiis quisquam.", "53dee70d-cd4b-4035-b3fa-4f97dd2b7c3a", new DateTime(2020, 11, 21, 2, 41, 30, 771, DateTimeKind.Local).AddTicks(5743), "Organization Crona - Cummings", new DateTime(2021, 9, 9, 5, 12, 18, 247, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("152bccc0-27ef-4ad0-886c-c16a57fdcca7"), "Delectus officia velit est debitis consequatur consequuntur sit.", "b141b30d-701d-4d1b-8aec-aa88707191fc", new DateTime(2018, 4, 1, 17, 25, 9, 961, DateTimeKind.Local).AddTicks(9169), "Organization Cummings - Beatty", new DateTime(2021, 8, 21, 8, 16, 59, 186, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1bfc4cc8-a5c8-4633-b01a-2ab4195a8a71"), "Voluptatem et ut nesciunt quaerat.", "323884df-768a-4c2b-afea-35a5c897af55", new DateTime(2021, 4, 7, 7, 59, 2, 895, DateTimeKind.Local).AddTicks(1357), "Organization Pagac LLC", new DateTime(2022, 4, 4, 21, 8, 0, 7, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1d3f7a53-69ce-43b9-9879-b7d8159286c4"), "Quaerat nostrum omnis rerum praesentium excepturi deleniti.", "916dca1a-da78-4c9a-98e2-e270de2097d1", new DateTime(2017, 7, 7, 10, 51, 37, 590, DateTimeKind.Local).AddTicks(9506), "Organization Hane and Sons", new DateTime(2020, 6, 2, 14, 8, 24, 106, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1d6e013e-c969-4c86-ac87-d415bae306ea"), "Eum qui possimus sint rem voluptatem.", "af8bcba2-612b-4a40-9675-8d29f0e3b759", new DateTime(2017, 10, 8, 9, 6, 5, 392, DateTimeKind.Local).AddTicks(6710), "Organization Gutmann LLC", new DateTime(2021, 11, 1, 8, 32, 10, 791, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26e8d8cc-6e10-4af1-9c5a-151d6de58109"), "Et provident ea enim dignissimos incidunt quaerat quis.", "0a93ca51-3409-4a3a-9e35-2d487fd29ef7", new DateTime(2020, 10, 22, 23, 14, 34, 457, DateTimeKind.Local).AddTicks(4580), "Organization Schmidt, Hoppe and Gulgowski", new DateTime(2021, 9, 6, 3, 58, 12, 159, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("27404452-74bf-44ef-baae-aca4d86689af"), "Ut amet quam exercitationem dolorum aut.", "b713eea2-3875-4e63-af6d-bb6dc474228f", new DateTime(2018, 7, 28, 3, 39, 10, 732, DateTimeKind.Local).AddTicks(9508), "Organization Leuschke - Considine", new DateTime(2021, 7, 2, 6, 9, 44, 659, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2771998b-1f3b-4cd9-a5e2-4d9ee61e64a5"), "Aut et est porro quia dolor.", "61cc9dd2-78a5-4a66-a907-f944d09a077c", new DateTime(2019, 12, 11, 16, 16, 12, 116, DateTimeKind.Local).AddTicks(8397), "Organization Simonis, Schumm and Predovic", new DateTime(2020, 7, 10, 13, 23, 58, 205, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2af5f22f-fae6-4e1e-b6f1-81dd6be03489"), "Quibusdam hic inventore quia et corrupti neque architecto sunt.", "01714e0a-98f8-4441-ae93-85c6aae5ff20", new DateTime(2020, 7, 14, 6, 23, 12, 258, DateTimeKind.Local).AddTicks(4331), "Organization Hagenes, Keebler and McDermott", new DateTime(2022, 2, 3, 17, 41, 18, 152, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30470be8-2236-47f2-9193-43e8c87ef5a9"), "Ratione atque ut et aut molestiae suscipit natus.", "20a1de56-f330-45fd-a1a2-58210741f00a", new DateTime(2018, 8, 8, 6, 22, 49, 285, DateTimeKind.Local).AddTicks(372), "Organization Lubowitz - Murray", new DateTime(2019, 6, 27, 21, 48, 33, 880, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("304b80b7-6c45-4d16-ac32-1c742826d426"), "Fugit minima molestias.", "22693ea6-e724-4d89-b78f-39701e48fa0b", new DateTime(2021, 1, 11, 17, 5, 57, 618, DateTimeKind.Local).AddTicks(8136), "Organization Erdman - Kuphal", new DateTime(2022, 5, 28, 6, 45, 0, 756, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30d0004f-5624-4938-a009-b2ed40f59ab4"), "Autem quam quisquam hic sapiente eligendi.", "ab65f72c-0dc5-4f50-a748-d228cd4325b4", new DateTime(2020, 2, 12, 10, 56, 14, 248, DateTimeKind.Local).AddTicks(7459), "Organization Koepp, Marks and Kuvalis", new DateTime(2020, 6, 17, 20, 50, 36, 369, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3177719f-4e83-4e1c-b205-13d531c1b82d"), "Quisquam assumenda dolorum eveniet ut ut earum.", "c410adde-0469-44a6-bac6-3a23afdfcd8e", new DateTime(2021, 1, 22, 22, 13, 20, 167, DateTimeKind.Local).AddTicks(7508), "Organization Hettinger - Anderson", new DateTime(2022, 3, 22, 9, 54, 11, 665, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("332d429b-8610-486d-aab0-395b93aaf087"), "Perspiciatis consectetur a ipsa blanditiis eos aspernatur ad omnis.", "c05d504a-a40f-4831-866e-12fd8354b32b", new DateTime(2019, 9, 18, 7, 26, 12, 679, DateTimeKind.Local).AddTicks(8038), "Organization Greenholt and Sons", new DateTime(2022, 4, 1, 11, 41, 23, 281, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3578224a-005e-4ddc-bc3d-cd9de62d349b"), "Totam iste accusantium dolore animi iure reprehenderit animi dolore.", "2dfff448-83da-4433-8c75-6683ce700e2e", new DateTime(2021, 6, 20, 20, 55, 49, 74, DateTimeKind.Local).AddTicks(1740), "Organization Franecki, Rohan and Kulas", new DateTime(2021, 8, 19, 9, 8, 43, 506, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a857d44-ed15-4a27-aabe-5acdcbf114e5"), "Quo eum earum ratione optio autem.", "b2c475cf-eb3c-4d94-a2db-ce35f07bb35f", new DateTime(2017, 9, 4, 4, 55, 9, 544, DateTimeKind.Local).AddTicks(8090), "Organization Renner and Sons", new DateTime(2018, 10, 11, 2, 8, 24, 29, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d47c76b-d95a-4e74-bea5-93f9a8ba7ca2"), "Aliquam nihil libero nulla quo ipsa dolore ut sunt excepturi.", "23b0a91b-5be7-4176-a63b-3e490a63729b", new DateTime(2019, 2, 15, 9, 21, 18, 79, DateTimeKind.Local).AddTicks(8187), "Organization Zulauf, Rolfson and Little", new DateTime(2020, 12, 19, 8, 21, 53, 745, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("407300f9-14ac-4357-a4fa-39931f0c7f9d"), "Voluptatum occaecati voluptatum illo sint nemo tempore assumenda.", "a65c2a58-f719-4821-9ac2-1e689b33c3d1", new DateTime(2018, 7, 13, 14, 52, 30, 272, DateTimeKind.Local).AddTicks(2886), "Organization Towne, Stiedemann and Hermann", new DateTime(2022, 7, 3, 14, 1, 40, 583, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("40c93618-6db7-46c6-a7c6-ec1d557625c3"), "Repellendus velit doloribus quam.", "e79f3d70-ca6d-48c6-bd1b-e2087abde450", new DateTime(2018, 6, 27, 5, 31, 49, 832, DateTimeKind.Local).AddTicks(5704), "Organization Hauck, Beer and Crooks", new DateTime(2022, 4, 28, 10, 34, 3, 571, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41b89b6a-1554-413a-b7c1-e3dd05b3d815"), "Quia aut sunt tempore laudantium ut vel est.", "5e089179-a3e6-446f-b90f-f47e50aae36f", new DateTime(2019, 8, 19, 6, 8, 7, 447, DateTimeKind.Local).AddTicks(1789), "Organization Predovic - D'Amore", new DateTime(2020, 6, 21, 16, 43, 44, 698, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("438b8a08-85f4-4814-aa65-49eaf1707b05"), "Repellat ea dolorem a fugiat qui fuga id eos.", "5f02af3e-68b0-4f89-8482-9b0084f60bf2", new DateTime(2019, 5, 14, 11, 16, 1, 590, DateTimeKind.Local).AddTicks(6333), "Organization Kassulke - Mohr", new DateTime(2021, 9, 10, 17, 22, 36, 50, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("43ef2419-d56e-45a9-b742-4917c873b044"), "Vero qui deserunt recusandae dolor.", "a69d5468-4719-4d2c-b7b0-bb7c7abeaa97", new DateTime(2019, 4, 18, 13, 51, 33, 319, DateTimeKind.Local).AddTicks(6642), "Organization Aufderhar - Goyette", new DateTime(2022, 5, 17, 22, 38, 56, 162, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4bfe79dc-53e7-4dd5-961f-e991f1685a4f"), "Voluptates sapiente et consequatur sint rerum aperiam molestiae quidem.", "ad0da61f-c88d-4241-b709-eb99a7b944fb", new DateTime(2021, 5, 29, 8, 25, 39, 149, DateTimeKind.Local).AddTicks(3852), "Organization Runte LLC", new DateTime(2022, 5, 29, 15, 17, 22, 407, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f4a7f6a-d2b0-4ab9-972f-318e4526627a"), "Et qui cum nemo aut sunt fugiat dolorem vitae aut.", "7b45cf9e-272d-44f1-8c70-3f343ab34a2e", new DateTime(2018, 6, 14, 19, 48, 19, 95, DateTimeKind.Local).AddTicks(8244), "Organization Jenkins Inc", new DateTime(2019, 5, 23, 20, 21, 59, 475, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("504ede06-70bb-418e-b970-6926bf75d9a0"), "Ad sed voluptatibus illo minus pariatur vel mollitia ea culpa.", "d7c68927-a2fe-4ec4-9773-8a9328126866", new DateTime(2019, 1, 17, 3, 28, 14, 839, DateTimeKind.Local).AddTicks(7072), "Organization Pollich LLC", new DateTime(2019, 2, 2, 12, 52, 40, 133, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54f2cbf4-debd-4474-a155-adcade44d0fb"), "Rerum molestias ab velit ratione est sed consequatur eos qui.", "f5362c58-f006-4382-877e-1badca26462b", new DateTime(2020, 12, 15, 16, 1, 49, 922, DateTimeKind.Local).AddTicks(2316), "Organization Funk, Fritsch and Kessler", new DateTime(2022, 1, 29, 8, 56, 28, 75, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("58c0d396-7e42-4113-85b5-a0e295c438a0"), "Sint alias fugiat qui consectetur modi rerum aut illum sapiente.", "c1b712cb-307b-463c-a82d-588f9e49cb9e", new DateTime(2018, 11, 25, 12, 58, 56, 928, DateTimeKind.Local).AddTicks(2880), "Organization Macejkovic, Wilderman and Reilly", new DateTime(2019, 2, 3, 23, 0, 52, 665, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a940ee6-ea3d-49fc-8c85-02e55072bbd7"), "Velit incidunt vel porro placeat dolor natus quo.", "c139e9bc-1d6c-492f-8ec5-68055390a3ca", new DateTime(2018, 4, 7, 7, 18, 50, 129, DateTimeKind.Local).AddTicks(8642), "Organization Lueilwitz - Parisian", new DateTime(2018, 6, 28, 22, 8, 5, 840, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5fe511d9-1aae-474d-a0b6-9fbe67ca6c53"), "Corporis maxime autem.", "82117e99-1b00-4f9d-a714-c9dcb0a1751e", new DateTime(2022, 1, 17, 19, 34, 27, 496, DateTimeKind.Local).AddTicks(1521), "Organization Pagac - Johnson", new DateTime(2022, 4, 28, 2, 44, 56, 876, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6698f1a3-dd40-4234-80e2-84928a0321e7"), "Aut accusamus rerum.", "9dc5a991-458c-4bd1-aa81-44b5f3a8a579", new DateTime(2021, 9, 22, 0, 45, 12, 942, DateTimeKind.Local).AddTicks(4510), "Organization Bartell LLC", new DateTime(2021, 12, 1, 17, 48, 57, 237, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b62d027-847e-4752-a3fc-33a069a34fc3"), "Qui occaecati ex sint officiis ut ex enim.", "961144dd-775b-411f-b53a-9f6f11131a6c", new DateTime(2017, 9, 13, 1, 40, 51, 872, DateTimeKind.Local).AddTicks(2731), "Organization Ward, Hane and Kuhlman", new DateTime(2019, 12, 9, 19, 42, 13, 4, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73e20c30-157a-4299-92f1-e2bc963dc3eb"), "Corporis alias quo sint numquam consequatur quia est odio corporis.", "f29c19ed-db5e-410c-a24f-37543c38e6e5", new DateTime(2018, 6, 4, 6, 27, 43, 770, DateTimeKind.Local).AddTicks(9471), "Organization Tromp LLC", new DateTime(2020, 1, 18, 9, 41, 10, 811, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7473348d-81eb-4976-815b-370c074e6545"), "Suscipit quas ut.", "dd0d1eb3-2f3c-45fe-8ef5-18afb4229d56", new DateTime(2019, 12, 28, 22, 20, 12, 391, DateTimeKind.Local).AddTicks(4318), "Organization Gulgowski - Balistreri", new DateTime(2021, 11, 23, 7, 14, 49, 926, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75fb4ead-247d-4f76-822d-847bc02ba4cf"), "Autem odit commodi delectus officia est molestiae eum est.", "f8abbaaa-df29-473b-9703-06378648ce61", new DateTime(2017, 9, 5, 7, 40, 0, 118, DateTimeKind.Local).AddTicks(2304), "Organization Goodwin, Rath and Bruen", new DateTime(2019, 9, 13, 3, 43, 24, 794, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("79e05157-2cab-4baa-8200-f6b0c7a6a3c2"), "Ut ipsam ut necessitatibus id saepe alias error error.", "06b629d4-bfcb-4fda-9bcc-875a757586d0", new DateTime(2018, 6, 25, 22, 32, 11, 848, DateTimeKind.Local).AddTicks(2530), "Organization Goodwin - O'Kon", new DateTime(2020, 12, 17, 15, 1, 59, 438, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7be17f2c-bd7d-4cfb-b152-c7f457c4ef8c"), "Expedita at ea sed dignissimos et.", "b37b0426-9892-479f-9ae0-92bdcc434b85", new DateTime(2018, 7, 1, 15, 29, 47, 374, DateTimeKind.Local).AddTicks(7904), "Organization Price - Bosco", new DateTime(2020, 11, 30, 23, 6, 9, 48, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("82465895-8d80-4ae0-8e8a-5dbd10a93fa4"), "Sequi occaecati expedita.", "fcc026eb-012e-4eb2-b7a2-862f6feeb378", new DateTime(2018, 8, 3, 13, 7, 5, 458, DateTimeKind.Local).AddTicks(6505), "Organization Hansen Group", new DateTime(2022, 2, 3, 13, 56, 30, 696, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("88a013f1-d6de-4e93-bcfb-ea9975ca4d3c"), "Repudiandae qui ratione.", "a1ec313d-8cc2-4104-864f-ddc0af6203bf", new DateTime(2020, 7, 24, 11, 22, 52, 580, DateTimeKind.Local).AddTicks(5334), "Organization Schneider Inc", new DateTime(2021, 3, 23, 17, 15, 14, 529, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89922480-1518-4500-999e-17df72715f1b"), "Repudiandae omnis sit cumque.", "022d9a17-cc00-4357-bf8f-9c2f4dbaa405", new DateTime(2019, 11, 13, 16, 25, 31, 16, DateTimeKind.Local).AddTicks(9700), "Organization Stracke, Schamberger and Ziemann", new DateTime(2021, 5, 22, 1, 55, 30, 61, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8cdb486d-b184-4dbd-a014-e6bfa3985214"), "Ad facere voluptas quia quis aut sunt modi alias qui.", "da36dca1-f366-4072-be27-93c7be0444f1", new DateTime(2021, 1, 17, 15, 35, 42, 42, DateTimeKind.Local).AddTicks(4430), "Organization Hilpert - Senger", new DateTime(2022, 4, 26, 12, 46, 28, 514, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ec9bbbc-8f5e-45d2-934a-c88e096d4ae6"), "Quibusdam quia sint.", "1e5b03f7-b30a-4ced-a635-7ed50ba5ab73", new DateTime(2022, 3, 30, 22, 14, 46, 732, DateTimeKind.Local).AddTicks(7197), "Organization Glover, Macejkovic and Lowe", new DateTime(2022, 6, 23, 17, 13, 20, 761, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90dbecd4-f98d-4919-9881-0a238daad9cd"), "Corporis doloribus aut ea temporibus aut in reiciendis.", "fd701850-0e3f-463f-932c-68e2daff750b", new DateTime(2022, 6, 18, 21, 14, 44, 879, DateTimeKind.Local).AddTicks(8441), "Organization Green, Schumm and Goodwin", new DateTime(2022, 6, 30, 20, 33, 9, 317, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("913c6ada-10c2-4417-8ae7-52e0904750c9"), "Qui quod omnis ex soluta aliquam excepturi.", "85520e60-c347-48b0-a396-7afc5f5f387c", new DateTime(2019, 3, 18, 14, 10, 54, 978, DateTimeKind.Local).AddTicks(4017), "Organization Schaefer LLC", new DateTime(2019, 3, 20, 10, 48, 10, 798, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9431a0ba-f7e2-4b56-8d8c-db31ed4442b3"), "Optio modi voluptatibus nostrum harum veritatis iure ut natus.", "a780c751-d2ef-4d97-a3d5-f55dd582e900", new DateTime(2019, 9, 16, 7, 15, 11, 114, DateTimeKind.Local).AddTicks(7271), "Organization Zulauf - Schamberger", new DateTime(2022, 4, 17, 14, 10, 18, 204, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("989bf339-0e65-4743-b2cf-64643636180c"), "Non velit atque aut autem nostrum quia.", "4330f537-52ac-433c-be7b-a2beeb19a781", new DateTime(2020, 10, 3, 12, 12, 41, 395, DateTimeKind.Local).AddTicks(9978), "Organization Zemlak and Sons", new DateTime(2021, 3, 20, 7, 11, 10, 728, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a67d844-10d6-4fea-886f-bf09586eb4fa"), "Beatae autem dignissimos.", "120c634d-2e42-4cb8-9d04-04da42c8871f", new DateTime(2017, 11, 7, 3, 45, 32, 564, DateTimeKind.Local).AddTicks(5668), "Organization Macejkovic LLC", new DateTime(2021, 2, 26, 21, 31, 6, 521, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9afa247a-fd03-46ce-9580-3f865c4cf042"), "Velit dolorum quis dignissimos ut porro.", "c14a28e9-9483-45cf-b2b4-a9711b1b9562", new DateTime(2022, 6, 5, 23, 3, 13, 581, DateTimeKind.Local).AddTicks(9305), "Organization Kunze - Conn", new DateTime(2022, 6, 15, 12, 21, 33, 356, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9b58eba2-55d9-4239-b6f8-ee37841c895a"), "Vel consequatur corrupti deserunt aliquid sed accusamus ut et perferendis.", "1b74f2eb-4c1d-4266-b2a5-f7aeda098587", new DateTime(2018, 3, 23, 6, 35, 22, 329, DateTimeKind.Local).AddTicks(3986), "Organization Larson and Sons", new DateTime(2019, 2, 13, 21, 2, 26, 164, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9bff49ee-2a7f-42fe-8b14-1a859e29d46f"), "Repellat mollitia sed dolorem voluptatem.", "3cbf89a7-2d59-488c-b407-d3297636c634", new DateTime(2019, 2, 2, 19, 2, 13, 991, DateTimeKind.Local).AddTicks(6723), "Organization Nolan, Durgan and Jakubowski", new DateTime(2021, 9, 29, 17, 28, 49, 142, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a1ea491b-eab8-4287-b611-104ddc2881e3"), "Expedita ipsam ipsum rerum molestias est voluptate consequuntur quisquam.", "a415583f-390b-4e52-b3dd-e0f37e63a666", new DateTime(2020, 3, 25, 2, 0, 15, 220, DateTimeKind.Local).AddTicks(4572), "Organization O'Keefe - Dicki", new DateTime(2022, 4, 13, 22, 44, 10, 604, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2205b31-a6cd-4b12-b258-11b5e76e089f"), "Magnam ea ducimus.", "35e9f9bd-d867-47b6-b4be-0cb5914d4d14", new DateTime(2018, 11, 1, 5, 15, 1, 528, DateTimeKind.Local).AddTicks(8912), "Organization O'Reilly, Satterfield and D'Amore", new DateTime(2020, 5, 19, 1, 25, 45, 457, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a350898a-d91e-47e7-b8b0-b23f5f1703e4"), "Labore voluptatem nihil ut in fuga est sed.", "71654265-ec8a-4a19-b529-ef4b57babb20", new DateTime(2019, 9, 27, 17, 37, 22, 877, DateTimeKind.Local).AddTicks(4612), "Organization DuBuque, Douglas and Muller", new DateTime(2022, 3, 4, 1, 49, 59, 464, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a4f7be50-9af1-499d-ade9-b8c9adb794b2"), "Et autem maiores maiores necessitatibus.", "95645fed-cd85-495c-8efe-ce4dad9da6c6", new DateTime(2021, 2, 22, 23, 37, 12, 623, DateTimeKind.Local).AddTicks(2022), "Organization Turcotte and Sons", new DateTime(2021, 10, 24, 21, 14, 31, 390, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5fc4867-0ee9-44ee-98a4-f9d91081273f"), "Consequatur debitis est ab autem.", "2c68f60b-7df4-4769-8763-7339e7a50de4", new DateTime(2021, 1, 30, 5, 55, 52, 950, DateTimeKind.Local).AddTicks(3546), "Organization Hamill, Streich and Schimmel", new DateTime(2021, 5, 30, 22, 47, 4, 309, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aafe8239-7c0b-45ee-ac10-0e170cfe00a0"), "Placeat quam ea.", "5c25f898-70e1-4158-b206-73e8de5db566", new DateTime(2018, 1, 19, 12, 24, 45, 751, DateTimeKind.Local).AddTicks(905), "Organization Sipes LLC", new DateTime(2020, 2, 8, 3, 24, 50, 2, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b05907b1-52cd-4cd7-aa49-5362198e21a4"), "Eum iusto voluptatum voluptatem non architecto.", "65055166-431a-4a50-8322-c654719dc4d8", new DateTime(2020, 12, 13, 12, 23, 26, 931, DateTimeKind.Local).AddTicks(6399), "Organization Little - Legros", new DateTime(2021, 11, 4, 17, 13, 29, 319, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1cdf672-1a7c-4ea8-9135-1126620b4522"), "Consequatur rerum illum explicabo et rem.", "2d21eefe-fe17-4c4b-ad06-df92f9979d77", new DateTime(2021, 9, 2, 16, 23, 33, 709, DateTimeKind.Local).AddTicks(7196), "Organization Adams Group", new DateTime(2021, 10, 2, 10, 4, 21, 519, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b4decd64-c9d6-42cd-bbc4-73a0ad8f4917"), "Perspiciatis beatae nulla earum sint.", "65dd0dfa-eec2-4602-8cbd-45ab35fce268", new DateTime(2021, 2, 8, 11, 22, 38, 297, DateTimeKind.Local).AddTicks(4930), "Organization Morar - Volkman", new DateTime(2022, 4, 28, 21, 5, 52, 87, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b8c04cbc-f6ae-47c4-8f5b-1e9b05ca38d4"), "Vero ratione non voluptatum veritatis ipsa.", "490b3e59-1c80-47b0-a155-bc902e118cea", new DateTime(2018, 6, 29, 15, 20, 3, 289, DateTimeKind.Local).AddTicks(4502), "Organization Vandervort Group", new DateTime(2019, 5, 8, 17, 59, 53, 156, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b980ca59-22ef-4486-9ac8-cf7eff527bf4"), "Quas ipsum dolorem nisi et iste et ipsum.", "e25f33e5-f24c-49ae-891a-bdb3e90ac2ab", new DateTime(2022, 3, 15, 21, 46, 15, 762, DateTimeKind.Local).AddTicks(6493), "Organization Rowe, Swift and Howell", new DateTime(2022, 7, 1, 9, 31, 56, 921, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("babc28cf-cfb1-4a5c-94c3-18da918c7548"), "Libero consequuntur ut nihil ducimus et aliquid.", "5f6fdca9-f567-41e9-9827-da6d2030e90b", new DateTime(2020, 9, 3, 9, 54, 3, 643, DateTimeKind.Local).AddTicks(3786), "Organization Durgan - Raynor", new DateTime(2021, 9, 12, 3, 11, 1, 555, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bbbf2243-6845-433e-9734-b4a8f00bc883"), "Enim consequatur ea et debitis est quia quisquam sequi nam.", "4f8ebd53-d07e-4d63-b88f-c863fcd7ed05", new DateTime(2021, 9, 12, 11, 29, 27, 955, DateTimeKind.Local).AddTicks(4571), "Organization Wiza, Runte and Schultz", new DateTime(2022, 5, 28, 8, 6, 21, 523, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf39ce09-96ee-40d9-bb47-64d1c4c73f39"), "Soluta facilis temporibus corporis quaerat earum in optio quibusdam a.", "1f8decb7-08a0-4368-af16-7248f5ff9e81", new DateTime(2022, 3, 5, 23, 42, 5, 329, DateTimeKind.Local).AddTicks(8911), "Organization Cole, Walsh and Powlowski", new DateTime(2022, 4, 20, 11, 30, 56, 857, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c05d51f7-7d19-438f-a126-d568db2db9a6"), "Error rerum a qui.", "eb0418e2-58fa-4652-a3e8-c4aaaa3b68fd", new DateTime(2021, 12, 10, 19, 5, 29, 362, DateTimeKind.Local).AddTicks(2626), "Organization Huel, Mitchell and Hermann", new DateTime(2022, 1, 24, 0, 46, 51, 464, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c17701bc-9b04-493c-a7cc-78535fe578fa"), "Consequatur id est porro eius veritatis.", "2d18614c-d43a-4f7a-9a0d-3100b6210a0b", new DateTime(2019, 6, 4, 16, 36, 4, 965, DateTimeKind.Local).AddTicks(5179), "Organization Baumbach LLC", new DateTime(2021, 9, 3, 1, 10, 11, 628, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c72ad1b8-6afa-46a1-884e-8f290af20166"), "Repellendus voluptatem debitis excepturi veniam ut.", "47ebe5c2-b490-4ec0-996b-2e9e247eeac7", new DateTime(2021, 7, 23, 15, 52, 31, 290, DateTimeKind.Local).AddTicks(5731), "Organization Rohan, Pacocha and Bednar", new DateTime(2022, 5, 8, 12, 17, 53, 532, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d153bb25-ed53-4d61-aa63-5e31af2cf183"), "Rerum laboriosam id accusantium rerum.", "ea24bcd2-f572-4ee6-ac5f-b2e381e674b1", new DateTime(2020, 2, 21, 3, 3, 23, 978, DateTimeKind.Local).AddTicks(5981), "Organization Leuschke, Wunsch and Torphy", new DateTime(2020, 10, 26, 13, 30, 54, 648, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d24c2009-dd10-4ab9-8288-cb2e86d9295e"), "Et id voluptatem sint cumque delectus assumenda.", "e68accdf-d604-492a-8b9e-f521649b041f", new DateTime(2019, 3, 29, 1, 19, 59, 94, DateTimeKind.Local).AddTicks(9685), "Organization Dickinson and Sons", new DateTime(2022, 1, 21, 13, 19, 3, 327, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d395ca4e-911d-47c3-89e9-d3f6c871727f"), "Laboriosam nihil debitis.", "940bac67-fb8d-4198-b30c-7523b50866be", new DateTime(2022, 2, 13, 18, 54, 10, 828, DateTimeKind.Local).AddTicks(2550), "Organization Haley - Stark", new DateTime(2022, 6, 18, 2, 42, 55, 731, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d5922434-7029-41a2-9687-444f2d89e5cc"), "Reiciendis quis et aperiam ab tenetur.", "f202bccd-f919-46bf-b784-e1c887a8c7ed", new DateTime(2021, 8, 27, 10, 53, 19, 308, DateTimeKind.Local).AddTicks(8866), "Organization Kris, Feeney and Bartoletti", new DateTime(2021, 12, 3, 4, 15, 41, 570, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d60ce380-1fef-42ac-8253-3261c24bc90c"), "Id pariatur consequatur voluptatem ullam omnis molestiae eaque consectetur consequatur.", "42f64abb-10e5-426d-8ff1-1066731e6fd5", new DateTime(2022, 3, 20, 5, 22, 39, 302, DateTimeKind.Local).AddTicks(4932), "Organization Schmidt Inc", new DateTime(2022, 4, 3, 0, 6, 28, 547, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7e59105-d066-4a19-92a9-6343b2838ab1"), "Non consequatur ut ut sint explicabo ex aut.", "9bde9e23-14a0-4541-bc5e-3600640458eb", new DateTime(2022, 4, 4, 13, 10, 53, 180, DateTimeKind.Local).AddTicks(5118), "Organization Moore, Thompson and Stracke", new DateTime(2022, 6, 27, 4, 43, 58, 608, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d85e167f-47c3-4548-bfcf-893d7c573ba2"), "Officiis qui voluptas.", "1783a385-07db-44c1-b78d-b88b7d4d54cd", new DateTime(2022, 6, 2, 12, 33, 34, 466, DateTimeKind.Local).AddTicks(8787), "Organization Dare Group", new DateTime(2022, 6, 30, 21, 17, 37, 342, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8b193b3-419b-4846-9996-b9d714729d62"), "Aperiam perspiciatis sint.", "047bd496-b623-4928-a2b1-6215e83163fa", new DateTime(2018, 5, 25, 5, 47, 54, 267, DateTimeKind.Local).AddTicks(3632), "Organization Grimes, Jakubowski and O'Hara", new DateTime(2021, 5, 14, 11, 10, 8, 193, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da3f1cfa-d9b0-4c5e-abdd-a6ffbdd1979c"), "Esse ut ut quisquam quidem laboriosam et.", "416e5b2b-e446-4252-b578-6b6bd72a2625", new DateTime(2022, 4, 2, 6, 37, 42, 348, DateTimeKind.Local).AddTicks(6826), "Organization Schulist - Kshlerin", new DateTime(2022, 5, 22, 0, 25, 21, 982, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db0e362a-03b6-465b-b912-f11dac5276e5"), "Exercitationem enim necessitatibus odio id qui adipisci vero.", "a8b96313-c2f2-498b-96b1-1dc9c5dfe0bf", new DateTime(2019, 1, 19, 20, 33, 35, 363, DateTimeKind.Local).AddTicks(7881), "Organization Friesen Group", new DateTime(2020, 4, 1, 4, 28, 26, 706, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e042abd3-5802-42b8-a776-19f85f1f8d7b"), "Ea tempore nam.", "f6172f55-b2b8-491b-94b3-621d32cbaf0c", new DateTime(2021, 4, 27, 20, 56, 12, 41, DateTimeKind.Local).AddTicks(6600), "Organization Franecki, Koepp and Mann", new DateTime(2021, 10, 23, 1, 34, 29, 457, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e39331da-c960-458b-9685-cc6be207c61e"), "Molestias facere a voluptatem qui temporibus dolor quod.", "46cf6c6e-07f9-4fa5-9f89-b9be4966175b", new DateTime(2020, 6, 24, 13, 59, 30, 386, DateTimeKind.Local).AddTicks(2452), "Organization Gutmann Inc", new DateTime(2021, 3, 31, 14, 28, 58, 250, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e47f90c6-0411-4dcf-942b-b03f5026566c"), "Nobis dolorum dolores ullam.", "a90a4649-e583-4faa-9bb6-2a29c87f8846", new DateTime(2019, 6, 11, 11, 29, 8, 625, DateTimeKind.Local).AddTicks(5887), "Organization Schaefer - Carter", new DateTime(2020, 6, 13, 16, 40, 41, 685, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e58fb6fa-06c6-470e-b7a2-8c969536156e"), "Et et et error.", "0f479d03-22b4-4d44-a07d-da6dcb55f645", new DateTime(2020, 1, 22, 23, 3, 23, 813, DateTimeKind.Local).AddTicks(3809), "Organization Haag - Ward", new DateTime(2021, 7, 27, 20, 45, 45, 116, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ea5e577c-b9a1-48da-a437-73ea59557f0f"), "Aut laboriosam sequi.", "e5a4b288-27ca-4da7-bfb7-11fe306370e2", new DateTime(2020, 9, 15, 17, 6, 0, 196, DateTimeKind.Local).AddTicks(8139), "Organization Ryan - Anderson", new DateTime(2020, 12, 5, 19, 2, 30, 911, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eab7951f-65d4-40f2-ac20-c87beee06e4c"), "Occaecati tempora esse id cum saepe.", "c6c02ca8-8d4a-41d5-9aa1-72d09aacc2f1", new DateTime(2020, 6, 24, 1, 52, 3, 447, DateTimeKind.Local).AddTicks(9671), "Organization Koch, Waelchi and Torp", new DateTime(2020, 12, 3, 11, 15, 0, 521, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eb935c64-8a05-4549-a769-382a3bde9e25"), "Debitis impedit quisquam quia vitae perspiciatis.", "cdd60a9c-ae60-4d47-bbfb-bfcb3c18626f", new DateTime(2018, 8, 20, 15, 1, 8, 74, DateTimeKind.Local).AddTicks(30), "Organization Beier, McCullough and Thiel", new DateTime(2021, 1, 19, 18, 53, 42, 151, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee3dd98e-cb50-4b58-8649-76f2b55bd101"), "Porro dolorum odit necessitatibus assumenda reprehenderit consequatur earum incidunt et.", "2571432a-1f2b-4f60-827d-c3708c872dfc", new DateTime(2020, 12, 8, 20, 24, 14, 238, DateTimeKind.Local).AddTicks(1833), "Organization Roob - Pagac", new DateTime(2022, 6, 16, 8, 3, 41, 689, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("efa5da01-e4fe-46a9-b1c5-9c7e32b9e3db"), "Quibusdam nihil beatae dolor ducimus molestias.", "67c55d9a-b203-40d2-b622-9e3f171b909d", new DateTime(2019, 1, 18, 12, 45, 49, 762, DateTimeKind.Local).AddTicks(6432), "Organization Paucek and Sons", new DateTime(2019, 7, 17, 9, 18, 53, 991, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eff37896-cbf6-4679-8daa-b2ed1728cac8"), "Adipisci inventore esse expedita repudiandae repellat ea.", "46a6ddda-a01c-423e-98aa-d95484e04981", new DateTime(2019, 7, 31, 22, 25, 35, 824, DateTimeKind.Local).AddTicks(8323), "Organization Cassin Inc", new DateTime(2021, 3, 26, 6, 58, 16, 695, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f40c9163-d300-49b2-b06c-e36eea8c381c"), "Qui illum ut alias quasi perferendis qui voluptate inventore.", "4128d207-3733-4ce7-80b3-281108ea5973", new DateTime(2019, 4, 8, 17, 4, 19, 261, DateTimeKind.Local).AddTicks(4399), "Organization Gislason Group", new DateTime(2020, 8, 25, 13, 55, 37, 387, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6079610-9fb5-4886-9d9f-b7e860436acd"), "Amet ut ullam eos dolores.", "3cbd89a8-e5a3-4767-9c59-f8100210b37b", new DateTime(2019, 6, 26, 19, 7, 27, 337, DateTimeKind.Local).AddTicks(3897), "Organization Paucek - Goodwin", new DateTime(2022, 1, 6, 22, 12, 9, 806, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7ba888a-6d53-4bd3-a724-520f564b4fce"), "Eligendi dolore omnis consequuntur error facere vero ut.", "c454b645-b8fe-40e1-b826-81614a27f691", new DateTime(2018, 4, 22, 23, 18, 19, 898, DateTimeKind.Local).AddTicks(7780), "Organization Pollich - Kilback", new DateTime(2021, 9, 25, 7, 58, 9, 94, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f95a1665-faa5-4658-98f2-0bc939999235"), "Suscipit itaque qui nesciunt distinctio et autem tempora debitis aspernatur.", "d12377ea-b5ac-4d2c-b275-ca0bc04620df", new DateTime(2020, 11, 3, 8, 35, 40, 727, DateTimeKind.Local).AddTicks(3728), "Organization Abbott Inc", new DateTime(2020, 12, 10, 12, 36, 7, 498, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f96ad851-5467-499a-8608-16096977d5ac"), "Voluptatem totam mollitia dolore sed veritatis ut.", "e20f3996-4fc2-4ef9-91dc-6be10023ea66", new DateTime(2018, 2, 11, 4, 49, 29, 269, DateTimeKind.Local).AddTicks(6778), "Organization White and Sons", new DateTime(2018, 6, 3, 13, 26, 35, 349, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe9f17df-cab8-4291-b28c-ead5fe8b2e52"), "Saepe quidem cum velit doloremque ut qui.", "cafc8e20-fc3d-46c1-a9c2-fb98b598499e", new DateTime(2018, 6, 9, 14, 55, 47, 8, DateTimeKind.Local).AddTicks(6282), "Organization Durgan - Bayer", new DateTime(2018, 6, 14, 18, 45, 37, 862, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff43a9e0-c860-48e3-8471-07eda9eba9a9"), "Hic aut nam a aut asperiores distinctio ratione rerum voluptatem.", "ff2d8f4d-9c2d-4dee-ac87-e6e0e516ffda", new DateTime(2018, 12, 23, 4, 54, 39, 882, DateTimeKind.Local).AddTicks(7723), "Organization Weber - Thompson", new DateTime(2021, 12, 18, 17, 3, 18, 578, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.InsertData(
                table: "PriceType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("58e6ad21-758e-45ea-baad-145f2577a386"), "Nulla rem qui alias laudantium earum amet.", "af44466d-d76b-463a-be6d-4421b8f60761", new DateTime(2019, 3, 30, 9, 36, 34, 718, DateTimeKind.Local).AddTicks(2816), "opt", new DateTime(2019, 6, 6, 11, 42, 39, 474, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.InsertData(
                table: "PriceType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5f20c245-ed8f-43cc-ae50-e54be6552d1b"), "Quo magnam non.", "8cbf1f63-8985-40ba-853c-d71d619e1103", new DateTime(2019, 4, 25, 1, 48, 15, 615, DateTimeKind.Local).AddTicks(9354), "big opt", new DateTime(2021, 3, 18, 4, 55, 38, 446, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.InsertData(
                table: "PriceType<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6784106-b9d3-458e-8d00-73a0638deeef"), "Aut quia sunt atque blanditiis voluptatem consequuntur aut id itaque.", "f5f61885-3432-4d7c-9f2f-a699185d5dc4", new DateTime(2019, 7, 25, 17, 27, 5, 894, DateTimeKind.Local).AddTicks(5063), "all", new DateTime(2021, 2, 20, 14, 55, 27, 235, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("03502f6f-1315-4957-bc10-08cea515cb8c"), "Reprehenderit magnam est.", "0164da99-b1f4-4b66-ac6a-e14715ed510a", new DateTime(2022, 5, 19, 16, 34, 26, 205, DateTimeKind.Local).AddTicks(8528), "azure", new DateTime(2022, 5, 21, 14, 45, 39, 804, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05395555-44b3-4acd-aa2f-876662fb3168"), "Delectus ut sint quae alias ipsa maxime itaque.", "791e3973-c643-4e52-976e-915edec7c06d", new DateTime(2018, 11, 22, 20, 39, 18, 44, DateTimeKind.Local).AddTicks(4084), "indigo", new DateTime(2020, 10, 22, 22, 50, 35, 246, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("066551d9-df9b-4400-8889-357230c8dad9"), "Voluptatum atque molestiae cum aut magnam quo molestiae.", "2fcbc423-574b-4e6f-8cac-5e81789a2928", new DateTime(2020, 11, 9, 5, 55, 2, 644, DateTimeKind.Local).AddTicks(7083), "silver", new DateTime(2022, 5, 24, 12, 39, 6, 436, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07daef5f-5ef1-447d-b71a-77e02c1cb701"), "Non distinctio ut rerum minus minus.", "a38f5ac4-fa4a-4179-b493-4858c5f6d54c", new DateTime(2020, 7, 26, 19, 23, 16, 933, DateTimeKind.Local).AddTicks(5746), "salmon", new DateTime(2021, 6, 21, 0, 20, 55, 427, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08a72ef8-9963-473e-a28f-dcb2feb5dd70"), "Voluptatem consequatur saepe consequatur minus.", "66d7a0c5-cba1-4876-952d-de8ca20d4661", new DateTime(2022, 4, 16, 9, 3, 54, 411, DateTimeKind.Local).AddTicks(8572), "azure", new DateTime(2022, 5, 17, 2, 46, 39, 415, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("09637c49-7c03-4a9b-9318-72c309693335"), "Et et accusantium corporis est aliquam dicta dolorum rerum vel.", "bb560744-1b16-41f6-8dd8-dc5194c40ae6", new DateTime(2020, 8, 13, 15, 31, 50, 548, DateTimeKind.Local).AddTicks(4291), "mint green", new DateTime(2020, 10, 9, 10, 21, 44, 523, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ad737c4-6c4c-4923-ae60-c47ecf5f63ef"), "Iste quas repudiandae.", "cce02748-ae69-4b81-a345-6d10a7353aca", new DateTime(2020, 3, 7, 17, 44, 13, 539, DateTimeKind.Local).AddTicks(8682), "white", new DateTime(2020, 4, 30, 20, 50, 32, 571, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0aea2259-a11d-43e6-a786-4d2be979d67a"), "Ipsa doloremque possimus ab animi omnis ut ipsum autem.", "d26caecd-03de-4fa0-bf46-1ee09af4c09f", new DateTime(2022, 2, 10, 17, 11, 53, 799, DateTimeKind.Local).AddTicks(2890), "white", new DateTime(2022, 4, 29, 22, 31, 32, 163, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f4e8346-ed6c-4bc6-9c1a-59bfa0f2644a"), "Cupiditate tenetur dolor ullam et repellat quae.", "0aa143f3-85cd-422d-b39a-03b70fe88d54", new DateTime(2020, 1, 26, 2, 57, 39, 662, DateTimeKind.Local).AddTicks(3224), "teal", new DateTime(2021, 8, 15, 7, 43, 13, 421, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("119759b0-472f-45ac-b149-4f0653275bce"), "Esse cumque facere dolores veniam eveniet libero.", "bbf645a6-9b08-4158-81b3-fb75a53984a6", new DateTime(2020, 3, 24, 10, 46, 9, 702, DateTimeKind.Local).AddTicks(3583), "grey", new DateTime(2022, 1, 7, 4, 53, 37, 631, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11e3a172-51f0-45d1-8afb-2603b75de1db"), "Delectus qui harum recusandae magnam explicabo sit blanditiis.", "35112890-8fa4-4db8-905a-3ea80021b5e1", new DateTime(2019, 7, 3, 8, 7, 27, 831, DateTimeKind.Local).AddTicks(3786), "yellow", new DateTime(2020, 2, 1, 16, 26, 30, 403, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1280b829-0e6d-43da-9a13-c5b62a27920d"), "Aspernatur saepe et quisquam accusantium quia asperiores sit veritatis ut.", "eeff3d66-3756-4c86-88c5-f24bd04fb027", new DateTime(2022, 2, 4, 3, 2, 23, 603, DateTimeKind.Local).AddTicks(5172), "red", new DateTime(2022, 6, 21, 6, 23, 43, 603, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12f9abef-c5b8-47c8-bd07-3af386ba3e20"), "Cupiditate deserunt ut et ut voluptatem laborum illo.", "3747ba3d-0965-41f8-8358-608651923763", new DateTime(2018, 10, 18, 3, 19, 47, 371, DateTimeKind.Local).AddTicks(5619), "cyan", new DateTime(2021, 4, 3, 9, 43, 59, 269, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("14c74702-3fbb-4781-a356-c275cda3be8c"), "Qui fuga ullam culpa facere magni perferendis.", "6e4b065e-de1f-4aa7-93c8-b3fe28ceef57", new DateTime(2020, 6, 17, 16, 13, 0, 507, DateTimeKind.Local).AddTicks(2020), "maroon", new DateTime(2022, 5, 9, 18, 49, 22, 109, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17e31170-844a-49da-bfb8-d35fba450517"), "Et quidem dolor est quisquam qui aut cumque.", "ad4bd836-46d8-4778-a988-719c739183a9", new DateTime(2018, 4, 6, 19, 10, 28, 73, DateTimeKind.Local).AddTicks(8156), "salmon", new DateTime(2019, 2, 26, 6, 37, 3, 75, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("187ff9f4-ec72-47b7-8c77-27735da6b951"), "Mollitia quia maxime voluptatem ea.", "b4dc070e-ca8b-4c96-940b-d02486294ede", new DateTime(2021, 1, 25, 20, 38, 49, 171, DateTimeKind.Local).AddTicks(3035), "teal", new DateTime(2021, 5, 10, 19, 45, 54, 744, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19836be5-d866-468c-a27a-48b520fa9146"), "Rerum atque cupiditate sed placeat ea non omnis.", "704704ec-446c-4d79-af87-0ee9ce936f37", new DateTime(2020, 5, 9, 3, 53, 39, 530, DateTimeKind.Local).AddTicks(8587), "magenta", new DateTime(2022, 5, 8, 13, 42, 33, 945, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b292a80-c2e0-4d1c-a4d3-3eefc80c8b30"), "Quia repudiandae temporibus culpa ad est suscipit eum aut.", "8e5be8f3-4a72-4255-b2f9-c6300845843d", new DateTime(2022, 2, 13, 0, 19, 1, 637, DateTimeKind.Local).AddTicks(8889), "salmon", new DateTime(2022, 6, 23, 15, 5, 12, 337, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1bf4a046-0540-4f01-9799-3cabbf221a53"), "Laborum dolor consequatur.", "b1a85404-ca3e-4821-a4c8-21478b0cbe9a", new DateTime(2021, 4, 9, 16, 3, 1, 390, DateTimeKind.Local).AddTicks(3330), "sky blue", new DateTime(2022, 1, 31, 13, 15, 52, 30, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2288a178-9533-481c-a9a9-12abb5eb9805"), "Adipisci itaque pariatur quos eos quas accusantium aut aspernatur nulla.", "6f817a38-667e-4399-afa0-a94b7bdb05e5", new DateTime(2019, 12, 10, 10, 7, 36, 839, DateTimeKind.Local).AddTicks(8022), "orange", new DateTime(2020, 2, 7, 22, 43, 44, 306, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("30acd64a-a365-4a9e-9b3c-8ad5055d77f1"), "Alias nisi itaque laboriosam possimus ad occaecati quia nostrum minima.", "c88af3a4-907f-4470-8399-ec943083a76b", new DateTime(2020, 8, 18, 4, 30, 2, 36, DateTimeKind.Local).AddTicks(680), "teal", new DateTime(2021, 1, 7, 11, 5, 0, 388, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3326ade3-469c-4d6e-82fa-5b0743383141"), "Atque sit quibusdam voluptas cumque ut quis.", "1298cc01-ba3c-440d-bdbb-167f22d71623", new DateTime(2020, 2, 24, 16, 39, 42, 792, DateTimeKind.Local).AddTicks(8581), "azure", new DateTime(2021, 5, 29, 6, 54, 30, 207, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("39230515-a40e-419d-a41c-e6bfc868ac3e"), "Nam repudiandae est ut error excepturi ad.", "9807fd91-06c7-45c4-b07a-20ee052afe75", new DateTime(2021, 10, 17, 0, 8, 5, 92, DateTimeKind.Local).AddTicks(2754), "fuchsia", new DateTime(2022, 1, 3, 2, 31, 35, 420, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f9e0154-5f8f-4f10-9abd-8837f2f614e5"), "Nostrum qui sint quasi velit vitae consectetur.", "c1f9809f-d8a7-4bbf-abe8-91cb0a0e294d", new DateTime(2019, 5, 28, 8, 14, 15, 216, DateTimeKind.Local).AddTicks(1023), "plum", new DateTime(2021, 1, 18, 16, 53, 7, 867, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3fea5185-344e-4f1f-a584-6263b3b4a962"), "Voluptatum mollitia neque quas sunt et quaerat autem commodi.", "2143470a-7aa1-4e17-bff4-d2757be602fa", new DateTime(2019, 11, 8, 2, 41, 6, 46, DateTimeKind.Local).AddTicks(3706), "fuchsia", new DateTime(2021, 9, 9, 19, 4, 52, 586, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("427b1792-e0ff-4eac-88d2-dc9577af342d"), "Neque consequatur suscipit quae suscipit quos molestias.", "30471516-8718-48f2-b0e0-3c4560bf5bef", new DateTime(2020, 8, 26, 12, 36, 40, 594, DateTimeKind.Local).AddTicks(3967), "azure", new DateTime(2022, 2, 20, 15, 22, 40, 445, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("447081be-0607-4d39-960f-42101a2b1ef1"), "Porro quis blanditiis quisquam.", "94c7e92f-715b-4444-bfb4-5b82db567163", new DateTime(2018, 2, 21, 1, 7, 26, 858, DateTimeKind.Local).AddTicks(6654), "azure", new DateTime(2021, 5, 2, 6, 36, 41, 658, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47a55502-ed6f-4997-9d01-5c146dedf62c"), "Nostrum quas voluptate.", "02fcbea0-2097-49c1-8ba5-97e0e67c74d0", new DateTime(2018, 4, 22, 21, 8, 33, 185, DateTimeKind.Local).AddTicks(4720), "orange", new DateTime(2021, 7, 9, 14, 6, 9, 76, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("48bb1eb0-1d77-431a-a38c-1cf4835c3dbe"), "Labore nesciunt quasi et nemo.", "95a673e7-8461-4b18-bcea-3ecf1cda7814", new DateTime(2020, 12, 3, 17, 33, 50, 729, DateTimeKind.Local).AddTicks(8312), "azure", new DateTime(2021, 9, 27, 13, 20, 10, 785, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c43c3c8-04e4-43bd-a693-fe5f13b273a1"), "Accusamus et et accusantium aliquid assumenda.", "95b07b65-6da6-4acb-bd9f-b272a3142fb5", new DateTime(2021, 9, 18, 4, 52, 40, 535, DateTimeKind.Local).AddTicks(7914), "azure", new DateTime(2021, 10, 21, 11, 43, 56, 65, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c5b1ad3-07c1-49c1-879b-49039408166a"), "Et et voluptas deserunt.", "0296063e-afc3-47ea-8820-082d6ecfb525", new DateTime(2018, 4, 5, 14, 49, 56, 728, DateTimeKind.Local).AddTicks(5196), "magenta", new DateTime(2021, 2, 9, 1, 9, 53, 652, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f454e49-297a-4bea-9999-e0d95d57125d"), "Consectetur dolorum ut facilis esse sint voluptates recusandae.", "ac0228ac-3aa8-4d98-a32c-6f8dae6dfaa3", new DateTime(2019, 4, 18, 3, 13, 14, 611, DateTimeKind.Local).AddTicks(9851), "yellow", new DateTime(2021, 1, 12, 21, 52, 25, 243, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4fc6171b-6675-4b02-b360-c70a271144fa"), "Perspiciatis sint ratione repellat.", "a45ebcd1-df7b-4b7c-84f1-15c37da1b0f6", new DateTime(2019, 1, 20, 16, 57, 55, 727, DateTimeKind.Local).AddTicks(377), "indigo", new DateTime(2022, 3, 2, 4, 21, 37, 520, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("515d9976-029c-48c0-8820-beb5d35ffa9f"), "Voluptas aut dolores in dolorum modi sit sit qui.", "65dc85f7-6b1b-479f-bbf1-324acb393573", new DateTime(2019, 9, 14, 8, 58, 51, 23, DateTimeKind.Local).AddTicks(3533), "azure", new DateTime(2021, 11, 9, 22, 29, 23, 687, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52670a3d-b92b-4ba3-88f7-bb1454cd130f"), "Ea repellat est perspiciatis earum officiis autem.", "0141e2f2-e422-42e9-897d-0634ad679fd7", new DateTime(2021, 3, 27, 1, 27, 17, 371, DateTimeKind.Local).AddTicks(1866), "mint green", new DateTime(2021, 7, 13, 5, 42, 5, 19, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53b34775-e14a-4489-9f6c-985b9e9eb1d1"), "Est blanditiis quo quaerat perspiciatis praesentium.", "0006bfba-98ac-40d0-adfe-7dfb12bd6a22", new DateTime(2018, 3, 14, 7, 23, 4, 533, DateTimeKind.Local).AddTicks(4257), "olive", new DateTime(2019, 8, 11, 10, 21, 50, 329, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6940b99d-829f-41ba-b3c4-028f3fa460e2"), "Dolores neque dignissimos autem ut maiores.", "ca8624b4-4b95-4d4d-b0de-491795688d42", new DateTime(2020, 10, 12, 16, 34, 9, 678, DateTimeKind.Local).AddTicks(4630), "plum", new DateTime(2022, 7, 1, 21, 40, 1, 277, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69df674b-9ec5-4332-b1cf-87c29d337243"), "Ipsam culpa ab beatae ea.", "dc96c186-0932-441d-b27c-ccffb2c3c5d3", new DateTime(2017, 9, 1, 8, 53, 25, 426, DateTimeKind.Local).AddTicks(4047), "black", new DateTime(2018, 4, 14, 23, 5, 3, 149, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69e93bd8-d20e-4ae4-8a47-e67ed0020976"), "Quidem id et eius laboriosam eaque voluptatibus.", "23fde8f8-470d-498d-8884-417c9bb6945f", new DateTime(2019, 10, 1, 3, 4, 51, 631, DateTimeKind.Local).AddTicks(8540), "tan", new DateTime(2020, 2, 18, 5, 5, 37, 796, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6fb774d0-04d5-468c-9418-c122106d9637"), "Nemo architecto et maxime quod adipisci veniam non accusantium sit.", "e98ef03a-9b6f-49a0-bdff-fe0fcc4e393c", new DateTime(2019, 11, 21, 15, 43, 7, 14, DateTimeKind.Local).AddTicks(7963), "gold", new DateTime(2021, 7, 24, 15, 55, 32, 133, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("715f68b0-5d77-49cf-af30-c9bfc039d984"), "Temporibus consectetur fugit quia sint nihil quasi consequuntur omnis.", "a016db8a-1574-4325-ba49-2b1d4b6082e7", new DateTime(2021, 9, 1, 9, 51, 0, 58, DateTimeKind.Local).AddTicks(8980), "olive", new DateTime(2022, 2, 26, 14, 37, 44, 128, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("719a143a-274f-4755-b876-025bcea8a088"), "Dolores suscipit ipsam in dolor tempore laborum doloribus tenetur.", "08904aa8-e385-4801-8a82-aba2a603bdaf", new DateTime(2022, 5, 3, 14, 55, 27, 953, DateTimeKind.Local).AddTicks(8819), "tan", new DateTime(2022, 6, 18, 10, 5, 33, 721, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c44ff33-df5f-40e4-8068-22448a23ab1f"), "At voluptate eos aliquam.", "b8f1cec3-95b5-4cb6-a4db-17dcf8d1b96b", new DateTime(2021, 5, 12, 19, 35, 49, 119, DateTimeKind.Local).AddTicks(5160), "green", new DateTime(2022, 2, 25, 15, 56, 57, 177, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e7769aa-22a2-49a6-8b55-c030b6ac012e"), "Rerum blanditiis ut.", "69fd8c1a-ed3b-4d98-8160-61deb12fca43", new DateTime(2020, 5, 31, 22, 16, 45, 614, DateTimeKind.Local).AddTicks(1008), "black", new DateTime(2020, 6, 6, 2, 58, 13, 711, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e825d4f-076f-4a4f-9a3f-f798b4ada130"), "Et animi molestiae perferendis sunt quae reprehenderit itaque.", "b67b6823-33c1-44a4-8d12-c9d541781f46", new DateTime(2020, 10, 20, 1, 49, 9, 786, DateTimeKind.Local).AddTicks(3486), "grey", new DateTime(2022, 2, 7, 0, 46, 5, 554, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7fe2ff2a-ceb3-4ac8-a185-67dd2ad71e1a"), "Maxime quia ut voluptatem.", "b440ca54-602c-447f-87aa-1236b81c217b", new DateTime(2021, 12, 6, 0, 38, 2, 786, DateTimeKind.Local).AddTicks(4502), "red", new DateTime(2022, 5, 29, 23, 26, 14, 188, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("827a2073-a8e8-4ead-a146-64741c28cb99"), "Illum libero incidunt aut pariatur repudiandae sed.", "057ebcc8-a0bd-4b36-87cf-227c0db1cd57", new DateTime(2018, 9, 25, 9, 13, 40, 945, DateTimeKind.Local).AddTicks(2352), "fuchsia", new DateTime(2019, 11, 13, 2, 31, 33, 824, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8474485b-9dcd-4c4f-aa77-f16e7c6e91f4"), "Qui ut quisquam.", "05403be3-fe05-48f5-ad28-6454a81591fb", new DateTime(2019, 2, 13, 1, 9, 28, 975, DateTimeKind.Local).AddTicks(3115), "plum", new DateTime(2022, 1, 2, 16, 4, 38, 205, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84dccb9d-45d1-44bf-b800-87a98470a74b"), "Qui sit voluptatum explicabo.", "5fec5c36-ac56-496a-8319-ff27b9fb00b3", new DateTime(2021, 5, 4, 14, 0, 54, 988, DateTimeKind.Local).AddTicks(9914), "teal", new DateTime(2021, 12, 21, 17, 12, 51, 648, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86af9c1f-af42-46e4-9472-d3ff72994c00"), "Voluptas impedit velit est placeat voluptas ut ad reprehenderit quia.", "d59aa1bb-29d9-4524-ad1e-12b5d80d6cd6", new DateTime(2021, 3, 15, 18, 28, 3, 720, DateTimeKind.Local).AddTicks(6078), "cyan", new DateTime(2021, 10, 1, 11, 1, 46, 431, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ceb1657-4344-4f7c-b983-36937173c377"), "Inventore assumenda maiores unde consequatur omnis similique odio rerum consequatur.", "0c6e3220-8a54-4f88-9a5f-395f70b3e1ef", new DateTime(2022, 3, 8, 18, 15, 45, 973, DateTimeKind.Local).AddTicks(385), "ivory", new DateTime(2022, 5, 2, 6, 31, 30, 262, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f7ebfc5-f2ff-46a2-a86b-a65ba692e7eb"), "Quae deleniti neque.", "2a9a3ea2-fbd3-4eef-bd6f-d5e6951d1fdf", new DateTime(2021, 3, 16, 3, 6, 40, 456, DateTimeKind.Local).AddTicks(8952), "black", new DateTime(2021, 6, 3, 8, 54, 47, 742, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92298cfe-45bf-4de5-9a85-abebf386bba4"), "Non deleniti unde.", "96de2669-f5c5-486a-abb1-91ff1014fa88", new DateTime(2021, 11, 15, 9, 2, 2, 690, DateTimeKind.Local).AddTicks(6955), "orange", new DateTime(2022, 2, 10, 10, 2, 54, 324, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("92605d84-75fd-49aa-9bd3-72a2cb1cbb13"), "Omnis ad vel magnam adipisci nulla eum.", "0ac0e80f-74fe-4e7a-acb7-0bb8f883c43b", new DateTime(2021, 10, 24, 0, 26, 4, 365, DateTimeKind.Local).AddTicks(3365), "salmon", new DateTime(2021, 12, 18, 9, 54, 52, 146, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("999fe3e5-60ec-416b-a6f9-27e3cc7c5ab0"), "Sit temporibus voluptatem quia dolorem laudantium qui quidem voluptate.", "cb9539d1-5c87-4a98-8b16-bf7307411f6f", new DateTime(2022, 5, 10, 15, 20, 52, 531, DateTimeKind.Local).AddTicks(387), "purple", new DateTime(2022, 6, 26, 9, 43, 57, 547, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9c3a52f3-c308-4f2d-9df6-a01d3c856fa7"), "Nam debitis vel et libero earum.", "72cb4cb9-e9dd-46ab-9f8c-392a12f5e34e", new DateTime(2017, 8, 21, 3, 57, 12, 182, DateTimeKind.Local).AddTicks(3898), "ivory", new DateTime(2021, 8, 23, 1, 52, 49, 448, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9caac69d-feba-4308-bb15-b9a8f64147c9"), "Id harum cumque cupiditate aut magni.", "072e3f6c-7806-46e3-ad10-f22d231183f5", new DateTime(2017, 12, 2, 15, 28, 17, 692, DateTimeKind.Local).AddTicks(2716), "azure", new DateTime(2019, 12, 9, 6, 56, 50, 530, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9dac649e-fbab-429a-9da9-cfbda1da99a4"), "Dicta voluptatem quidem animi qui omnis.", "78f20137-8ad4-46e1-9d6e-f92ded798a30", new DateTime(2020, 10, 5, 19, 16, 53, 747, DateTimeKind.Local).AddTicks(398), "silver", new DateTime(2021, 2, 8, 5, 22, 54, 79, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f2533e1-69d7-4332-8a4b-93c6f246a26e"), "Id consectetur cum illo et est ea laudantium.", "ae3c7fe5-cc5d-4065-aef5-3ace38613f1c", new DateTime(2020, 3, 8, 7, 57, 2, 758, DateTimeKind.Local).AddTicks(5114), "gold", new DateTime(2020, 6, 17, 3, 48, 31, 625, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f8b2d95-065a-4822-95db-8313ff0ac4b2"), "Fugit natus facilis aut deleniti neque esse.", "54725d50-fdcb-4f62-964c-851a991cae9a", new DateTime(2017, 7, 15, 10, 53, 34, 788, DateTimeKind.Local).AddTicks(495), "lavender", new DateTime(2022, 7, 1, 18, 36, 25, 50, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a029fb8b-3060-4951-92c1-bca3e701a887"), "Perferendis non voluptatum.", "1bb0a2ee-bd4d-49a9-97ef-3328fb0ffa07", new DateTime(2019, 8, 28, 7, 37, 27, 649, DateTimeKind.Local).AddTicks(8632), "silver", new DateTime(2021, 9, 13, 18, 30, 23, 553, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a1339198-8881-4594-9494-cf2d282ec7c1"), "Sit cumque recusandae voluptatibus at.", "d285b359-1099-49c8-a0e3-98a62a742b07", new DateTime(2019, 7, 18, 14, 6, 56, 383, DateTimeKind.Local).AddTicks(8068), "salmon", new DateTime(2020, 11, 5, 1, 9, 0, 923, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a14ee26f-f199-41fb-a661-cea73f993b46"), "Quaerat enim quibusdam vel recusandae.", "b81d62f3-52d9-49f0-8716-fff249316ce3", new DateTime(2018, 7, 1, 5, 2, 18, 791, DateTimeKind.Local).AddTicks(9237), "grey", new DateTime(2022, 3, 24, 22, 42, 16, 920, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a36db411-8221-4e89-ac47-4159613bf53f"), "Consectetur doloremque aut occaecati consectetur iure.", "63671a46-b37f-454c-861c-187366ca6e46", new DateTime(2019, 8, 22, 10, 31, 55, 841, DateTimeKind.Local).AddTicks(2943), "indigo", new DateTime(2019, 9, 4, 0, 28, 55, 9, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a4733873-8fd0-48ac-8401-d72ab2d1da44"), "Magni sunt consequatur amet repellat exercitationem enim placeat quia non.", "e5df7407-739c-499d-93e1-df9d85ed9fd2", new DateTime(2020, 2, 21, 19, 2, 33, 955, DateTimeKind.Local).AddTicks(7764), "black", new DateTime(2020, 8, 13, 4, 14, 43, 380, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a53f6c77-69d6-425f-8099-23741c21fc72"), "Iure soluta ratione voluptatum velit voluptate.", "34e0b7e9-183b-495a-8f70-635ba94b3474", new DateTime(2017, 9, 4, 2, 9, 18, 966, DateTimeKind.Local).AddTicks(3144), "sky blue", new DateTime(2018, 8, 5, 8, 10, 59, 531, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a857574d-4a70-444e-90c3-4e5369047f86"), "Voluptatum sit est enim omnis itaque qui sint.", "c5d8eefd-e445-4458-a315-a239b4f59d9c", new DateTime(2022, 4, 29, 19, 35, 9, 818, DateTimeKind.Local).AddTicks(3916), "silver", new DateTime(2022, 5, 7, 15, 17, 47, 149, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab31b504-5442-4524-8943-ab999d05c40b"), "Debitis vel nihil qui eum asperiores occaecati corrupti porro fuga.", "42fab824-5f52-4d8d-aa6f-d655bee08811", new DateTime(2018, 6, 6, 15, 3, 17, 70, DateTimeKind.Local).AddTicks(7738), "plum", new DateTime(2021, 9, 6, 8, 30, 20, 849, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae801a3b-181c-4c1e-a410-2fde94a735d0"), "Animi consequatur voluptas praesentium a optio necessitatibus sed.", "aae19b21-cf8f-4044-9b6e-0c8889abe44c", new DateTime(2020, 1, 3, 21, 37, 4, 98, DateTimeKind.Local).AddTicks(895), "olive", new DateTime(2020, 11, 18, 16, 26, 12, 105, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b354e2aa-6083-4a35-a800-bf59f29d7eaa"), "Repellendus quod iste deleniti quas.", "233f2b5b-5eee-4238-9c73-b10e88c6169e", new DateTime(2022, 5, 14, 3, 21, 58, 497, DateTimeKind.Local).AddTicks(6930), "ivory", new DateTime(2022, 7, 1, 15, 10, 12, 722, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3a8b154-6f69-4a9b-924e-9dbfc88fb523"), "Ea voluptatem deleniti architecto nesciunt aut assumenda.", "c1c4ad3e-ef50-481e-a499-9dab210d9fa5", new DateTime(2020, 7, 10, 1, 30, 36, 511, DateTimeKind.Local).AddTicks(324), "maroon", new DateTime(2022, 2, 18, 23, 25, 42, 431, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b4a29323-782a-4b13-a1d6-96bcaa459efb"), "Ut similique laborum occaecati.", "23d81826-528e-40f8-a6c3-b85820ebc188", new DateTime(2020, 2, 19, 15, 54, 36, 658, DateTimeKind.Local).AddTicks(1523), "ivory", new DateTime(2021, 10, 31, 11, 40, 9, 66, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba293f47-1b97-47f5-a67b-80756e323c29"), "Quas velit eius quia quia nisi reiciendis occaecati eligendi dolore.", "45621ac4-6aa2-4043-8b9b-6498402354f1", new DateTime(2018, 7, 20, 4, 55, 22, 188, DateTimeKind.Local).AddTicks(6191), "teal", new DateTime(2022, 1, 12, 22, 24, 14, 125, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bbfc24fd-ac96-4fb9-aabe-3fcdc61d53c7"), "Eveniet animi voluptatem sint quaerat sunt reprehenderit consectetur.", "341b335a-a08d-443d-96a7-07e7c9b524c4", new DateTime(2021, 3, 18, 12, 36, 41, 247, DateTimeKind.Local).AddTicks(7102), "blue", new DateTime(2021, 6, 7, 20, 28, 12, 348, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c673e512-93b2-4a8a-b91f-9655071b56e5"), "Voluptas soluta aliquam voluptatum enim.", "596dcbce-7ac7-460f-be2c-ffdde507617d", new DateTime(2018, 4, 17, 11, 1, 24, 975, DateTimeKind.Local).AddTicks(5206), "plum", new DateTime(2022, 2, 19, 11, 37, 20, 176, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7087f2a-1af9-4577-a273-1a195b9eba13"), "Blanditiis deleniti ea.", "5d9250a4-434c-4d8c-a23c-945dd32a32d7", new DateTime(2019, 10, 5, 20, 50, 57, 606, DateTimeKind.Local).AddTicks(7032), "salmon", new DateTime(2021, 4, 30, 20, 11, 25, 869, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c86a3520-b471-47bd-9ada-afab95dd7fad"), "Aut atque sint qui cumque molestiae aut.", "d2afe331-21ae-4fba-8493-6feff967938b", new DateTime(2021, 10, 25, 6, 0, 46, 90, DateTimeKind.Local).AddTicks(5154), "orange", new DateTime(2022, 4, 24, 10, 29, 44, 427, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8b32bf0-31a5-4013-b0ad-5c090425a0d7"), "Id repellat et.", "4919b49f-d342-4e52-9663-518db13b49b2", new DateTime(2021, 11, 24, 12, 13, 52, 577, DateTimeKind.Local).AddTicks(7270), "indigo", new DateTime(2022, 6, 1, 7, 18, 8, 950, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cfa1e566-36c7-4cfc-9fd0-a761223e0235"), "Labore adipisci ducimus assumenda animi laboriosam nesciunt nesciunt.", "e0a3971a-bd7b-4edb-8c38-239e1a78fa31", new DateTime(2018, 8, 14, 3, 11, 10, 71, DateTimeKind.Local).AddTicks(6774), "orchid", new DateTime(2022, 3, 16, 0, 44, 21, 257, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d10bfbc7-7ba6-48cc-8aa0-9a5d850a3c98"), "Repellendus commodi reprehenderit labore sed.", "bdb80379-0440-40f9-a240-00b7be54fe09", new DateTime(2021, 8, 20, 9, 49, 55, 326, DateTimeKind.Local).AddTicks(9014), "turquoise", new DateTime(2021, 11, 2, 9, 59, 16, 967, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d30b6df7-6ae4-4968-aae4-c92b7a7fb885"), "Voluptatem vero commodi facilis voluptate atque.", "7b3904be-e931-4b82-b166-caf5803189c1", new DateTime(2018, 1, 19, 19, 8, 9, 829, DateTimeKind.Local).AddTicks(3024), "mint green", new DateTime(2022, 5, 15, 6, 12, 15, 45, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d5c685eb-113f-4e4f-b5e5-dfc9957d6dd5"), "Consequatur sit rem est reprehenderit reprehenderit.", "33c82be6-83b8-4263-9334-6be300f33422", new DateTime(2022, 5, 31, 7, 26, 34, 731, DateTimeKind.Local).AddTicks(2280), "cyan", new DateTime(2022, 6, 29, 1, 5, 49, 647, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d6e098cf-f07c-4102-a2b1-8003dfa81294"), "Eos consequuntur similique quos et aut aut consequatur.", "649ef8f4-82fc-4851-819d-8cf2e525af62", new DateTime(2021, 8, 4, 20, 53, 5, 285, DateTimeKind.Local).AddTicks(9106), "sky blue", new DateTime(2022, 6, 24, 21, 44, 43, 638, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8e79bde-5102-4a97-8132-8626afa9b60f"), "Esse repellendus autem quidem porro nihil.", "d4bd3bc8-11ea-48ed-a839-c18daa5dca12", new DateTime(2020, 3, 10, 18, 16, 47, 942, DateTimeKind.Local).AddTicks(5078), "ivory", new DateTime(2021, 10, 17, 6, 42, 12, 338, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d95156a3-cc77-447c-9710-226c48998853"), "Tempore dolore non est corporis dolor voluptatem.", "a26c319c-9214-42bd-9d30-6d09a4359998", new DateTime(2019, 11, 4, 21, 20, 41, 634, DateTimeKind.Local).AddTicks(5722), "blue", new DateTime(2020, 4, 16, 15, 14, 13, 94, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da7e6a16-229a-43f9-ab1d-0a97d5649e9c"), "Quae ut maiores sunt tempora dignissimos voluptatem aut sed ut.", "c92e2953-e6fb-43cc-b14a-04ff41cdf59f", new DateTime(2019, 7, 11, 21, 46, 6, 697, DateTimeKind.Local).AddTicks(8788), "purple", new DateTime(2020, 5, 2, 14, 23, 29, 207, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("daf9fa39-8a4a-48ff-afb1-b21fbccc5d72"), "Et at unde quae laudantium unde aut quaerat in error.", "a4da4f74-1954-4efa-b697-26ded240bacc", new DateTime(2018, 12, 6, 8, 41, 42, 361, DateTimeKind.Local).AddTicks(8062), "violet", new DateTime(2022, 6, 7, 2, 40, 39, 641, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e0681bb3-1adf-4772-9fa9-df6c45217993"), "Ea quod impedit voluptatem et in est.", "1bc38a78-c97c-4985-8d9e-1915596603d4", new DateTime(2017, 9, 21, 13, 34, 18, 698, DateTimeKind.Local).AddTicks(575), "blue", new DateTime(2022, 6, 1, 23, 53, 21, 689, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2055ab4-70d5-46c7-b2c3-170a29f0611f"), "Velit beatae enim aut nihil expedita a.", "dd86ee9a-d97f-480e-966c-6f55c4276233", new DateTime(2018, 10, 31, 15, 5, 18, 839, DateTimeKind.Local).AddTicks(2016), "magenta", new DateTime(2022, 4, 26, 19, 48, 55, 767, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e453fd3b-5f32-42c5-ad8f-c571a4b69620"), "Molestias velit voluptatem harum dicta consequatur ipsa id harum.", "8385e855-5e8c-43ef-9e72-711daeb002b1", new DateTime(2020, 1, 12, 11, 5, 55, 539, DateTimeKind.Local).AddTicks(5245), "mint green", new DateTime(2021, 8, 30, 20, 35, 9, 880, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5f6511c-a403-450f-9d36-6aaa7d00d920"), "Est autem qui corporis.", "cd106cfb-0b26-4c38-b26e-ebbe9c15def7", new DateTime(2018, 8, 25, 5, 1, 20, 993, DateTimeKind.Local).AddTicks(5217), "black", new DateTime(2021, 4, 5, 0, 58, 17, 327, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7278652-3658-42bc-bc83-15ae0dae897a"), "Voluptatem tempora provident aliquam aut neque quis blanditiis.", "6c7c709b-34d5-4dad-8bb2-a5bfa201a86d", new DateTime(2021, 4, 30, 6, 32, 3, 15, DateTimeKind.Local).AddTicks(4076), "ivory", new DateTime(2021, 7, 16, 18, 5, 13, 140, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e9184b64-4dbe-430e-93c9-37b872019877"), "Et consequatur dolor qui vel omnis voluptas quia.", "e0f4742e-0e92-413a-864f-9747e5faccc7", new DateTime(2020, 10, 15, 16, 39, 1, 325, DateTimeKind.Local).AddTicks(272), "blue", new DateTime(2021, 3, 20, 0, 3, 15, 899, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec929361-9384-4aed-b671-3ba55e8515d8"), "Deleniti sed ipsum id ratione aut voluptates rerum voluptate nihil.", "21da61df-14d0-4625-884a-817ec6df2f8d", new DateTime(2021, 10, 24, 21, 8, 39, 348, DateTimeKind.Local).AddTicks(8902), "ivory", new DateTime(2021, 11, 21, 6, 47, 34, 387, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed83fabc-0b64-415c-8372-1ba2e8a250ad"), "Optio sapiente commodi sit earum iusto et.", "06f6653b-b403-4e73-8e11-446d07b81507", new DateTime(2017, 7, 21, 18, 7, 0, 84, DateTimeKind.Local).AddTicks(6110), "red", new DateTime(2018, 3, 5, 1, 34, 17, 188, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7c52aa8-2dde-4c60-b919-f17e4091b6f3"), "Quasi sit totam.", "36419a1c-8548-422c-b60c-3096b293b1ee", new DateTime(2021, 1, 2, 20, 5, 30, 558, DateTimeKind.Local).AddTicks(5408), "lavender", new DateTime(2021, 7, 13, 10, 42, 30, 418, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f8733eee-c95c-4c3c-947e-c73899eb9cd4"), "Quisquam amet repellat corporis magni.", "91790c59-6669-4e9a-9cc0-6d49eb1fc43c", new DateTime(2019, 7, 1, 11, 31, 10, 488, DateTimeKind.Local).AddTicks(4022), "yellow", new DateTime(2020, 5, 19, 17, 54, 37, 88, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f8a74a7d-a851-4088-b031-8fadd2843862"), "Unde explicabo ut eaque.", "43a5194c-e2e0-49c4-83aa-6ebcb8f7832c", new DateTime(2021, 12, 6, 8, 37, 28, 126, DateTimeKind.Local).AddTicks(8148), "teal", new DateTime(2022, 5, 20, 14, 0, 2, 187, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fae0bd47-00da-4555-9b03-262a097b47db"), "Asperiores fugiat natus dolores.", "1b9bccd9-cbfe-491d-84f8-e126d52a3f5a", new DateTime(2019, 7, 12, 2, 57, 45, 660, DateTimeKind.Local).AddTicks(654), "grey", new DateTime(2020, 4, 24, 5, 56, 25, 619, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fd4b0dcc-8cf1-4779-b803-13ede89b76b9"), "Nihil possimus impedit qui exercitationem corrupti natus provident.", "a035e54e-2718-4332-8fa7-25c901a9d707", new DateTime(2020, 11, 7, 14, 38, 6, 789, DateTimeKind.Local).AddTicks(342), "magenta", new DateTime(2021, 5, 25, 18, 6, 12, 110, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01d3ff66-83c0-4076-97a7-50ad7361204e"), "Aut et quia vero est nesciunt qui blanditiis error.", "bca660a3-60af-41d1-a356-eff0c0059b55", new DateTime(2017, 8, 11, 23, 54, 34, 204, DateTimeKind.Local).AddTicks(1949), "Product quanity: illo", new DateTime(2018, 3, 20, 21, 5, 17, 383, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("054eeb8f-8b7d-463d-ad5d-953adf20aa5c"), "Velit qui quam ducimus.", "f57ecd4b-402f-4fda-ba84-cc373098db0d", new DateTime(2022, 2, 13, 20, 5, 39, 18, DateTimeKind.Local).AddTicks(7247), "Product quanity: inventore", new DateTime(2022, 4, 22, 14, 47, 21, 402, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0852b5fe-2f2b-48a9-95f4-c432bbdda69d"), "Delectus facere laborum.", "4e4eba3c-b20e-44b6-bec8-3e9ba07e9122", new DateTime(2019, 2, 5, 6, 51, 0, 453, DateTimeKind.Local).AddTicks(1442), "Product quanity: consequuntur", new DateTime(2021, 10, 10, 5, 20, 26, 911, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("14c695b8-0378-4ec6-b339-180da7ff20a7"), "Soluta numquam voluptatem.", "2e127625-85cd-45ad-bc60-c2a89dac72bf", new DateTime(2022, 6, 3, 5, 17, 54, 433, DateTimeKind.Local).AddTicks(1665), "Product quanity: veritatis", new DateTime(2022, 6, 29, 1, 49, 57, 425, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("16843353-869d-4bfc-9aca-8b2e3c339808"), "Est commodi qui pariatur ut.", "b3776590-fe28-4957-ac53-a46a4ac91d9b", new DateTime(2021, 1, 2, 23, 57, 47, 292, DateTimeKind.Local).AddTicks(5748), "Product quanity: voluptatem", new DateTime(2022, 6, 18, 2, 39, 31, 196, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1cdc3578-1903-4e4a-b44a-eb914903f341"), "Officia ea fugit sit dolorem provident quidem impedit.", "510ebd3e-d74a-4ac1-97fe-9cc93140019a", new DateTime(2022, 5, 23, 10, 52, 7, 283, DateTimeKind.Local).AddTicks(2877), "Product quanity: consequatur", new DateTime(2022, 5, 25, 21, 10, 37, 934, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1ef8ac5c-1bbb-4d95-8447-c71a8bdca9e9"), "Rerum autem non voluptatem consequuntur vero dignissimos voluptas.", "5c7fb3a5-f100-4e2a-b128-32f0448f745e", new DateTime(2017, 7, 16, 12, 42, 8, 807, DateTimeKind.Local).AddTicks(3541), "Product quanity: est", new DateTime(2021, 10, 17, 21, 0, 19, 729, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24b67ebd-96c8-4765-ae87-a95e89f67b97"), "Molestias doloribus voluptates sed voluptatem sed consequatur eum consectetur illum.", "59e5734f-891f-4633-a5cc-3e08dad8c3ac", new DateTime(2020, 2, 28, 14, 33, 17, 87, DateTimeKind.Local).AddTicks(2282), "Product quanity: ut", new DateTime(2022, 5, 21, 14, 51, 53, 42, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24c21805-2ef6-4e37-ab2e-8df4b1c727c6"), "Qui ad et harum facilis et et ea similique.", "79878d4c-d37f-40ca-9ab0-161eab89fb40", new DateTime(2021, 9, 21, 20, 6, 3, 990, DateTimeKind.Local).AddTicks(1979), "Product quanity: aut", new DateTime(2021, 11, 11, 6, 28, 26, 686, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("277f61b5-0975-4b57-bb08-5a4df894251b"), "Et ipsum voluptatem iure non sed quis ab dignissimos vero.", "35de27b8-c3d7-4368-8764-f49c321a99d5", new DateTime(2018, 4, 5, 20, 21, 0, 504, DateTimeKind.Local).AddTicks(5203), "Product quanity: quod", new DateTime(2020, 1, 27, 14, 12, 51, 321, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2b575614-5585-4894-a981-9227fea901a3"), "Numquam voluptatem qui quasi eaque ducimus.", "a99ed3b5-d080-497f-9812-0c3cac85e1c4", new DateTime(2017, 11, 4, 22, 22, 53, 429, DateTimeKind.Local).AddTicks(222), "Product quanity: magnam", new DateTime(2021, 3, 20, 3, 7, 35, 932, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32ffcba8-7f10-4dcb-a6bc-d38ee968ebf3"), "Omnis quae repellendus.", "bb4839b3-7e5b-4e5a-81cb-85c53eccd382", new DateTime(2020, 8, 15, 13, 10, 17, 813, DateTimeKind.Local).AddTicks(833), "Product quanity: eum", new DateTime(2020, 10, 14, 16, 33, 25, 645, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("372578ac-32b0-4bc8-b47e-8ad47ae68030"), "Ut molestiae atque iusto aliquid.", "fc517368-230c-46ef-8c19-76f54ce45a43", new DateTime(2020, 9, 19, 5, 18, 4, 151, DateTimeKind.Local).AddTicks(4623), "Product quanity: voluptatem", new DateTime(2020, 9, 26, 12, 2, 55, 142, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38ddd0fe-f25a-432c-b1d2-ebbda1e58eac"), "Impedit aspernatur beatae aut sed porro dolor.", "310b5832-2331-40de-8965-ceac099c524f", new DateTime(2018, 12, 3, 8, 56, 46, 709, DateTimeKind.Local).AddTicks(5554), "Product quanity: sunt", new DateTime(2020, 3, 7, 17, 26, 5, 484, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3c35a048-6678-4844-acef-561f8a300585"), "Dolorum quisquam nesciunt nulla necessitatibus.", "fc8638df-d1ad-4a9a-a411-f2ddb223c544", new DateTime(2018, 11, 7, 9, 59, 22, 887, DateTimeKind.Local).AddTicks(3878), "Product quanity: consequuntur", new DateTime(2019, 12, 22, 22, 48, 37, 767, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41ae3730-df47-4e5e-b703-404df7aff1fa"), "Modi voluptas omnis beatae sed vitae.", "830033c3-9be0-4f0c-b8e8-faab6e2c2c52", new DateTime(2021, 4, 27, 22, 59, 44, 256, DateTimeKind.Local).AddTicks(8095), "Product quanity: consectetur", new DateTime(2022, 5, 31, 6, 34, 3, 611, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("45db0f13-d9d3-4046-aa33-81fd27be4a05"), "Et suscipit quam est.", "18f56c39-02ae-4d3d-8442-558412ca8bca", new DateTime(2019, 8, 17, 3, 15, 45, 567, DateTimeKind.Local).AddTicks(2982), "Product quanity: ea", new DateTime(2021, 1, 8, 15, 52, 24, 133, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("484aa2ea-bdff-41a8-839a-c00f9f690001"), "Ipsum vel non quas illum culpa repellendus consequuntur nemo.", "80a78d09-392c-4c0f-ade5-7a4a1e53964b", new DateTime(2018, 9, 8, 12, 30, 22, 436, DateTimeKind.Local).AddTicks(2563), "Product quanity: vel", new DateTime(2021, 6, 26, 19, 41, 24, 280, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("497bc570-564f-49ec-9951-b124855316da"), "Nihil in sit sit.", "84d544af-cc4b-4375-9d04-d26809492293", new DateTime(2020, 4, 24, 16, 20, 49, 113, DateTimeKind.Local).AddTicks(9512), "Product quanity: velit", new DateTime(2021, 11, 14, 1, 22, 41, 33, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b31f1c8-49e6-4b49-a315-abcfcd7f362e"), "Accusamus qui nostrum nesciunt sint blanditiis.", "5d852180-6512-42e1-b748-719323a509ba", new DateTime(2018, 2, 24, 18, 33, 20, 43, DateTimeKind.Local).AddTicks(4923), "Product quanity: itaque", new DateTime(2021, 5, 1, 11, 34, 25, 108, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e8ad202-446f-4fd8-b569-3194a1efed17"), "Ad alias inventore esse eveniet voluptatum facere.", "e5651d01-14bc-4d50-b0e5-dee57c40ee1c", new DateTime(2021, 9, 30, 21, 26, 10, 126, DateTimeKind.Local).AddTicks(872), "Product quanity: id", new DateTime(2021, 12, 25, 21, 38, 6, 538, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52a29f9e-3668-435b-b412-d0553297a0b3"), "Nostrum est vitae ut.", "dc9263b8-4d6e-4ee2-9954-84c13e60f97f", new DateTime(2017, 7, 22, 14, 57, 59, 939, DateTimeKind.Local).AddTicks(2013), "Product quanity: voluptas", new DateTime(2020, 5, 26, 10, 43, 17, 992, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55374852-a38c-4ae4-b68d-7c1888e0b432"), "Qui aspernatur reiciendis deserunt.", "0feda739-2587-4d96-aea7-305fffdbb9ac", new DateTime(2020, 6, 13, 4, 19, 0, 693, DateTimeKind.Local).AddTicks(7931), "Product quanity: minus", new DateTime(2020, 12, 18, 18, 53, 19, 536, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("564bcd39-d72e-49d9-8ad2-56aff658306f"), "In est commodi atque ipsam ut qui quia ut.", "dfd2d037-5e65-40d2-b64a-a5d6c33fa3be", new DateTime(2022, 4, 6, 15, 13, 13, 718, DateTimeKind.Local).AddTicks(4335), "Product quanity: quidem", new DateTime(2022, 5, 10, 10, 10, 55, 492, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("56c8bcc1-906c-4567-85aa-74353e4b3576"), "Et fugit neque iure dolorem.", "12a84fb0-dd00-4456-aaec-8a7d5e51d693", new DateTime(2021, 10, 13, 14, 28, 6, 173, DateTimeKind.Local).AddTicks(5666), "Product quanity: fugit", new DateTime(2022, 2, 27, 2, 29, 49, 511, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5839c865-7b09-46fa-af9b-0b73b0c0693d"), "Distinctio ea soluta ducimus et dolores sint iure minus ut.", "123b3bdc-a9b0-451d-83f0-bfcb80138b26", new DateTime(2021, 2, 23, 4, 28, 25, 553, DateTimeKind.Local).AddTicks(5881), "Product quanity: reprehenderit", new DateTime(2021, 9, 28, 7, 53, 52, 235, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c224ac4-b629-443d-809d-0b4c16bdf42b"), "Error et eum sapiente distinctio non voluptas architecto fuga quis.", "39e31872-87e2-4562-812f-3e9ab7726266", new DateTime(2020, 10, 31, 9, 3, 12, 282, DateTimeKind.Local).AddTicks(952), "Product quanity: numquam", new DateTime(2022, 1, 15, 9, 47, 14, 359, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e306126-575d-43ef-8c05-993e2226e2ef"), "Hic qui nulla dolorem non aliquam nemo vel aut.", "290c75a1-ce6b-4eac-9125-5606fc259856", new DateTime(2018, 2, 3, 0, 22, 48, 684, DateTimeKind.Local).AddTicks(8018), "Product quanity: itaque", new DateTime(2021, 9, 17, 2, 39, 52, 184, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e60e88c-00f9-4aa9-a21c-39f3969702db"), "Nobis dolor sit dolores sint commodi rerum eum.", "694b02e6-6786-42b2-93a6-80e9851325eb", new DateTime(2018, 8, 25, 18, 58, 32, 424, DateTimeKind.Local).AddTicks(9050), "Product quanity: ducimus", new DateTime(2022, 5, 30, 20, 51, 45, 797, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6318a2e3-dc5c-4419-bb24-e4989208ecbd"), "In possimus ea et quod et cupiditate vero.", "49d0fc15-557a-43ab-89c0-a29fb9b359e5", new DateTime(2018, 4, 6, 6, 56, 8, 472, DateTimeKind.Local).AddTicks(5205), "Product quanity: fugiat", new DateTime(2020, 1, 30, 22, 57, 5, 353, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("657dfaf1-529c-47a7-aed8-53b52ad92969"), "Reiciendis in tempore dolor.", "d572d9c8-462e-4886-b493-06abd1775d43", new DateTime(2017, 12, 28, 19, 40, 20, 918, DateTimeKind.Local).AddTicks(3080), "Product quanity: libero", new DateTime(2020, 9, 5, 11, 3, 41, 45, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e5d2071-2142-4b16-ab33-fe58783f19bd"), "Ipsa earum delectus voluptate nostrum.", "868136de-56b4-46be-84d3-1c14f5cdec40", new DateTime(2021, 5, 3, 5, 13, 5, 172, DateTimeKind.Local).AddTicks(8521), "Product quanity: animi", new DateTime(2021, 7, 10, 19, 8, 41, 77, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6facbef1-23e5-45f8-a249-9b59efb6cf69"), "Provident neque aut voluptas natus quas quia voluptate.", "52e3f48d-829b-4a9a-97b3-aa532f3bf078", new DateTime(2019, 3, 19, 14, 13, 48, 968, DateTimeKind.Local).AddTicks(7434), "Product quanity: nam", new DateTime(2019, 3, 21, 22, 34, 10, 837, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72994c73-93fd-4669-9553-c5d7c805ac23"), "Ipsum aliquid voluptatibus maiores fuga numquam.", "ae84e4e2-b990-4b88-a85d-307c1943fb6e", new DateTime(2021, 9, 23, 11, 20, 22, 220, DateTimeKind.Local).AddTicks(294), "Product quanity: magni", new DateTime(2021, 10, 16, 0, 10, 58, 784, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73162bd1-2b0f-414c-be69-c81a98fb1689"), "Illo consequatur dolore placeat eum qui voluptates veritatis.", "cd05921c-e245-407f-b7dc-0f79284ec201", new DateTime(2019, 6, 13, 0, 39, 51, 161, DateTimeKind.Local).AddTicks(2037), "Product quanity: et", new DateTime(2022, 1, 9, 11, 26, 43, 129, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73d11efb-70f9-4b47-ba8b-0bde21d85b95"), "Sit est accusantium quia ab commodi.", "100d232c-6b07-4b07-a9cf-ea63a5405b4a", new DateTime(2020, 6, 21, 18, 45, 56, 739, DateTimeKind.Local).AddTicks(2875), "Product quanity: enim", new DateTime(2020, 7, 6, 23, 31, 53, 496, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7688426a-c79d-497b-8752-c8f4ce5515d7"), "Dolor hic omnis eligendi.", "54f425bb-b90a-4f16-86a4-e1cc1b0ef81f", new DateTime(2019, 10, 20, 17, 26, 4, 605, DateTimeKind.Local).AddTicks(9160), "Product quanity: veniam", new DateTime(2020, 6, 11, 1, 12, 49, 93, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7870e2cf-d8c0-46e4-a565-5a6bf78348dc"), "Vel dolore odio deleniti id est quo ea non.", "fca1979b-c7cb-4b29-86cf-485596032f0f", new DateTime(2022, 2, 2, 20, 19, 10, 379, DateTimeKind.Local).AddTicks(9841), "Product quanity: accusamus", new DateTime(2022, 5, 21, 8, 2, 32, 729, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("78c555b9-14ba-4896-844e-054de9aeeca6"), "Dolorum esse quia doloremque.", "7a515427-391f-435a-8a5d-8315e221d26b", new DateTime(2022, 2, 1, 3, 22, 1, 664, DateTimeKind.Local).AddTicks(9289), "Product quanity: sit", new DateTime(2022, 4, 17, 15, 21, 5, 417, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("79ecc02b-de0f-4a36-bdbb-d52bee22dc49"), "Optio animi laboriosam aperiam fugit.", "b48050a1-387e-4c5d-8b1d-1e1dbc14239e", new DateTime(2018, 4, 3, 7, 3, 19, 390, DateTimeKind.Local).AddTicks(1), "Product quanity: asperiores", new DateTime(2018, 9, 24, 5, 59, 10, 277, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b1b687b-2eae-4b2a-ba67-91702e257e4a"), "Adipisci voluptate quasi fuga provident voluptas eaque.", "d61b39d8-1430-4519-8798-11bf27a8171d", new DateTime(2021, 2, 10, 3, 29, 15, 284, DateTimeKind.Local).AddTicks(6662), "Product quanity: qui", new DateTime(2021, 10, 24, 22, 58, 43, 249, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b3f8801-c7e1-4fe9-8857-aa402dbf9ef1"), "Eos quos ab praesentium.", "5535d504-5a7f-4e4b-a1ed-1a0823a2c75f", new DateTime(2022, 2, 28, 20, 40, 14, 918, DateTimeKind.Local).AddTicks(1983), "Product quanity: aut", new DateTime(2022, 3, 2, 17, 43, 54, 778, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7cd14937-cdbf-4e19-89b8-3380ea087443"), "Quasi commodi corporis magnam ut.", "11984474-7a9e-4c1a-9868-e767bf19fc4a", new DateTime(2019, 3, 12, 23, 38, 47, 627, DateTimeKind.Local).AddTicks(6825), "Product quanity: sint", new DateTime(2021, 2, 14, 19, 51, 44, 156, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7cdc6899-4457-46d0-93ff-9f216d64dc7a"), "Sequi minus voluptas.", "7b643f81-c520-4893-8b22-6f446d705ac6", new DateTime(2021, 4, 2, 7, 56, 13, 61, DateTimeKind.Local).AddTicks(6835), "Product quanity: nihil", new DateTime(2022, 2, 16, 11, 24, 47, 554, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7db0e38f-4d51-468d-a73d-1fe5dcaa355f"), "Quos mollitia qui ab expedita blanditiis aut ipsam distinctio.", "fdf88ada-0ecd-48aa-b4d5-9e11aece2931", new DateTime(2021, 5, 2, 10, 42, 4, 967, DateTimeKind.Local).AddTicks(6252), "Product quanity: et", new DateTime(2021, 7, 23, 5, 14, 35, 526, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7de7da4c-6beb-4dcb-b82d-6b5e85ce04f0"), "Et illo minus sed officia.", "533f19f7-5795-4b3d-a892-4e0e2fa61e7c", new DateTime(2017, 11, 17, 0, 28, 43, 249, DateTimeKind.Local).AddTicks(3229), "Product quanity: sit", new DateTime(2019, 9, 9, 1, 21, 16, 687, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("85354b19-4dd7-4381-be68-54d0f26a8408"), "Rem perferendis laborum velit.", "134b7298-1102-4764-a02a-94ed85ddedda", new DateTime(2019, 3, 16, 23, 52, 37, 260, DateTimeKind.Local).AddTicks(8770), "Product quanity: aut", new DateTime(2022, 7, 4, 4, 40, 48, 269, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("88d2a59f-faef-4a61-819e-7725f75ffa34"), "Vero numquam est quae veritatis.", "9b9c22a7-936e-4e2b-91fa-b898eb741394", new DateTime(2018, 9, 14, 10, 40, 5, 385, DateTimeKind.Local).AddTicks(8435), "Product quanity: quisquam", new DateTime(2022, 2, 15, 9, 35, 0, 164, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8922e85a-5490-412d-8150-aa4311ef3c5f"), "Pariatur illo maxime iure aut sed error a ut.", "7b78441d-f1e1-4c36-a509-4536bbff312a", new DateTime(2019, 4, 22, 16, 25, 30, 840, DateTimeKind.Local).AddTicks(3049), "Product quanity: dolorem", new DateTime(2022, 4, 5, 12, 24, 33, 80, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("898bf058-1cd6-4884-8de4-008309322792"), "Perspiciatis non tenetur et hic aliquam ea qui dolore temporibus.", "c2a0b8ce-9b16-4dd9-806d-e3d9af2dfb0e", new DateTime(2018, 6, 1, 17, 47, 31, 528, DateTimeKind.Local).AddTicks(4579), "Product quanity: et", new DateTime(2021, 10, 9, 11, 56, 24, 493, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c1d1982-c93a-4ce8-92f6-66110fcf2bbb"), "Modi velit illum exercitationem voluptas laborum quia eos a beatae.", "9eb6b506-6843-40f8-8128-ac16950e1bdd", new DateTime(2018, 12, 27, 3, 7, 29, 786, DateTimeKind.Local).AddTicks(8810), "Product quanity: quisquam", new DateTime(2020, 11, 22, 2, 37, 13, 487, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d47a116-be92-4374-83c3-e1ad63f3b615"), "Aut nam possimus eaque consequatur nisi corrupti.", "d3c56ef0-9836-4855-a964-ab9106ddd991", new DateTime(2021, 12, 27, 7, 57, 6, 227, DateTimeKind.Local).AddTicks(9408), "Product quanity: labore", new DateTime(2022, 3, 3, 7, 47, 58, 123, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8df2ad21-2e23-4f85-bcee-cdfd4b3652d0"), "Velit omnis magni debitis voluptate similique.", "fd2627f3-8d6e-4284-b396-22247cee9b37", new DateTime(2020, 11, 28, 21, 4, 14, 113, DateTimeKind.Local).AddTicks(7223), "Product quanity: sed", new DateTime(2021, 5, 2, 20, 44, 23, 351, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e5e8e0c-f450-4467-a7b0-995274c064eb"), "Quo error optio iusto.", "8859cbcc-f7f4-443d-97bb-3e9ab6274875", new DateTime(2017, 11, 18, 15, 59, 32, 274, DateTimeKind.Local).AddTicks(1504), "Product quanity: unde", new DateTime(2021, 4, 30, 9, 12, 5, 454, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ee8d0d7-9ecc-4c49-869f-1a03039f3d33"), "Neque voluptatum aliquam in dolor.", "4688d61e-4426-4a8d-9208-fbb5593d66b7", new DateTime(2021, 12, 28, 22, 23, 11, 719, DateTimeKind.Local).AddTicks(5218), "Product quanity: est", new DateTime(2022, 2, 4, 6, 12, 14, 464, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9969be90-96f1-4b81-8390-81b7a01a0373"), "Sint nemo soluta beatae dicta aspernatur quo.", "68221690-c04f-4589-85e9-f8b5e929510e", new DateTime(2022, 3, 1, 4, 52, 0, 131, DateTimeKind.Local).AddTicks(990), "Product quanity: aut", new DateTime(2022, 4, 1, 10, 31, 14, 553, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9c59095e-e6a6-4ae2-ba75-58fb81a39688"), "Enim doloribus molestiae.", "cb713142-0fc5-4740-a4a6-9d472fa90705", new DateTime(2019, 12, 21, 22, 29, 26, 303, DateTimeKind.Local).AddTicks(7241), "Product quanity: magnam", new DateTime(2020, 1, 7, 21, 2, 33, 524, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9c6f57b2-6444-4ae0-9781-fff1b7321f5c"), "Eaque modi laudantium praesentium.", "703e2105-f7a4-44aa-955c-dd50cbf77fe0", new DateTime(2022, 5, 22, 1, 39, 45, 179, DateTimeKind.Local).AddTicks(624), "Product quanity: itaque", new DateTime(2022, 6, 9, 2, 8, 12, 614, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a486816d-a0f3-47e7-9fb3-89d94df8f87b"), "Deserunt quas odit sapiente.", "1461a772-f037-42d8-ab4e-8e8c8d1f85b8", new DateTime(2020, 5, 28, 21, 13, 22, 251, DateTimeKind.Local).AddTicks(8505), "Product quanity: dolorem", new DateTime(2022, 2, 15, 3, 10, 38, 742, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a65c720e-95bf-4330-82fe-4727f0c93316"), "Quam voluptatibus aut voluptatem in ut facere facere est accusantium.", "9437ccd4-c21a-4ab5-93d5-107af5a824ae", new DateTime(2019, 1, 21, 3, 0, 7, 738, DateTimeKind.Local).AddTicks(7569), "Product quanity: amet", new DateTime(2021, 5, 18, 22, 18, 19, 771, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a843a8d4-8e34-45b5-b232-6e1532e96714"), "Assumenda quaerat sed omnis suscipit.", "3ac717b1-5e9d-4743-9325-2cd16def5a6e", new DateTime(2020, 8, 30, 23, 56, 43, 394, DateTimeKind.Local).AddTicks(9700), "Product quanity: quos", new DateTime(2022, 2, 19, 18, 56, 15, 447, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9c2d157-b72b-42ec-98db-550bbb68dd52"), "Sed eius quam assumenda consequatur.", "65400e36-8316-47bc-8b90-ca0719fdfb94", new DateTime(2020, 5, 10, 23, 15, 49, 664, DateTimeKind.Local).AddTicks(7287), "Product quanity: ipsam", new DateTime(2021, 4, 24, 13, 4, 0, 916, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa2b4c2f-a34f-41b8-9c66-002420d88072"), "Dolore perferendis totam incidunt soluta voluptas et nemo quia laborum.", "c74e1c5a-8fad-4fed-beb9-20ea6806b52e", new DateTime(2020, 1, 2, 22, 48, 25, 743, DateTimeKind.Local).AddTicks(1514), "Product quanity: ut", new DateTime(2022, 6, 9, 0, 57, 48, 164, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ac391766-4a19-4035-b9c2-e4e20703480b"), "Repudiandae quia sed ut qui repellat qui maxime minus.", "57d232a7-3c51-400c-a5cf-4b25d55543ab", new DateTime(2018, 5, 15, 21, 21, 32, 749, DateTimeKind.Local).AddTicks(6016), "Product quanity: aspernatur", new DateTime(2019, 9, 15, 19, 27, 27, 276, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae99a1dc-ac45-464e-a5d2-4026101cef1e"), "Voluptates est quae debitis quia blanditiis provident quia.", "bba08ff6-00dd-4512-8112-9b2cfac5124a", new DateTime(2018, 12, 24, 4, 25, 52, 85, DateTimeKind.Local).AddTicks(1788), "Product quanity: pariatur", new DateTime(2018, 12, 24, 5, 56, 17, 467, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b032b9d9-d79e-43a6-99d1-a8f0677ce391"), "Qui dolorem fuga dolores.", "36450501-580c-4a1c-83b4-ba92cf5b5107", new DateTime(2018, 4, 13, 14, 18, 5, 524, DateTimeKind.Local).AddTicks(8238), "Product quanity: esse", new DateTime(2021, 9, 21, 7, 32, 32, 765, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1016bb0-93e8-403c-bee4-5219dc578155"), "In fugiat ut quasi deserunt sint.", "1039d98f-fc5f-44e1-8db2-e20bb486da8d", new DateTime(2017, 8, 17, 16, 18, 0, 291, DateTimeKind.Local).AddTicks(8060), "Product quanity: dolorem", new DateTime(2018, 9, 18, 16, 55, 48, 734, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b50ed171-42f9-42d0-af50-99978098df6c"), "Magni et aperiam.", "d693df92-fce5-4388-9fdf-1bce1d703e7d", new DateTime(2021, 5, 10, 10, 55, 11, 437, DateTimeKind.Local).AddTicks(4379), "Product quanity: quibusdam", new DateTime(2022, 6, 16, 11, 55, 15, 360, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b69273e0-9232-4141-9789-91de0df037fe"), "A et provident ex sint quos illum dolores iure.", "c1d9aef2-9cdb-443b-81c7-6cf7e29dae38", new DateTime(2021, 6, 6, 11, 49, 16, 789, DateTimeKind.Local).AddTicks(4870), "Product quanity: assumenda", new DateTime(2021, 8, 17, 8, 51, 21, 275, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba61e43b-728e-4e63-b8f6-702bab0a4ef0"), "Quam rem occaecati dicta qui ducimus iusto.", "ada1bb03-416f-461b-a5c1-e8e5a18cb67e", new DateTime(2019, 12, 24, 11, 6, 20, 846, DateTimeKind.Local).AddTicks(7481), "Product quanity: est", new DateTime(2021, 6, 6, 5, 23, 40, 869, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd2139c8-1acc-4ea3-9b8f-9d7bc778b150"), "Consequatur tenetur sint eveniet est nostrum cupiditate vel.", "a3f142c5-13a5-4dce-81b0-0596d32f7c69", new DateTime(2019, 8, 23, 14, 3, 24, 23, DateTimeKind.Local).AddTicks(6828), "Product quanity: molestias", new DateTime(2021, 2, 8, 13, 31, 42, 139, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdb38d38-167a-4fb2-8c31-6bdbc5b94b64"), "Quidem quae quibusdam quia et cumque accusantium.", "0189c462-9856-4b1e-bc2c-03b74365c048", new DateTime(2018, 11, 27, 1, 13, 21, 12, DateTimeKind.Local).AddTicks(8145), "Product quanity: hic", new DateTime(2020, 7, 16, 15, 45, 13, 377, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0815687-e960-4350-a12c-057bc3da12f1"), "Similique beatae ab harum iure repellendus numquam omnis provident.", "08615cf6-d018-4fc1-bfb0-e4fe283b71c6", new DateTime(2021, 11, 14, 0, 22, 22, 751, DateTimeKind.Local).AddTicks(5501), "Product quanity: qui", new DateTime(2022, 6, 22, 18, 37, 2, 32, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c21f12e5-c713-425e-bb76-1bc20266d577"), "Omnis et consectetur odit.", "a4c6093f-2c1c-4604-8de9-6ba3ccdd82af", new DateTime(2021, 11, 6, 2, 4, 38, 385, DateTimeKind.Local).AddTicks(64), "Product quanity: illo", new DateTime(2022, 2, 23, 21, 0, 0, 914, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c38aa4a0-b663-4b68-abe9-541ec0fe766c"), "Molestias esse vero sit dolorem consectetur adipisci modi fugit.", "c1c4ab65-ad00-4638-8a79-55adde926275", new DateTime(2020, 2, 6, 23, 15, 30, 710, DateTimeKind.Local).AddTicks(9184), "Product quanity: aliquam", new DateTime(2021, 5, 19, 19, 37, 49, 20, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c4c0cb73-4bd7-4db2-bf9d-7385297404a8"), "Ut ut aliquam qui.", "539c1e61-ff8f-4ed2-b70f-7702f2432cf5", new DateTime(2018, 5, 27, 8, 26, 54, 632, DateTimeKind.Local).AddTicks(2889), "Product quanity: ullam", new DateTime(2020, 7, 31, 8, 46, 20, 398, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c6e372e3-2336-4f22-9260-88bc24561812"), "Temporibus dicta repellendus.", "79e87ada-ad9f-4668-b556-76b665756feb", new DateTime(2018, 2, 7, 1, 13, 38, 759, DateTimeKind.Local).AddTicks(3371), "Product quanity: illo", new DateTime(2019, 9, 27, 16, 18, 11, 542, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7cf296d-ebd5-4aa4-9d9d-77b224c538b0"), "Veritatis iusto expedita cum sunt voluptatem.", "0ba65f0d-9179-491f-969b-c70bd1403a86", new DateTime(2021, 4, 18, 19, 35, 9, 949, DateTimeKind.Local).AddTicks(6632), "Product quanity: deserunt", new DateTime(2022, 4, 2, 19, 21, 19, 996, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cc4fa982-684a-42a4-b443-56ab6185d4be"), "Ut aut minus.", "7c372cbe-7120-41f2-8e8c-77ce34661a98", new DateTime(2018, 11, 24, 10, 51, 47, 362, DateTimeKind.Local).AddTicks(347), "Product quanity: alias", new DateTime(2021, 10, 3, 11, 23, 56, 902, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ce40e626-1b60-485f-aa57-11c6858a943f"), "Rem maiores atque numquam sit consectetur.", "5a6e069c-0f5b-4624-a134-b5cb9f4b5ae0", new DateTime(2019, 6, 12, 4, 9, 29, 365, DateTimeKind.Local).AddTicks(2758), "Product quanity: dolores", new DateTime(2022, 3, 27, 23, 15, 46, 23, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cec9b084-6857-42f1-95a2-6fa18b75ac62"), "Et ut maiores cumque.", "8c55a914-53b7-4fcc-8d32-965316f84b07", new DateTime(2021, 3, 7, 11, 8, 15, 951, DateTimeKind.Local).AddTicks(7321), "Product quanity: incidunt", new DateTime(2021, 5, 25, 16, 29, 56, 393, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d0ace004-79e0-4e98-93ed-fbcafa03c991"), "In cupiditate qui.", "479c1b78-2aff-4e5e-a8b5-8b3a10a1b624", new DateTime(2018, 5, 12, 18, 23, 7, 222, DateTimeKind.Local).AddTicks(7948), "Product quanity: ut", new DateTime(2021, 9, 19, 2, 8, 5, 477, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1fda960-deb9-4710-ac99-c8fcd4eb0d12"), "Sequi voluptatum aut aut dolorum eaque.", "7506d805-15bd-45b2-8117-d57cea5ae1f8", new DateTime(2020, 9, 26, 14, 37, 5, 757, DateTimeKind.Local).AddTicks(3997), "Product quanity: ipsum", new DateTime(2021, 4, 15, 18, 1, 7, 117, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d355a93e-64b7-46ea-8b09-e4905fc61c45"), "Omnis et commodi saepe aut voluptates maiores velit soluta dolores.", "1ba6bdf5-3c41-4fad-a0d5-9313ec8f6c2a", new DateTime(2021, 3, 8, 15, 37, 9, 439, DateTimeKind.Local).AddTicks(9215), "Product quanity: consequatur", new DateTime(2022, 5, 9, 7, 22, 21, 553, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7fcc9c7-031c-4f41-ae99-94c10a0add38"), "Aut odit dolorem.", "3f3c6375-1ee1-4ff1-8200-f4f189050a9f", new DateTime(2020, 9, 8, 9, 7, 24, 947, DateTimeKind.Local).AddTicks(3321), "Product quanity: assumenda", new DateTime(2021, 10, 1, 7, 44, 44, 647, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d86ce8bd-1d07-4456-a452-b7907b2fcb58"), "Et unde eius sint ea ut in.", "2b13ec98-da77-4fdd-bfa6-ff66f84bc329", new DateTime(2020, 7, 13, 13, 35, 53, 236, DateTimeKind.Local).AddTicks(2558), "Product quanity: laudantium", new DateTime(2020, 8, 29, 22, 33, 46, 400, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da38e70c-68a6-40c4-8c97-c7e7afbf7d77"), "Consequatur laudantium incidunt repellendus porro ut.", "162891da-7f10-4dcb-8dd9-bb550aac19c8", new DateTime(2020, 1, 23, 10, 4, 45, 122, DateTimeKind.Local).AddTicks(2007), "Product quanity: non", new DateTime(2020, 10, 13, 8, 25, 18, 267, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db57e23e-cb91-4f47-9b32-7b56402179d6"), "Culpa ea voluptatem explicabo.", "2d0a6728-5df8-4d9a-87b0-8cd17225dd71", new DateTime(2022, 6, 3, 18, 5, 14, 102, DateTimeKind.Local).AddTicks(4423), "Product quanity: nesciunt", new DateTime(2022, 6, 10, 18, 7, 0, 152, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dccb73cc-8d39-493f-af85-57a2daf3af07"), "Non ipsum consectetur aliquam et eos velit et.", "a32ab340-750f-4e5b-8e0f-121df8d2d253", new DateTime(2018, 4, 20, 9, 27, 46, 373, DateTimeKind.Local).AddTicks(5965), "Product quanity: non", new DateTime(2022, 6, 5, 20, 15, 29, 680, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5b793d4-0f69-4498-8f60-0e426507481e"), "Aut minima consequatur.", "dbd575d0-723f-4418-8ab6-98de072b8ad5", new DateTime(2017, 8, 12, 18, 13, 43, 791, DateTimeKind.Local).AddTicks(1802), "Product quanity: fugit", new DateTime(2022, 4, 26, 20, 47, 16, 418, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e66c8526-27db-4b39-9b02-aa1133bbddec"), "Atque consequatur quae deleniti et cum.", "b51c1e03-4143-4377-8843-2e6e148fe004", new DateTime(2017, 7, 20, 7, 3, 4, 490, DateTimeKind.Local).AddTicks(3594), "Product quanity: dolor", new DateTime(2021, 12, 3, 21, 58, 10, 243, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6761819-f187-428f-b376-a387c390d26a"), "Praesentium eligendi maxime quia molestiae.", "4b4fbed3-0b03-47fc-ba08-4604338fbdd0", new DateTime(2019, 1, 25, 16, 32, 2, 60, DateTimeKind.Local).AddTicks(3530), "Product quanity: est", new DateTime(2020, 4, 10, 22, 54, 54, 469, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6a8473a-c4ae-4fdd-8842-b0017fcd7298"), "Dolor id harum vero atque et.", "1033ff96-2b85-43a9-bc54-126944d2462e", new DateTime(2020, 12, 22, 14, 46, 59, 914, DateTimeKind.Local).AddTicks(1644), "Product quanity: in", new DateTime(2020, 12, 25, 13, 35, 58, 965, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eabfbd09-29e1-4b57-8523-f674ce294840"), "Accusamus repellat ipsum fugit quae placeat perspiciatis.", "267ae4cf-3fec-4aa9-b1ed-00d6b18cb60e", new DateTime(2019, 12, 8, 0, 2, 21, 864, DateTimeKind.Local).AddTicks(6214), "Product quanity: hic", new DateTime(2019, 12, 21, 5, 52, 6, 130, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f14f9ccc-f25d-4b2b-8932-a1d325e4c98f"), "Est ullam accusamus voluptate non corrupti.", "1c5b4287-fc2b-408d-aa7e-f63a75141315", new DateTime(2022, 3, 20, 16, 1, 38, 452, DateTimeKind.Local).AddTicks(9505), "Product quanity: ea", new DateTime(2022, 4, 24, 22, 42, 36, 87, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f5732e4e-1f4c-4529-948f-0083a1ed80fb"), "Nihil officia aut temporibus ab sequi tempore dolor omnis.", "7e02bf35-fdc7-4d1a-b3c6-64cfd69168bb", new DateTime(2021, 12, 16, 3, 41, 52, 733, DateTimeKind.Local).AddTicks(6738), "Product quanity: id", new DateTime(2022, 5, 15, 2, 21, 34, 64, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f5f124c0-3176-4219-b968-c9d972b2ee22"), "Sit accusamus quas explicabo.", "81489406-76eb-4e38-8163-30176ae0a193", new DateTime(2022, 2, 1, 0, 44, 35, 638, DateTimeKind.Local).AddTicks(4832), "Product quanity: ducimus", new DateTime(2022, 4, 5, 8, 1, 7, 817, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f8540e6c-99aa-4214-94fc-4894a945205d"), "Libero iusto labore suscipit vel natus.", "eb06faef-b304-44a5-86ef-79be78c180e3", new DateTime(2019, 6, 4, 19, 38, 30, 374, DateTimeKind.Local).AddTicks(4942), "Product quanity: laborum", new DateTime(2019, 12, 12, 20, 43, 27, 888, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb0dc785-40b2-4967-a493-489dbc11d4d5"), "Quasi exercitationem dolorem voluptatem totam.", "2af19fd2-83c2-4358-8359-38e4b927c957", new DateTime(2021, 9, 3, 2, 32, 52, 492, DateTimeKind.Local).AddTicks(7975), "Product quanity: nulla", new DateTime(2022, 4, 13, 9, 15, 1, 283, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.InsertData(
                table: "ProductQuantity<Guid>",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("febab788-bc4d-4ff6-bb2c-ecc92506628d"), "Non vero dolor aut dolor tempora dolores.", "e1949b86-901e-4f14-bfb1-caaf57ede485", new DateTime(2022, 5, 2, 23, 31, 11, 604, DateTimeKind.Local).AddTicks(738), "Product quanity: veritatis", new DateTime(2022, 6, 7, 8, 35, 5, 207, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04335bb8-4e36-43fd-8f5a-5d7ef29dab2c"), "Molestiae quia autem perferendis blanditiis autem aut nesciunt maiores.", "eb051d43-aca2-4fa0-95fe-8c24e5fdffa0", new DateTime(2017, 7, 26, 17, 24, 22, 868, DateTimeKind.Local).AddTicks(8767), "Product serie: 6790294873278", new DateTime(2018, 11, 15, 20, 6, 10, 684, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06c80d6e-3f81-4571-9275-e26c14ccab69"), "Architecto praesentium ipsa voluptatem perferendis optio blanditiis.", "1c9f8b61-1d45-4e56-a155-c966e2422c82", new DateTime(2022, 4, 25, 10, 16, 1, 18, DateTimeKind.Local).AddTicks(4203), "Product serie: 5429303633558", new DateTime(2022, 6, 29, 15, 24, 43, 320, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0894327d-1016-486e-97df-134a840cf272"), "Rerum est a.", "76ef7211-d054-462e-82ae-2eb37db8f76c", new DateTime(2019, 12, 23, 10, 10, 50, 590, DateTimeKind.Local).AddTicks(2168), "Product serie: 1366516918871", new DateTime(2021, 4, 4, 1, 56, 52, 746, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08ac14e9-844b-4dfc-82d8-4896549d902a"), "A blanditiis ut at.", "9676e133-3ea3-4275-8a29-8e8a7f3e1eb0", new DateTime(2020, 9, 27, 3, 11, 32, 558, DateTimeKind.Local).AddTicks(3544), "Product serie: 9508551293960", new DateTime(2022, 2, 16, 9, 5, 30, 812, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("08c683c6-1a35-4f65-81c2-4e979266f510"), "Eum fugiat unde possimus voluptate dolores.", "0ad6de7e-80e6-455c-b105-5b0b3a7a3dc7", new DateTime(2018, 12, 17, 9, 25, 30, 177, DateTimeKind.Local).AddTicks(6850), "Product serie: 7869078881262", new DateTime(2021, 4, 17, 20, 32, 52, 29, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a3f056d-9a31-4b3c-bb2b-21f6292ff906"), "Nesciunt amet assumenda est blanditiis molestiae architecto voluptatem alias deserunt.", "808723e5-51a3-4d28-bec0-a004e20b2d4e", new DateTime(2017, 11, 7, 9, 50, 51, 899, DateTimeKind.Local).AddTicks(2798), "Product serie: 5868340262169", new DateTime(2018, 5, 14, 2, 32, 48, 143, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a5bcdf6-a7ed-4849-a1b8-52e3de080aeb"), "Assumenda et placeat earum earum nostrum delectus blanditiis perspiciatis.", "ecd42e7c-caf8-41d9-9783-631d3d8ccb7b", new DateTime(2022, 1, 13, 2, 58, 41, 671, DateTimeKind.Local).AddTicks(8221), "Product serie: 0770689631955", new DateTime(2022, 3, 31, 23, 50, 44, 796, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0df597f8-f4c3-4a61-b4e0-d67568340774"), "Ab debitis architecto eum facilis commodi et animi.", "557aa327-5f77-4553-aab0-8f39a3a27f23", new DateTime(2019, 6, 27, 7, 53, 26, 873, DateTimeKind.Local).AddTicks(6065), "Product serie: 5781918183744", new DateTime(2021, 12, 22, 19, 18, 3, 58, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12220fe6-9545-4d1c-a16d-3dfaa5a44a3c"), "Facilis amet sed illo rerum.", "dd6a7b8e-a748-4be9-a3e8-26a125a55223", new DateTime(2019, 7, 8, 6, 36, 45, 566, DateTimeKind.Local).AddTicks(9739), "Product serie: 7094641738982", new DateTime(2019, 10, 27, 15, 41, 0, 359, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1470d9b4-18f6-4226-81f9-78f4b755cab3"), "Atque qui nobis ut sed possimus porro voluptates consequatur provident.", "abdea5f6-c7ad-4508-93f1-57ea48d07345", new DateTime(2019, 3, 23, 20, 22, 16, 968, DateTimeKind.Local).AddTicks(537), "Product serie: 6274273839184", new DateTime(2019, 8, 8, 3, 2, 39, 543, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1507a7ea-78c9-4115-887e-ee0cc79dd8bc"), "Omnis aperiam in.", "0a1304b1-5707-4b78-acb8-293b163d2163", new DateTime(2018, 9, 3, 3, 23, 7, 810, DateTimeKind.Local).AddTicks(5829), "Product serie: 0793296933861", new DateTime(2021, 12, 4, 20, 27, 21, 217, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15b83540-6fbc-430c-9881-d0a5bd1fdb0e"), "Animi ut voluptas non.", "10d3669f-d02a-4639-95b0-123437d2e213", new DateTime(2020, 12, 31, 10, 30, 24, 84, DateTimeKind.Local).AddTicks(5638), "Product serie: 2777277616699", new DateTime(2021, 2, 5, 13, 20, 19, 628, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("18412f83-4678-40ed-afdf-35c6edd19215"), "Quidem eligendi eum consectetur a voluptas sapiente cum.", "08258836-ec0b-472c-8413-1c76e9f9cd3f", new DateTime(2022, 5, 11, 15, 22, 6, 30, DateTimeKind.Local).AddTicks(7353), "Product serie: 9428022329809", new DateTime(2022, 7, 2, 10, 28, 41, 37, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c3be2d5-4e49-43df-b033-85a22c9812ea"), "Rerum laudantium est quia est magnam id aut.", "ab21d592-9fd5-4579-900e-45c440ad968a", new DateTime(2018, 8, 20, 15, 34, 26, 826, DateTimeKind.Local).AddTicks(5057), "Product serie: 3349926975144", new DateTime(2022, 6, 21, 16, 42, 47, 565, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e25a55f-5353-403e-a294-dd5fa9898d03"), "Libero porro repudiandae voluptatem earum culpa molestiae numquam unde similique.", "e42ee15d-485a-4899-8b57-9e943fbb4975", new DateTime(2019, 3, 1, 15, 57, 30, 599, DateTimeKind.Local).AddTicks(6329), "Product serie: 6184304014094", new DateTime(2021, 3, 19, 18, 25, 16, 158, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("213e3f60-e20f-4ead-a5b1-fbf038873301"), "Modi deleniti ut.", "677cfeef-8d88-4226-b744-4084dcb87cc0", new DateTime(2020, 3, 28, 7, 29, 12, 145, DateTimeKind.Local).AddTicks(9994), "Product serie: 0860089912805", new DateTime(2020, 12, 3, 7, 21, 8, 456, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2312e346-6e98-4150-b317-f38184698a97"), "Qui nostrum et nulla quam magni qui non eius eos.", "cd9c6df1-6744-4865-b1ea-849127dffe68", new DateTime(2018, 8, 1, 15, 6, 21, 260, DateTimeKind.Local).AddTicks(561), "Product serie: 7485936606374", new DateTime(2022, 2, 26, 9, 52, 1, 694, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2317baea-e815-49ba-be1f-f4a9c3d527fc"), "Voluptas iste accusamus minima voluptatum.", "7756b41b-b782-422c-9dca-62ce9ad2f81c", new DateTime(2018, 6, 17, 10, 14, 59, 452, DateTimeKind.Local).AddTicks(8052), "Product serie: 7959330633569", new DateTime(2021, 12, 9, 1, 32, 16, 968, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2339a502-fed4-4c20-81d7-5ab43c7248df"), "Id nostrum provident aut ut libero ut.", "1cbf5baf-989d-41a5-84f0-aadcd3efcc29", new DateTime(2019, 10, 27, 12, 45, 24, 491, DateTimeKind.Local).AddTicks(6528), "Product serie: 0147354587488", new DateTime(2020, 3, 13, 17, 38, 47, 144, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23e4f856-d10e-4c8f-a16f-e4bab4300c4b"), "Qui tempora quos quia ut laudantium consequatur expedita error molestiae.", "22620e49-72cb-49af-9822-9acf1203d4ea", new DateTime(2022, 5, 28, 22, 47, 19, 497, DateTimeKind.Local).AddTicks(2821), "Product serie: 1380515234817", new DateTime(2022, 6, 11, 3, 29, 28, 270, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2434e6da-1bb5-4708-91f2-d5119154b2d7"), "Et quod quis reiciendis nemo similique est omnis repudiandae.", "31a9238d-de60-4b8f-9c03-d18f2f923743", new DateTime(2022, 4, 23, 18, 59, 16, 893, DateTimeKind.Local).AddTicks(9964), "Product serie: 9279836692104", new DateTime(2022, 5, 19, 11, 24, 16, 37, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26f00159-7930-45f4-a3f8-12da1fe252db"), "Hic quaerat nesciunt mollitia aperiam rerum ut aspernatur soluta quis.", "4b960d47-721d-4783-9da0-04bb4e88e736", new DateTime(2018, 4, 4, 21, 57, 32, 53, DateTimeKind.Local).AddTicks(242), "Product serie: 6329067286818", new DateTime(2022, 2, 19, 15, 14, 45, 154, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("272bd18c-c77a-48b6-b2a3-29689424177d"), "Sapiente sit voluptatem veniam voluptas consequuntur est ab culpa.", "f36d9245-ab75-4c63-9de4-6cd24aab40dc", new DateTime(2021, 8, 26, 20, 21, 25, 877, DateTimeKind.Local).AddTicks(3786), "Product serie: 3401912793153", new DateTime(2021, 11, 24, 13, 41, 32, 610, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("27e86bcd-0a5a-46ab-a722-146e4e72be40"), "Corrupti velit odio nisi ab ea molestias qui ratione.", "0ed639ca-3954-4c8b-bb12-f511028f6c18", new DateTime(2021, 7, 23, 12, 51, 52, 680, DateTimeKind.Local).AddTicks(815), "Product serie: 3899955439624", new DateTime(2021, 10, 5, 20, 13, 3, 234, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("29e391a7-ff20-489b-ac01-f02de71def5e"), "Est velit non eum vitae at.", "6aa308b1-78cc-4680-8a0e-bf96c82777b7", new DateTime(2022, 2, 10, 8, 11, 10, 753, DateTimeKind.Local).AddTicks(7115), "Product serie: 3806669513403", new DateTime(2022, 2, 14, 2, 41, 5, 106, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2b529778-5c3d-4592-aa33-289adfa164bc"), "Dignissimos voluptate nam ullam pariatur corrupti ducimus quia sed est.", "c13fc6da-0054-4cd1-9be1-52a7a683fb5d", new DateTime(2019, 6, 4, 12, 14, 1, 767, DateTimeKind.Local).AddTicks(2474), "Product serie: 3272134135614", new DateTime(2021, 3, 24, 16, 52, 45, 157, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2ef91821-8701-4807-a0d2-1262842565a6"), "Temporibus quibusdam qui non maiores temporibus.", "5844672f-d297-4049-bbe1-8f7968d88e98", new DateTime(2018, 8, 11, 19, 27, 2, 405, DateTimeKind.Local).AddTicks(8478), "Product serie: 1105946529925", new DateTime(2022, 3, 7, 18, 53, 38, 636, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("318ecbb0-f79b-4edf-8790-19606eb5c0fe"), "Commodi incidunt ea ea fuga ab.", "9e04fece-cb6b-4150-bcc2-32cc48bc2b24", new DateTime(2022, 3, 19, 6, 6, 9, 864, DateTimeKind.Local).AddTicks(7099), "Product serie: 2543981381723", new DateTime(2022, 7, 1, 19, 39, 2, 517, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35dbfce0-6352-4301-9668-2c6448a9f9df"), "Voluptates aut veniam repellendus.", "5e628b4e-894f-4714-9872-f56174cdc7de", new DateTime(2019, 2, 5, 5, 54, 46, 251, DateTimeKind.Local).AddTicks(3473), "Product serie: 0258132797439", new DateTime(2020, 4, 6, 3, 10, 45, 88, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3652849b-cc02-4214-908a-f6c4044efa40"), "Voluptatum veritatis aut voluptatibus quisquam esse fugit eos.", "4c31380b-4836-4c64-9f54-5175fe0dccfc", new DateTime(2020, 4, 28, 6, 54, 39, 174, DateTimeKind.Local).AddTicks(9469), "Product serie: 4479158259930", new DateTime(2021, 5, 17, 23, 56, 48, 704, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("394df94c-26a9-46c6-a127-c20b6996d6e3"), "Omnis illo ut illum.", "f433f886-1326-4450-b1e8-3f028d28ee76", new DateTime(2017, 10, 2, 7, 39, 57, 73, DateTimeKind.Local).AddTicks(742), "Product serie: 4300263067229", new DateTime(2019, 6, 9, 4, 32, 5, 556, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("39cb8e68-4496-48b2-9e05-b274e37f256e"), "Consequuntur qui ut reprehenderit ipsa at dolore.", "1196ff01-813d-4b02-8aea-42fc3b77fbf9", new DateTime(2019, 7, 17, 10, 20, 27, 222, DateTimeKind.Local).AddTicks(7909), "Product serie: 2503198962054", new DateTime(2019, 11, 26, 13, 56, 33, 268, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b111a0b-dd8a-4970-8751-3ccbc7007e09"), "Tempora quidem qui.", "55d26968-4a55-4a4c-baee-78b2c98e3167", new DateTime(2019, 7, 19, 15, 56, 57, 973, DateTimeKind.Local).AddTicks(3774), "Product serie: 4199888937273", new DateTime(2021, 5, 23, 16, 31, 16, 248, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ba0efec-020e-4e5f-ae4a-db7498a3365a"), "Tempore quia facere.", "eccbcd78-f9d8-4380-9091-3d515c5ecdf6", new DateTime(2019, 2, 20, 2, 17, 46, 27, DateTimeKind.Local).AddTicks(4097), "Product serie: 5053528367259", new DateTime(2020, 2, 14, 19, 43, 14, 460, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3c6d283e-63b5-4344-a7ba-b158afc3da18"), "Ut rem est qui ea accusamus voluptates autem ea reprehenderit.", "cb952bd4-c421-49e7-8f4f-96962ed9816e", new DateTime(2019, 12, 20, 14, 6, 56, 907, DateTimeKind.Local).AddTicks(9965), "Product serie: 2781869025981", new DateTime(2021, 2, 2, 19, 38, 12, 976, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d2ca47a-9b4e-4829-b496-9715604a5f63"), "Sed minima aspernatur dolor aut placeat perspiciatis voluptas rerum.", "cc589ea0-af07-497c-ac2e-2ce0d621766d", new DateTime(2020, 10, 19, 11, 13, 44, 107, DateTimeKind.Local).AddTicks(8196), "Product serie: 4516443667565", new DateTime(2021, 10, 4, 23, 3, 56, 286, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4030001d-35a4-4803-9188-793b83dd0025"), "Excepturi accusamus praesentium ducimus sapiente qui.", "913ff7da-2959-4e04-baf9-13a33410ee31", new DateTime(2018, 11, 29, 9, 11, 58, 278, DateTimeKind.Local).AddTicks(7022), "Product serie: 9962803466661", new DateTime(2019, 7, 8, 2, 50, 46, 19, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("464feebe-b391-49f9-8c23-ba61861cab87"), "Qui aut officia quas quaerat asperiores sed voluptas officia.", "a32be845-4b2c-40cc-91a9-bbf0f88b647c", new DateTime(2021, 10, 26, 9, 18, 40, 702, DateTimeKind.Local).AddTicks(8063), "Product serie: 2291913611874", new DateTime(2022, 1, 21, 13, 59, 50, 561, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("466aaaef-f86d-4e5a-9d8f-9cadec426573"), "Aliquam commodi aut ducimus.", "53433f9d-0584-4732-8439-3aecc7ea01bd", new DateTime(2021, 1, 29, 6, 13, 34, 820, DateTimeKind.Local).AddTicks(1485), "Product serie: 0365581740111", new DateTime(2021, 6, 9, 12, 1, 6, 106, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47dc9543-5155-49a0-acc5-1230301848ca"), "Omnis ut explicabo rerum.", "9398e37d-d3e2-458a-9f0d-5c765ae11770", new DateTime(2022, 4, 1, 5, 59, 8, 261, DateTimeKind.Local).AddTicks(3949), "Product serie: 8057348423529", new DateTime(2022, 4, 4, 17, 3, 41, 126, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4bcb51c9-adf3-4174-be72-8ba849e6142f"), "Et mollitia deleniti.", "32b18839-6441-4f28-8b97-be7afe7f6ff1", new DateTime(2020, 4, 18, 12, 17, 41, 278, DateTimeKind.Local).AddTicks(5140), "Product serie: 6201676486790", new DateTime(2022, 4, 28, 4, 35, 27, 443, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f941ffc-a0ce-439a-a49c-06e54accb65d"), "Architecto ipsa minus animi vitae eos excepturi iusto et minima.", "b1862759-1fc9-4469-b419-0119c094dff5", new DateTime(2022, 1, 6, 6, 15, 6, 461, DateTimeKind.Local).AddTicks(43), "Product serie: 3220562299927", new DateTime(2022, 2, 15, 8, 4, 58, 317, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59ce02d1-01df-4aee-a1b9-3bd03da388c2"), "Facere omnis nihil aspernatur animi qui rerum et enim ut.", "5f6e77ba-a7ff-403b-9da6-cd46caa44c86", new DateTime(2022, 1, 10, 23, 13, 28, 890, DateTimeKind.Local).AddTicks(2227), "Product serie: 3027460356758", new DateTime(2022, 1, 14, 16, 21, 43, 449, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ae1ec56-2de7-485e-87b5-9dfc8231aa59"), "Minima aliquam et consequuntur tenetur id enim nesciunt sunt pariatur.", "b498724f-dd2a-49e1-b7f8-dd84989f9e53", new DateTime(2020, 4, 30, 6, 15, 15, 170, DateTimeKind.Local).AddTicks(6319), "Product serie: 1348879719333", new DateTime(2020, 11, 15, 6, 1, 4, 423, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("604b012d-9176-4a83-b5c0-8f76c1c209b8"), "Recusandae ut sit voluptas sapiente enim perferendis temporibus.", "dc720ec2-efbb-4ec8-84c8-3a023030523c", new DateTime(2019, 9, 27, 1, 7, 13, 476, DateTimeKind.Local).AddTicks(7283), "Product serie: 1938775142542", new DateTime(2021, 6, 11, 3, 18, 56, 106, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("66155a49-1525-4077-b8e3-1e5624d5f3c9"), "Error corporis sunt vitae sint.", "90591703-e422-429b-b395-5ee4ed85fb36", new DateTime(2019, 10, 24, 20, 49, 14, 54, DateTimeKind.Local).AddTicks(7453), "Product serie: 0836506733810", new DateTime(2020, 7, 20, 7, 6, 26, 983, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("667128bc-04e0-4a21-9520-8f396b5b029d"), "Minus corrupti praesentium.", "cea6659c-9708-44d7-94bf-5c44ed47eda5", new DateTime(2019, 7, 2, 21, 46, 48, 686, DateTimeKind.Local).AddTicks(1676), "Product serie: 1221728966686", new DateTime(2020, 5, 20, 22, 34, 35, 506, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("673ce282-665d-4ce7-a990-da5dc2f59592"), "Adipisci modi enim nam quia dolorem qui.", "25356c0e-3046-4cf6-964e-53f5ef5f1581", new DateTime(2021, 3, 7, 18, 57, 14, 433, DateTimeKind.Local).AddTicks(7494), "Product serie: 2217836781845", new DateTime(2021, 10, 24, 17, 15, 56, 144, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c5d9c1d-c071-4d86-bc0e-fbbfd55e7a7f"), "Magni et quas reiciendis fuga.", "e87bffd2-359f-4c6e-bcfe-d7a1fc661b73", new DateTime(2020, 3, 8, 7, 54, 24, 68, DateTimeKind.Local).AddTicks(7893), "Product serie: 5261200829432", new DateTime(2022, 2, 13, 7, 28, 9, 820, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e086bcc-8c23-458c-adf2-e1bc9450e873"), "Et laborum sunt.", "46255192-7855-44eb-867b-66052784682b", new DateTime(2020, 9, 12, 0, 23, 21, 381, DateTimeKind.Local).AddTicks(1354), "Product serie: 8584870297040", new DateTime(2021, 8, 24, 1, 30, 29, 582, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("70a00e30-a5e1-4fe4-a432-588ccd9e3ec2"), "Nisi porro ut quaerat omnis eum laborum veniam eius et.", "f034a2e9-e2b0-44c9-997f-24fd805195d2", new DateTime(2022, 4, 21, 14, 29, 21, 485, DateTimeKind.Local).AddTicks(5078), "Product serie: 6363790261155", new DateTime(2022, 6, 13, 10, 41, 59, 723, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7237e73c-99fb-49b6-8908-b6d73c9099db"), "Ratione possimus aut et.", "38dac9e8-bfa0-4be6-bfe0-e0f3b3031971", new DateTime(2021, 5, 9, 6, 47, 26, 328, DateTimeKind.Local).AddTicks(4073), "Product serie: 6347760438747", new DateTime(2022, 4, 3, 14, 42, 23, 177, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72baa3ef-1b51-48d5-9ea1-9af8eca4ead3"), "Et molestiae est laborum ad et voluptate qui reiciendis.", "036f1dc7-2d54-4420-934b-8f7c398383c7", new DateTime(2021, 4, 13, 18, 55, 58, 888, DateTimeKind.Local).AddTicks(8900), "Product serie: 0225806638336", new DateTime(2021, 10, 2, 4, 59, 12, 471, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73b6cbde-15fc-4e09-b9bb-0ebc9710da09"), "Voluptates omnis omnis dolor ut et est ut.", "199a7d60-e7f4-4963-a222-eadc04dd11a0", new DateTime(2018, 1, 31, 5, 19, 46, 399, DateTimeKind.Local).AddTicks(5172), "Product serie: 8421401903035", new DateTime(2021, 9, 20, 14, 40, 46, 758, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7bac0af4-3d21-4c11-9f1c-62a64b881cbf"), "Ut aut est et.", "eb0ea1b2-15c3-43d9-ad63-792b9288300b", new DateTime(2021, 10, 12, 18, 48, 55, 713, DateTimeKind.Local).AddTicks(5728), "Product serie: 8028196732668", new DateTime(2021, 11, 15, 22, 43, 25, 120, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7dad8282-f764-4579-9535-dd6c4b21af45"), "Rerum quis modi.", "38de9b29-56a5-450d-b2f4-23ded838ce24", new DateTime(2018, 5, 2, 18, 38, 6, 304, DateTimeKind.Local).AddTicks(5700), "Product serie: 5205160942091", new DateTime(2020, 9, 5, 8, 51, 44, 775, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7eaba05e-120d-41dd-a4c4-5ab49bcae466"), "Architecto corrupti et quas enim.", "a066d61d-7dd8-4b4b-83eb-26c80cc1189a", new DateTime(2017, 9, 20, 22, 2, 47, 154, DateTimeKind.Local).AddTicks(4631), "Product serie: 9622065564863", new DateTime(2019, 2, 3, 7, 13, 10, 607, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("810a4ca1-7304-4f33-8c21-d140d65ebb7e"), "Quibusdam sequi minus dolor repellat excepturi ut.", "50b4004b-d55e-4cee-b52a-bd52a02e402b", new DateTime(2021, 4, 9, 9, 59, 48, 255, DateTimeKind.Local).AddTicks(6668), "Product serie: 5094374074793", new DateTime(2021, 4, 15, 12, 24, 5, 247, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("83eb476a-f71c-4259-be92-e0c8ae5d4903"), "Facilis mollitia accusantium ad itaque quas eveniet aperiam.", "05f1af59-52a0-45fb-bcc4-f1b84e27ac37", new DateTime(2020, 3, 20, 14, 28, 41, 764, DateTimeKind.Local).AddTicks(7250), "Product serie: 1605246056393", new DateTime(2022, 6, 7, 23, 58, 31, 380, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89d492ca-3946-46d8-9424-2e3c12abe267"), "Ut architecto aut.", "1f09b1ea-e20c-4709-b3ec-3e68c7541027", new DateTime(2020, 3, 17, 7, 57, 0, 695, DateTimeKind.Local).AddTicks(8378), "Product serie: 3871184317638", new DateTime(2021, 8, 10, 3, 47, 23, 917, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a24a931-3ce0-4829-b02b-fb359e57e0bd"), "Ratione aliquam dolores ipsum distinctio fuga exercitationem architecto dolorum laboriosam.", "663773a7-a028-42bf-8e4f-dcd2bc9e8d23", new DateTime(2021, 7, 1, 4, 44, 56, 342, DateTimeKind.Local).AddTicks(4152), "Product serie: 8786225884046", new DateTime(2021, 11, 15, 1, 45, 56, 273, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a8e89b2-5a87-4379-ac8c-f3cccb5c2d23"), "Temporibus quia reiciendis.", "8ebeb254-d542-4be9-9d87-2863da585dfa", new DateTime(2019, 1, 9, 17, 52, 19, 483, DateTimeKind.Local).AddTicks(8717), "Product serie: 0473086721389", new DateTime(2019, 3, 28, 9, 35, 14, 596, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c007713-fa74-48b5-a010-ff7da5fc9284"), "Sit totam assumenda velit ad error nihil iste.", "dd498acf-9251-4867-8b3d-a022b7e799d1", new DateTime(2020, 10, 23, 13, 25, 29, 894, DateTimeKind.Local).AddTicks(3960), "Product serie: 1997888061270", new DateTime(2021, 12, 16, 3, 7, 23, 468, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c4d8a5d-5d3b-4a27-894b-9f6881a4bfe5"), "Ex dolores saepe in corporis eius sit earum totam unde.", "db3689d9-8fe5-446e-9b8f-f0f6455b23dc", new DateTime(2020, 7, 3, 19, 12, 23, 916, DateTimeKind.Local).AddTicks(1696), "Product serie: 0037707162366", new DateTime(2021, 5, 26, 17, 48, 56, 992, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c63e2cf-3503-44c0-b876-047d7adf0980"), "Facere temporibus sit sit.", "6bc972ae-4972-411e-8a2b-14472f48fca7", new DateTime(2021, 1, 31, 10, 5, 16, 283, DateTimeKind.Local).AddTicks(7890), "Product serie: 1951631467368", new DateTime(2022, 3, 19, 13, 57, 2, 742, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f00b8a3-c2e8-4f98-8035-aa75dbcecae7"), "Occaecati non asperiores nam aut modi et animi nulla.", "941d76e9-61dc-4c2a-92b1-ead70cc1de73", new DateTime(2021, 3, 23, 12, 2, 5, 583, DateTimeKind.Local).AddTicks(2682), "Product serie: 7742273368311", new DateTime(2022, 5, 4, 11, 24, 12, 901, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8fefcb36-8e33-4be3-8085-96c7b78fee2f"), "Veniam quae magnam magnam mollitia non iure molestiae sint assumenda.", "b0750aa3-9de6-4eeb-b8bc-fdaaa4cbba11", new DateTime(2020, 4, 7, 5, 40, 54, 652, DateTimeKind.Local).AddTicks(5014), "Product serie: 4393922556981", new DateTime(2021, 3, 1, 19, 36, 15, 732, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9030b641-4899-4f68-9dae-af4412a7299f"), "Quisquam provident aliquid.", "a5977588-0ec7-48e3-b9a2-8d0ea398032f", new DateTime(2018, 10, 17, 6, 2, 40, 476, DateTimeKind.Local).AddTicks(7672), "Product serie: 6200115936858", new DateTime(2019, 8, 24, 2, 48, 37, 601, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9181e4a0-cb11-448d-8997-7f1dc721e9db"), "Quia et non beatae laudantium magni explicabo.", "2c084d8b-f409-41f8-9b8a-ff0852705f74", new DateTime(2021, 3, 6, 17, 33, 47, 109, DateTimeKind.Local).AddTicks(6110), "Product serie: 8367430642197", new DateTime(2022, 3, 13, 21, 26, 57, 255, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91f75b5a-fe72-497b-9b41-6414be742574"), "Facilis quis id autem quia libero vitae.", "1f2cfafe-bd14-4db2-b3e3-66c8a090b093", new DateTime(2018, 4, 29, 2, 31, 47, 971, DateTimeKind.Local).AddTicks(5522), "Product serie: 3627046884035", new DateTime(2021, 11, 12, 18, 34, 37, 956, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("924ad240-86db-4167-b3e3-8ba7b2f8826c"), "Et illum dolorem enim atque molestiae.", "a99ae472-54e3-47bd-88f8-dbbe53117b59", new DateTime(2020, 8, 7, 4, 29, 15, 582, DateTimeKind.Local).AddTicks(6362), "Product serie: 4029552894345", new DateTime(2020, 9, 18, 11, 21, 57, 819, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("93e8bd88-e9ea-4e94-98d0-d82c56d80f29"), "Qui et sint doloremque omnis harum.", "668e0e4f-5b8e-45cd-ae25-c1d5e895dcf6", new DateTime(2021, 8, 30, 9, 17, 54, 786, DateTimeKind.Local).AddTicks(836), "Product serie: 9601415623269", new DateTime(2021, 11, 28, 19, 1, 50, 975, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d22f955-7577-4377-9159-15700b02e9c5"), "Neque ea eum dolorem sed vel dolor quos.", "25994fbc-18fc-4121-a920-5dc0bcac1e09", new DateTime(2018, 2, 28, 18, 44, 43, 826, DateTimeKind.Local).AddTicks(7666), "Product serie: 0278131446312", new DateTime(2021, 7, 31, 18, 46, 24, 993, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d91adf3-218b-4fe4-8366-d69133aa21b2"), "Placeat molestias cupiditate.", "a81f11ea-048e-42cf-bd86-3d3829e1baf4", new DateTime(2019, 12, 30, 23, 18, 21, 325, DateTimeKind.Local).AddTicks(6624), "Product serie: 4493252896273", new DateTime(2022, 5, 16, 3, 12, 16, 246, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7a9295e-d4c1-47a5-8939-ba9f948ce923"), "Nostrum qui praesentium.", "8fad42d0-ac23-4ed8-a151-7bb721404234", new DateTime(2019, 12, 29, 20, 14, 19, 16, DateTimeKind.Local).AddTicks(974), "Product serie: 0720934313006", new DateTime(2022, 6, 13, 11, 56, 40, 694, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7da727c-4779-4436-9ef3-ac118d89ad77"), "Eius aut rerum dolorum sequi repellat nulla.", "addfb60c-de92-4da0-b8ec-ae5439934444", new DateTime(2019, 8, 30, 12, 13, 25, 645, DateTimeKind.Local).AddTicks(9162), "Product serie: 7298884853017", new DateTime(2020, 3, 25, 22, 58, 27, 666, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("abc7568a-d488-403f-8e5c-1b3ebceee2b1"), "Laborum aut cum nihil.", "833f7fcc-77ac-44bc-a96c-fa38e353bb78", new DateTime(2019, 7, 11, 3, 11, 56, 563, DateTimeKind.Local).AddTicks(7073), "Product serie: 9178624546516", new DateTime(2021, 10, 26, 19, 29, 52, 579, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad107456-4aee-4fb8-a7a5-4fdd19d6d14d"), "Qui consequuntur numquam quaerat quae rem velit quo.", "3e6115f8-bb08-4f98-8b48-96d2191db1f3", new DateTime(2022, 5, 17, 11, 50, 55, 956, DateTimeKind.Local).AddTicks(5530), "Product serie: 4440012818167", new DateTime(2022, 5, 18, 14, 13, 35, 276, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b0c96ab5-8a9a-4792-80cd-f8b725be8402"), "Rerum magni ut deserunt aperiam aut et.", "4f935487-5c34-4dea-8b83-76116ba22611", new DateTime(2021, 2, 3, 16, 13, 12, 879, DateTimeKind.Local).AddTicks(8880), "Product serie: 7400592032251", new DateTime(2022, 1, 1, 14, 15, 43, 715, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1194594-2e24-4762-83c1-98ac85b72d84"), "Corrupti necessitatibus tempora.", "4a06d2ed-afe0-46c7-b6bb-091a0b3f711b", new DateTime(2021, 2, 25, 2, 11, 21, 375, DateTimeKind.Local).AddTicks(27), "Product serie: 4337621168137", new DateTime(2021, 6, 21, 8, 8, 3, 84, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b73d85a2-4e0c-4cc1-89dd-59f3aea1910d"), "Alias amet quidem similique molestiae.", "867a4d23-7d94-4865-8c34-8af90564e709", new DateTime(2019, 11, 28, 3, 15, 37, 212, DateTimeKind.Local).AddTicks(3713), "Product serie: 8289057804997", new DateTime(2021, 9, 8, 10, 57, 28, 494, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9c8ade4-abdf-4c3d-a925-710af528d6c8"), "Quod beatae ipsum saepe facilis et dolore.", "c242b099-3240-48f9-b44f-5f8d8deee079", new DateTime(2019, 9, 2, 17, 5, 29, 173, DateTimeKind.Local).AddTicks(7113), "Product serie: 3461883998612", new DateTime(2021, 6, 19, 17, 44, 31, 69, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bcf8c64c-597a-45a6-b861-8fba4928fe56"), "Incidunt asperiores et.", "8bff9f78-5ab6-4818-82ff-6ab6762b61b2", new DateTime(2018, 6, 28, 23, 49, 7, 751, DateTimeKind.Local).AddTicks(4724), "Product serie: 0451597824775", new DateTime(2019, 10, 18, 2, 31, 26, 983, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("beb29145-e506-47bd-904c-9b6992116877"), "Et impedit odio pariatur assumenda doloribus error molestiae possimus maxime.", "3784d089-9eae-4649-8c7a-2d145a393fb6", new DateTime(2020, 6, 26, 0, 16, 17, 278, DateTimeKind.Local).AddTicks(5110), "Product serie: 8293785304612", new DateTime(2021, 10, 23, 21, 38, 57, 412, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0353918-804c-4ca6-b374-4e4c9eb85e5e"), "Quis mollitia provident nesciunt beatae.", "614138d2-8f90-4f9b-82b5-eb55aeff73df", new DateTime(2018, 5, 23, 0, 22, 59, 215, DateTimeKind.Local).AddTicks(3682), "Product serie: 7767010800114", new DateTime(2022, 1, 9, 2, 53, 20, 251, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c3fb656d-4440-4f42-b9fe-f3e1d3f36c56"), "Labore dolorem sed ipsa sunt incidunt cumque quia placeat vel.", "77b0bc47-ac5c-4807-8b63-9d82d7a69dc6", new DateTime(2019, 8, 7, 2, 59, 25, 492, DateTimeKind.Local).AddTicks(9262), "Product serie: 8295513430709", new DateTime(2022, 1, 28, 20, 8, 13, 239, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c4939d9e-2a0a-4d75-9a3e-e1cd053a7f59"), "Esse eos provident quidem aliquam nostrum molestiae.", "069f9524-6a43-46f0-a477-5399b41931f3", new DateTime(2021, 9, 22, 12, 30, 49, 312, DateTimeKind.Local).AddTicks(9821), "Product serie: 7903444027318", new DateTime(2021, 9, 29, 19, 17, 8, 650, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c810ad5b-9f83-4785-b978-7ff29616ab5b"), "Distinctio velit sapiente omnis iure praesentium autem.", "e3260ac3-51c1-4212-bbb6-4ce93ff209e0", new DateTime(2021, 12, 14, 1, 7, 20, 787, DateTimeKind.Local).AddTicks(7354), "Product serie: 2012305284106", new DateTime(2022, 3, 27, 22, 53, 2, 756, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cb578f65-edaa-415b-a938-a7755e631cf6"), "Est nulla occaecati consequatur omnis exercitationem ratione.", "4a7758d7-e5c5-4b9b-9804-52235b3e986b", new DateTime(2018, 2, 6, 12, 0, 51, 358, DateTimeKind.Local).AddTicks(3778), "Product serie: 1416002704850", new DateTime(2019, 4, 13, 17, 6, 43, 574, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cdfa4794-9edf-49ec-9704-d30ef1a46f44"), "Odio cumque delectus eum neque.", "ae7577b2-98f9-42ea-8454-4a9b6bec28d8", new DateTime(2019, 10, 20, 9, 5, 15, 352, DateTimeKind.Local).AddTicks(4600), "Product serie: 6619110654689", new DateTime(2021, 9, 27, 17, 41, 43, 616, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d2dbf03e-0a7c-4eb2-ba24-8525d9425a4d"), "Ipsam nam est ea quos error est quibusdam consequatur.", "c0e9bda6-5baa-4579-bcca-62abf4f9f28d", new DateTime(2020, 2, 28, 2, 50, 27, 559, DateTimeKind.Local).AddTicks(9212), "Product serie: 8360630886644", new DateTime(2020, 9, 14, 1, 28, 29, 779, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d827a590-0f22-4e7e-8269-f3743f0ac5b8"), "Reiciendis iste eum vel dolores doloremque.", "8c732c06-5236-4e8c-a0d9-f19d7637744e", new DateTime(2019, 10, 10, 20, 19, 53, 836, DateTimeKind.Local).AddTicks(8805), "Product serie: 9119410900143", new DateTime(2020, 7, 17, 18, 2, 48, 815, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ddf7dc04-4899-4781-8a0c-3ae9c9b16796"), "Excepturi illum et dolor ipsa non autem optio aliquid architecto.", "a74013d6-20da-49a4-86cd-034beb337cb3", new DateTime(2019, 10, 28, 8, 34, 50, 469, DateTimeKind.Local).AddTicks(4833), "Product serie: 1826314132676", new DateTime(2020, 2, 17, 13, 8, 38, 309, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df9d67b8-e6db-4c5e-866f-1fe2d902dade"), "Rerum voluptatem praesentium est voluptas nam magnam.", "d4a241e2-3de9-425c-8256-660b080f0bcb", new DateTime(2019, 4, 22, 21, 40, 50, 216, DateTimeKind.Local).AddTicks(3733), "Product serie: 8483786886877", new DateTime(2020, 10, 13, 22, 57, 17, 792, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e07b3f3d-641d-4d42-b0e8-841eb4d488ed"), "Non quaerat tenetur accusamus vitae autem eos molestiae.", "c702932d-3880-4904-adc8-799668ad6e54", new DateTime(2017, 10, 22, 23, 1, 54, 487, DateTimeKind.Local).AddTicks(4514), "Product serie: 3258685956700", new DateTime(2021, 2, 6, 4, 51, 1, 501, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3b00fe8-f5c8-4da9-a10d-1112496308e9"), "Vel mollitia exercitationem repudiandae dolorem perspiciatis sint velit sed.", "31d6018e-fff5-4621-8777-5cc173b862fb", new DateTime(2019, 8, 22, 21, 39, 21, 489, DateTimeKind.Local).AddTicks(9534), "Product serie: 9859440226614", new DateTime(2020, 3, 4, 4, 13, 54, 150, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5b79ffd-f791-41b2-976a-7017d533a171"), "Sunt dolor ratione quia minima nobis molestiae sint.", "59da5c30-1398-4127-840f-7b49a7cac9a1", new DateTime(2021, 3, 12, 5, 31, 2, 396, DateTimeKind.Local).AddTicks(7702), "Product serie: 1880277787977", new DateTime(2021, 6, 24, 13, 41, 0, 324, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed1a7e6a-c6b0-48bc-87b3-f0f49d84e55f"), "Ex at labore assumenda tempore omnis labore aut consequatur error.", "2f6cb0c5-694f-43a5-a9de-ce0d2d580f71", new DateTime(2021, 1, 29, 12, 32, 9, 299, DateTimeKind.Local).AddTicks(2902), "Product serie: 7147080006942", new DateTime(2022, 2, 7, 4, 14, 20, 626, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f037b6f1-5c68-4bd5-9a94-775f20dad045"), "Modi mollitia saepe nihil.", "6941a732-d77a-42d4-a478-beaa8213e049", new DateTime(2021, 6, 11, 2, 10, 21, 960, DateTimeKind.Local).AddTicks(5052), "Product serie: 1913171082043", new DateTime(2022, 4, 22, 18, 3, 44, 759, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.InsertData(
                table: "ProductSeries",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fdb1d314-796a-405e-bec7-8ef887ef0607"), "Vitae voluptatum ab non quia nobis magnam repellat fuga.", "ef331539-6c55-438b-a35a-47c8a86639ca", new DateTime(2021, 6, 28, 13, 39, 4, 58, DateTimeKind.Local).AddTicks(1532), "Product serie: 0248990156226", new DateTime(2022, 3, 30, 20, 30, 48, 741, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01427a68-a1e9-4ffb-a0a9-fe8df12db345"), "Placeat expedita enim et rerum explicabo sit nesciunt corporis alias.", "2a91b296-e67a-4ddf-9c10-d6a91f565617", new DateTime(2017, 10, 1, 16, 2, 20, 451, DateTimeKind.Local).AddTicks(2207), "Product type: soluta", new DateTime(2021, 5, 11, 8, 35, 54, 745, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04b8b616-b960-4e7a-b74d-387861ebaf77"), "Blanditiis nostrum iusto.", "ba8f39f2-b9ae-4b2e-8dff-a0e7d220170e", new DateTime(2017, 11, 28, 15, 1, 46, 951, DateTimeKind.Local).AddTicks(2805), "Product type: molestiae", new DateTime(2017, 12, 17, 5, 34, 33, 420, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04bc4e0b-ed4f-4243-a561-083d84c66fbc"), "Cupiditate aperiam a natus non non officiis natus.", "e8d83e67-73e7-461f-b297-87e8331bb783", new DateTime(2017, 8, 10, 15, 17, 59, 266, DateTimeKind.Local).AddTicks(6019), "Product type: velit", new DateTime(2018, 6, 23, 12, 27, 46, 456, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05447d8e-f306-403b-b49a-f27f7a7854fe"), "Fugiat magnam et debitis praesentium.", "43ebeb35-c795-4334-b5fb-302fffbc6072", new DateTime(2020, 4, 18, 19, 52, 26, 785, DateTimeKind.Local).AddTicks(1628), "Product type: aliquid", new DateTime(2020, 7, 15, 8, 33, 30, 33, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("055c5520-65b2-4566-a5c6-d7b54d13a371"), "Neque illum ut consequatur dolorem.", "4b8442d2-8378-48bc-a170-3681a190a8a2", new DateTime(2021, 6, 8, 8, 4, 0, 565, DateTimeKind.Local).AddTicks(1415), "Product type: in", new DateTime(2022, 3, 1, 4, 34, 19, 830, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0dfca2e9-0344-43b9-86fe-019ba87951ea"), "Velit asperiores aspernatur.", "2d5f246a-8f39-45ae-9a7e-5ccc2c08e638", new DateTime(2021, 3, 26, 9, 5, 12, 924, DateTimeKind.Local).AddTicks(1746), "Product type: dicta", new DateTime(2021, 10, 17, 9, 33, 45, 89, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ed66703-4f42-4f4f-96a5-a435bd8fe674"), "Sunt consequatur explicabo enim commodi autem dolores.", "d170a65b-19ec-4972-918c-81c65bf9684b", new DateTime(2020, 12, 26, 13, 33, 48, 557, DateTimeKind.Local).AddTicks(1562), "Product type: accusantium", new DateTime(2021, 8, 30, 2, 6, 11, 956, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f77657c-2d7c-4f73-9be6-fb2771eb8792"), "Id omnis cumque id.", "2a177dfa-4a9c-4454-9348-43c36cea9a25", new DateTime(2021, 8, 30, 4, 50, 58, 687, DateTimeKind.Local).AddTicks(2574), "Product type: voluptas", new DateTime(2022, 5, 22, 22, 33, 14, 502, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("158e8796-6aa9-4e6a-b117-dd365edb5e72"), "Dolorum omnis debitis officia totam.", "c122fad2-59ca-40f4-ac8f-e46613c53790", new DateTime(2019, 9, 1, 12, 17, 0, 707, DateTimeKind.Local).AddTicks(9616), "Product type: ea", new DateTime(2021, 6, 9, 4, 1, 3, 512, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15fdebca-8b0c-46fb-b2fb-d2edf66fe241"), "Quas voluptatem ea aut autem nihil beatae vel quas nihil.", "ef6f3567-54d6-45f8-87eb-caddb1b5d328", new DateTime(2020, 9, 12, 17, 47, 34, 302, DateTimeKind.Local).AddTicks(9000), "Product type: voluptatibus", new DateTime(2021, 10, 13, 14, 10, 4, 671, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17bd8c6b-6b1d-4622-9a68-e4ef2f103c71"), "Explicabo doloribus et pariatur dolorem.", "edd36ade-c906-4b9c-acd2-55e791c9c629", new DateTime(2018, 5, 30, 7, 43, 44, 234, DateTimeKind.Local).AddTicks(5541), "Product type: quibusdam", new DateTime(2020, 9, 26, 14, 44, 8, 929, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("198cdaf1-e401-4e43-87d2-b270c9ffbd2f"), "Asperiores ab laborum in et cupiditate sunt qui voluptates et.", "fc27f2e2-af1a-4b54-8b11-25c9a814bc67", new DateTime(2017, 9, 17, 4, 18, 22, 83, DateTimeKind.Local).AddTicks(3257), "Product type: qui", new DateTime(2020, 1, 25, 9, 17, 33, 275, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b3248c8-b3d3-4518-843d-02c03499912f"), "Voluptates magnam porro porro.", "2a5be73b-5814-4ba2-9623-3c7a8d918958", new DateTime(2018, 7, 9, 9, 54, 57, 650, DateTimeKind.Local).AddTicks(2932), "Product type: voluptatibus", new DateTime(2021, 3, 10, 2, 11, 11, 337, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e395fde-74bf-413d-8ea0-4d5f9f642571"), "Illum vel quod omnis ea reiciendis est assumenda debitis earum.", "6f7624bc-3af3-4534-866c-17c6b77f47f3", new DateTime(2017, 10, 25, 20, 33, 24, 125, DateTimeKind.Local).AddTicks(328), "Product type: temporibus", new DateTime(2018, 7, 15, 8, 26, 7, 173, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e7d63e8-3307-4a12-8ef4-aef9508724e2"), "Reiciendis quis sed deleniti voluptas optio numquam dolorum eveniet et.", "9667f1a9-a3ec-4cd9-9755-29ca881f6e3f", new DateTime(2019, 1, 17, 11, 25, 10, 294, DateTimeKind.Local).AddTicks(8756), "Product type: quia", new DateTime(2020, 6, 2, 3, 42, 33, 349, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1f4c6489-96db-4682-ba88-20cb21580ae9"), "Cupiditate voluptas cumque sapiente nesciunt harum.", "6bc16cd6-b338-47e1-afea-e4a0841e5a2c", new DateTime(2020, 9, 1, 22, 43, 35, 833, DateTimeKind.Local).AddTicks(7794), "Product type: quas", new DateTime(2021, 5, 24, 0, 17, 25, 388, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("204b2f4f-ce9e-40a4-98c2-7f0be6e0e62e"), "Ea sint porro minima.", "d2b66356-a358-46a1-a277-6ebf279962a9", new DateTime(2018, 5, 10, 12, 33, 34, 418, DateTimeKind.Local).AddTicks(8425), "Product type: aut", new DateTime(2019, 12, 7, 5, 52, 25, 919, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("20c68d8a-4b0d-4284-830a-c76c2a507541"), "Et repellendus recusandae doloremque aut dolores eaque.", "3f539c2c-3b82-4744-be48-cec0dbead590", new DateTime(2019, 4, 19, 1, 22, 26, 411, DateTimeKind.Local).AddTicks(1306), "Product type: ab", new DateTime(2021, 3, 10, 18, 35, 54, 513, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2320d459-fc06-4788-9db9-7d6c5d837491"), "Exercitationem voluptatum quod expedita quae sunt.", "a35db4b8-9976-4435-945b-b798c9cc12a7", new DateTime(2021, 12, 11, 3, 0, 39, 153, DateTimeKind.Local).AddTicks(1847), "Product type: repellat", new DateTime(2022, 5, 30, 2, 0, 34, 356, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23f73f94-600e-4ea6-a0a1-5f80b25ff240"), "Cumque facilis molestiae tempora eum perferendis perspiciatis.", "490f8e4a-a316-404b-80fc-bc41f4493d2b", new DateTime(2018, 10, 8, 14, 5, 35, 755, DateTimeKind.Local).AddTicks(2577), "Product type: nemo", new DateTime(2020, 5, 9, 10, 32, 0, 653, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("262f7978-4b3f-4495-b23e-42cf84d927c9"), "Vel reprehenderit et quis non velit deleniti saepe omnis.", "c96d1c72-2d8d-487b-a007-61c9df89faf0", new DateTime(2017, 8, 13, 12, 20, 13, 723, DateTimeKind.Local).AddTicks(3774), "Product type: neque", new DateTime(2021, 5, 1, 0, 13, 49, 751, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26696e84-71da-4ef0-a197-2d9c40c2623c"), "Quibusdam alias veniam eaque rem odit eveniet tempore.", "b5315c84-fdc8-4c88-a506-6166ffc5af66", new DateTime(2020, 5, 25, 8, 12, 45, 766, DateTimeKind.Local).AddTicks(7730), "Product type: saepe", new DateTime(2021, 3, 21, 9, 39, 53, 193, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2c1d6461-c418-4abd-b622-18e90771a20f"), "Mollitia numquam est eveniet non sit eos odio repellendus est.", "3d970ddc-2b89-4d58-910e-0b703206f277", new DateTime(2022, 2, 17, 11, 19, 52, 933, DateTimeKind.Local).AddTicks(6474), "Product type: expedita", new DateTime(2022, 7, 4, 5, 29, 12, 63, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2cbb1eb4-cf43-44df-b34a-3551fca94d5c"), "Inventore quia sit et autem amet quia.", "69a7a594-34b7-4f62-a5ba-7e968f29eecf", new DateTime(2022, 1, 12, 1, 23, 31, 282, DateTimeKind.Local).AddTicks(3779), "Product type: et", new DateTime(2022, 5, 12, 11, 13, 4, 658, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e127f67-704b-4f2c-8fd9-cf0ce1cfeae1"), "Expedita voluptatem eum sunt voluptatem et quis.", "09ea831e-f3f8-4c50-be20-f049b1c78317", new DateTime(2020, 5, 6, 15, 31, 29, 475, DateTimeKind.Local).AddTicks(2797), "Product type: aspernatur", new DateTime(2021, 12, 23, 14, 33, 2, 670, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e165196-6780-43e7-abf2-08c0818fa30b"), "Odit ex molestias autem sit.", "c393d050-917e-447a-b20f-e5ad766228c7", new DateTime(2019, 5, 10, 6, 4, 45, 716, DateTimeKind.Local).AddTicks(2262), "Product type: ullam", new DateTime(2022, 2, 5, 3, 29, 43, 326, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f93e7f4-78b1-4776-ac46-784eedd3fc4d"), "Doloremque unde autem vero qui doloremque accusamus eum.", "7ccfe116-3b13-4e1d-a7bd-93da8d5ef63d", new DateTime(2019, 1, 13, 2, 39, 0, 165, DateTimeKind.Local).AddTicks(9900), "Product type: id", new DateTime(2021, 12, 28, 8, 52, 5, 140, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2fe70daf-9657-4b10-b281-dfa01eee9f14"), "Expedita eos eos laboriosam debitis.", "ebcd74b0-f3fb-47a5-a5fc-a8c5fbc71980", new DateTime(2019, 8, 31, 20, 49, 37, 727, DateTimeKind.Local).AddTicks(6298), "Product type: quia", new DateTime(2019, 11, 13, 20, 4, 54, 59, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31675856-2fdb-4ff6-9cc2-170cc95c43ff"), "Aspernatur quia repellendus laborum occaecati amet id.", "1d11034f-b70e-4a2c-96f5-3f7cf6e79e05", new DateTime(2019, 1, 19, 6, 59, 3, 441, DateTimeKind.Local).AddTicks(9823), "Product type: et", new DateTime(2020, 8, 6, 22, 28, 43, 722, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32568899-76c7-4268-8d5a-0a06f5825522"), "Ab asperiores atque eum eum qui tempora nam quidem.", "c2adf454-572e-46bf-93ef-9ed814aee760", new DateTime(2019, 6, 11, 3, 18, 0, 847, DateTimeKind.Local).AddTicks(8058), "Product type: cupiditate", new DateTime(2021, 12, 30, 15, 29, 59, 802, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("36fe948d-c89f-4046-962d-d7c9ae84464f"), "Enim doloremque et repellendus cumque assumenda animi provident sit omnis.", "681e18ef-c4b4-4008-a833-2a4e9bfba798", new DateTime(2018, 12, 4, 23, 7, 54, 991, DateTimeKind.Local).AddTicks(8090), "Product type: ad", new DateTime(2019, 5, 25, 8, 3, 17, 539, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3aa6cbb5-0d76-478c-b3fd-9bf97213d9ae"), "Consequatur mollitia vero quia molestiae rem.", "10fb0fb1-7585-4632-9834-259e2b0823da", new DateTime(2022, 4, 15, 11, 37, 26, 912, DateTimeKind.Local).AddTicks(9018), "Product type: suscipit", new DateTime(2022, 6, 20, 1, 40, 45, 338, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e76fb35-fd6e-4fde-a0eb-89c06f629e7c"), "Repellendus saepe dolor nihil ex veniam.", "ee67a03d-f3ce-4cdf-ba7c-634bdaec1a8e", new DateTime(2019, 4, 18, 16, 57, 47, 466, DateTimeKind.Local).AddTicks(7679), "Product type: eligendi", new DateTime(2019, 12, 30, 20, 18, 39, 443, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3fb6ba75-f9f2-4983-b09f-dec422cf8b3b"), "Quos ad quia saepe.", "21187605-8020-42ba-af15-20b4cc06995a", new DateTime(2019, 7, 5, 1, 49, 34, 145, DateTimeKind.Local).AddTicks(4491), "Product type: at", new DateTime(2019, 12, 25, 18, 0, 59, 573, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3fc10cc1-fbf9-447a-ab8b-62ac1e7bef64"), "Sunt et minima nostrum laboriosam nisi voluptatem id possimus.", "79a2daed-a013-4a50-a1d8-37cf6e4835ea", new DateTime(2018, 1, 6, 14, 56, 53, 42, DateTimeKind.Local).AddTicks(9897), "Product type: quia", new DateTime(2018, 5, 16, 23, 11, 51, 792, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ff0d09c-32d8-4103-80ac-527b4eb0a567"), "Enim sint aliquid quos.", "d4f35bff-777d-4fc3-bccd-2b9b7ffa55b9", new DateTime(2018, 3, 15, 13, 2, 6, 773, DateTimeKind.Local).AddTicks(3873), "Product type: impedit", new DateTime(2018, 5, 24, 0, 0, 39, 353, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("422b3950-864e-4c4b-819f-92662bb114a3"), "Magni molestiae sequi corporis magni in.", "625eac8b-c02c-41f3-ac06-8317e4c47640", new DateTime(2019, 6, 3, 21, 30, 45, 534, DateTimeKind.Local).AddTicks(7402), "Product type: corporis", new DateTime(2022, 1, 19, 18, 37, 52, 149, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("44499418-a222-476e-b1f4-4768d9f33349"), "Sint voluptas et pariatur ducimus adipisci.", "d920a855-1e2a-499c-80a0-3e4b2d740ac1", new DateTime(2020, 1, 16, 4, 43, 30, 745, DateTimeKind.Local).AddTicks(290), "Product type: sunt", new DateTime(2022, 2, 27, 20, 44, 13, 307, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("48837afd-d8ec-47a0-8071-6a298ae4bf5e"), "Quae blanditiis commodi error quidem officiis vel.", "a430d578-d875-41dd-9e8e-dcc1a5868513", new DateTime(2019, 9, 1, 22, 24, 58, 575, DateTimeKind.Local).AddTicks(1476), "Product type: ea", new DateTime(2019, 12, 6, 23, 4, 9, 735, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49052ae2-00dc-46b5-b6f7-b1a8b2bb7622"), "Fugiat minima consectetur sint sed temporibus.", "fc365c57-12dd-4322-bdc1-f64ce4d942bd", new DateTime(2018, 5, 14, 4, 57, 54, 353, DateTimeKind.Local).AddTicks(8264), "Product type: labore", new DateTime(2022, 2, 13, 17, 51, 1, 968, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4abb49d3-f285-44cd-b700-8b7fd952c1c8"), "Praesentium aliquam ut qui voluptate autem saepe dolorum.", "d3ffeb1b-4004-4efa-b1ea-ee183d544e0c", new DateTime(2019, 5, 2, 15, 6, 41, 264, DateTimeKind.Local).AddTicks(9280), "Product type: saepe", new DateTime(2020, 8, 1, 14, 16, 2, 741, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4ebd021e-b5c5-4b99-92c8-af902c723e04"), "Qui quae cum quia labore exercitationem aliquam voluptatem architecto.", "272df2e6-4d38-42bc-8459-f5767a75ba95", new DateTime(2021, 2, 3, 6, 16, 3, 229, DateTimeKind.Local).AddTicks(7053), "Product type: quia", new DateTime(2021, 5, 19, 3, 6, 57, 68, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5abd186d-d574-402d-be3c-b7f1be70ebd9"), "Eaque impedit qui est qui accusantium.", "f7a43740-6309-4a4f-8f2c-dab072a37f80", new DateTime(2022, 5, 27, 19, 34, 34, 453, DateTimeKind.Local).AddTicks(4114), "Product type: eum", new DateTime(2022, 7, 6, 3, 20, 48, 946, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ae9e980-07c5-4908-b531-22b815ea341c"), "Quidem qui sapiente laudantium repellendus et.", "923390be-4bf1-4832-965d-cd775e669e10", new DateTime(2017, 10, 18, 19, 6, 38, 883, DateTimeKind.Local).AddTicks(9478), "Product type: porro", new DateTime(2020, 9, 1, 19, 58, 28, 579, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b51ed3e-bdd6-4170-9392-20b0a60fb19b"), "Omnis veniam et assumenda non ex nobis minima excepturi.", "f48d33d0-37d1-48ce-a828-b90a2b135510", new DateTime(2017, 8, 19, 20, 48, 17, 682, DateTimeKind.Local).AddTicks(7898), "Product type: iusto", new DateTime(2018, 10, 29, 21, 46, 34, 707, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d171b6a-51a6-49a7-9c60-8d45805a62ea"), "Cumque in libero dolores architecto quae adipisci.", "cd1da706-ec5f-4267-9453-e4b65973c913", new DateTime(2019, 2, 3, 2, 39, 8, 152, DateTimeKind.Local).AddTicks(5021), "Product type: debitis", new DateTime(2021, 2, 19, 15, 44, 27, 875, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6827b871-5b13-46ee-ae5a-bdf3b923bcf3"), "Velit dolorem et et porro itaque sit.", "ba0332ba-a562-4bb5-86f1-4d87dc19b2d6", new DateTime(2019, 6, 23, 8, 48, 16, 668, DateTimeKind.Local).AddTicks(6170), "Product type: pariatur", new DateTime(2019, 12, 30, 2, 30, 38, 845, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("68ba45af-c251-405f-9d77-21eb65dbc6b3"), "Sed reiciendis ut.", "46a57d75-ff2d-42c4-b633-4350c7885031", new DateTime(2018, 2, 16, 19, 15, 39, 415, DateTimeKind.Local).AddTicks(2863), "Product type: ipsum", new DateTime(2021, 7, 22, 5, 21, 20, 603, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e80921d-b101-4723-b254-5cc5527f6217"), "Tenetur qui ut expedita incidunt voluptatem architecto vel iure.", "051ebae6-e1e3-4a2e-b19d-8b18d83a9cfc", new DateTime(2017, 8, 8, 2, 19, 22, 353, DateTimeKind.Local).AddTicks(2279), "Product type: maxime", new DateTime(2019, 5, 14, 7, 26, 46, 583, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7023bef4-1c82-4855-a91d-de019dd4d691"), "Sit reprehenderit tenetur quia.", "bc144cbe-fa31-4e32-912c-f7d4db2188aa", new DateTime(2017, 9, 1, 14, 34, 12, 289, DateTimeKind.Local).AddTicks(4558), "Product type: laudantium", new DateTime(2022, 6, 22, 21, 49, 47, 720, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73f353e2-6153-4171-b595-f3db5d09cde8"), "Pariatur cum esse omnis.", "d30c2e9c-dc43-4e7e-8f4f-86fbfec2dc1a", new DateTime(2019, 10, 7, 20, 15, 35, 693, DateTimeKind.Local).AddTicks(199), "Product type: ea", new DateTime(2019, 10, 17, 19, 0, 38, 714, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75687dfe-dfa9-4ad8-bd6a-af05269f6e1f"), "Beatae impedit assumenda ab quis consequatur quo amet quia.", "2e021732-0339-4b40-838f-345a813f471b", new DateTime(2020, 10, 25, 14, 34, 5, 511, DateTimeKind.Local).AddTicks(3639), "Product type: alias", new DateTime(2020, 12, 17, 6, 51, 35, 502, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("777758f1-6fa2-4228-abb7-750fd1ff1986"), "Delectus cumque et magnam.", "d036aa65-1563-4f6c-bd22-bd44e8f42434", new DateTime(2018, 2, 17, 7, 40, 48, 55, DateTimeKind.Local).AddTicks(8434), "Product type: fugiat", new DateTime(2021, 1, 23, 5, 7, 36, 781, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77eaa0ed-52f7-4a53-a3bc-c8f5aaf5c4e2"), "Alias voluptatem aut non.", "907a2219-de09-49d6-897d-215db555a9bb", new DateTime(2020, 12, 21, 14, 18, 44, 446, DateTimeKind.Local).AddTicks(7617), "Product type: ab", new DateTime(2021, 4, 20, 22, 12, 56, 909, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7872677f-edb2-424e-a9e0-3100f471ce1c"), "Id est rerum sit quis ut ut fuga.", "7d47a1dc-2d76-43ed-88be-2bd5ca0a942a", new DateTime(2017, 12, 6, 4, 39, 10, 606, DateTimeKind.Local).AddTicks(1796), "Product type: quia", new DateTime(2021, 4, 13, 8, 31, 58, 12, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7b758c60-dd2d-4e74-95f9-eb2c1045d040"), "Eos ratione omnis dolorum inventore quaerat.", "905a6c60-231c-4820-ae26-2510f4fc0ba4", new DateTime(2018, 10, 27, 6, 33, 50, 965, DateTimeKind.Local).AddTicks(1777), "Product type: aut", new DateTime(2020, 2, 19, 18, 10, 28, 875, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c133c8f-699b-4be5-9423-8ffae59688e0"), "Consectetur ipsa aut laborum impedit vitae quia.", "a79c0de4-173a-48b5-afa3-95b4eeb1f783", new DateTime(2017, 9, 22, 20, 41, 55, 316, DateTimeKind.Local).AddTicks(1094), "Product type: excepturi", new DateTime(2020, 11, 1, 10, 4, 5, 533, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7ca57836-bc76-45a7-8516-0d436d9cb8da"), "Rem omnis praesentium et.", "2699c137-3d2a-4e1a-82e1-fcf91a6c97af", new DateTime(2018, 7, 2, 0, 8, 19, 427, DateTimeKind.Local).AddTicks(4520), "Product type: est", new DateTime(2021, 7, 19, 2, 20, 0, 842, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7da37d08-c407-4b11-9415-d5bff3328d69"), "Laboriosam quos molestiae vel eius tempore et quia debitis.", "a9073414-ff5d-4344-b716-11ca6aaa6c3e", new DateTime(2022, 7, 2, 7, 11, 55, 534, DateTimeKind.Local).AddTicks(5644), "Product type: ipsam", new DateTime(2022, 7, 2, 16, 19, 31, 734, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("848b1dcb-4036-4ae2-bd93-2bc08083fb10"), "Quaerat laborum odio voluptate.", "a584534e-825e-4794-8cbb-d6e7f5948a37", new DateTime(2019, 8, 16, 7, 37, 7, 771, DateTimeKind.Local).AddTicks(6427), "Product type: quis", new DateTime(2020, 2, 15, 15, 10, 9, 969, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("85a4d2e0-92fb-41ba-9467-e33911f90f40"), "Aut sint libero aliquid incidunt occaecati.", "2443f8b3-d562-48f5-b9e9-ca4f694a8a12", new DateTime(2017, 10, 30, 11, 21, 6, 601, DateTimeKind.Local).AddTicks(7197), "Product type: sit", new DateTime(2022, 5, 17, 16, 22, 23, 221, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("87aae796-548d-48fc-bcfd-ce4cb6c2fec2"), "Non consequatur minus expedita deserunt fuga.", "4157cae9-a36b-4268-9b36-68285b37f6db", new DateTime(2021, 9, 3, 21, 8, 7, 74, DateTimeKind.Local).AddTicks(8810), "Product type: autem", new DateTime(2022, 2, 18, 13, 21, 33, 481, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8a0f6b12-9a9e-41f8-837c-2f8f28b714c9"), "Ut tempore iusto.", "2f96f900-b53c-444e-94ed-04f4949a6671", new DateTime(2019, 7, 5, 20, 36, 12, 435, DateTimeKind.Local).AddTicks(8924), "Product type: qui", new DateTime(2021, 2, 18, 1, 43, 50, 194, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90b79182-ab1c-4492-854a-05a406cc82e8"), "Sint ipsum animi.", "9e00db1a-695e-4ca5-bf2b-13a3983e2ba5", new DateTime(2022, 3, 13, 9, 51, 15, 981, DateTimeKind.Local).AddTicks(1339), "Product type: sequi", new DateTime(2022, 5, 4, 7, 42, 16, 248, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90cbed02-cb67-45ad-b298-c319f25024f7"), "Asperiores harum quis aut eaque aut exercitationem ut perspiciatis.", "76414738-fe87-412d-a2fd-1aeb5359e741", new DateTime(2021, 9, 24, 22, 18, 41, 548, DateTimeKind.Local).AddTicks(4590), "Product type: officia", new DateTime(2022, 6, 12, 23, 28, 43, 179, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91009563-744e-4215-b3f2-69874f4f0e7d"), "Sunt dolores laboriosam esse officiis sit libero laudantium ut.", "3823330d-d5ea-49de-a00f-9d2edbadb27b", new DateTime(2021, 8, 26, 20, 7, 15, 297, DateTimeKind.Local).AddTicks(6588), "Product type: maxime", new DateTime(2021, 8, 27, 10, 17, 39, 743, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("925316a3-a356-49a1-847b-b2724c8865c7"), "Soluta non expedita cupiditate provident minus amet.", "63040098-ba30-4bd9-8413-cf93f24149d2", new DateTime(2021, 10, 7, 10, 58, 22, 24, DateTimeKind.Local).AddTicks(1584), "Product type: sit", new DateTime(2021, 10, 16, 11, 22, 24, 850, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9391c08d-06b4-4a31-a79d-4741c5641e53"), "Aut error numquam dolor tempore est consequatur atque.", "9cd9c290-a49d-4273-99fb-ce554c9676b4", new DateTime(2018, 2, 14, 6, 32, 25, 739, DateTimeKind.Local).AddTicks(6035), "Product type: neque", new DateTime(2019, 11, 2, 17, 33, 16, 42, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94507aa0-9674-4fb4-a9fe-1cf7775b0252"), "Quaerat asperiores rerum nemo autem rerum eum voluptas quisquam.", "0a816b55-dbec-421c-a742-f74b21a3ea01", new DateTime(2022, 3, 31, 3, 41, 55, 369, DateTimeKind.Local).AddTicks(5299), "Product type: cupiditate", new DateTime(2022, 6, 4, 8, 49, 6, 54, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9696c2e0-4784-48b8-bc52-7c793a89f598"), "Eius facere nobis ut incidunt ipsa.", "77c5a8b6-c0fa-45d6-9ba1-602ab131029d", new DateTime(2018, 3, 18, 16, 24, 55, 347, DateTimeKind.Local).AddTicks(886), "Product type: esse", new DateTime(2019, 7, 30, 23, 58, 5, 477, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9c6fd87c-4128-4c2b-854a-17e664b7616b"), "Ab praesentium doloribus itaque reiciendis beatae vel optio voluptatem.", "f9820b8d-850d-4083-ba47-4472d6a3f3c2", new DateTime(2019, 12, 12, 16, 23, 46, 484, DateTimeKind.Local).AddTicks(168), "Product type: molestiae", new DateTime(2022, 4, 26, 19, 16, 2, 67, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a0e99965-bfd9-4b3b-830b-8796e61f898e"), "Officia voluptatem veniam sit sit culpa ratione.", "1cf31ac7-6a32-4fa4-b6af-647f05176407", new DateTime(2018, 10, 21, 4, 53, 18, 574, DateTimeKind.Local).AddTicks(361), "Product type: ut", new DateTime(2021, 8, 21, 13, 17, 20, 10, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a3e3d199-777b-47d6-8eca-46b2f7512045"), "Et porro et cupiditate soluta est suscipit ab.", "c39fa130-9059-4ae5-98d4-7998aadb2f97", new DateTime(2020, 9, 17, 16, 7, 34, 529, DateTimeKind.Local).AddTicks(5124), "Product type: deleniti", new DateTime(2021, 10, 15, 12, 52, 40, 351, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6170b23-ff60-4402-b68b-197b778b259e"), "Ab neque qui illum magnam necessitatibus blanditiis qui.", "3375fb7d-1647-4439-968b-c14c4220d1ef", new DateTime(2017, 12, 20, 15, 13, 31, 381, DateTimeKind.Local).AddTicks(9062), "Product type: quod", new DateTime(2019, 5, 3, 1, 17, 28, 454, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a650ab8c-5c1e-4488-8482-8d58a6673bde"), "Iure sit rerum.", "ca4c0f12-249e-4451-b251-5d0e5204f319", new DateTime(2020, 11, 28, 8, 28, 26, 349, DateTimeKind.Local).AddTicks(8264), "Product type: maxime", new DateTime(2022, 6, 11, 8, 50, 27, 214, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a950c6df-8247-4a9e-9603-a6294a836004"), "Ut omnis quod.", "2492a335-ae63-4a69-80a4-17fa45ba3d4e", new DateTime(2017, 10, 31, 4, 44, 31, 32, DateTimeKind.Local).AddTicks(2928), "Product type: modi", new DateTime(2018, 9, 29, 21, 29, 49, 713, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa9a8a8b-cd7f-45fa-ac49-c98e421d35e5"), "Quidem voluptatem ad dolorem omnis ipsam.", "52fea380-be40-422e-9e94-c93c5f8fde54", new DateTime(2021, 11, 3, 1, 29, 0, 65, DateTimeKind.Local).AddTicks(9431), "Product type: voluptate", new DateTime(2022, 6, 2, 22, 51, 43, 978, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("abaeae64-1c6c-4d83-bca8-f65808129fa0"), "Sed et est rerum sed delectus.", "60504445-c0ca-423a-8496-531f7bf0a2a7", new DateTime(2017, 11, 12, 21, 52, 45, 9, DateTimeKind.Local).AddTicks(5836), "Product type: eum", new DateTime(2020, 1, 26, 5, 41, 52, 120, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad019822-a071-490f-b4a9-0bfe0e726eb4"), "Laboriosam modi mollitia quod.", "f751e72f-5112-49fd-9c13-523ad11d56b3", new DateTime(2019, 7, 8, 1, 56, 29, 852, DateTimeKind.Local).AddTicks(4019), "Product type: dolores", new DateTime(2022, 6, 7, 16, 7, 6, 968, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("adbc94d0-4196-4e46-ba78-f653d778f504"), "Et maxime sit odit qui iusto et nulla.", "8b19a327-68c6-4fb0-9035-a82d2ed81425", new DateTime(2018, 4, 24, 5, 1, 32, 319, DateTimeKind.Local).AddTicks(5253), "Product type: consectetur", new DateTime(2020, 7, 27, 18, 56, 24, 290, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("af4d1131-e60e-49aa-a7f4-c3acffc773f7"), "Et et inventore laborum placeat.", "5807d89d-5b4e-4ace-ba44-22e377b30d3b", new DateTime(2022, 4, 30, 16, 26, 33, 163, DateTimeKind.Local).AddTicks(2718), "Product type: tempora", new DateTime(2022, 5, 20, 18, 8, 44, 183, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("afe1083b-12dc-429e-a088-5d1ea710ecf6"), "Illum dolore ea quia beatae.", "1d120ae1-c765-43dd-9570-df4a04a1fdfb", new DateTime(2019, 5, 18, 4, 53, 17, 831, DateTimeKind.Local).AddTicks(9965), "Product type: voluptatem", new DateTime(2022, 6, 2, 12, 10, 9, 734, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b90a396c-68c6-445f-9533-c94524e50d2f"), "Soluta voluptate autem delectus eligendi eos.", "0179af4d-7358-4d19-a2ad-46d01013d1e3", new DateTime(2021, 10, 21, 13, 1, 7, 987, DateTimeKind.Local).AddTicks(786), "Product type: maxime", new DateTime(2022, 3, 3, 10, 3, 54, 96, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0bb148a-79d8-4381-8c35-d3a548cc9b84"), "Natus repellendus debitis culpa consequatur esse.", "0e4c8371-a730-41ee-9ef0-251755dfdce3", new DateTime(2020, 12, 20, 1, 36, 12, 673, DateTimeKind.Local).AddTicks(8669), "Product type: quia", new DateTime(2021, 4, 20, 1, 39, 32, 502, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2c7c1a8-5c19-47e5-9a13-90273866052f"), "Libero facilis in aut maxime eum.", "8094a60e-efaa-4bd2-92c1-0b299e07e7df", new DateTime(2019, 3, 8, 4, 51, 52, 458, DateTimeKind.Local).AddTicks(1825), "Product type: beatae", new DateTime(2019, 10, 28, 22, 20, 55, 378, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c5e4b874-d0c7-4ae7-b04e-5787378fc50e"), "Molestias doloremque necessitatibus quibusdam veniam.", "8695fbe5-b122-4a9d-ac32-0e46bae4892f", new DateTime(2020, 7, 8, 5, 2, 45, 550, DateTimeKind.Local).AddTicks(2193), "Product type: distinctio", new DateTime(2021, 10, 23, 0, 16, 29, 321, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ca3ab135-b525-4b3f-9098-746e212363fa"), "Dolores non numquam ipsa ducimus voluptate.", "ddbb5cc2-ff36-46d6-8bd6-b3389b4f7fe0", new DateTime(2019, 1, 4, 5, 1, 59, 662, DateTimeKind.Local).AddTicks(7354), "Product type: voluptatem", new DateTime(2020, 11, 17, 18, 50, 26, 478, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d2819da8-b14b-4d3e-b1d3-4c76302fe938"), "Voluptates ut ipsam aut eum molestiae accusantium excepturi dolorem similique.", "f715821a-f7d5-4c49-a584-aa82002ff352", new DateTime(2019, 12, 31, 7, 52, 34, 626, DateTimeKind.Local).AddTicks(6890), "Product type: doloremque", new DateTime(2022, 2, 4, 22, 55, 56, 868, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d409b79d-cdde-4380-888b-8ee29bd50fc2"), "Illum iusto nihil cupiditate.", "e0175c8c-4116-4f42-b865-81643d56a5a2", new DateTime(2021, 2, 1, 9, 18, 3, 870, DateTimeKind.Local).AddTicks(1051), "Product type: quam", new DateTime(2021, 3, 31, 8, 6, 52, 255, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da32059a-a6a3-45d2-8f2c-491a07da5d7b"), "Vero quia rerum velit ab nobis eveniet molestias consequatur.", "46a0245e-d2c1-444d-81ca-6e71fd093894", new DateTime(2019, 3, 22, 19, 45, 40, 483, DateTimeKind.Local).AddTicks(8496), "Product type: a", new DateTime(2019, 12, 2, 23, 57, 7, 68, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e00063c7-0596-4651-88e9-af1201c6f997"), "Reprehenderit facilis quia aperiam assumenda libero ipsum et temporibus.", "431e6b0c-2b74-4a22-954d-0c70cbda2473", new DateTime(2022, 1, 23, 11, 49, 11, 15, DateTimeKind.Local).AddTicks(1202), "Product type: ut", new DateTime(2022, 6, 8, 11, 21, 47, 403, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1b0930b-636c-4047-9e72-ad3ab5461738"), "Fugit fugiat sequi fugiat consequuntur voluptas.", "4e71cc9e-08b9-415c-9aa8-d62cf6ef820e", new DateTime(2021, 1, 28, 17, 31, 18, 396, DateTimeKind.Local).AddTicks(8271), "Product type: consequatur", new DateTime(2021, 9, 6, 3, 17, 5, 714, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e58c1616-0382-4448-a069-ad6cffdcf0a7"), "Et quo aut.", "1f45d96b-cf9b-4e6f-9e3f-f4ebb968ecb5", new DateTime(2022, 3, 21, 7, 50, 8, 886, DateTimeKind.Local).AddTicks(9224), "Product type: ea", new DateTime(2022, 4, 20, 6, 11, 41, 482, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e9b55bcb-483c-47d2-ac22-04c579138a04"), "Molestias ducimus hic.", "5f31a799-7a0d-4919-8c86-6a5f709aed24", new DateTime(2018, 4, 26, 0, 18, 23, 958, DateTimeKind.Local).AddTicks(5240), "Product type: dolorum", new DateTime(2021, 11, 1, 22, 6, 27, 271, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec0cf321-a4d1-44d6-961f-d33364906a37"), "Ducimus autem eum sed est accusantium.", "e2d55d20-df3b-446f-8476-a7bf0cb9e94c", new DateTime(2019, 1, 30, 4, 25, 14, 52, DateTimeKind.Local).AddTicks(1513), "Product type: autem", new DateTime(2020, 9, 12, 20, 5, 21, 670, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f0e7753c-60a6-4ad2-a69e-c1863498c841"), "Aut voluptas saepe sint magni laborum vitae magni qui explicabo.", "174b9147-b1a0-4de8-aaf4-7a2fc0b4eebd", new DateTime(2022, 6, 2, 2, 33, 50, 800, DateTimeKind.Local).AddTicks(7816), "Product type: impedit", new DateTime(2022, 6, 20, 23, 25, 12, 222, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f1afa994-0f42-4d0e-946e-abcaf4651062"), "Iure ut ad.", "5205cd9f-ef51-42f1-8cd9-a097d080cba5", new DateTime(2018, 5, 10, 3, 26, 6, 976, DateTimeKind.Local).AddTicks(1805), "Product type: provident", new DateTime(2018, 8, 8, 19, 47, 28, 409, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f85f5b4d-b6b7-4c54-a379-95036de7b8ed"), "Animi et sunt optio minima qui laudantium voluptas.", "d0477659-7dfe-40cd-8c71-a7c46eea52ad", new DateTime(2022, 4, 20, 8, 45, 11, 331, DateTimeKind.Local).AddTicks(989), "Product type: ut", new DateTime(2022, 7, 4, 5, 38, 19, 178, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc9cdba3-6469-47ff-a227-761fa3336e86"), "Voluptatem delectus excepturi quia.", "bd5827d3-876d-4a6f-9a0d-4fc079d95ad4", new DateTime(2021, 1, 14, 11, 30, 21, 831, DateTimeKind.Local).AddTicks(2104), "Product type: voluptas", new DateTime(2021, 11, 14, 22, 45, 27, 299, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc9d24c5-5294-43bb-b84e-d786adeae575"), "Illum dignissimos neque voluptatem laudantium at.", "2c4d0b35-b316-4ed0-9d2f-ab600e1a5918", new DateTime(2022, 6, 6, 7, 5, 4, 752, DateTimeKind.Local).AddTicks(3146), "Product type: provident", new DateTime(2022, 6, 14, 11, 27, 58, 109, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("019ee047-5535-4c24-bd78-549238a44d90"), "Sint repellendus nisi ea aut fugiat.", "713fdc05-8fbf-472c-8999-a11e1b67e1a2", new DateTime(2019, 8, 20, 11, 30, 24, 814, DateTimeKind.Local).AddTicks(8816), "Product unit classifier: laborum", new DateTime(2022, 5, 14, 12, 41, 53, 73, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0326cd22-51da-4082-9358-9622e4e3a7d7"), "Doloremque nobis quas quibusdam ipsam voluptas et numquam.", "672d611d-b5cb-4d1e-97f6-324d0031f632", new DateTime(2018, 1, 8, 15, 45, 38, 985, DateTimeKind.Local).AddTicks(8270), "Product unit classifier: iusto", new DateTime(2018, 10, 22, 9, 39, 37, 5, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0398f66b-4acc-4285-95da-0fe9ed04b0d7"), "Ad minima sunt perspiciatis.", "c7e63971-8278-40b0-adf1-66cc40a4c581", new DateTime(2017, 8, 14, 3, 19, 33, 59, DateTimeKind.Local).AddTicks(9113), "Product unit classifier: tenetur", new DateTime(2021, 8, 3, 5, 46, 35, 893, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("03daae17-d93d-445b-b31b-59c7095833b5"), "Est quia odit est.", "019b8501-bfca-47a6-b3df-be2228bf2ff5", new DateTime(2021, 10, 24, 5, 58, 7, 663, DateTimeKind.Local).AddTicks(3581), "Product unit classifier: quia", new DateTime(2022, 2, 16, 9, 56, 35, 500, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("053eea9e-6b38-49a7-8b9e-93cd82ee512f"), "Saepe et fuga sint.", "a3b1cbaf-3ae2-4796-a1df-75eb40e42b10", new DateTime(2022, 1, 11, 6, 0, 36, 229, DateTimeKind.Local).AddTicks(7528), "Product unit classifier: inventore", new DateTime(2022, 4, 18, 2, 13, 52, 598, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("062beab2-1429-4ef5-a7e0-85cfe7dd8fb1"), "Ea sunt pariatur quo reprehenderit ut sunt perspiciatis ex.", "eeced48c-cf55-43b1-ae1e-799035ac6855", new DateTime(2018, 7, 30, 5, 55, 26, 480, DateTimeKind.Local).AddTicks(9462), "Product unit classifier: harum", new DateTime(2019, 3, 3, 4, 2, 39, 318, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07e6dab2-efb5-4ede-b87a-9a99dc9c4ee9"), "Quasi ut provident similique dolor rerum.", "06c41b98-8ede-4088-a0db-bd9cee045ee3", new DateTime(2020, 10, 11, 12, 8, 7, 435, DateTimeKind.Local).AddTicks(459), "Product unit classifier: quis", new DateTime(2022, 3, 21, 20, 57, 33, 731, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0bd109cf-0d18-4e3e-bb08-2a2294be55bd"), "Nostrum eum earum assumenda.", "f673f501-d0aa-4398-9cc6-6dd2ea099e90", new DateTime(2018, 8, 10, 22, 27, 8, 380, DateTimeKind.Local).AddTicks(5019), "Product unit classifier: et", new DateTime(2019, 9, 23, 21, 22, 55, 627, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f376951-0c65-40b8-8ad4-5e8e83412890"), "Ut qui ad excepturi.", "54f5db31-bd2d-440c-96f3-134c6196f38e", new DateTime(2020, 12, 7, 18, 5, 15, 555, DateTimeKind.Local).AddTicks(5257), "Product unit classifier: deleniti", new DateTime(2022, 4, 3, 23, 7, 58, 674, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("103bc6d4-c83d-4124-ad02-8bd1c414f83e"), "Nesciunt recusandae harum.", "1fcadca8-488f-4840-bab7-fc778fecc1a9", new DateTime(2018, 10, 16, 23, 7, 14, 973, DateTimeKind.Local).AddTicks(7715), "Product unit classifier: voluptas", new DateTime(2021, 8, 29, 6, 42, 56, 358, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1119c965-f939-4317-95dc-df225152b886"), "Voluptatem consequatur exercitationem et qui harum quo.", "18aef629-5f09-40ba-9b85-a9a836fa2e9c", new DateTime(2020, 11, 30, 5, 47, 45, 671, DateTimeKind.Local).AddTicks(1735), "Product unit classifier: molestiae", new DateTime(2021, 6, 27, 6, 59, 18, 299, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11782f63-7e8a-4ddb-982f-1a1122043b61"), "Animi minima non non suscipit.", "7eed3238-a064-41e6-94fe-6961dd13bbbd", new DateTime(2022, 5, 14, 15, 37, 33, 261, DateTimeKind.Local).AddTicks(8134), "Product unit classifier: praesentium", new DateTime(2022, 5, 27, 12, 5, 41, 502, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1565acfb-34db-4973-80f2-563ad6d5440a"), "Voluptate architecto et repellat vel voluptatem consequatur qui odit qui.", "4e340887-7b42-469d-85a8-5afad7662199", new DateTime(2020, 4, 9, 14, 59, 5, 904, DateTimeKind.Local).AddTicks(8353), "Product unit classifier: omnis", new DateTime(2022, 1, 3, 10, 46, 9, 818, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1747663b-3fad-402b-a0a8-3be4dc065f0e"), "Enim debitis maiores voluptate molestiae.", "549be9cf-4c89-453f-bb94-2b5f0fa6ceec", new DateTime(2020, 9, 30, 23, 15, 5, 559, DateTimeKind.Local).AddTicks(7849), "Product unit classifier: dolores", new DateTime(2021, 10, 10, 11, 54, 27, 861, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("179d55bb-5f65-4ee7-bd30-fa3f23c812ff"), "Incidunt magni recusandae aperiam.", "2ada2472-7a17-4539-b7ab-06b286e2a0e6", new DateTime(2018, 3, 31, 15, 17, 54, 533, DateTimeKind.Local).AddTicks(2699), "Product unit classifier: ducimus", new DateTime(2020, 1, 3, 17, 40, 25, 207, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19764d4e-ddbf-427e-8b84-6910167b48c3"), "Eaque eius iusto.", "a9b1b335-1c6d-462b-a51f-edb2b126f82a", new DateTime(2019, 4, 30, 13, 12, 11, 734, DateTimeKind.Local).AddTicks(5495), "Product unit classifier: ut", new DateTime(2020, 1, 7, 12, 14, 41, 635, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c122b6f-f08d-4379-8e26-efecfd90e82c"), "Aliquid et voluptas qui autem est sunt.", "64cab773-a4ad-462e-8311-b5a032cc194b", new DateTime(2017, 12, 30, 23, 44, 35, 280, DateTimeKind.Local).AddTicks(9611), "Product unit classifier: maxime", new DateTime(2021, 9, 15, 8, 54, 47, 272, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c913377-7295-4747-96cc-a7cedf049aac"), "Repudiandae expedita provident dicta odio incidunt.", "8c7ed3d6-9f0c-43ab-aa70-0d9704912fdb", new DateTime(2018, 11, 25, 7, 8, 43, 528, DateTimeKind.Local).AddTicks(5552), "Product unit classifier: quia", new DateTime(2019, 7, 18, 13, 51, 9, 409, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1d661567-b03d-4fb2-a319-857fcd8ff3e9"), "Voluptas facere dignissimos explicabo eum.", "69a4f901-f773-45a9-b3ea-1540584538c5", new DateTime(2017, 10, 15, 13, 55, 27, 990, DateTimeKind.Local).AddTicks(6618), "Product unit classifier: consequatur", new DateTime(2019, 6, 28, 8, 43, 47, 961, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1deed37f-6fb3-4407-b769-ca7bb199820f"), "Sed fugiat consequuntur voluptas quo quis sit.", "bc6b348a-c0b0-4b34-8fc5-d972cc0840dd", new DateTime(2019, 6, 21, 12, 47, 53, 870, DateTimeKind.Local).AddTicks(4823), "Product unit classifier: eum", new DateTime(2021, 7, 21, 6, 56, 33, 96, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("207556de-7f66-4b0e-8c77-a1e072fd0cc0"), "Cum eveniet dignissimos quam.", "80573236-039a-48dc-a56d-b5c0ce3fc1c1", new DateTime(2021, 11, 12, 12, 5, 51, 910, DateTimeKind.Local).AddTicks(3384), "Product unit classifier: vitae", new DateTime(2021, 11, 18, 6, 32, 13, 186, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22fa8a31-4892-46e0-9b29-1e5378854508"), "Et perspiciatis occaecati quas reprehenderit nostrum modi quo.", "15bfc890-18f7-4a1a-ace0-6acf3b1738ea", new DateTime(2017, 8, 8, 22, 43, 16, 829, DateTimeKind.Local).AddTicks(1236), "Product unit classifier: voluptatem", new DateTime(2020, 5, 7, 16, 27, 37, 277, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2395fbdf-c5d3-445f-b63a-164c8f540cb8"), "Deleniti molestias unde deleniti ullam.", "b292a892-4f80-4445-9f80-39c59b1f5364", new DateTime(2021, 9, 6, 9, 54, 34, 933, DateTimeKind.Local).AddTicks(978), "Product unit classifier: iure", new DateTime(2022, 1, 11, 23, 52, 21, 435, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2a932ffb-c812-4fa3-85c9-d29e1c2dec9d"), "Non reprehenderit eos itaque et iste.", "cde3e685-a15c-49e8-9f9c-4f3378eadf0f", new DateTime(2020, 5, 8, 13, 52, 53, 982, DateTimeKind.Local).AddTicks(1557), "Product unit classifier: et", new DateTime(2021, 5, 20, 19, 12, 23, 239, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2f480754-f6f2-429c-8e86-6b4f04063adf"), "Dicta mollitia similique nisi deleniti iusto.", "2506a078-53bd-44e2-8607-6ea4e1576256", new DateTime(2019, 10, 22, 11, 37, 48, 763, DateTimeKind.Local).AddTicks(5701), "Product unit classifier: libero", new DateTime(2022, 4, 25, 13, 14, 29, 431, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3196656f-e7ad-448f-b7b9-b99c2df9b56f"), "Voluptatem facere earum sed.", "b2e16287-0004-4202-94ca-86f2d93351ac", new DateTime(2021, 9, 4, 19, 25, 13, 608, DateTimeKind.Local).AddTicks(5313), "Product unit classifier: sunt", new DateTime(2022, 4, 9, 16, 6, 5, 906, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31998dfb-bf5a-4592-a5a9-d1f1342227e9"), "Nisi molestias perferendis.", "258dd7c0-33b6-44c6-a0ab-a9e90b4c1e03", new DateTime(2019, 10, 14, 12, 54, 10, 704, DateTimeKind.Local).AddTicks(6013), "Product unit classifier: aut", new DateTime(2022, 1, 8, 1, 21, 8, 68, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("353a776b-d7ca-49a6-8931-d9d897aef35a"), "Occaecati error maxime tempore minus.", "61399197-0873-4c2e-9711-767182304bbe", new DateTime(2020, 6, 27, 22, 21, 56, 166, DateTimeKind.Local).AddTicks(742), "Product unit classifier: at", new DateTime(2020, 9, 20, 1, 22, 14, 705, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3aa14c6c-20c5-4043-add8-8460d59e8f5b"), "Fugit est in perferendis.", "f5685b3d-b88c-4d1d-87a6-ea8f7e20381b", new DateTime(2019, 4, 11, 13, 58, 22, 544, DateTimeKind.Local).AddTicks(8423), "Product unit classifier: ut", new DateTime(2022, 5, 26, 8, 44, 12, 569, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b8af2e0-cb46-4a7f-aafb-4a588a677fe3"), "Quo in dolor dolores id quibusdam corrupti commodi qui consequatur.", "da49a0ba-0a8b-47ec-97ec-ba576cdbd772", new DateTime(2021, 8, 18, 17, 46, 23, 758, DateTimeKind.Local).AddTicks(4798), "Product unit classifier: architecto", new DateTime(2021, 10, 7, 23, 6, 34, 156, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f1365f5-4a58-4034-9f59-e203046a5d0b"), "Ut quo eaque aut in corrupti rerum molestiae pariatur.", "e65f34f3-877f-43f7-a1d2-a96946cf5f7d", new DateTime(2018, 5, 29, 17, 29, 44, 615, DateTimeKind.Local).AddTicks(1091), "Product unit classifier: autem", new DateTime(2018, 11, 13, 23, 8, 41, 556, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("40033a74-9a79-4dc2-ba02-1fc16637ecc5"), "Sit dolorum est sapiente corrupti.", "7d37744c-fd64-4954-bcd5-05961f98f05f", new DateTime(2019, 1, 19, 23, 4, 48, 423, DateTimeKind.Local).AddTicks(7223), "Product unit classifier: sequi", new DateTime(2021, 12, 9, 19, 8, 38, 346, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("442e9eb6-b14b-49cf-b790-72e5c4a4f35b"), "Optio atque nulla quo consequatur.", "6c304a17-b384-439c-881f-c766bdf3705c", new DateTime(2018, 9, 4, 16, 44, 58, 774, DateTimeKind.Local).AddTicks(9552), "Product unit classifier: molestias", new DateTime(2019, 2, 25, 9, 52, 29, 827, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("443b092d-77d1-489e-b299-5ab961e96e30"), "Explicabo voluptatibus omnis ipsa amet voluptas.", "7ac67bec-df8d-4a51-a498-35c78ddd3de7", new DateTime(2018, 9, 8, 17, 52, 16, 161, DateTimeKind.Local).AddTicks(5871), "Product unit classifier: non", new DateTime(2020, 9, 7, 19, 8, 4, 812, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("44f5816f-6cd3-4266-a2ee-c24bbdc77373"), "Amet a quia.", "8ea07734-da52-4864-8dad-e72b17ff063d", new DateTime(2019, 1, 23, 5, 4, 49, 549, DateTimeKind.Local).AddTicks(1653), "Product unit classifier: nam", new DateTime(2021, 8, 24, 21, 34, 16, 2, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("44fcc50c-2988-466c-8ef1-740ec9f12642"), "Itaque saepe architecto harum doloremque omnis veritatis esse debitis asperiores.", "b36ed96f-93e8-4dc4-96d6-914cbdd07243", new DateTime(2017, 10, 5, 6, 7, 38, 431, DateTimeKind.Local).AddTicks(5441), "Product unit classifier: consequatur", new DateTime(2020, 4, 23, 20, 20, 19, 789, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("460f80f8-6cf4-406b-9561-e87e99ee292d"), "Aliquam quidem quae rerum rerum iusto ut libero vitae.", "00c38296-457b-4702-8595-bc7304ba812e", new DateTime(2021, 12, 11, 8, 6, 43, 542, DateTimeKind.Local).AddTicks(6899), "Product unit classifier: rerum", new DateTime(2022, 2, 14, 21, 43, 44, 264, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4a17cda5-9aa2-443f-b70a-e13e2169b2e3"), "Quasi fuga quia adipisci distinctio occaecati.", "17235bcd-5053-4050-b058-6e54be4df1e8", new DateTime(2020, 2, 19, 21, 41, 16, 47, DateTimeKind.Local).AddTicks(1244), "Product unit classifier: asperiores", new DateTime(2022, 1, 1, 22, 45, 24, 36, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c6e00ea-eef4-4d39-9566-64f82bc6993e"), "Odio cumque quia ut eaque ratione ab dolorem.", "efa484d2-9fa3-4a6d-84af-fd59d0c44af3", new DateTime(2019, 12, 24, 11, 38, 54, 910, DateTimeKind.Local).AddTicks(2570), "Product unit classifier: odio", new DateTime(2020, 6, 16, 9, 45, 53, 505, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e34a3f1-fabf-4a77-9290-ecb40ea7563d"), "Fugiat non nihil minus est inventore repellat delectus quo.", "910dafa8-bb36-4277-bbf6-5f9b44d8b4aa", new DateTime(2017, 8, 24, 21, 33, 7, 403, DateTimeKind.Local).AddTicks(5731), "Product unit classifier: et", new DateTime(2020, 5, 8, 10, 10, 54, 396, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52a664a8-7676-493e-8441-00805f476903"), "Vel sit ex voluptatum.", "3fe558c8-980c-4e0f-b7ce-e3ca04d032b4", new DateTime(2022, 2, 17, 4, 53, 50, 236, DateTimeKind.Local).AddTicks(3847), "Product unit classifier: soluta", new DateTime(2022, 5, 14, 2, 50, 34, 344, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52d48d70-69fb-4138-a6b1-a3debb243e04"), "Delectus nulla itaque explicabo.", "41031e82-4e55-4712-b86a-a997fc062832", new DateTime(2018, 5, 2, 10, 10, 6, 159, DateTimeKind.Local).AddTicks(7747), "Product unit classifier: molestiae", new DateTime(2021, 11, 29, 23, 2, 58, 162, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55c6f755-32b9-43eb-802c-1c91886a2139"), "Sed ipsam sed qui aut consectetur iure asperiores cupiditate distinctio.", "be5e451c-1a72-4e6f-b312-e5472003dbf5", new DateTime(2021, 7, 13, 18, 39, 8, 859, DateTimeKind.Local).AddTicks(5978), "Product unit classifier: esse", new DateTime(2021, 10, 2, 21, 53, 27, 956, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("56055748-a165-4924-a8d0-0baaf314ade4"), "Amet consectetur tenetur et architecto quis.", "47f2bc0d-2c0d-4c9b-9780-b89832b73c4c", new DateTime(2020, 10, 21, 19, 13, 34, 336, DateTimeKind.Local).AddTicks(7154), "Product unit classifier: delectus", new DateTime(2021, 4, 6, 18, 18, 30, 331, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("56e2e3bd-83cc-4b01-a4a8-2df24ac3e045"), "Cupiditate dolorem natus accusamus aut dolor rerum odit sed.", "7e845680-7d2b-452f-b07d-cfb6e95118b1", new DateTime(2019, 6, 6, 6, 4, 53, 299, DateTimeKind.Local).AddTicks(9958), "Product unit classifier: sequi", new DateTime(2022, 5, 24, 21, 1, 12, 961, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("570c1e11-1f23-48a3-9686-e8d912c15061"), "Sapiente corporis eius consequatur.", "7f719f76-2945-4047-b07f-70b146e29b96", new DateTime(2020, 10, 31, 15, 0, 23, 82, DateTimeKind.Local).AddTicks(6003), "Product unit classifier: facere", new DateTime(2022, 3, 10, 6, 36, 50, 722, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e447507-c3b7-4e69-9caf-2050a01e9458"), "Quo rerum dicta non ipsa aperiam nam quasi incidunt.", "1a645708-73a2-4849-ba96-4d887de249a9", new DateTime(2018, 9, 7, 14, 34, 29, 322, DateTimeKind.Local).AddTicks(5221), "Product unit classifier: qui", new DateTime(2021, 5, 6, 21, 35, 44, 950, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ea72b1c-c9be-4771-9739-d57e4c1c81d1"), "Inventore minima sit rem sed ad reiciendis.", "06b4edfe-b337-4444-9610-c2646683a1af", new DateTime(2017, 9, 23, 8, 20, 22, 134, DateTimeKind.Local).AddTicks(504), "Product unit classifier: voluptatum", new DateTime(2021, 10, 12, 5, 9, 54, 411, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5fac3ff8-c8ba-47b1-9278-6a7e13fb9b20"), "Non aperiam nesciunt doloremque aut laboriosam totam.", "0f25db2a-4e5a-473d-9f21-fcf4457169c3", new DateTime(2019, 12, 4, 17, 23, 5, 888, DateTimeKind.Local).AddTicks(3709), "Product unit classifier: et", new DateTime(2022, 2, 9, 10, 17, 52, 902, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("63000b26-f6a4-40c4-839d-4595256e96f5"), "Ab officia recusandae officia.", "584d8574-3bee-42f1-965d-d1d96d772b55", new DateTime(2022, 4, 27, 20, 21, 51, 610, DateTimeKind.Local).AddTicks(4550), "Product unit classifier: odit", new DateTime(2022, 6, 29, 2, 26, 13, 358, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69564ec1-1801-4e15-bffd-0bdaa85760b0"), "Impedit eligendi earum ut sit vitae delectus occaecati et.", "2042805f-a385-47af-847b-ca120900a06e", new DateTime(2019, 3, 23, 5, 2, 35, 769, DateTimeKind.Local).AddTicks(1420), "Product unit classifier: corporis", new DateTime(2021, 11, 25, 18, 2, 49, 19, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b557633-5754-4b36-966a-ef6f1fbd78cc"), "Debitis nesciunt eum.", "34d4a854-1c7b-4b5f-bf1a-22485f55cdd9", new DateTime(2019, 10, 18, 0, 13, 34, 435, DateTimeKind.Local).AddTicks(2567), "Product unit classifier: accusamus", new DateTime(2021, 12, 23, 10, 8, 50, 284, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6eb2ee90-cf26-4df9-853d-9ccf7b965780"), "Temporibus autem pariatur fuga reiciendis.", "8a44fbfb-5c4a-407d-a636-79c0002c9d38", new DateTime(2020, 10, 20, 12, 52, 18, 602, DateTimeKind.Local).AddTicks(7087), "Product unit classifier: voluptas", new DateTime(2020, 12, 2, 4, 21, 10, 175, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6ec84a00-91cd-4719-8edb-46ec330fede8"), "Non veritatis quod.", "fd88a03f-e596-45ad-9c10-919196111a92", new DateTime(2019, 6, 18, 23, 52, 16, 52, DateTimeKind.Local).AddTicks(903), "Product unit classifier: rerum", new DateTime(2020, 10, 14, 7, 58, 53, 670, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7032b10f-dc4e-4874-bfa8-1e248dbe6f4f"), "Et excepturi rerum dolorem sit.", "dd43658d-9146-4388-9327-f20399cb1b0f", new DateTime(2018, 4, 16, 10, 44, 36, 64, DateTimeKind.Local).AddTicks(357), "Product unit classifier: quod", new DateTime(2019, 6, 4, 17, 0, 44, 768, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("780810e5-74d6-4ec7-9a24-69147e4d24d1"), "Dolores repellendus dolores quidem.", "bb389d3d-81d7-4f1b-a1d2-00c08135b45b", new DateTime(2020, 7, 9, 4, 9, 6, 196, DateTimeKind.Local).AddTicks(4152), "Product unit classifier: alias", new DateTime(2020, 7, 16, 21, 6, 55, 975, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("78b27df6-0428-464a-932a-b2d726659cd9"), "Officia dolore odit eum et.", "bc9aefe6-d48c-448f-8eb4-3f0ec471e6ae", new DateTime(2020, 5, 27, 23, 0, 8, 452, DateTimeKind.Local).AddTicks(4484), "Product unit classifier: exercitationem", new DateTime(2020, 7, 8, 13, 29, 9, 733, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7bac3d26-a332-4c19-97b1-e7e807b5b6fd"), "Ut deleniti quia.", "46f82d4c-ec16-41cf-b1fc-9d75938edb3b", new DateTime(2018, 10, 21, 15, 29, 25, 477, DateTimeKind.Local).AddTicks(8179), "Product unit classifier: hic", new DateTime(2020, 11, 16, 2, 18, 8, 323, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7d41b5d7-e149-4d3d-a904-fbabd4c7f87d"), "Minus quas non eligendi accusantium.", "463557a3-cca8-4625-9ee3-c2667302bb3f", new DateTime(2022, 6, 28, 20, 25, 47, 579, DateTimeKind.Local).AddTicks(8757), "Product unit classifier: quia", new DateTime(2022, 7, 5, 9, 47, 12, 193, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7fa883d1-ea41-42c7-b1da-d5673919df48"), "Laborum et minima eos consequatur quos.", "62066161-16ad-4339-82e2-23c90447c49f", new DateTime(2020, 9, 25, 20, 6, 52, 214, DateTimeKind.Local).AddTicks(5383), "Product unit classifier: distinctio", new DateTime(2022, 4, 24, 7, 1, 19, 187, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("865a95ef-352c-4e5e-aa86-e7736d631203"), "Consequatur consectetur fugiat quis dolor consequatur animi et.", "3d4608b3-e4ae-4a8c-881c-30c309585db7", new DateTime(2020, 2, 19, 10, 54, 14, 488, DateTimeKind.Local).AddTicks(3380), "Product unit classifier: in", new DateTime(2022, 3, 4, 8, 32, 40, 68, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ea965b2-2e2e-4cc3-966f-b7439b58e957"), "Totam officia qui laborum debitis rem qui velit similique ipsum.", "caa53aba-4390-4e14-8273-ab022f7f80f8", new DateTime(2017, 7, 14, 2, 42, 18, 482, DateTimeKind.Local).AddTicks(8332), "Product unit classifier: nihil", new DateTime(2022, 3, 31, 13, 26, 50, 291, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9235dbb8-70c1-401e-a206-13fce6f1d668"), "Hic velit recusandae consectetur praesentium magnam.", "c5e51a65-4192-45cf-9352-1533f33bdd27", new DateTime(2020, 7, 6, 17, 8, 13, 618, DateTimeKind.Local).AddTicks(9529), "Product unit classifier: dolor", new DateTime(2020, 11, 20, 21, 8, 54, 778, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("97e3ff62-7070-431a-ad10-30cd1718a1c5"), "Enim odio molestias.", "c686aada-050b-4208-a41d-aa88ec4babca", new DateTime(2019, 6, 12, 14, 55, 53, 757, DateTimeKind.Local).AddTicks(4397), "Product unit classifier: aliquam", new DateTime(2022, 1, 24, 12, 57, 44, 793, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("98db78ba-d895-4aa1-affd-3027c29484ad"), "Voluptates optio blanditiis laborum.", "6c766782-f8f4-48ea-a91d-9d642339d5db", new DateTime(2019, 10, 24, 23, 12, 39, 86, DateTimeKind.Local).AddTicks(9936), "Product unit classifier: eos", new DateTime(2021, 12, 15, 14, 38, 47, 895, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f2897df-7af7-4374-bc9b-2843bc4a8aac"), "Nihil esse similique labore quia ex.", "df58b5ba-02d6-4aae-a682-5b635228bc09", new DateTime(2021, 8, 13, 6, 36, 7, 644, DateTimeKind.Local).AddTicks(6061), "Product unit classifier: inventore", new DateTime(2022, 1, 28, 0, 25, 5, 66, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2fd4d1d-a318-4ece-837f-4e2def45d5fa"), "Quaerat dolorem minus sit soluta.", "b5ed9025-c697-4487-b5f6-ab162e713f00", new DateTime(2020, 10, 15, 0, 48, 21, 547, DateTimeKind.Local).AddTicks(2395), "Product unit classifier: enim", new DateTime(2022, 5, 28, 16, 4, 39, 991, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a971fca5-0100-42d8-9920-7299bf0b97bf"), "In vero autem est porro.", "b7807d1a-60c1-432e-aaf4-9d4437cd51c6", new DateTime(2022, 2, 28, 4, 23, 5, 4, DateTimeKind.Local).AddTicks(6023), "Product unit classifier: beatae", new DateTime(2022, 6, 11, 20, 45, 38, 838, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa1181b4-d6d2-4763-a28a-438ba42af99e"), "Voluptas aut eius et consequatur qui accusamus sunt adipisci.", "235a8bea-e689-48a4-9a11-b8c18bcf6520", new DateTime(2019, 7, 11, 12, 31, 43, 812, DateTimeKind.Local).AddTicks(6230), "Product unit classifier: provident", new DateTime(2022, 5, 19, 6, 5, 11, 964, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae511e5f-4b8d-4691-b444-7a334407c347"), "Ea sequi non accusamus id itaque odit illum repudiandae nulla.", "71d7e9c1-d3e0-43e6-8623-c56bac48112c", new DateTime(2020, 5, 3, 9, 28, 42, 379, DateTimeKind.Local).AddTicks(3893), "Product unit classifier: modi", new DateTime(2021, 12, 7, 6, 58, 30, 563, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae684ea7-e2b9-4540-8477-d38a4384b353"), "Dignissimos voluptatem occaecati pariatur aut.", "1fcf386a-6341-4f8a-a2fe-50dd181539fb", new DateTime(2017, 12, 22, 22, 34, 56, 202, DateTimeKind.Local).AddTicks(7855), "Product unit classifier: ipsam", new DateTime(2017, 12, 28, 2, 19, 28, 566, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae7d5348-e6ed-4358-835e-7e3735692e75"), "Tempora neque veritatis fugiat dolore minus praesentium placeat est.", "390ea118-bfc5-4559-957b-de87611e87cb", new DateTime(2018, 8, 15, 0, 25, 30, 493, DateTimeKind.Local).AddTicks(4038), "Product unit classifier: rerum", new DateTime(2019, 2, 5, 11, 19, 12, 335, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b0bdd516-00f7-4e23-8a22-c9b1a4d3cd3f"), "Officiis autem consequatur illo rem illum vitae.", "dd484ff8-91e0-46c2-affb-c8459dd8e7b3", new DateTime(2021, 4, 1, 16, 54, 16, 120, DateTimeKind.Local).AddTicks(1010), "Product unit classifier: excepturi", new DateTime(2021, 9, 2, 18, 47, 48, 447, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b12e61ab-e1ae-4cad-b2ae-5901ac93d7b2"), "Delectus ut officiis neque quo optio illo.", "023532bd-c40f-4660-9bdb-8149aa9b352f", new DateTime(2021, 10, 12, 4, 53, 7, 578, DateTimeKind.Local).AddTicks(5565), "Product unit classifier: et", new DateTime(2022, 2, 9, 12, 26, 24, 537, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b19473e9-e3b6-48c4-a842-6f9c7732ad15"), "Dignissimos repellendus et eveniet sequi.", "d8a80b89-a247-4325-b317-4c6dfc160a7f", new DateTime(2019, 9, 8, 16, 19, 35, 883, DateTimeKind.Local).AddTicks(2805), "Product unit classifier: eum", new DateTime(2021, 6, 18, 20, 50, 7, 696, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b2d2448a-3f5c-4393-bfa9-a8bbb330ef3b"), "Accusantium et similique assumenda unde optio nam.", "821ffc4f-3d5b-4a7b-96fb-7452a255dc30", new DateTime(2018, 3, 4, 8, 50, 8, 984, DateTimeKind.Local).AddTicks(5406), "Product unit classifier: dignissimos", new DateTime(2021, 2, 22, 16, 15, 43, 92, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6644042-9721-4fc5-86ae-707f9f3717ef"), "Cupiditate voluptatem quia porro quos laboriosam nihil ducimus.", "880bee0d-89bd-4d06-9686-00fde08d45e7", new DateTime(2017, 8, 21, 15, 11, 12, 244, DateTimeKind.Local).AddTicks(696), "Product unit classifier: eos", new DateTime(2022, 6, 7, 17, 32, 23, 335, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc55c75a-bf28-4049-b655-3d6211ee607e"), "Sit et fugit eligendi.", "63c79a15-3dc1-42b7-8b2d-830fa41426b9", new DateTime(2020, 7, 29, 8, 7, 5, 253, DateTimeKind.Local).AddTicks(7120), "Product unit classifier: similique", new DateTime(2022, 1, 2, 0, 28, 15, 29, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("be23a8a8-5b42-4361-898e-425856612045"), "Nemo in nesciunt labore.", "d3b39401-74b2-4372-a6da-2d8f584608b9", new DateTime(2022, 5, 15, 22, 44, 33, 819, DateTimeKind.Local).AddTicks(2930), "Product unit classifier: blanditiis", new DateTime(2022, 5, 24, 20, 24, 38, 92, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c19f8675-41bf-477d-b741-a6e26b5802f7"), "Rerum quos nihil et sit minima asperiores.", "c781f468-7cf1-43bd-878f-25af5d154e0a", new DateTime(2021, 1, 17, 3, 56, 43, 875, DateTimeKind.Local).AddTicks(4652), "Product unit classifier: nostrum", new DateTime(2021, 10, 29, 7, 41, 6, 882, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1e26a1b-a88e-4c12-97c3-aa1f71de3327"), "Dicta quas voluptas est.", "c188e05a-be70-4d8d-b585-a4f44dd9db33", new DateTime(2019, 10, 28, 6, 47, 15, 841, DateTimeKind.Local).AddTicks(8401), "Product unit classifier: culpa", new DateTime(2022, 5, 23, 19, 27, 26, 810, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c3e2b176-b03e-449d-85c6-cf8b420b9c3e"), "Voluptatem recusandae totam quia nesciunt totam nihil expedita voluptate qui.", "0e656254-e74e-46e1-aa6c-b3fc2149f7a7", new DateTime(2018, 6, 24, 7, 56, 39, 156, DateTimeKind.Local).AddTicks(3282), "Product unit classifier: quidem", new DateTime(2019, 12, 4, 10, 55, 49, 530, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c91fb68b-d1f8-4a40-9712-670487a67c08"), "Et natus mollitia.", "7be603c1-9630-4d60-aa58-c42af781f640", new DateTime(2018, 2, 11, 8, 54, 18, 775, DateTimeKind.Local).AddTicks(1510), "Product unit classifier: ullam", new DateTime(2019, 10, 14, 9, 39, 12, 383, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cac3005e-8dbc-4b13-8559-be3db9224483"), "Odit et laborum.", "be282e7a-b461-4e9f-bb29-2618a6fb3d0f", new DateTime(2020, 6, 28, 17, 0, 49, 451, DateTimeKind.Local).AddTicks(4226), "Product unit classifier: natus", new DateTime(2021, 3, 9, 5, 55, 21, 588, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd1e8c8b-b406-4fad-a951-91588b94b58f"), "Consequatur autem blanditiis explicabo rem quo laboriosam facilis consectetur.", "e7939130-d720-45bb-b0e6-d36c6722b4cc", new DateTime(2017, 11, 30, 21, 27, 39, 992, DateTimeKind.Local).AddTicks(4593), "Product unit classifier: neque", new DateTime(2018, 11, 6, 6, 14, 5, 338, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ced9b084-43f8-40a1-8f4c-b18b14396557"), "Nesciunt vel hic inventore magni quia aperiam minima.", "f3335a99-ed23-4f96-9621-9f2d07a4ef7e", new DateTime(2021, 9, 12, 12, 33, 47, 138, DateTimeKind.Local).AddTicks(3668), "Product unit classifier: corporis", new DateTime(2021, 10, 2, 16, 43, 50, 606, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8abd132-cb93-4113-a2b2-8962c1096aac"), "Voluptatem et rerum placeat omnis accusamus.", "aaee364e-760d-4adf-bfc2-f165ff2fb94c", new DateTime(2020, 2, 29, 3, 6, 41, 292, DateTimeKind.Local).AddTicks(4351), "Product unit classifier: sint", new DateTime(2021, 2, 26, 18, 42, 37, 394, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d91ac048-baa4-421b-bdfd-ce4fc281c584"), "Doloremque nam doloremque ea.", "0a8593e2-e91e-4278-ae36-5ea32c39f90c", new DateTime(2019, 1, 4, 18, 31, 55, 192, DateTimeKind.Local).AddTicks(3146), "Product unit classifier: numquam", new DateTime(2019, 5, 5, 15, 50, 16, 275, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da09b1d0-dc6c-4ba6-a4f3-bddf4a0896da"), "Laudantium omnis et expedita aspernatur aut.", "cde7990a-b267-467b-8c5e-1ecc0131d2b4", new DateTime(2021, 1, 22, 18, 50, 27, 565, DateTimeKind.Local).AddTicks(6099), "Product unit classifier: iure", new DateTime(2022, 1, 30, 7, 52, 44, 600, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dad735a2-9424-4f9c-8c41-5d231bb5e21c"), "Suscipit consequuntur iure eaque perspiciatis eum nobis.", "8001de2f-90d8-48ba-87fb-fe1bec72b587", new DateTime(2019, 2, 26, 11, 56, 32, 643, DateTimeKind.Local).AddTicks(4140), "Product unit classifier: distinctio", new DateTime(2021, 5, 13, 5, 47, 28, 462, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db4d716f-abfc-46be-aa7b-ab4a32abdeb7"), "Ab unde impedit perspiciatis repudiandae beatae velit qui omnis.", "fa27f394-8d3b-4197-b2b0-775235954bb8", new DateTime(2018, 8, 3, 7, 40, 27, 543, DateTimeKind.Local).AddTicks(5636), "Product unit classifier: sunt", new DateTime(2020, 12, 30, 4, 25, 22, 276, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("def49799-6ea5-4661-9983-187a86e7be55"), "Iusto nam porro.", "f1c25eff-2046-4702-96aa-6079e9e994f1", new DateTime(2017, 10, 3, 21, 12, 17, 100, DateTimeKind.Local).AddTicks(7596), "Product unit classifier: quae", new DateTime(2020, 7, 22, 3, 13, 3, 723, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8cb6f06-4b15-4252-87dd-c328f0a983d9"), "Dolorem nisi facilis facere sit quod.", "d853d16c-cab2-4ce5-8501-7ca3e915503d", new DateTime(2021, 3, 30, 17, 15, 57, 69, DateTimeKind.Local).AddTicks(3105), "Product unit classifier: occaecati", new DateTime(2021, 11, 12, 13, 56, 35, 171, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eae13858-0ea8-4768-a5e1-d3a40ef533f4"), "Et aut quae modi dolorem.", "78131906-8114-4415-8a8d-1d7de0e5f260", new DateTime(2018, 2, 5, 5, 24, 43, 455, DateTimeKind.Local).AddTicks(6127), "Product unit classifier: repellat", new DateTime(2018, 11, 11, 3, 58, 3, 400, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ecdb5ef5-c967-4277-b6cc-217a4e270d99"), "Atque iste dolore ex excepturi voluptatem ipsum odio reprehenderit.", "56b2c94b-d0e0-4002-8475-b0606a783521", new DateTime(2022, 7, 6, 11, 8, 46, 964, DateTimeKind.Local).AddTicks(2), "Product unit classifier: consequuntur", new DateTime(2022, 7, 6, 17, 37, 41, 120, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eef6ea08-03c1-4a1e-9bc8-27c179a644f8"), "Reiciendis rerum vel architecto ducimus rem.", "3815c57d-625f-486c-bba5-96f23b62e8be", new DateTime(2018, 12, 14, 4, 38, 43, 885, DateTimeKind.Local).AddTicks(6968), "Product unit classifier: sunt", new DateTime(2018, 12, 29, 21, 13, 36, 390, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("efb686b0-0a2d-4f51-babb-ab7c1b039540"), "Commodi ea sint quisquam soluta est aut sapiente.", "cc81f9c4-7a78-43f5-9e67-7762ebefd79e", new DateTime(2018, 8, 23, 2, 44, 24, 913, DateTimeKind.Local).AddTicks(9212), "Product unit classifier: et", new DateTime(2021, 2, 24, 14, 11, 58, 288, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f295866d-73ef-49bd-ac9c-dc69ed4918a5"), "Sed quos quasi id dolor qui consequatur.", "2a5ba723-b2be-4258-a340-4cd6e43a01c5", new DateTime(2018, 9, 4, 20, 34, 13, 431, DateTimeKind.Local).AddTicks(3108), "Product unit classifier: voluptatem", new DateTime(2022, 3, 23, 20, 1, 9, 732, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f40cf530-361a-472e-a37f-daa913fa9133"), "Ex et consequuntur quia voluptate.", "8e0d1620-b2cc-4dbe-be14-b28dc675eb2e", new DateTime(2017, 11, 24, 16, 41, 50, 616, DateTimeKind.Local).AddTicks(1576), "Product unit classifier: perferendis", new DateTime(2020, 11, 4, 9, 47, 26, 419, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.InsertData(
                table: "ProductUnitClassifiers",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb647a75-7974-4e43-a1df-852574c0c12d"), "Nihil tempora sint voluptatem accusantium quasi.", "cbe0657f-5c20-46b7-9656-a92b775443c8", new DateTime(2017, 11, 2, 14, 24, 24, 546, DateTimeKind.Local).AddTicks(6750), "Product unit classifier: inventore", new DateTime(2021, 4, 9, 18, 41, 0, 54, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("001214da-de52-49c5-b75e-fc1bd2169937"), "Est id aliquam omnis possimus molestiae molestias.", "18d6df68-cd97-4c8f-8102-96f06b0916a2", new DateTime(2019, 12, 6, 11, 16, 46, 716, DateTimeKind.Local).AddTicks(5201), "Product unit measurement: eius", new DateTime(2021, 11, 12, 20, 25, 49, 807, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("020f32fc-ec7c-43a9-bed4-32f0e7999c97"), "Consequatur eligendi ut est est.", "8a639bc4-71c6-4d36-914a-6d927734291a", new DateTime(2020, 6, 27, 2, 55, 28, 295, DateTimeKind.Local).AddTicks(9069), "Product unit measurement: odio", new DateTime(2022, 6, 17, 8, 33, 55, 462, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("089cf186-d3d6-45be-8ab5-17f8fe797c5c"), "Veritatis dignissimos reiciendis veniam veritatis dolorem quae ut ut.", "ba7b229e-e373-481a-8fc8-f8b1580c2a4a", new DateTime(2019, 7, 5, 12, 37, 23, 430, DateTimeKind.Local).AddTicks(3522), "Product unit measurement: totam", new DateTime(2020, 2, 29, 7, 36, 21, 650, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("098ae507-b002-4a91-843a-68c31ea08e18"), "Qui iure sunt et.", "2dcbde72-0b67-4f78-87c9-82a05706983b", new DateTime(2022, 7, 4, 0, 17, 22, 633, DateTimeKind.Local).AddTicks(5216), "Product unit measurement: dolor", new DateTime(2022, 7, 4, 14, 41, 49, 218, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0aaf9344-18b3-4586-9bfc-23b335c79d89"), "Fugit repellat cumque.", "26d8845f-925d-4b84-8670-5c09ea4556b1", new DateTime(2019, 9, 29, 23, 6, 42, 285, DateTimeKind.Local).AddTicks(5426), "Product unit measurement: officia", new DateTime(2020, 4, 7, 23, 39, 36, 794, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ce68cd1-e4fd-4a9c-a10c-a878176a96a4"), "Est veritatis voluptatum fuga aut et.", "589a73e7-4065-4b44-bb0c-173412306517", new DateTime(2017, 10, 21, 23, 15, 29, 91, DateTimeKind.Local).AddTicks(4651), "Product unit measurement: in", new DateTime(2018, 7, 11, 21, 27, 19, 347, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0d73350b-73f9-4296-b21b-3df7d93940b2"), "Quaerat amet asperiores molestias quaerat officiis aliquam vitae.", "4fe37295-4897-4e0f-8ac1-28fcedef8172", new DateTime(2020, 11, 25, 17, 8, 12, 168, DateTimeKind.Local).AddTicks(3444), "Product unit measurement: iure", new DateTime(2021, 3, 2, 3, 15, 59, 325, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ee2d50d-3750-4ea0-8941-3ecca2d080f2"), "Excepturi nisi expedita aperiam itaque a dolor voluptatem cupiditate aliquid.", "ebcacc57-0267-4461-aef4-c67e5a093df0", new DateTime(2020, 4, 25, 2, 1, 19, 748, DateTimeKind.Local).AddTicks(8700), "Product unit measurement: qui", new DateTime(2021, 11, 7, 8, 58, 33, 525, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f3a8a1b-7ac9-45a3-ad99-609563d4f29b"), "Eos iure cum molestias autem tempore quisquam nesciunt.", "1b9b9a11-fb85-4d01-adca-0af30cb5d12d", new DateTime(2019, 12, 27, 7, 37, 31, 401, DateTimeKind.Local).AddTicks(8860), "Product unit measurement: fugit", new DateTime(2021, 6, 4, 5, 53, 32, 99, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11ac695b-5e00-498e-9c2c-0d6d50a42fd4"), "Id est quia.", "2b90b444-9264-45dd-b1b6-ca0c456c0691", new DateTime(2019, 9, 15, 4, 43, 47, 237, DateTimeKind.Local).AddTicks(1238), "Product unit measurement: saepe", new DateTime(2020, 7, 24, 8, 41, 10, 367, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("16e5ad38-f754-44be-8eef-5a53bf935c2f"), "Rerum qui quisquam sapiente quasi dicta illum qui nostrum.", "0868c84a-6040-4eac-8b6f-573d0143c861", new DateTime(2020, 5, 22, 5, 9, 35, 514, DateTimeKind.Local).AddTicks(4782), "Product unit measurement: reiciendis", new DateTime(2021, 12, 24, 7, 10, 37, 278, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("16f5d6d4-fac7-4247-aa67-1fddf91c97e2"), "Et et et atque molestias esse voluptatem molestiae deserunt quisquam.", "7da39a7f-7545-4e74-8c26-d46a5a0cf64f", new DateTime(2019, 9, 6, 6, 40, 38, 306, DateTimeKind.Local).AddTicks(1626), "Product unit measurement: qui", new DateTime(2019, 12, 25, 20, 5, 39, 926, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17ab91e3-1dea-4b6a-a0fa-b1e4274e2d55"), "Quibusdam sit possimus explicabo.", "6eb122cc-976b-4bcf-a583-737820c723bf", new DateTime(2017, 8, 18, 13, 44, 33, 197, DateTimeKind.Local).AddTicks(5664), "Product unit measurement: excepturi", new DateTime(2019, 4, 19, 7, 33, 26, 185, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17e4fb1c-0913-4329-bc29-9b6139334b1b"), "Enim sapiente vero.", "05a45668-e798-4e79-91dd-d4dba81e82e4", new DateTime(2021, 9, 26, 6, 16, 56, 795, DateTimeKind.Local).AddTicks(6777), "Product unit measurement: ex", new DateTime(2022, 1, 22, 10, 1, 2, 375, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19710043-7c20-4b61-8644-8db533aebb25"), "Est facilis est.", "bad0c0fb-de0e-477d-bb1b-437f9faa63ef", new DateTime(2022, 1, 3, 12, 36, 19, 395, DateTimeKind.Local).AddTicks(8693), "Product unit measurement: natus", new DateTime(2022, 2, 19, 7, 1, 35, 219, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b7b7139-d081-4c36-81b1-6887634ff882"), "Natus ut voluptate aut voluptas voluptatem suscipit.", "e545f3bb-92b8-4f9c-b997-3b95c272ed18", new DateTime(2019, 3, 23, 16, 45, 42, 241, DateTimeKind.Local).AddTicks(2506), "Product unit measurement: ut", new DateTime(2020, 4, 4, 1, 39, 51, 997, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1fe179fb-021e-4cfa-81da-cbdba02c9419"), "Adipisci corrupti voluptate voluptates aut iste.", "8e6b0bbe-b6a1-44b6-af85-a75612709d80", new DateTime(2017, 11, 13, 19, 17, 51, 444, DateTimeKind.Local).AddTicks(5403), "Product unit measurement: iste", new DateTime(2021, 12, 1, 7, 51, 22, 598, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22d3a950-1a59-408b-a3b8-27547f1be41a"), "Porro fuga aut deserunt porro porro sapiente quia.", "2200b95a-b0a2-4941-933f-fa0b9567eb5c", new DateTime(2021, 3, 5, 14, 19, 44, 491, DateTimeKind.Local).AddTicks(8907), "Product unit measurement: enim", new DateTime(2022, 4, 13, 0, 50, 57, 474, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2828bd2c-b17a-4ebc-bc85-ca47142efd8d"), "Quia atque non.", "5eab5598-5039-42d8-b275-83ef76307508", new DateTime(2021, 4, 8, 4, 54, 55, 430, DateTimeKind.Local).AddTicks(4339), "Product unit measurement: quia", new DateTime(2021, 11, 17, 22, 29, 23, 211, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("287981ac-9644-470c-8aaf-60340e8ef604"), "Tempore in eum.", "6ab6a913-7004-4d9a-ab21-24c109bbe6a3", new DateTime(2018, 7, 10, 12, 12, 52, 560, DateTimeKind.Local).AddTicks(5883), "Product unit measurement: optio", new DateTime(2021, 6, 30, 8, 41, 14, 743, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2bcc296f-b6f8-4bb1-a97a-00bffbf396f1"), "Est sint velit veniam.", "9dcdab82-9415-4e81-a619-5866b2239a31", new DateTime(2019, 9, 28, 7, 13, 15, 986, DateTimeKind.Local).AddTicks(1359), "Product unit measurement: suscipit", new DateTime(2020, 3, 25, 4, 18, 3, 184, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2eee1cc6-bd84-4e79-9d34-88b5cb1ca928"), "Iste qui iusto labore voluptatem vitae quas perspiciatis sint.", "d5d146ff-8644-4b36-9c62-06766eebb205", new DateTime(2018, 3, 28, 19, 35, 1, 605, DateTimeKind.Local).AddTicks(2491), "Product unit measurement: dolore", new DateTime(2020, 7, 15, 19, 49, 56, 735, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2fc71a85-8fa0-479f-833c-ce8a2b3b150b"), "Incidunt impedit autem voluptas iusto dolores non non sequi occaecati.", "0bd0deb3-66d5-4972-aca8-21d5904d7e8d", new DateTime(2020, 8, 25, 20, 10, 29, 628, DateTimeKind.Local).AddTicks(8101), "Product unit measurement: molestias", new DateTime(2021, 8, 2, 14, 5, 49, 870, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("352d69c6-c0e9-4c1c-b75c-cc386952f648"), "Asperiores tempora et odio cupiditate.", "4c83909c-d23a-434d-8e13-c51b92b546f3", new DateTime(2021, 12, 25, 19, 47, 32, 400, DateTimeKind.Local).AddTicks(7506), "Product unit measurement: itaque", new DateTime(2022, 5, 8, 2, 36, 16, 96, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3546bb52-a3fb-4023-9221-ae1251730702"), "A numquam maxime.", "3209ed71-ebce-4561-8bfa-e7149369d6aa", new DateTime(2021, 11, 3, 19, 37, 36, 763, DateTimeKind.Local).AddTicks(4350), "Product unit measurement: recusandae", new DateTime(2022, 6, 20, 10, 35, 30, 285, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("355f7d0e-2d4b-480e-b80c-0888c3a1d031"), "Ducimus eligendi libero aperiam unde dolorem rerum id.", "a00951ea-7b99-4587-ac3a-cb9435f3f988", new DateTime(2020, 2, 10, 2, 13, 36, 19, DateTimeKind.Local).AddTicks(2604), "Product unit measurement: facere", new DateTime(2020, 8, 3, 3, 1, 56, 930, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3bd30013-bae5-489c-831e-4f70f51e68e3"), "Eveniet ea possimus sint in voluptas id rem dolor necessitatibus.", "8a9b1ce7-2fbf-4674-b3d1-5b924257430a", new DateTime(2022, 5, 13, 9, 27, 19, 696, DateTimeKind.Local).AddTicks(2589), "Product unit measurement: quas", new DateTime(2022, 6, 24, 12, 50, 56, 152, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3dcb35de-3217-411d-8b84-cda05faf96ff"), "Voluptas sed inventore autem deserunt velit corporis repellendus sit est.", "ab208188-247c-4861-9cea-eac97197bf0a", new DateTime(2022, 7, 3, 19, 16, 27, 833, DateTimeKind.Local).AddTicks(6892), "Product unit measurement: mollitia", new DateTime(2022, 7, 5, 1, 26, 13, 482, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3e161587-3696-42aa-b626-527727dda1f8"), "Nostrum nulla deleniti aut ullam.", "5fef4631-594f-4629-aa2a-3f1eff20417e", new DateTime(2019, 10, 22, 3, 51, 56, 594, DateTimeKind.Local).AddTicks(5548), "Product unit measurement: aut", new DateTime(2020, 12, 23, 13, 46, 17, 819, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3fabf014-f273-4996-965c-31064a73b171"), "Totam dolor quisquam ex repellendus sit.", "d6f70029-18b4-4084-8e1d-5b86a5d5b948", new DateTime(2018, 9, 12, 4, 38, 8, 421, DateTimeKind.Local).AddTicks(6572), "Product unit measurement: quos", new DateTime(2021, 2, 1, 5, 5, 28, 583, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("412f2d31-c00f-4fa6-8af8-1c9733c3141b"), "Incidunt nam quibusdam.", "c9c3eb73-08ec-4a54-a8a3-71f467481f21", new DateTime(2021, 1, 12, 15, 29, 1, 674, DateTimeKind.Local).AddTicks(2077), "Product unit measurement: eligendi", new DateTime(2021, 11, 30, 12, 8, 8, 94, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42ed24d3-7eb5-456e-9422-39f634830371"), "Quidem assumenda saepe hic quae.", "6e0d7f9b-0ddc-43f3-b4e6-c0ce86530683", new DateTime(2020, 11, 14, 14, 6, 3, 541, DateTimeKind.Local).AddTicks(1033), "Product unit measurement: iste", new DateTime(2021, 2, 28, 17, 40, 55, 344, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("43ae6642-6666-4fad-b86e-b53819f515ec"), "Dolore ducimus odit ut minus doloribus explicabo velit ut.", "8d928898-2f1c-4b90-af43-55e2a3d8dcc2", new DateTime(2018, 5, 17, 15, 19, 13, 828, DateTimeKind.Local).AddTicks(2421), "Product unit measurement: voluptatem", new DateTime(2019, 5, 21, 12, 20, 45, 788, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4a7cd209-e7fd-48fa-a430-77eb4b9819e9"), "Quod consequuntur ut qui sapiente ab aut animi ut.", "e5ea0a2b-f980-4ca8-ad70-34e2683d9a18", new DateTime(2022, 5, 23, 3, 6, 25, 52, DateTimeKind.Local).AddTicks(1097), "Product unit measurement: nihil", new DateTime(2022, 6, 3, 2, 34, 51, 443, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4d62200d-3d40-4d48-9399-b7d7b4cc4e94"), "Sequi id ullam dicta dolor.", "c95199b6-eec6-46fa-92f0-190f0a5c7309", new DateTime(2022, 6, 24, 17, 17, 57, 17, DateTimeKind.Local).AddTicks(1384), "Product unit measurement: aliquid", new DateTime(2022, 7, 4, 7, 41, 6, 705, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("512becc8-b847-4a71-80f6-2f7917af15e9"), "Autem veritatis esse natus facere.", "7f3c4da5-e10f-422f-afe2-0c3bd62f20c2", new DateTime(2020, 6, 30, 23, 0, 35, 177, DateTimeKind.Local).AddTicks(6320), "Product unit measurement: recusandae", new DateTime(2020, 8, 6, 12, 31, 15, 345, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("537de258-4765-47a6-a34b-69e1a998b1b1"), "Doloribus assumenda aperiam deserunt.", "b471d9c6-8fc7-4ba7-9eec-c84c2e48ba34", new DateTime(2022, 2, 15, 1, 0, 27, 83, DateTimeKind.Local).AddTicks(1878), "Product unit measurement: rerum", new DateTime(2022, 6, 11, 9, 55, 59, 248, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5851d35f-f1bd-4f3a-a5de-6439158b1944"), "Architecto dolorum dolores excepturi consequatur.", "0033a12e-a41f-43f2-a9a2-df4850385630", new DateTime(2019, 5, 7, 6, 7, 18, 370, DateTimeKind.Local).AddTicks(8121), "Product unit measurement: omnis", new DateTime(2020, 11, 21, 13, 17, 16, 785, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59f6f34e-e286-4f4d-9116-e8cab1f57b4e"), "Omnis iste ut numquam.", "43f4d462-5ea7-43fe-a77b-6fda292305b7", new DateTime(2018, 1, 28, 8, 51, 9, 775, DateTimeKind.Local).AddTicks(3102), "Product unit measurement: ex", new DateTime(2020, 9, 6, 19, 41, 38, 152, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a9f8789-a81e-4837-9998-60ddc2d6bca4"), "Et ipsum non sunt dignissimos non unde a.", "5ba1696f-6d7c-4c8e-978a-8d73689e4c50", new DateTime(2021, 1, 7, 20, 38, 30, 893, DateTimeKind.Local).AddTicks(5557), "Product unit measurement: id", new DateTime(2022, 5, 1, 5, 53, 0, 74, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5c461b8e-de5a-4332-90c3-7e069db8501a"), "Est et dolorum aperiam quaerat rem ullam numquam reiciendis.", "1a16b806-6834-4bdf-af6d-78c283316697", new DateTime(2018, 5, 3, 19, 15, 51, 554, DateTimeKind.Local).AddTicks(5462), "Product unit measurement: dolores", new DateTime(2022, 4, 25, 9, 57, 56, 761, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d01c5a6-7b7c-4a73-906d-ed8dc0edcd00"), "Facilis cum dolorum delectus.", "6d73c045-0d97-43d4-b2b4-ee8869627838", new DateTime(2021, 3, 14, 1, 6, 9, 965, DateTimeKind.Local).AddTicks(7657), "Product unit measurement: atque", new DateTime(2022, 2, 9, 16, 57, 55, 436, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e9a319f-c54d-4c24-a687-84a645bafd89"), "Et labore tempora fugiat quia illum.", "2d91ba87-4c61-4d02-93fe-df048c3df1cc", new DateTime(2019, 11, 3, 20, 19, 56, 757, DateTimeKind.Local).AddTicks(3051), "Product unit measurement: eos", new DateTime(2020, 1, 25, 19, 28, 36, 586, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5fc561e2-f9f1-4404-9f61-1a5f39f8cefa"), "Quos aut amet et laudantium.", "7894ac6a-461c-460f-9c38-60f3c72f7a9f", new DateTime(2020, 1, 1, 13, 8, 2, 730, DateTimeKind.Local).AddTicks(9463), "Product unit measurement: sit", new DateTime(2022, 3, 3, 21, 25, 3, 936, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("60796620-3058-4ebf-a0e2-33913ce03f55"), "Doloremque esse ipsam aut maiores.", "6ad1b797-ed79-4dc3-9f05-5e038e8f2ae0", new DateTime(2019, 7, 31, 8, 44, 55, 485, DateTimeKind.Local).AddTicks(5716), "Product unit measurement: cumque", new DateTime(2021, 3, 14, 7, 15, 21, 117, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("609896d5-019e-4352-981e-8b1fa8907918"), "Qui temporibus perspiciatis et accusamus vitae voluptatem.", "1c3995e5-6c19-403c-b2ed-689222d5e941", new DateTime(2021, 7, 20, 17, 36, 46, 548, DateTimeKind.Local).AddTicks(7398), "Product unit measurement: id", new DateTime(2022, 5, 10, 23, 35, 25, 923, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("63b1a796-d0a3-46ae-8f46-110faa879c03"), "Et debitis quibusdam consequatur mollitia.", "17afdd66-7770-471f-8872-797fd2715127", new DateTime(2020, 11, 22, 9, 47, 36, 595, DateTimeKind.Local).AddTicks(9315), "Product unit measurement: esse", new DateTime(2021, 12, 12, 10, 25, 54, 65, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6529d33b-aa21-48d6-b525-34056f52b00b"), "Vitae eos non quidem nihil molestiae maxime non earum laboriosam.", "306879eb-b4fe-4c79-beba-289498bde5cc", new DateTime(2017, 8, 6, 10, 47, 23, 350, DateTimeKind.Local).AddTicks(8867), "Product unit measurement: aut", new DateTime(2019, 1, 17, 12, 48, 34, 841, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("674fc49b-8418-4b3b-a74b-87dacaa16f8d"), "Nulla ratione in fuga officiis.", "a7b56228-8bea-49a7-a5ae-4c650c09dc01", new DateTime(2021, 3, 5, 6, 42, 0, 68, DateTimeKind.Local).AddTicks(924), "Product unit measurement: corrupti", new DateTime(2022, 1, 17, 19, 59, 33, 48, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6915f332-0183-41af-a209-bf88cb3a2d83"), "Sit non voluptatem assumenda voluptatem veritatis dolores qui.", "7432c61a-a715-4902-a817-26a182a17faf", new DateTime(2018, 2, 25, 7, 52, 46, 932, DateTimeKind.Local).AddTicks(3722), "Product unit measurement: voluptatem", new DateTime(2021, 11, 16, 2, 17, 49, 968, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c0f38b0-9a0f-4a4d-b45b-c073859efbce"), "Magni aut accusamus aperiam qui et.", "217dff0d-2971-4d71-b000-af440d008876", new DateTime(2019, 7, 12, 20, 48, 9, 973, DateTimeKind.Local).AddTicks(6869), "Product unit measurement: eligendi", new DateTime(2021, 9, 1, 23, 36, 55, 717, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e8ae987-cd69-42d0-86d3-acb451b5ce59"), "Illo quia amet commodi quis.", "56437045-81c7-49eb-b2cf-f6d174cb8445", new DateTime(2018, 2, 15, 20, 44, 19, 447, DateTimeKind.Local).AddTicks(4915), "Product unit measurement: qui", new DateTime(2020, 3, 22, 9, 41, 40, 43, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("86e44433-2e02-4b3f-afa8-fb7f855109c4"), "Qui dolorum eveniet.", "22cf415c-1a7d-4989-81e4-c5fd4a9fcda4", new DateTime(2021, 3, 22, 1, 55, 27, 49, DateTimeKind.Local).AddTicks(5469), "Product unit measurement: et", new DateTime(2022, 3, 7, 13, 0, 0, 309, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8998827a-16c0-4c0c-9aaa-82e85e0e91a6"), "Ea sit incidunt iusto facere eveniet veritatis deleniti blanditiis.", "1820218e-70f1-486e-995b-1b6d60d51e37", new DateTime(2019, 5, 30, 20, 56, 12, 487, DateTimeKind.Local).AddTicks(6384), "Product unit measurement: quasi", new DateTime(2022, 2, 9, 23, 18, 14, 779, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89bffcbc-a419-460e-9d59-e751725cf1ab"), "Exercitationem neque impedit dignissimos.", "a7d2d501-3bf4-4634-a055-1714b0461630", new DateTime(2021, 5, 23, 6, 30, 40, 426, DateTimeKind.Local).AddTicks(9500), "Product unit measurement: voluptate", new DateTime(2021, 6, 21, 2, 54, 43, 903, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8c301a68-45a6-4a2e-8b1f-86138e5a7498"), "Sit nihil nemo aut enim nisi eos.", "6c6d521d-1832-452b-9184-d2362d35617a", new DateTime(2021, 10, 11, 12, 18, 43, 247, DateTimeKind.Local).AddTicks(6658), "Product unit measurement: expedita", new DateTime(2022, 3, 2, 6, 2, 14, 181, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8cb94254-59b9-4fe6-94f1-7cc4aad89f3f"), "Dolores corrupti recusandae eaque et dolorem tenetur ut velit.", "755e0ffe-24b5-4a3a-929d-7e9cae073446", new DateTime(2019, 5, 23, 17, 49, 56, 34, DateTimeKind.Local).AddTicks(8404), "Product unit measurement: asperiores", new DateTime(2020, 2, 22, 1, 57, 47, 358, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8de2d1ff-fddc-4a30-837a-8557b2865103"), "Occaecati nisi hic dolorem incidunt atque voluptatem et necessitatibus.", "1fd03d4b-e631-4fee-b806-fcbe4e984f7a", new DateTime(2019, 8, 16, 16, 49, 31, 796, DateTimeKind.Local).AddTicks(9754), "Product unit measurement: sunt", new DateTime(2020, 5, 3, 9, 19, 29, 193, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90ce8b9d-040d-4a58-9f0b-264039d1f4e5"), "Aliquid eius similique saepe nulla eos quia architecto quia.", "1dabf5a0-f60f-431b-a5ef-f63e7a1f4cca", new DateTime(2017, 12, 25, 10, 9, 51, 801, DateTimeKind.Local).AddTicks(7560), "Product unit measurement: ut", new DateTime(2022, 4, 5, 5, 56, 19, 302, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("91904f20-c56a-40c8-96a6-90586fd428dc"), "Qui assumenda tempora consectetur.", "01de9393-34c1-4fa3-b9af-ef694764e9bc", new DateTime(2018, 5, 5, 10, 6, 37, 788, DateTimeKind.Local).AddTicks(6348), "Product unit measurement: et", new DateTime(2019, 2, 22, 21, 19, 18, 1, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94db3639-408b-4524-9441-79fb3c90b1ea"), "Optio fugiat sed omnis perferendis similique amet incidunt.", "3232df76-6416-46ad-b7d0-768be0e9240c", new DateTime(2021, 3, 23, 8, 44, 53, 532, DateTimeKind.Local).AddTicks(7236), "Product unit measurement: ea", new DateTime(2021, 11, 21, 5, 5, 48, 960, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99384d58-bf75-4362-a69f-e5faeda62fc8"), "Eaque sunt rem similique aut possimus consectetur est.", "ce42f042-c652-4d44-ab74-c86ee5d51c20", new DateTime(2019, 9, 30, 5, 16, 41, 196, DateTimeKind.Local).AddTicks(8259), "Product unit measurement: qui", new DateTime(2021, 10, 31, 1, 23, 49, 620, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("99d39752-770f-455e-a35c-074be8a4e7ed"), "Nesciunt beatae ab reiciendis temporibus aperiam nisi nemo et unde.", "bf95ada3-2204-43e4-b40e-2294daa5f84c", new DateTime(2018, 4, 17, 6, 21, 47, 431, DateTimeKind.Local).AddTicks(833), "Product unit measurement: ut", new DateTime(2018, 10, 26, 22, 38, 8, 424, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a3d6c9c-17e2-4494-8939-310858a50aa1"), "Sit repellat magni vel.", "834c6b1a-ef86-4ad4-a509-655f9008c39a", new DateTime(2017, 9, 20, 10, 19, 13, 488, DateTimeKind.Local).AddTicks(3941), "Product unit measurement: culpa", new DateTime(2020, 9, 15, 8, 52, 3, 454, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a84a06e1-bd93-4f09-8434-66de05d7380b"), "Voluptatem sit quia est ut.", "893097a4-c1c8-4a67-a610-cdea23c212e6", new DateTime(2020, 11, 14, 22, 23, 28, 430, DateTimeKind.Local).AddTicks(8636), "Product unit measurement: tenetur", new DateTime(2021, 12, 29, 8, 57, 11, 135, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9a8789d-8461-4a27-9c1b-1e2575133683"), "Sit dolores dolor iusto voluptates unde omnis explicabo.", "5eb2af7a-4358-4f30-9712-dc45d949c52f", new DateTime(2020, 11, 21, 21, 22, 35, 629, DateTimeKind.Local).AddTicks(9793), "Product unit measurement: omnis", new DateTime(2021, 5, 18, 2, 32, 30, 232, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9ee5756-5ba3-45ff-8454-60e7dec5f0e9"), "Quos qui harum distinctio occaecati earum qui.", "2478f406-be41-4069-81bb-bfd2184471ee", new DateTime(2020, 11, 26, 12, 5, 30, 223, DateTimeKind.Local).AddTicks(2959), "Product unit measurement: quibusdam", new DateTime(2021, 6, 19, 0, 12, 9, 979, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad655e15-19a8-4ad5-a040-a36fec109faa"), "Ducimus quam dignissimos temporibus odit sequi doloribus.", "1bc132bb-7aa4-4ebf-9e50-7fbe0584cc6d", new DateTime(2020, 4, 11, 23, 47, 52, 390, DateTimeKind.Local).AddTicks(553), "Product unit measurement: deleniti", new DateTime(2021, 4, 17, 6, 55, 2, 743, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("afb52a11-a201-4fd5-8b00-bf5d5310fa5f"), "Qui a magnam iusto laborum odio nihil alias.", "cad3b0d9-48bd-4b68-9f3f-efc1be69e91f", new DateTime(2020, 11, 23, 21, 35, 21, 745, DateTimeKind.Local).AddTicks(4078), "Product unit measurement: suscipit", new DateTime(2022, 4, 7, 9, 14, 3, 356, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1e85253-9479-4011-a1b1-0aa0751adaa6"), "Sed praesentium dolores consequatur unde.", "80726c76-f3fa-459e-9736-6426fb0d6b3c", new DateTime(2018, 12, 4, 7, 18, 58, 807, DateTimeKind.Local).AddTicks(5567), "Product unit measurement: quia", new DateTime(2021, 3, 2, 6, 57, 11, 764, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b1ff40a9-7260-4ae6-b7f0-be7ef458856d"), "Et non omnis atque qui aperiam perspiciatis sint similique vitae.", "9d35cb89-3be0-461c-a3a6-47c808339443", new DateTime(2020, 1, 15, 16, 59, 3, 884, DateTimeKind.Local).AddTicks(5157), "Product unit measurement: itaque", new DateTime(2020, 7, 8, 5, 16, 50, 949, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b48194e9-b5b0-4ad4-adf5-1187d8116ba3"), "Eius vitae sint et at laudantium explicabo.", "28bd0361-7c46-4bbd-a34a-609809aad860", new DateTime(2018, 3, 9, 1, 10, 59, 700, DateTimeKind.Local).AddTicks(7264), "Product unit measurement: voluptas", new DateTime(2018, 4, 15, 21, 48, 20, 166, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b831bdfe-3936-4a88-8af2-22043b8bc936"), "Autem voluptatem assumenda enim veniam.", "1628412f-0e67-479b-838b-19d6f74332bc", new DateTime(2021, 8, 2, 23, 30, 25, 476, DateTimeKind.Local).AddTicks(1396), "Product unit measurement: mollitia", new DateTime(2022, 3, 31, 10, 26, 19, 813, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bccdfd03-d7bf-4c6b-90fb-4cd2a358af0d"), "Enim esse odio dicta.", "c3c2a87b-ae66-4682-a601-8216bbda4352", new DateTime(2021, 2, 20, 17, 7, 27, 698, DateTimeKind.Local).AddTicks(5688), "Product unit measurement: dolorem", new DateTime(2022, 3, 15, 2, 49, 51, 112, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd23763b-b4da-4667-857a-74a67ca4110b"), "Ab sunt recusandae reiciendis occaecati.", "eddf5912-3328-4710-88e0-883aef872a20", new DateTime(2019, 6, 11, 18, 53, 23, 626, DateTimeKind.Local).AddTicks(2360), "Product unit measurement: eos", new DateTime(2021, 10, 24, 10, 16, 43, 645, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bfa9c8f6-be46-46c1-b1a7-c84c739f02df"), "Libero quia asperiores est autem provident nobis tenetur voluptates.", "05c72638-48d2-4e2c-b095-8f1c2520c902", new DateTime(2022, 5, 15, 11, 3, 28, 575, DateTimeKind.Local).AddTicks(939), "Product unit measurement: autem", new DateTime(2022, 5, 31, 5, 50, 7, 355, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c09501e5-e408-430b-9cf0-f6890638fd08"), "Praesentium et error debitis in aut totam voluptas provident.", "4386a0f7-5365-443b-8589-bb8ddc882245", new DateTime(2020, 3, 16, 15, 48, 49, 446, DateTimeKind.Local).AddTicks(5441), "Product unit measurement: at", new DateTime(2022, 1, 19, 14, 12, 27, 989, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c221fd8a-258a-445f-a3bb-127f7d2e3a64"), "Aliquam saepe aut.", "ded1a638-89fa-4da3-8c13-bb5c57dfcbc8", new DateTime(2017, 9, 5, 21, 1, 6, 829, DateTimeKind.Local).AddTicks(1838), "Product unit measurement: et", new DateTime(2019, 6, 14, 16, 52, 50, 596, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2e91c0b-4273-49f6-8537-78c3dfe2a4df"), "Commodi autem maxime voluptate iste et voluptas iusto et.", "884bc9b4-5477-4517-ba62-fbe5b809ca32", new DateTime(2021, 12, 16, 7, 44, 10, 616, DateTimeKind.Local).AddTicks(8098), "Product unit measurement: nihil", new DateTime(2022, 1, 28, 18, 38, 7, 198, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cad1e29c-0994-48ab-bf27-8635eb12e458"), "Iure dolorum ut.", "af55c585-5401-4074-82cf-d772e2fd4c4f", new DateTime(2018, 1, 13, 15, 55, 35, 367, DateTimeKind.Local).AddTicks(2037), "Product unit measurement: voluptatem", new DateTime(2019, 1, 6, 12, 31, 56, 607, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cb4eef68-037f-4422-afba-c3f944754b06"), "Qui omnis iusto dolorum voluptatem veritatis autem qui repellendus enim.", "fb57e5ee-d815-42e9-8cec-2ec26a96400f", new DateTime(2018, 6, 3, 19, 26, 28, 106, DateTimeKind.Local).AddTicks(5746), "Product unit measurement: vitae", new DateTime(2019, 4, 28, 17, 22, 1, 310, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cdbcb8cc-fecc-47b8-bc1f-831a8a272d0d"), "Repellendus deserunt laboriosam molestiae qui molestiae nam dolorem voluptates blanditiis.", "56fd6697-d1ff-462e-baf4-b2c06960aeeb", new DateTime(2017, 10, 20, 13, 47, 53, 522, DateTimeKind.Local).AddTicks(9581), "Product unit measurement: qui", new DateTime(2019, 12, 27, 0, 18, 52, 64, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ce6004f7-8a5c-4871-a3b2-384d3281aa11"), "Explicabo sint voluptatem est consequatur.", "d712ad35-962b-4519-bf61-3b1bebcfbc75", new DateTime(2020, 5, 16, 0, 37, 58, 211, DateTimeKind.Local).AddTicks(4909), "Product unit measurement: fuga", new DateTime(2020, 8, 19, 9, 43, 12, 760, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d44593f4-1847-47bc-b39b-133783d75a1e"), "Fugit error ut.", "20728195-6100-41a0-b726-b5174e9ac390", new DateTime(2017, 12, 5, 13, 33, 22, 514, DateTimeKind.Local).AddTicks(3616), "Product unit measurement: voluptatibus", new DateTime(2020, 4, 13, 16, 11, 49, 197, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7fe7cd5-f7fe-4516-b871-8c11351ca025"), "Vel placeat voluptatem dolor aperiam.", "e4373ea2-9bb4-4592-9f89-f6e8a63c51a7", new DateTime(2019, 5, 8, 2, 51, 46, 133, DateTimeKind.Local).AddTicks(7480), "Product unit measurement: numquam", new DateTime(2021, 3, 19, 20, 5, 2, 22, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d97151a3-440d-4f53-9984-6b418e36f2ee"), "Dolorem illum libero adipisci qui in quos quisquam eligendi quo.", "56164043-b83c-4db3-9714-70d1bcebcfeb", new DateTime(2017, 10, 9, 11, 44, 45, 510, DateTimeKind.Local).AddTicks(6052), "Product unit measurement: totam", new DateTime(2019, 3, 10, 20, 13, 59, 137, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dc66765c-d93e-483b-a5ae-a00563590960"), "Ab tempore perspiciatis commodi cum.", "b81db063-ec9e-4fa8-81a4-1fbc025eee5c", new DateTime(2017, 8, 22, 8, 38, 44, 898, DateTimeKind.Local).AddTicks(1672), "Product unit measurement: deserunt", new DateTime(2017, 12, 11, 12, 9, 0, 763, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dccfab5a-c3cd-4ad3-a6f7-b913492e2de1"), "Vitae reiciendis corrupti asperiores ut repudiandae ut accusantium.", "4d412e93-0534-4166-85da-a8cef9b2330d", new DateTime(2018, 3, 15, 11, 47, 29, 272, DateTimeKind.Local).AddTicks(324), "Product unit measurement: sequi", new DateTime(2021, 2, 14, 13, 9, 44, 489, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ddc59af5-ae8c-44cf-8f61-26d98e0264e4"), "Rem dignissimos et voluptates et qui inventore.", "32d426f0-ec7e-46ab-949b-b42a21e88841", new DateTime(2021, 12, 27, 18, 12, 56, 625, DateTimeKind.Local).AddTicks(4559), "Product unit measurement: deserunt", new DateTime(2022, 5, 11, 14, 18, 42, 636, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dfcf7a56-e7a3-4961-bae7-16ef9b061738"), "Iste non dolorem consequuntur doloremque perspiciatis dolorem.", "401c94a3-d4ae-414b-bf69-2ab5f9d1fa17", new DateTime(2020, 9, 2, 0, 2, 0, 912, DateTimeKind.Local).AddTicks(5734), "Product unit measurement: incidunt", new DateTime(2021, 6, 8, 15, 50, 24, 354, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dfd22127-26e0-4430-a62b-2d25773ea98d"), "Quia qui non culpa nobis.", "9f5085f0-e909-4eeb-ab0d-94516bd4e7d2", new DateTime(2018, 8, 23, 17, 58, 34, 131, DateTimeKind.Local).AddTicks(5432), "Product unit measurement: dignissimos", new DateTime(2021, 8, 17, 18, 27, 31, 343, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dfd6ed25-d1cb-4715-af64-e6eb20234d53"), "Earum eligendi quidem voluptatibus sed culpa non eveniet eum.", "71245f22-9b48-4589-bb80-3962ceb48e62", new DateTime(2021, 5, 19, 2, 46, 54, 418, DateTimeKind.Local).AddTicks(3518), "Product unit measurement: quibusdam", new DateTime(2022, 4, 18, 14, 31, 10, 775, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eb1ac618-af54-4984-8637-e156053a3054"), "Deserunt id molestiae in voluptatem sed odio cumque.", "8bb2aa65-0166-4a01-97e6-8c6a68d614c0", new DateTime(2021, 8, 21, 7, 56, 21, 564, DateTimeKind.Local).AddTicks(4307), "Product unit measurement: fugiat", new DateTime(2022, 4, 6, 23, 2, 11, 389, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec278943-6362-4106-9bab-839cd7519d14"), "In ab id molestiae et blanditiis optio dolorem ipsum et.", "987ddc33-b880-486c-9242-d1dd844af5dc", new DateTime(2017, 11, 25, 7, 48, 22, 745, DateTimeKind.Local).AddTicks(1523), "Product unit measurement: in", new DateTime(2020, 7, 6, 22, 8, 8, 953, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ecb06034-5792-4289-9c7e-719530210330"), "Nobis eos perferendis nesciunt tempora minus.", "b9d317af-f57f-4524-905f-a2c1f370ecff", new DateTime(2019, 2, 25, 12, 2, 8, 231, DateTimeKind.Local).AddTicks(6876), "Product unit measurement: quia", new DateTime(2020, 12, 16, 15, 31, 28, 49, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee5762d8-44b3-4198-9c56-d4549925ccb1"), "Eos voluptas deserunt qui.", "1c914c30-e03e-4663-97d9-ab9450005391", new DateTime(2021, 8, 18, 22, 12, 10, 855, DateTimeKind.Local).AddTicks(3243), "Product unit measurement: porro", new DateTime(2022, 4, 14, 22, 32, 8, 240, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f131a7ed-d4b0-451a-8dba-259ef27e2bc3"), "Velit corporis earum laborum est accusantium.", "96a47b9c-2011-4c6f-99f7-271aacf86f4a", new DateTime(2019, 8, 12, 19, 32, 43, 62, DateTimeKind.Local).AddTicks(7713), "Product unit measurement: est", new DateTime(2022, 6, 2, 5, 21, 18, 400, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f53b1e9e-d2ac-475e-b696-66863949e571"), "Dolores modi totam non.", "c02c6ff2-fecb-4668-a87e-9c9bbfbaaeb8", new DateTime(2019, 3, 30, 0, 31, 37, 844, DateTimeKind.Local).AddTicks(8182), "Product unit measurement: soluta", new DateTime(2021, 2, 28, 2, 57, 10, 554, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f72de707-9b00-4d80-b550-819d57a8ff33"), "Fuga tempore similique enim ea explicabo rerum porro perferendis.", "708f09c9-dde5-49e0-a900-d982d44edc82", new DateTime(2021, 5, 16, 16, 17, 42, 489, DateTimeKind.Local).AddTicks(2022), "Product unit measurement: culpa", new DateTime(2021, 11, 6, 22, 24, 44, 810, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.InsertData(
                table: "ProductUnitMeasuraments",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7ea7e2c-8934-4cbe-8a01-52617dec3972"), "Magni incidunt et nesciunt neque ea ratione.", "c3869ad9-c85b-4ae7-8271-2bae02fc694f", new DateTime(2018, 12, 7, 13, 40, 4, 949, DateTimeKind.Local).AddTicks(4406), "Product unit measurement: quo", new DateTime(2021, 7, 4, 0, 40, 13, 736, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0032ffd7-4249-42ba-abe8-aedcacd844b5"), "Voluptatum maiores non.", "a5698d9c-1ed8-46e8-a6aa-d6ab947134e5", new DateTime(2018, 3, 3, 6, 28, 7, 592, DateTimeKind.Local).AddTicks(4081), "Storage: at", new DateTime(2021, 2, 15, 12, 14, 32, 248, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01ee846b-63a5-4225-bffe-9db1d5d2c350"), "Est aut molestias odio totam.", "cd448c5e-124d-46cd-9faf-69ee8065118d", new DateTime(2021, 4, 13, 12, 3, 29, 646, DateTimeKind.Local).AddTicks(9751), "Storage: recusandae", new DateTime(2022, 5, 2, 5, 46, 6, 633, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("045ff820-02e1-4aba-b941-851950f06d0c"), "Qui consectetur et ad odio esse quisquam saepe.", "63cf4587-607f-4a07-8534-2e38e43c2df4", new DateTime(2020, 3, 4, 13, 20, 34, 689, DateTimeKind.Local).AddTicks(5224), "Storage: vero", new DateTime(2020, 7, 2, 16, 45, 37, 750, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0629ffef-3581-4c65-ba8a-37994abd7be4"), "Quia asperiores delectus officia sequi et ut.", "0101e3c7-85ec-4e99-a324-df7b6d18b68c", new DateTime(2020, 10, 11, 23, 43, 8, 281, DateTimeKind.Local).AddTicks(4717), "Storage: voluptate", new DateTime(2021, 9, 30, 5, 57, 18, 413, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("066cfd25-e3b6-4c2b-8218-b34c4fd19014"), "Quibusdam corporis maxime ipsa ratione.", "aeed63a2-ef6f-4daf-a2f4-4b205dd6312d", new DateTime(2020, 10, 7, 16, 59, 4, 756, DateTimeKind.Local).AddTicks(9820), "Storage: earum", new DateTime(2020, 12, 26, 20, 32, 48, 10, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("06c27e64-d8fb-4065-8a42-52b318d41cad"), "Vel vero architecto et natus sunt perferendis.", "22d20f12-0ebd-435e-ad56-ad5f222147e6", new DateTime(2022, 6, 23, 1, 58, 42, 908, DateTimeKind.Local).AddTicks(2542), "Storage: et", new DateTime(2022, 6, 29, 13, 38, 37, 512, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07da3221-e189-457b-a213-191bb82c7539"), "Sit et est sint qui necessitatibus.", "19dfe91f-3219-4f9d-99f4-1c597d84b3ad", new DateTime(2020, 9, 27, 13, 31, 33, 570, DateTimeKind.Local).AddTicks(6426), "Storage: quam", new DateTime(2022, 1, 27, 1, 56, 18, 8, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a553a01-72ba-453d-b48e-050b03343ee8"), "Inventore sed quos et rem ipsam repellendus.", "63dbc41f-8500-44b1-b7f2-87e9f5b104ca", new DateTime(2021, 10, 17, 2, 26, 38, 637, DateTimeKind.Local).AddTicks(3804), "Storage: qui", new DateTime(2021, 12, 15, 17, 53, 26, 544, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0afd1b45-362d-4bb5-9034-473e3130f785"), "Veritatis tempore nisi optio ut quas autem aliquam laborum.", "c65cef31-9fe8-425d-9f16-5f51dbd8f951", new DateTime(2018, 11, 20, 13, 23, 52, 855, DateTimeKind.Local).AddTicks(6111), "Storage: deleniti", new DateTime(2019, 5, 29, 14, 48, 1, 341, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0dac62eb-544c-4006-bd99-907d8de60681"), "Libero deserunt dolores et ut odio.", "7627edc0-ebfe-4714-8127-57a326afb969", new DateTime(2019, 8, 6, 8, 55, 33, 393, DateTimeKind.Local).AddTicks(3355), "Storage: ut", new DateTime(2020, 6, 10, 1, 29, 47, 222, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0db249a2-0db0-4ef2-a6ad-8b481ec286ce"), "Eius aliquam aspernatur eum beatae corporis aspernatur neque sint.", "ac7322da-1b26-4a0d-8903-bde4d6885a83", new DateTime(2022, 5, 16, 1, 25, 40, 441, DateTimeKind.Local).AddTicks(7420), "Storage: quod", new DateTime(2022, 6, 20, 23, 52, 13, 249, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12c8e231-91c9-40c3-96e8-095b3da13b6c"), "Illo iusto in nobis.", "2d9e4bfc-af69-4ae0-a616-ab4675f8e2e0", new DateTime(2022, 3, 18, 11, 50, 42, 89, DateTimeKind.Local).AddTicks(3688), "Storage: cupiditate", new DateTime(2022, 7, 5, 11, 32, 44, 765, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("154b6dc3-d32f-453c-8160-66b2c3ad2a7f"), "Cupiditate quibusdam perspiciatis architecto quas nulla aliquam accusantium.", "5d72dda8-d663-4895-8561-56b152c160b0", new DateTime(2020, 10, 5, 7, 31, 21, 879, DateTimeKind.Local).AddTicks(932), "Storage: quia", new DateTime(2021, 3, 5, 17, 17, 33, 77, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("188af721-99c4-4d0d-ae93-db2f34d411bf"), "Adipisci officiis quam eos officiis laboriosam molestias.", "0da3b344-06a1-46df-9736-5863656059b6", new DateTime(2019, 2, 17, 14, 20, 52, 793, DateTimeKind.Local).AddTicks(2160), "Storage: consectetur", new DateTime(2020, 4, 13, 11, 26, 17, 855, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b347e2e-2f92-438d-811d-d61fa14859f3"), "Qui quis quo rerum.", "1ff2d84e-2807-4a99-a745-96858a71edc6", new DateTime(2019, 6, 9, 1, 49, 26, 782, DateTimeKind.Local).AddTicks(9105), "Storage: consequatur", new DateTime(2020, 12, 9, 16, 31, 38, 791, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1bd048da-5de3-437a-9032-ef18ce44add5"), "Et voluptatem distinctio ea.", "c33a3a9e-63f8-4d88-a0de-df581fd5d206", new DateTime(2018, 12, 7, 6, 46, 13, 259, DateTimeKind.Local).AddTicks(8307), "Storage: est", new DateTime(2019, 6, 5, 14, 20, 17, 998, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1beb53eb-9f59-45df-b0aa-64e0cee18f2a"), "Id nulla unde exercitationem reiciendis quam molestias libero.", "eca2dd2b-47e3-400d-80d8-b3c25660f0d9", new DateTime(2018, 2, 10, 10, 30, 25, 456, DateTimeKind.Local).AddTicks(4692), "Storage: corporis", new DateTime(2020, 9, 6, 15, 1, 16, 767, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c4ec5d4-91d5-4d7a-bb16-df5d8ee8cae9"), "Vel perferendis tempora adipisci.", "86186674-ba84-4d5f-bb5a-b94a3b0d60b9", new DateTime(2019, 1, 9, 0, 17, 30, 129, DateTimeKind.Local).AddTicks(1754), "Storage: aut", new DateTime(2020, 1, 22, 22, 13, 7, 850, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("21ba9d5d-d77b-491f-ad22-f7116669f3a4"), "Mollitia optio maxime qui incidunt qui hic illo sed quas.", "bc60da16-adb4-4987-885d-62c3158fcf57", new DateTime(2022, 5, 25, 19, 37, 21, 304, DateTimeKind.Local).AddTicks(6577), "Storage: in", new DateTime(2022, 5, 30, 0, 42, 44, 542, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("22e4306e-ac4f-41c1-81ed-f382ce3a1f72"), "Quibusdam ut vel.", "fdd3e2a3-3da1-4ea1-afb2-c4cd5be0eda2", new DateTime(2021, 8, 18, 22, 14, 8, 677, DateTimeKind.Local).AddTicks(7235), "Storage: id", new DateTime(2021, 10, 22, 23, 32, 58, 751, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("242fd958-a1cb-4a7e-a22a-17326aa59235"), "Dolorem et nulla.", "b507f436-adbd-4817-b209-c814f0fc2b45", new DateTime(2018, 2, 14, 19, 37, 52, 549, DateTimeKind.Local).AddTicks(859), "Storage: corrupti", new DateTime(2021, 11, 9, 2, 22, 11, 398, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26bb3ea5-5d2c-4cd6-9a38-3d9e8c8f9f7c"), "Sint sed aspernatur voluptatibus fuga.", "c0f032b4-4c4f-4193-b2fb-804158f1a1d0", new DateTime(2021, 6, 27, 14, 48, 39, 795, DateTimeKind.Local).AddTicks(1502), "Storage: unde", new DateTime(2021, 10, 22, 15, 35, 0, 649, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("28b4b296-7253-4328-b80f-1b31c24a4efd"), "Voluptatem consequatur et.", "2718064f-384c-41f7-811e-a84b00367ebf", new DateTime(2020, 2, 19, 15, 39, 14, 756, DateTimeKind.Local).AddTicks(5616), "Storage: sed", new DateTime(2021, 1, 6, 19, 58, 28, 667, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2b795e27-2920-4264-b8a6-2ad096eeae6d"), "Porro aliquam error velit unde voluptas nesciunt consequatur aperiam blanditiis.", "bfe4e57b-8f85-452c-8a53-05ec7feeb524", new DateTime(2017, 12, 5, 23, 56, 0, 381, DateTimeKind.Local).AddTicks(1845), "Storage: et", new DateTime(2020, 8, 26, 18, 41, 31, 413, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("334c5f38-8998-4ef9-8042-036581374798"), "Possimus earum enim quidem quo.", "c421b619-885c-4960-88dc-e8b65e7cdfc3", new DateTime(2018, 8, 28, 12, 38, 14, 645, DateTimeKind.Local).AddTicks(1787), "Storage: ipsa", new DateTime(2020, 4, 8, 8, 28, 50, 204, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("355962ad-ceea-4e3b-aed1-8c3708a047f8"), "Delectus vel voluptatem sunt consectetur est inventore repudiandae nihil.", "4382f08e-2a48-4cde-abcc-08bc613358bc", new DateTime(2019, 3, 22, 20, 45, 20, 698, DateTimeKind.Local).AddTicks(6678), "Storage: deserunt", new DateTime(2020, 11, 14, 3, 39, 38, 456, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35dd3922-009f-4be5-87fb-b71fcc720921"), "Porro quisquam assumenda et quis.", "5cf35a71-7ce2-4600-ad02-64d6b73b6487", new DateTime(2018, 9, 8, 19, 7, 15, 172, DateTimeKind.Local).AddTicks(2696), "Storage: eum", new DateTime(2020, 11, 20, 4, 16, 7, 458, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("367d67be-495f-44d6-86fe-3941ace45a13"), "Tenetur accusamus consequatur ea atque maiores quis itaque voluptatibus eum.", "b3586fb2-bcb6-4265-9341-08174d0fbe56", new DateTime(2019, 5, 27, 11, 56, 38, 437, DateTimeKind.Local).AddTicks(6155), "Storage: ipsum", new DateTime(2019, 10, 21, 6, 12, 13, 234, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a7c7182-de60-4db5-9a38-a6c7c1066ab9"), "A voluptatem rem dolores sit cupiditate maiores.", "8e1303cf-9e30-4f72-b14e-0329a11c8619", new DateTime(2020, 1, 22, 5, 35, 51, 37, DateTimeKind.Local).AddTicks(6920), "Storage: est", new DateTime(2020, 11, 1, 15, 13, 25, 231, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a9569ac-9f9b-4ffa-9551-4e9b12580e00"), "Numquam qui beatae.", "9032611a-97d9-41b3-85d3-a480b3f8f8bc", new DateTime(2022, 6, 5, 22, 57, 32, 591, DateTimeKind.Local).AddTicks(1797), "Storage: quo", new DateTime(2022, 7, 4, 15, 31, 10, 410, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d1a240b-95ae-49a6-b3d0-0c7a91a52f3f"), "Eos adipisci non aspernatur dolor cumque.", "53c22a9d-a25e-4c54-972e-ecae356a8028", new DateTime(2018, 6, 16, 2, 57, 15, 609, DateTimeKind.Local).AddTicks(2223), "Storage: rerum", new DateTime(2018, 6, 26, 10, 12, 59, 708, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d3ea794-dbef-4d92-b6a4-f4f6702311ab"), "Asperiores eum expedita.", "2947773e-8ad5-4d2d-9c81-0892dfa5b558", new DateTime(2018, 2, 22, 6, 33, 50, 90, DateTimeKind.Local).AddTicks(8219), "Storage: et", new DateTime(2019, 5, 13, 16, 52, 47, 853, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4017cbee-04f2-45ec-b73b-bb407caa5eb9"), "Animi non non aut culpa.", "a0dd334a-c586-4930-9771-9eb6af20cb6e", new DateTime(2017, 9, 26, 22, 5, 27, 422, DateTimeKind.Local).AddTicks(8761), "Storage: maiores", new DateTime(2018, 4, 25, 21, 7, 57, 275, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("407e7a8f-2bc8-467b-9f40-73cfbca50576"), "In et ut facilis iure et.", "30c7ca6e-b26e-4a6f-b624-45276f437675", new DateTime(2018, 6, 11, 18, 17, 11, 449, DateTimeKind.Local).AddTicks(5539), "Storage: sit", new DateTime(2020, 6, 26, 5, 19, 10, 984, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("40b0cf79-936b-4c8d-a789-59d95b47aac2"), "Eaque reiciendis quae nesciunt.", "ec9339b5-3480-47ac-a559-9c9b86247248", new DateTime(2019, 11, 23, 17, 1, 39, 775, DateTimeKind.Local).AddTicks(6989), "Storage: et", new DateTime(2020, 9, 5, 2, 11, 23, 409, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("45826bd3-795b-40c1-b979-67b560c08a6d"), "Accusantium quaerat nam laborum rerum qui iste dolores porro eaque.", "9bf2ccf0-5b52-45da-8f51-f29982d87cba", new DateTime(2022, 6, 29, 6, 43, 45, 291, DateTimeKind.Local).AddTicks(3392), "Storage: dolorum", new DateTime(2022, 7, 2, 19, 5, 42, 116, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4787abb4-7a02-4d7e-8cde-9b1787ba48e3"), "Temporibus nihil tempora neque rerum eaque eum et.", "bcca705e-2a9d-4b0e-91fa-e733234129f9", new DateTime(2018, 10, 9, 21, 11, 22, 773, DateTimeKind.Local).AddTicks(8516), "Storage: magni", new DateTime(2019, 2, 26, 7, 51, 33, 122, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f547c38-06a0-4435-b71e-c275f95a20da"), "Ut et assumenda maiores et accusantium possimus ratione facilis.", "c388c205-1fb8-4793-908a-c08d6ff5b29b", new DateTime(2021, 5, 30, 12, 2, 14, 225, DateTimeKind.Local).AddTicks(4815), "Storage: minus", new DateTime(2022, 3, 21, 17, 8, 1, 637, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f8752c7-3d16-414e-a487-d8679d7a66be"), "Aliquam ipsa voluptatem est vel laudantium quos quam.", "04c5ac98-f8a9-43dc-916a-6f16b12e3fb9", new DateTime(2020, 3, 11, 16, 3, 49, 81, DateTimeKind.Local).AddTicks(6930), "Storage: consequatur", new DateTime(2021, 12, 9, 23, 40, 50, 297, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4fefaf3a-0c4e-4bdc-9c9b-12ec3bf11a4a"), "Porro et ut enim.", "0ef4beb1-a8b4-408d-a9b3-c38b492d1abd", new DateTime(2018, 2, 7, 3, 35, 23, 308, DateTimeKind.Local).AddTicks(8890), "Storage: porro", new DateTime(2020, 10, 2, 23, 40, 40, 535, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("52021c94-00aa-4946-bb68-854815534fea"), "Voluptate voluptatum amet error est ut est velit ut rerum.", "8b09c33d-26c7-4049-90e7-11139cd9c0c8", new DateTime(2020, 3, 15, 8, 13, 51, 312, DateTimeKind.Local).AddTicks(5848), "Storage: tempora", new DateTime(2021, 8, 30, 3, 31, 9, 641, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59e31264-89cd-471a-a373-326bc716a6c3"), "Et repudiandae sed esse culpa.", "3774e1dc-22b5-479a-80cc-5339a61cfa46", new DateTime(2021, 8, 18, 2, 45, 45, 358, DateTimeKind.Local).AddTicks(3140), "Storage: hic", new DateTime(2022, 3, 2, 12, 9, 15, 169, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a70c924-a5b1-4760-9744-be7f6dc19519"), "Autem ea fugiat quia.", "17dbbc46-e22a-4498-826d-cdc9d3330eb6", new DateTime(2017, 9, 1, 12, 32, 39, 793, DateTimeKind.Local).AddTicks(4067), "Storage: maiores", new DateTime(2018, 6, 30, 11, 26, 34, 93, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b3a3eaa-7bab-4d31-bee8-23a3d99ecfd2"), "Aut quis optio eum.", "08506b42-41cb-478f-bd34-d809c0dbeb82", new DateTime(2018, 4, 2, 14, 19, 34, 886, DateTimeKind.Local).AddTicks(4534), "Storage: optio", new DateTime(2021, 4, 11, 6, 34, 5, 675, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b5adbc6-b651-4577-81e6-c298ad683a2a"), "Ut nihil harum tenetur qui expedita beatae adipisci veritatis.", "81a2e620-1d29-43a0-97ff-3f6c8baf3391", new DateTime(2022, 1, 25, 20, 5, 38, 585, DateTimeKind.Local).AddTicks(1815), "Storage: sit", new DateTime(2022, 6, 23, 15, 26, 23, 342, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5b8d1bb7-217d-48c5-9493-3dac2e314ecc"), "Asperiores repellendus est facere culpa aut veritatis nostrum fugit eum.", "2322d3f1-7b4c-4c36-96bf-c8ac50e11ac9", new DateTime(2018, 1, 17, 23, 16, 23, 571, DateTimeKind.Local).AddTicks(9156), "Storage: velit", new DateTime(2018, 11, 20, 17, 0, 44, 538, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d00e1cf-4fc3-470b-b974-f3db7efa1de2"), "Officiis minus et totam enim consequatur at perspiciatis.", "2a613a3d-83ae-4790-b116-e3f6e6514e53", new DateTime(2018, 6, 4, 15, 35, 47, 697, DateTimeKind.Local).AddTicks(3165), "Storage: ut", new DateTime(2019, 4, 5, 8, 58, 20, 295, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5ff29308-3081-497b-ab5e-bdc8df2ef211"), "Ea voluptas expedita id soluta quisquam adipisci recusandae qui consectetur.", "39c77b6e-b83b-40db-9fef-a2d28c11e125", new DateTime(2018, 6, 8, 3, 35, 14, 289, DateTimeKind.Local).AddTicks(4086), "Storage: at", new DateTime(2019, 12, 7, 17, 52, 34, 650, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("611ef658-d107-4fe4-ad19-b401627ed931"), "Libero autem aut aperiam voluptates incidunt reiciendis modi accusantium ea.", "22e0789f-e56a-4584-802d-853196f572b2", new DateTime(2021, 4, 24, 4, 59, 51, 499, DateTimeKind.Local).AddTicks(7904), "Storage: qui", new DateTime(2022, 3, 14, 3, 59, 16, 374, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("665def44-5ae0-457a-8851-8e4e65a15bd8"), "Enim provident et ullam rerum aliquam.", "6c18ac3b-3d22-47fa-94f7-000487a249bd", new DateTime(2020, 3, 31, 11, 17, 17, 121, DateTimeKind.Local).AddTicks(4807), "Storage: reiciendis", new DateTime(2020, 9, 12, 8, 46, 24, 621, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6caba233-7533-46fc-8658-906b9c9dc4a9"), "Consectetur magnam accusamus esse velit autem.", "1ddaea45-565b-423b-91f2-0357d31ffad4", new DateTime(2017, 7, 9, 13, 49, 56, 471, DateTimeKind.Local).AddTicks(6574), "Storage: placeat", new DateTime(2022, 1, 29, 5, 49, 4, 507, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6f8a13b3-e9dc-4d48-963a-e8f052c462c3"), "Vel atque earum non ducimus.", "43dd48a5-2bb1-45eb-8794-9811100ce797", new DateTime(2021, 4, 8, 1, 22, 2, 902, DateTimeKind.Local).AddTicks(3813), "Storage: et", new DateTime(2021, 8, 19, 6, 58, 5, 500, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6fcf53a0-2ee6-4e21-ba4a-d5861b507010"), "Tempore incidunt sit ut quasi ut sed illum modi sapiente.", "0ae7f4cb-6b9a-413a-af99-54be1828288b", new DateTime(2018, 2, 1, 14, 42, 3, 266, DateTimeKind.Local).AddTicks(5850), "Storage: alias", new DateTime(2020, 7, 18, 15, 5, 55, 171, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6fd3c9c9-9de3-428b-9aab-8b8d428a28d5"), "Est deleniti quisquam omnis nihil.", "adc3c455-d15e-4529-b293-98cfe9f7c7af", new DateTime(2020, 2, 11, 2, 25, 11, 132, DateTimeKind.Local).AddTicks(7802), "Storage: assumenda", new DateTime(2020, 2, 24, 23, 52, 59, 470, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("713291a1-5ffd-4e7a-88b8-22d93de2c840"), "Corrupti sed ipsum dignissimos est sunt perferendis officiis.", "25f27bc1-54a6-4009-b59e-80818bd09c7b", new DateTime(2020, 9, 10, 11, 0, 24, 736, DateTimeKind.Local).AddTicks(8039), "Storage: accusamus", new DateTime(2022, 6, 7, 2, 21, 16, 713, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72fe0fff-ce0f-41b6-a1c2-e1229b196ebd"), "Fugit labore ipsa asperiores suscipit ipsam fugiat consequatur aliquid temporibus.", "d31e1daa-e4ca-40e2-8170-78bc79f33b4a", new DateTime(2021, 8, 2, 1, 19, 17, 891, DateTimeKind.Local).AddTicks(829), "Storage: omnis", new DateTime(2021, 9, 26, 12, 41, 26, 288, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74027bf4-83dd-4457-bd0e-5446aa756eb2"), "Earum nam explicabo odio aut autem.", "9e46b45b-36b0-4a50-99a0-a2731ecd1d64", new DateTime(2019, 2, 16, 18, 30, 59, 777, DateTimeKind.Local).AddTicks(9701), "Storage: quasi", new DateTime(2019, 7, 20, 17, 12, 39, 665, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("74736d66-9a9b-4fd3-980d-4829455faa0b"), "Vel laborum impedit et molestiae dolore suscipit iure.", "908152d0-5c89-4e95-ada3-b4874d9345dd", new DateTime(2018, 3, 13, 20, 38, 10, 793, DateTimeKind.Local).AddTicks(8314), "Storage: quia", new DateTime(2019, 7, 16, 7, 26, 57, 346, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77524452-8d74-4eba-90b1-a4ebda552a24"), "Modi quo rerum necessitatibus id rem voluptas debitis impedit quia.", "2653752f-7aed-45c9-bf01-3e2371c7d2f4", new DateTime(2019, 4, 21, 1, 15, 1, 406, DateTimeKind.Local).AddTicks(5913), "Storage: autem", new DateTime(2019, 8, 21, 22, 7, 15, 848, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77a1ba96-7d84-48e3-a7ca-3a1666f7851a"), "Consectetur repellat nobis autem nihil nihil.", "75c043d2-42c8-40e3-bbcf-e5a6cd598c5f", new DateTime(2022, 6, 20, 10, 36, 25, 689, DateTimeKind.Local).AddTicks(1436), "Storage: dicta", new DateTime(2022, 7, 1, 18, 50, 54, 624, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7979a11c-67dc-4a36-9003-beb3bc3096fb"), "Veritatis dolore voluptates expedita eaque sint est at.", "f7e9f70c-97cd-47df-8e38-a4c57a174bd7", new DateTime(2022, 2, 17, 5, 18, 29, 976, DateTimeKind.Local).AddTicks(1360), "Storage: repudiandae", new DateTime(2022, 3, 8, 15, 4, 10, 917, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7ad08a91-2692-4a2d-8d56-a73065038643"), "Qui sapiente qui reprehenderit sed iusto aut.", "31c8fc14-3c85-4917-be86-1900143478f8", new DateTime(2021, 10, 10, 19, 57, 32, 120, DateTimeKind.Local).AddTicks(5886), "Storage: veritatis", new DateTime(2021, 11, 4, 18, 55, 5, 881, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7f7dfac2-d253-461a-937d-f2cee2e1eef1"), "Vel voluptatem vitae dolor labore et possimus sed.", "ddd8f560-9249-42c2-a601-60f03244bb4e", new DateTime(2018, 5, 11, 0, 54, 53, 928, DateTimeKind.Local).AddTicks(5730), "Storage: et", new DateTime(2019, 9, 22, 4, 44, 14, 492, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("829f23ea-64ac-4355-90d9-8c4ac13c3732"), "Quos rerum perferendis ipsum.", "92e71b6c-7f8a-4b46-88a8-c38a4ae79eb5", new DateTime(2018, 8, 19, 19, 40, 52, 993, DateTimeKind.Local).AddTicks(5620), "Storage: itaque", new DateTime(2021, 11, 29, 7, 24, 48, 52, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("82c3fd22-e8da-4952-bd16-bed8cf0d0062"), "Eveniet eveniet voluptas praesentium explicabo et.", "d581bc96-a15b-4f44-a51d-912d152682ff", new DateTime(2022, 4, 1, 21, 33, 8, 672, DateTimeKind.Local).AddTicks(218), "Storage: consequatur", new DateTime(2022, 4, 3, 20, 5, 28, 565, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("84d1e1d3-e344-4a31-a77d-3506356f60e1"), "Id nemo fugiat.", "e6399774-87d5-4340-9268-e36bdd503011", new DateTime(2019, 4, 8, 16, 35, 47, 671, DateTimeKind.Local).AddTicks(4905), "Storage: quia", new DateTime(2020, 4, 18, 18, 13, 46, 565, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8bb73b93-147c-4651-99be-f271ff21320b"), "Cupiditate iure eius sequi.", "9e449bbe-2b50-42df-aeb4-e902f011e281", new DateTime(2018, 4, 8, 14, 56, 7, 151, DateTimeKind.Local).AddTicks(1092), "Storage: ex", new DateTime(2019, 8, 24, 19, 1, 34, 321, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("924b9690-a1cb-44c5-a295-ebdb0adac61c"), "Cum laboriosam sed ex animi natus dolorum.", "d0626140-26a3-4a54-bf46-63a84e5bc632", new DateTime(2022, 1, 7, 9, 39, 19, 334, DateTimeKind.Local).AddTicks(5464), "Storage: aut", new DateTime(2022, 6, 8, 20, 44, 47, 652, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("970117af-732c-4f34-9b53-614003dcd683"), "Eaque consequatur illum id.", "966d9062-0f8c-4668-9ce9-92c6e3f43c30", new DateTime(2019, 9, 17, 5, 34, 19, 988, DateTimeKind.Local).AddTicks(3203), "Storage: sint", new DateTime(2022, 5, 17, 16, 40, 1, 761, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9d2677ad-fd84-4b78-8ff6-80db71022349"), "Repellendus quis excepturi dignissimos sunt qui.", "91151dcd-5fdc-4ae3-ae06-9f41048cce83", new DateTime(2020, 12, 3, 16, 49, 1, 716, DateTimeKind.Local).AddTicks(6873), "Storage: ratione", new DateTime(2021, 4, 28, 9, 28, 53, 724, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a23937c7-76f3-4c30-ac84-6aa04462da50"), "Laudantium eos quis.", "5b75ad3b-a135-4f6c-917b-76ee99386c5f", new DateTime(2022, 5, 17, 17, 20, 45, 244, DateTimeKind.Local).AddTicks(9537), "Storage: cupiditate", new DateTime(2022, 6, 21, 13, 35, 28, 73, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b13c7d21-05ea-4f35-84af-ba281c7b38ad"), "Voluptas corporis voluptatum.", "e5e9a153-ec86-4917-8568-af161d5bfbb2", new DateTime(2018, 2, 19, 13, 10, 46, 960, DateTimeKind.Local).AddTicks(7059), "Storage: ut", new DateTime(2022, 4, 22, 23, 14, 16, 842, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6dfb8ad-0eda-4117-8bd2-b10ef19eb59d"), "Optio quam deserunt.", "9ba74fcb-ba3b-40c4-bc04-7c6ee28066a4", new DateTime(2018, 8, 5, 6, 30, 55, 879, DateTimeKind.Local).AddTicks(6617), "Storage: in", new DateTime(2019, 4, 20, 22, 31, 27, 26, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b91332e8-070f-450d-8629-1f27940dbd8c"), "Quia consectetur cumque dicta odio veritatis.", "826a729e-6fc3-4c7e-aa84-bc8c3b4e2e5b", new DateTime(2017, 7, 25, 13, 7, 8, 217, DateTimeKind.Local).AddTicks(3811), "Storage: corporis", new DateTime(2020, 1, 4, 4, 47, 57, 136, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bcbb9686-33f3-4178-a3bd-cc9f60fbab29"), "Ullam veritatis sint architecto.", "a4a2b00e-20e8-4505-a94b-4a7436ca6d28", new DateTime(2019, 3, 16, 16, 10, 38, 138, DateTimeKind.Local).AddTicks(6835), "Storage: accusantium", new DateTime(2020, 7, 23, 11, 6, 46, 559, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bed517a0-7168-4c2a-8b22-2a1c30653e74"), "Numquam soluta non culpa nemo quos.", "8f2e01c7-91a6-498d-bbbe-4dbed49f4168", new DateTime(2017, 7, 7, 13, 30, 39, 395, DateTimeKind.Local).AddTicks(2840), "Storage: est", new DateTime(2022, 2, 17, 8, 59, 8, 977, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c773a65f-9567-4f2f-9604-cf28d825f3aa"), "Explicabo quod incidunt et voluptate.", "3c2340d9-94cd-43e8-b87f-1853116500a0", new DateTime(2019, 11, 13, 18, 30, 36, 647, DateTimeKind.Local).AddTicks(717), "Storage: occaecati", new DateTime(2020, 7, 26, 20, 20, 45, 907, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c9c07a71-afa9-4de3-9b01-1e8eac418ded"), "Et maiores eveniet optio ut.", "40dc1711-fbd7-4fcf-8c19-5f0b437deb82", new DateTime(2019, 6, 21, 13, 51, 47, 778, DateTimeKind.Local).AddTicks(9013), "Storage: veniam", new DateTime(2021, 10, 29, 2, 28, 57, 633, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d2e52abf-de87-4dc8-ac99-a42e4e3ea985"), "Expedita fuga ut sed quaerat ex eos.", "d9fa5dd8-b8d2-4727-b026-3e5aefbfdf44", new DateTime(2021, 9, 22, 0, 47, 34, 648, DateTimeKind.Local).AddTicks(6119), "Storage: voluptatibus", new DateTime(2022, 5, 9, 22, 34, 40, 923, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d59d43d7-292e-4099-a33e-4b3266b50ada"), "Aut nam eaque distinctio laboriosam explicabo reprehenderit consequatur quae provident.", "302818bc-685c-4cc4-80fa-962b348d2973", new DateTime(2017, 8, 5, 7, 31, 52, 358, DateTimeKind.Local).AddTicks(9166), "Storage: accusamus", new DateTime(2021, 1, 5, 22, 39, 59, 727, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d68f0966-8712-4832-9b48-9de57298d538"), "Voluptatibus laudantium maxime voluptatem.", "c643c1e3-4c1e-48bd-bb2f-c39fa55ce024", new DateTime(2020, 1, 27, 14, 24, 7, 298, DateTimeKind.Local).AddTicks(6583), "Storage: accusamus", new DateTime(2020, 8, 2, 18, 31, 5, 53, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7b2ffbe-9027-4140-a1c6-8c22b1565781"), "Quia perferendis explicabo accusantium doloribus molestiae ut.", "5c1c514f-67d8-4447-87b6-70cbbf606b46", new DateTime(2019, 3, 8, 14, 28, 57, 330, DateTimeKind.Local).AddTicks(8737), "Storage: a", new DateTime(2021, 4, 3, 23, 8, 0, 170, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d8c3416a-d531-491f-9bec-a8c1e5f76b27"), "Dicta fugiat repellendus.", "87c33a84-793b-4ca8-8d8e-ad9655d4f9d9", new DateTime(2020, 8, 13, 17, 54, 51, 34, DateTimeKind.Local).AddTicks(3129), "Storage: itaque", new DateTime(2022, 3, 13, 14, 23, 8, 252, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dcf6a8fd-8e92-418e-9ba1-8efcb0a9a7c3"), "Nam beatae amet molestiae laudantium necessitatibus.", "94cdd892-5bf0-4ca1-9593-85752cfcdad9", new DateTime(2019, 6, 13, 5, 17, 3, 399, DateTimeKind.Local).AddTicks(9505), "Storage: praesentium", new DateTime(2021, 11, 14, 11, 17, 41, 103, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dea453d0-ecc4-40b4-bbd5-92546f5c5eb3"), "Qui fuga sit nemo adipisci consectetur quibusdam deserunt.", "25c3b858-b5e8-4f0b-9d19-106bd6f301b7", new DateTime(2022, 6, 22, 5, 49, 19, 587, DateTimeKind.Local).AddTicks(7816), "Storage: iste", new DateTime(2022, 7, 5, 4, 18, 35, 201, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df9fa051-2e09-4455-8604-f9a1464702d6"), "Culpa qui aspernatur asperiores quas.", "c5751af5-0331-4e35-9e8d-d96f92d31b69", new DateTime(2017, 8, 9, 15, 15, 27, 792, DateTimeKind.Local).AddTicks(6679), "Storage: voluptatibus", new DateTime(2017, 8, 31, 18, 4, 6, 574, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dfdcf1cc-eb13-4e1a-9a56-d2693b1b3e51"), "Adipisci dolore quis quo corporis ex dolores.", "ef655401-09aa-4d52-bc9c-cdb2931fd123", new DateTime(2022, 5, 23, 7, 8, 29, 886, DateTimeKind.Local).AddTicks(9639), "Storage: error", new DateTime(2022, 6, 18, 13, 5, 52, 412, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2631dae-5f61-49a0-83b9-d637baa259c0"), "Ipsum ea saepe minima illo deleniti.", "2191fe09-9c80-44cd-ab66-6413f3fa9ad5", new DateTime(2019, 9, 4, 1, 38, 48, 531, DateTimeKind.Local).AddTicks(6327), "Storage: dolore", new DateTime(2021, 7, 8, 16, 25, 46, 556, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e51105b4-57aa-418d-8a63-c75e5f51aa7c"), "Quia sed hic dolorem consectetur.", "d5aa8816-8273-4f86-a442-e7631c1378bc", new DateTime(2022, 5, 29, 22, 46, 4, 32, DateTimeKind.Local).AddTicks(9920), "Storage: autem", new DateTime(2022, 6, 25, 18, 21, 22, 335, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e633b417-15dc-409e-bd97-f35d385c2b0c"), "Quo earum corrupti et dolorem fugit non.", "e1702bda-63be-4ae8-a056-340578d61151", new DateTime(2019, 9, 13, 0, 50, 16, 361, DateTimeKind.Local).AddTicks(6262), "Storage: dolores", new DateTime(2021, 8, 19, 13, 28, 51, 153, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e6380ba7-2451-4751-a4e4-36304ceb71e4"), "Blanditiis dicta ut et rerum nihil non minima.", "0bbcc41d-dcb3-4ddc-9241-421ac9aadc5a", new DateTime(2017, 12, 31, 17, 45, 56, 582, DateTimeKind.Local).AddTicks(162), "Storage: reiciendis", new DateTime(2019, 12, 8, 7, 35, 53, 337, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eafb3a53-e919-4186-9c5d-1e5427bcb7fa"), "Necessitatibus dicta eum.", "3d63f491-0871-411a-9c90-7eda0281a736", new DateTime(2017, 11, 24, 14, 33, 45, 827, DateTimeKind.Local).AddTicks(8573), "Storage: nemo", new DateTime(2021, 10, 24, 16, 42, 37, 219, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ece6b6ff-3baf-4cea-a541-69d9c6c323c4"), "Quaerat nihil sapiente deserunt possimus consequatur.", "015c1d23-8458-4fe4-9faf-face1dcf1ce2", new DateTime(2020, 12, 1, 20, 56, 20, 555, DateTimeKind.Local).AddTicks(9845), "Storage: quaerat", new DateTime(2021, 6, 18, 4, 4, 42, 698, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee9f290a-2c30-4e19-9c07-d905e2099c5f"), "In sed omnis voluptatibus ipsam.", "8ad4b55e-cf8a-4fd4-af5c-fbfe885d0a00", new DateTime(2019, 8, 26, 3, 57, 1, 899, DateTimeKind.Local).AddTicks(608), "Storage: atque", new DateTime(2020, 4, 14, 2, 41, 18, 107, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f0e068ec-052e-43df-ba8a-e5f687ba8673"), "Nemo consequatur ratione.", "05e28773-ce77-445b-bcf9-aa9e0eacd395", new DateTime(2019, 6, 21, 23, 22, 19, 129, DateTimeKind.Local).AddTicks(8192), "Storage: ex", new DateTime(2019, 12, 11, 13, 45, 31, 738, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f2eabb06-c113-4e45-b0b8-6f29a45f5de6"), "Voluptas sit voluptates qui est consequuntur quos.", "e6e1f5ab-d289-456c-a4ab-0d8172204c1b", new DateTime(2022, 4, 29, 6, 7, 12, 660, DateTimeKind.Local).AddTicks(1744), "Storage: et", new DateTime(2022, 5, 19, 12, 48, 17, 77, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f88e0cac-3733-42cb-b1ae-b0526f65d26c"), "Nobis delectus atque.", "a6f58068-be6e-4d5e-9b8b-cb3c23d27727", new DateTime(2022, 2, 22, 16, 36, 41, 938, DateTimeKind.Local).AddTicks(2497), "Storage: laudantium", new DateTime(2022, 6, 3, 17, 18, 28, 117, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f9142e52-e1da-4356-8b41-3ec0a5fdb8fb"), "Sit porro ipsam porro earum repellendus.", "1c53e037-2fcf-463f-af35-70eb910add1d", new DateTime(2020, 8, 10, 5, 40, 26, 313, DateTimeKind.Local).AddTicks(3126), "Storage: odit", new DateTime(2021, 8, 6, 10, 45, 27, 766, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fdcd2378-19b6-4e2a-b882-e48bee69846d"), "Est qui est ex.", "c80b16f2-95b7-4cc9-8fea-4d19183049aa", new DateTime(2018, 10, 19, 4, 6, 11, 837, DateTimeKind.Local).AddTicks(4516), "Storage: hic", new DateTime(2019, 2, 25, 16, 9, 13, 929, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fec3888f-49f4-43ea-b3b1-a1f97ecb8316"), "Dolores quia vitae est quibusdam repellat.", "0be6cd92-116c-47d0-95b4-8e01d2ef382d", new DateTime(2021, 7, 9, 5, 52, 3, 154, DateTimeKind.Local).AddTicks(6596), "Storage: eum", new DateTime(2021, 10, 19, 18, 57, 12, 130, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05b79cff-9528-46bb-a54d-d0db541439ba"), "Ut repellat voluptatum molestias.", "b6e19fab-e20a-4c6f-ae84-50fece8355fd", new DateTime(2018, 3, 3, 0, 24, 51, 57, DateTimeKind.Local).AddTicks(5092), "Subdivision: doloribus", new DateTime(2019, 11, 14, 12, 9, 21, 984, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("07caab84-a8e3-4628-ba1e-11d6e534fea6"), "Aspernatur inventore amet voluptatum incidunt quidem ut.", "760c18b6-848d-4a82-87df-bd3ec7fed120", new DateTime(2022, 6, 26, 22, 5, 53, 162, DateTimeKind.Local).AddTicks(8518), "Subdivision: voluptatem", new DateTime(2022, 7, 1, 3, 50, 59, 917, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0b116cf6-0760-4e9c-9f41-0d4486f1d1ff"), "Tempore suscipit quis reprehenderit est animi perferendis consectetur.", "222a496e-25d6-4179-b1ff-41e982a63f91", new DateTime(2019, 1, 11, 4, 40, 50, 475, DateTimeKind.Local).AddTicks(8814), "Subdivision: ducimus", new DateTime(2019, 8, 5, 5, 3, 43, 492, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ed19789-509c-48cc-bdf5-f1dc861642f6"), "Dicta sed expedita ea corporis numquam deleniti.", "23332f9a-3ef7-441b-94eb-10823a280d02", new DateTime(2020, 11, 9, 6, 34, 24, 800, DateTimeKind.Local).AddTicks(9990), "Subdivision: suscipit", new DateTime(2021, 12, 19, 10, 42, 59, 183, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12911650-fa30-4477-abcb-624c47e41fe8"), "Voluptatem libero fuga et excepturi officia qui laborum corporis autem.", "649965e8-ae0f-4ce1-96c8-992e604bc489", new DateTime(2018, 6, 28, 17, 16, 48, 18, DateTimeKind.Local).AddTicks(9470), "Subdivision: quia", new DateTime(2018, 10, 8, 7, 49, 23, 985, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("146dfa9b-5a3f-455e-bd08-c162bb7fbfaf"), "Autem quia nemo cum.", "d39a55fa-ad59-4d18-97e6-8b6871ae7a03", new DateTime(2019, 5, 5, 21, 52, 45, 416, DateTimeKind.Local).AddTicks(4177), "Subdivision: odit", new DateTime(2019, 7, 4, 7, 48, 43, 322, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("15c2fc01-a01e-404f-84ca-4ab92ae8a296"), "Dicta et vitae rem ipsam explicabo autem repellendus.", "45280374-cece-45ee-b492-2722a0ccaf7f", new DateTime(2020, 5, 8, 1, 56, 37, 673, DateTimeKind.Local).AddTicks(3020), "Subdivision: consequatur", new DateTime(2022, 4, 29, 23, 30, 48, 451, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19b2161f-f8e6-4115-be5a-18c48172506a"), "Quia labore sit reprehenderit qui consequuntur.", "c3c9f03a-e351-4c81-ab4f-b174211eec42", new DateTime(2018, 11, 24, 12, 40, 9, 64, DateTimeKind.Local).AddTicks(5415), "Subdivision: voluptas", new DateTime(2020, 1, 19, 4, 45, 16, 917, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19cb1f2d-0b4a-4b07-a856-239a661ed419"), "Fugit dolore ut nam.", "c34a36e9-740b-4cfc-8705-a584dffe28ca", new DateTime(2018, 5, 24, 2, 19, 42, 188, DateTimeKind.Local).AddTicks(8206), "Subdivision: officia", new DateTime(2020, 8, 24, 16, 52, 30, 151, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1aeb508f-3418-443f-b407-2e1584fe8b8f"), "Quia et dolore et incidunt.", "ec6c824a-c6a7-4ccc-908f-8a11b84c8015", new DateTime(2019, 5, 13, 4, 16, 16, 97, DateTimeKind.Local).AddTicks(4044), "Subdivision: eum", new DateTime(2019, 8, 11, 20, 48, 52, 975, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e04fc70-cf75-45b9-a37b-42b546678606"), "Saepe molestiae perferendis eaque autem.", "03881667-cc53-4b39-99e2-45feb723068d", new DateTime(2019, 4, 16, 21, 46, 12, 318, DateTimeKind.Local).AddTicks(9615), "Subdivision: vel", new DateTime(2021, 8, 7, 6, 33, 14, 854, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1e9127b9-bf2d-4a21-b302-4848ed8439c8"), "Facilis assumenda aliquid molestiae enim pariatur.", "ebaf239e-1a46-4d1a-82d1-8881e9d71648", new DateTime(2020, 4, 27, 8, 55, 29, 870, DateTimeKind.Local).AddTicks(2237), "Subdivision: voluptatibus", new DateTime(2022, 7, 6, 13, 57, 15, 454, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("215214cf-926f-4d3d-8235-b036cc2dbeda"), "Vitae est consectetur quisquam exercitationem autem quidem a assumenda.", "26b78d6e-d873-45f0-8151-e6383aa0ecaa", new DateTime(2020, 12, 25, 6, 41, 10, 313, DateTimeKind.Local).AddTicks(5102), "Subdivision: iure", new DateTime(2021, 1, 6, 13, 18, 19, 511, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("24f35874-3649-4080-84b0-3b8c632db882"), "Atque eos eos dolorum quos inventore.", "23c7582e-e155-40ef-a335-a5f922730d89", new DateTime(2019, 6, 23, 8, 45, 55, 432, DateTimeKind.Local).AddTicks(2359), "Subdivision: nihil", new DateTime(2019, 10, 14, 17, 29, 9, 796, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2cc34610-7940-428a-a44a-ad9c3f5e3ac2"), "Saepe tenetur modi.", "02bc62f1-0894-4557-bc64-cd04955f273a", new DateTime(2019, 6, 23, 6, 12, 34, 487, DateTimeKind.Local).AddTicks(9964), "Subdivision: porro", new DateTime(2021, 4, 14, 19, 51, 3, 358, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("327ae8b3-8cc4-4dac-82e7-80a199827ef4"), "Laborum numquam odit nemo qui incidunt voluptatem.", "2553b795-e1fe-41f8-8421-6f16387fd6d1", new DateTime(2020, 12, 6, 16, 37, 46, 85, DateTimeKind.Local).AddTicks(6590), "Subdivision: officiis", new DateTime(2021, 12, 23, 15, 10, 0, 280, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3408e3ff-3950-4962-a8ed-4f65779bf6dc"), "Totam consequatur repellendus corrupti dolore.", "c323cba1-d782-4cca-95fe-08735e01475d", new DateTime(2020, 10, 19, 9, 9, 34, 12, DateTimeKind.Local).AddTicks(3443), "Subdivision: maiores", new DateTime(2021, 2, 21, 19, 27, 15, 428, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("344a3ed3-c001-401f-8aa0-c4b2ca1bc04b"), "Ut vel non itaque et nemo tenetur dolores.", "9e7b9ece-3490-4a42-a95b-34281f706b56", new DateTime(2020, 9, 3, 20, 56, 22, 792, DateTimeKind.Local).AddTicks(407), "Subdivision: odit", new DateTime(2021, 1, 18, 5, 41, 59, 18, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("349a2ee9-ec84-4515-9a04-ce0afae77e7b"), "Non consequatur ea corrupti ipsam aut expedita nisi.", "9363a183-a060-4140-8d61-41526840ea4a", new DateTime(2021, 5, 6, 15, 45, 4, 387, DateTimeKind.Local).AddTicks(5034), "Subdivision: consequuntur", new DateTime(2022, 2, 27, 7, 48, 53, 104, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3a50d25d-2704-459f-8f4c-7171c0e3da25"), "Ducimus et et consequatur commodi exercitationem consequatur.", "453e7783-6168-4d25-94e3-56884bcbd187", new DateTime(2020, 5, 23, 2, 28, 9, 164, DateTimeKind.Local).AddTicks(7531), "Subdivision: natus", new DateTime(2021, 5, 21, 1, 23, 52, 705, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b96164d-4f0e-457d-93a1-9b6f36cf0578"), "Omnis dicta vel praesentium blanditiis minima amet occaecati.", "0cbca986-0945-42e3-b5c7-63afe201ceb5", new DateTime(2020, 4, 7, 16, 12, 41, 753, DateTimeKind.Local).AddTicks(2291), "Subdivision: et", new DateTime(2021, 11, 4, 18, 41, 41, 189, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d27f92c-f79f-4637-94d0-ab4c57f22e18"), "Nostrum ea aliquid eius dolor dolor ea saepe tenetur impedit.", "d103cfc7-bef6-448e-a014-daacb82a29d2", new DateTime(2018, 12, 26, 15, 46, 51, 898, DateTimeKind.Local).AddTicks(6316), "Subdivision: ducimus", new DateTime(2021, 4, 8, 0, 59, 6, 482, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3db22fe8-f43e-42b5-ad46-87564b75a614"), "Perspiciatis ab quas quia.", "f5d0dd62-736c-46ed-a143-ba414e81dc1d", new DateTime(2017, 10, 19, 16, 38, 1, 881, DateTimeKind.Local).AddTicks(5402), "Subdivision: explicabo", new DateTime(2022, 5, 6, 14, 8, 2, 62, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f0f91bb-1bca-4375-942f-4b2a46808f70"), "Ea minima tempore error sint.", "29a11fb8-a0ac-425d-977a-8d2fdbca283d", new DateTime(2020, 9, 29, 13, 48, 48, 79, DateTimeKind.Local).AddTicks(6206), "Subdivision: reprehenderit", new DateTime(2021, 4, 5, 10, 29, 17, 619, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("41b0329b-4ecc-4625-9914-e2dff7707d60"), "Dignissimos dolores sapiente.", "a7015cb9-8fd2-4a1e-b7a7-f05a9122cc3c", new DateTime(2019, 1, 7, 0, 32, 33, 527, DateTimeKind.Local).AddTicks(9146), "Subdivision: culpa", new DateTime(2020, 9, 7, 17, 14, 44, 949, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("462609bb-db95-4a0e-b7e7-21c4477a04d1"), "Natus maiores blanditiis voluptatem.", "47f9c469-f8b2-4403-82ed-a94420b68ff6", new DateTime(2021, 3, 15, 7, 50, 44, 275, DateTimeKind.Local).AddTicks(5944), "Subdivision: enim", new DateTime(2021, 12, 28, 20, 5, 23, 128, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("47a25e8f-ea58-4346-9823-b7237fa52e45"), "Culpa et vel exercitationem dolores.", "645d359e-05db-4d09-b470-11287751f42f", new DateTime(2022, 3, 11, 20, 32, 10, 906, DateTimeKind.Local).AddTicks(9019), "Subdivision: molestiae", new DateTime(2022, 5, 23, 16, 20, 49, 28, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("48a5bbed-a4ae-4b7a-8ec2-6361ba02afeb"), "Aut iste eius soluta voluptate ullam earum et nisi ad.", "e2503ba8-176d-4ebf-b841-c26567de361b", new DateTime(2018, 2, 10, 18, 5, 15, 502, DateTimeKind.Local).AddTicks(1932), "Subdivision: distinctio", new DateTime(2019, 12, 6, 23, 8, 53, 121, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("48e4f124-659d-48d5-ba10-86753724cccb"), "Provident facere enim voluptatem corrupti eveniet dolore.", "66194bac-c81e-4440-8151-b19e96ff3b9d", new DateTime(2020, 7, 4, 6, 39, 37, 78, DateTimeKind.Local).AddTicks(4738), "Subdivision: aspernatur", new DateTime(2021, 10, 25, 19, 54, 7, 968, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49146349-3909-4aca-ac87-3943d2a8b634"), "Dolor rem animi eveniet dolore quia ducimus.", "5f3523df-f35f-42de-b32d-c8921240684b", new DateTime(2020, 11, 22, 8, 21, 31, 839, DateTimeKind.Local).AddTicks(8427), "Subdivision: asperiores", new DateTime(2022, 6, 25, 18, 26, 42, 246, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("492f2a3f-cd51-4033-be41-159a239b7533"), "Sed molestias est sit ut dolorem soluta rerum.", "1ce540a5-02cf-4738-be4d-b3f4ff8126cf", new DateTime(2021, 10, 21, 10, 44, 2, 263, DateTimeKind.Local).AddTicks(2897), "Subdivision: nisi", new DateTime(2021, 11, 21, 8, 5, 7, 666, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b74a27d-ccb4-44e5-9853-08fc9f5610a0"), "Magnam hic sunt omnis impedit velit itaque porro totam molestiae.", "3fa7a195-ed70-4d02-a0f0-aaeb266545cb", new DateTime(2020, 5, 29, 22, 45, 48, 121, DateTimeKind.Local).AddTicks(9502), "Subdivision: iusto", new DateTime(2020, 7, 10, 6, 27, 45, 137, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4dd1fcda-6eb9-4181-9552-b30d9eaeacc8"), "Incidunt perspiciatis repellendus reiciendis facilis officiis.", "c2b0ac38-2f61-4e56-aa1c-b4821c90e70a", new DateTime(2017, 7, 13, 6, 51, 22, 422, DateTimeKind.Local).AddTicks(9246), "Subdivision: harum", new DateTime(2019, 12, 26, 14, 15, 59, 927, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54d9f122-3be4-4ab8-a58a-bee2be9c4e9a"), "Consequatur dolor iste ducimus est id illo nobis qui.", "34e359e4-af40-40be-8a30-d78e91b6ae08", new DateTime(2021, 6, 9, 9, 46, 23, 554, DateTimeKind.Local).AddTicks(8583), "Subdivision: esse", new DateTime(2022, 3, 19, 16, 58, 5, 539, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5692d242-f35d-4b81-a40b-b05513c5011c"), "Nisi facere ipsum quis accusantium necessitatibus ab maiores animi ut.", "4ea321ad-bb7c-4578-8c57-6e896693238b", new DateTime(2022, 2, 9, 8, 7, 23, 442, DateTimeKind.Local).AddTicks(7302), "Subdivision: et", new DateTime(2022, 4, 21, 4, 13, 8, 800, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5af8871e-fb49-4fca-b8f9-9a54715a0f67"), "Est voluptate natus et delectus ipsam ut ea.", "f76c432e-26f6-480d-af1e-a1ea00e6df0d", new DateTime(2022, 5, 6, 4, 2, 38, 556, DateTimeKind.Local).AddTicks(3719), "Subdivision: non", new DateTime(2022, 5, 10, 3, 42, 11, 473, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5d94845c-c776-4e54-9c10-f08d54f22a72"), "Sed minus consectetur ipsam.", "d230c6f8-36c7-4535-92f7-2f5d0d6b6685", new DateTime(2018, 6, 7, 11, 59, 8, 189, DateTimeKind.Local).AddTicks(6996), "Subdivision: eligendi", new DateTime(2021, 2, 9, 0, 41, 38, 244, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e66f7b3-cfe0-48bd-a731-64b3eb915740"), "Optio totam sunt voluptas.", "bc9b6c0b-542d-427a-83bf-c7d622a7ee44", new DateTime(2019, 3, 6, 17, 59, 31, 683, DateTimeKind.Local).AddTicks(7110), "Subdivision: velit", new DateTime(2019, 3, 24, 4, 12, 21, 990, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("64be164e-2bd4-4da2-93ba-2b1047b5cfa5"), "Rerum similique dolores quis consequuntur sunt nesciunt ut aliquam.", "33e3cf06-b637-43e3-b0fe-16ba2f2ac10f", new DateTime(2020, 10, 10, 15, 8, 46, 843, DateTimeKind.Local).AddTicks(8189), "Subdivision: est", new DateTime(2021, 7, 10, 5, 58, 16, 334, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("687f4436-bb99-4717-be5a-736d100267af"), "Dolorem corrupti expedita mollitia eum explicabo sequi.", "a9f5ef42-69e6-440c-ad8b-b32d688c593d", new DateTime(2022, 1, 25, 5, 56, 37, 645, DateTimeKind.Local).AddTicks(8894), "Subdivision: sequi", new DateTime(2022, 6, 15, 18, 20, 45, 961, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a0af94d-f9af-46a2-bac4-c0d8bc2f7cd5"), "Qui consequatur totam.", "48fe210c-241e-4554-8dee-eadcb4c256f2", new DateTime(2022, 5, 7, 5, 2, 25, 413, DateTimeKind.Local).AddTicks(5994), "Subdivision: quo", new DateTime(2022, 6, 17, 2, 27, 16, 262, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a681d94-2138-4e2d-8f38-06e3e1443039"), "Aliquam et est aut qui et et iusto eveniet.", "858a625c-239f-449f-b849-8f56638fe464", new DateTime(2019, 7, 11, 4, 51, 20, 677, DateTimeKind.Local).AddTicks(6609), "Subdivision: ut", new DateTime(2022, 6, 10, 7, 1, 5, 202, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c4a3c1d-1ba2-450b-85b5-6b34341fd5a5"), "Molestiae iste distinctio nemo.", "56c3ed9c-0a32-474e-bb5d-4db2e7b1ab0a", new DateTime(2018, 8, 10, 4, 30, 8, 193, DateTimeKind.Local).AddTicks(4785), "Subdivision: praesentium", new DateTime(2020, 1, 13, 1, 48, 4, 752, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e324216-6363-4be5-a281-afd1a31786b0"), "Sint consequatur quod dolor deleniti.", "eef54bc4-b003-4f80-8249-02fd61cf3a88", new DateTime(2020, 5, 11, 18, 0, 23, 420, DateTimeKind.Local).AddTicks(6944), "Subdivision: sed", new DateTime(2020, 12, 15, 4, 25, 16, 96, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6ff28863-fce6-47a6-b374-1c0906adfe08"), "A optio et voluptate ut illo voluptatem quo et mollitia.", "81f4789d-d207-42e5-9cf9-62805fbf68e5", new DateTime(2018, 11, 26, 13, 14, 35, 732, DateTimeKind.Local).AddTicks(8174), "Subdivision: sapiente", new DateTime(2019, 9, 9, 4, 44, 39, 599, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("70cde5e4-2f80-4069-b78b-26deeacd9ebf"), "Aut id minima et magnam.", "65935400-e8ef-4e62-a0a9-dcbefaeba2c3", new DateTime(2019, 9, 28, 17, 31, 11, 344, DateTimeKind.Local).AddTicks(3352), "Subdivision: inventore", new DateTime(2019, 12, 10, 0, 12, 24, 940, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("75041a74-91fa-4c67-96d3-2a1a86fa2d6a"), "Illo et iste.", "ae3ff0cf-a71f-4f4d-9353-8e39d54ab1ab", new DateTime(2022, 3, 16, 10, 23, 1, 56, DateTimeKind.Local).AddTicks(3845), "Subdivision: qui", new DateTime(2022, 7, 3, 6, 26, 19, 798, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7560dea1-6393-4807-bf40-f8f88e303954"), "Vel mollitia in.", "bcad92f9-b625-4205-b2b7-8da5f557bb48", new DateTime(2019, 10, 10, 13, 35, 59, 855, DateTimeKind.Local).AddTicks(4386), "Subdivision: vitae", new DateTime(2020, 8, 17, 5, 11, 51, 436, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7689a78a-f9cb-471c-887a-15b10b0c8d00"), "Rerum consectetur dolor laudantium rerum eius consequatur quisquam assumenda.", "89f6a20b-6647-4fc7-8f2e-c0391547c7cf", new DateTime(2017, 11, 30, 2, 48, 38, 182, DateTimeKind.Local).AddTicks(2992), "Subdivision: sed", new DateTime(2021, 1, 18, 7, 41, 1, 373, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7a14c355-7bef-4ab1-adc2-79c1e410f6a6"), "Expedita facilis excepturi voluptas earum alias ut accusamus vero quia.", "84a3b080-94a7-44d0-9094-04a4b9dc3c79", new DateTime(2019, 7, 21, 0, 20, 23, 796, DateTimeKind.Local).AddTicks(4668), "Subdivision: harum", new DateTime(2020, 5, 16, 6, 16, 26, 164, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("827c7b47-8d62-4d43-9c51-2844323499e3"), "Eveniet soluta odit amet ad qui eos.", "ec40e64d-c53b-4a19-afad-8d85b35b7b9f", new DateTime(2019, 3, 9, 14, 22, 0, 22, DateTimeKind.Local).AddTicks(5407), "Subdivision: reprehenderit", new DateTime(2022, 6, 13, 11, 15, 30, 826, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("83ae6e5c-d12f-42c9-965e-45f79063329d"), "Eligendi praesentium totam fugit et.", "f59337d9-151d-4b44-8e2e-885a8464290f", new DateTime(2020, 8, 7, 3, 23, 53, 381, DateTimeKind.Local).AddTicks(8780), "Subdivision: modi", new DateTime(2022, 6, 10, 2, 17, 6, 562, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("88d4dfd0-96df-450f-995d-bf1851381ff7"), "Sint excepturi animi sint consectetur nesciunt eum voluptatibus.", "6e29a455-f1e6-472c-b2a8-3afa5b076056", new DateTime(2018, 8, 13, 4, 48, 4, 816, DateTimeKind.Local).AddTicks(9488), "Subdivision: a", new DateTime(2020, 9, 22, 3, 19, 43, 794, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d46c04f-0cd8-4950-a7ce-7ed1e8bb54ce"), "Accusamus qui quis dolorem et eveniet occaecati.", "97282513-7f78-4b3d-b3df-cebd06c4f3f6", new DateTime(2019, 11, 19, 4, 38, 28, 767, DateTimeKind.Local).AddTicks(3471), "Subdivision: est", new DateTime(2021, 1, 17, 17, 12, 1, 863, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e2f01d9-8786-4f26-b7fd-5e65bb5e0ae6"), "Sunt fuga illo placeat quasi mollitia iure.", "ec1617b3-ba8b-40ea-b912-f30599bc0dc0", new DateTime(2020, 2, 4, 2, 28, 5, 862, DateTimeKind.Local).AddTicks(7350), "Subdivision: et", new DateTime(2022, 3, 24, 1, 29, 25, 591, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e51c65b-7792-416c-9e14-0be1a9eca809"), "Voluptates quod quia officia.", "0b0ef19e-014d-412a-aa26-dfe5afa88924", new DateTime(2018, 4, 10, 19, 41, 23, 940, DateTimeKind.Local).AddTicks(6760), "Subdivision: placeat", new DateTime(2022, 2, 11, 14, 19, 31, 530, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e58c1e0-6cf1-4c2e-9f46-910b08b75ce8"), "Aperiam sunt est sed est voluptatibus.", "8c048dc7-b443-4064-b30c-94332d1fe11a", new DateTime(2019, 1, 27, 19, 1, 56, 374, DateTimeKind.Local).AddTicks(5115), "Subdivision: sed", new DateTime(2019, 11, 19, 15, 15, 4, 86, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("913e2220-209f-4272-9612-010af8685aaa"), "Optio aut ipsam quaerat dolor.", "37bd25bb-c4bd-4b6f-a91e-b0d8f7e3fb65", new DateTime(2021, 6, 28, 2, 50, 55, 132, DateTimeKind.Local).AddTicks(6255), "Subdivision: accusamus", new DateTime(2021, 8, 15, 10, 46, 29, 168, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9aa17b64-62b3-426a-956d-55793cbde95c"), "Quia sed et sapiente id quisquam quia saepe et porro.", "b17f470a-b086-4295-b959-e7f1a679ba38", new DateTime(2021, 6, 23, 9, 18, 43, 532, DateTimeKind.Local).AddTicks(1410), "Subdivision: libero", new DateTime(2022, 2, 16, 19, 54, 55, 668, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e48e873-0b2a-47c0-b8af-8e29c3e22bdd"), "Rerum voluptas nihil ullam delectus et adipisci vero aut cumque.", "5f8cd736-9784-4e21-8603-4f76a9fd1023", new DateTime(2018, 4, 6, 8, 3, 40, 811, DateTimeKind.Local).AddTicks(5352), "Subdivision: est", new DateTime(2020, 7, 13, 10, 48, 27, 958, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f86a5b0-7ccb-4ad2-a672-73ab820a220a"), "Dolor nihil possimus quae molestias.", "6cb1014b-4262-4796-bb89-8ad857e10928", new DateTime(2018, 12, 19, 3, 59, 15, 487, DateTimeKind.Local).AddTicks(4998), "Subdivision: temporibus", new DateTime(2019, 2, 16, 6, 19, 4, 222, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a14876bd-e7e3-4d9f-a8aa-acbfbe9c2b71"), "Quaerat cum maiores voluptates enim voluptatem aliquid dolores et dolorum.", "ffd43acd-2ef4-4cfc-b23a-b80991e2288a", new DateTime(2019, 11, 9, 9, 13, 28, 35, DateTimeKind.Local).AddTicks(6596), "Subdivision: sed", new DateTime(2020, 6, 26, 11, 9, 40, 337, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a3692b54-8ed8-48e9-b396-f4c4da2fb588"), "Illum consequatur quia veritatis nihil dolorem distinctio eveniet.", "e76a22ea-9f8f-47ec-bf7d-56f6f01aa4b9", new DateTime(2019, 11, 27, 11, 37, 41, 832, DateTimeKind.Local).AddTicks(7203), "Subdivision: in", new DateTime(2020, 7, 25, 11, 27, 6, 247, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a4c224fe-5f77-4980-8662-562ef073e3da"), "Perspiciatis asperiores fugit ipsa.", "68aaa054-b482-4d1c-b251-b1e151e22e8e", new DateTime(2021, 2, 14, 14, 55, 15, 734, DateTimeKind.Local).AddTicks(3446), "Subdivision: laudantium", new DateTime(2021, 3, 6, 22, 58, 17, 280, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a5a02ea1-329b-48c7-a414-138149d3f0b7"), "Magni debitis facere.", "346f82a9-01f3-4179-a0b3-4f854dc1799a", new DateTime(2020, 12, 28, 21, 18, 43, 294, DateTimeKind.Local).AddTicks(2743), "Subdivision: temporibus", new DateTime(2021, 4, 25, 22, 15, 26, 47, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7fa907a-ca84-42e2-8fbb-201dae8a809d"), "Voluptatem non sed nobis dolorem recusandae quae itaque cum.", "6c88b403-674b-4f34-ac7b-664f277ee8dc", new DateTime(2019, 12, 4, 14, 52, 23, 78, DateTimeKind.Local).AddTicks(2351), "Subdivision: eveniet", new DateTime(2020, 5, 26, 8, 21, 28, 369, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a9301cb0-03fe-4141-8b99-b9f0f2d2028e"), "Dolore repellendus corporis.", "d71e92fd-4b66-46a4-bfe8-c72d65c6af55", new DateTime(2019, 8, 30, 3, 21, 19, 248, DateTimeKind.Local).AddTicks(9787), "Subdivision: iure", new DateTime(2022, 3, 26, 22, 28, 1, 832, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa6bff42-1e93-4028-ba52-44f8fe496c81"), "Deleniti et explicabo et et non perspiciatis dolorem et ex.", "f0cd9013-778e-459e-baaf-461b3f88217b", new DateTime(2020, 3, 31, 11, 45, 41, 879, DateTimeKind.Local).AddTicks(1129), "Subdivision: aut", new DateTime(2020, 6, 10, 12, 27, 16, 628, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab3253e8-b817-46d6-bdc4-969263686bb1"), "Ad nostrum mollitia et quo.", "ba16bb90-5d26-459b-a14a-2f5c566345b4", new DateTime(2019, 12, 4, 3, 59, 47, 535, DateTimeKind.Local).AddTicks(6156), "Subdivision: quasi", new DateTime(2021, 3, 5, 5, 52, 30, 973, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ae51bee7-da49-47e8-ae7d-c2365cbc923d"), "Veritatis eum rerum illo vitae est deleniti enim natus qui.", "d0698696-bed8-4e79-9971-d7245222c537", new DateTime(2017, 12, 3, 4, 29, 4, 698, DateTimeKind.Local).AddTicks(3847), "Subdivision: quas", new DateTime(2018, 1, 18, 12, 29, 9, 398, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("be4b1b60-963d-47b2-a4ab-b19c4d04397f"), "Voluptatem culpa nam in.", "45023598-1fc1-410a-a1b5-6a537ffa7691", new DateTime(2020, 9, 8, 21, 34, 26, 933, DateTimeKind.Local).AddTicks(951), "Subdivision: officiis", new DateTime(2021, 6, 24, 15, 47, 24, 305, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c02ff5fa-4325-4827-b965-b4befe278c24"), "Ad perferendis aut omnis et quo totam vero quia.", "201dd8b9-f94b-4438-bf0c-5215042eb23c", new DateTime(2021, 7, 3, 13, 33, 25, 582, DateTimeKind.Local).AddTicks(1347), "Subdivision: distinctio", new DateTime(2021, 7, 12, 14, 24, 33, 576, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0d10103-def1-4f2f-b123-bd953899e926"), "Et amet et.", "d2edb466-34df-466f-98cb-7ae05e1fd85d", new DateTime(2020, 8, 12, 11, 53, 2, 593, DateTimeKind.Local).AddTicks(1849), "Subdivision: doloribus", new DateTime(2022, 6, 10, 11, 45, 41, 30, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1506bea-d7ba-4b63-b26d-59fcb5fa49f0"), "Et qui ad officiis consectetur id ea ut consequatur laudantium.", "2f2b8146-a08c-423d-ab4a-dfecc973d9f2", new DateTime(2017, 7, 8, 18, 51, 53, 509, DateTimeKind.Local).AddTicks(7762), "Subdivision: sit", new DateTime(2017, 12, 7, 2, 58, 46, 335, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c17bb2fd-33c1-4762-bf4e-00de98cac0e5"), "Aut fugiat praesentium temporibus rem ut quasi id voluptas.", "3eb45ef0-3aae-4395-9b53-635b6b4cadd9", new DateTime(2019, 2, 15, 15, 44, 56, 618, DateTimeKind.Local).AddTicks(5274), "Subdivision: laborum", new DateTime(2019, 6, 15, 0, 20, 10, 764, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2eb0fb8-1f4f-4231-81c7-3ae319a287a6"), "Hic quia enim illum et molestiae.", "3b3660aa-3837-47f9-9900-0b2ce479d69e", new DateTime(2022, 3, 12, 11, 7, 7, 820, DateTimeKind.Local).AddTicks(8800), "Subdivision: et", new DateTime(2022, 4, 4, 11, 19, 45, 468, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c5e0dfdf-0497-4328-9c01-774a8d2e0247"), "Pariatur ipsam quia suscipit veritatis voluptatibus quos.", "8a8d6aa0-4146-48cb-9070-d3327f2abbc3", new DateTime(2021, 7, 16, 10, 30, 51, 11, DateTimeKind.Local).AddTicks(6683), "Subdivision: voluptas", new DateTime(2022, 6, 19, 5, 11, 38, 433, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c8ca2a60-9e70-437a-8399-31d6962a083d"), "Tempore minima ad ut quia et.", "2bd242ab-fa6b-40c7-935c-46cc58b1ec05", new DateTime(2019, 4, 5, 14, 58, 47, 701, DateTimeKind.Local).AddTicks(7696), "Subdivision: cumque", new DateTime(2020, 2, 29, 16, 38, 56, 298, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c94af2fe-80f7-4aba-915a-bc0e37ce6630"), "Nemo quibusdam eum.", "b38b8841-86fc-43d0-bcf7-61e62f1d192f", new DateTime(2017, 7, 8, 7, 29, 17, 390, DateTimeKind.Local).AddTicks(551), "Subdivision: enim", new DateTime(2017, 11, 17, 14, 15, 48, 171, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cb602ebb-f6f9-45be-a703-6145b8343bd7"), "Ut dolorem commodi veniam aspernatur harum fuga earum quia.", "e6ad8c3a-2b22-4222-a5e4-3476555215a9", new DateTime(2019, 4, 28, 11, 24, 23, 840, DateTimeKind.Local).AddTicks(5989), "Subdivision: molestiae", new DateTime(2020, 4, 6, 11, 59, 3, 444, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ce384bfa-26e1-4250-bf9d-8dd7dbb171d0"), "Et quia nesciunt quis.", "7707f14b-e722-42bd-87e2-97cd55f9b2c8", new DateTime(2017, 7, 21, 18, 23, 10, 564, DateTimeKind.Local).AddTicks(7254), "Subdivision: reiciendis", new DateTime(2018, 4, 29, 6, 56, 59, 920, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d5147a80-3406-412f-ab93-cdc9f0dfd108"), "Sed fuga tempore asperiores est.", "63d2b59e-eadc-405a-bd5d-24b34615feb9", new DateTime(2018, 5, 19, 16, 0, 17, 566, DateTimeKind.Local).AddTicks(9028), "Subdivision: natus", new DateTime(2020, 2, 26, 23, 20, 12, 155, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d6f3ced5-921f-42a2-b80c-415e99d32e99"), "Vel et est et.", "da175db4-759e-446c-9e81-67bd150d9a4a", new DateTime(2022, 2, 26, 14, 59, 31, 541, DateTimeKind.Local).AddTicks(1764), "Subdivision: velit", new DateTime(2022, 4, 19, 23, 51, 35, 149, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d7193b92-705b-4e91-a436-c83d4457884c"), "Voluptatum in voluptas voluptas officia quae autem eum aspernatur aut.", "6e00e699-ef82-4465-bcd3-d0f9255c315e", new DateTime(2017, 7, 17, 8, 23, 16, 39, DateTimeKind.Local).AddTicks(3670), "Subdivision: consequatur", new DateTime(2021, 12, 21, 1, 57, 34, 230, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d91b80ec-a1dc-4efd-859a-34b6970b4dbd"), "Eos quo qui eius qui.", "3c61b6e4-6876-4643-8324-0fb4d3c8221b", new DateTime(2018, 2, 26, 3, 38, 21, 115, DateTimeKind.Local).AddTicks(2740), "Subdivision: fugit", new DateTime(2020, 5, 19, 15, 53, 27, 791, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9250daf-20b0-4328-81b4-e97ecfbf1ba5"), "Aut id maxime et dolores.", "03a22db2-046c-4f40-aa8b-1ea78ffd6129", new DateTime(2018, 12, 27, 2, 11, 55, 952, DateTimeKind.Local).AddTicks(2978), "Subdivision: qui", new DateTime(2022, 4, 26, 0, 19, 52, 725, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da793a1d-34e6-49e6-8d4c-b9ca1583d714"), "Accusantium doloribus laboriosam ad architecto.", "1fe7ca33-627f-4943-b9b6-7d0be5e57952", new DateTime(2018, 9, 17, 11, 7, 51, 965, DateTimeKind.Local).AddTicks(6310), "Subdivision: iusto", new DateTime(2021, 8, 26, 7, 22, 49, 728, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dad1cf4e-c051-4cc2-ae5f-c65c3a6cf9ac"), "Hic unde veritatis et.", "02759a60-15df-477a-bbe8-9ee67f4aa035", new DateTime(2022, 1, 1, 9, 29, 25, 269, DateTimeKind.Local).AddTicks(1249), "Subdivision: voluptatem", new DateTime(2022, 3, 12, 11, 51, 15, 40, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ddc9e5c5-e4fc-4471-b581-09c4d8829a34"), "Aut et voluptate.", "e7ff4e02-fa6d-4ff6-a4ee-59e58a41ba26", new DateTime(2021, 1, 5, 15, 23, 10, 624, DateTimeKind.Local).AddTicks(5644), "Subdivision: culpa", new DateTime(2022, 3, 19, 4, 8, 29, 551, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5ad006b-5cb3-4097-a596-407e65229d33"), "Doloremque qui iste quis voluptas quod consequatur at omnis.", "cfdc5628-8fd7-419f-85e9-2269ee0a1b3c", new DateTime(2018, 12, 26, 2, 25, 23, 66, DateTimeKind.Local).AddTicks(4881), "Subdivision: soluta", new DateTime(2020, 7, 11, 9, 29, 34, 748, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e9c2a339-8a31-4f61-ae3f-214927a1feb9"), "Corrupti delectus consequatur excepturi doloremque quas consequuntur reiciendis ea.", "6e3de141-03e7-4f59-97ef-9b5234612f4f", new DateTime(2018, 2, 27, 7, 59, 45, 287, DateTimeKind.Local).AddTicks(4387), "Subdivision: saepe", new DateTime(2018, 12, 15, 0, 45, 18, 432, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec1fb5e9-dae5-4c71-9bdd-e69c6847cf36"), "Non quaerat ab amet tenetur et ut.", "f36d4bdb-7019-44d9-b93c-cc236fd306e2", new DateTime(2018, 1, 23, 9, 8, 18, 215, DateTimeKind.Local).AddTicks(986), "Subdivision: a", new DateTime(2020, 6, 15, 19, 0, 2, 277, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed722730-bd70-4680-aebb-83d490e44a6b"), "Ex quibusdam laudantium ut quia est.", "033efd44-bfc3-4f3d-ad1f-58cb4fa1faba", new DateTime(2019, 9, 27, 0, 45, 29, 101, DateTimeKind.Local).AddTicks(6767), "Subdivision: incidunt", new DateTime(2020, 3, 26, 13, 33, 31, 672, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef2cd0b9-6e3f-4911-947d-4fff494e845d"), "Odio corrupti odio est enim eaque corrupti omnis voluptatem nobis.", "6c17448c-7c4f-4663-8b5f-7e33d4b23cd0", new DateTime(2022, 6, 30, 5, 52, 51, 214, DateTimeKind.Local).AddTicks(7425), "Subdivision: aliquid", new DateTime(2022, 7, 1, 17, 24, 4, 202, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f1eb49cd-54ed-412c-ad2a-74f05a4bed73"), "Est recusandae et mollitia mollitia nihil odio sed.", "90eaa233-eba8-4d70-885a-f4a9691631b2", new DateTime(2021, 3, 31, 2, 28, 38, 521, DateTimeKind.Local).AddTicks(2470), "Subdivision: suscipit", new DateTime(2021, 12, 4, 0, 44, 22, 228, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f346cfd6-4b05-4c9b-be10-e697ee1f8259"), "Ipsam magnam aut consectetur.", "22cf7804-cd0d-4347-87fe-283bc34f45d7", new DateTime(2022, 1, 18, 15, 35, 9, 648, DateTimeKind.Local).AddTicks(1275), "Subdivision: quis", new DateTime(2022, 3, 17, 13, 23, 31, 995, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc01104f-52c9-445b-8ef7-b83967e04872"), "Voluptatem exercitationem nam vitae harum ea dolorum ullam.", "22971c15-df2d-492a-9707-5b04e365d971", new DateTime(2019, 1, 21, 14, 52, 36, 142, DateTimeKind.Local).AddTicks(2986), "Subdivision: delectus", new DateTime(2021, 8, 27, 4, 10, 0, 281, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc632164-90f7-4afa-aeed-9c1d5c31763c"), "Impedit pariatur autem corporis laborum ducimus voluptas doloribus perferendis.", "bcb5ff10-84c7-4f97-b5ff-3966fcf976ac", new DateTime(2017, 8, 14, 7, 14, 32, 711, DateTimeKind.Local).AddTicks(8700), "Subdivision: est", new DateTime(2020, 12, 17, 0, 50, 44, 764, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fcda2a47-c00d-4200-85da-61e25e92b551"), "Exercitationem harum minus.", "d9c40dd3-aa4e-4d74-bc20-af9431bb9405", new DateTime(2019, 7, 1, 16, 18, 45, 227, DateTimeKind.Local).AddTicks(556), "Subdivision: aspernatur", new DateTime(2022, 5, 21, 4, 15, 58, 277, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe615f28-bf32-46ff-8302-9ba83da74b99"), "Omnis maiores alias quos rerum impedit molestiae molestiae error et.", "48a43901-1a2f-4bc6-b9c7-b3d7c8175e16", new DateTime(2020, 7, 14, 14, 58, 36, 559, DateTimeKind.Local).AddTicks(3913), "Subdivision: hic", new DateTime(2021, 3, 8, 0, 53, 38, 185, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("01272d42-aedb-4cb1-ba1f-6efd214a6b5c"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Voluptatem maiores enim et consequuntur et qui.", "6e1c5790-9251-4de8-aa8c-c81b3be7df75", new DateTime(2018, 5, 25, 13, 53, 9, 310, DateTimeKind.Local).AddTicks(5406), "6218 Rashawn Centers, West Sheahaven, Lithuania", new DateTime(2020, 6, 28, 16, 50, 47, 578, DateTimeKind.Local).AddTicks(1252), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("0151bd95-dea0-43f0-8ce8-ba44aeb6ea6a"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Nobis distinctio et.", "05a17f64-8b70-4c37-9bb4-6128f5f2e367", new DateTime(2022, 3, 5, 0, 40, 15, 718, DateTimeKind.Local).AddTicks(2219), "32178 Wisoky Freeway, Port Damion, Qatar", new DateTime(2022, 5, 6, 2, 5, 24, 72, DateTimeKind.Local).AddTicks(1360), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("03ae289d-cba6-4dfb-baa3-ee991335f6fc"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Laboriosam tempore est ea aut vel non.", "ef107227-4e0e-4ceb-b201-9703c9be1d61", new DateTime(2019, 9, 8, 12, 55, 30, 421, DateTimeKind.Local).AddTicks(3018), "67208 Genoveva Drive, Rempelhaven, Luxembourg", new DateTime(2020, 1, 20, 21, 5, 8, 298, DateTimeKind.Local).AddTicks(2755), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("07b34e3e-f16e-4f7c-9dc1-d341a8801a1f"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Ex iste debitis eligendi omnis.", "d829b555-924b-463b-b9f6-6d6db51af58b", new DateTime(2021, 4, 3, 16, 52, 4, 72, DateTimeKind.Local).AddTicks(2303), "36911 William Mall, O'Keefeton, Swaziland", new DateTime(2021, 11, 15, 0, 10, 44, 394, DateTimeKind.Local).AddTicks(2287), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("0c6d88ae-e3d1-4357-847c-a6ade9829f45"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Est sit incidunt.", "d8790591-cd39-4eb6-a4e3-89611139f916", new DateTime(2020, 10, 10, 8, 47, 49, 436, DateTimeKind.Local).AddTicks(7491), "94215 Eleanore Ferry, Zulashire, Macedonia", new DateTime(2021, 12, 28, 22, 25, 22, 563, DateTimeKind.Local).AddTicks(8971), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("0cdb861e-c51d-4019-b78c-5265b83adc30"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "A autem debitis non iure sed a minus.", "3cdfeb12-6462-4b81-8fde-290e77b6aeec", new DateTime(2020, 4, 7, 0, 55, 37, 34, DateTimeKind.Local).AddTicks(2285), "47381 Justus Via, Quincyfurt, Reunion", new DateTime(2022, 3, 9, 7, 24, 28, 461, DateTimeKind.Local).AddTicks(9310), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("17ef5a88-b664-4e7a-9acd-e023d2447519"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Voluptas sunt rerum alias quam alias est est.", "c10d10c2-3c81-4257-ac30-9bb74aae459f", new DateTime(2021, 2, 19, 23, 4, 19, 403, DateTimeKind.Local).AddTicks(6348), "53369 Towne Ford, Dietrichville, Somalia", new DateTime(2021, 7, 21, 16, 7, 34, 688, DateTimeKind.Local).AddTicks(3741), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("18bbe028-d8bc-4d57-b1dc-3943286ff1c4"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Enim sequi ipsum deleniti enim aliquid rerum ut est.", "c8c1afd0-ca11-459a-af31-2c81506e7be9", new DateTime(2022, 2, 7, 1, 2, 19, 144, DateTimeKind.Local).AddTicks(7825), "55290 Mertz Flat, Port Roosevelt, Netherlands Antilles", new DateTime(2022, 5, 1, 9, 10, 31, 377, DateTimeKind.Local).AddTicks(1999), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("1cd62248-c242-489f-99e4-a2696efc2b42"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Minima autem asperiores porro ut quia dolore.", "005cb705-6bd9-4dd0-b373-2e7f58ca2d8b", new DateTime(2018, 10, 9, 17, 58, 29, 998, DateTimeKind.Local).AddTicks(5722), "3447 Ritchie Terrace, Kuhlmanton, Tuvalu", new DateTime(2021, 10, 31, 23, 30, 4, 77, DateTimeKind.Local).AddTicks(2495), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("25a48504-9651-4d63-bd8e-8164ac80b644"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Quod voluptatem maxime pariatur dolores.", "9a7f5b21-a1e7-467b-8d43-55cf2089cfef", new DateTime(2020, 11, 16, 18, 12, 5, 453, DateTimeKind.Local).AddTicks(4350), "87651 Brenna Mount, Port Wava, French Polynesia", new DateTime(2020, 12, 13, 12, 2, 36, 600, DateTimeKind.Local).AddTicks(8096), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("25d7b3f9-7fff-4a2d-abf8-2c542f43fe27"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Ut possimus laudantium voluptas.", "609823c6-5a73-44c5-9221-6c251e9bee36", new DateTime(2020, 11, 13, 0, 36, 15, 274, DateTimeKind.Local).AddTicks(3667), "09428 Rippin Common, Ebbaview, Czech Republic", new DateTime(2021, 4, 25, 5, 39, 17, 670, DateTimeKind.Local).AddTicks(4921), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("25fa565e-852a-4bfc-9e3e-ed61c229ae9c"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Perferendis nostrum est laborum omnis maxime in iusto dolorum.", "15e0d8db-64ae-4207-ac48-7ea975ec6bf3", new DateTime(2020, 4, 9, 16, 54, 7, 338, DateTimeKind.Local).AddTicks(6294), "87033 Arch Ridge, Port Nathenborough, Greece", new DateTime(2021, 7, 9, 21, 13, 24, 49, DateTimeKind.Local).AddTicks(8437), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("2721e360-d896-4e09-a214-c4c311e8dfe0"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Autem iure dolorum sed est tempore dolorum laboriosam minima necessitatibus.", "a6968ff7-491a-4ce1-b4fc-07e3045e3d8a", new DateTime(2021, 3, 10, 21, 54, 14, 486, DateTimeKind.Local).AddTicks(6085), "2099 Thurman Common, West Adelle, Lesotho", new DateTime(2021, 4, 4, 4, 57, 5, 457, DateTimeKind.Local).AddTicks(2871), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("2c125d03-18e1-42ff-b8c6-425bd35f7bb0"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Voluptatibus pariatur commodi necessitatibus totam commodi laudantium a aut quis.", "800bdaf8-461c-490e-9f6a-e27ef01addf7", new DateTime(2020, 5, 24, 5, 17, 35, 139, DateTimeKind.Local).AddTicks(3046), "381 Kihn Mountain, Kaceytown, Kiribati", new DateTime(2021, 4, 18, 19, 40, 7, 448, DateTimeKind.Local).AddTicks(2421), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("2d35c993-71af-4491-a884-c1ef73168593"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Quos aut provident.", "dd54b90f-e2b4-4967-85e1-5ee5d4c78c0b", new DateTime(2020, 8, 6, 11, 41, 17, 765, DateTimeKind.Local).AddTicks(4504), "59851 Bradtke Lights, Botsfordburgh, Nicaragua", new DateTime(2021, 7, 29, 1, 57, 27, 726, DateTimeKind.Local).AddTicks(561), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("2d91c387-9b1a-472c-bbfb-8d16ebcafbba"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Deserunt ut velit corporis quod perspiciatis.", "88189b33-5f25-4dac-8e74-432320b9c3ea", new DateTime(2021, 2, 12, 6, 45, 33, 806, DateTimeKind.Local).AddTicks(3089), "099 Eunice Corner, Hiltonport, Haiti", new DateTime(2021, 9, 28, 15, 37, 58, 642, DateTimeKind.Local).AddTicks(9004), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("2e306f84-862a-4ea7-b97f-509404ad840a"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Officiis pariatur consequatur labore ab aut eius iure molestiae impedit.", "b533c366-3083-4575-b461-75ff947581e8", new DateTime(2020, 11, 6, 8, 39, 40, 547, DateTimeKind.Local).AddTicks(4330), "9937 Dennis Courts, Lake Geovanny, Isle of Man", new DateTime(2022, 5, 30, 5, 27, 17, 579, DateTimeKind.Local).AddTicks(2250), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("2ec0ad0a-7e7e-4c5d-8395-3693e4ccf11b"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Mollitia excepturi aspernatur.", "8874e1fb-3e9d-4aab-bc7f-34fbbd72d6ef", new DateTime(2018, 7, 27, 8, 42, 57, 478, DateTimeKind.Local).AddTicks(8288), "352 Gutmann Spurs, Oniefurt, Taiwan", new DateTime(2022, 3, 31, 9, 47, 4, 987, DateTimeKind.Local).AddTicks(6514), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("31528d30-df64-4adf-9d23-2d08c6f9f792"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Natus dignissimos rerum qui delectus.", "2d59c8e5-13b4-4e15-b99d-019891f4ec65", new DateTime(2021, 8, 5, 8, 16, 56, 500, DateTimeKind.Local).AddTicks(9951), "65992 Gordon Tunnel, Siennaberg, Kyrgyz Republic", new DateTime(2022, 3, 9, 7, 21, 41, 149, DateTimeKind.Local).AddTicks(8675), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("32ae417b-16c7-4b8e-b88c-4a1d850049b1"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Dolore qui hic porro.", "9ec7b865-48df-4a64-afa6-774a163bfba0", new DateTime(2019, 5, 31, 9, 0, 57, 730, DateTimeKind.Local).AddTicks(1611), "6800 Waelchi Light, North Leathaport, Switzerland", new DateTime(2020, 10, 18, 19, 44, 59, 626, DateTimeKind.Local).AddTicks(7746), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("36ebe57c-3161-49eb-98df-92ea0901dfb6"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Corrupti inventore consequatur blanditiis rerum maiores.", "343e1047-88a8-4c97-acce-8ac132fa06c9", new DateTime(2018, 7, 17, 8, 42, 9, 799, DateTimeKind.Local).AddTicks(4292), "36208 Kaleb Crest, New Andres, Equatorial Guinea", new DateTime(2019, 10, 8, 1, 12, 54, 623, DateTimeKind.Local).AddTicks(1502), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("37c1d1fc-5735-488e-a56b-38ebf913e948"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Eum molestiae aut ex voluptatem labore.", "7a672450-79fb-4c2d-8464-25ab58b72195", new DateTime(2018, 12, 22, 19, 6, 28, 849, DateTimeKind.Local).AddTicks(4638), "36289 Arvel Alley, Regantown, Benin", new DateTime(2020, 8, 5, 15, 30, 41, 903, DateTimeKind.Local).AddTicks(6619), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("3f1f334a-f5a0-4399-8a9c-5ed7214c4731"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Id eveniet vero velit aut est odit delectus.", "c5712688-e12a-4d6c-a119-74c8d5b5a523", new DateTime(2019, 9, 27, 11, 38, 3, 442, DateTimeKind.Local).AddTicks(9314), "776 Orpha Via, Lake Maynard, Nepal", new DateTime(2022, 4, 25, 1, 13, 44, 714, DateTimeKind.Local).AddTicks(8636), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("408c0f5d-d043-4ded-9910-00b5047cf576"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Et est id esse.", "ea280bc2-206c-478a-99ea-5a83f55d230f", new DateTime(2019, 10, 21, 1, 29, 24, 351, DateTimeKind.Local).AddTicks(4739), "822 King Shoals, Andersonview, Rwanda", new DateTime(2020, 2, 14, 20, 49, 14, 682, DateTimeKind.Local).AddTicks(5000), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("43e138f5-2aab-44ba-a8be-b02756b092dc"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Quo ab explicabo a et non provident velit accusamus consequatur.", "e19f7e50-ae40-4760-8b20-c5cd0dd98296", new DateTime(2020, 5, 17, 6, 27, 52, 824, DateTimeKind.Local).AddTicks(4607), "6150 Mireille Manor, New Camrynburgh, Mayotte", new DateTime(2021, 11, 6, 0, 27, 21, 693, DateTimeKind.Local).AddTicks(3769), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("4d14d930-c533-4647-a89c-269dd938f582"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Id assumenda provident enim consequatur eveniet ea dolorum voluptates.", "73f7b49f-51f1-4aca-9c40-036fc2fd33fb", new DateTime(2022, 4, 7, 9, 56, 8, 30, DateTimeKind.Local).AddTicks(1650), "391 Kuphal Station, Nathanmouth, Heard Island and McDonald Islands", new DateTime(2022, 4, 30, 2, 37, 23, 544, DateTimeKind.Local).AddTicks(2998), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("4f68eca7-5811-4de2-89d5-1bf5b0727d44"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Odit nesciunt in.", "26d4a430-b39a-40bf-a335-58c8c5761f70", new DateTime(2020, 4, 4, 4, 5, 18, 702, DateTimeKind.Local).AddTicks(314), "086 Clementina Brook, Kristofferland, Falkland Islands (Malvinas)", new DateTime(2021, 12, 16, 22, 24, 45, 976, DateTimeKind.Local).AddTicks(8971), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("557b8dc6-c924-4679-b618-82eee3a650db"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Quia animi dolores similique.", "e5fba8b6-38df-4f7e-846a-47475f85f174", new DateTime(2019, 4, 18, 23, 18, 24, 878, DateTimeKind.Local).AddTicks(1125), "168 Okuneva Crescent, Jarrodborough, Rwanda", new DateTime(2022, 1, 12, 1, 2, 41, 265, DateTimeKind.Local).AddTicks(3491), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("57fda32f-ae8f-4ac4-aebe-fce30f81cef7"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Odio quas qui.", "f35bf84a-c80a-4292-a706-aaff6aa5ed7a", new DateTime(2020, 6, 2, 22, 21, 6, 769, DateTimeKind.Local).AddTicks(3953), "2889 Douglas Mountain, East Thomasmouth, Norfolk Island", new DateTime(2020, 12, 8, 16, 42, 57, 186, DateTimeKind.Local).AddTicks(4046), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("5e49f446-6bfe-4de7-8afe-73ed097a7783"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Nihil fugiat quo ut ab est dolorem ex qui.", "22d7faa6-781c-48ef-8312-fb7fd33fc433", new DateTime(2021, 4, 13, 9, 48, 37, 157, DateTimeKind.Local).AddTicks(7830), "21999 Ratke Roads, North Daronton, Poland", new DateTime(2021, 10, 21, 10, 20, 41, 487, DateTimeKind.Local).AddTicks(317), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("604ec4c5-fefb-48ea-97b2-e6f01c7fa7a8"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Aspernatur eum nisi recusandae rerum.", "17db2684-e2d0-4fd0-8260-26eaf03e96a3", new DateTime(2022, 5, 22, 15, 24, 39, 586, DateTimeKind.Local).AddTicks(9511), "7984 Jayda Road, South Darenberg, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2022, 5, 24, 0, 2, 53, 893, DateTimeKind.Local).AddTicks(3849), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("6279bdbe-0f9c-46af-9092-80aaf7540e58"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Maiores cumque aut dolores voluptas rem consequuntur voluptatem.", "9d065969-5de0-417e-b121-475cf924459e", new DateTime(2021, 4, 6, 10, 28, 38, 721, DateTimeKind.Local).AddTicks(5004), "693 Fay Mews, Jerrellton, Cote d'Ivoire", new DateTime(2021, 12, 13, 4, 13, 7, 38, DateTimeKind.Local).AddTicks(3355), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("6773bcbe-5c7a-4569-b5b4-b758cd3fc261"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Deserunt voluptatem accusamus corrupti odit.", "d99f1433-6f08-46aa-8062-4fce17bee96c", new DateTime(2018, 7, 17, 6, 39, 43, 325, DateTimeKind.Local).AddTicks(6662), "156 Legros Square, West Clara, Oman", new DateTime(2020, 6, 5, 9, 42, 9, 226, DateTimeKind.Local).AddTicks(5633), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("68134145-2a01-4661-859a-191bdf3aedc7"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Tenetur corporis ipsa.", "30e66bc8-cfc5-4bf6-94f2-68e429086d0a", new DateTime(2021, 5, 20, 6, 30, 12, 526, DateTimeKind.Local).AddTicks(9830), "1939 Hirthe Glen, New Hobart, Guinea-Bissau", new DateTime(2021, 10, 3, 17, 41, 12, 836, DateTimeKind.Local).AddTicks(6602), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("6a138658-faae-424a-b5bb-260ba7a0d0c8"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Non iste eaque atque similique voluptas ut.", "90d5dc2b-9fe3-4b34-85ea-e10f98a5e506", new DateTime(2017, 10, 19, 19, 56, 24, 855, DateTimeKind.Local).AddTicks(3111), "66279 Denesik Skyway, East Chrishaven, India", new DateTime(2022, 6, 18, 12, 51, 20, 307, DateTimeKind.Local).AddTicks(1739), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("75a6d25f-122e-41b1-b4ed-cc8757a59aab"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "A nemo eveniet autem voluptatem expedita libero.", "312b4cde-b3ad-4025-a5ed-67d8c6afcca5", new DateTime(2020, 3, 10, 20, 10, 41, 408, DateTimeKind.Local).AddTicks(3382), "047 Reilly Motorway, Metzborough, Trinidad and Tobago", new DateTime(2020, 12, 25, 17, 48, 0, 549, DateTimeKind.Local).AddTicks(4645), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("75c5a74b-897f-49b5-beab-e9771542f9fa"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Et a ducimus debitis reiciendis.", "7f4aaa62-6604-457c-bdcc-75a2c74ce927", new DateTime(2018, 12, 23, 7, 38, 22, 521, DateTimeKind.Local).AddTicks(2496), "719 Trevor Dam, Burnicetown, Poland", new DateTime(2020, 1, 10, 17, 46, 54, 43, DateTimeKind.Local).AddTicks(236), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("75ebab37-ce81-4ebf-a879-7f2a2de58d24"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Minus quisquam eum cupiditate ea.", "f0424021-5c02-44a5-952f-5ca4e036c6a5", new DateTime(2020, 6, 6, 15, 1, 8, 428, DateTimeKind.Local).AddTicks(6651), "070 Mac Brooks, Mohrfort, Canada", new DateTime(2021, 9, 12, 12, 27, 11, 364, DateTimeKind.Local).AddTicks(8308), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("76176ce8-dceb-4a1c-8b50-4081bd8acc25"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Consequuntur iure accusamus.", "ae4cb694-4136-4dd2-929f-d353023e5db4", new DateTime(2018, 2, 22, 19, 22, 30, 420, DateTimeKind.Local).AddTicks(6225), "8988 Myron Locks, New Rose, Netherlands", new DateTime(2022, 6, 27, 10, 10, 42, 201, DateTimeKind.Local).AddTicks(5896), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("829d349a-3ee6-4f1f-8925-07eaa915d80e"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Ratione natus quasi.", "dfef199c-2774-4d2d-845d-e93244820cd9", new DateTime(2017, 12, 7, 17, 10, 0, 689, DateTimeKind.Local).AddTicks(6805), "3624 O'Hara Parkway, West Kirsten, Denmark", new DateTime(2018, 1, 19, 2, 16, 56, 65, DateTimeKind.Local).AddTicks(5206), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("84989bc0-6201-4565-9282-0fe136537b53"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Nemo debitis vel.", "01889468-cf96-486d-a04c-111a9f183d26", new DateTime(2019, 5, 26, 14, 34, 28, 436, DateTimeKind.Local).AddTicks(7774), "19207 Carter Estates, Jerdechester, Pakistan", new DateTime(2019, 6, 26, 13, 54, 55, 28, DateTimeKind.Local).AddTicks(7978), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("8593c7a6-b151-49a6-bed6-83c534e8648b"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Itaque omnis laudantium voluptatem.", "0dd73fa1-e23b-4d80-8660-48d474019ba8", new DateTime(2018, 3, 26, 18, 13, 51, 743, DateTimeKind.Local).AddTicks(3313), "234 Prosacco Mountain, Hahnchester, Montserrat", new DateTime(2021, 2, 9, 23, 45, 5, 32, DateTimeKind.Local).AddTicks(4926), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("865afdd0-1f98-48c1-81a4-4afa5cec77b4"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Qui quaerat optio maiores autem ullam error aut.", "c6f8a28b-5728-42c0-8990-a375a97716aa", new DateTime(2021, 7, 9, 23, 29, 39, 118, DateTimeKind.Local).AddTicks(8869), "882 Hilll Views, Port Guyfort, India", new DateTime(2022, 4, 6, 13, 0, 27, 472, DateTimeKind.Local).AddTicks(7840), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("869aba8b-51f8-4eb7-8b66-221395f3dfda"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Facere ea quaerat natus et dolore suscipit ut vel.", "ff83d6a1-5f8d-4554-983c-5c8678ebf2e6", new DateTime(2019, 8, 15, 9, 40, 7, 861, DateTimeKind.Local).AddTicks(8629), "7763 Dach Turnpike, Trantowberg, Mozambique", new DateTime(2022, 1, 8, 3, 20, 23, 15, DateTimeKind.Local).AddTicks(2988), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("8867cf95-52d3-46a9-9dcf-a477f7b2e62f"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Perferendis non pariatur impedit sed magni debitis veritatis unde accusantium.", "fbff017b-a09e-487c-b1b9-98a9cac5f24f", new DateTime(2019, 5, 21, 18, 35, 24, 963, DateTimeKind.Local).AddTicks(9160), "028 Flatley Villages, New Hellen, Guinea", new DateTime(2022, 6, 14, 7, 8, 51, 633, DateTimeKind.Local).AddTicks(7973), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("89739116-e437-4107-bbc1-1b830e83b002"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Omnis inventore in quod harum optio reiciendis aliquid.", "d89739a5-11f0-47fb-8f14-fadda61539f8", new DateTime(2019, 10, 18, 15, 47, 36, 687, DateTimeKind.Local).AddTicks(7192), "8007 Libby Gateway, East Beaulahmouth, Tuvalu", new DateTime(2022, 1, 9, 6, 12, 27, 399, DateTimeKind.Local).AddTicks(7173), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("91fa30fb-22cb-4c5a-ab1b-c8f4c0448fb5"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Et modi expedita modi porro suscipit.", "5f9b7043-1f31-47a6-9c3f-0e31913b3e9d", new DateTime(2019, 7, 28, 2, 55, 10, 582, DateTimeKind.Local).AddTicks(1004), "2987 Rohan Radial, West Faustinoberg, Uganda", new DateTime(2021, 3, 19, 8, 59, 31, 829, DateTimeKind.Local).AddTicks(1379), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("92966c11-4673-4d6d-b81c-348fc07d4279"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Earum est ipsam nam voluptates quia laborum quis qui exercitationem.", "9bcb0f08-b1c0-488d-996d-d44d441c96be", new DateTime(2019, 1, 1, 17, 38, 11, 39, DateTimeKind.Local).AddTicks(5782), "44032 Vandervort Ways, New Herta, Finland", new DateTime(2020, 7, 23, 6, 1, 7, 473, DateTimeKind.Local).AddTicks(3629), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("93648c29-bbc5-40a6-9ea1-0a985829c9f7"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Dignissimos sequi placeat veritatis voluptatem et.", "555efe5c-8e24-4450-9b30-0501dca925a9", new DateTime(2022, 3, 18, 1, 56, 33, 44, DateTimeKind.Local).AddTicks(9367), "3431 Maddison Mission, Andersonton, Virgin Islands, British", new DateTime(2022, 4, 8, 0, 27, 46, 425, DateTimeKind.Local).AddTicks(6039), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("953dd549-faaa-47f0-9871-25522775333b"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Nobis labore necessitatibus voluptas.", "0058c318-5fb5-4a3d-af57-8e408a1ec394", new DateTime(2021, 6, 23, 13, 49, 33, 62, DateTimeKind.Local).AddTicks(4725), "6989 Fahey Meadows, Oberbrunnerside, Cyprus", new DateTime(2021, 7, 12, 13, 25, 45, 888, DateTimeKind.Local).AddTicks(8780), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("969b1249-fd16-4baf-9cac-2e851b121827"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Eos laudantium sed dignissimos illo iusto autem esse quo.", "ba907a44-c8ca-4b48-bbe5-ed904d8be226", new DateTime(2017, 10, 9, 11, 57, 31, 278, DateTimeKind.Local).AddTicks(5836), "1669 White Ford, South Mackmouth, Netherlands Antilles", new DateTime(2021, 9, 24, 0, 10, 7, 554, DateTimeKind.Local).AddTicks(1327), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("99e68497-16e9-413e-aba3-bba7b5271b82"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Voluptatem rerum est perferendis amet quod iste maxime modi tenetur.", "6a4a9772-15fe-4046-9b55-1dfba6d1fe01", new DateTime(2019, 10, 18, 0, 51, 26, 772, DateTimeKind.Local).AddTicks(185), "346 Zieme Mountain, Boscofurt, Democratic People's Republic of Korea", new DateTime(2020, 2, 13, 9, 46, 35, 722, DateTimeKind.Local).AddTicks(7586), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("9b9b5aa7-edfb-4bc7-aab0-c0763c72caa8"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Aut aperiam accusantium in aspernatur.", "5ec37858-32b1-471e-a815-f03fc5667543", new DateTime(2018, 9, 18, 11, 34, 52, 172, DateTimeKind.Local).AddTicks(5352), "9459 Adaline Spurs, Zulaufberg, Reunion", new DateTime(2021, 6, 30, 13, 27, 23, 80, DateTimeKind.Local).AddTicks(28), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("9d2adf28-4cb8-404c-8d8f-9bce386fb195"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Libero voluptatibus sapiente voluptates recusandae recusandae est debitis ducimus.", "267828c0-5342-4cd7-a5a2-428e9ce8ffdc", new DateTime(2019, 1, 25, 22, 43, 15, 141, DateTimeKind.Local).AddTicks(7760), "262 Kohler Port, Sawaynborough, Peru", new DateTime(2020, 11, 28, 4, 8, 34, 308, DateTimeKind.Local).AddTicks(1522), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a1f4037a-c72c-434e-b159-ae0ceaf4df0b"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Nihil autem enim quod sequi.", "2c44e381-39cb-49a6-b383-c72b7ee2f4e4", new DateTime(2022, 4, 28, 18, 57, 20, 96, DateTimeKind.Local).AddTicks(3714), "5916 Zboncak Junction, Goldenview, Gibraltar", new DateTime(2022, 5, 6, 12, 0, 5, 523, DateTimeKind.Local).AddTicks(1017), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a209c80f-a5fe-40fe-9dca-d15a725a75f4"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Commodi debitis et velit ut voluptates rerum quisquam.", "1126e8d6-a02e-49bc-8639-3fef4e6c1a11", new DateTime(2017, 7, 20, 22, 39, 44, 686, DateTimeKind.Local).AddTicks(3692), "10223 Hayes Lights, North Jeniferland, Ethiopia", new DateTime(2022, 2, 24, 22, 59, 59, 975, DateTimeKind.Local).AddTicks(2826), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a2a340d9-4d0c-4be1-8f58-66653ee94eac"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Est perspiciatis mollitia ut rerum dolor molestias qui fugit quia.", "b0f7b396-4cf9-45af-ad32-1e78ca99566b", new DateTime(2018, 5, 13, 21, 21, 59, 904, DateTimeKind.Local).AddTicks(3782), "77285 Sanford Springs, Port Ernest, Timor-Leste", new DateTime(2021, 12, 9, 21, 51, 15, 207, DateTimeKind.Local).AddTicks(8937), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a4f48a2c-174d-449c-a75d-3101152ed5f6"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Debitis laudantium ducimus qui aliquam alias architecto.", "e062707e-194e-48ab-a247-da96978b37d7", new DateTime(2021, 7, 7, 9, 39, 56, 441, DateTimeKind.Local).AddTicks(7117), "99492 Jerry Mountains, West Carissabury, Vanuatu", new DateTime(2022, 6, 11, 10, 41, 46, 124, DateTimeKind.Local).AddTicks(109), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a5236cb5-944a-481a-9ce3-f7124f116b60"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Recusandae rerum architecto ab accusamus nihil.", "f091695e-f051-424f-ae11-95c7c46f29d9", new DateTime(2022, 7, 4, 11, 12, 46, 402, DateTimeKind.Local).AddTicks(5944), "181 Gregoria Forks, Dustinside, Liberia", new DateTime(2022, 7, 6, 2, 29, 1, 280, DateTimeKind.Local).AddTicks(6461), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a54f1502-8e4b-48b6-a3ec-a89f75af69e6"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Sint asperiores pariatur labore et aut quae et.", "bcd2b06f-05f1-481c-a5da-8b4c832fd0be", new DateTime(2022, 7, 1, 23, 48, 40, 707, DateTimeKind.Local).AddTicks(6745), "31272 Gusikowski Walk, Lake Raymondchester, Sri Lanka", new DateTime(2022, 7, 5, 19, 4, 3, 597, DateTimeKind.Local).AddTicks(3294), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a66b1615-7ee2-474e-87f1-323cc092b536"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Ullam qui ea in dolorem nobis enim qui.", "9885ed4d-586e-4439-9411-2f24bd5b8e06", new DateTime(2021, 2, 19, 13, 9, 55, 631, DateTimeKind.Local).AddTicks(7346), "0619 Keeling Hill, East Marietta, Cook Islands", new DateTime(2022, 1, 14, 14, 55, 21, 50, DateTimeKind.Local).AddTicks(7358), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a6cbd5ec-8654-4237-8fe3-63516b24f5ba"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Consequatur magni earum.", "06260d3d-3443-4ecc-a909-a409bd7c0533", new DateTime(2018, 1, 13, 16, 58, 57, 411, DateTimeKind.Local).AddTicks(2302), "482 Loren Drive, New Keelymouth, Eritrea", new DateTime(2018, 4, 10, 18, 51, 2, 47, DateTimeKind.Local).AddTicks(2008), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("a72d7da3-a238-4153-a99f-1f2b8eeb1c31"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Provident mollitia omnis ea molestiae.", "fe315e7b-480a-4871-bf89-f23943b6f525", new DateTime(2021, 5, 18, 14, 2, 56, 904, DateTimeKind.Local).AddTicks(9165), "94725 Moses Common, North Magdalena, Monaco", new DateTime(2022, 2, 2, 18, 11, 12, 587, DateTimeKind.Local).AddTicks(7108), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("ab061cc2-697a-46d6-b843-c073fade4361"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Qui suscipit aut fugit iure odit in consectetur eos.", "4cef6896-c1ec-48ee-81d8-8d5558e7fbee", new DateTime(2022, 1, 13, 6, 12, 34, 910, DateTimeKind.Local).AddTicks(5300), "7965 Emiliano Isle, Port Ivahport, Mexico", new DateTime(2022, 4, 28, 17, 41, 44, 298, DateTimeKind.Local).AddTicks(5313), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("abd807a4-f76e-4792-93ee-05a4b521b9b5"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Ducimus quo blanditiis dolorum voluptatem sint vitae ut fugiat.", "453e33dd-41c9-4a42-8c8b-77a8d40640ae", new DateTime(2021, 4, 26, 6, 29, 10, 930, DateTimeKind.Local).AddTicks(1767), "95325 Garrett Street, West Marianashire, Lithuania", new DateTime(2021, 10, 27, 14, 34, 33, 727, DateTimeKind.Local).AddTicks(133), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("b07955aa-fa1d-4bc2-bbd0-1c0a170a7226"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Repellat debitis sint quae magni veritatis laborum eius.", "e6c49349-11ab-45d6-814d-d1dc49cba716", new DateTime(2019, 11, 14, 8, 22, 21, 704, DateTimeKind.Local).AddTicks(6770), "63571 Benton Station, Murphychester, Sao Tome and Principe", new DateTime(2022, 2, 2, 13, 19, 38, 701, DateTimeKind.Local).AddTicks(3929), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("b2dcc305-4fe2-431b-861e-d3b2df2b3464"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Non voluptate et in magni perferendis necessitatibus explicabo ut.", "91a58ba2-96c1-42d3-82bf-9f4ad104f0ac", new DateTime(2018, 9, 28, 9, 15, 10, 768, DateTimeKind.Local).AddTicks(9492), "77838 Will Vista, South Mikehaven, Iran", new DateTime(2020, 2, 25, 12, 23, 9, 133, DateTimeKind.Local).AddTicks(8322), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("b5c26fa8-dc02-43ed-a8a6-3e85cab7be9f"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Error et illum provident fugiat.", "cb90ef70-575e-457e-a205-7054fff93f7e", new DateTime(2020, 4, 11, 5, 49, 13, 808, DateTimeKind.Local).AddTicks(466), "036 Nicklaus Ferry, North Percy, Tuvalu", new DateTime(2022, 1, 23, 17, 51, 39, 553, DateTimeKind.Local).AddTicks(1342), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("b83f6988-c1af-49d8-bc4b-f5cddd1d3fe7"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Veniam iusto rerum facere.", "c2d1c726-9982-443c-aabe-ee5cf2431a2b", new DateTime(2020, 9, 26, 7, 46, 24, 85, DateTimeKind.Local).AddTicks(2930), "06017 Ben Lights, Jacksonfurt, Micronesia", new DateTime(2020, 11, 8, 1, 56, 2, 756, DateTimeKind.Local).AddTicks(4787), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("bc8a7523-d3eb-4c40-b869-4e3bcc701a5a"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Illo aperiam quia est ratione.", "d2f850a5-12b0-4f0c-b000-6aa2320d6a7a", new DateTime(2018, 12, 21, 22, 19, 55, 920, DateTimeKind.Local).AddTicks(3539), "29113 Lina Terrace, North Shanelville, Madagascar", new DateTime(2020, 3, 31, 3, 6, 25, 907, DateTimeKind.Local).AddTicks(6331), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("bfbf948a-d39e-43c3-89c6-df296708abf2"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Voluptas praesentium accusantium sunt sed nihil necessitatibus.", "7b4b616a-fa91-4ec1-960c-3e7e06296631", new DateTime(2018, 11, 14, 8, 44, 52, 419, DateTimeKind.Local).AddTicks(4741), "71172 Norene Courts, Efrenview, Jersey", new DateTime(2021, 4, 9, 19, 52, 27, 288, DateTimeKind.Local).AddTicks(9928), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("c3842bbb-96de-49a7-bdcd-1fc6d970aca2"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Eius ut voluptate ut rerum inventore qui dignissimos quasi est.", "536303f0-90c3-454b-b752-0b8971e66bc8", new DateTime(2018, 2, 14, 21, 48, 0, 955, DateTimeKind.Local).AddTicks(9714), "65621 Tressie Camp, O'Reillyfort, Burundi", new DateTime(2018, 11, 11, 18, 0, 20, 66, DateTimeKind.Local).AddTicks(4700), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("c58d1b00-f7df-446e-8f7c-e7c1b1dfcf60"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Quis id aut perspiciatis voluptatem amet.", "ac34ad49-9eab-4642-a7b3-4c36fcd3c05a", new DateTime(2018, 2, 14, 19, 22, 39, 461, DateTimeKind.Local).AddTicks(5925), "108 Wiegand Vista, Clarkfurt, Cyprus", new DateTime(2019, 1, 9, 21, 46, 6, 86, DateTimeKind.Local).AddTicks(4731), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("c7e3f03c-06f3-405c-b7e2-1aef8d0773db"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Ullam pariatur saepe officia.", "4c7dd3c1-84eb-4a5a-83ce-263bd19c15c7", new DateTime(2017, 10, 2, 19, 33, 33, 935, DateTimeKind.Local).AddTicks(4296), "5394 Stracke Circle, North Aileen, Rwanda", new DateTime(2018, 1, 18, 13, 24, 56, 809, DateTimeKind.Local).AddTicks(1659), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("ca10c840-5e61-4953-b865-d1546a55d2aa"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Sunt est dolores.", "2eba5c4d-ae67-4293-a36c-a410a07ac88b", new DateTime(2022, 1, 31, 7, 41, 32, 839, DateTimeKind.Local).AddTicks(6096), "607 Christiansen Meadows, Maureenshire, Namibia", new DateTime(2022, 5, 16, 12, 49, 46, 630, DateTimeKind.Local).AddTicks(6338), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("ca1a5d7a-2575-43f4-8236-ae49c8722b76"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Doloribus nihil ut voluptatem autem eveniet.", "d67221f8-2b32-436f-b937-b9474acca5b4", new DateTime(2021, 4, 14, 3, 43, 55, 772, DateTimeKind.Local).AddTicks(8724), "89404 Klein Road, Shieldsborough, Turks and Caicos Islands", new DateTime(2021, 10, 2, 3, 26, 7, 295, DateTimeKind.Local).AddTicks(5088), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("cad9bf00-1f22-4471-8861-39c28c12b83a"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Facilis quos repudiandae aperiam voluptatem.", "3494cdad-e357-4ee9-be98-951037ff3ac1", new DateTime(2020, 11, 14, 7, 14, 55, 760, DateTimeKind.Local).AddTicks(6665), "20519 Eloy Causeway, Hickleport, Oman", new DateTime(2021, 6, 6, 5, 30, 23, 21, DateTimeKind.Local).AddTicks(1021), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("cd011119-22f9-43b5-8136-247683757fe3"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Itaque iusto deserunt sed esse.", "214c6348-48c2-44f5-a944-3322b55c5a95", new DateTime(2021, 7, 18, 9, 44, 56, 903, DateTimeKind.Local).AddTicks(7006), "050 Kaley Court, Port Forrest, Singapore", new DateTime(2022, 4, 14, 1, 54, 37, 136, DateTimeKind.Local).AddTicks(9334), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("d054072b-0efe-43cc-ab26-71d74f473b0f"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Iure doloremque mollitia.", "869c243e-67bc-4a53-8ee3-b0134b2fd9b7", new DateTime(2019, 6, 23, 4, 50, 27, 247, DateTimeKind.Local).AddTicks(9504), "0293 Ryan Course, North Randalfurt, Norway", new DateTime(2021, 7, 18, 5, 38, 19, 957, DateTimeKind.Local).AddTicks(9118), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("d1ac07b2-a8ba-4037-a464-ee26cfcfc996"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Suscipit blanditiis ad veniam aut eum et.", "363f40fa-f87e-4020-835f-22a56b5a0ebf", new DateTime(2018, 5, 13, 2, 21, 0, 886, DateTimeKind.Local).AddTicks(893), "5325 Dwight Centers, Breannafurt, Nicaragua", new DateTime(2021, 10, 28, 3, 38, 35, 488, DateTimeKind.Local).AddTicks(3846), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("d34961ac-84ff-4c8c-b041-dcb8c6ad5198"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Soluta qui qui velit voluptates qui ea est.", "e35d20b3-c913-49e7-ac1e-83dc9f74b5f1", new DateTime(2018, 1, 15, 16, 43, 0, 614, DateTimeKind.Local).AddTicks(8827), "2356 Schuppe Parkways, Wolffchester, Serbia", new DateTime(2018, 3, 18, 22, 3, 18, 789, DateTimeKind.Local).AddTicks(8495), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("d43eceb0-e286-403b-b5e9-b0ae654cc900"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Sed velit possimus sint quibusdam velit.", "7c24cfb3-7d38-49e6-86d0-5d51f6f3cf3b", new DateTime(2022, 2, 1, 1, 48, 18, 892, DateTimeKind.Local).AddTicks(8481), "39646 Roderick Throughway, West Valentinbury, Montserrat", new DateTime(2022, 4, 4, 4, 5, 20, 695, DateTimeKind.Local).AddTicks(8830), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("d4f247e4-86f0-434c-b728-631cf1ec0ee9"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Ad alias dolor provident qui velit illum occaecati.", "607b7ed4-c397-42b0-ad9d-6a8fc785b23a", new DateTime(2017, 10, 25, 7, 28, 7, 125, DateTimeKind.Local).AddTicks(7749), "8996 Jackson Flat, Port Bricefurt, Swaziland", new DateTime(2022, 6, 16, 0, 30, 9, 989, DateTimeKind.Local).AddTicks(6690), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("d8c0715a-18fd-4b48-b25f-7774e3b161ce"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Dolores soluta velit sed amet soluta distinctio perferendis.", "7f3b1e6f-b6fc-4a74-91e2-2b8cf1309cac", new DateTime(2022, 6, 25, 0, 36, 40, 224, DateTimeKind.Local).AddTicks(5310), "310 Brakus Forest, Kulasborough, Germany", new DateTime(2022, 6, 25, 6, 15, 26, 794, DateTimeKind.Local).AddTicks(5641), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("dff68a0b-2512-46b9-9dca-391ee6f9820e"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Voluptatem numquam ut.", "1b3a8dec-2838-44b2-adbd-53ad2d597f8d", new DateTime(2021, 12, 17, 10, 48, 12, 235, DateTimeKind.Local).AddTicks(5214), "8113 Una Tunnel, Westtown, Bhutan", new DateTime(2022, 4, 8, 12, 29, 13, 996, DateTimeKind.Local).AddTicks(1125), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("e1c91b46-0a74-4fc0-8c9c-8aab1e4d8436"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Totam aperiam perspiciatis minus numquam rerum.", "28f67502-0af7-4b71-9dae-c9510d25e3d3", new DateTime(2018, 9, 21, 13, 55, 44, 454, DateTimeKind.Local).AddTicks(5644), "49309 Joe Roads, Jesusview, Bahamas", new DateTime(2020, 5, 7, 11, 40, 16, 789, DateTimeKind.Local).AddTicks(9757), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("e2017252-f18c-4bcc-8654-dd6eb1e78b2a"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Molestias quo corporis ut consequatur assumenda minima.", "2a0cd23f-b20c-4b4f-a306-bbca3f70fdcf", new DateTime(2017, 11, 30, 4, 19, 45, 758, DateTimeKind.Local).AddTicks(7251), "937 Blick Parkways, Randalview, Brunei Darussalam", new DateTime(2018, 2, 10, 5, 53, 34, 325, DateTimeKind.Local).AddTicks(4952), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("e324d58a-7540-45d4-b5a3-a4b4b444ae78"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Excepturi rerum voluptatem rerum reiciendis.", "cacc72cb-fc79-44aa-8637-453ea8418438", new DateTime(2021, 7, 12, 13, 12, 12, 667, DateTimeKind.Local).AddTicks(9173), "71027 Huel Islands, New Ivoryhaven, Mali", new DateTime(2022, 3, 18, 3, 11, 22, 53, DateTimeKind.Local).AddTicks(1285), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("e782766c-c360-42cf-9c34-d6386bcb1e4a"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Earum fugiat et assumenda eaque occaecati ut illum vel.", "f1560e8d-8a95-4f8b-a60d-eb1c1d07ad7b", new DateTime(2022, 5, 18, 11, 53, 31, 98, DateTimeKind.Local).AddTicks(579), "3423 Kayden Courts, West Jensenmouth, Guadeloupe", new DateTime(2022, 5, 24, 21, 2, 2, 33, DateTimeKind.Local).AddTicks(5200), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("e8f7a18c-5f45-4c25-b7ef-970ca1a4a513"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Ex voluptates repellendus omnis porro earum quod fugit a accusamus.", "244ad23f-397a-4261-b4e1-1ca77ee3940b", new DateTime(2018, 9, 27, 18, 51, 40, 315, DateTimeKind.Local).AddTicks(2449), "64294 Auer Ranch, Sanfordmouth, France", new DateTime(2019, 6, 17, 7, 47, 13, 925, DateTimeKind.Local).AddTicks(8404), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("ea3c6c83-abb4-44e1-9769-a7ed2be0adc0"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Molestiae saepe aut alias impedit ipsam rerum aut ea.", "62ad1c85-d12b-443b-8b2a-2fada50d7821", new DateTime(2021, 2, 8, 17, 9, 14, 354, DateTimeKind.Local).AddTicks(1869), "2398 Cormier Ports, Fadelchester, United States of America", new DateTime(2021, 10, 16, 15, 8, 30, 369, DateTimeKind.Local).AddTicks(5024), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("f118eaa7-e019-4edd-afa1-93f16c2cfe0d"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Aut voluptatem et est in.", "28bdbbda-e03a-4be0-b59c-dfce6718aeb1", new DateTime(2017, 8, 8, 6, 15, 52, 777, DateTimeKind.Local).AddTicks(7938), "1076 Schultz Trail, Adamshaven, Maldives", new DateTime(2018, 6, 28, 3, 9, 20, 472, DateTimeKind.Local).AddTicks(9148), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("f5544d6b-9e56-476f-b011-e406d558d99c"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Amet nihil nesciunt impedit voluptatem adipisci.", "e0ed71cb-a471-4fce-8206-e81f9ec38e84", new DateTime(2017, 12, 5, 10, 28, 51, 717, DateTimeKind.Local).AddTicks(8592), "02033 Goodwin Turnpike, Mozellstad, South Georgia and the South Sandwich Islands", new DateTime(2020, 8, 24, 8, 22, 32, 371, DateTimeKind.Local).AddTicks(5461), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("f76d2a90-2024-4190-a869-4f7bbed058d9"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Autem voluptas magnam nostrum eos ipsam sit.", "6b9c5548-c5aa-4340-86a2-5117ab52d8d3", new DateTime(2018, 5, 15, 9, 48, 36, 207, DateTimeKind.Local).AddTicks(754), "73947 Keon Parkways, East Ciara, Saudi Arabia", new DateTime(2020, 5, 14, 5, 1, 41, 360, DateTimeKind.Local).AddTicks(5251), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("fa425ec4-4bb1-492a-b4da-4f7628fbbb4d"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Ex et doloribus commodi sed consequatur sequi.", "525b173d-855a-4df9-a93d-f06caf50e81c", new DateTime(2021, 12, 17, 3, 39, 3, 818, DateTimeKind.Local).AddTicks(2884), "025 Nitzsche Valley, Candidotown, Iceland", new DateTime(2022, 5, 31, 1, 50, 41, 929, DateTimeKind.Local).AddTicks(1154), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("fb20161d-28ca-4eaa-b261-0e771a5c515b"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Voluptatibus qui veniam corrupti sed eum eius esse omnis.", "f3c445e4-8f65-46fa-b953-42830e792303", new DateTime(2018, 6, 24, 21, 59, 54, 705, DateTimeKind.Local).AddTicks(2272), "7564 Viviane Extensions, Delorestown, Greece", new DateTime(2022, 3, 24, 10, 19, 29, 617, DateTimeKind.Local).AddTicks(3512), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("fb3c6d5c-345c-4a9b-a250-e9690a31557b"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Id ea repudiandae non et beatae cumque et eos.", "8164e187-f3d8-403f-8433-7eb2832429de", new DateTime(2019, 3, 17, 23, 6, 42, 542, DateTimeKind.Local).AddTicks(4508), "8721 O'Kon Mountain, Margarettstad, Chile", new DateTime(2020, 12, 7, 7, 43, 55, 270, DateTimeKind.Local).AddTicks(7043), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("fbfbca3d-969a-4fea-ad25-40bf48a9d2f6"), new Guid("41e3e946-1333-494f-b7e7-4942089bf425"), null, "Laboriosam ex et consequatur ipsum recusandae ab distinctio voluptatem.", "ae707868-481b-4817-8ef8-2c8fb6ba1a8a", new DateTime(2021, 1, 18, 21, 42, 33, 226, DateTimeKind.Local).AddTicks(7106), "56239 Elyse Canyon, East Wallacechester, Heard Island and McDonald Islands", new DateTime(2022, 3, 19, 17, 25, 29, 756, DateTimeKind.Local).AddTicks(2741), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("fc9abf5d-ef50-48e3-a0bc-bdf50a27a0fe"), new Guid("f2c0c896-4c1f-4746-b539-ce177471ae04"), null, "Ut eaque optio.", "5f39d84b-085f-492b-b1bf-845e48f3d8d0", new DateTime(2021, 5, 7, 18, 15, 35, 574, DateTimeKind.Local).AddTicks(5403), "8163 Tremblay Hills, Clemmieton, Puerto Rico", new DateTime(2022, 2, 7, 20, 6, 43, 365, DateTimeKind.Local).AddTicks(7579), null });

            migrationBuilder.InsertData(
                table: "ClientContactInformation<Guid>",
                columns: new[] { "Id", "ClientContactInformationTypeId", "ClientId", "Comment", "ConcurrencyStamp", "CreatedAt", "Name", "UpdatedAt", "Value" },
                values: new object[] { new Guid("ff4616cd-43c8-48f0-95ac-d0ee62eea68f"), new Guid("a8c2d5c9-b341-4586-aadf-7e68c17d5ac2"), null, "Necessitatibus laborum modi rerum id totam asperiores omnis.", "dcd64f4c-18fc-4399-bf68-eb09f46e7040", new DateTime(2021, 7, 22, 17, 24, 31, 810, DateTimeKind.Local).AddTicks(4908), "18905 Cole Passage, New Kipfort, Kyrgyz Republic", new DateTime(2022, 3, 6, 23, 18, 26, 613, DateTimeKind.Local).AddTicks(7252), null });

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
                name: "ClientContactInformationType<Guid>");

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
