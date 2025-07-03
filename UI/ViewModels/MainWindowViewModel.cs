using System.Windows.Input;
using UI.Views;

namespace UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand NovaEntradaCommand { get; }
        public ICommand NovaSaidaCommand { get; }
        public ICommand NovaTransacaoCommand { get; }
        public ICommand FluxoMensalCommand { get; }
        public ICommand FluxoAnualCommand { get; }

        public MainWindowViewModel()
        {
            NovaEntradaCommand = new RelayCommand(OpenNovaEntrada);
            NovaSaidaCommand = new RelayCommand(OpenNovaSaida);
            NovaTransacaoCommand = new RelayCommand(OpenNovaTransacao);
            FluxoMensalCommand = new RelayCommand(OpenFluxoMensal);
            FluxoAnualCommand = new RelayCommand(OpenFluxoAnual);
        }

        private void OpenNovaEntrada() => new NovaEntradaWindow().Show();
        private void OpenNovaSaida() => new NovaSaidaWindow().Show();
        private void OpenNovaTransacao() => new NovaTransacaoWindow().Show();
        private void OpenFluxoMensal() => new FluxoMensalWindow().Show();
        private void OpenFluxoAnual() => new FluxoAnualWindow().Show();
    }
}
