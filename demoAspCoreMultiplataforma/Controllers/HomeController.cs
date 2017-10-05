using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoAspCoreMultiplataforma.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //rest petición
        // POST api/values
        [HttpPost]
        [Route("api/demo")]
        public object demo([FromBody] demoClass d)
        {
            d.valor1 = "Valor de retorno: " + d.valor1;
            d.valor2 = "Valor de retorno: " + d.valor2;
            return d;
        }
        public class demoClass
        {
            public string valor1;
            public string valor2;

        }
    }
}
