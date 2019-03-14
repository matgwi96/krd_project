using System.Threading.Tasks;
using krd_project.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace krd_project.API.People.Workers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorkersController : ControllerBase
	{
		private readonly DataContext _context;

		public WorkersController(DataContext context)
		{
			_context = context;
		}
		// GET api/values
		[HttpGet]
		public async Task<IActionResult> GetWorkers()
		{
			var workers = await _context.Workers.ToListAsync();

			return Ok(workers);
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetWorker(int id)
		{
			var worker = await _context.Workers.FirstOrDefaultAsync(x => x.Id == id);

			return Ok(worker);
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
