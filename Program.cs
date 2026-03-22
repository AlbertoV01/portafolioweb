using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortfolioW;
using PortfolioW.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// ESTA LÍNEA ES CLAVE: vincula el HTML con el código C#
builder.RootComponents.Add<App>("#app"); 
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();