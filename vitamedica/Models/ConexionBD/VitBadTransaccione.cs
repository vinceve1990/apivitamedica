using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitBadTransaccione
{
    public int IdPropio { get; set; }

    public int IdDia { get; set; }

    public short Originador { get; set; }

    public short Nodo { get; set; }

    public int Ticket { get; set; }

    public string ReferTrans { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public DateTime Hora { get; set; }

    public short Concepto { get; set; }

    public decimal Monto { get; set; }

    public short Trxtype { get; set; }

    public short Trxsubtype { get; set; }

    public short Estatus { get; set; }

    public string? Vitidtransaccion { get; set; }

    public short Vittype { get; set; }

    public string? Vitaccount { get; set; }

    public string Vitauth { get; set; } = null!;

    public string Vitrefer { get; set; } = null!;

    public string Referenciafg { get; set; } = null!;

    public int IdLote { get; set; }

    public int IdFolio { get; set; }

    public int IdColote { get; set; }

    public DateTime FinInserta { get; set; }

    public DateTime FEstatus { get; set; }

    /// <summary>
    /// Tarifa o comision
    /// </summary>
    public decimal Fee { get; set; }

    public string Vitacount { get; set; } = null!;

    public int? Vitcode { get; set; }

    public string? Afectado { get; set; }
}
