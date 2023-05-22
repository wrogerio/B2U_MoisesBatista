using B2U.DAL.Domain;

namespace B2U.DAL.Interfaces;

public interface ICategoriaRepository
{
    public Task<IEnumerable<Categoria>> GetAllAsync();
    public Task<Categoria> GetById(Guid id);
}
