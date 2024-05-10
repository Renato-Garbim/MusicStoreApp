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
    public class CDService : ServiceBase<CD>, ICDService
    {
        private readonly ICDRepository _CDRepository;
        private readonly ICDArtistaRepository _CDArtistaRepository;
        private readonly IMusicaRepository _MusicaRepository;

        public CDService(ICDRepository CDRepository, ICDArtistaRepository cDArtistaRepository, IMusicaRepository musicaRepository) : base(CDRepository)
        {
            _CDRepository = CDRepository;
            _CDArtistaRepository = cDArtistaRepository;
            _MusicaRepository = musicaRepository;
        }

        public int ObterCDIdPor(string titulo, int ano)
        {
            return _CDRepository.ObterCDIdPor(titulo, ano);
        }

        public IQueryable<CD> FiltrarCdPor(string tituloAlbum, string nomeMusica, int generoId, int artistaId)
        {
            var registros = _CDRepository.GetAllRecords();

            if (!string.IsNullOrEmpty(tituloAlbum))
            {
                registros = registros.Where(x => x.Titulo.Contains(tituloAlbum));
            }

            if(generoId != 0)
            {
                registros = registros.Where(x => x.GeneroId == generoId);
            }

            if (!string.IsNullOrEmpty(nomeMusica))
            {
                var musica = _MusicaRepository.ObterMusicaPor(nomeMusica);
                if(musica != null) {

                    //Todo: refatorar, necessario uma nova tabela chamada CdMusica para relacionar as musicas a um CD

                    var artista = musica.ArtistaId;
                    var album = _CDArtistaRepository.ObterCdIdPor(artista);

                    registros = registros.Where(x => x.Id == album);

                }

            }

            if(artistaId != 0)
            {
                var album = _CDArtistaRepository.ObterCdIdPor(artistaId);

                registros = registros.Where(x => x.Id == album);
            }

            if(generoId != 0)
            {
                registros = registros.Where(x => x.GeneroId == generoId);
            }


            return registros;
        }
    }
}
