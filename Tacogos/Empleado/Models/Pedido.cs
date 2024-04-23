using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Empleado.Models;

public partial class Pedido
{ 
    public int IdPedido { get; set; }

    public DateTime FechaPedido { get; set; }

    public int IdCliente { get; set; }

    public int? IdEmpleado { get; set; }

    public int IdEstado { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Estado IdEstadoNavigation { get; set; } = null!;
}
