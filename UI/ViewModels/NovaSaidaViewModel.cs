using System;
using System.Windows.Input;
using Domain.Entities;
using Infrastructure.Services;

namespace UI.ViewModels
{
    public class NovaSaidaViewModel : BaseViewModel
    {
        private readonly ISaidaService _service;

        public NovaSaidaViewModel(ISaidaService service)
        {
            _service = service;
            Data = DateTime.Now;
            SalvarCommand = new RelayCommand(Salvar);
        }

        public string? Categoria { get; set; }
        public string? Nome { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int Parcelas { get; set; }

        public ICommand SalvarCommand { get; }

        private async void Salvar()
        {
            var saida = new Saida
            {
                Categoria = Categoria,
                Nome = Nome,
                Data = Data,
                Valor = Valor,
                Parcelas = Parcelas
            };
            await _service.AddAsync(saida);
        }
    }
}
