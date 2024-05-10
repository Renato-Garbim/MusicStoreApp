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
    public class CDArtistaService : ServiceBase<CDArtista>, ICDArtistaService
    {
        private readonly ICDArtistaRepository _CDArtistaRepository;
        
        public CDArtistaService(ICDArtistaRepository CDArtistaRepository) : base(CDArtistaRepository) 
        {
            _CDArtistaRepository = CDArtistaRepository;
        }

        public int ObterIdPor(int cdId)
        {
            return _CDArtistaRepository.ObterCDArtistaIdPor(cdId);
        }

        public int ObterArtistaIdPor(int cdId)
        {
            return _CDArtistaRepository.ObterArtistaIdPor(cdId);
        }
    }
}
