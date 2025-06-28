using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Sub-requisito 5.1 – Instalar antivírus em sistemas comumente afetados por malware
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito determina que soluções antivírus sejam instaladas em todos os sistemas suscetíveis a malware (estações de trabalho, servidores, sistemas que acessam a internet), garantindo detecção e bloqueio em tempo real.',
                    'Sem essa proteção, ameaças como trojans, ransomware e spyware podem se propagar livremente, comprometendo dados sensíveis e a continuidade dos serviços.',
                    'Um colaborador abre um anexo malicioso em um computador sem antivírus ativo e dispara um ransomware que criptografa arquivos da rede. Com o antivírus instalado e atualizado, o anexo teria sido bloqueado antes da execução.',
                    22
                );
            ");

            // Sub-requisito 5.2 – Manter antivírus atualizado, com varreduras periódicas e logs
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito exige que os mecanismos antivírus recebam atualizações de assinatura regularmente, realizem scans periódicos e registrem todas as ações em logs auditáveis.',
                    'Antivírus desatualizado ou sem registros impede a detecção de ameaça, estendendo a janela de exposição e dificultando investigações após um incidente.',
                    'A empresa faz varreduras mensais em servidores mas ignora as estações de trabalho; um spyware se instala e exfiltra dados até ser descoberto meses depois. Scans automáticos e logs revisados teriam detectado a infecção rapidamente.',
                    23
                );
            ");

            // Sub-requisito 5.3 – Impedir que usuários desativem o antivírus sem autorização
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito exige que o antivírus não possa ser desativado ou alterado por usuários finais sem credenciais administrativas, protegendo a configuração e a integridade da defesa.',
                    'Permitir que usuários desliguem o antivírus abre brechas fáceis para ataques, pois um simples clique pode eliminar a última linha de defesa.',
                    'Um colaborador desativa o antivírus para executar uma tarefa e, nesse intervalo, um site comprometido instala um trojan. Se a desativação exigisse autorização administrativa, o malware jamais teria sido instalado.',
                    24
                );
            ");

            // Sub-requisito 5.4 – Garantir que políticas e procedimentos estejam documentados e em uso
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito reforça a necessidade de documentar políticas de proteção contra malware, incluindo procedimentos de atualização, revisão de logs e escalonamento de incidentes.',
                    'Sem diretrizes formais, equipes podem ignorar atualizações, não revisar registros ou falhar ao responder a alertas, comprometendo a eficácia dos controles técnicos.',
                    'Um analista recebe um alerta de malware mas desconhece o procedimento a seguir e abandona a investigação. Com documentação clara, ele saberia exatamente como isolar o ativo e iniciar a resposta.',
                    25
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove as entradas do requisito 5
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId IN (22, 23, 24, 25);");
        }
    }
}
