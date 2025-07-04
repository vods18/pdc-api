public class GuiaRequisito
    {
        public int Id { get; set; }
        public string Significado { get; set; } = string.Empty;
        public string? Importancia { get; set; }
        public string? Exemplo { get; set; }
        public int SubRequisitoId { get; set; }
        public SubRequisito SubRequisito { get; set; } = null!;
        public ICollection<TermoTecnico> TermosTecnicos { get; set; } = new List<TermoTecnico>();
    }