using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 7.1 – Conceder acesso apenas a quem precisa (SubRequisitoId = 16)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Garantir que apenas usuários com necessidade legítima tenham permissão para acessar dados sensíveis, seguindo o princípio de menor privilégio.',
                    'Reduz o risco de vazamento acidental ou intencional de informações, limitando a superfície de ataque e facilitando auditorias.',
                    'Em um sistema de e-commerce, somente o time de faturamento pode ver o número completo do cartão, enquanto atendimento e marketing veem apenas dados mascarados.',
                    16
                );
            ");

            // 7.2 – Implementar sistema de controle com negação por padrão (SubRequisitoId = 17)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Configurar todos os acessos como negados por padrão e liberar apenas o estritamente necessário, evitando permissões excessivas.',
                    'Previne que contas recém-criadas ou recursos não revisados tenham acesso indevido, reforçando a governança de acesso.',
                    'Um novo colaborador não recebe nenhum acesso até que seja aprovada formalmente sua função e responsabilidades.',
                    17
                );
            ");

            // 7.3 – Garantir que políticas e procedimentos estejam documentados e em uso (SubRequisitoId = 18)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Formalizar critérios e processos de concessão, revisão e revogação de acessos em um manual de políticas, e treinar equipes para segui-lo.',
                    'Documentação e treinamento asseguram conformidade contínua, evitam improvisações e suportam auditorias regulares.',
                    'A equipe de TI realiza revisões trimestrais de permissões, seguindo uma checklist oficial registrada em política de controle de acesso.',
                    18
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId IN (16, 17, 18);");
        }
    }
}
