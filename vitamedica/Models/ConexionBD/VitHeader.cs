using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitHeader
{
    public int IdPropio { get; set; }

    public int FolioProceso { get; set; }

    public string Type { get; set; } = null!;

    public string? Origen { get; set; }

    public string? Nodo { get; set; }

    public DateTime? Date { get; set; }

    public string? Txttype { get; set; }

    public string? Trxsubtype { get; set; }

    public string? Refertrans { get; set; }

    public string? Error { get; set; }

    public string? Origenresp { get; set; }

    public string? Descerror { get; set; }

    public string? Lote { get; set; }

    public string? Transaccion { get; set; }
}
