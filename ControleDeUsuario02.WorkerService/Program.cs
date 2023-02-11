using Autofac;
using Autofac.Extensions.DependencyInjection;
using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.InfraStructure.Repositories;
using ControleDeUsuario02.WorkerService;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService()
    .ConfigureLogging((ctx, config) => {
        config.ClearProviders();
        config.AddNLog(ctx.Configuration, new NLogProviderOptions() { LoggingConfigurationSectionName = "NLog" });
    })
    .ConfigureServices((ctx, services) => {
        /*services.AddDbContextPool<Context>((service, options) => {
            options.UseSqlServer(ctx.Configuration.GetConnectionString("DefaultConnection"));
            options.UseInternalServiceProvider(service);
        });
        services.AddEntityFrameworkSqlServer();

        services.AddTransient<IRepositoryReembolsoDeslocamento, ReembolsoDeslocamentoRepository>();*/
        services.AddHostedService<Worker>();
    })
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder => {
        builder
            .Register(_ => {
                var options = new DbContextOptionsBuilder<Context>();

                return new Context(options.Options);
            })
            .InstancePerLifetimeScope();

        builder
            .RegisterType<ReembolsoDeslocamentoRepository>()
            .As<IRepositoryReembolsoDeslocamento>()
            .InstancePerLifetimeScope();
    })
    .Build();

await host.RunAsync();
