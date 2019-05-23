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

        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Nombre Departamento")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Solo caracteres del alfabeto")]
        public string NombreDepartamento { get; set; }

        [Required(ErrorMessage = "Código es requerido")]
        [StringLength(2, ErrorMessage = "Máximo 2 dígitos")]
        [MinLength(2, ErrorMessage = "Codigo Departamento debe ser de 2 números")]
        [Display(Name = "Código Departamento")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Codigo Departamento debe ser numérico")]
        public string CodigoDepartamento { get; set; }
    }
}