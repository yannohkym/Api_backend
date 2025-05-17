using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsurancePolicies.Migrations
{
    /// <inheritdoc />
    public partial class InitialInsurancePolicies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PremiumAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "Id", "IsActive", "PolicyHolderName", "PolicyNumber", "PolicyType", "PremiumAmount" },
                values: new object[,]
                {
                    { 1, true, "John Mwangi", "POL123456", "Health", 15000.00m },
                    { 2, true, "Alice Wanjiku", "POL234567", "Life", 25000.00m },
                    { 3, false, "Brian Otieno", "POL345678", "Vehicle", 8000.50m },
                    { 4, true, "Faith Njeri", "POL456789", "Home", 12000.75m },
                    { 5, false, "Elvis Kiptoo", "POL567890", "Travel", 6000.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");
        }
    }
}
