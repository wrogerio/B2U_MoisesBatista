using B2U.BLL.Interfaces;
using B2U.DAL.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace B2U.WebUI.Controllers;

public class TransacoesController : Controller
{
    private readonly ITransacaoService _transacaoService;
    private readonly IContaService _contaService;
    private readonly ICategoriaService _categoriaService;

    public TransacoesController(ITransacaoService transacaoService, IContaService contaService, ICategoriaService categoriaService)
    {
        _transacaoService = transacaoService;
        _contaService = contaService;
        _categoriaService = categoriaService;
    }

    public async Task<IActionResult> Index(Guid contaid, DateTime? dtInicio)
    {
        // Caso não seja informada uma data, exibiremos os últimos 30 dias.
        ViewBag.UltimosTrintaDias = dtInicio == null ? "Visualizando os últimos 30 dias" : "";
        DateTime dataInicial = dtInicio ?? DateTime.Now.AddMonths(-1);

        // Caso não informe o id da conta, retorna para a action Index da página Home
        if (contaid == Guid.Empty)
            return RedirectToAction("Index", "Home");

        ViewBag.DataExtrato = dataInicial.ToString("dd/MM/yyyy");

        var transacoes = await _transacaoService.GetAll(contaid, dataInicial);
        ViewBag.SaldoTotal = transacoes.Select(x => x.Credito).Sum() - transacoes.Select(x => x.Debito).Sum();
        return View(transacoes);
    }

    public async Task<IActionResult> Create()
    {
        var categorias = await _categoriaService.GetAll();
        var categoriasList = new SelectList(categorias, "Id", "Nome");
        ViewBag.Categorias = categoriasList;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Transacao transacao)
    {
        if (!ModelState.IsValid)
        {
            var categorias = await _categoriaService.GetAll();
            var categoriasList = new SelectList(categorias, "Id", "Nome", transacao.CategoriaId);
            ViewBag.Categorias = categoriasList;
            return View(transacao);
        }

        await _transacaoService.Create(transacao);

        return RedirectToAction("Index", "Transacoes", new { contaId = transacao.ContaId });
    }

    [HttpPost]
    public JsonResult GetDetalhesConta(Guid contaId)
    {
        var contaSelecionada = _contaService.GetbyId(contaId).Result;
        return Json(contaSelecionada);
    }
}