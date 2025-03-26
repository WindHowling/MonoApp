using Microsoft.EntityFrameworkCore;
using WebApp.Database;
using WebApp.Services.Interface;
using WebApp.Services;
using WebApp.Mapping;
using AutoMapper;
using Ninject;
using Ninject.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//EF DbContext 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<VehicleDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//Registracija Ninject kao DI container
builder.Host.UseServiceProviderFactory(new NinjectServiceProviderFactory());

builder.Host.ConfigureContainer<IKernel>(kernel =>
{
    //Dependency bindings
    kernel.Bind<IVehicleRepository>().To<VehicleRepository>().InTransientScope();
    kernel.Bind<IVehicleService>().To<VehicleService>().InTransientScope();

    kernel.Bind<IMapper>().ToMethod(ctx =>
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        return config.CreateMapper();
    }).InSingletonScope();
});

//MVC i Razor
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//Build
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=VehicleMakes}/{action=Index}/{id?}");

app.Run();
