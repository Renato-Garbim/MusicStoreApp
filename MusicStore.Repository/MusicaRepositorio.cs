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
    }
}
