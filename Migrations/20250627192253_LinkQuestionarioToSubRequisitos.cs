using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class LinkQuestionarioToSubRequisitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1 → subReqs 1, 2, 3
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 0 WHERE Id IN (2, 3);");

            // 2 → subReq 5
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 1 WHERE Id = 5;");

            // 3 → subReqs 6, 9, 10
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 2 WHERE Id IN (6, 9, 10);");

            // 4 → subReqs 7, 8, 11
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 3 WHERE Id IN (7, 8, 11);");

            // 5 → nenhum subrequisito linkado, saltar

            // 6 → subReqs 12, 14, 15
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 5 WHERE Id IN (12, 14, 15);");

            // 7 → subReqs 19, 21
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 6 WHERE Id IN (19, 21);");

            // 8 → subReqs 22, 24
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 7 WHERE Id IN (22, 24);");

            // 9 → subReqs 27, 31
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 8 WHERE Id IN (27, 31);");

            // 10 → subReq 30
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 9 WHERE Id = 30;");

            // 11 → subReqs 33, 34
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 10 WHERE Id IN (33, 34);");

            // 12 → subReqs 36, 40, 41
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 11 WHERE Id IN (36, 40, 41);");

            // 13 → subReqs 37, 39
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 12 WHERE Id IN (37, 39);");

            // 14 → subReqs 38, 42
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 13 WHERE Id IN (38, 42);");

            // 15 → subReqs 43, 44, 45, 46
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 14 WHERE Id IN (43, 44, 45, 46);");

            // 16 → subReqs 59–64
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 15 WHERE Id IN (59, 60, 61, 62, 63, 64);");

            // 17 → subReqs 47, 48, 49
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 16 WHERE Id IN (47, 48, 49);");

            // 18 → subReqs 65–68
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 17 WHERE Id BETWEEN 65 AND 68;");

            // 19 → subReq 73
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 18 WHERE Id = 73;");

            // 20 → subReqs 51, 52
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 19 WHERE Id IN (51, 52);");

            // 21 → subReqs 53, 74
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 20 WHERE Id IN (53, 74);");

            // 22 → subReqs 54, 55, 57
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 21 WHERE Id IN (54, 55, 57);");

            // 23 → subReqs 75, 76, 77
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = 22 WHERE Id IN (75, 76, 77);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Limpa todos os QuestionarioId inseridos acima
            migrationBuilder.Sql("UPDATE SubRequisitos SET QuestionarioId = NULL WHERE QuestionarioId BETWEEN 0 AND 22;");
        }
    }
}
