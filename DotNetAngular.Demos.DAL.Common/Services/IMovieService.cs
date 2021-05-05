using DotNetAngular.Demos.DAL.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAngular.Demos.DAL.Common.Services
{
    public interface IMovieService<TEntity, TId> : ICRUDService<TEntity, TId> where TEntity : IDataModel<TId>
    {
        IEnumerable<TEntity> GetByYear(int year);
    }
}
