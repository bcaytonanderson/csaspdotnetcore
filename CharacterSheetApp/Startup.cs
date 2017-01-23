using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
// Infrastructure lets us have an in-memory database; if we were to use a SQL server, MySQL server, or other, we will change this accordingly.
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CharacterSheetApp
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder.SetBasePath(env.ContentRootPath);
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddEntityFramework()
				.AddDbContext<Models.ApplicationDbContext>();
				
			// allows MVC to be accessible throughout the application
			services.AddMvc();
		}
	}
}