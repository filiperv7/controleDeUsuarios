using Autofac;
using Autofac.Extensions.DependencyInjection;
using ControleDeUsuario02.API.Mappings;
using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.InfraStructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
        .AddJsonOptions(options =>
            options.JsonSerializerOptions
                .ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IRepositoryDepartment, DepartmentRepository>();
builder.Services.AddScoped<IRepositoryUser, UserRepository>();
builder.Services.AddScoped<IRepositoryProject, ProjectRepository>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(ReembolsoDeslocamentoMapping));

string sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection");

// AutoFac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => {
    builder.Register(_ => {
        var options = new DbContextOptionsBuilder<Context>();
        options
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .EnableSensitiveDataLogging()
            .UseLazyLoadingProxies()
            .UseSqlServer(sqlServerConnection);

        return new Context(options.Options);
    }).InstancePerLifetimeScope();

    builder.RegisterType<ReembolsoDeslocamentoRepository>().As<IRepositoryReembolsoDeslocamento>().InstancePerLifetimeScope();
});

builder.Services.AddSwaggerGen();

/*builder.Services.AddDbContext<Context>(options =>  options
        .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
        .EnableSensitiveDataLogging()
        .UseLazyLoadingProxies()
        .UseSqlServer(sqlServerConnection));*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();