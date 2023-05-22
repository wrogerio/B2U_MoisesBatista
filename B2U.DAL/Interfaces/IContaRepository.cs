using B2U.DAL.Domain;

namespace B2U.DAL.Interfaces;

public interface IContaRepository
{
    public Task<IEnumerable<Conta>> GetAllAsync();
    public Task<Conta> GetById(Guid id);
}
