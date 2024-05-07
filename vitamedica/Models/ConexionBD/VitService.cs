using System;
using System.Collections.Generic;

namespace vitamedica.Models.ConexionBD;

public partial class VitService
{
    public int IdvitServices { get; set; }

    public int? Idmensaje { get; set; }

    public string? Descripcion { get; set; }

    public string? Url { get; set; }

    public int? Time { get; set; }
}
