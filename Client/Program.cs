using Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient(ServiceProvider => new HttpClient
{
    // BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
    BaseAddress = new Uri("https://localhost:5001/")
});


builder.Services.AddTransient(typeof(IRepository<DocumentSale, Guid>), typeof(RepositoryBaseClient<DocumentSale, Guid>));

builder.Services.AddOidcAuthentication(options =>
{
    // Configure your authentication provider options here.
    // For more information, see https://aka.ms/blazor-standalone-auth
    builder.Configuration.Bind("Local", options.ProviderOptions);
});

await builder.Build().RunAsync();
