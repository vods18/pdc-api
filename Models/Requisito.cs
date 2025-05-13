public class Requisito
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";

    public List<SubRequisito> SubRequisitos { get; set; } = [];
}