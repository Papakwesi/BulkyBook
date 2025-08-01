using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCompanyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Companies",
                newName: "Region");

            migrationBuilder.RenameColumn(
                name: "PostalCdde",
                table: "Companies",
                newName: "PostalCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Companies",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Companies",
                newName: "PostalCdde");
        }
    }
}
