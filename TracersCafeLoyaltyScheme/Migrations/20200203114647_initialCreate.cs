using Microsoft.EntityFrameworkCore.Migrations;

namespace TracersCafeLoyaltyScheme.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Adress1 = table.Column<string>(nullable: false),
                    Adress2 = table.Column<string>(nullable: true),
                    Adress3 = table.Column<string>(nullable: true),
                    Adress4 = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
