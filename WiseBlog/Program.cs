using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WiseBlog.Services;
using WiseBlog.Shared.Models;
using WiseBlog;
using WiseBlog.Components;
using MudBlazor.Services;
using Microsoft.AspNetCore.Components.Authorization;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();

//builder.Services.AddSingleton<IConfiguration>(new ConfigurationBuilder()
//    .SetBasePath(builder.HostEnvironment.BaseAddress)
//    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//    .Build());

Secrets secrets = new Secrets();

var supabaseOptions = new Supabase.SupabaseOptions
{
    AutoRefreshToken = true,
};
var supabaseUrl = secrets.GetSUPABASEURL();
var supabaseKey = secrets.GetSUPABASEKEY();
var supabaseClient = new Supabase.Client(supabaseUrl, supabaseKey, supabaseOptions);

builder.Services.AddSingleton(supabaseClient);
//builder.Services.AddSingleton<MongoDBServices>();
builder.Services.AddSingleton<SupabaseService>();
builder.Services.AddSingleton<UserContext>();
builder.Services.AddSingleton<AuthenticationStateProvider, AuthenticationProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
