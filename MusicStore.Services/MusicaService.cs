using MusicStore.Entities;
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
    public class MusicaService : ServiceBase<Musica>, IMusicaService
    {
        private readonly IMusicaRepository _MusicaRepository;
        
        public MusicaService(IMusicaRepository MusicaRepository) : base(MusicaRepository) 
        {
            _MusicaRepository = MusicaRepository;
        }
    }
}
