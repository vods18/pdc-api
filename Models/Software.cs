public class Software
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";

    public int SubRequisitoId { get; set; }
    public SubRequisito? SubRequisito { get; set; }
}