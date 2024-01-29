using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Features;
using SupermarketWeb.Components;
using SupermarketWeb.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<HttpContextAccessor>();
builder.Services.AddScoped<CookieService>();
builder.Services.AddSingleton<GlobalService>();
builder.Services.AddSingleton<PathService>();

builder.Services.AddSingleton<S3Service>();


builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 6000000; // 6 Mo (ajustez selon vos besoins)
});

builder.Services.AddHttpClient("supermarket", client =>
{
    // Set the base address of your API
    client.BaseAddress = new Uri(builder.Configuration.GetSection("BaseUrl").Value);
    // Optionally, configure other HttpClient properties, such as timeout, headers, etc.
    // client.Timeout = TimeSpan.FromSeconds(30);
});

builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "X-CSRF-TOKEN";
});

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
//builder.Services.AddAuthorizationCore();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
