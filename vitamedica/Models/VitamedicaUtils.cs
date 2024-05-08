using Microsoft.Extensions.Primitives;
using vitamedica.Models.ConexionBD;

namespace vitamedica.Models {
    public class VitamedicaUtils {
        public static int lote {  get; set; }
        public static int folio { get; set; }
        public static int colotes { get; set; }
        public static ILogger Logger { get; set; }

        internal static VitHeader leerHeader(IHeaderDictionary headers, string type) {
            VitHeader objHeader = new VitHeader();

            headers.TryGetValue("ReferTrans", out StringValues ReferTrans);
            objHeader.Refertrans = ReferTrans;

            headers.TryGetValue("Origen", out StringValues Origen);
            objHeader.Origen = Origen;

            headers.TryGetValue("Nodo", out StringValues nodo);
            objHeader.Nodo = nodo;

            headers.TryGetValue("TrxType", out StringValues trxType);
            objHeader.Txttype = trxType;

            headers.TryGetValue("trxSubType", out StringValues trxSubType);
            objHeader.Trxsubtype = trxSubType;

            //headers.TryGetValue("FechaHora", out StringValues FechaHora);//Todavia no se utiliza
            objHeader.Date = DateTime.Now;

            objHeader.Type = type;

            return objHeader;
        }
    }
}
