using System;
using System.Windows.Input;
using Domain.Entities;
using Infrastructure.Services;

namespace UI.ViewModels
{
    public class NovaTransacaoViewModel : BaseViewModel
    {
        private readonly ITransacaoService _service;

        public NovaTransacaoViewModel(ITransacaoService service)
        {
            _service = service;
            Data = DateTime.Now;
            SalvarCommand = new RelayCommand(Salvar);
        }

        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public string? SubCategoria { get; set; }
        public decimal Valor { get; set; }
        public string? MeioPagamento { get; set; }
        public string? InstituicaoFinanceira { get; set; }
        public bool Parcelado { get; set; }
        public int NumeroParcelas { get; set; }

        public ICommand SalvarCommand { get; }

        private async void Salvar()
        {
            var transacao = new Transacao
            {
                Data = Data,
                Nome = Nome,
                Categoria = Categoria,
                SubCategoria = SubCategoria,
                Valor = Valor,
                MeioPagamento = MeioPagamento,
                InstituicaoFinanceira = InstituicaoFinanceira,
                Parcelado = Parcelado,
                NumeroParcelas = NumeroParcelas
            };
            await _service.AddAsync(transacao);
        }
    }
}
