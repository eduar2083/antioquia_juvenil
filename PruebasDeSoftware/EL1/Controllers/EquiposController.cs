using EL1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EL1.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EquipoVM vm)
        {
            if (vm.Fecha <= DateTime.Today)
            {
                ModelState.AddModelError("Fecha", "Debe ingresar una fecha válida");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Success));
            }

            return View(vm);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}