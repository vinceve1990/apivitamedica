using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitBitError
{
    public int IdPropio { get; set; }

    public string ReferTrans { get; set; } = null!;

    public short Origen { get; set; }

    public short Nodo { get; set; }

    /// <summary>
    /// 1 - Interno\\n2 - Proveedor
    /// </summary>
    public string? Error { get; set; }

    public string? DescError { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Type { get; set; }
}
