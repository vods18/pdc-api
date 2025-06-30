using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Sub-requisito 3.1 – Limitar armazenamento e retenção de dados conforme necessidade
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    12,
                    'Este sub-requisito determina que os dados de titulares de cartão devem ser armazenados somente quando estritamente necessário, e por um período limitado e justificado. Informações sensíveis não podem ser mantidas indefinidamente — devem ser excluídas ou tornadas irreconhecíveis quando não forem mais essenciais para finalidades operacionais ou legais.',
                    'Manter dados desnecessários representa um risco desnecessário. Caso um sistema seja comprometido, qualquer dado armazenado além do necessário aumenta a gravidade da violação. O PCI DSS orienta que políticas formais de retenção sejam estabelecidas, incluindo critérios claros para eliminação segura das informações ao final de seu ciclo de vida.',
                    'Uma empresa de assinaturas armazena o número completo dos cartões de seus clientes mesmo após o cancelamento da conta, por conveniência. Ao sofrer um vazamento, essas informações são expostas. Com uma política de retenção clara, os dados teriam sido anonimizados ou excluídos após o encerramento da relação contratual, reduzindo o impacto do incidente.',
                    12
                );
            ");

            // Sub-requisito 3.2 – Não armazenar dados sensíveis de autenticação após a autorização
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    13,
                    'Este sub-requisito reforça que os dados sensíveis usados para autenticação — como o código de verificação do cartão (CVV2/CVC2), dados de tarja magnética ou informações de chip — não devem, sob nenhuma circunstância, ser armazenados após a autorização da transação.',
                    'A retenção desses dados constitui uma violação grave dos padrões de segurança, pois eles representam o principal alvo de agentes maliciosos em casos de invasão. O PCI DSS deixa claro que a proteção do titular do cartão não depende apenas da criptografia ou da rede segura, mas também do não armazenamento de dados que, por si só, possibilitem a realização de fraudes.',
                    'Uma empresa de serviços online decide armazenar temporariamente o CVV dos clientes para facilitar compras futuras. Após um incidente de segurança, esses dados são acessados indevidamente e utilizados para fraudes em massa. Se a empresa tivesse seguido o sub-requisito e eliminado o CVV logo após a autorização, o ataque teria sido consideravelmente menos impactante.',
                    13
                );
            ");

            // Sub-requisito 3.3 – Mascarar o PAN quando exibido
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    14,
                    'Este sub-requisito determina que o Primary Account Number (PAN) deve ser mascarado sempre que for exibido, salvo quando houver necessidade legítima de acesso integral.',
                    'A máscara do PAN impede que observadores casuais ou usuários sem autorização visualizem informações sensíveis em telas, relatórios impressos ou sistemas administrativos. A exibição irrestrita do número do cartão amplia significativamente o risco de exposição indevida.',
                    'Uma operadora de call center permite que seus atendentes visualizem o número completo do cartão do cliente na tela de atendimento. Um colaborador mal-intencionado anota os dados e realiza transações indevidas. Se o sistema tivesse aplicado a máscara — exibindo apenas os últimos quatro dígitos — o risco de vazamento seria significativamente reduzido.',
                    14
                );
            ");

            // Sub-requisito 3.4 – Tornar o PAN ilegível onde for armazenado
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    15,
                    'Este sub-requisito estabelece que o PAN deve ser armazenado de forma ilegível, utilizando métodos robustos de proteção de dados, como criptografia forte, tokenização ou truncamento.',
                    'A exposição de PANs legíveis é uma das causas mais recorrentes de vazamentos de dados em ambientes de pagamento. Métodos que tornem esses dados inutilizáveis por terceiros não autorizados são essenciais para a segurança contínua.',
                    'Um sistema de e-commerce salva os números de cartão de seus clientes em texto puro em seu banco de dados. Após um ataque, os invasores acessam esses dados e os utilizam em fraudes. Se o sistema tivesse criptografado os PANs com uma chave protegida, os dados roubados seriam inúteis sem acesso a essa chave.',
                    15
                );
            ");

            // Sub-requisito 3.5 – Proteger chaves de criptografia
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    16,
                    'Este sub-requisito estabelece que as chaves de criptografia utilizadas para proteger dados sensíveis devem ser devidamente protegidas contra acesso, modificação e substituição não autorizados.',
                    'A segurança dos dados criptografados depende inteiramente da confidencialidade e integridade das chaves. Práticas inadequadas podem comprometer toda a eficácia da criptografia.',
                    'Uma empresa armazena seus PANs criptografados, mas deixa a chave salva em um arquivo texto no mesmo servidor, sem restrição de acesso. Após um ataque, a chave é obtida junto com os dados criptografados, permitindo que o invasor recupere os números de cartão.',
                    16
                );
            ");

            // Sub-requisito 3.6 – Gerenciar chaves criptográficas de forma segura
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    17,
                    'Este sub-requisito determina que todas as atividades do ciclo de vida das chaves criptográficas — geração, distribuição, armazenamento, uso, rotação e destruição — devem ser executadas de maneira segura e controlada.',
                    'A gestão inadequada de chaves pode anular completamente os benefícios da criptografia. Diretrizes rígidas asseguram que as chaves não sejam expostas ou comprometidas em nenhum momento.',
                    'Uma organização permite que desenvolvedores mantenham cópias das chaves em seus computadores pessoais para testes. Um dispositivo é comprometido por malware, expondo a chave e os dados protegidos.',
                    17
                );
            ");

            // Sub-requisito 3.7 – Garantir que políticas e procedimentos estejam documentados e em uso
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    18,
                    'Este sub-requisito reforça a necessidade de documentar formalmente todas as práticas relacionadas à proteção de dados armazenados, incluindo políticas de retenção, criptografia, mascaramento e gerenciamento de chaves.',
                    'A existência de políticas bem definidas assegura que todos saibam como os dados sensíveis devem ser tratados, reduzindo falhas operacionais e garantindo consistência das ações.',
                    'Uma empresa implementa criptografia em seus sistemas de pagamento, mas não possui política formal para rotação periódica das chaves. Com o tempo, as mesmas chaves são utilizadas indefinidamente, elevando o risco de comprometimento.',
                    18
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Limpa todas as entradas do requisito 3 (SubRequisitoId de 12 a 18)
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId BETWEEN 12 AND 18;");
        }
    }
}
