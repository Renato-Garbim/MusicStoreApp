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
    }
}
