using System;
using System.Collections.Generic;

namespace Empleado.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string ClaveCliente { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
