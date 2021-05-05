using DotNetAngular.Demos.DAL.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAngular.Demos.DAL.Common.Services
{
    public interface ICRUDService<TEntity, TId> where TEntity : IDataModel<TId>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
        TId Insert(TEntity entity);
        void Update(TId id, TEntity entity);
        void Delete(TId id);
    }
}
