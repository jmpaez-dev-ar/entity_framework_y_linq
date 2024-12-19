using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m04
{
	internal class _00_EntityFramework
	{
		// Entity Framework (EF) es un ORM (Object-Relational Mapper) de Microsoft para .NET que simplifica la interacción entre aplicaciones y bases de datos relacionales. Permite trabajar con datos como objetos en código (clases y propiedades), evitando escribir consultas SQL directamente.
		/*
		    Principales características de Entity Framework (EF):
			    - Modelos de desarrollo: Database-First, Code-First y Model-First.
			    - Consultas con LINQ: Lenguaje integrado para consultas.
			    - Carga de datos: Lazy Loading, Eager Loading y Explicit Loading.
			    - Migraciones: Gestión de cambios en la base de datos.
			    - Seguimiento de cambios: Rastrea automáticamente modificaciones en los datos.

		    Beneficios:
			    - Aumenta la productividad.
			    - Facilita el mantenimiento del código.
			    - Compatible con patrones como Repository y Unit of Work.

		    Limitaciones:
			    - Puede ser menos eficiente en escenarios complejos.
			    - Requiere aprender conceptos de ORM y bases de datos.

		    Es ideal para simplificar el acceso a datos en aplicaciones .NET Core y .NET Framework.
		*/

		// Un ORM (Object-Relational Mapper) es una herramienta que facilita la interacción entre aplicaciones y bases de datos relacionales, mapeando tablas y columnas a clases y propiedades en código. Permite trabajar con datos como objetos, evitando escribir consultas SQL manuales.
		/*
            Principales características de un ORM (Object-Relational Mapper):
			    - Automatización de CRUD (Create, Read, Update, Delete).
			    - Gestión de relaciones entre tablas como objetos.
			    - Seguimiento de cambios en los datos.
			    - Abstracción: Traduce operaciones en código a consultas SQL automáticamente.

		    Ventajas:
			    - Mayor productividad y mantenibilidad.
			    - Código más limpio y legible.
			    - Portabilidad entre bases de datos.

		    Desventajas:
			    - Menor rendimiento en escenarios complejos.
			    - Requiere aprender su funcionamiento.
			    - Menor control sobre consultas SQL específicas.
		 */

		// 1. Database-First (Base de datos primero)
		/*
            Database-First:
                - Se parte de una base de datos existente.
                - EF genera automáticamente el modelo de datos a partir de las tablas.
                - Ideal para bases de datos heredadas.
                - Ventaja: Aprovecha estructuras existentes.
                - Desventaja: Menor flexibilidad para cambios en el modelo.
		 */

		// 2. Code-First (Código primero)
		/*
            Code-First:
                - Se define el modelo en código y EF genera la base de datos.
                - Usa Data Annotations o Fluent API para configurar relaciones.
                - Ventaja: Mayor control sobre el modelo y soporte para migraciones.
                - Desventaja: Requiere mayor configuración inicial.
		 */

		// 3. Model-First(Modelo primero)
		/*
            Model-First:
                - El modelo se diseña gráficamente y EF genera la base de datos.
                - Ventaja: Visualización clara de entidades y relaciones.
                - Desventaja: Menor control sobre el código generado.         
         */

		// DbContext en Entity Framework (EF): es la clase principal en EF que sirve como puente entre la aplicación y la base de datos, permitiendo realizar operaciones CRUD y gestionar conexiones.
		/*
		     Funciones principales de DbContext:
			    - Gestión de Entidades: Proporciona propiedades DbSet<T> para representar y manipular tablas de la base de datos.

			    - Seguimiento de Cambios: Rastrea inserciones, actualizaciones y eliminaciones en las entidades y aplica los cambios con SaveChanges().

			    - Consultas y LINQ: Facilita consultas tipadas y seguras utilizando LINQ.

			    - Configuración del Modelo: Permite configurar el modelo de datos (relaciones, restricciones, etc.) con Fluent API en OnModelCreating.

		    DbContext simplifica la interacción con la base de datos al combinar acceso, rastreo y configuración en una sola clase.
		 */


	}
}
