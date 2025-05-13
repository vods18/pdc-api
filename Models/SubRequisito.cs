public class SubRequisito
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string? Descricao { get; set; }
    public bool Check { get; set; }

    public int RequisitoId { get; set; }
    public Requisito? Requisito { get; set; }

    public int QuestionarioId { get; set; }
    public Questionario? Questionario { get; set; }

    public List<Referencia> Referencias { get; set; } = [];
    public List<Software> Softwares { get; set; } = [];
}