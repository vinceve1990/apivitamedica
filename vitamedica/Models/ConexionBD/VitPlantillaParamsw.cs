using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitPlantillaParamsw
{
    public int IdPlantillaParamws { get; set; }

    public int IdPlantilla { get; set; }

    public int RestServicios { get; set; }

    public int RestUrls { get; set; }

    public string NombreTrx { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Parametro { get; set; } = null!;
}
