public class TermoTecnico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
        public int GuiaRequisitoId { get; set; }
        public GuiaRequisito GuiaRequisito { get; set; } = null!;
    }