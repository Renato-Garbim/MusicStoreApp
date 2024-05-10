using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;
using MusicStore.EntityFrameworkMigrations;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Interfaces;

namespace MusicStoreMVC.Repositorio
{
    public class CDRepositorio : RepositoryBase<CD>, ICDRepository
    {
        public CDRepositorio(MusicStoreContext db) : base(db)
        {

        }
    }
}
