using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;
using MusicStore.EntityFrameworkMigrations;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Interfaces;

namespace MusicStoreMVC.Repositorio
{
    public class MusicaRepositorio : RepositoryBase<Musica>, IMusicaRepository
    {
        public MusicaRepositorio(MusicStoreContext db) : base(db)
        {

        }

        public IQueryable<Musica> ObterMusicasPor(int artistaId)
        {
            var registros = Db.Set<Musica>().Where(x => x.ArtistaId == artistaId);

            return registros;
        }

        public Musica ObterMusicaPor(string tituloMusica)
        {
            var registros = base.GetAllRecords();
            var musica = registros.FirstOrDefault(x => x.titulo == tituloMusica);

            return musica != null ? musica : null;
        }

    }
}
