using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitTrx3
{
    public int IdVittrx3 { get; set; }

    public string PrSecuencia { get; set; } = null!;

    public string PrIdenCade { get; set; } = null!;

    public string PrIdenSucu { get; set; } = null!;

    public string Ca1 { get; set; } = null!;

    public string Ca2 { get; set; } = null!;

    public string? Ca3 { get; set; }

    public string? Error { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
