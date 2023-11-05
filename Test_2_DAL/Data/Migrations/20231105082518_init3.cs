using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_2_DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating2",
                table: "Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating2",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
