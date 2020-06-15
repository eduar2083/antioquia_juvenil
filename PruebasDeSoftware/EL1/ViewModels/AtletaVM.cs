using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModels
{
    public class AtletaVM
    {
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [Display(Name ="Sexo")]
        public char Sexo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Estatura (metros)")]
        public float Estatura { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Peso (kg)")]
        public float Peso { get; set; }
    }
}
