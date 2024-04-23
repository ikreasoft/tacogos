using System;
using System.Collections.Generic;

namespace Empleado.Models;

public partial class ElementoPedido
{
    public int IdPedido { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int IdElemento { get; set; }

    public virtual ElementoCartum IdElementoNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;
}
