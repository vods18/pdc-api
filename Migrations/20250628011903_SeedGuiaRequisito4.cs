using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Sub-requisito 4.1 – Utilizar criptografia forte e protocolos seguros em redes públicas
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito exige que toda transmissão de dados do titular do cartão através de redes públicas utilize criptografia forte, com protocolos seguros configurados corretamente (por exemplo, TLS 1.2 ou superior).',
                    'Sem proteção criptográfica adequada, dados sensíveis podem ser interceptados por atacantes durante a transmissão, comprometendo a confidencialidade e a integridade das informações.',
                    'Um cliente realiza uma compra por um site que ainda usa SSL 3.0. Um atacante posiciona-se no meio do tráfego e decifra os dados do cartão. Com TLS 1.2 configurado corretamente, o tráfego teria permanecido inacessível ao invasor.',
                    19
                );
            ");

            // Sub-requisito 4.2 – Nunca enviar PANs desprotegidos via tecnologias de mensagens de usuário
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito estabelece que o PAN não deve nunca ser transmitido em texto claro por e-mails, chats, SMS ou outras ferramentas de mensagem de usuário.',
                    'Mensagens de usuário não oferecem criptografia ponta a ponta garantida, aumentando o risco de interceptação ou armazenamento inseguro nos servidores intermediários.',
                    'Um atendente pede ao cliente que envie o número completo do cartão por e-mail. Essa prática expõe o PAN em texto simples e pode resultar em vazamento se o canal for comprometido.',
                    20
                );
            ");

            // Sub-requisito 4.3 – Garantir que políticas e procedimentos estejam documentados e em uso
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito exige que as políticas e procedimentos de criptografia e proteção em trânsito sejam formalmente documentados, revisados e comunicados a todos os envolvidos.',
                    'Sem documentação e comunicação, as configurações seguras podem não ser mantidas ou validadas regularmente, abrindo brechas por configurações incorretas ou obsoletas.',
                    'A empresa adota TLS para proteger dados em trânsito, mas não possui política clara sobre versões e renovação de certificados. Um novo colaborador configura versões obsoletas, enfraquecendo a segurança.',
                    21
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove as entradas para o requisito 4
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId IN (19, 20, 21);");
        }
    }
}
