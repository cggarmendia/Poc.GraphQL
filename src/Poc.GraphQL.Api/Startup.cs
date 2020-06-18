using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poc.GraphQL.Api.Data;
using Poc.GraphQL.Api.GraphQL;
using Poc.GraphQL.Api.GraphQL.Messaging;
using Poc.GraphQL.Api.Repositories;

namespace Poc.GraphQL.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _config = configuration;
            _env = env;
        }

        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IAGContext>(options =>
                options
                    .UseSqlServer(_config["ConnectionStrings:InternationalAirlinesGroup"]));


            services.AddScoped<AirlineRepository>();
            services.AddScoped<AirlineReviewRepository>();

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            services.AddScoped<IAGSchema>();
            services.AddSingleton<ReviewMessageService>();

            services
                .AddGraphQL(o => { o.ExposeExceptions = _env.IsDevelopment(); })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddUserContextBuilder(httpContext => httpContext.User)
                .AddDataLoader()
                .AddWebSockets();

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IAGContext dbContext)
        {
            app.UseCors(builder =>
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseWebSockets();
            app.UseGraphQLWebSockets<IAGSchema>("/graphql");
            app.UseGraphQL<IAGSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            dbContext.Seed();
        }
    }
}
