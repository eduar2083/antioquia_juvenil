using System;
using System.ComponentModel.DataAnnotations;

namespace EL1.ViewModels
{
    public class EquipoVM
    {
        [Required(ErrorMessage = "El campo \'{0}\' es requerido")]
        [StringLength(maximumLength: 6, MinimumLength =6, ErrorMessage = "\"{0}\" debe tener {2} caracteres.")]
        [RegularExpression(pattern: "^PR[0-9]{4}$", ErrorMessage ="Ingrese un código válido")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El campo \'{0}\' es requerido")]
        //[MinLength(4, ErrorMessage = "\"{0}\" debe tener cómo mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "\"{0}\" debe tener cómo máximo {1} caracteres.")]
        [RegularExpression(pattern: "(.*[a-zA-Z]){4}.*", ErrorMessage = "Recuerde que el nombre del equipo debe contener al menos 4 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo \'{0}\' es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }
    }
}
