using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 7.1 – Conceder acesso apenas a quem precisa
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    33,
                    'Garantir que apenas usuários com necessidade legítima tenham permissão para acessar dados sensíveis, seguindo o princípio de menor privilégio.',
                    'Reduz o risco de vazamento acidental ou intencional de informações, limitando a superfície de ataque e facilitando auditorias.',
                    'Em um sistema de e-commerce, somente o time de faturamento pode ver o número completo do cartão, enquanto atendimento e marketing veem apenas dados mascarados.',
                    33
                );
            ");

            // 7.2 – Implementar sistema de controle com negação por padrão
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    34,
                    'Configurar todos os acessos como negados por padrão e liberar apenas o estritamente necessário, evitando permissões excessivas.',
                    'Previne que contas recém-criadas ou recursos não revisados tenham acesso indevido, reforçando a governança de acesso.',
                    'Um novo colaborador não recebe nenhum acesso até que seja aprovada formalmente sua função e responsabilidades.',
                    34
                );
            ");

            // 7.3 – Garantir que políticas e procedimentos estejam documentados e em uso
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    35,
                    'Formalizar critérios e processos de concessão, revisão e revogação de acessos em um manual de políticas, e treinar equipes para segui-lo.',
                    'Documentação e treinamento asseguram conformidade contínua, evitam improvisações e suportam auditorias regulares.',
                    'A equipe de TI realiza revisões trimestrais de permissões, seguindo uma checklist oficial registrada em política de controle de acesso.',
                    35
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id IN (33, 34, 35);");
        }
    }
}
