﻿using m03.Demos.Clases;

namespace m03
{
	public class _09_Linq_Operadores_Agrupacion
	{
		// Los operadores de agrupación en LINQ organizan elementos en grupos según propiedades comunes, facilitando la categorización o segmentación de datos por una clave específica.

		/*
		 Operadores de agrupación en LINQ:

			GroupBy: Agrupa elementos por una clave común.
			ToLookup: Crea un objeto Lookup para acceder a elementos agrupados por clave.
			Join: Combina dos secuencias usando una clave común.
			GroupJoin: Combina dos secuencias y agrupa los resultados por la clave común.
		 */
		public static void Demos()
		{           
			// Obtener la lista de todos los estudiantes
			var estudiantes = Estudiante.ObtenerTodos();

			// Agrupar estudiantes por edad usando GroupBy

			// Utilizando la sintaxis de consulta
			var agrupadosPorEdad =
					from e in estudiantes
					group e by e.Edad;

			foreach (var grupo in agrupadosPorEdad)
			{
				Console.WriteLine($"Edad: {grupo.Key}");
				// Iterar sobre cada estudiante en el grupo actual
				foreach (var estudiante in grupo)
				{
					Console.WriteLine($"    Estudiante: {estudiante.Nombre}");
				}
			}
		}
	}
}