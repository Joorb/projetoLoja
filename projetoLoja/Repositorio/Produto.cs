using Microsoft.AspNetCore.Mvc;

namespace projetoLoja.Repositorio
{
    public class Produto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
