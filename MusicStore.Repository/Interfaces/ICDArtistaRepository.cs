using MusicStore.Entities;
using MusicStoreMVC.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repositories.Interfaces
{
    public interface ICDArtistaRepository : IRepositoryBase<CDArtista>
    {
        int ObterCDArtistaIdPor(int cdId);
        int ObterArtistaIdPor(int cdId);
        int ObterCdIdPor(int artistaId);
    }
}
