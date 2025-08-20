using Microsoft.AspNetCore.Mvc;

namespace projetoLoja.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
