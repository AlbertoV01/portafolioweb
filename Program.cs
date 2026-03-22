using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortfolioW; // Tu espacio de nombres
using PortfolioW.Components; // Donde está tu App.razor

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configuramos los componentes principales
// "head::after" permite que Blazor controle el <title> y los <meta> tags
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuramos el HttpClient (necesario en WebAssembly para hacer peticiones)
builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

await builder.Build().RunAsync();