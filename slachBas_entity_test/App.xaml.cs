using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using slachBas_entity_test.Services.avatar;
using slachBas_entity_test.Services;

namespace slachBas_entity_test;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public IServiceProvider serviceProvider { get; }

    public App()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        serviceProvider = serviceCollection.BuildServiceProvider();
    }
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<SlachBasDbContext>();
        services.AddScoped<IAvatarService, AvatarService>();
        // Other service registrations
    }
}