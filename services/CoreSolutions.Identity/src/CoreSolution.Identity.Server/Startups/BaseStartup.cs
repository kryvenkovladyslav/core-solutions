using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreSolution.Identity.Server
{
    public abstract class BaseStartup
    {
        public BaseStartup(IConfiguration configuration) => this.Configuration = configuration;

        public IConfiguration Configuration { get; private init; }

        public abstract void ConfigureServices(IServiceCollection services);

        public abstract void Configure(IApplicationBuilder app, IWebHostEnvironment env);
    }
}