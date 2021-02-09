using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DailySpellsAPI.GraphQL.GraphQLSchema;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using DailySpellsAPI.GraphQL;
using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.GraphQL.Context;

namespace DailySpellsAPI
{
	public class Startup
	{
		readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
								  builder =>
								  {
									  builder.WithOrigins("*");
								  });
			});
			services.AddDbContext<ApplicationContext>();//(opt => opt.UseSqlServer(Configuration.GetConnectionString("sqlConString")));
			services.AddScoped<ICharacterRepository, CharacterRepository>();
			services.AddScoped<GraphQLSchema>();
			services.AddGraphQL()
					.AddSystemTextJson()
					.AddGraphTypes(typeof(GraphQLSchema), ServiceLifetime.Scoped);

			services.AddControllers();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();
			app.UseCors(MyAllowSpecificOrigins);

			app.UseAuthorization();
			app.UseGraphQL<GraphQLSchema>();
			app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});


		}
	}
}
