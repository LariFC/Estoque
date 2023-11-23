using Microsoft.AspNetCore.Mvc;

namespace RelacionamentoHeranca.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
