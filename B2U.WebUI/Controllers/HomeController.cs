using B2U.BLL.Interfaces;
using B2U.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace B2U.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly IContaService _contaService;

    public HomeController(IContaService contaService)
    {
        _contaService = contaService;
    }

    public async Task<IActionResult> Index()
    {
        var contas = await _contaService.GetAll();
        ViewBag.Contas = new SelectList(contas, "Id", "Nome");
        return View();
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}