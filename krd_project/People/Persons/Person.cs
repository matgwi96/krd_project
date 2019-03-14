using System.ComponentModel.DataAnnotations;

namespace krd_project.API.People.Persons
{
	public class Person
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string SurName { get; set; }

		public string Password  { get; set; }
	}
}
