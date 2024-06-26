﻿using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;
using MusicStore.EntityFrameworkMigrations;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Interfaces;

namespace MusicStoreMVC.Repositorio
{
    public class ArtistaRepositorio : RepositoryBase<Artista>, IArtistaRepository
    {
        public ArtistaRepositorio(MusicStoreContext db) : base(db)
        {

        }
    }
}
