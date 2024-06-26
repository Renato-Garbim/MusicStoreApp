﻿using MusicStore.Entities.Base;

namespace MusicStore.Entities
{
    public class CD : EntityBase
    {
        public int Id { get; set; }
        public int GeneroId { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public virtual ICollection<CDArtista> ArtistasDoCD { get; set; }

        public virtual Genero Genero { get; set; }


    }
}
