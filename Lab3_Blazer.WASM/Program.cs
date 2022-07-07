using Lab3_Blazer.shared;
using Lab3_Blazer.WASM.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Blazer.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped < IServices < Product >, ProductServices > ();
            builder.Services.AddScoped<IServices<Category>,CategoryServices>();

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress =
                new Uri(sp.GetRequiredService<IConfiguration>()["IP"])
            }
                );

            await builder.Build().RunAsync();
        }
    }
}
