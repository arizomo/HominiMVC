using System.ComponentModel.DataAnnotations;

namespace HominiMVC.Models
{
    public class Municipio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Nombre Municipio")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Solo caracteres del alfabeto")]
        public string NombreMunicipio { get; set; }

        [Required(ErrorMessage = "Código es requerido")]
        [StringLength(3, ErrorMessage = "Máximo 3 dígitos")]
        [MinLength(3, ErrorMessage = "Codigo Municipio debe ser de 3 números")]
        [Display(Name = "Código Municipio")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Codigo Departamento debe ser numérico")]
        public string CodigoMunicipio { get; set; }

        public Departamento Departamento { get; set; }
        public int  DepartamentoId { get; set; }
    }
}