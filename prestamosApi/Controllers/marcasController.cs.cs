using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using prestamosApi.Models;

namespace prestamosApi.Controllers
{
    [ApiController]
    public class marcasController : ControllerBase
    {
        private readonly prestamosContext _contexto;

        public marcasController(prestamosContext miContexto)
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/marcas")]
        public IActionResult Get()
        {
            var marcasList = _contexto.marcas;
            //if (marcasList.Count > 0)
            {
                return Ok(marcasList);
            }
            //return NotFound();
        }
    }
}