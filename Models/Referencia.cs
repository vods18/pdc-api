public class Referencia
{
    public int Id { get; set; }
    public string Texto { get; set; } = "";

    public int SubRequisitoId { get; set; }
    public SubRequisito? SubRequisito { get; set; }
}