using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisitosRequisito8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 8.1 – Gerenciar IDs de usuário e administradores (SubRequisitoId = 36)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Definir e atribuir nomes de usuário únicos antes de permitir acesso a sistemas ou dados de cartão.',
                    'Assegura rastreabilidade e revogação imediata de acesso quando um colaborador sai ou muda de função.',
                    'Um colaborador deixa a empresa, mas sua conta genérica continua ativa, impedindo identificar quem fez alterações indevidas.',
                    36
                );
            ");

            // 8.2 – Usar autenticação segura (algo que se sabe, tem ou é) (SubRequisitoId = 37)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Empregar ao menos um fator de autenticação: senha, token/smartcard ou biometria, com armazenamento e transmissão criptografados.',
                    'Reduz o risco de acesso indevido caso uma credencial seja comprometida, usando métodos reconhecidos pelo PCI DSS.',
                    'Um invasor obtém a senha de um funcionário via phishing, mas falha porque falta o segundo fator do aplicativo autenticador.',
                    37
                );
            ");

            // 8.3 – Usar autenticação multifator para acesso remoto ou privilegiado (SubRequisitoId = 38)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Exigir dois ou mais fatores distintos para administradores e acessos remotos ao ambiente de dados de cartão.',
                    'Fortalece o controle sobre contas privilegiadas, dificultando ataques mesmo com senha comprometida.',
                    'Um administrador conecta-se por VPN e, além da senha, fornece um código temporário gerado por app autenticador.',
                    38
                );
            ");

            // 8.4 – Documentar políticas de autenticação (SubRequisitoId = 39)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Desenvolver, publicar e comunicar regras de complexidade de senhas, bloqueio de conta e MFA a todos os usuários.',
                    'Garante aplicação consistente dos controles e evita decisões improvisadas que possam comprometer a segurança.',
                    'Sem política de bloqueio após tentativas falhas, um invasor faz força bruta até obter a senha; com política documentada, o acesso seria bloqueado.',
                    39
                );
            ");

            // 8.5 – Não usar IDs compartilhados ou genéricos (SubRequisitoId = 40)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Proibir contas genéricas ou compartilhadas, garantindo que cada ação seja atribuída a um usuário único.',
                    'Assegura responsabilização individual e facilita auditorias em caso de incidente.',
                    'A equipe de suporte usa um mesmo login genérico; após mudança crítica, não se sabe quem a executou.',
                    40
                );
            ");

            // 8.6 – Associar tokens, smartcards e certificados a contas individuais (SubRequisitoId = 41)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Vincular dispositivos de autenticação (tokens, smartcards, certificados) a contas específicas de cada usuário.',
                    'Impede uso indevido ou compartilhamento desses dispositivos, mantendo rastreabilidade clara.',
                    'Dois usuários compartilham um certificado digital; em caso de fraude, não é possível identificar o responsável.',
                    41
                );
            ");

            // 8.7 – Restringir acesso a bancos de dados a administradores e via métodos programáticos (SubRequisitoId = 58)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos(Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Permitir acesso direto a bancos de dados apenas a administradores ou por meio de APIs/controladores programáticos.',
                    'Minimiza exposição a consultas manuais ou não auditadas, mantendo todos os acessos sob controle de código.',
                    'Um analista conecta-se diretamente ao banco sem criptografia; com APIs seguras, somente endpoints autorizados seriam usados.',
                    58
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId IN (36,37,38,39,40,41,58);");
        }
    }
}
