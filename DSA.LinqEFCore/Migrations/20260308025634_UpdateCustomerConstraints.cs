using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA.LinqEFCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomerConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                newName: "UX_Customer_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Id",
                table: "Customers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Id",
                table: "Customers");

            migrationBuilder.RenameIndex(
                name: "UX_Customer_Email",
                table: "Customers",
                newName: "IX_Customers_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
