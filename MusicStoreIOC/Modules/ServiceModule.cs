using Microsoft.Extensions.DependencyInjection;
using MusicStore.Services;
using MusicStore.Services.Interfaces;

namespace MusicStoreIOC.Modules
{
    public class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IArtistaService, ArtistaService>();
            container.AddScoped<IGeneroService, GeneroService>();
            container.AddScoped<IMusicaService, MusicaService>();
            container.AddScoped<ICDService, CDService>();
            container.AddScoped<ICDArtistaService, CDArtistaService>();

        }
    }
}
