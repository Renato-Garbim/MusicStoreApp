using MusicStore.Repositories.Entidades;
using MusicStore.Repositories.Interfaces;
using MusicStore.Services.Base;
using MusicStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services
{
    public class ArtistaService : ServiceBase<Artista>, IArtistaService
    {
        private readonly IArtistaRepository _artistaRepository;
        
        public ArtistaService(IArtistaRepository artistaRepository) : base(artistaRepository) 
        {
            _artistaRepository = artistaRepository;
        }
    }
}
