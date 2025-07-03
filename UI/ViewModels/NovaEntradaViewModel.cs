using System;
using System.Windows.Input;
using Domain.Entities;
using Infrastructure.Services;

namespace UI.ViewModels
{
    public class NovaEntradaViewModel : BaseViewModel
    {
        private readonly IEntradaService _service;

        public NovaEntradaViewModel(IEntradaService service)
        {
            _service = service;
            DataRecebimento = DateTime.Now;
            SalvarCommand = new RelayCommand(Salvar);
        }

        public string? TipoEntrada { get; set; }
        public DateTime DataRecebimento { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }

        public ICommand SalvarCommand { get; }

        private async void Salvar()
        {
            var entrada = new Entrada
            {
                TipoEntrada = TipoEntrada,
                DataRecebimento = DataRecebimento,
                Valor = Valor,
                CategoriaId = CategoriaId
            };
            await _service.AddAsync(entrada);
        }
    }
}
