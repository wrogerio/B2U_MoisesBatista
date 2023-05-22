using B2U.DAL.Context;
using B2U.DAL.Domain;
using B2U.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B2U.DAL.Repositories;

public class ContaRepository : IContaRepository
{
    private readonly B2UContext _context;

    public ContaRepository(B2UContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Conta>> GetAllAsync()
    {
        return await _context.Conta.AsNoTracking().ToListAsync();
    }

    public async Task<Conta> GetById(Guid id)
    {
        return await _context.Conta.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
    }
}