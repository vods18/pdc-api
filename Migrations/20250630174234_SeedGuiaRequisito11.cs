using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 11.1 – Gerenciar vulnerabilidades de segurança em tempo hábil (SubRequisitoId = 50)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    63,
                    'As vulnerabilidades em sistemas, processos e softwares são descobertas continuamente; é necessário identificá-las e tratá-las de forma estruturada e tempestiva.',
                    'Gerenciar vulnerabilidades rapidamente reduz a janela de exposição a ataques automatizados e manualmente explorados.',
                    'Após a divulgação de uma falha crítica no OpenSSL, a equipe aplica o patch em todos os servidores no mesmo dia, evitando exploração em massa.',
                    50
                );
            ");

            // 11.2 – Testar sistemas com regularidade (SubRequisitoId = 51)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    64,
                    'Sistemas e redes devem passar por varreduras internas e externas, além de testes de invasão, para verificar a eficácia dos controles de segurança.',
                    'Testes regulares detectam falhas não cobertas por análises automatizadas e ajudam a manter a conformidade ao longo do tempo.',
                    'A cada trimestre, a empresa realiza varreduras externas e um teste de penetração manual por consultoria especializada.',
                    51
                );
            ");

            // 11.3 – Desabilitar recursos não utilizados (SubRequisitoId = 52)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    65,
                    'Componentes, serviços e portas não utilizados devem ser desativados para reduzir a superfície de ataque dos sistemas.',
                    'Eliminar funcionalidades desnecessárias dificulta a exploração de pontos de entrada não monitorados.',
                    'Um servidor de banco de dados tem o serviço FTP habilitado por padrão, mas é desabilitado imediatamente após a instalação.',
                    52
                );
            ");

            // 11.4 – Garantir que políticas e procedimentos estejam documentados e em uso (SubRequisitoId = 53)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    66,
                    'Documentar diretrizes e fluxos de trabalho para testes de segurança, garantindo que sejam aplicados e revisados periodicamente.',
                    'Políticas bem definidas evitam improvisações e garantem consistência nos processos de avaliação e resposta.',
                    'Uma política formal de testes trimestrais detalha responsáveis, ferramentas e cronogramas, sendo seguida pela equipe de segurança.',
                    53
                );
            ");

            // 11.5 – Testar trimestralmente pontos de acesso sem fio e manter inventário de AP autorizados (SubRequisitoId = 73)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    67,
                    'Realizar varreduras para identificar todos os pontos de acesso sem fio autorizados e não autorizados, mantendo um inventário atualizado.',
                    'Controlar e monitorar wireless evita vetores de ataque que podem passar despercebidos em redes corporativas.',
                    'Durante auditoria, um AP não autorizado é detectado e removido imediatamente graças ao inventário trimestral.',
                    73
                );
            ");

            // 11.6 – Implementar monitoramento de integridade de arquivos para alertar modificações não autorizadas (SubRequisitoId = 74)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    68,
                    'Implantar ferramentas de monitoramento de integridade de arquivos para detectar alterações, adições ou exclusões não autorizadas.',
                    'Alertas automáticos permitem resposta imediata a possíveis invasões ou modificações maliciosas.',
                    'Uma alteração inesperada em um executável crítico dispara um alerta, levando à descoberta de tentativa de injeção de malware.',
                    74
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id IN (63, 64, 65, 66, 67, 68);");
        }
    }
}
