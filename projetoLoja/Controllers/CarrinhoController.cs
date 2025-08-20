using Microsoft.AspNetCore.Mvc;

namespace projetoLoja.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
