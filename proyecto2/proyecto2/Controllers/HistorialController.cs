using proyecto2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace proyecto2.Controllers
{
    public class HistorialController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Todas()
        {
            var datos = await Consumir("api/historial/todas");
            ViewBag.Operaciones = datos;
            ViewBag.Titulo = "Todas las Operaciones";
            return View("Index");
        }

        public async Task<ActionResult> Sumas()
        {
            var datos = await Consumir("api/historial/sumas");
            ViewBag.Operaciones = datos;
            ViewBag.Titulo = "Sumas";
            return View("Index");
        }

        public async Task<ActionResult> Restas()
        {
            var datos = await Consumir("api/historial/restas");
            ViewBag.Operaciones = datos;
            ViewBag.Titulo = "Restas";
            return View("Index");
        }

        public async Task<ActionResult> Multiplicaciones()
        {
            var datos = await Consumir("api/historial/multiplicaciones");
            ViewBag.Operaciones = datos;
            ViewBag.Titulo = "Multiplicaciones";
            return View("Index");
        }

        public async Task<ActionResult> Divisiones()
        {
            var datos = await Consumir("api/historial/divisiones");
            ViewBag.Operaciones = datos;
            ViewBag.Titulo = "Divisiones";
            return View("Index");
        }

        private async Task<List<CalculadoraResultado>> Consumir(string endpoint)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("https://localhost:44321/");
                var response = await client.GetAsync(endpoint);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CalculadoraResultado>>(json);
            }
        }
    }
}