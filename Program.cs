// filepath: /home/tor/Descargas/cs13net9/cursoMicrosoft/TasksApp/Program.cs
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TasksApp;
using TasksApp.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<UserSession>();
builder.Services.AddSingleton<AttendanceService>();

await builder.Build().RunAsync();
