namespace Domain.Entities
{
    public class Transacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public string? SubCategoria { get; set; }
        public decimal Valor { get; set; }
        public string? MeioPagamento { get; set; }
        public string? InstituicaoFinanceira { get; set; }
        public bool Parcelado { get; set; }
        public int NumeroParcelas { get; set; }
    }
}
