using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitTrx5
{
    public int IdVittrx5 { get; set; }

    public string PrSecuencia { get; set; } = null!;

    public string PrIdenCade { get; set; } = null!;

    public string PrIdenSucu { get; set; } = null!;

    public string Ca4 { get; set; } = null!;

    public string? PrNumFact { get; set; }

    public string? Ca5 { get; set; }

    public string? Error { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
