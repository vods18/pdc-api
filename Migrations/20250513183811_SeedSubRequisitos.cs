using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedSubRequisitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // sub 1
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Estabelecer e implementar padrões de configuração para firewalls e roteadores', 0, 1, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Criar configurações que restrinjam todo o tráfego não autorizado', 0, 1, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Proibir acesso direto da Internet ao ambiente de dados do cartão', 0, 1, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Instalar firewall pessoal em dispositivos que se conectam externamente', 0, 1, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 1, NULL);");

            // sub 2
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Alterar senhas padrão e desabilitar contas padrão antes da instalação', 0, 2, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Desenvolver padrões de configuração para abordar vulnerabilidades conhecidas', 0, 2, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Criptografar todo acesso administrativo não-console', 0, 2, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Manter inventário de componentes do sistema', 0, 2, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 2, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('(Hospedagem compartilhada) Isolar ambientes de diferentes clientes', 0, 2, NULL);");

            // sub 3
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Limitar armazenamento e retenção de dados conforme necessidade', 0, 3, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Não armazenar dados sensíveis de autenticação após a autorização', 0, 3, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Mascarar o PAN quando exibido', 0, 3, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Tornar o PAN ilegível onde for armazenado', 0, 3, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Proteger chaves de criptografia', 0, 3, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Gerenciar chaves criptográficas de forma segura', 0, 3, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 3, NULL);");

            // sub 4
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Utilizar criptografia forte e protocolos seguros em redes públicas', 0, 4, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Nunca enviar PANs desprotegidos via tecnologias de mensagens de usuário', 0, 4, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 4, NULL);");

            // sub 5
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Instalar antivírus em sistemas comumente afetados por malware', 0, 5, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Manter antivírus atualizado, com varreduras periódicas e logs', 0, 5, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Impedir que usuários desativem o antivírus sem autorização', 0, 5, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 5, NULL);");

            // sub 6
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Identificar vulnerabilidades e classificá-las por risco', 0, 6, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Aplicar correções de segurança em tempo hábil', 0, 6, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Desenvolver software seguindo práticas seguras', 0, 6, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Seguir processos de controle de mudanças', 0, 6, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Prevenir vulnerabilidades comuns via codificação segura', 0, 6, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Proteger aplicações web contra ataques conhecidos', 0, 6, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 6, NULL);");

            // sub 7
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Conceder acesso apenas a quem precisa', 0, 7, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Implementar sistema de controle com \"negação por padrão\"', 0, 7, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 7, NULL);");

            // sub 8
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Gerenciar IDs de usuário e administradores', 0, 8, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Usar autenticação segura (algo que se sabe, tem ou é)', 0, 8, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Usar autenticação multifator para acesso remoto ou privilegiado', 0, 8, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Documentar políticas de autenticação', 0, 8, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Não usar IDs compartilhados ou genéricos', 0, 8, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Associar tokens, smartcards e certificados a contas individuais', 0, 8, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 8, NULL);");
    
            // sub 9
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Auditar e revisar contas e acessos periodicamente', 0, 9, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Fornecer logs de auditoria completos e seguros', 0, 9, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Gerenciar registros de acesso com integridade e segurança', 0, 9, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 9, NULL);");

            // sub 10
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Realizar treinamento de segurança para todos os funcionários', 0, 10, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Implementar procedimentos para incidentes de segurança', 0, 10, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 10, NULL);");

            // sub 11
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Gerenciar vulnerabilidades de segurança em tempo hábil', 0, 11, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Testar sistemas com regularidade', 0, 11, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Desabilitar recursos não utilizados', 0, 11, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 11, NULL);");

            // sub 12
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Estabelecer uma estratégia de resposta a incidentes', 0, 12, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Notificar sobre eventos de segurança em tempo real', 0, 12, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Realizar análise forense de incidentes', 0, 12, NULL);");
            migrationBuilder.Sql("INSERT INTO SubRequisitos (Nome, [Check], RequisitoId, QuestionarioId) VALUES ('Garantir que políticas e procedimentos estejam documentados e em uso', 0, 12, NULL);");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remover SubRequisitos de todos os Requisitos
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 12;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 11;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 10;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 9;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 8;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 7;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 6;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 5;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 4;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 3;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 2;");
            migrationBuilder.Sql("DELETE FROM SubRequisitos WHERE RequisitoId = 1;");
        }
    }
}
