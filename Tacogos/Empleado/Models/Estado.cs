using System;
using System.Collections.Generic;

namespace Empleado.Models;

public partial class Estado
{
    public int IdEstado { get; set; }

    public string Estado1 { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
