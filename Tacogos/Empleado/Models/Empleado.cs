using System;
using System.Collections.Generic;

namespace Empleado.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string ClaveEmpleado { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
