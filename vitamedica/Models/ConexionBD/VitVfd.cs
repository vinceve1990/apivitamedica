using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitVfd
{
    public int IdVitVfd { get; set; }

    public string IdProveedor { get; set; } = null!;

    public string Elegibilidad { get; set; } = null!;

    public string FirmaDigital { get; set; } = null!;

    public long? FirmaValida { get; set; }

    public string? Mensaje { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
