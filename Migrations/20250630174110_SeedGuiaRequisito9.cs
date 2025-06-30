using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 9.1 – Auditar e revisar contas e acessos periodicamente (SubRequisitoId = 43)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    44,
                    'Manter registros de quem possui acesso físico a áreas sensíveis e revisar essas permissões regularmente.',
                    'Ajuda a identificar e remover autorizações obsoletas, evitando que ex-colaboradores ou prestadores continuem com acesso indevido.',
                    'Após o fim de um contrato de manutenção, a revisão identifica que o ex-prestador ainda tem acesso à sala de servidores e revoga imediatamente suas credenciais.',
                    43
                );
            ");

            // 9.2 – Fornecer logs de auditoria completos e seguros (SubRequisitoId = 44)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    45,
                    'Registrar todas as entradas e saídas em locais onde há dados de cartão, garantindo integridade dos logs.',
                    'Permite reconstruir eventos em caso de incidente e comprovar conformidade em auditorias, sem risco de adulteração.',
                    'Após o desaparecimento de um disco de backup, os logs protegidos mostram quem entrou na sala e quando, facilitando a investigação.',
                    44
                );
            ");

            // 9.3 – Gerenciar registros de acesso com integridade e segurança (SubRequisitoId = 45)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    46,
                    'Proteger e versionar logs de acesso físico para evitar exclusão ou edição não autorizada.',
                    'Garante disponibilidade e integridade das evidências mesmo que um invasor tente apagar rastros.',
                    'Um invasor tenta apagar seu registro de entrada, mas os logs criptografados em servidor separado impedem a remoção.',
                    45
                );
            ");

            // 9.4 – Garantir que políticas e procedimentos estejam documentados e em uso (SubRequisitoId = 46)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    47,
                    'Formalizar diretrizes de controle de acesso físico e treinar a equipe para segui-las de forma consistente.',
                    'Evita variações entre unidades e garante que novos colaboradores entendam e apliquem corretamente as regras.',
                    'Após padronizar o registro de visitantes em manual, todas as filiais passam a usar o mesmo processo, eliminando falhas.',
                    46
                );
            ");

            // 9.5 – Proteger fisicamente mídias e armazenar backups em local seguro (SubRequisitoId = 59)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    48,
                    'Guardar mídias contendo dados de cartão em locais trancados e manter cópias de backup fora do ambiente principal.',
                    'Reduz riscos de perda acidental, roubo ou danos físicos, garantindo recuperação em caso de desastre.',
                    'Backups diários são enviados a uma instalação externa e armazenados em cofre digital, assegurando disponibilidade.',
                    59
                );
            ");

            // 9.6 – Manter controle rigoroso sobre distribuição interna e externa de mídias (SubRequisitoId = 60)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    49,
                    'Registrar e autorizar cada movimentação de mídias sensíveis dentro e fora da organização.',
                    'Garante rastreabilidade completa e impede extravio ou uso indevido de dispositivos de armazenamento.',
                    'Um funcionário tenta levar um disco externo; o sistema de controle de saída bloqueia a retirada sem autorização.',
                    60
                );
            ");

            // 9.7 – Manter controle rigoroso sobre armazenamento e acessibilidade de mídias (SubRequisitoId = 61)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    50,
                    'Armazenar mídias sensíveis em armários trancados com acesso limitado e monitorado.',
                    'Previne acessos não autorizados e protege contra manipulações internas ou externas.',
                    'Em vez de deixar backups antigos em sala comum, são guardados em armário trancado com registro de acesso por crachá.',
                    61
                );
            ");

            // 9.8 – Destruir mídias quando não forem mais necessárias (SubRequisitoId = 62)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    51,
                    'Eliminar mídias antigas por meio de métodos seguros (trituração, desmagnetização ou sobrescrita).',
                    'Impede recuperação de dados sensíveis após o fim do ciclo de vida, reduzindo impactos de vazamentos.',
                    'Após o período fiscal, os CDs com transações são triturados, garantindo que não possam ser recuperados.',
                    62
                );
            ");

            // 9.9 – Proteger dispositivos de captura de dados contra adulteração e substituição (SubRequisitoId = 63)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    52,
                    'Inspecionar regularmente terminais de pagamento e leitores de cartão para detectar modificações suspeitas.',
                    'Previne ataques de skimming e substituição, assegurando que dispositivos não foram adulterados.',
                    'Caixas verificam diariamente os terminais e reportam qualquer sinal de equipamento estranho ou adicional.',
                    63
                );
            ");

            // 9.10 – Garantir que políticas e procedimentos relacionados sejam documentados e conhecidos (SubRequisitoId = 64)
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    53,
                    'Documentar diretrizes de segurança física e treinar todos os envolvidos para seguir o mesmo padrão.',
                    'Assegura que funcionários, terceiros e equipes de manutenção compreendam e apliquem as políticas corretamente.',
                    'Treinamentos anuais reforçam procedimentos de manuseio de mídias e controle de acesso a áreas restritas.',
                    64
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id BETWEEN 44 AND 53;");
        }
    }
}
