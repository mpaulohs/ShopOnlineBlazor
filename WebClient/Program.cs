using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using global::Shared.Models.Catalogs;
using global::Shared.Models.Documents;
using global::Shared.Services.Repository;
using WebClient;
WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//ToDo: clean builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/api/") });
// builder.Services.AddScoped(typeof(IRepository<DocumentSale<Guid>, Guid>), typeof(RepositoryBaseClient<DocumentSale<Guid>, Guid>));
builder.Services.AddScoped(typeof(IRepository<Product<Guid>, Guid>), typeof(RepositoryBaseClient<Product<Guid>, Guid>));
builder.Services.AddScoped(typeof(IRepository<DocumentSale<Guid>, Guid>), typeof(RepositoryBaseClient<DocumentSale<Guid>, Guid>));
builder.Services.AddOidcAuthentication(options =>
{
    // Configure your authentication provider options here.
    // For more information, see https://aka.ms/blazor-standalone-auth
    builder.Configuration.Bind("Local", options.ProviderOptions);
});
await builder.Build().RunAsync();