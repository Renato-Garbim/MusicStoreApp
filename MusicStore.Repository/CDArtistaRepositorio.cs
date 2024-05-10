using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;
using MusicStore.EntityFrameworkMigrations;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Interfaces;

namespace MusicStoreMVC.Repositorio
{
    public class CDArtistaRepositorio : RepositoryBase<CDArtista>, ICDArtistaRepository
    {
        public CDArtistaRepositorio(MusicStoreContext db) : base(db)
        {

        }

        public int ObterArtistaIdPor(int cdId)
        {
            var registro = Db.Set<CDArtista>().Where(x => x.CDId == cdId).FirstOrDefault();

            return registro == null ? 0 : registro.ArtistaId;
        }

        public int ObterCDArtistaIdPor(int cdId)
        {
            var registro = Db.Set<CDArtista>().Where(x => x.CDId == cdId).FirstOrDefault();

            return registro == null ? 0 : registro.Id;
        }

        public int ObterCdIdPor(int artistaId)
        {
            var registro = Db.Set<CDArtista>().Where(x => x.ArtistaId == artistaId).FirstOrDefault();

            return registro == null ? 0 : registro.CDId;
        }

    }
}
