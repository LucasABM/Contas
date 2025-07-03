using Domain.Entities;

namespace Infrastructure.Services
{
    public interface ISaidaService
    {
        Task AddAsync(Saida saida);
    }
}
