using System;
using System.Collections.Generic;

namespace DotNetAngular.Demos.DBDatas
{
    public static class DBContext
    {
        public static List<Models.Movie> Movies = new List<Models.Movie>()
        {
            new Models.Movie(){ Id = 1, Title="Jurassic Park", RatedMature = false, ReleaseDate=new DateTime(1992,06,12), TimeLength = 132},
            new Models.Movie(){ Id = 2, Title="Matrix", RatedMature = false, ReleaseDate=new DateTime(1999,06,12), TimeLength = 124},
            new Models.Movie(){ Id = 3, Title="Interstellar", RatedMature = false, ReleaseDate=new DateTime(2016,08,14), TimeLength = 180},
            new Models.Movie(){ Id = 4, Title="SacredNurses", RatedMature = true, ReleaseDate=DateTime.Now, TimeLength = 30}
        };
    }
}
