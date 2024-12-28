using m04_EF_DatabaseFirst.Data;
using m04_EF_DatabaseFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace m05_EF_CRUD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Demo();
			Console.ReadLine();
		}

		public static async void Demo()
		{
			// Demo de CRUD con las entidades de la base de datos

			//----------------------------------------------------------------------------------------------
			// Cliente
			//----------------------------------------------------------------------------------------------
			var clienteService = new ClienteService();

			// READ
			var clientes = await clienteService.GetAllClientesAsync();
			foreach (var clienteItem in clientes)
			{
				Console.WriteLine($"{clienteItem.Id}, {clienteItem.Nombre}");
			}

			// CREATE
			var cliente1 = new Cliente
			{
				Codigo = "C01",
				Nombre = "Juan",
				Apellido = "Pérez",
				Ciudad = "Buenos Aires",
				Direccion = "Calle Falsa 123",
				Telefono = "01112345678",
				Email = "juan.perez@gmail.com"
			};
			await clienteService.CreateClienteAsync(cliente1);
			Console.WriteLine("Cliente agregado");
			MostrarDatosCliente(cliente1);

			// UPDATE
			cliente1.Nombre = "Cliente 21";
			await clienteService.UpdateClienteAsync(cliente1);
			Console.WriteLine("Cliente actualizado");
			MostrarDatosCliente(cliente1);

			// DELETE
			await clienteService.DeleteClienteAsync(cliente1.Id);
			Console.WriteLine("Cliente eliminado");
			MostrarDatosCliente(cliente1);

			//----------------------------------------------------------------------------------------------
			// Categoria
			//----------------------------------------------------------------------------------------------
			var categoriaService = new CategoriaService();

			// READ
			var categorias = await categoriaService.GetAllCategoriasAsync();
			foreach (var categoriaItem in categorias)
			{
				MostrarDatosCategoria(categoriaItem);
			}

			// CREATE
			var categoria = new Categoria { Codigo = "C20", Nombre = "Categoria 20" };
			await categoriaService.CreateCategoriaAsync(categoria);
			Console.WriteLine("Categoría agregada");
			MostrarDatosCategoria(categoria);

			// UPDATE
			categoria.Codigo = "C31";
			categoria.Nombre = "Categoría 31";
			await categoriaService.UpdateCategoriaAsync(categoria);
			Console.WriteLine("Categoría actualizada");
			MostrarDatosCategoria(categoria);

			// DELETE
			await categoriaService.DeleteCategoriaAsync(categoria.Id);
			Console.WriteLine("Categoría eliminada");
			MostrarDatosCategoria(categoria);

			//----------------------------------------------------------------------------------------------
			// Producto
			//----------------------------------------------------------------------------------------------
			var productoService = new ProductoService();

			// READ
			var productos = await productoService.GetAllProductosAsync();
			foreach (var productoItem in productos)
			{
				MostrarDatosProducto(productoItem);
			}

			// CREATE
			var producto1 = new Producto { Codigo = "P21", Nombre = "Producto 21", PrecioUnitario = 100, CategoriaId = 1 };
			await productoService.CreateProductoAsync(producto1);
			Console.WriteLine("Producto agregado");
			MostrarDatosProducto(producto1);


			// UPDATE
			producto1.PrecioUnitario = 200;
			await productoService.UpdateProductoAsync(producto1);
			Console.WriteLine("Producto actualizado");
			MostrarDatosProducto(producto1);

			// DELETE
			await productoService.DeleteProductoAsync(producto1.Id);
			Console.WriteLine("Producto eliminado");
			MostrarDatosProducto(producto1);

			//----------------------------------------------------------------------------------------------
			// Pedido
			//----------------------------------------------------------------------------------------------
			var pedidoService = new PedidoService();

			Cliente clienteParaPedido = await clienteService.GetClienteByCodigoAsync("C02");
			if (clienteParaPedido == null)
			{
				clienteParaPedido = new Cliente
				{
					Codigo = "C02",
					Nombre = "Carlos",
					Apellido = "González",
					Ciudad = "Córdoba",
					Direccion = "Avenida Siempre Viva 742",
					Telefono = "03511234567",
					Email = "carlos.gonzalez@gmail.com"
				};
				await clienteService.CreateClienteAsync(clienteParaPedido);
			}

			Producto producto2ParaPedido = await productoService.GetProductoByCodigoAsync("P22");
			if (producto2ParaPedido == null)
			{
				producto2ParaPedido = new Producto { Codigo = "P22", Nombre = "Producto 22", PrecioUnitario = 100, CategoriaId = 2 };
				await productoService.CreateProductoAsync(producto2ParaPedido);
			}

			Producto producto3ParaPedido = await productoService.GetProductoByCodigoAsync("P23");
			if (producto3ParaPedido == null)
			{
				producto3ParaPedido = new Producto { Codigo = "P23", Nombre = "Producto 23", PrecioUnitario = 100, CategoriaId = 3 };
				await productoService.CreateProductoAsync(producto3ParaPedido);
			}


			// CREATE
			var pedido = new Pedido
			{
				ClienteId = clienteParaPedido.Id,
				Numero = 101,
				FechaPedido = DateOnly.FromDateTime(DateTime.Now),
				DetallesPedidos = new List<DetallePedido>
									{
										new DetallePedido {
											ProductoId = producto2ParaPedido.Id,
											Cantidad = 1,
											PrecioUnitario = producto2ParaPedido.PrecioUnitario,
											DescuentoPorcentaje =0 },
										new DetallePedido {
											ProductoId = producto3ParaPedido.Id,
											Cantidad = 2,
											PrecioUnitario = 200,
											DescuentoPorcentaje =10}
									}
			};
			pedido.Total = pedido.DetallesPedidos.Sum(d => d.Cantidad * d.PrecioUnitario * (1 - (d.DescuentoPorcentaje / 100.0m)));

			await pedidoService.CreatePedidoAsync(pedido);

			// READ
			 pedido = await pedidoService.GetPedidoByIdAsync(pedido.Id);


			// Mostrar datos del pedido creado
			MostrarDatosPedido(pedido);
		}

		private static void MostrarDatosCliente(Cliente cliente)
		{
			Console.WriteLine($"Cliente: {cliente.Id}, {cliente.Nombre}, {cliente.Direccion}, {cliente.Telefono}, {cliente.Email}");
			Console.WriteLine("\n----------------------------------------\n");
		}

		private static void MostrarDatosCategoria(Categoria categoria)
		{
			Console.WriteLine($"Categoría: {categoria.Id}, {categoria.Codigo}, {categoria.Nombre}");
			Console.WriteLine("\n----------------------------------------\n");
		}
		private static void MostrarDatosProducto(Producto producto)
		{
			Console.WriteLine($"Producto: {producto.Id}, {producto.Codigo}, {producto.Nombre}, {producto.PrecioUnitario}");
			Console.WriteLine("\n----------------------------------------\n");
		}

		private static void MostrarDatosPedido(Pedido pedido)
		{
			Console.WriteLine($"Pedido: {pedido.Id}, {pedido.Numero}, {pedido.FechaPedido}, {pedido.Total}");
			Console.WriteLine($"	Cliente: {pedido.Cliente.Id}, {pedido.Cliente.Nombre}");
			foreach (var detalle in pedido.DetallesPedidos)
			{
				Console.WriteLine($"Detalle: {detalle.Id}, Producto: {detalle.Producto.Nombre}, Cantidad: {detalle.Cantidad}, Precio Unitario: {detalle.PrecioUnitario}, Descuento: {detalle.DescuentoPorcentaje}%");
			}
		}
	}
}