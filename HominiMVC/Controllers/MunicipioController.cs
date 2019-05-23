using HominiMVC.DAL;
using HominiMVC.Models;
using HominiMVC.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace HominiMVC.Controllers
{
    public class MunicipioController : Controller
    {
        private POCContext _context;

        public MunicipioController()
        {
            _context = new POCContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var municipios = _context.Municipios.Include(m => m.Departamento).ToList();

            return View(municipios);
        }

        public ActionResult New()
        {
            var departamentos = _context.Departamentos.ToList();
            var viewModel = new NewMunicipioViewModel
            {
                Departamentos = departamentos
            };

            return View(viewModel);
        }

        public ActionResult Create(Municipio municipio)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMunicipioViewModel
                {
                    Municipio = municipio,
                    Departamentos = _context.Departamentos.ToList()
                };

                return View("New", viewModel);
            }

            _context.Municipios.Add(municipio);
            _context.SaveChanges();

            return RedirectToAction("Index", "Municipio");
        }
    }
}