using AutoMapper;

using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Application.Services.Imp;
using Eldorado.TeamManager.DataAccess.Base;
using Eldorado.TeamManager.DataAccess.Repositories;
using Eldorado.TeamManager.Domain.Repositories;
using Eldorado.TeamManager.Web;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddHealthChecks();

#region AddEntityFrameworkNpgsql
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<TeamManagerDbContext>(options =>
              {
                  options.UseLazyLoadingProxies();
                  options.UseNpgsql(
                       builder.Configuration.GetConnectionString("DbEldoradoTeamManager"),
                       opts =>
                       {
                           opts.MigrationsAssembly(typeof(TeamManagerDbContext).Assembly.GetName().Name);
                           opts.SetPostgresVersion(new Version(9, 6));
                       });
              });
#endregion

#region Automapper
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperProfiler());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion

#region Repositories IoC
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
#endregion

#region Services IoC
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISkillService, SkillService>();
#endregion

var app = builder.Build();

app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


//a rota básica da aplicação vai ser o controller=Team e a ação Index.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Team}/{action=Index}/{id?}");

app.Run();
