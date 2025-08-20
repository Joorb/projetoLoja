using Microsoft.AspNetCore.Mvc;

namespace projetoLoja.Repositorio
{
    public class Pedido : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
