using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable


namespace pdc_api.Migrations
{
   /// <inheritdoc />
   public partial class SeedSoftwares : Migration
   {
       /// <inheritdoc />
       protected override void Up(MigrationBuilder migrationBuilder)
       {
           migrationBuilder.InsertData(
               table: "Softwares",
               columns: new[] { "Nome", "Justificativa", "Fonte", "SubRequisitoId" },
               values: new object[,]
               {
                   { "TinyWall", "TinyWall oferece uma interface leve e intuitiva sobre o firewall nativo do Windows, permitindo gerenciar regras de entrada e saída de forma padronizada e segura. Ele protege contra desativações não autorizadas, mantém políticas consistentes e bloqueia solicitações inseguras.", "https://tinywall.pados.hu/features.php", 1 },
                   { "TinyWall", "Usa política de “negação por padrão”, bloqueando automaticamente conexões não autorizadas, em conformidade com os princípios de segmentação de rede exigidos pelo PCI DSS.", "https://tinywall.pados.hu/features.php", 2 },
                   { "TinyWall", "Com filtragem por aplicação e domínio, TinyWall impede que serviços não autorizados acessem redes públicas diretamente, protegendo o ambiente de dados sensíveis.", "https://tinywall.pados.hu/features.php", 3 },
                   { "TinyWall", "Instalável em dispositivos Windows, oferece proteção de endpoint com controle ativo de conexões, ideal para notebooks em trabalho remoto.", "https://tinywall.pados.hu/features.php", 4 },
                   { "Microsoft Local Users and Groups (lusrmgr.msc)", "Ferramenta nativa do Windows que permite desativar contas padrão (como Administrator) e alterar senhas em instalações novas, atendendo ao requisito essencial de eliminar credenciais genéricas e reduzir vetores iniciais de acesso não autorizado.", "https://www.reddit.com/r/techsupport/comments/52gx4k/how_do_i_prevent_a_user_from_changing_their_pw", 6 },
                   { "Microsoft Security Compliance Toolkit (SCT)", "O SCT inclui baselines de segurança recomendados pela Microsoft para Windows e outras plataformas, além de ferramentas como o PolicyAnalyzer e LGPO.exe, que permitem comparar, exportar e aplicar políticas de grupo (GPO) seguras — facilitando a criação e aplicação de padrões robustos de configuração.", "https://learn.microsoft.com/en-us/windows/security/operating-system-security/device-management/windows-security-configuration-framework/security-compliance-toolkit-10", 7 },
                   { "Windows Remote Desktop Protocol (RDP) com TLS padrão", "O RDP do Windows utiliza criptografia TLS por padrão em todas as sessões administrativas remotas. Quando configurado corretamente (NLA e TLS obrigatório), assegura que credenciais e dados administrativos sejam protegidos durante a transmissão pela rede.", "https://security.berkeley.edu/education-awareness/securing-remote-desktop-rdp-system-administrators", 8 },
                   { "OCS Inventory NG Agent para Windows", "Ferramenta open source com agente Windows, que coleta hardware e software de forma automatizada, enviando os dados para o servidor central. Atende ao requisito de registrar configurações e componentes do sistema para fins de auditoria e rastreabilidade.", "https://en.m.wikipedia.org/wiki/OCS_Inventory", 9 },
                   { "Windows Sandbox", "O Windows Sandbox cria um ambiente virtual leve e temporário, isolado do sistema principal, ideal para separar instâncias de ambiente de teste ou de clientes distintos em hospedagens compartilhadas. Fornece isolamento baseado em hypervisor sem configuração complexa.", "https://learn.microsoft.com/en-us/windows/security/application-security/application-isolation/windows-sandbox/", 11 },
                   { "Microsoft Purview Data Lifecycle Management", "Permite criar e aplicar políticas automatizadas de retenção e exclusão de dados nas plataformas Microsoft 365 (Exchange, SharePoint, OneDrive, Teams, etc.), ajudando a remover dados de cartão quando não são mais necessários.", "https://learn.microsoft.com/en-us/purview/data-lifecycle-management", 12 },
                   { "Microsoft Purview Information Protection (MIP)", "O MIP identifica e classifica automaticamente dados sensíveis (como CVV), permitindo aplicar proteção ou impedir o armazenamento após o uso, evitando retenção indevida.", "https://learn.microsoft.com/en-us/purview/data-lifecycle-management", 13 },
                   { "Splunk Edge Processor", "Permite mascarar ou truncar PAN em pipelines antes da ingestão no SIEM, exibindo apenas os últimos 4 dígitos, em conformidade com PCI DSS 3.3.", "https://lantern.splunk.com/Security/UCE/Foundational_Visibility/Compliance/Using_Edge_Processor_to_mask_or_truncate_cardholder_data_for_PCI_DSS_compliance", 14 },
                   { "IRI FieldShield", "Realiza mascaramento estático e formatação-preservante de dados, permitindo que o PAN seja armazenado de forma criptografada ou tokenizada.", "https://www.iri.com/solutions/data-masking/pci-dss", 15 },
                   { "Cosmian KMS", "Servidor KMS open source compatível com FIPS, oferecendo armazenamento seguro de chaves, rotação, criação e API para integração.", "https://github.com/Cosmian/kms", 16 },
                   { "OpenSSL (Win64 OpenSSL)", "O OpenSSL oferece implementação completa dos protocolos TLS 1.2 e 1.3 no Windows, habilitando criptografia forte com algoritmos como AES-GCM e curvas elípticas. A adoção desses protocolos é explicitamente exigida pelo PCI DSS para proteção de dados em trânsito sobre redes públicas.", "https://www.ssl.com/guide/tls-standards-compliance/", 19 },
                   { "Signal Desktop", "O Signal utiliza o protocolo Signal – amplamente reconhecido por seu padrão de segurança e confidencialidade – garantindo criptografia de ponta a ponta para qualquer mensagem ou arquivo enviado entre usuários.", "https://en.m.wikipedia.org/wiki/Signal_(software)", 20 },
                   { "Microsoft Defender Antivirus", "Antivírus nativo do Windows com proteção em tempo real, compatível com sistemas Windows 10/11 e servidores. Ele detecta e bloqueia malware comum, sendo instalado por padrão nos dispositivos, em conformidade com a exigência de cobertura antimalware.", "https://learn.microsoft.com/en-us/defender-business/", 22 },
                   { "OpenVAS (via Greenbone Vulnerability Management)", "O OpenVAS realiza escaneamento automatizado de vulnerabilidades e categoriza isso por níveis de severidade (Crítico, Alto, Médio), atendendo ao requisito de identificação e classificação de riscos.", "https://www.cybrary.it/blog/vulnerability-assessment-using-openvas-first-scan", 26 },
                   { "Windows Server Update Services (WSUS)", "O WSUS permite aprovar, distribuir e monitorar patches de segurança em sistemas Windows, garantindo que as correções sejam aplicadas de forma centralizada e documentada, alinhada ao PCI DSS.", "https://learn.microsoft.com/en-us/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus", 27 },
                   { "Visual Studio com .NET Code Analysis", "Inclui regras de análise estática que identificam vulnerabilidades como injeção SQL e XSS durante o desenvolvimento, melhorando a segurança do código .NET.", "https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/security-warnings", 28 },
                   { "OWASP ZAP", "Scanner automático de aplicações web que testa contra falhas comuns (OWASP Top 10), prevenindo vulnerabilidades antes da implementação.", "https://www.zaproxy.org/docs/guides/zapping-the-top-10-2021/", 30 },
                   { "w3af", "Ferramenta open source com mais de 200 plugins para detectar ataques como SQLi, XSS e execução remota, garantindo proteção de aplicações web.", "https://github.com/andresriancho/w3af", 31 },
                   { "Active Directory com Role-Based Access Control (RBAC)", "Permite criar grupos de segurança no AD vinculados a funções específicas, garantindo que apenas usuários autorizados tenham acesso aos recursos necessários.", "https://infoaccesscontrol.com/top-strategies-for-windows-user-access-control-implementation/", 33 },
                   { "YubiKey com Yubico Login for Windows", "A solução utiliza dispositivos físicos (YubiKeys) como fator adicional à senha, integrando-se ao login do Windows. Isso adiciona o fator “algo que se tem”, reforçando a segurança dos acessos.", "https://support.yubico.com/hc/en-us/articles/360013708460-Yubico-Login-for-Windows-configuration-guide", 37 },
                   { "SolarWinds Security Event Manager (SEM)", "Oferece correlacionamento de logs, detecção de alterações (FIM) e armazenamento criptografado dos registros, atendendo aos requisitos de proteção e integridade dos dados de acesso.", "https://www.solarwinds.com/security-event-manager/use-cases/file-integrity-monitoring-software", 45 },
                   { "Belkasoft Evidence Center", "Ferramenta Windows de análise forense completa: captura de memória, disco, logs, timelines e geração de relatórios, adequada para investigações profundas.", "https://en.m.wikipedia.org/wiki/Belkasoft_Evidence_Center_X", 56 }
               });
       }


       /// <inheritdoc />
       protected override void Down(MigrationBuilder migrationBuilder)
       {
           migrationBuilder.DeleteData(
               table: "Softwares",
               keyColumn: "SubRequisitoId",
               keyValues: new object[]
               {
                   1, 2, 3, 4, 6, 7, 8, 9, 11, 12,
                   13, 14, 15, 16, 19, 20, 22, 26,
                   27, 28, 30, 31, 33, 37, 45, 56
               });
       }
   }
}


