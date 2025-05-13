public class Questionario
{
    public int Id { get; set; }
    public string Pergunta { get; set; } = "";
    public string? Resposta { get; set; }
    public bool Visivel { get; set; }

    public List<SubRequisito> SubRequisitos { get; set; } = [];
    public List<RegrasOcultacao> RegrasOcultacaoGatilho { get; set; } = [];
    public List<RegrasOcultacao> RegrasOcultacaoAlvo { get; set; } = [];
}