using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services
{
    public class SaidaService : ISaidaService
    {
        private readonly AppDbContext _context;

        public SaidaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Saida saida)
        {
            _context.Saidas.Add(saida);
            await _context.SaveChangesAsync();
        }
    }
}
