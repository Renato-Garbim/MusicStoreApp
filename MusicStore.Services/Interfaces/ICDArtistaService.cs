using MusicStore.Entities;
using MusicStore.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services.Interfaces
{
    public interface ICDArtistaService : IServiceBase<CDArtista>
    {
        int ObterIdPor(int cdId);
        int ObterArtistaIdPor(int cdId);
    }
}
