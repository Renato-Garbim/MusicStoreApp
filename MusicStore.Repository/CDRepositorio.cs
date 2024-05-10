using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;
using MusicStore.EntityFrameworkMigrations;
using MusicStore.Repositories.Bases;
using MusicStore.Repositories.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MusicStoreMVC.Repositorio
{
    public class CDRepositorio : RepositoryBase<CD>, ICDRepository
    {
        public CDRepositorio(MusicStoreContext db) : base(db)
        {

        }

        public int ObterCDIdPor(string titulo, int ano)
        {
            var registro = Db.Set<CD>().Where(x => x.Titulo.Equals(titulo) && x.Ano == ano).FirstOrDefault();
            
            return registro == null ? 0 : registro.Id;
        }


    }
}
