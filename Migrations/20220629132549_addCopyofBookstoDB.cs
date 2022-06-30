using Microsoft.EntityFrameworkCore.Migrations;

namespace LMSRazor.Migrations
{
    public partial class addCopyofBookstoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoofCopies",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoofCopies",
                table: "Books");
        }
    }
}
