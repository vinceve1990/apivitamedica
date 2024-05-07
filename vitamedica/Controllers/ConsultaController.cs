using Microsoft.AspNetCore.Mvc;
using vitamedica.Models;
using vitamedica.Models.ConexionBD;

namespace vitamedica.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConsultaController : ControllerBase {
        public readonly VitamedicaContext VitamedicaContext;
        private object jsonResp;
        private ILogger logger = VitamedicaUtils.Logger;

        public ConsultaController(VitamedicaContext context) {
            VitamedicaContext = context;
        }

        [HttpGet]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<JsonResult> consultaReceta() {
            logger.LogInformation("Inicio de Consulta");
        
            return new JsonResult(jsonResp);
        }
    }
}
