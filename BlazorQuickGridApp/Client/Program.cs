global using BlazorQuickGridApp.Client.Services.TeachersService;
global using BlazorQuickGridApp.Shared;
using BlazorQuickGridApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TeacherInterface, TeacherServices>();
await builder.Build().RunAsync();
