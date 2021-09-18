using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class tipo_equipoController : ControllerBase
    {
        private readonly prestamosContext _contexto;

        public tipo_equipoController(prestamosContext miContexto)
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/tipo_equipo")]
        public IActionResult Get()
        {
            var tipo_equipoList = _contexto.tipo_equipo;
            //if (tipo_equiposList.Count > 0)
            {
                return Ok(tipo_equipoList);
            }
            //return NotFound();
        }
    }
}