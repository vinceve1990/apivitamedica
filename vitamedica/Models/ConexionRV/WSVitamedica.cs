using vitamedica.Models.ConexionBD;

namespace vitamedica.Models.ConexionRV {
    public class WSVitamedica {
        private HttpRequestMessage request;
        private string Url;
        private VitamedicaContext context;
        private string jsonBody;

        public static class AppSettings {
            public static string TipoApi { get; set; }
        }

        private HttpClientHandler handler = new HttpClientHandler {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
        };

        private static HttpClient client = null;
    }
}
