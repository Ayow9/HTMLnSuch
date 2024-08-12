using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZeldaMonsters.Models;
using ZeldaMonsters.Services;

namespace ZeldaMonsters.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly InterZelda_db _Zelda_dbService;

    public HomeController(ILogger<HomeController> logger, InterZelda_db ZeldadbService)
    {
        _logger = logger;
        _Zelda_dbService = ZeldadbService;
    }

    //step 5 VV
    [HttpPost]
    //call our API and whatever we get, this is the action to do it!
    public async Task<IActionResult> Search(string monsterName)
    {
        var result = await _Zelda_dbService.SearchMonster(monsterName);
        return View(result);
    }

    public IActionResult Index()
    {
        return View();
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
