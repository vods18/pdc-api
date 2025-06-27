using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedAndFixSubRequisitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Corrigir títulos existentes (requisito 12)
            migrationBuilder.Sql(
                "UPDATE SubRequisitos " +
                "SET Nome = 'Estabelecer, publicar e revisar anualmente política de segurança da informação' " +
                "WHERE Id = 54;"
            );
            migrationBuilder.Sql(
                "UPDATE SubRequisitos " +
                "SET Nome = 'Implementar avaliação de riscos anual e após mudanças significativas' " +
                "WHERE Id = 55;"
            );
            migrationBuilder.Sql(
                "UPDATE SubRequisitos " +
                "SET Nome = 'Desenvolver políticas de uso para acesso remoto, wireless, mídia removível e Internet' " +
                "WHERE Id = 56;"
            );

            // 2) Inserir subrequisitos faltantes

            // Requisito 8 – 8.7
            migrationBuilder.Sql(
                "INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) " +
                "VALUES (58, 'Restringir acesso a bancos de dados a administradores e via métodos programáticos', 0, 8, NULL);"
            );

            // Requisito 9 – itens 9.5 a 9.10
            migrationBuilder.Sql(
                "INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES " +
                "(59, 'Proteger fisicamente mídias e armazenar backups em local seguro, preferencialmente fora do local', 0, 9, NULL)," +
                "(60, 'Manter controle rigoroso sobre distribuição interna e externa de mídias', 0, 9, NULL)," +
                "(61, 'Manter controle rigoroso sobre armazenamento e acessibilidade de mídias', 0, 9, NULL)," +
                "(62, 'Destruir mídias quando não forem mais necessárias por motivos legais ou de negócio', 0, 9, NULL)," +
                "(63, 'Proteger dispositivos de captura de dados de cartão contra adulteração e substituição', 0, 9, NULL)," +
                "(64, 'Garantir que políticas e procedimentos relacionados sejam documentados e conhecidos por todas as partes', 0, 9, NULL);"
            );

            // Requisito 10 – itens 10.4 a 10.9
            migrationBuilder.Sql(
                "INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES " +
                "(65, 'Sincronizar relógios críticos e controlar distribuição de tempo', 0, 10, NULL)," +
                "(66, 'Proteger trilhas de auditoria contra alterações', 0, 10, NULL)," +
                "(67, 'Revisar logs e eventos de segurança diariamente para identificar anomalias', 0, 10, NULL)," +
                "(68, 'Reter histórico de audit trails por pelo menos um ano, com três meses acessíveis', 0, 10, NULL)," +
                "(69, 'Detectar e reportar falhas em controles críticos de segurança', 0, 10, NULL)," +
                "(70, 'Documentar e comunicar políticas e procedimentos de audit trails', 0, 10, NULL);"
            );

            // Requisito 11 – 11.1 e 11.5
            migrationBuilder.Sql(
                "INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES " +
                "(73, 'Testar trimestralmente pontos de acesso sem fio e manter inventário de AP autorizados', 0, 11, NULL)," +
                "(74, 'Implementar monitoramento de integridade de arquivos para alertar modificações não autorizadas', 0, 11, NULL);"
            );

            // Requisito 12 – itens 12.5 a 12.11 (já corrigi 12.1–12.3)
            migrationBuilder.Sql(
                "INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES " +
                "(75, 'Atribuir responsabilidades de segurança da informação a indivíduos ou equipes', 0, 12, NULL)," +
                "(76, 'Implementar programa formal de conscientização em segurança para todo o pessoal', 0, 12, NULL)," +
                "(77, 'Realizar triagem de candidatos antes da contratação (antecedentes e referências)', 0, 12, NULL)," +
                "(78, 'Gerenciar políticas e procedimentos para provedores de serviço de dados de cartão', 0, 12, NULL)," +
                "(79, 'Exigir reconhecimento escrito dos provedores sobre responsabilidade pela segurança de dados', 0, 12, NULL)," +
                "(80, 'Implementar plano de resposta a incidentes e estar preparado para reações imediatas', 0, 12, NULL)," +
                "(81, 'Realizar e documentar revisões trimestrais de políticas e procedimentos de segurança', 0, 12, NULL);"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverter correções de títulos
            migrationBuilder.Sql(
                "UPDATE SubRequisitos SET Nome = 'Estabelecer uma estratégia de resposta a incidentes' WHERE Id = 54;"
            );
            migrationBuilder.Sql(
                "UPDATE SubRequisitos SET Nome = 'Notificar sobre eventos de segurança em tempo real' WHERE Id = 55;"
            );
            migrationBuilder.Sql(
                "UPDATE SubRequisitos SET Nome = 'Realizar análise forense de incidentes' WHERE Id = 56;"
            );

            // Remover todos os inseridos
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE Id IN (58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 73, 74, 75, 76, 77, 78, 79, 80, 81);");
        }
    }
}
