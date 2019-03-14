using krd_project.API.People.Persons;

namespace krd_project.API.People.Workers
{
	public class Worker : Person
	{
		public string Opinion { get; set; }

		public int BossId { get; set; }
	}
}
