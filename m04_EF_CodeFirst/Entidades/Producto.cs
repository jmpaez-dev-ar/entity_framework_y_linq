using System;
using System.Collections.Generic;

namespace m04_EF_DatabaseFirst.Entidades;

public partial class Producto
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public decimal PrecioUnitario { get; set; }

    public int CategoriaId { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();

	public static implicit operator Producto(Task<Producto?> v)
	{
		throw new NotImplementedException();
	}
}
