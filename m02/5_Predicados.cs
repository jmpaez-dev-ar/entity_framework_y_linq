using static Predicados;

namespace m02
{
	public partial class Predicados
	{
		// Predicate<T>
		/*
		 Predicate<T> es un delegado genérico que encapsula un método que toma un argumento de tipo T y devuelve un valor booleano (true o false). Es útil para filtrar o buscar elementos en colecciones.

		Características Principales:

		Verifica si un elemento cumple con una condición específica.
		Utilizado con métodos como FindAll, Find o RemoveAll.
		Pertenece al espacio de nombres System.
		
		SINTAXIS:
			bool Metodo(T parametro);

		Escenarios Comunes:

		Filtrar números pares o impares.
		Buscar elementos con propiedades específicas en listas.
		Validar elementos en colecciones.
		 */
		public static void Demos()
		{
			// DemoPredicados1();
			// DemoPredicados2();
			//DemoPredicados3();
			//DemoPredicados4();
			DemoPredicados5();
		}

		#region DemoPredicados1
		// Demo: Uso de Predicate con una lista de objetos Persona.
		private static void DemoPredicados1()
		{
			var listaPersonas = new List<Persona>
				{
				new Persona { Nombre = "Marco", Edad = 17 },
					new Persona { Nombre = "Juan", Edad = 25 },
					new Persona { Nombre = "Mario", Edad = 30 },
					new Persona { Nombre = "Edith", Edad = 15 },
				};

			// Definimos un Predicate que verifica si una persona es mayor de edad.
			Predicate<Persona> esMayorDeEdad = (persona) => persona.Edad >= 18;
			// Filtramos las personas mayores de edad usando FindAll.
			var mayoresDeEdad = listaPersonas.FindAll(esMayorDeEdad);

			// Imprimimos los nombres y edades de las personas mayores de edad.
			mayoresDeEdad.ForEach(persona =>
				Console.WriteLine($"{persona.Nombre}, {persona.Edad} años"));
		}
		#endregion
		#region DemoPredicados2
		// Demo: Uso de Predicate para filtrar números pares en una lista.
		private static void DemoPredicados2()
		{
			// Lista de números enteros.
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Declaramos un Predicate que verifica si un número es par.
			
			//Predicate<int> esPar = new Predicate<int>(EsNumeroPar);
			Predicate<int> esPar = EsNumeroPar;

			// Usamos FindAll para obtener solo los números pares.
			//List<int> numerosPares = numeros.FindAll(esPar);
			var numerosPares = numeros.FindAll(esPar);

			// Imprimimos los números pares en la consola.
			Console.WriteLine("Números Pares:");
			numerosPares.ForEach(num => Console.WriteLine(num));
		}

		// Método auxiliar que verifica si un número es par.
		static bool EsNumeroPar(int numero)
		{
			return numero % 2 == 0;
		}

		#endregion
		#region DemoPredicados3
		// Demo: Uso de Predicate para verificar si una lista contiene un número mayor a 50.
		private static void DemoPredicados3()
		{
			// Lista de números enteros.
			List<int> numeros = new List<int> { 10, 20, 30, 40, 50, 60, 70 };

			// Declaramos un Predicate que verifica si un número es mayor a 50.
			Predicate<int> esMayorQueCincuenta = (numero) => numero > 50;

			// Usamos el método Exists para verificar si hay algún número mayor a 50.
			bool existeMayorQueCincuenta = numeros.Exists(esMayorQueCincuenta);

			// Imprimimos el resultado en la consola.
			if (existeMayorQueCincuenta)
			{
				Console.WriteLine("Existe al menos un número mayor a 50 en la lista.");
			}
			else
			{
				Console.WriteLine("No existe ningún número mayor a 50 en la lista.");
			}
		}

		#endregion
		#region DemoPredicados4
		// Demo: Uso de Predicate para eliminar palabras con más de 5 caracteres en una lista.
		private static void DemoPredicados4()
		{
			// Lista de cadenas.
			List<string> palabras = new List<string> { "manzana", "banana", "cereza", "durazno", "pera" };
			Console.WriteLine("Palabras originales:");
			palabras.ForEach(palabra => Console.WriteLine(palabra));

			// Declaramos un Predicate que verifica si una palabra tiene más de 5 caracteres.
			Predicate<string> tieneMasDeCincoCaracteres = (palabra) => palabra.Length > 5;

			// Usamos el método RemoveAll para eliminar todas las palabras que tienen más de 5 caracteres.
			int eliminados = palabras.RemoveAll(tieneMasDeCincoCaracteres);

			// Imprimimos la cantidad de palabras eliminadas y la lista resultante.
			Console.WriteLine($"Se eliminaron {eliminados} palabras.");
			Console.WriteLine("Palabras restantes:");
			palabras.ForEach(palabra => Console.WriteLine(palabra));
		}
		#endregion
		#region DemoPredicados5
		//  Demo: Uso de Predicate para encontrar el primer número impar en una lista.
		private static void DemoPredicados5()
		{
			// Lista de números enteros.
			List<int> numeros = new List<int> { 8, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Declaramos un Predicate que verifica si un número es impar.
			Predicate<int> esImpar = numero => numero % 2 != 0;

			// Usamos el método Find para encontrar el primer número impar.
			int primerImpar = numeros.Find(esImpar);

			// Imprimimos el primer número impar encontrado.
			Console.WriteLine($"El primer número impar es: {primerImpar}");
		}
		#endregion
	}
}
