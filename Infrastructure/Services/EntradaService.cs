using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services
{
    public class EntradaService : IEntradaService
    {
        private readonly AppDbContext _context;

        public EntradaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Entrada entrada)
        {
            _context.Entradas.Add(entrada);
            await _context.SaveChangesAsync();
        }
    }
}
