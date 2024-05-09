using Microsoft.EntityFrameworkCore;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Entidades;

namespace MusicStoreMVC.Repositorio
{
    public class ArtistaRepositorio : RepositoryBase<Artista>
    {
        public ArtistaRepositorio(DbContext db) : base(db)
        {

        }
    }
}
