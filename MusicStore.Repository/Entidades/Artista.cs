﻿using MusicStore.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repositories.Entidades
{
    public class Artista : EntityBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Musica> Musicas { get; set; }

    }
}