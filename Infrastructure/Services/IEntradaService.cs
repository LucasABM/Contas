using Domain.Entities;

namespace Infrastructure.Services
{
    public interface IEntradaService
    {
        Task AddAsync(Entrada entrada);
    }
}
