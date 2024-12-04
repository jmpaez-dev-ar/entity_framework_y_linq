
namespace m02
{
	public class Delegados
	{
		// DELEGADOS
		// Los delegados son un tipo especial de objeto que se utiliza para representar y referenciar métodos. Actúan como punteros a funciones, pero son seguros en cuanto a tipos.
		public static void Demos()
		{
			Console.WriteLine("Delegados");
			Console.WriteLine("-----------------------------------\n");

			InvocarDemo1Delegados();
		}

		public delegate void MiDelegado(string mensaje);
		private static void InvocarDemo1Delegados()
		{
			// Crear una instancia del delegado y asignarle un método
			MiDelegado delegado = MostrarMensaje;
			// Invocar el delegado
			delegado("Hola desde el delegado!");

			// Asignar otro método al delegado
			delegado = MostrarMensajeEnMayusculas;
			// Invocar el delegado
			delegado("Hola desde el delegado en mayúsculas!");
		}

		public static void MostrarMensaje(string mensaje)
		{
			Console.WriteLine(mensaje);
		}

		public static void MostrarMensajeEnMayusculas(string mensaje)
		{
			Console.WriteLine(mensaje.ToUpper());
		}
	}
}
