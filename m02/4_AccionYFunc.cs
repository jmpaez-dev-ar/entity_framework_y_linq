namespace m02
{
	public class AccionYFunc
	{
		// Las clases Action<> y Func<> son delegados genéricos que permiten representar métodos con diversos parámetros y valores de retorno, ofreciendo flexibilidad en su manejo.

		// Action<>:
		/*
			Action<> es un delegado genérico en C# que representa un método que no devuelve un valor (void) y puede aceptar hasta 16 parámetros de entrada. Se utiliza para encapsular lógica que realiza acciones sin retornar resultados.

		Sintaxis:
			Action<parametro1, parametro2, ..., parametroN> nombreDelegado = (parametro1, parametro2, ..., parametroN) => {
				// Cuerpo del método
			};

		Usos Comunes:
			1. Callback: Ejecutar una acción tras completar una tarea(ej.operaciones asíncronas).
			2. Encapsulamiento: Pasar lógica como parámetro a otros métodos.
			3. Eventos: Manejar eventos que no necesitan devolver valores.
			4. Colecciones: Usado con List<T>.ForEach para aplicar acciones a cada elemento.
			5. Tareas Paralelas: Ejecutar acciones en hilos separados con Task.Run.
			6. Patrones de Diseño: Aplicado en patrones como Observador o Estrategia.
			7. Pruebas Unitarias: Simular o validar comportamientos específicos.
		*/

		// Func<>:
		/*
		Func<> es un delegado genérico en C# que encapsula métodos con valores de retorno. Acepta de 0 a 16 parámetros de entrada, siendo el último tipo el tipo de retorno.

		Sintaxis:
			Func<parametro1, ..., parametroN, tipoDeRetorno> delegado = (param1, ..., paramN) => {
				return valorDeRetorno;
			};
		
		Usos Comunes:
			1. Programación Funcional: Pasar o retornar funciones como datos.
			2. LINQ: Transformar y filtrar colecciones.
			3. Lazy Loading: Retrasar la ejecución hasta que sea necesario.
			4. Pruebas Unitarias: Simular comportamientos en pruebas.
			5. Tareas Diferidas: Encapsular lógica a ejecutar en el futuro.
		 */


		public static void Demos()
		{
			Console.WriteLine("Action<> y Func<>");
			Console.WriteLine("-----------------------------------\n");

			//DemoAccion1();

			//DemoAccion2();

			//DemoFunc1();

			//DemoFunc2();

			//DemoFunc3();

			//DemoFunc4();

			DemoFunc5();
		}

		#region DemoAccion1
		private static void DemoAccion1()
		{
			Console.WriteLine("Demo Action<T>");

			// Definir un Action que acepta un parámetro de tipo string y no devuelve un valor
			Action<string> mostrarMensaje = (mensaje) =>
			{
				// Imprimir el mensaje en la consola
				Console.WriteLine(mensaje);
			};

			// Invocar el Action con un mensaje específico
			mostrarMensaje("Hola, mundo con Action<T>!");

			Console.WriteLine("\n");
		}
		#endregion
		#region DemoAccion2
		public static void DemoAccion2()
		{
			Console.WriteLine("Demo Action<T> en Ciclos");

			// Definir un Action que acepta un entero como parámetro y lo imprime
			Action<int> imprimir = numero => Console.WriteLine(numero);

			// Usar un bucle for para llamar al Action con valores del 0 al 4
			for (int i = 0; i < 5; i++)
				imprimir(i);

			Console.WriteLine("\n");
		}
		#endregion


		#region DemoFunc1
		// Ejemplo de un Func<> sin parámetros que retorna un valor.
		private static void DemoFunc1()
		{
			// Declarar un Func que retorna una cadena sin tomar parámetros.
			// Func<string> obtenerSaludo = () => { return "Hola Mundo!"; };

			Func<string> obtenerSaludo = () => "Hola Mundo!";

			// Invocar la función y mostrar el resultado en la consola.
			Console.WriteLine(obtenerSaludo());
		}
		#endregion
		#region DemoFunc2
		//  Ejemplo de un Func<> con parámetros y retorno de valor.
		private static void DemoFunc2()
		{
			// Declarar un Func que toma dos enteros y retorna su suma.
			Func<int, int, int> sumar = (x, y) => x + y;

			// Invocar la función con dos números y mostrar el resultado en la consola.
			Console.WriteLine(sumar(5, 3));
		}

		#endregion
		#region DemoFunc3
		//  Ejemplo de un Func<> sin parámetros que genera un número aleatorio.
		private static void DemoFunc3()
		{
			// Declarar un Func que genera un número aleatorio.
			Func<int> getRandomNumber = () => new Random().Next();

			// Obtener el número aleatorio llamando a la función.
			int numeroAleatorio = getRandomNumber();

			// Imprimir el número generado.
			Console.WriteLine("Número aleatorio: " + numeroAleatorio);
		}

		#endregion
		#region DemoFunc4
		// Ejemplo de un Func<> con un parámetro que convierte una cadena a un número.
		private static void DemoFunc4()
		{
			// Declarar un Func que convierte una cadena a un entero.
			Func<string, int> parseToInt = str => int.Parse(str);

			// Convertir una cadena numérica a entero e imprimir el resultado.
			string numeroComoCadena = "123";
			int resultado = parseToInt(numeroComoCadena);
			Console.WriteLine("El resultado de la conversión es: " + resultado);
		}

		#endregion
		#region DemoFunc5
		// Ejemplo de un Func<> que retorna un valor nullable.
		private static void DemoFunc5()
		{
			// Declarar un Func que intenta convertir una cadena a un entero nullable.
			Func<string, int?> tryParse = str => int.TryParse(str, out int result) ? result : (int?)null;

			// Probar la función con diferentes entradas.
			string input1 = "123";
			string input2 = "abc";

			int? resultado1 = tryParse(input1);
			int? resultado2 = tryParse(input2);

			// Imprimir los resultados.
			Console.WriteLine("Resultado 1: " + (resultado1.HasValue ? resultado1.Value.ToString() : "null"));
			Console.WriteLine("Resultado 2: " + (resultado2.HasValue ? resultado2.Value.ToString() : "null"));
		}
		#endregion

	}
}
