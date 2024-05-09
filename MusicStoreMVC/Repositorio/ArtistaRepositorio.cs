using Microsoft.EntityFrameworkCore;
using MusicStoreMVC.Entidades;

namespace MusicStoreMVC.Repositorio
{
    public class ArtistaRepositorio : RepositoryBase<Artista>
    {
        public ArtistaRepositorio(DbContext db) : base(db)
        {

        }
    }
}
