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
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (1, 'Estabelecer e implementar padrões de configuração para firewalls e roteadores', 0, 1, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (2, 'Criar configurações que restrinjam todo o tráfego não autorizado', 0, 1, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (3, 'Proibir acesso direto da Internet ao ambiente de dados do cartão', 0, 1, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (4, 'Instalar firewall pessoal em dispositivos que se conectam externamente', 0, 1, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (5, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 1, NULL);");


           // sub 2,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (6, 'Alterar senhas padrão e desabilitar contas padrão antes da instalação', 0, 2, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (7, 'Desenvolver padrões de configuração para abordar vulnerabilidades conhecidas', 0, 2, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (8, 'Criptografar todo acesso administrativo não-console', 0, 2, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (9, 'Manter inventário de componentes do sistema', 0, 2, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (10, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 2, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (11, '(Hospedagem compartilhada) Isolar ambientes de diferentes clientes', 0, 2, NULL);");


           // sub 3,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (12, 'Limitar armazenamento e retenção de dados conforme necessidade', 0, 3, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (13, 'Não armazenar dados sensíveis de autenticação após a autorização', 0, 3, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (14, 'Mascarar o PAN quando exibido', 0, 3, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (15, 'Tornar o PAN ilegível onde for armazenado', 0, 3, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (16, 'Proteger chaves de criptografia', 0, 3, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (17, 'Gerenciar chaves criptográficas de forma segura', 0, 3, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (18, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 3, NULL);");


           // sub 4,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (19, 'Utilizar criptografia forte e protocolos seguros em redes públicas', 0, 4, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (20, 'Nunca enviar PANs desprotegidos via tecnologias de mensagens de usuário', 0, 4, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (21, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 4, NULL);");


           // sub 5,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (22, 'Instalar antivírus em sistemas comumente afetados por malware', 0, 5, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (23, 'Manter antivírus atualizado, com varreduras periódicas e logs', 0, 5, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (24, 'Impedir que usuários desativem o antivírus sem autorização', 0, 5, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (25, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 5, NULL);");


           // sub 6,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (26, 'Identificar vulnerabilidades e classificá-las por risco', 0, 6, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (27, 'Aplicar correções de segurança em tempo hábil', 0, 6, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (28, 'Desenvolver software seguindo práticas seguras', 0, 6, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (29, 'Seguir processos de controle de mudanças', 0, 6, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (30, 'Prevenir vulnerabilidades comuns via codificação segura', 0, 6, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (31, 'Proteger aplicações web contra ataques conhecidos', 0, 6, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (32, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 6, NULL);");


           // sub 7,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (33, 'Conceder acesso apenas a quem precisa', 0, 7, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (34, 'Implementar sistema de controle com \"negação por padrão\"', 0, 7, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (35, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 7, NULL);");


           // sub 8,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (36, 'Gerenciar IDs de usuário e administradores', 0, 8, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (37, 'Usar autenticação segura (algo que se sabe, tem ou é)', 0, 8, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (38, 'Usar autenticação multifator para acesso remoto ou privilegiado', 0, 8, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (39, 'Documentar políticas de autenticação', 0, 8, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (40, 'Não usar IDs compartilhados ou genéricos', 0, 8, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (41, 'Associar tokens, smartcards e certificados a contas individuais', 0, 8, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (42, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 8, NULL);");


           // sub 9,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (43, 'Auditar e revisar contas e acessos periodicamente', 0, 9, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (44, 'Fornecer logs de auditoria completos e seguros', 0, 9, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (45, 'Gerenciar registros de acesso com integridade e segurança', 0, 9, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (46, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 9, NULL);");


           // sub 10,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (47, 'Realizar treinamento de segurança para todos os funcionários', 0, 10, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (48, 'Implementar procedimentos para incidentes de segurança', 0, 10, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (49, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 10, NULL);");


           // sub 11,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (50, 'Gerenciar vulnerabilidades de segurança em tempo hábil', 0, 11, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (51, 'Testar sistemas com regularidade', 0, 11, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (52, 'Desabilitar recursos não utilizados', 0, 11, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (53, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 11, NULL);");


           // sub 12,
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (54, 'Estabelecer uma estratégia de resposta a incidentes', 0, 12, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (55, 'Notificar sobre eventos de segurança em tempo real', 0, 12, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (56, 'Realizar análise forense de incidentes', 0, 12, NULL);");
           migrationBuilder.Sql("INSERT INTO SubRequisitos (Id, Nome, [Check], RequisitoId, QuestionarioId) VALUES (57, 'Garantir que políticas e procedimentos estejam documentados e em uso', 0, 12, NULL);");


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
