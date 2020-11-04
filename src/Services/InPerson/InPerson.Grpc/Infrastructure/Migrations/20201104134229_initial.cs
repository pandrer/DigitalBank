using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InPerson.Grpc.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountReference = table.Column<string>(nullable: true),
                    IdClient = table.Column<string>(nullable: true),
                    AccountType = table.Column<int>(nullable: false),
                    HasCard = table.Column<bool>(nullable: false),
                    OpeningDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardReference = table.Column<string>(nullable: true),
                    CreditCardType = table.Column<int>(nullable: false),
                    OpeningDate = table.Column<DateTimeOffset>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankProduct");

            migrationBuilder.DropTable(
                name: "CreditCard");
        }
    }
}
