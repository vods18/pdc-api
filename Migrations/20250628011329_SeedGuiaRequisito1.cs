using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Sub-requisito 1.1
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito determina que todas as organizações devem definir, documentar e aplicar padrões de configuração para dispositivos que realizam controle de tráfego de rede, como firewalls e roteadores. Esses padrões devem ser revisados periodicamente e seguidos de forma consistente em todo o ambiente de rede.',
                    'A padronização garante que todos os pontos de entrada e saída da rede estejam protegidos por regras mínimas de segurança. Dispositivos mal configurados ou mantidos com parâmetros genéricos representam brechas críticas, muitas vezes exploradas por agentes maliciosos para obter acesso indevido a dados sensíveis. Com diretrizes bem definidas, a organização reduz a exposição a riscos e assegura que as boas práticas sejam replicadas em toda a infraestrutura, inclusive em filiais e ambientes remotos.',
                    'Uma empresa com filiais conectadas à matriz via VPN define um padrão que obriga todos os roteadores a bloquear portas desnecessárias e exigir autenticação forte para acesso remoto. Isso evita falhas humanas e garante segurança uniforme.',
                    1
                );
            ");

            // Sub-requisito 1.2
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito determina que os dispositivos de segurança da rede devem ser configurados com base no princípio de default deny, ou seja, todo o tráfego deve ser bloqueado por padrão, e apenas comunicações expressamente autorizadas devem ser permitidas.',
                    'Adotar essa política reduz significativamente os vetores de ataque, impedindo que conexões não previstas ou maliciosas circulem pela rede. A inspeção e o controle detalhado de entradas e saídas — considerando endereços de origem, destino, portas e protocolos — são essenciais para evitar acessos indevidos e proteger o ambiente onde os dados de titulares de cartão (CDE) são manipulados.',
                    'Uma empresa deixa diversas portas abertas no firewall, inclusive a porta 3306 utilizada por serviços MySQL. Um atacante interno identifica essa brecha e tenta acessar o banco de dados de forma não autorizada. Caso as regras de tráfego seguissem o modelo de negação por padrão, com liberação específica apenas para o sistema de faturamento interno, o ataque teria sido automaticamente bloqueado.',
                    2
                );
            ");

            // Sub-requisito 1.3
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito estabelece que nenhum sistema do ambiente de dados dos titulares de cartão (CDE) deve estar diretamente acessível a partir da internet. Servidores internos, bancos de dados e outros ativos críticos devem ser isolados por camadas intermediárias de segurança, como firewalls, zonas desmilitarizadas (DMZ) ou servidores proxy.',
                    'Essa separação lógica e física entre redes públicas e sistemas sensíveis reduz drasticamente o risco de invasões diretas. Mesmo que um serviço exposto — como um site institucional — seja comprometido, a existência de barreiras impede o acesso imediato ao CDE, limitando a ação de agentes maliciosos e preservando a confidencialidade das informações.',
                    'Uma empresa de e-commerce hospeda seu site público na mesma rede em que se encontra o banco de dados com informações de pagamento. Um atacante explora uma vulnerabilidade no site e acessa os dados do cartão dos clientes. Com uma arquitetura adequada, o site estaria isolado em uma DMZ, com regras que impediriam a comunicação direta com o banco de dados, bloqueando o ataque.',
                    3
                );
            ");

            // Sub-requisito 1.4
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito estabelece que todos os dispositivos que acessam a rede da organização a partir de ambientes externos — como redes públicas, domésticas ou móveis — devem possuir um firewall pessoal ativo e configurado com regras de segurança consistentes. O ideal é que tais configurações sejam controladas pela própria organização, especialmente em dispositivos corporativos.',
                    'A presença de um firewall pessoal garante que mesmo fora do perímetro de segurança da empresa, os dispositivos mantenham um nível adequado de proteção. Isso reduz o risco de acessos não autorizados, interceptações de tráfego e infecções por malware em redes não confiáveis, protegendo o ambiente corporativo contra comprometimentos indiretos.',
                    'Um colaborador em viagem conecta seu notebook corporativo à rede Wi-Fi de um hotel. Sem um firewall pessoal ativo, o notebook fica exposto a ataques como varredura de portas e interceptação de tráfego por outros dispositivos da mesma rede. Com o firewall devidamente configurado, apenas conexões autorizadas — como com os sistemas internos da empresa — são permitidas, reduzindo significativamente os riscos.',
                    4
                );
            ");

            // Sub-requisito 1.5
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito reforça a necessidade de documentar formalmente as práticas relacionadas à configuração, manutenção e revisão de dispositivos de rede como firewalls e roteadores. A documentação deve incluir diretrizes claras sobre como esses dispositivos devem ser utilizados, quem são os responsáveis por mantê-los, e com que frequência as configurações devem ser revisadas.',
                    'Estabelecer políticas formais garante que a segurança não dependa exclusivamente da memória ou experiência individual dos técnicos. Além disso, procedimentos bem definidos evitam improvisações, falhas operacionais e garantem continuidade quando houver mudanças na equipe. Essa padronização é essencial para manter a integridade do ambiente de dados dos titulares de cartão (CDE) ao longo do tempo.',
                    'Uma empresa de pequeno porte instala um firewall, mas não registra suas configurações nem define responsáveis por sua manutenção. Anos depois, com mudanças na equipe de TI, um novo técnico remove uma regra de bloqueio essencial por desconhecimento, interrompendo o sistema de pagamento e expondo a rede a riscos. Com políticas e procedimentos adequadamente documentados, esse tipo de falha seria evitado.',
                    5
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId IN (1, 2, 3, 4, 5);");
        }
    }
}
