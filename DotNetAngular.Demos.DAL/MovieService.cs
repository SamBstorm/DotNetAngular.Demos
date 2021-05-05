using DotNetAngular.Demos.DBDatas;
using DotNetAngular.Demos.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using DotNetAngular.Demos.DAL.Common.Services;

namespace DotNetAngular.Demos.Service
{
    public class MovieService : IMovieService<Movie,int>
    {
        public Movie Get(int id)
        {
            return DBContext.Movies.Where(m => m.Id == id).SingleOrDefault();
        }
        public IEnumerable<Movie> Get()
        {
            return DBContext.Movies;
        }

        public int Insert(Movie movie)
        {
            int idMax = (DBContext.Movies != null && DBContext.Movies.Count > 0 )?DBContext.Movies.Max(m => m.Id): 1;
            movie.Id = idMax;
            DBContext.Movies.Add(movie);
            return movie.Id;
        }

        public void Delete(int id)
        {
            Movie m = DBContext.Movies.Where(m => m.Id == id).SingleOrDefault();
            if(m != null)
            {
                DBContext.Movies.Remove(m);
            }
        }

        public void Update(int id, Movie movie)
        {
            Movie m = DBContext.Movies.Where(m => m.Id == id).SingleOrDefault();
            if (m != null)
            {
                m.Title = movie.Title;
                m.TimeLength = movie.TimeLength;
                m.ReleaseDate = movie.ReleaseDate;
                m.RatedMature = movie.RatedMature;
            }
        }

        public IEnumerable<Movie> GetByYear(int year)
        {
            return DBContext.Movies.Where(m => (m.ReleaseDate is null)? false : ((DateTime)m.ReleaseDate).Year == year);
        }
    }
}
