using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringProperty = table.Column<string>(maxLength: 100, nullable: false),
                    FloatProperty = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringProperty = table.Column<string>(maxLength: 100, nullable: false),
                    FloatProperty = table.Column<float>(nullable: false),
                    TableId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table2s_Table1s_TableId",
                        column: x => x.TableId,
                        principalTable: "Table1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Table2s_TableId",
                table: "Table2s",
                column: "TableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table2s");

            migrationBuilder.DropTable(
                name: "Table1s");
        }
    }
}
