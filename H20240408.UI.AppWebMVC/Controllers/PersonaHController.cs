using H20240408.LogicaDeNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace H20240408.UI.AppWebMVC.Controllers
{
    public class PersonaHController : Controller
    {
        readonly PersonaHBL _personaHBL;
        public PersonaHController(PersonaHBL personaABL)
        {
            _personaHBL = personaABL;
        }
        // GET: PersonaAController
        public async Task<ActionResult> Index(PersonaH personaH)
        {
            var personasA = await _personaHBL.Buscar(personaH);
            return View(personasA);
        }

        // GET: PersonaAController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personasA = await _personaHBL.ObtenerPorId(new PersonaH { Id = id });
            return View(personasA);
        }

        // GET: PersonaAController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaAController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaH personaH)
        {
            try
            {
                await _personaHBL.Crear(personaH);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaAController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var personasA = await _personaHBL.ObtenerPorId(new PersonaH { Id = id });
            return View(personasA);
        }

        // POST: PersonaAController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaH personaH)
        {
            try
            {
                await _personaHBL.Modificar(personaH);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaAController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var personasA = await _personaHBL.ObtenerPorId(new PersonaH { Id = id });
            return View(personasA);
        }

        // POST: PersonaAController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaH personaH)
        {
            try
            {
                await _personaHBL.Eliminar(personaH);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
