namespace m05_EF_CRUD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Demo();
			Console.ReadLine();
		}

		public static async void  Demo() {
			var categoriaService = new CategoriaService();
			var categorias = await categoriaService.GetAllCategoriasAsync();
			foreach (var c in categorias)
			{
				Console.WriteLine($"{c.Id}, {c.Codigo}, {c.Nombre}");
			}

		}
	}
}
