using B2U.DAL.Context;
using B2U.DAL.Domain;
using B2U.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B2U.DAL.Repositories;

public class TransacaoRepository : ITransacaoRepository
{
    private readonly B2UContext _context;

    public TransacaoRepository(B2UContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Transacao>> GetAllAsync(Guid idConta, DateTime dtInicio)
    {
        return await _context
            .Transacao
            .AsNoTracking()
            .Include(x => x.Categoria)
            .AsNoTracking()
            .Include(x => x.Conta)
            .AsNoTracking()
            .OrderBy(x => x.Data)
            .Where(x => x.Conta.Id == idConta && x.Data >= dtInicio)
            .ToListAsync();
    }


    public async Task<Transacao> GetByIdAsync(Guid id)
    {
        return await _context
           .Transacao
           .AsNoTracking()
           .Include(x => x.Conta)
           .AsNoTracking()
           .Include(x => x.Categoria)
           .AsNoTracking()
           .FirstOrDefaultAsync(x => x.Id.Equals(id));
    }

    public async Task<Transacao> CreateAsync(Transacao transacao)
    {
        _context.Transacao.Add(transacao);
        await _context.SaveChangesAsync();
        return transacao;
    }

    public async Task<Transacao> UpdateAsync(Transacao transacao)
    {
        var entityEdit = await GetByIdAsync(transacao.Id);

        if (entityEdit == null)
            throw new Exception("Falha ao localizar a transação informada.");

        _context.Entry(entityEdit).CurrentValues.SetValues(transacao);
        await _context.SaveChangesAsync();
        return transacao;
    }


    public async Task<bool> DeleteAsync(Guid id)
    {
        var entityRemove = await GetByIdAsync(id);

        if (entityRemove == null)
            return false;

        _context.Transacao.Remove(entityRemove);
        await _context.SaveChangesAsync();

        return true;
    }
}