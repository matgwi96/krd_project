using Microsoft.EntityFrameworkCore.Migrations;

namespace krd_project.API.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubordinateId",
                table: "Bosses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubordinateId",
                table: "Bosses");
        }
    }
}
