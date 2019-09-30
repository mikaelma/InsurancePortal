using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class AddInsurance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InsuranceNumber = table.Column<string>(nullable: true),
                    DateOfPurchase = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateActive = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    Premium = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurances_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_CustomerId",
                table: "Insurances",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurances");
        }
    }
}
