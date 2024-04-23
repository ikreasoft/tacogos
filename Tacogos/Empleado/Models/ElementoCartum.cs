using System;
using System.Collections.Generic;

namespace Empleado.Models;

public partial class ElementoCartum
{
    public int IdElemento { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }
}
