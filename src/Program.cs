using Blazor.Services.ImageService;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddWebOptimizer(pipeline =>
{
    var assemblyConfiguration = typeof(Program).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>();
    pipeline.AddCssBundle("/css/bundle.css", sourceFiles: new string[] { "/wwwroot/css/*.css", "/wwwroot/Pages/*.css", "/wwwroot/Shared/*.css" }).UseContentRoot();
    pipeline.MinifyCssFiles("/css/bundle.css");
});
builder.Services.AddScoped<IImageService, ImageService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseWebOptimizer();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
