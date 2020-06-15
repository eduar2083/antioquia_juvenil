using App.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace App.Web.Controllers
{
    public class AtletasController : Controller
    {
        public IActionResult Create()
        {
            var lista = new[]
            {
                new { Codigo = "M", Nombre = "Masculino" },
                new { Codigo = "F", Nombre = "Femenino" }
            }.ToList();

            ViewData["Sexos"] = new SelectList(lista, "Codigo", "Nombre");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AtletaVM vm)
        {
            
            if (ModelState.IsValid)
            {
                bool resultado;

                if (vm.Sexo == 'M')
                {
                    resultado = vm.Edad >= 18 && vm.Estatura > 1.70 && vm.Peso < 70;
                }
                else
                {
                    resultado = vm.Edad > 16 && vm.Estatura >= 1.70 && vm.Peso <= 60;
                }

                return RedirectToAction(nameof(Restultado), routeValues: new { resultado });
            }

            return View(vm);
        }

        public IActionResult Restultado(bool resultado)
        {
            return View(resultado);
        }
    }
}
