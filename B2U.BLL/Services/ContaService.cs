using B2U.BLL.Interfaces;
using B2U.DAL.Domain;
using B2U.DAL.Interfaces;

namespace B2U.BLL.Services;

public class ContaService : IContaService
{
    private readonly IContaRepository _contaRepository;

    public ContaService(IContaRepository contaRepository)
    {
        _contaRepository = contaRepository;
    }

    public async Task<IEnumerable<Conta>> GetAll()
    {
        return await _contaRepository.GetAllAsync();
    }

    public async Task<Conta> GetbyId(Guid id)
    {
        return await _contaRepository.GetById(id);
    }
}