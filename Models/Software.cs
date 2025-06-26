public class Software
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Justificativa { get; set; } = string.Empty;
    public string Fonte { get; set; } = string.Empty;

    public int SubRequisitoId { get; set; }
    public SubRequisito SubRequisito { get; set; } = null!;
}
