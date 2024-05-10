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
    public class GeneroService : ServiceBase<Genero>, IGeneroService
    {
        private readonly IGeneroRepository _GeneroRepository;
        
        public GeneroService(IGeneroRepository GeneroRepository) : base(GeneroRepository) 
        {
            _GeneroRepository = GeneroRepository;
        }
    }
}
