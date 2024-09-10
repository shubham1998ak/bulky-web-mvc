using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modifyOrderHeaderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PymentDueDate",
                table: "OrderHeaders",
                newName: "PaymentDueDate");

            migrationBuilder.RenameColumn(
                name: "Paymenttatus",
                table: "OrderHeaders",
                newName: "PaymentStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "OrderHeaders",
                newName: "Paymenttatus");

            migrationBuilder.RenameColumn(
                name: "PaymentDueDate",
                table: "OrderHeaders",
                newName: "PymentDueDate");
        }
    }
}
