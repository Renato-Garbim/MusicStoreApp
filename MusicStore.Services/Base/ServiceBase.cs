using MusicStoreMVC.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services.Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public bool InsertRecord(TEntity objeto)
        {

            return _repository.InsertRecord(objeto);
        }

        public bool UpdateRecord(TEntity objeto)
        {
            return _repository.UpdateRecord(objeto);
        }

        public IQueryable<TEntity> GetAllRecords()
        {
            return _repository.GetAllRecords();
        }

        public TEntity GetRecordById(int id)
        {
            return _repository.GetRecordById(id);
        }

        public bool RemoveRecord(TEntity registro)
        {
            return _repository.RemoveRecord(registro);
        }
    }
}
