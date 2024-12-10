namespace m02
{
	public class InterfacesIEnumerableYIQueryable
	{
		public static void Demos()
		{

			// `IEnumerable<T>` y `IQueryable<T>`:
			/*
				`IEnumerable<T>`:
					- Definición: Permite recorrer colecciones en memoria de manera secuencial.
					- Uso: Ideal para datos ya cargados en memoria.
					- Características: Ejecución inmediata, no optimizada para consultas complejas.
					- Ejemplo: Utilizable con listas, matrices y colecciones genéricas.

				`IQueryable<T>`:
					- Definición: Permite realizar consultas a fuentes de datos externas (como bases de datos) usando LINQ.
					- Uso: Diseñado para consultas optimizadas y diferidas.
					- Características: Ejecuta consultas en el origen de los datos (como SQL), minimizando la carga en memoria.
					- Ejemplo: Utilizado comúnmente en Entity Framework y LINQ to SQL.

				Diferencias Clave:
					- `IEnumerable<T>` trabaja con datos en memoria y ejecuta las consultas inmediatamente.
					- `IQueryable<T>` realiza consultas diferidas y optimizadas en el origen de los datos.
			 */
			Console.WriteLine("Interfaces IEnumerable<T> y IQueryable<T>");
			Console.WriteLine("-----------------------------------------\n");

			//DemoIEnumerable1();
			//DemoIEnumerable2();
			//DemoIEnumerable3();

			//DemoIQueryable1();
		}

		#region DemoIEnumerable1
		#endregion
		#region DemoIEnumerable2
		#endregion
		#region DemoIEnumerable3
		#endregion
		#region DemoIQueryable1
		#endregion
	}
}
