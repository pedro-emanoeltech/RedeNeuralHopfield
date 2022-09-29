using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RedeNeuralHopfieldDomain.Interfaces.Repository;
using RedeNeuralHopfieldDomain.Interfaces.Services;
using RedeNeuralHopfieldDomain.Services;
using RedeNeuralHopfieldInfras.Service;
using System;


namespace RedeNeuralHopfield.Configuration
{
    public static class DependencyInjectionConfiguration
    {

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<FrmPrincipal>();
                services.AddScoped<IArquivoDadosRepository, ArquivoDadosRepository>();
                services.AddScoped<IProcessarArquivoServices, ProcessarArquivoServices>();
                services.AddScoped<IProcessarPesosServices, ProcessarPesosServices>();
                services.AddScoped<IAprendizagemServices, AprendizagemServices>();
            });


        }
        public static IServiceProvider hostservices()
        {
            var host = CreateHostBuilder().Build();
            var services = host.Services;
            return services;
        }
    }
}
