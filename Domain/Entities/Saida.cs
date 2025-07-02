namespace Domain.Entities
{
    public class Saida
    {
        public int Id { get; set; }
        public string? Categoria { get; set; }
        public string? Nome { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int Parcelas { get; set; }
    }
}
