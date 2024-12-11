using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace m02
{
	public class ExpresionesLambda
	{
		// EXPRESIONES LAMBDA
		// Las expresiones lambda son una forma concisa y flexible de definir funciones anónimas. Son útiles para escribir código breve y claro, especialmente en operaciones con colecciones, eventos y consultas LINQ.
		/*
		 Principales características:
				Definición compacta: (parámetros) => expresión o bloque.
				Manejo de colecciones: Filtrado, proyección, ordenación y agrupación.
				Eventos: Simplifican la suscripción y manejo de eventos.
				Consultas LINQ: Facilitan consultas y transformaciones de datos.
				Callbacks: Permiten implementar funciones que responden a eventos o condiciones específicas.

		 SINTAXIS:
			La sintaxis básica de una expresión lambda es la siguiente:
				(parametros) => expresion
			 Donde:
					parametros son los parámetros que toma la función lambda.
					expresion es la expresión que se ejecutará cuando se invoque la función lambda.
		*/
		public static void Demos()
		{
			Console.WriteLine("Expresiones Lambda");
			Console.WriteLine("-----------------------------------\n");

			//DemoExpresionesLambda1();
			//DemoExpresionesLambda2();
			//DemoExpresionesLambda3();
			// DemoExpresionesLambda4();
			// DemoExpresionesLambda5();
			//DemoExpresionesLambda6();
			//DemoExpresionesLambda7();
			DemoExpresionesLambda8();
		}

		#region DemoExpresionesLambda1
		private static void DemoExpresionesLambda1()
		{
			Console.WriteLine("Demo 1: Expresiones Lambda");

			// Lista de números
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine("Números:");
			numeros.ForEach(n => Console.WriteLine(n));


			// Filtrar números mayores que un umbral
			int umbral = 5;
			List<int> mayoresQueUmbral = numeros.Where(n => n > umbral).ToList();

			Console.WriteLine($"\nNúmeros mayores que {umbral}:");
			mayoresQueUmbral.ForEach(n => Console.WriteLine(n));
		}
		#endregion
		#region DemoExpresionesLambda2
		// Ordenar una Lista de Enteros con Expresión Lambda
		private static void DemoExpresionesLambda2()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			numeros.ForEach(n => Console.WriteLine(n));

			Console.WriteLine("------");

			numeros.Sort((a, b) => a.CompareTo(b));
			numeros.ForEach(n => Console.WriteLine(n));
		}
		#endregion
		#region DemoExpresionesLambda3
		// Suma de Elementos
		private static void DemoExpresionesLambda3()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			numeros.ForEach(n => Console.WriteLine(n));
			Console.WriteLine("------");
			int suma = numeros.Aggregate((a, b) => a + b);
			Console.WriteLine(suma);
		}
		#endregion
		#region DemoExpresionesLambda4
		// Encontrar el Máximo
		private static void DemoExpresionesLambda4()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			numeros.ForEach(n => Console.WriteLine(n));
			Console.WriteLine("------");
			int maximo = numeros.Max(n => n);
			Console.WriteLine(maximo);	
		}
		#endregion
		#region DemoExpresionesLambda5
		// Contar Elementos Condicionalmente
		private static void DemoExpresionesLambda5()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			numeros.ForEach(n => Console.WriteLine(n));
			Console.WriteLine("------");

//			int conteo = numeros.Count();
			int conteo = numeros.Count(n => n % 2 == 0);
			Console.WriteLine(conteo);
		}
		#endregion
		#region DemoExpresionesLambda6
		// Filtrar con Múltiples Condiciones
		private static void DemoExpresionesLambda6()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			var filtrados = numeros.Where(n => n > 3 && n < 8).ToList();

			filtrados.ForEach(n => Console.WriteLine(n));
		}
		#endregion
		#region DemoExpresionesLambda7
		// Conversión de Elementos de una Lista
		private static void DemoExpresionesLambda7()
		{
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
			List<string> cadenas = numeros.Select(n => n.ToString()).ToList();
			cadenas.ForEach(n => Console.WriteLine(n));
		}
		#endregion
		#region DemoExpresionesLambda8
		// Filtrar y Seleccionar Propiedades de una Lista de Objetos

		class Persona
		{
			public string Nombre { get; set; }
			public int Edad { get; set; }

			public override string ToString()
			{
				return $"Soy {Nombre} y tengo ({Edad}) de edad";
			}
		}

		private static void DemoExpresionesLambda8()
		{
			List<Persona> personas = new List<Persona>
								{
									new Persona { Nombre = "Juan", Edad = 25 },
									new Persona { Nombre = "Mario", Edad = 30 },
									new Persona { Nombre="Edith", Edad=28 },
								};

			var nombres = personas.Select(p => p.Nombre).ToList();

			var datosPersonas = personas.Select(p => p.ToString()).ToList();


			nombres.ForEach(p => Console.WriteLine(p));
			Console.WriteLine("------");
			datosPersonas.ForEach(p => Console.WriteLine(p));
		}
		#endregion
	}
}
