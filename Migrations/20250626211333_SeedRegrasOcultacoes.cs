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
                    { 9, "não", 9, 10 },
                    { 10, "não", 9, 20 },
                    { 11, "não", 9, 21 },
                    { 12, "não", 11, 12 },
                    { 13, "não", 11, 13 },
                    { 14, "não", 11, 14 },
                    { 15, "não", 11, 17 },
                    { 16, "não", 19, 21 },
                    { 17, "não", 22, 23 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int id = 1; id <= 17; id++)
            {
                migrationBuilder.DeleteData(
                    table: "RegrasOcultacoes",
                    keyColumn: "Id",
                    keyValue: id);
            }
        }
    }
}