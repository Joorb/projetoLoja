using Microsoft.AspNetCore.Mvc;

namespace projetoLoja.Repositorio
{
    public class PedidoRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
