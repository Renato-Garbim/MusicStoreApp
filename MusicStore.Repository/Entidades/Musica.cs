using MusicStore.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repositories.Entidades
{
    public class Musica : EntityBase
    {
        public int Id { get; set; }
        public int ArtistaId { get; set; }
        public string titulo { get; set; }
        public decimal duracao { get; set; }

        public virtual Artista Artistas { get; set; }

    }
}
