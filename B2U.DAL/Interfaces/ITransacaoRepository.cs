using B2U.DAL.Domain;

namespace B2U.DAL.Interfaces;

public interface ITransacaoRepository
{
    public Task<IEnumerable<Transacao>> GetAllAsync(Guid idConta, DateTime dtInicio);
    public Task<Transacao> GetByIdAsync(Guid id);
    public Task<Transacao> CreateAsync(Transacao transacao);
    public Task<Transacao> UpdateAsync(Transacao transacao);
    public Task<bool> DeleteAsync(Guid id);
}
