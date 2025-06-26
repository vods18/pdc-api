using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pergunta = table.Column<string>(type: "TEXT", nullable: false),
                    Resposta = table.Column<string>(type: "TEXT", nullable: true),
                    Visivel = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requisitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegrasOcultacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RespostaGatilho = table.Column<string>(type: "TEXT", nullable: false),
                    PerguntaGatilhoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PerguntaAlvoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegrasOcultacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegrasOcultacoes_Questionario_PerguntaAlvoId",
                        column: x => x.PerguntaAlvoId,
                        principalTable: "Questionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegrasOcultacoes_Questionario_PerguntaGatilhoId",
                        column: x => x.PerguntaGatilhoId,
                        principalTable: "Questionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubRequisitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Check = table.Column<bool>(type: "INTEGER", nullable: false),
                    RequisitoId = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRequisitos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubRequisitos_Questionario_QuestionarioId",
                        column: x => x.QuestionarioId,
                        principalTable: "Questionario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubRequisitos_Requisitos_RequisitoId",
                        column: x => x.RequisitoId,
                        principalTable: "Requisitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Texto = table.Column<string>(type: "TEXT", nullable: false),
                    SubRequisitoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referencias_SubRequisitos_SubRequisitoId",
                        column: x => x.SubRequisitoId,
                        principalTable: "SubRequisitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Justificativa = table.Column<string>(type: "TEXT", nullable: false),
                    Fonte = table.Column<string>(type: "TEXT", nullable: false),
                    SubRequisitoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Softwares_SubRequisitos_SubRequisitoId",
                        column: x => x.SubRequisitoId,
                        principalTable: "SubRequisitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referencias_SubRequisitoId",
                table: "Referencias",
                column: "SubRequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_RegrasOcultacoes_PerguntaAlvoId",
                table: "RegrasOcultacoes",
                column: "PerguntaAlvoId");

            migrationBuilder.CreateIndex(
                name: "IX_RegrasOcultacoes_PerguntaGatilhoId",
                table: "RegrasOcultacoes",
                column: "PerguntaGatilhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_SubRequisitoId",
                table: "Softwares",
                column: "SubRequisitoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubRequisitos_QuestionarioId",
                table: "SubRequisitos",
                column: "QuestionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SubRequisitos_RequisitoId",
                table: "SubRequisitos",
                column: "RequisitoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Referencias");

            migrationBuilder.DropTable(
                name: "RegrasOcultacoes");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "SubRequisitos");

            migrationBuilder.DropTable(
                name: "Questionario");

            migrationBuilder.DropTable(
                name: "Requisitos");
        }
    }
}
