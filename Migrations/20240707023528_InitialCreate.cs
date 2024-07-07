using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gtfs_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    route_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    agency_id = table.Column<string>(type: "TEXT", nullable: false),
                    route_short_name = table.Column<string>(type: "TEXT", nullable: false),
                    route_long_name = table.Column<string>(type: "TEXT", nullable: false),
                    route_desc = table.Column<string>(type: "TEXT", nullable: false),
                    route_type = table.Column<string>(type: "TEXT", nullable: false),
                    route_url = table.Column<string>(type: "TEXT", nullable: false),
                    route_color = table.Column<string>(type: "TEXT", nullable: false),
                    route_text_color = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.route_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
