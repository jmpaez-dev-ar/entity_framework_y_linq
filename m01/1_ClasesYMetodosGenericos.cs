using m01.clases;
using System.Collections;

namespace m01
{
	public class ClasesYMetodosGenericos
	{
		// CLASES GENÉRICAS:
		// Las clases genéricas permiten definir estructuras reutilizables que trabajan con cualquier tipo de datos, especificados en tiempo de ejecución. Ofrecen reutilización de código, seguridad de tipos y mejoran el rendimiento al evitar conversiones innecesarias. Estas clases son flexibles, fáciles de mantener y mejoran la legibilidad al eliminar duplicaciones en el código.

		// MÉTODOS GENÉRICOS:
		// Los métodos genéricos permiten definir métodos con parámetros de tipo, especificados en tiempo de ejecución. Ofrecen flexibilidad, reutilización de código y seguridad de tipos al trabajar con diferentes datos sin duplicar el código.
		public static void Demos()
		{
			Console.WriteLine("Demo de Clases y Metodos Genericos");
			Console.WriteLine("-----------------------------------\n");

			DemoSinGenerics();

			DemoConGenerics();

			DemoClaseGenerics();

			DemoClaseGenericaCaja();
		}


		private static void DemoSinGenerics()
		{
			/*
			DESVENTAJAS DE NO USAR GENÉRICOS
				- Falta de seguridad de tipos: Permite agregar cualquier tipo, lo que puede causar errores en tiempo de ejecución.
				- Conversión de tipos: Requiere casting, aumentando errores y afectando el rendimiento.
				- Rendimiento: Boxing/unboxing degrada el desempeño.
				- Legibilidad y mantenimiento: El código es menos claro y más difícil de mantener.
			*/

			var list = new ArrayList();

			// Aquí se pueden añadir elementos de diferentes tipos a un ArrayList.
			list.Add(23);
			list.Add(45);
			list.Add(87);
			list.Add("una cadena");
			list.Add(new ArrayList());
			list.Add(DateTime.Now);
			list.Add(new MiClase());

			foreach (var i in list)
			{
				Console.WriteLine(i);
			}
		}
		private static void DemoConGenerics()
		{
			/*
			 VENTAJAS DE USAR GENÉRICOS
				- Seguridad de tipos: Evitan errores en tiempo de ejecución al garantizar tipos consistentes.
				- Eliminación de conversiones: Mejoran la legibilidad y reducen errores al no requerir casting.
				- Mejor rendimiento: Optimizan el desempeño al evitar boxing/unboxing.
				- Reutilización de código: Permiten crear código flexible y reutilizable para distintos tipos.
			 */

			var list = new List<MiClase>();

			// Aquí no se pueden añadir elementos de diferentes tipos a una lista genérica que solo debería contener objetos de tipo MiClase.

			list.Add(new MiClase());
			//list.Add(23);
			//list.Add(45);
			//list.Add(87);
			//list.Add("una cadena");
			//list.Add(new ArrayList());
			//list.Add(DateTime.Now);
			list.Add(new MiClase());

			foreach (var i in list)
			{
				Console.WriteLine(i);
			}
		}

		private static void DemoClaseGenerics()
		{
			// Ejemplo de la creación de instancias de una clase genérica con distintos tipos (int y string) y el uso de un método genérico para trabajar de forma flexible y reutilizable con estos tipos.

			MiClaseGenerica<int> objetoNumerico = new MiClaseGenerica<int>(10);
			MiClaseGenerica<string> objetoCadena = new MiClaseGenerica<string>("Un mensaje");

			objetoNumerico.MostrarTipoValor();
			objetoCadena.MostrarTipoValor();
		}

		public static void DemoClaseGenericaCaja()
		{
			// Ejemplo cómo la clase genérica Caja<T>, permiten almacenar cualquier tipo de dato en tiempo de ejecución, ofreciendo flexibilidad, reutilización de código y seguridad de tipos.

			Caja<int> cajaEntero = new Caja<int>();
			cajaEntero.Guardar(456);
			Console.WriteLine(cajaEntero.Obtener());

			Caja<string> cajaString = new Caja<string>();
			cajaString.Guardar("Mensajes");
			Console.WriteLine(cajaString.Obtener());
		}

		public static void DemoInstanciarListasGenerica()
		{
			List<int> numerosInteros = new List<int> { 2, 1, 3, 5, 7, 4, 1, 3, 5, 0, 7, 31 };
		}
	}

	public class MiClaseGenerica<T>     // T: Es un parámetro de tipo genérico. Puede ser cualquier tipo (int, string, etc.).
	{
		T value;

		public MiClaseGenerica(T t)     // Toma un parámetro de tipo T y lo asigna a la variable value.
		{
			this.value = t;
		}

		public void MostrarTipoValor()  // Imprime el nombre del tipo y el valor almacenado.
		{
			Console.WriteLine(this.value?.GetType().Name);
			Console.WriteLine(this.value);
		}
	}

	public class Caja<T>
	{
		// Ejemplo de una clase genérica donde T es un parámetro de tipo que puede representar cualquier dato (como int, string, o una clase) y se define al instanciar la clase. 

		private T contenido;
		public int Id { get; set; }
		public string Nombre { get; set; }

		public void Guardar(T item)
		{
			contenido = item;
		}

		public T Obtener()
		{
			return contenido;
		}
	}

}

