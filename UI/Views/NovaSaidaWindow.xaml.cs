using System;
using System.Windows;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UI.ViewModels;

namespace UI.Views
{
    public partial class NovaSaidaWindow : Window
    {
        public NovaSaidaWindow()
        {
            InitializeComponent();
            DataContext = CreateViewModel();
        }

        private static NovaSaidaViewModel CreateViewModel()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(connectionString, serverVersion)
                .Options;
            var context = new AppDbContext(options);
            var service = new SaidaService(context);
            return new NovaSaidaViewModel(service);
        }
    }
}
