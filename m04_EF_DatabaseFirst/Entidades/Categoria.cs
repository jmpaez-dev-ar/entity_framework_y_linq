﻿using System;
using System.Collections.Generic;

namespace m04_EF_DatabaseFirst.Entidades;

public partial class Categoria
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
