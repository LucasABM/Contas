using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Entrada> Entradas => Set<Entrada>();
        public DbSet<Saida> Saidas => Set<Saida>();
        public DbSet<Transacao> Transacoes => Set<Transacao>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<InstituicaoFinanceira> InstituicoesFinanceiras => Set<InstituicaoFinanceira>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
