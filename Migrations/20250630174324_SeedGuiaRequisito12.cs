using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 12.1 – Estabelecer, publicar e revisar anualmente política de segurança da informação (SubRequisitoId = 54)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    69,
                    'Manter uma política de segurança formal que seja publicada, disseminada e revista anualmente ou sempre que mudanças significativas ocorrerem.',
                    'Revisar a política regularmente garante que ela reflita o ambiente atual e continue eficaz contra novas ameaças.',
                    'Uma empresa documenta e publica sua política de segurança, revisando-a após uma grande migração para a nuvem.',
                    54
                );
            ");

            // 12.2 – Implementar avaliação de riscos anual e após mudanças significativas (SubRequisitoId = 55)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    70,
                    'Conduzir avaliações formais de risco pelo menos uma vez ao ano e sempre que houver alterações relevantes na infraestrutura.',
                    'Avaliações frequentes identificam novos pontos fracos antes que sejam explorados por atacantes.',
                    'Após integrar um novo serviço em nuvem, a equipe realiza uma avaliação de riscos para ajustar controles de acesso.',
                    55
                );
            ");

            // 12.3 – Desenvolver políticas de uso para acesso remoto, wireless, mídia removível e internet (SubRequisitoId = 56)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    71,
                    'Definir diretrizes claras sobre o uso seguro de acesso remoto, redes sem fio, mídias removíveis e navegação na internet.',
                    'Políticas específicas reduzem erros de uso e evitam mal-entendidos que podem causar exposições de dados.',
                    'Uma regra proíbe copiar dados sensíveis para pendrives pessoais e exige VPN com MFA para acesso remoto.',
                    56
                );
            ");

            // 12.4 – Garantir que políticas e procedimentos estejam documentados e em uso (SubRequisitoId = 57)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    72,
                    'Documentar políticas e procedimentos de forma acessível e garantir sua aplicação efetiva no dia a dia.',
                    'Sem aplicação prática, a existência de documentos não impede falhas operacionais.',
                    'Durante auditoria, confirma-se que todos seguem o procedimento oficial de gestão de senhas documentado.',
                    57
                );
            ");

            // 12.5 – Atribuir responsabilidades de segurança da informação a indivíduos ou equipes (SubRequisitoId = 75)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    73,
                    'Nomear claramente quem coordena e monitora iniciativas de segurança da informação na organização.',
                    'Responsabilização assegura que tarefas críticas não sejam negligenciadas e que exista ponto focal.',
                    'Um responsável interno recebe e gerencia relatórios periódicos de avaliação de vulnerabilidades.',
                    75
                );
            ");

            // 12.6 – Implementar programa formal de conscientização em segurança para todo o pessoal (SubRequisitoId = 76)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    74,
                    'Desenvolver e manter treinamentos regulares para educar funcionários sobre boas práticas e riscos.',
                    'Usuários informados reduzem erros humanos e atuam como uma linha de defesa adicional.',
                    'Após um módulo de phishing, funcionários detectam e reportam tentativas reais de e-mail malicioso.',
                    76
                );
            ");

            // 12.7 – Realizar triagem de candidatos antes da contratação (SubRequisitoId = 77)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    75,
                    'Verificar antecedentes e referências de candidatos que terão acesso a dados sensíveis.',
                    'Triagem prévia minimiza o risco de ameaças internas e aumenta a confiança na equipe.',
                    'Um novo funcionário com histórico inconsistente em testes de referência tem acesso restrito até revisão.',
                    77
                );
            ");

            // 12.8 – Gerenciar políticas e procedimentos para provedores de serviço de dados de cartão (SubRequisitoId = 78)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    76,
                    'Estabelecer contratos e controles para provedores que manipulam dados de cartão em nome da empresa.',
                    'Garantir que terceiros atendam aos mesmos padrões de segurança evita pontos fracos externos.',
                    'Contrato com provedor de nuvem inclui cláusulas de criptografia e resposta a incidentes.',
                    78
                );
            ");

            // 12.9 – Exigir reconhecimento escrito dos provedores sobre responsabilidade pela segurança de dados (SubRequisitoId = 79)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    77,
                    'Obter confirmação formal de provedores sobre suas obrigações de proteger os dados que gerenciam.',
                    'Reconhecimento por escrito fortalece a corresponsabilidade e facilita a atuação em caso de incidentes.',
                    'Provedor assina termo confirmando responsabilidade pela segurança dos dados de cartão sob sua custódia.',
                    79
                );
            ");

            // 12.10 – Implementar plano de resposta a incidentes e estar preparado para reações imediatas (SubRequisitoId = 80)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    78,
                    'Desenvolver, testar e manter um plano que descreva como detectar, conter e remediar incidentes.',
                    'Ter um roteiro definido reduz o tempo de resposta e mitiga impactos em casos reais.',
                    'Em um ransomware, a equipe segue o plano testado, isola servidores e restaura backups em horas.',
                    80
                );
            ");

            // 12.11 – Realizar e documentar revisões trimestrais de políticas e procedimentos de segurança (SubRequisitoId = 81)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    79,
                    'Conduzir revisões formais a cada trimestre para verificar se políticas e procedimentos estão alinhados à realidade.',
                    'Revisões regulares garantem que documentos reflitam mudanças tecnológicas e novas ameaças.',
                    'Após adoção de trabalho remoto, a política de VPN é atualizada e revalidada em reunião trimestral.',
                    81
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id IN (69,70,71,72,73,74,75,76,77,78,79);");
        }
    }
}
