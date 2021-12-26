using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ShopOnlinePWA.Client.Services;
using ShopOnlinePWA.Library;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace ShopOnlinePWA.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddHttpClient<IEntityService<DocumentSale, Guid>, EntityService<DocumentSale, Guid>>(client =>
            client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            await builder.Build().RunAsync();
        }
    }
}
