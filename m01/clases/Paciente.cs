namespace m01.clases
{
	public class Paciente
	{
		public Paciente()
		{
			Nombre = string.Empty;
			Email = string.Empty;
		}
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Email { get; set; }
	}
}
