using Helper.Contrato;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Modelo.Integracion2;
using Negocio.Integracion2;
using System.Reflection.Metadata.Ecma335;

namespace INTEGRACION_API_SALESFORCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActualizarProgramasController : ControllerBase
    {
        private readonly IRestHelper _restHelper;
        private readonly NegocioIntegracion2 _integracion2 = null;
        public ActualizarProgramasController(IRestHelper restHelper)
        {
            _restHelper= restHelper;
            _integracion2 = new NegocioIntegracion2(_restHelper);
        }

        [HttpPut]
        public IActionResult Actualizar(ModeloIntegracion2 datosEntrada)
        {
            _integracion2.Ejecutar("");
            return Ok(datosEntrada);
        }

    }
}
