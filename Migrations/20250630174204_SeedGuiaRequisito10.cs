using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 10.1 – Realizar treinamento de segurança para todos os funcionários (SubRequisitoId = 47)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    54,
                    'Todos os colaboradores devem receber treinamento adequado em segurança da informação, incluindo reconhecimento de ameaças, uso seguro de sistemas e boas práticas no tratamento de dados sensíveis.',
                    'Funcionários bem treinados atuam como uma das primeiras linhas de defesa, identificando comportamentos suspeitos e evitando erros que podem comprometer o ambiente.',
                    'Uma empresa realiza treinamentos semestrais de conscientização em segurança. Um funcionário treinado identifica um e-mail de phishing com anexo malicioso e aciona a equipe de TI antes de qualquer dano ser causado.',
                    47
                );
            ");

            // 10.2 – Implementar procedimentos para incidentes de segurança (SubRequisitoId = 48)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    55,
                    'Definir, documentar e praticar fluxos claros para detectar, responder e recuperar-se de incidentes de segurança, com equipes e critérios de escalonamento.',
                    'Procedimentos bem estabelecidos garantem resposta coordenada e eficaz, evitando improvisações em momentos críticos.',
                    'Após detectar tráfego suspeito em um servidor, a equipe de resposta a incidentes isola o ativo afetado e inicia a análise forense conforme o procedimento definido.',
                    48
                );
            ");

            // 10.3 – Garantir que políticas e procedimentos estejam documentados e em uso (SubRequisitoId = 49)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    56,
                    'Formalizar políticas de monitoramento e rastreamento de acessos, aplicando-as na prática diária da organização.',
                    'Documentação clara serve de referência para equipe e auditores, reduzindo falhas operacionais e assegurando conformidade contínua.',
                    'Uma empresa estabelece uma política que obriga a revisão de logs semanalmente. Um novo funcionário da equipe de segurança consegue seguir essa política com clareza.',
                    49
                );
            ");

            // 10.4 – Sincronizar relógios críticos e controlar distribuição de tempo (SubRequisitoId = 65)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    57,
                    'Sincronizar todos os sistemas críticos com uma fonte de tempo confiável para manter registros de eventos alinhados cronologicamente.',
                    'A sincronização evita discrepâncias de horário que dificultam a reconstrução de incidentes e atrasam investigações.',
                    'Durante a análise de um ataque, logs de diferentes servidores mostravam horários divergentes. Com NTP configurado, todos os eventos teriam timestamps consistentes.',
                    65
                );
            ");

            // 10.5 – Proteger trilhas de auditoria contra alterações (SubRequisitoId = 66)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    58,
                    'Implementar controles que impeçam a alteração ou exclusão não autorizada dos registros de log e audit trails.',
                    'Garantir a integridade das evidências durante e após incidentes, assegurando que não sejam manipuladas.',
                    'Um invasor tenta apagar os logs para ocultar suas ações, mas as trilhas protegidas e replicadas em servidor imutável impossibilitam a remoção.',
                    66
                );
            ");

            // 10.6 – Revisar logs e eventos de segurança diariamente para identificar anomalias (SubRequisitoId = 67)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    59,
                    'Analisar diariamente os registros de acesso e eventos relevantes de segurança em busca de comportamentos fora do padrão.',
                    'Revisões regulares aumentam a probabilidade de detecção precoce de ataques ou falhas operacionais.',
                    'A equipe de segurança detecta um volume anormal de acessos fora do horário comercial e identifica uma tentativa de acesso por um ex-funcionário.',
                    67
                );
            ");

            // 10.7 – Reter histórico de audit trails por pelo menos um ano, com três meses acessíveis (SubRequisitoId = 68)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    60,
                    'Manter registros de auditoria por no mínimo um ano, assegurando que os três meses mais recentes estejam prontamente disponíveis.',
                    'Essa retenção permite investigação retroativa e suporte a auditorias sem risco de perda de histórico crítico.',
                    'Após um alerta de fraude, a equipe consegue consultar logs de cinco meses atrás para identificar a origem da violação.',
                    68
                );
            ");

            // 10.8 – Detectar e reportar falhas em controles críticos de segurança (SubRequisitoId = 69)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    61,
                    'Implementar mecanismos automáticos ou procedimentos para identificar e relatar falhas em firewalls, antivírus e autenticação.',
                    'A detecção precoce de falhas reduz a janela de exposição e permite correções rápidas.',
                    'Um sistema de monitoramento alerta que o antivírus de um servidor foi desativado, acionando a equipe de segurança em tempo real.',
                    69
                );
            ");

            // 10.9 – Documentar e comunicar políticas e procedimentos de audit trails (SubRequisitoId = 70)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    62,
                    'Formalizar diretrizes sobre coleta, retenção e proteção de registros de auditoria e comunicá-las a todas as partes envolvidas.',
                    'Documentação acessível e clara garante consistência de aplicação e facilita auditorias externas.',
                    'Durante uma auditoria, a equipe apresenta a política oficial de audit trails, contendo orientações sobre tempo de retenção e proteção dos registros.',
                    70
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id BETWEEN 54 AND 62;");
        }
    }
}
