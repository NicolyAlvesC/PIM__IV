
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace THE_PIM.Controllers
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        // Adicione esta nova a��o para a p�gina Fornecedores
        public IActionResult Fornecedores()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        
    }
}