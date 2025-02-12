using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Online_Assessment.Shared.Services;
using Online_Assessment.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the Online_Assessment.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddSingleton<AdminService>();
builder.Services.AddSingleton<AdminQuestionService>();
await builder.Build().RunAsync();
