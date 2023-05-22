using B2U.DAL.Domain;

namespace B2U.BLL.Interfaces;

public interface IContaService
{
    public Task<IEnumerable<Conta>> GetAll();
    public Task<Conta> GetbyId(Guid id);
}
