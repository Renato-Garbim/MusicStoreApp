using Microsoft.EntityFrameworkCore;
using MusicStore.Repositories.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.EntityFrameworkMigrations
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options)
        {

        }

        public DbSet<Artista> Artista { get; set; }
        public DbSet<CD> CD { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Musica> Musica { get; set; }
    }
}
