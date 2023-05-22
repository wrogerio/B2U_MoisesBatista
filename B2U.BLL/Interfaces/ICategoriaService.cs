using B2U.DAL.Domain;

namespace B2U.BLL.Interfaces;

public interface ICategoriaService
{
    public Task<IEnumerable<Categoria>> GetAll();
    public Task<Categoria> GetbyId(Guid id);
}
