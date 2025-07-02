namespace Domain.Entities
{
    public class Entrada
    {
        public int Id { get; set; }
        public string? TipoEntrada { get; set; }
        public DateTime DataRecebimento { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
