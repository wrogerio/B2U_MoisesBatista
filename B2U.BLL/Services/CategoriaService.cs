using B2U.BLL.Interfaces;
using B2U.DAL.Domain;
using B2U.DAL.Interfaces;

namespace B2U.BLL.Services;

public class CategoriaService : ICategoriaService
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaService(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<IEnumerable<Categoria>> GetAll()
    {
        return await _categoriaRepository.GetAllAsync();
    }

    public async Task<Categoria> GetbyId(Guid id)
    {
        return await _categoriaRepository.GetById(id);
    }
}