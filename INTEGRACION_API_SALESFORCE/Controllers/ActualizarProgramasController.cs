using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Modelo.Integracion2;
using System.Reflection.Metadata.Ecma335;

namespace INTEGRACION_API_SALESFORCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActualizarProgramasController : ControllerBase
    {
        [HttpPut]
        public IActionResult Actualizar(ModeloIntegracion2 datosEntrada)
        { 
            return Ok(datosEntrada);
        }

    }
}
