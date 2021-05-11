using DotNetAngular.Demos.DAL.Common.Repositories;
using DotNetAngular.Demos.DAL.Common.Services;
using DotNetAngular.Demos.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
//using Tools.Connections.Database;

namespace DotNetAngular.Demos.DAL.Global.Repositories
{
    public class MoviesRepository : CommonRepository, IMovieService<Movie, int>
    {
        public MoviesRepository(IConfiguration config) : base(config,"MovieDB")
        {

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> Get()
        {
            throw new NotImplementedException();
        }

        public Movie Get(int id)
        {
            //Connection connection = new Connection(_factory,_connectionString);
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetByYear(int year)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
