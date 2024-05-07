using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitInfopaciente
{
    public int IdVitinfoPaciente { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApePaterno { get; set; } = null!;

    public string ApeMaterno { get; set; } = null!;

    public string Elegibilidad { get; set; } = null!;

    public string NumReceta { get; set; } = null!;

    public DateTime FechaConsulta { get; set; }

    public int TipoEmpleado { get; set; }

    public int EstatusEmpleado { get; set; }

    public string NumCredencial { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string IdPersona { get; set; } = null!;
}
