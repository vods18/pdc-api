using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pdc_api.Migrations
{
    public partial class SeedGuiaRequisito8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 8.1 – Gerenciar IDs de usuário e administradores
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    36,
                    'Gerenciar os identificadores de usuário significa atribuir um ID exclusivo a cada indivíduo que tenha acesso aos sistemas, evitando o uso de contas genéricas. Esse controle garante a rastreabilidade de ações realizadas em ambientes críticos, além de permitir a revogação rápida de acessos quando necessário.',
                    'Esse cuidado é essencial para evitar acessos não autorizados após desligamentos, mudanças de função ou violações. IDs exclusivos associados a permissões específicas também auxiliam no princípio do menor privilégio, evitando que usuários tenham acessos desnecessários.',
                    'Um colaborador deixa a empresa, mas sua conta de acesso continua ativa. Como era uma conta genérica usada por mais pessoas, não é possível rastrear quem fez alterações indevidas em configurações do banco de dados após sua saída. Com IDs individuais, a auditoria seria viável e o acesso poderia ter sido revogado imediatamente.',
                    36
                );
            ");

            // 8.2 – Usar autenticação segura
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    37,
                    'A autenticação segura exige que o usuário prove sua identidade por meio de um ou mais fatores: algo que ele sabe (senha), algo que possui (token, smartcard), ou algo que é (biometria). Essa abordagem reduz as chances de acesso não autorizado em caso de comprometimento de senhas.',
                    'A prática se baseia em uma estrutura de autenticação conhecida como MFA (Multi-Factor Authentication), que acrescenta uma camada adicional de verificação, dificultando o uso de credenciais obtidas indevidamente.',
                    'Um invasor obtém a senha de um funcionário por meio de um ataque de phishing. No entanto, como o sistema exige um código temporário gerado por um aplicativo autenticador ou smartcard, a tentativa de invasão falha, pois o segundo fator não está disponível ao atacante.',
                    37
                );
            ");

            // 8.3 – Usar autenticação multifator para acesso remoto ou privilegiado
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    38,
                    'Este sub-requisito reforça que qualquer acesso remoto ou a funções com alto nível de privilégio deve, obrigatoriamente, adotar autenticação multi-fator. O objetivo é dificultar acessos indevidos mesmo quando senhas ou credenciais forem comprometidas.',
                    'Ambientes privilegiados são alvos frequentes de atacantes, pois concentram poder administrativo. Reforçar seu acesso com múltiplos fatores protege contra ataques como roubo de senhas, phishing e reutilização de credenciais.',
                    'Um administrador acessa o painel do servidor por meio de VPN. Mesmo com usuário e senha válidos, o sistema solicita autenticação adicional por aplicativo autenticador, protegendo a rede contra invasões externas.',
                    38
                );
            ");

            // 8.4 – Documentar políticas de autenticação
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    39,
                    'É fundamental que a organização documente suas regras relacionadas à autenticação, como complexidade de senhas, bloqueio de contas, tempo de sessão e uso de autenticação multi-fator. Essa documentação deve ser formal, atualizada e de conhecimento de todos os envolvidos.',
                    'Ao formalizar as políticas de autenticação, a empresa garante consistência nos controles, evita decisões improvisadas e reforça a cultura de segurança.',
                    'Um sistema não implementa bloqueio automático após tentativas de senha incorreta. Um invasor realiza ataque de força bruta e descobre a senha de um usuário. Com políticas bem definidas e aplicadas, essa brecha teria sido evitada.',
                    39
                );
            ");

            // 8.5 – Não usar IDs compartilhados ou genéricos
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    40,
                    'O uso de contas compartilhadas deve ser evitado, pois impede a rastreabilidade das ações realizadas em sistemas. Cada usuário deve ser responsabilizado por seu acesso, sendo possível auditar ações de forma individual.',
                    'IDs genéricos são especialmente perigosos em funções administrativas, pois dificultam a identificação de quem alterou configurações ou acessou dados críticos.',
                    'Uma equipe de suporte usa o mesmo login para acessar o painel de administração. Após uma alteração crítica, não se sabe quem executou a ação. Com contas individuais, seria possível atribuir a responsabilidade com precisão.',
                    40
                );
            ");

            // 8.6 – Associar tokens, smartcards e certificados a contas individuais
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    41,
                    'Quando a organização adota mecanismos como tokens físicos, smartcards ou certificados digitais, esses recursos devem estar vinculados a um único usuário, garantindo que seu uso seja individualizado e rastreável.',
                    'Essa prática garante que o controle de acesso continue funcionando mesmo em ambientes com autenticação mais avançada, evitando compartilhamento indevido desses recursos.',
                    'Dois usuários compartilham um certificado digital para assinar transações. Em caso de fraude, não é possível identificar o autor. Se cada certificado estivesse associado a uma conta única, a auditoria seria clara.',
                    41
                );
            ");

            // 8.7 – Garantir que políticas e procedimentos estejam documentados e em uso
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    42,
                    'Para assegurar a eficácia dos controles de identificação e autenticação, é essencial que todas as políticas e procedimentos relacionados estejam devidamente formalizados, acessíveis e em vigor. Isso inclui diretrizes sobre criação e gerenciamento de usuários, requisitos de autenticação segura, uso de multi-factor authentication e o controle de acessos privilegiados.',
                    'Documentar esse processo reduz o risco de erro humano e garante que práticas seguras sejam mantidas ao longo do tempo.',
                    'Uma empresa estabelece procedimentos detalhados sobre como provisionar novas contas de administrador com multi-factor authentication e sobre como revisar periodicamente essas permissões.',
                    42
                );
            ");

            // 8.8 – Restringir acesso a bancos de dados a administradores e via métodos programáticos
            migrationBuilder.Sql(@"
                INSERT INTO GuiaRequisitos (Id, Significado, Importancia, Exemplo, SubRequisitoId)
                VALUES (
                    43,
                    'Este controle determina que o acesso direto a bancos de dados deve ser restrito, preferencialmente permitido apenas a administradores autorizados ou por meio de aplicações com controle programático.',
                    'Limitar acessos diretos minimiza o risco de exposição de dados sensíveis e garante que interações com o banco de dados sejam validadas, auditadas e controladas por camadas intermediárias.',
                    'Um analista conecta-se diretamente ao banco de dados via interface gráfica para executar uma consulta, sem criptografia ou autenticação robusta. Essa prática representa risco elevado. Usar APIs seguras e acessos via backend reduz drasticamente esse tipo de exposição.',
                    58
                );
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GuiaRequisitos WHERE Id IN (36,37,38,39,40,41,42,43);");
        }
    }
}
