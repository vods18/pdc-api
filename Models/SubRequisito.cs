public class SubRequisito
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string? Descricao { get; set; }
    public bool Check { get; set; }
    public int RequisitoId { get; set; }
    public int? QuestionarioId { get; set; }
    
    public Requisito Requisito { get; set; } = null!;
    public Questionario? Questionario { get; set; }
    public Software? Software { get; set; }
}
