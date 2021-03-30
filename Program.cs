using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DailySpellsAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//CreateHostBuilder(args).Build().Run();
			var rootPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			Directory.SetCurrentDirectory(rootPath);
			//var currentDirectory = Directory.GetCurrentDirectory();
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
				.UseUrls("http://localhost:5005")
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();
			host.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
