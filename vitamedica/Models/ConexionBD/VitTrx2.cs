using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitTrx2
{
    public int IdVittrx2 { get; set; }

    public string PrSecuencia { get; set; } = null!;

    public string PrIdenCade { get; set; } = null!;

    public string PrIdenSucu { get; set; } = null!;

    public string Ca1 { get; set; } = null!;

    public string? PrIdenProd { get; set; }

    public string? PrCantToma { get; set; }

    public string? PrVecesDia { get; set; }

    public string? PrDias { get; set; }

    public string? PrCantSurt { get; set; }

    public string? PrPmp { get; set; }

    public string? PrDesc { get; set; }

    public string? PrValorUnitVenta { get; set; }

    public string? PrDesglva { get; set; }

    public string? PrValorTotalVenta { get; set; }

    public string? Ca2 { get; set; }

    public string? MtoTotalCred { get; set; }

    public string? MtoTotalCopa { get; set; }

    public string? CantProdAuto { get; set; }

    public string? MensajeSeg { get; set; }

    public string? Error { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
