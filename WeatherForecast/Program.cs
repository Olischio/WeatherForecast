using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WeatherForecast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Konfigurerer HTTP Client for å snakke med APIet
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast") });

await builder.Build().RunAsync();
