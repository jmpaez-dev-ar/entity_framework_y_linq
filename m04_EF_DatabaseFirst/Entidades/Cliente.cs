using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace m04_EF_DatabaseFirst.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

	[Required(ErrorMessage = "El código es obligatorio."), StringLength(10, ErrorMessage = "El código no puede exceder 10 caracteres.") ]
	public string Codigo { get; set; } = null!;

	[Required(ErrorMessage = "El apellido es obligatorio."), StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres.")]
	public string Apellido { get; set; } = null!;

	[Required(ErrorMessage = "El nombre es obligatorio."), StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres.") ]
	public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Email { get; set; } = null!;

	[StringLength(13, ErrorMessage = "El CUIT/CUIL no puede exceder 13 caracteres.")]
	[RegularExpression("^d{2}-d{8}-d{1}$", ErrorMessage = "El CUIT/CUIL debe tener el formato XX-XXXXXXXX-X.")]
	public string? CuitCuil { get; set; }

	public string? RazonSocial { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Pais { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
