using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly AppDbContext _context;

        public TransacaoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Transacao transacao)
        {
            _context.Transacoes.Add(transacao);
            await _context.SaveChangesAsync();
        }
    }
}
