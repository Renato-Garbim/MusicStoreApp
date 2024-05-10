using MusicStore.Entities;
using MusicStore.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services.Interfaces
{
    public interface ICDService : IServiceBase<CD>
    {
        int ObterCDIdPor(string titulo, int ano);
        IQueryable<CD> FiltrarCdPor(string tituloAlbum, string nomeMusica, int generoId, int artistaId);
    }
}
