using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;
using MusicStore.EntityFrameworkMigrations;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Interfaces;

namespace MusicStoreMVC.Repositorio
{
    public class GeneroRepositorio : RepositoryBase<Genero>, IGeneroRepository
    {
        public GeneroRepositorio(MusicStoreContext db) : base(db)
        {

        }
    }
}
