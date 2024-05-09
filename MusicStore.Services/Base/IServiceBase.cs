using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services.Base
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        bool InsertRecord(TEntity objeto);
        bool UpdateRecord(TEntity objeto);
        IQueryable<TEntity> GetAllRecords();
        TEntity GetRecordById(int id);
        bool RemoveRecord(TEntity registro);
    }
}
