using B2U.DAL.Domain;

namespace B2U.BLL.Interfaces;

public interface ITransacaoService
{
    public Task<IEnumerable<Transacao>> GetAll(Guid contaId, DateTime dtInicio);
    public Task<Transacao> GetbyId(Guid id);
    public Task<bool> Create(Transacao transacao);
    public Task<bool> Update(Transacao transacao);
    public Task<bool> Delete(Guid id);
}
