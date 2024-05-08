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

        public ConsultaController(VitamedicaContext context, ILogger<ConsultaController> logger) {
            VitamedicaContext = context;
        }

        [HttpGet]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<JsonResult> consultaReceta() {
            logger.LogInformation(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " Inicio de Consulta");
            try {
                VitHeader vitHeader = VitamedicaUtils.leerHeader(Request.Headers, "CON");

                logger.LogInformation(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " Lote");

                logger.LogInformation(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " Folio");
            } catch (Exception ex) {
                logger.LogInformation(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + ex.Message);
            }

            return new JsonResult(jsonResp);
        }
    }
}
