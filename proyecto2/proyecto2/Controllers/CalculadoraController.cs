using proyecto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace proyecto2.Controllers
{
    public class CalculadoraController : ApiController
    {
        private HistorialDbContext db = new HistorialDbContext();


        [HttpGet]
        [Route("api/historial/todas")]
        public IEnumerable<CalculadoraResultado> ObtenerOperaciones()
        {
            return db.Database.SqlQuery<CalculadoraResultado>(
                "EXEC sp_MostrarTodasOperaciones"
                ).ToList();
        }

        [HttpGet]
        [Route("api/historial/sumas")]
        public IEnumerable<CalculadoraResultado> ObtenerSumas()
        {
            return db.Database.SqlQuery<CalculadoraResultado>(
                "EXEC sp_MostrarOperacionesPorTipo @p0", "+").ToList();
        }

        [HttpGet]
        [Route("api/historial/restas")]
        public IEnumerable<CalculadoraResultado> ObtenerRestas()
        {
            return db.Database.SqlQuery<CalculadoraResultado>(
                "EXEC sp_MostrarOperacionesPorTipo @p0", "-").ToList();
        }

        [HttpGet]
        [Route("api/historial/multiplicaciones")]
        public IEnumerable<CalculadoraResultado> ObtenerMultiplicaciones()
        {
            return db.Database.SqlQuery<CalculadoraResultado>(
                "EXEC sp_MostrarOperacionesPorTipo @p0", "*").ToList();
        }

        [HttpGet]
        [Route("api/historial/divisiones")]
        public IEnumerable<CalculadoraResultado> ObtenerDivisiones()
        {
            return db.Database.SqlQuery<CalculadoraResultado>(
                "EXEC sp_MostrarOperacionesPorTipo @p0", "/").ToList();
        }

    }

}

