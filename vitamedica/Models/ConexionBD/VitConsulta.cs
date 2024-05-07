using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitConsulta
{
    public int IdVitconsultas { get; set; }

    public string Tipoconsulta { get; set; } = null!;

    public string Folio { get; set; } = null!;

    public string PrprId { get; set; } = null!;

    public string? Mensajeerror { get; set; }

    public int? Codigoerror { get; set; }

    public DateTime? FechaInsert { get; set; }

    public DateTime? FechaUpdate { get; set; }
}
