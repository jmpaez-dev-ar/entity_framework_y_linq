using System.Collections;
namespace m02
{
	public class Laboratorio02
	{
		// Lab01
		// Crear un nuevo proyecto de Consola en Visual Studio, y crear un delegado que se llame Funcion que reciba dos parámetros de tipo int y retorne un valor de tipo int.
		delegate int Funcion(int a, int b);

		static void Demos()
		{
			Console.WriteLine("Laboratorio #02");
			Console.WriteLine("-----------------------------------\n");

			int resultado;

			//Lab02
			// Crear dos métodos que permitan sumar y restar, retornando el resultado de la operación y utilizarlos mediante un delegado.
			Funcion funcion;
			funcion = Sumar;
			int resultadoSuma = funcion(2, 4);

			funcion = Restar;
			int resultadoResta = funcion(2, 4);

			//Lab03
			// Crear un método anónimo que utilice la firma del delegado propuesto en el Lab01.
			funcion = delegate (int a, int b) { return a + b; };
			resultado = funcion(1, 4);

			//Lab04
			// Crear una expresión lambda que utilice la firma del delegado propuesto en el Lab01.
			funcion = (a, b) => a + b;
			resultado = funcion(2, 6);

			//Lab05
			// Crear una expresión lamda que imprimir un valor por pantalla y asignarlo a la clase Action.
			Action<string> show = (value) => { Console.WriteLine(value); };
			show("Hello world!");

			//Lab06
			// Crear una expresión lambda que permita sumar dos números y asignárselo a la clase Func.
			Func<int, int, int> func = (a, b) => a + b;
			resultado = funcion(2, 6);

			//Lab07
			// Indicar a la clase Coleccion<T> que implemente la interfaz IEnumerable<T>
			Coleccion<int> coleccion = new Coleccion<int>();
			foreach (int valor in coleccion)
			{
				Console.WriteLine(valor);
			}
		}

		static int Sumar(int a, int b)
		{
			return a + b;
		}

		static int Restar(int a, int b)
		{
			return a - b;
		}

	}

	class Coleccion<T> : IEnumerable<T>
	{
		// Método para agregar un elemento a la colección
		public void Add<T>(T valor)
		{
			// TODO: Implementar la lógica para agregar un elemento a la colección
		}

		// Método para obtener un enumerador que itera a través de la colección
		public IEnumerator<T> GetEnumerator()
		{
			// TODO: Implementar la lógica para obtener un enumerador
			throw new NotImplementedException();
		}

		// Método para obtener un enumerador que itera a través de una colección no genérica
		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			// TODO: Implementar la lógica para obtener un enumerador no genérico
			throw new NotImplementedException();
		}
	}
}
