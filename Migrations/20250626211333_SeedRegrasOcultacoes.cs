using Microsoft.EntityFrameworkCore.Migrations;

namespace pdc_api.Migrations
{

    public partial class SeedRegrasOcultacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegrasOcultacoes",
                columns: new[] { "Id", "RespostaGatilho", "PerguntaGatilhoId", "PerguntaAlvoId" },
                values: new object[,]
                {
                    { 1, "não", 1, 2 },
                    { 2, "não", 2, 12 },
                    { 3, "não", 2, 13 },
                    { 4, "não", 2, 18 },
                    { 5, "não", 3, 4 },
                    { 6, "não", 3, 12 },
                    { 7, "não", 4, 9 },
                    { 8, "não", 4, 18 },
                    { 9, "não", 5, 6 },
                    { 10, "não", 9, 10 },
                    { 11, "não", 9, 20 },
                    { 12, "não", 9, 21 },
                    { 13, "não", 11, 12 },
                    { 14, "não", 11, 13 },
                    { 15, "não", 11, 14 },
                    { 16, "não", 11, 17 },
                    { 17, "não", 12, 13 },
                    { 18, "não", 12, 14 },
                    { 19, "não", 15, 16 },
                    { 20, "não", 17, 18 },
                    { 21, "não", 19, 20 },
                    { 22, "não", 19, 21 },
                    { 23, "não", 22, 23 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int id = 1; id <= 23; id++)
            {
                migrationBuilder.DeleteData(
                    table: "RegrasOcultacoes",
                    keyColumn: "Id",
                    keyValue: id);
            }
        }
    }
}