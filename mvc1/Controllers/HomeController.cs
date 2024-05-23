using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc1.Models;

namespace mvc1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorio _repositorio;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private string _message;

    public HomeController(ILogger<HomeController> logger, IRepositorio repositorio, IHttpContextAccessor httpContextAccessor)
    {
        _logger = logger;
        _repositorio = repositorio;
        _httpContextAccessor = httpContextAccessor;
        var hostname = _httpContextAccessor.HttpContext.Request.Host.Value;
        _message = $"Docker - {hostname}";
    }

    public IActionResult Index()
    {
        ViewBag.Message = _message;
        return View(_repositorio.Produtos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
