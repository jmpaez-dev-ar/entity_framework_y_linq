using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo3
{
	public class m01_Basico
	{
		static void Main(string[] args)
		{
			Ejemplo1();
			// Ejemplo2();
			// Ejemplo3();
			// Ejemplo4();
			// Ejemplo5();
			// Ejemplo6();

		}
		private static void Ejemplo6()
		{
			// Consulta de Elementos con ElementAt
			var numeros = Enumerable.Range(1, 10);
			foreach (int numero in numeros) { Console.WriteLine(numero); }


			var tercerNumero = numeros.ElementAt(2);
			Console.WriteLine($"El tercer número en la lista es: {tercerNumero}");
					

			// Consulta de Elementos con Take y Skip
			var primerosTresNumeros = numeros.Take(3);
            Console.WriteLine("Take");
            foreach (int numero in primerosTresNumeros) { Console.WriteLine(numero); }

			Console.WriteLine("Skip");
			var numerosSaltandoTres = numeros.Skip(3);
			foreach (int numero in numerosSaltandoTres) { Console.WriteLine(numero); }

		}
		private static void Ejemplo5()
		{
			// Consulta de Cadena
			var nombres = new List<string> { "Juan", "María", "Carlos", "Ana", "Abel", "Pedro" };
			var nombresConA = nombres.Where(nombre => nombre.Contains("a", StringComparison.OrdinalIgnoreCase));
			foreach (var nombre in nombresConA)
				Console.WriteLine(nombre);
		}
		private static void Ejemplo4()
		{
			// Consulta Distinct
			var colores = new List<string> { "rojo", "verde", "azul", "rojo", "amarillo", "verde" };
			var coloresUnicos = colores.Distinct();
			foreach (var color in coloresUnicos)
				Console.WriteLine(color);
		}

		private static void Ejemplo3()
		{
			// Unión de Consultas
			var otrosNumerosPares = Enumerable.Range(1, 10).Where(n => n % 2 == 0);
			var otrosNumerosImpares = Enumerable.Range(20, 30).Where(n => n % 2 != 0);
			var numerosCombinados = otrosNumerosPares.Concat(otrosNumerosImpares);
			foreach (var numero in numerosCombinados)
			{
				Console.WriteLine(numero.ToString());
			}


		}

		private static void Ejemplo1()
		{
			// Consultar una colección
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

			Console.WriteLine("Sintaxis Consulta");
			var consultaSql = from num in numeros
							  where num > 3
							  select num;

			foreach (int numero in consultaSql)
				Console.WriteLine(numero);

			Console.WriteLine("Sintaxis Método");
			var consultaMth = numeros.Where(num => num % 2 == 0);

			foreach (int numero in consultaMth)
				Console.WriteLine(numero);
		}

		private static void Ejemplo2()
		{
			var rangoNumeros = Enumerable.Range(1, 30);
			Console.WriteLine("Números del 1 al 30:");
			foreach (var numero in rangoNumeros)
				Console.WriteLine(numero);
		}


	}
}
