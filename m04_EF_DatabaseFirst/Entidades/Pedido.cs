using System;
using System.Collections.Generic;

namespace m04_EF_DatabaseFirst.Entidades;

public partial class Pedido
{
    public int Id { get; set; }

    public DateOnly FechaPedido { get; set; }

    public int Numero { get; set; }

    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; } = new List<DetallesPedido>();
}
