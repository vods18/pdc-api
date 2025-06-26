using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedRequisito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var requisitos = new[]
            {
                "Instalar e manter uma configuração de firewall para proteger os dados do titular do cartão",
                "Não utilizar senhas padrão fornecidas por fabricantes e outros parâmetros de segurança padrão",
                "Proteger os dados armazenados do titular do cartão",
                "Criptografar a transmissão dos dados do titular do cartão em redes públicas abertas",
                "Proteger todos os sistemas contra malware e manter softwares antivírus atualizados",
                "Desenvolver e manter sistemas e aplicativos seguros",
                "Restringir o acesso aos dados do titular do cartão com base na necessidade de conhecimento",
                "Identificar e autenticar o acesso a componentes do sistema",
                "Restringir o acesso físico aos dados do titular do cartão",
                "Rastrear e monitorar todos os acessos a recursos de rede e dados do titular do cartão",
                "Testar regularmente sistemas e processos de segurança",
                "Manter uma política de segurança da informação para todos os colaboradores"
            };

            for (int i = 0; i < requisitos.Length; i++)
            {
                migrationBuilder.InsertData(
                    table: "Requisitos",
                    columns: new[] { "Id", "Nome" },
                    values: new object[] { i + 1, requisitos[i] }
                );
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i <= 12; i++)
            {
                migrationBuilder.DeleteData(
                    table: "Requisitos",
                    keyColumn: "Id",
                    keyValue: i
                );
            }
        }
    }
}
