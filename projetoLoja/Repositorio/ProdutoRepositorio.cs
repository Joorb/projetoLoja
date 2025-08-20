using Microsoft.AspNetCore.Mvc;

namespace projetoLoja.Repositorio
{
    public class ProdutoRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
