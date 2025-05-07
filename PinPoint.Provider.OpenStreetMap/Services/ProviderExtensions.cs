using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PinPoint.Core;
using PinPoint.Core.Models;
using Microsoft.Extensions.Options;
using PinPoint.Core.Services;


namespace PinPoint.Provider.OpenStreetMap.Services
{
    public static class ProviderExtensions
    {
        public static IServiceCollection AddEditorMapWidget(this IServiceCollection services, IConfiguration config)
        {
            //Bind config and register MapSettings
            services.Configure<MapSettings>(config.GetSection("MapSettings"));
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<MapSettings>>().Value);

            //Register & scope the provider service/implementation
            services.AddScoped<IMapProvider, OsmProvider>();

            //Get the MapSettings from appsettings and register the Map service
            var settings = config.GetSection("MapSettings").Get<MapSettings>();
            services.AddPinPointCore(settings);

            return services;
        }
    }
}
