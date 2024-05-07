using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitFolio
{
    public int Folio { get; set; }

    public string SerFolio { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int Sucursal { get; set; }

    public DateTime Fecha { get; set; }
}
