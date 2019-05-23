using HominiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HominiMVC.ViewModel
{
    public class NewMunicipioViewModel
    {
        public IEnumerable<Departamento> Departamentos { get; set; }
        public Municipio Municipio { get; set; }
    }
}