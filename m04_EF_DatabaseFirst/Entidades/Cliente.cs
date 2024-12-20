using System;
using System.Collections.Generic;

namespace m04_EF_DatabaseFirst.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Email { get; set; } = null!;

    public string? CuitCuil { get; set; }

    public string? RazonSocial { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
