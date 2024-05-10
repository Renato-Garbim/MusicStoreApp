using Microsoft.Extensions.DependencyInjection;
using MusicStore.Repositories.Interfaces;
using MusicStoreMVC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreIOC.Modules
{
    public class RepositoryModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IArtistaRepository, ArtistaRepositorio>();
            container.AddScoped<IGeneroRepository, GeneroRepositorio>();
            container.AddScoped<IMusicaRepository, MusicaRepositorio>();
            container.AddScoped<ICDRepository, CDRepositorio>();
            container.AddScoped<ICDArtistaRepository, CDArtistaRepositorio>();
        }
    }
}
