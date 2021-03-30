using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using DailySpellsAPI.Repository;
using DailySpellsAPI.Interfaces;
using DailySpellsAPI.GraphQL.GraphQLSchema;
using Microsoft.EntityFrameworkCore;
using DailySpellsAPI.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;

namespace DailySpellsAPI
{
	public class Startup
	{
		readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
		public Startup(IConfiguration configuration, IWebHostEnvironment env)
		{
			var builder = new ConfigurationBuilder()
								.SetBasePath(env.ContentRootPath)
								.AddJsonFile("appsettings.json")
								.AddJsonFile($"appsettings.{env.EnvironmentName}.json")
								.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public IConfiguration Configuration { get; }
		private IWebHostEnvironment CurrentEnvironment { get; set; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
								  builder =>
								  {
									  builder.WithOrigins("*")
									  .AllowAnyHeader();
								  });
				services.AddDbContext<DailySpellsContext>(options =>
				{
					options.UseNpgsql(Configuration.GetConnectionString("DailySpell"));
				});
			});
			
			services.AddDbContext<DailySpellsContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("DailySpells")));
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();


			/*if (CurrentEnvironment.IsProduction() || CurrentEnvironment.IsStaging())
			{
				services.Configure<ForwardedHeadersOptions>(options =>
				{
					options.KnownProxies.Add(IPAddress.Parse("10.0.0.100"));
				});
			}*/


			services.AddScoped<ICharacterRepository, CharacterRepository>();
			services.AddScoped<AppSchema>();
			services.AddGraphQL()
				.AddSystemTextJson()
				.AddGraphTypes(typeof(AppSchema), ServiceLifetime.Scoped);

			services.AddControllers()
					.AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

			

			services.Configure<KestrelServerOptions>(options =>
			{
				options.AllowSynchronousIO = true;
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			CurrentEnvironment = env;

			
			
			
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseForwardedHeaders(new ForwardedHeadersOptions
				{
					ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
				});
				//app.UseAuthentication();
			}
			app.UseHttpsRedirection();

			app.UseRouting();
			app.UseCors(MyAllowSpecificOrigins);
				

			app.UseAuthorization();
			
			app.UseGraphQL<AppSchema>();
			app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
			
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});


		}
	}
}
