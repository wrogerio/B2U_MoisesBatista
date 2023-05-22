using B2U.BLL.Interfaces;
using B2U.DAL.Domain;
using B2U.DAL.Interfaces;
using B2U.DAL.Shared;

namespace B2U.BLL.Services;

public class TransacaoService : ITransacaoService
{
    private readonly ITransacaoRepository _transacaoRepository;

    public TransacaoService(ITransacaoRepository transacaoRepository)
    {
        _transacaoRepository = transacaoRepository;
    }

    public async Task<IEnumerable<Transacao>> GetAll(Guid contaId, DateTime dtInicio)
    {
        return await _transacaoRepository.GetAllAsync(contaId, dtInicio);
    }

    public async Task<Transacao> GetbyId(Guid id)
    {
        return await _transacaoRepository.GetByIdAsync(id);
    }

    public async Task<bool> Create(Transacao transacao)
    {
        var result = transacao.ValidateTransacao();

        if (!result)
            return result;

        await _transacaoRepository.CreateAsync(transacao);
        return result;
    }

    public async Task<bool> Update(Transacao transacao)
    {
        var result = transacao.ValidateTransacao();

        if (!result)
            return result;

        await _transacaoRepository.UpdateAsync(transacao);
        return result;
    }

    public async Task<bool> Delete(Guid id)
    {
        return await _transacaoRepository.DeleteAsync(id);
    }
}