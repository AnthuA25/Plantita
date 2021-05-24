using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace plantitas.Controllers
{
    public class ProductoController
    {
          private readonly ILogger<ProductoController> _logger;

   

        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}