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

			//DemoFunc5();
		}

		#region DemoAccion1
		#endregion
		#region DemoAccion2
		#endregion


		#region DemoFunc1
		#endregion
		#region DemoFunc2
		#endregion
		#region DemoFunc3
		#endregion
		#region DemoFunc4
		#endregion
		#region DemoFunc5
		#endregion

	}
}
