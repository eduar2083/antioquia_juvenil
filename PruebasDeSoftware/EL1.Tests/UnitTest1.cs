using EL1.Controllers;
using EL1.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EL1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private EquipoVM vm;

        [TestInitialize]
        public void Startup()
        {
            //vm = new EquipoVM();
        }

        [TestMethod]
        public void Test_Fecha_No_Valida()
        {
            // Arrange
            var contoller = new EquiposController();
            vm = new EquipoVM();
            vm.Codigo = "PR1234";
            vm.Nombre = "EQUIPO 01";
            vm.Fecha = DateTime.Today;  // Fecha no puede ser actual, debe ser posterior

            // Act
            contoller.Create(vm);
            var resultado = contoller.ModelState["Fecha"].Errors[0].ErrorMessage;

            // Assert
            Assert.AreEqual(resultado, "Debe ingresar una fecha válida");

        }

        [TestMethod]
        public void Test_Datos_Correctos()
        {
            // Arrange
            var contoller = new EquiposController();
            vm = new EquipoVM();
            vm.Codigo = "PR1234";
            vm.Nombre = "EQUIPO 01";
            vm.Fecha = DateTime.Today.AddDays(1);

            // Act
            contoller.Create(vm);
            var resultado = contoller.ModelState.ErrorCount;

            // Assert
            Assert.AreEqual(resultado, 0);

        }
    }
}
