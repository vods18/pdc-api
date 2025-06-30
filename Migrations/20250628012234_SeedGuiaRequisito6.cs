using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 6.1 – Identificar vulnerabilidades e classificá-las por risco
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    26,
                    'Organizações devem implementar processos contínuos de varredura e monitoramento para identificar vulnerabilidades em sistemas e aplicativos, classificando-as por risco e priorizando correções.',
                    'Sem esse processo, falhas críticas podem ficar sem correção, expondo o ambiente a ataques automatizados que exploram brechas conhecidas.',
                    'Um sistema web roda uma versão desatualizada do Apache Struts; sem monitoramento, a equipe não percebe e um invasor executa código remoto explorando uma vulnerabilidade pública.',
                    26
                );
            ");

            // 6.2 – Aplicar correções de segurança em tempo hábil
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    27,
                    'As organizações devem aplicar patches de segurança assim que forem disponibilizados, de acordo com uma política que avalie criticidade e riscos.',
                    'A janela de exposição — período entre divulgação e correção de uma falha — deve ser mínima para reduzir o risco de exploração.',
                    'Após a liberação de um patch crítico para OpenSSL, a equipe aplica a correção no mesmo dia em todos os servidores, evitando ataques automatizados.',
                    27
                );
            ");

            // 6.3 – Desenvolver software seguindo práticas seguras
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    28,
                    'O desenvolvimento deve incorporar boas práticas como validação de entrada, controle de sessões e tratamento de erros para evitar introdução de vulnerabilidades.',
                    'Introduzir segurança desde o início previne retrabalho e reduz falhas críticas, mantendo o código mais robusto.',
                    'Uma API que não valida parâmetros em uma requisição GET permitia injeção de SQL; com validação adequada, o ataque não seria possível.',
                    28
                );
            ");

            // 6.4 – Seguir processos de controle de mudanças
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    29,
                    'Todas as alterações em sistemas ou aplicativos devem ser registradas, revisadas e aprovadas antes da implantação, garantindo rastreabilidade.',
                    'Sem controle formal, modificações podem introduzir falhas e ser aplicadas sem teste, aumentando o risco de incidentes.',
                    'Um script automatizado foi alterado sem revisão e apagou dados sensíveis; com um processo de mudanças, a falha teria sido detectada antes.',
                    29
                );
            ");

            // 6.5 – Prevenir vulnerabilidades comuns via codificação segura
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    30,
                    'Adotar técnicas para evitar falhas catalogadas (XSS, SQLi etc.), seguindo diretrizes como OWASP Top 10.',
                    'Essas vulnerabilidades são exploradas por ferramentas automatizadas; preveni-las reduz riscos e custos de correção.',
                    'Um campo de comentário sem higienização permitia injeção de JavaScript; aplicando escaping, o XSS não ocorreria.',
                    30
                );
            ");

            // 6.6 – Proteger aplicações web contra ataques conhecidos
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    31,
                    'Aplicações web devem contar com WAFs ou testes regulares para identificar e mitigar vulnerabilidades conhecidas.',
                    'Sem essa proteção, falhas de autenticação ou de validação podem ser exploradas repetidamente, comprometendo dados.',
                    'Um portal de pagamento sem WAF foi alvo de fuzzing que descobriu enumeração de usuários; com WAF ativo, esses ataques seriam bloqueados.',
                    31
                );
            ");

            // 6.7 – Garantir que políticas e procedimentos estejam documentados e em uso
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    32,
                    'Documentar formalmente todas as práticas de desenvolvimento seguro, controle de mudanças e correções, e aplicá-las no dia a dia.',
                    'A documentação evita improvisações e serve como guia em auditorias, treinamentos e revisões periódicas.',
                    'Durante auditoria, a equipe não conseguiu mostrar critérios de correção de segurança; com políticas bem definidas, a conformidade teria sido comprovada.',
                    32
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove os guias do requisito 6
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id IN (26, 27, 28, 29, 30, 31, 32);");
        }
    }
}
