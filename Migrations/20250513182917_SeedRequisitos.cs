using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRequisitos : Migration
    {
        /// <inheritdoc />
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
                    column: "Nome",
                    value: requisitos[i]
                );
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            foreach (var requisito in requisitos)
            {
                migrationBuilder.DeleteData(
                    table: "Requisitos",
                    keyColumn: "Nome",
                    keyValue: requisito
                );
            }
        }
    }
}
