using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class CreateGuiaRequisitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuiaRequisitos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Significado = table.Column<string>(nullable: false),
                    Importancia  = table.Column<string>(nullable: true),
                    Exemplo      = table.Column<string>(nullable: true),
                    SubRequisitoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuiaRequisitos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuiaRequisitos_SubRequisitos_SubRequisitoId",
                        column: x => x.SubRequisitoId,
                        principalTable: "SubRequisitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuiaRequisitos_SubRequisitoId",
                table: "GuiaRequisitos",
                column: "SubRequisitoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "GuiaRequisitos");
        }
    }

}
