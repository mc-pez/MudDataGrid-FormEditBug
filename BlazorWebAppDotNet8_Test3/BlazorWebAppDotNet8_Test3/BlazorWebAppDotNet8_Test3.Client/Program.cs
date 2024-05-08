using BlazorWebAppDotNet8_Test3.Client.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMudServices();
builder.Services.AddTransient<CounterViewModel>();

await builder.Build().RunAsync();
