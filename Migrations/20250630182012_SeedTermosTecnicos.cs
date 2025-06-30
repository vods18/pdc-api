using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedTermosTecnicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
            name: "TermosTecnicos",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Nome = table.Column<string>(nullable: false),
                Texto = table.Column<string>(nullable: false),
                GuiaRequisitoId = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TermosTecnicos", x => x.Id);
                table.ForeignKey(
                    name: "FK_TermosTecnicos_GuiaRequisitos_GuiaRequisitoId",
                    column: x => x.GuiaRequisitoId,
                    principalTable: "GuiaRequisitos",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });
            
            // Requisito 1: Sub-requisitos 1.1 a 1.5 (IDs 1 a 5)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Firewall', 'Dispositivo físico ou software que analisa o tráfego de rede e aplica regras de segurança.', 1),
                ('Roteador', 'Equipamento que conecta redes distintas e pode filtrar e redirecionar tráfego.', 2),
                ('Default deny', 'Política que bloqueia todo tráfego por padrão, permitindo apenas exceções autorizadas.', 3),
                ('DMZ', 'Zona de rede intermediária que separa sistemas expostos da internet dos internos sensíveis.', 4),
                ('Proxy reverso', 'Servidor intermediário que recebe requisições externas e as encaminha a serviços internos, funcionando como camada de filtragem e controle.', 5);
            ");

            // Requisito 2: Sub-requisitos 2.1 a 2.6 (IDs 6 a 11)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Conta padrão', 'Credencial genérica de fábrica que deve ser alterada antes da instalação.', 6),
                ('CDE', 'Cardholder Data Environment: ambiente que processa, transmite ou armazena dados de cartão.', 6),
                ('Vulnerabilidade conhecida', 'Falha amplamente documentada em repositórios como a NVD (National Vulnerability Database).', 7),
                ('CIS Benchmark', 'Conjunto de recomendações para configuração segura de sistemas.', 7),
                ('NIST', 'National Institute of Standards and Technology: órgão que publica padrões de segurança.', 7),
                ('Acesso administrativo não-console', 'Gerenciamento remoto de sistemas sem acesso físico direto.', 8),
                ('Criptografia', 'Técnica de codificação de dados que impede acesso não autorizado durante a transmissão.', 8),
                ('SSH', 'Secure Shell: protocolo seguro para acessos remotos que substitui o Telnet.', 8),
                ('Inventário de sistemas', 'Lista documentada de todos os componentes de TI ativos na rede.', 9),
                ('Componente do sistema', 'Hardware ou software que processa, armazena ou transmite dados de cartão.', 9),
                ('Política de segurança', 'Conjunto formal de diretrizes que definem como proteger recursos tecnológicos.', 10),
                ('Procedimento', 'Instruções operacionais detalhadas para aplicar políticas de segurança.', 10),
                ('Hospedagem compartilhada', 'Ambiente onde múltiplos clientes utilizam a mesma infraestrutura.', 11),
                ('Isolamento de ambientes', 'Práticas e mecanismos que garantem separação segura entre clientes.', 11),
                ('Hipervisor', 'Componente que gerencia múltiplas máquinas virtuais em um mesmo servidor físico.', 11);
            ");

            // Requisito 3: Sub-requisitos 3.1 a 3.7 (IDs 12 a 18)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Política de retenção de dados', 'diretriz formal que define quais dados podem ser armazenados, por quanto tempo e sob quais condições.', 12),
                ('Eliminação segura', 'processo de remoção de dados que impede sua recuperação, como sobrescrita múltipla ou destruição física de mídias.', 12),
                ('Dados de autenticação sensíveis', 'informações que confirmam a posse física do cartão, como CVV2/CVC2, dados de trilha magnética ou do chip EMV.', 13),
                ('Autorização', 'processo no qual a operadora do cartão valida uma transação antes de sua conclusão.', 13),
                ('PAN', 'número do cartão do titular, composto geralmente por 16 dígitos, que identifica a conta de pagamento.', 14),
                ('Mascaramento', 'técnica que oculta parcialmente uma informação sensível na tela ou em documentos, preservando apenas uma pequena parte visível.', 14),
                ('Privilégio mínimo', 'princípio segundo o qual usuários devem ter apenas o nível de acesso estritamente necessário para desempenhar suas funções.', 14),
                ('Tokenização', 'substituição de dados sensíveis por equivalentes não sensíveis (tokens) que não têm valor fora do sistema que os gerou.', 15),
                ('Truncamento', 'técnica de armazenamento que remove parte dos dígitos de um dado sensível, tornando-o inutilizável para fins fraudulentos.', 15),
                ('Criptografia forte', 'uso de algoritmos reconhecidos e robustos (como AES) para tornar informações ilegíveis sem a chave correspondente.', 15),
                ('Chave criptográfica', 'informação secreta utilizada para transformar dados legíveis em ilegíveis (criptografia) e vice-versa (descriptografia).', 16),
                ('Gerenciamento de chaves', 'conjunto de processos que controlam a criação, armazenamento, uso, rotação e descarte de chaves de forma segura.', 16),
                ('Rotação de chaves', 'prática de trocar periodicamente as chaves criptográficas para reduzir o risco em caso de comprometimento.', 16),
                ('Ciclo de vida da chave', 'etapas que envolvem a criação, distribuição, uso, rotação, expiração e destruição segura de chaves criptográficas.', 17),
                ('Módulo criptográfico seguro', 'componente de hardware ou software projetado para proteger operações criptográficas e armazenar chaves com segurança.', 17),
                ('Destruição segura', 'processo controlado de eliminação de chaves para garantir que não possam ser recuperadas ou reutilizadas.', 17),
                ('Controle de acesso', 'políticas que definem quem pode acessar, utilizar ou alterar as chaves criptográficas, incluindo autenticação e registro de atividades.', 17),
                ('Política de segurança', 'conjunto de regras e diretrizes formais que regem o tratamento de dados sensíveis dentro da organização.', 18),
                ('Procedimento operacional', 'instruções detalhadas para executar tarefas específicas de acordo com as políticas estabelecidas.', 18),
                ('Retenção de dados', 'tempo pelo qual dados são mantidos antes de serem descartados com segurança.', 18),
                ('Auditoria', 'processo de verificação da conformidade das práticas da organização com os requisitos estabelecidos.', 18);
            ");

            // Requisito 4: Sub-requisitos 4.1 a 4.3 (IDs 19 a 21)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('TLS (Transport Layer Security)', 'protocolo criptográfico moderno utilizado para proteger comunicações em redes.', 19),
                ('Criptografia forte', 'métodos de codificação de dados que utilizam algoritmos e tamanhos de chave atualizados, aprovados por padrões como NIST.', 19),
                ('Man-in-the-middle', 'tipo de ataque onde o invasor intercepta e potencialmente modifica a comunicação entre duas partes.', 19),
                ('Rede pública', 'qualquer rede fora do controle direto da organização, como a internet, redes Wi-Fi de aeroportos, cafés, ou conexões móveis.', 19),
                ('PAN (Primary Account Number)', 'número do cartão de pagamento usado para identificar o titular e o emissor.', 20),
                ('Mensagens de usuário', 'canais de comunicação utilizados diretamente por usuários, como e-mails, chat, SMS e aplicativos de mensagens.', 20),
                ('Criptografia ponta a ponta', 'técnica em que apenas o remetente e o destinatário conseguem decifrar a mensagem.', 20),
                ('Procedimento', 'conjunto de passos operacionais detalhados que devem ser seguidos para garantir a conformidade com a política.', 21);
            ");

            // Requisito 5: Sub-requisitos 5.1 a 5.4 (IDs 22 a 25)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Malware', 'software malicioso desenvolvido para causar danos, roubo de informações ou interrupções nos sistemas.', 22),
                ('Ransomware', 'tipo de malware que criptografa dados e exige pagamento para liberar o acesso.', 22),
                ('Spyware', 'tipo de malware que monitora a atividade do usuário e transmite dados sem consentimento.', 23),
                ('Log', 'registro sistemático de eventos e atividades, utilizado para auditoria e análise de incidentes.', 23),
                ('Exfiltração', 'processo de extração não autorizada de dados de um sistema ou rede, geralmente conduzido de forma furtiva por agentes maliciosos.', 23),
                ('Drive-by download', 'técnica na qual malwares são baixados e executados automaticamente ao visitar um site comprometido.', 24),
                ('Trojan (Cavalo de Troia)', 'tipo de malware que se disfarça como software legítimo para obter acesso ao sistema.', 24),
                ('Falso positivo', 'detecção incorreta de uma ameaça onde não existe, gerando um alerta sem fundamento real.', 25);
            ");

            // Requisito 6: Sub-requisitos 6.1 a 6.7 (IDs 26 a 32)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Vulnerabilidade', 'falha de segurança que pode ser explorada por um agente malicioso.', 26),
                ('Patch de segurança', 'atualização fornecida para corrigir falhas em software ou sistemas.', 27),
                ('Janela de exposição', 'período entre a descoberta pública de uma falha e sua correção efetiva no ambiente.', 27),
                ('Práticas seguras de desenvolvimento', 'conjunto de técnicas que visam proteger o código contra ataques comuns.', 28),
                ('Validação de entrada', 'processo de verificar e higienizar dados fornecidos por usuários.', 28),
                ('Controle de mudanças', 'processo formal que regula modificações em sistemas de TI.', 29),
                ('XSS (Cross-site scripting)', 'técnica que permite execução de scripts maliciosos no navegador da vítima.', 30),
                ('SQL injection', 'técnica de injeção que manipula comandos SQL para acessar dados não autorizados.', 30),
                ('OWASP Top 10', 'lista das 10 falhas mais críticas em segurança de aplicações web.', 30),
                ('WAF (Web Application Firewall)', 'sistema que protege aplicações web analisando e filtrando tráfego HTTP.', 31),
                ('Exploração automatizada', 'uso de ferramentas que testam vulnerabilidades de forma massiva e rápida.', 31),
                ('Política de segurança', 'diretrizes formais para proteger os ativos de tecnologia da informação.', 32),
                ('Procedimento operacional', 'conjunto de passos para executar uma tarefa conforme a política definida.', 32),
                ('Conformidade', 'aderência a normas e exigências regulatórias.', 32);
            ");

            // Requisito 7: Sub-requisitos 7.1 a 7.3 (IDs 33 a 35)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('E-commerce', 'modelo de negócio baseado na comercialização de produtos ou serviços por meio de plataformas digitais, como sites ou aplicativos de compra. Essas plataformas frequentemente lidam com dados sensíveis de pagamento, exigindo controles rigorosos de acesso.', 33),
                ('Default deny', 'política de controle de acesso que bloqueia tudo por padrão, liberando apenas o necessário.', 34),
                ('Política de controle de acesso', 'documento que define regras e responsabilidades sobre a concessão e revisão de acessos.', 35),
                ('Revisão periódica de acesso', 'prática de avaliar e validar os acessos concedidos, garantindo que ainda são necessários.', 35),
                ('Auditoria de permissões', 'processo de verificar se os acessos atribuídos estão em conformidade com as políticas estabelecidas.', 35);
            ");

            // Requisito 8: Sub-requisitos 8.1 a 8.8 (IDs 36 a 42 e 58)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('ID de usuário', 'identificador exclusivo atribuído a cada indivíduo que acessa sistemas da organização.', 36),
                ('Conta genérica', 'conta usada por múltiplos usuários, que dificulta a rastreabilidade e a responsabilização.', 36),
                ('Autenticação multi-fator (MFA)', 'combinação de dois ou mais fatores distintos para validar a identidade de um usuário.', 37),
                ('Fatores de autenticação', 'categorias como conhecimento (senha), posse (token) e inerência (biometria).', 37),
                ('Smartcard', 'cartão físico com chip integrado que armazena certificados digitais ou chaves criptográficas, utilizados para autenticação segura em sistemas.', 37),
                ('Phishing', 'técnica de engenharia social que engana usuários para obter informações sensíveis, como senhas ou dados bancários, geralmente por meio de e-mails ou sites falsos.', 38),
                ('VPN (Virtual Private Network)', 'tecnologia que cria um túnel criptografado entre o usuário e a rede da empresa, permitindo o acesso remoto de forma segura.', 38),
                ('Política de autenticação', 'conjunto de regras que definem os requisitos para criação, uso e renovação de credenciais de acesso dentro da organização.', 39),
                ('Conta compartilhada', 'conta acessada por mais de um indivíduo.', 40),
                ('Rastreabilidade', 'capacidade de identificar quem realizou determinada ação em um sistema.', 40),
                ('Token', 'dispositivo físico ou digital que gera códigos de autenticação únicos, geralmente usados como segundo fator em esquemas de autenticação multifator.', 41),
                ('Certificado digital', 'arquivo eletrônico que comprova a identidade de uma entidade (usuário, servidor, sistema), geralmente emitido por uma autoridade certificadora confiável.', 41),
                ('Restringir acesso a bancos de dados', 'acesso direto ao banco deve ser limitado a administradores ou via métodos programáticos/API.', 42),
                ('Acesso programático', 'forma de acessar dados por meio de código ou sistemas automatizados, evitando interação manual direta com o banco de dados.', 58);
            ");

            // Requisito 9: Sub-requisitos 9.1 a 9.10 (IDs 43 a 46 e 59 a 64)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Controle de acesso físico', 'práticas que regulam a entrada de pessoas em áreas protegidas.', 43),
                ('Revisão de acesso', 'processo periódico para verificar se os acessos concedidos continuam apropriados.', 43),
                ('Log de auditoria', 'registro automático ou manual de eventos de acesso a sistemas ou locais críticos.', 44),
                ('Integridade de logs', 'garantia de que os registros não foram alterados ou corrompidos.', 44),
                ('Criptografia de logs', 'técnica para garantir que somente usuários autorizados possam visualizar ou alterar os registros.', 45),
                ('Política de acesso físico', 'documento que define regras para entrada, permanência e registro em áreas restritas.', 46),
                ('Backup externo', 'cópia de segurança mantida fora da sede da empresa.', 59),
                ('Mídia removível', 'dispositivo portátil usado para armazenar ou transportar dados (ex: pen drive, disco rígido externo).', 60),
                ('Registro de movimentação', 'documento ou sistema que rastreia a entrada e saída de mídias da organização.', 61),
                ('Descarte seguro', 'procedimento que garante a inutilização permanente de mídias.', 62),
                ('Desmagnetização', 'método de apagar dados de mídias magnéticas usando campo magnético intenso.', 62),
                ('Skimming', 'técnica de copiar dados de cartões por meio de dispositivos clandestinos instalados em leitores legítimos.', 63),
                ('Sensibilização de segurança', 'atividades que visam educar os colaboradores sobre boas práticas e riscos de segurança.', 64),
                ('Política de segurança física', 'documento que rege como os ativos físicos da empresa devem ser protegidos.', 64);
            ");

            // Requisito 10: Sub-requisitos 10.1 a 10.9 (IDs 47 a 49 e 65 a 70)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Phishing', 'técnica usada por atacantes para enganar usuários e obter dados sensíveis, normalmente por e-mail.', 47),
                ('Análise forense', 'investigação técnica de sistemas para identificar causas e impactos de incidentes.', 48),
                ('Log de segurança', 'registro de eventos relacionados a acessos e atividades em sistemas.', 49),
                ('NTP', 'Network Time Protocol: protocolo utilizado para sincronização de horário entre sistemas.', 65),
                ('Audit trail', 'registro cronológico de eventos e ações em sistemas.', 66),
                ('Anomalia', 'comportamento fora do padrão esperado.', 67),
                ('Retenção de audit trails', 'manter logs por no mínimo um ano, com três meses acessíveis.', 68),
                ('Detecção de falhas em controles', 'mecanismos para identificar e reportar falhas em firewalls, antivírus e autenticação.', 69),
                ('Documentar audit trails', 'formalizar e comunicar políticas de coleta, retenção e proteção de logs.', 70);
            ");

            // Requisito 11: Sub-requisitos 11.1 a 11.6 (IDs 50 a 53 e 73 a 74)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Vulnerabilidade', 'falha ou fraqueza em um sistema que pode ser explorada para comprometer sua segurança.', 50),
                ('Teste de intrusão', 'simulação de ataque para avaliar a segurança de um sistema.', 51),
                ('Varredura de vulnerabilidades', 'processo de identificação automática de falhas em sistemas.', 52),
                ('Desabilitar recursos não usados', 'remover serviços, portas e contas inativas para reduzir a superfície de ataque.', 53),
                ('Inventário de APs', 'manter lista de pontos de acesso autorizados e testar redes sem fio regularmente.', 73),
                ('Monitoramento de integridade', 'detectar alterações não autorizadas em arquivos críticos.', 74);
            ");

            // Requisito 12: Sub-requisitos 12.1 a 12.9 (IDs 54 a 79)
            migrationBuilder.Sql(@"
                INSERT INTO TermosTecnicos (Nome, Texto, GuiaRequisitoId) VALUES
                ('Política de segurança da informação', 'documento que define regras e diretrizes para a proteção de dados e sistemas.', 54),
                ('Avaliação de riscos', 'processo de identificar, analisar e priorizar ameaças potenciais à segurança da informação.', 55),
                ('Política de uso remoto e wireless', 'diretrizes sobre acesso remoto, redes sem fio, mídia removível e internet.', 56),
                ('Documentar políticas', 'assegurar que procedimentos estejam formalizados e aplicados.', 57),
                ('Responsabilidades de segurança', 'atribuir papéis claros para coordenação e monitoramento.', 75),
                ('Programas de conscientização', 'treinamentos regulares para educar colaboradores sobre riscos.', 76),
                ('Triagem de candidatos', 'verificar antecedentes e referências antes da contratação.', 77),
                ('Gestão de terceiros', 'políticas e SLAs para provedores que manipulam dados de cartão.', 78),
                ('Reconhecimento de responsabilidade', 'termos formais para provedores assumirem obrigações de segurança.', 79);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.DropTable(
                name: "TermosTecnicos");

            // Remove todos os termos técnicos inseridos
            migrationBuilder.Sql(@"
                DELETE FROM TermosTecnicos
                WHERE GuiaRequisitoId BETWEEN 1 AND 79;
            ");
        }
    }
}
