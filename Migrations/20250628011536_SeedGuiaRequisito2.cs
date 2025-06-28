using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Sub-requisito 2.1
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito estabelece que credenciais padrão fornecidas por fabricantes — como nomes de usuário e senhas genéricas — devem ser desativadas ou modificadas antes da instalação de qualquer sistema ou dispositivo. Isso inclui equipamentos de rede, sistemas operacionais, softwares de gestão e dispositivos de segurança que, por padrão, vêm configurados com acessos amplamente conhecidos.',
                    'Manter essas configurações padrão representa uma vulnerabilidade crítica. Credenciais genéricas são facilmente encontradas em manuais técnicos e bancos de dados públicos, sendo um dos primeiros vetores explorados por agentes maliciosos durante varreduras automatizadas. Ao desconsiderar essa etapa, a organização expõe diretamente sua infraestrutura a acessos indevidos — especialmente no ambiente que manipula dados sensíveis, como o CDE.',
                    'Uma pequena loja de varejo instala um roteador comercial que ainda utiliza a senha padrão “admin/admin”. Um atacante, conectado à mesma rede Wi-Fi, acessa a interface do equipamento e redireciona o tráfego para capturar informações confidenciais dos clientes. Ao substituir as credenciais padrão durante a instalação, esse risco teria sido facilmente evitado.',
                    6
                );
            ");

            // Sub-requisito 2.2
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito orienta que as organizações estabeleçam padrões técnicos que levem em consideração vulnerabilidades amplamente documentadas em sistemas operacionais, softwares e dispositivos conectados à rede. Esses padrões devem prever, por exemplo, a desativação de serviços não utilizados, o bloqueio de portas desnecessárias e o uso de protocolos seguros.',
                    'Ao adotar configurações seguras desde a instalação, a organização reduz significativamente sua exposição a ataques que exploram falhas já conhecidas. Essas vulnerabilidades são alvos frequentes de varreduras automatizadas realizadas por agentes maliciosos que buscam sistemas desatualizados ou mal configurados para invadir.',
                    'Uma empresa instala um servidor com o protocolo Telnet habilitado por padrão. Apesar de não ser utilizado, o serviço permanece ativo e expõe comunicações desprotegidas. Um atacante usa essa brecha para interceptar credenciais. Se existisse um padrão exigindo a desativação de protocolos inseguros, esse risco teria sido eliminado na configuração inicial do servidor.',
                    7
                );
            ");

            // Sub-requisito 2.3
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito exige que qualquer acesso administrativo a sistemas e dispositivos que não ocorra fisicamente no equipamento (ou seja, acessos remotos) seja realizado por meio de canais criptografados. Isso garante que credenciais, comandos e informações sensíveis não possam ser interceptados durante a transmissão.',
                    'A exigência busca impedir ataques como man-in-the-middle, nos quais agentes maliciosos monitoram o tráfego de rede para capturar dados de autenticação ou modificar comandos enviados a servidores e dispositivos. Utilizar protocolos inseguros em acessos administrativos representa um risco significativo à integridade e confidencialidade dos sistemas críticos da organização.',
                    'Um administrador realiza a manutenção de um servidor via SSH, garantindo que as credenciais e os comandos estejam protegidos por criptografia de ponta a ponta. Caso o mesmo acesso fosse feito por Telnet, qualquer atacante monitorando a rede poderia visualizar as credenciais em texto puro e obter controle total do servidor.',
                    8
                );
            ");

            // Sub-requisito 2.4
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito exige que a organização mantenha um inventário formal e atualizado de todos os componentes que compõem o ambiente de dados do cartão (CDE) ou que possam impactar sua segurança. Isso inclui servidores, dispositivos de rede, aplicações, equipamentos de segurança e quaisquer outros ativos relevantes.',
                    'A existência de um inventário preciso permite que a organização saiba exatamente quais sistemas estão presentes, onde estão localizados, quem é responsável por eles e quais riscos representam. Sem essa visibilidade, é impossível garantir que todos os dispositivos estejam devidamente configurados, atualizados e monitorados — o que pode abrir brechas críticas na segurança.',
                    'Um auditor solicita a lista de dispositivos que compõem a rede da empresa. A organização, por manter um inventário atualizado, consegue apresentar rapidamente todos os ativos, incluindo modelo, função, responsável técnico e status de segurança de cada um. Com isso, garante-se que nenhum dispositivo desconhecido ou não autorizado esteja operando no ambiente sensível da empresa.',
                    9
                );
            ");

            // Sub-requisito 2.5
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito determina que a organização deve formalizar políticas e procedimentos relacionados à configuração segura de sistemas, gestão de senhas, controle de inventário e outros aspectos associados à segurança do ambiente. A documentação deve ser acessível, aprovada pela administração e refletir fielmente as práticas aplicadas.',
                    'Documentar políticas e procedimentos é essencial para garantir continuidade, padronização e rastreabilidade das práticas de segurança. Isso reduz a dependência de conhecimento individual e assegura que mudanças, auditorias e treinamentos sejam baseados em orientações claras.',
                    'Durante uma auditoria, a empresa não consegue comprovar as diretrizes adotadas para configuração de sistemas por ausência de documentação formal. Com políticas bem documentadas, seria possível demonstrar conformidade e identificar responsabilidades com clareza.',
                    10
                );
            ");

            // Sub-requisito 2.6
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    'Este sub-requisito aplica-se a provedores de serviços que utilizam ambientes de hospedagem compartilhada, exigindo a separação lógica ou física entre os ambientes de diferentes clientes para garantir que os dados, processos e recursos de um cliente não sejam acessíveis ou visíveis a outro.',
                    'O isolamento adequado de ambientes é fundamental em cenários de multitenancy, pois vulnerabilidades em um cliente não devem impactar nem expor dados de outros. Sem esse controle, falhas de configuração ou exploração de brechas de segurança podem comprometer todo o serviço oferecido.',
                    'Um provedor de hospedagem virtualizada implementa redes separadas por cliente e hipervisores seguros. Se, por falha, máquinas virtuais de clientes distintos ficarem no mesmo segmento, um invasor poderia explorar essa proximidade para acessar dados alheios.',
                    11
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE SubRequisitoId BETWEEN 6 AND 11;");
        }
    }
}
