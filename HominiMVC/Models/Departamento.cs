using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HominiMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Departamento")]
        public string NombreDepartamento { get; set; }

        [Required]
        [StringLength(2)]
        [MinLength(2)]
        [Display(Name = "Código Departamento")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "CodigoDepartamento debe ser numérico")]
        public string CodigoDepartamento { get; set; }
    }
}