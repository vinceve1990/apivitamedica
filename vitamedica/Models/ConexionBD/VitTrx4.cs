using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitTrx4
{
    public int IdVittrx4 { get; set; }

    public string PrSecuencia { get; set; } = null!;

    public string PrIdenCade { get; set; } = null!;

    public string PrIdenSucu { get; set; } = null!;

    public string Ca1 { get; set; } = null!;

    public string? PrCodiAcep { get; set; }

    public string? PrNumFact { get; set; }

    public string? PrVentTotal { get; set; }

    public string? PrDesglIva { get; set; }

    public string? Ca4 { get; set; }

    public string? Error { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
