using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitLote
{
    public int Lote { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime FechaHora { get; set; }

    public string Estatus { get; set; } = null!;

    public int Sucursal { get; set; }

    public string SerLote { get; set; } = null!;

    public int Colote { get; set; }
}
