using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using R2HBook.Models;

namespace R2HBook
{
	public class Startup
	{
		//Specifies an in-memory database is injected into the service container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<StudentContext>(opt => opt.UseInMemoryDatabase("StudentList"));
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}