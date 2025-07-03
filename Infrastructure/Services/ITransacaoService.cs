using Domain.Entities;

namespace Infrastructure.Services
{
    public interface ITransacaoService
    {
        Task AddAsync(Transacao transacao);
    }
}
