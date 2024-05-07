using Microsoft.AspNetCore.Mvc;
using vitamedica.Models;
using vitamedica.Models.ConexionBD;

namespace vitamedica.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConsultaController : ControllerBase {
        public readonly VitamedicaContext VitamedicaContext;
        public VitamedicaUtils vitamedicaUtils;
        private object jsonResp;
        private readonly ILogger<ConsultaController> logger;

        public ConsultaController(VitamedicaContext context, ILogger<ConsultaController> logger) {
            VitamedicaContext = context;
            this.logger = logger;
        }

        [HttpGet]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<JsonResult> consultaReceta() {
            logger.LogWarning("Inicio de Consulta");
            return new JsonResult(jsonResp);
        }
    }
}
