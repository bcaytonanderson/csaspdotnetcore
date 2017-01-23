using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
				
			services.AddMvc();
		}
	}
}