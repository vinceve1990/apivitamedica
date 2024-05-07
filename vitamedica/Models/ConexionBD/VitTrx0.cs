using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitTrx0
{
    public int IdVittrx0 { get; set; }

    public string? PrIdenSucu { get; set; }

    public string? PrIdenCade { get; set; }

    public string? Seciniventa { get; set; }

    public string? Error { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? Folio { get; set; }
}
