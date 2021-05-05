using DotNetAngular.Demos.DAL.Common.Services;
using DotNetAngular.Demos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAngular.Demos.Service
{
    public class MovieServiceV2 : IMovieService<Movie, int>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> Get()
        {
            return new List<Movie>();
        }

        public Movie Get(int id)
        {
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
