using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitServicioParam
{
    public int IdVitservicioParams { get; set; }

    public string Sucursal { get; set; } = null!;

    public string PrprIdQa { get; set; } = null!;

    public string PrprIdProducion { get; set; } = null!;

    public int Estatus { get; set; }
}
