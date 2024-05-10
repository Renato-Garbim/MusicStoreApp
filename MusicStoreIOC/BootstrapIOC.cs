using Microsoft.Extensions.DependencyInjection;
using MusicStoreIOC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreIOC
{
    public class BootstrapIOC
    {
        public static void RegisterServices(IServiceCollection container)
        {
            RepositoryModule.SetModules(container);
            ServiceModule.SetModules(container);
        }
    }
}
