using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitComission
{
    public int IdPropio { get; set; }

    public short Vitatype { get; set; }

    public decimal Amount { get; set; }

    public DateTime StartDate { get; set; }
}
