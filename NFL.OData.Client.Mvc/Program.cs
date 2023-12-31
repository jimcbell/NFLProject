using NFL.OData.Client.Mvc.Adapters;
using NFL.OData.Client.Mvc.Models;
using System.Net.Http.Headers; // MediaTypeWithQualityHeaderValue

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string? host = builder.Configuration["ODataServerUrl"];
if (string.IsNullOrEmpty(host)) throw new Exception("ODataServerUrl is null or empty.");
builder.Services.AddHttpClient("ODataServer", c =>
{
    c.BaseAddress = new Uri(host);
    c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(
        "application/json", 1.0));
});
builder.Services.AddScoped<IODataAdapter, ODataAdapter>();
builder.Services.AddScoped<HomeIndexViewModel>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
