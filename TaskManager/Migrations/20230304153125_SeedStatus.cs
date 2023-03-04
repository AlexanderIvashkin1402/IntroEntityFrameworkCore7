using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Status (Name) VALUES ('To Do');");
            migrationBuilder.Sql("INSERT INTO Status (Name) VALUES ('In Progress');");
            migrationBuilder.Sql("INSERT INTO Status (Name) VALUES ('Done');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
