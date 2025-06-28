public class TermosTecnicos
{
    public int Id { get; set; }
    public string Texto { get; set; } = string.Empty;
    public int GuiaRequisitoId { get; set; }
    public GuiaRequisitos GuiaRequisitos { get; set; } = null!;
}