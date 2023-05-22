using B2U.DAL.Context;
using B2U.DAL.Domain;
using B2U.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B2U.DAL.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly B2UContext _context;

    public CategoriaRepository(B2UContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Categoria>> GetAllAsync()
    {
        return await _context.Categoria.AsNoTracking().ToListAsync();
    }

    public async Task<Categoria> GetById(Guid id)
    {
        return await _context.Categoria.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
    }
}