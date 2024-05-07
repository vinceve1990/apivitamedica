using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitTrx1
{
    public int IdVittrx1 { get; set; }

    public string PrSecuencia { get; set; } = null!;

    public string PrIdenCade { get; set; } = null!;

    public string PrIdenSucu { get; set; } = null!;

    public string PrNumElegibilidad { get; set; } = null!;

    public string PrFolioReceta { get; set; } = null!;

    public string? PrCopia { get; set; }

    public string? PrSecIniVenta { get; set; }

    public string? PrNumPreautorizacion { get; set; }

    public string? Nomb { get; set; }

    public string? Primapel { get; set; }

    public string? Seguapel { get; set; }

    public string? Sexo { get; set; }

    public string? Edad { get; set; }

    public string? Cliente { get; set; }

    public string? Grupo { get; set; }

    public string? Valivent { get; set; }

    public string? Ca1 { get; set; }

    public string? Tiporeceta { get; set; }

    public string? Mens { get; set; }

    public string? Error { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
