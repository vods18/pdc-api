using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class InsertMissingFirstQuestionAndShiftIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Temporariamente desativa verificação de FK
            migrationBuilder.Sql("PRAGMA foreign_keys = OFF;");

            // 1) Ajusta todos os FK de SubRequisitos que apontam para Questionario
            migrationBuilder.Sql(@"
                UPDATE SubRequisitos
                SET QuestionarioId = QuestionarioId + 1
                WHERE QuestionarioId IS NOT NULL;
            ");

            // Se houver outras tabelas com FK para Questionario, trate-as aqui também:
            // e.g., RegrasOcultacoes.PerguntaGatilhoId e PerguntaAlvoId
            migrationBuilder.Sql(@"
                UPDATE RegrasOcultacoes
                SET PerguntaGatilhoId = PerguntaGatilhoId + 1;
            ");
            migrationBuilder.Sql(@"
                UPDATE RegrasOcultacoes
                SET PerguntaAlvoId = PerguntaAlvoId + 1;
            ");

            // 2) Move todas as perguntas para um ID maior, de trás pra frente
            //    Ordenação DESC garante que não haverá conflito de chave primária.
            migrationBuilder.Sql(@"
                UPDATE Questionario
                SET Id = Id + 1
                ORDER BY Id DESC;
            ");

            // 3) Insere a pergunta faltante como ID = 1
            migrationBuilder.Sql(@"
                INSERT INTO Questionario (Id, Pergunta, Resposta, Visivel)
                VALUES (
                    1,
                    'Sua empresa possui mecanismos para controlar o tráfego de rede e restringir acessos não autorizados, como firewalls configurados corretamente, segmentação de rede e proteção contra acessos diretos da Internet?',
                    NULL,
                    1
                );
            ");

            // 4) Reativa verificação de FK
            migrationBuilder.Sql("PRAGMA foreign_keys = ON;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Desativa FK para reverter
            migrationBuilder.Sql("PRAGMA foreign_keys = OFF;");

            // Remove a pergunta que inserimos
            migrationBuilder.Sql("DELETE FROM Questionario WHERE Id = 1;");

            // Reverte IDs de Questionario
            migrationBuilder.Sql(@"
                UPDATE Questionario
                SET Id = Id - 1
                ORDER BY Id ASC;
            ");

            // Reverte FKs em RegrasOcultacoes
            migrationBuilder.Sql("UPDATE RegrasOcultacoes SET PerguntaGatilhoId = PerguntaGatilhoId - 1;");
            migrationBuilder.Sql("UPDATE RegrasOcultacoes SET PerguntaAlvoId = PerguntaAlvoId - 1;");

            // Reverte FK em SubRequisitos
            migrationBuilder.Sql(@"
                UPDATE SubRequisitos
                SET QuestionarioId = QuestionarioId - 1
                WHERE QuestionarioId IS NOT NULL;
            ");

            // Reativa FK
            migrationBuilder.Sql("PRAGMA foreign_keys = ON;");
        }
    }
}
