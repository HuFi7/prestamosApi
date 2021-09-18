using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class estados_equipoController : ControllerBase
    {
        private readonly prestamosContext _contexto;

        public estados_equipoController(prestamosContext miContexto)
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/estados_equipo")]
        public IActionResult Get()
        {
            var estados_equipoList = _contexto.estados_equipo;
            //if (estados_equiposList.Count > 0)
            {
                return Ok(estados_equipoList);
            }
            //return NotFound();
        }
    }
}