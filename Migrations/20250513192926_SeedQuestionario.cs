using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql(@"
                INSERT INTO Questionario (Pergunta, Resposta, Visivel) VALUES
                ('Existe uma política implementada para revisar periodicamente essas configurações de segurança, garantindo que apenas acessos necessários sejam permitidos e que conexões inseguras (como Wi-Fi desprotegido e acessos remotos sem proteção) sejam bloqueadas ou adequadamente protegidas?', NULL, 1),
                ('Sua empresa garante que todas as senhas padrão de fábrica foram alteradas e que houve uma análise das configurações fornecidas pelos fabricantes para que possíveis falhas sejam removidas antes da instalação nos sistemas?', NULL, 1),
                ('Sua empresa possui padrões documentados para configuração do sistema, incluindo controle de vulnerabilidades, uso de criptografia para acessos administrativos e inventário atualizado dos componentes em uso?', NULL, 1),
                ('Sua empresa armazena dados completos de cartões (PAN, CVV, trilha magnética, chip) ou mantém qualquer dado de cartão sem criptografia forte ou mascaramento adequado', NULL, 1),
                ('Sua empresa possui uma política formal para limitar a retenção de dados de cartões, incluindo um processo de exclusão periódica das informações não mais necessárias?', NULL, 1),
                ('Sua empresa transmite dados de cartão por redes públicas (ex.: Internet, Wi-Fi, redes móveis) e garante que todas essas transmissões utilizam criptografia forte e protocolos seguros?', NULL, 1),
                ('Todos os sistemas vulneráveis a malware possuem um antivírus atualizado, ativo com varreduras periódicas e configurado para impedir a visualização e desativação não autorizada?', NULL, 1),
                ('Todos os sistemas e aplicações são protegidos contra vulnerabilidades conhecidas, incluindo a aplicação de patches de segurança e a adoção de práticas seguras de desenvolvimento de software?', NULL, 1),
                ('Os desenvolvedores da empresa recebem treinamento contínuo em relação a essas práticas seguras de codificação para evitar vulnerabilidades comuns?', NULL, 1),
                ('O acesso aos dados do cartão e aos sistemas relacionados é restrito apenas a funcionários que precisam dessas informações para realizar seu trabalho, e o sistema de controle de acesso segue o princípio de ""negação padrão"" (default deny), concedendo permissões apenas quando necessário?', NULL, 1),
                ('Todos os usuários e administradores possuem identificações únicas (usuário e senha próprios) antes de acessar sistemas e dados do cartão, sem uso de contas compartilhadas ou genéricas?', NULL, 1),
                ('A autenticação dos usuários utiliza pelo menos um fator seguro (senha, token, smart card ou biometria) e protege credenciais com criptografia forte?', NULL, 1),
                ('O acesso administrativo não-console, qualquer acesso remoto ao ambiente de dados do cartão e acessos diretos a bancos de dados são restritos e protegidos por autenticação multifator (MFA) e controles específicos para administradores?', NULL, 1),
                ('O acesso físico às áreas e dispositivos que armazenam ou processam dados de cartão é restrito apenas a pessoas autorizadas, monitorado adequadamente e há diferenciação clara entre funcionários e visitantes (ex.: crachás, controle de entrada)?', NULL, 1),
                ('Todos os tipos de mídia contendo dados de cartão (físicos ou eletrônicos) são armazenados com segurança, controlados rigorosamente, destruídos quando não são mais necessários e os dispositivos de captura de cartão são protegidos contra adulteração, com funcionários treinados para identificar sinais de manipulação?', NULL, 1),
                ('Todos os acessos aos sistemas e dados do cartão são registrados em trilhas de auditoria, vinculando cada ação a um usuário específico?', NULL, 1),
                ('Os logs do sistema registram eventos essenciais (como tentativas de acesso inválidas, alterações em contas e ações administrativas), são protegidos contra alteração, sincronizados com um servidor de horário confiável e armazenados por pelo menos um ano, com três meses acessíveis para análise imediata?', NULL, 1),
                ('A empresa realiza varreduras periódicas para identificar e remover pontos de acesso sem fio não autorizados, mantendo um inventário atualizado dos dispositivos aprovados?', NULL, 1),
                ('São realizados testes de vulnerabilidade e testes de invasão periodicamente, incluindo varreduras internas e externas a cada trimestre e testes de penetração pelo menos uma vez por ano ou após mudanças significativas na rede?', NULL, 1),
                ('A empresa usa sistemas de detecção e prevenção de intrusão (IDS/IPS) e mecanismos de detecção de alterações (ex.: monitoramento de integridade de arquivos) para identificar atividades suspeitas e modificações não autorizadas em arquivos críticos?', NULL, 1),
                ('A empresa possui uma política de segurança formal, documentada e revisada pelo menos anualmente, além de realizar avaliações de risco periódicas para identificar ameaças e vulnerabilidades?', NULL, 1),
                ('A empresa possui um programa de conscientização em segurança da informação para funcionários, realiza verificações antes da contratação para minimizar riscos internos e tem uma equipe ou indivíduo responsável por segurança da informação e um plano de resposta a incidentes documentado e testado?', NULL, 1)
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Questionario");
        }
    }
}
