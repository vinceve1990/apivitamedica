using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitColote
{
    public int IdPropio { get; set; }

    public int? Colote { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaHora { get; set; }
}
