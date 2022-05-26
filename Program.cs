using Microsoft.EntityFrameworkCore;
using Platzi_ASP_NET_CORE.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
object value = builder.HasKey((object EscuelaContext) => new { Escuela.EntityOneKey, Platzi_ASP_NET_CORE.Models.EscuelaContext.EntityTwoKey });
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EscuelaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EfConnection")); 
});
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
    pattern: "{controller=Escuela}/{action=Index}/{id?}");

app.Run();
