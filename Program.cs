using BlazorApp1;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.RootComponents.Test<Bob>("data-grid");
builder.RootComponents.Test<Test>("test-test");
builder.RootComponents.Test<Fred>("data-column");
builder.RootComponents.Test<SurveyPrompt>("survey-prompt");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

public static class Extensions
{
    public static void Test<T>(this RootComponentMappingCollection col, string s) where T : IComponent => col.RegisterForJavaScript<T>(s, "registerBlazorCustomElement2");
}