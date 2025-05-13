public class RegrasOcultacao
{
    public int Id { get; set; }
    public string RespostaGatilho { get; set; } = "";

    public int PerguntaGatilhoId { get; set; }
    public Questionario? PerguntaGatilho { get; set; }

    public int PerguntaAlvoId { get; set; }
    public Questionario? PerguntaAlvo { get; set; }
}