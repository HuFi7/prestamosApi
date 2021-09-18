using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly prestamosContext _contexto;

        public equiposController(prestamosContext miContexto)
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get()
        {
            var equiposList = _contexto.equipos;
            //if (equiposList.Count > 0)
            {
                return Ok(equiposList);
            }
            //return NotFound();
        }
    }
}