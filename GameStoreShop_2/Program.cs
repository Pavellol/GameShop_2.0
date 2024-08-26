using GameStoreShop_2.Data;
using GameStoreShop_2.Models;

using Microsoft.EntityFrameworkCore;
using GameStoreShop_2.Repository;


var builder = WebApplication.CreateBuilder(args);

// получаем строку подключения из файла конфигурации
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<EFDbContext>(options => options.UseNpgsql(connection));
// Добавление репозитория в DI-контейнер

builder.Services.AddScoped<IGamesRepository, GamesRepository>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Время жизни сессии
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Cookie, необходимое для сессии
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

/*app.UseEndpoints(endpoints =>
{    
    endpoints.MapControllers();
});*/

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Games}/{action=Index}/{id?}");
});

app.Run();
