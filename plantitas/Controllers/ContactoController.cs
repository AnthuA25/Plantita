using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace plantitas.Controllers
{
    public class ContactoController :Controller
    {
        private readonly ILogger<ContactoController> _logger;

   

        public IActionResult Index()
        {
            return View();
        }
    }
}