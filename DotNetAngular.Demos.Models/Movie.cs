using DotNetAngular.Demos.DAL.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAngular.Demos.Models
{
    public class Movie : IDataModel<int>
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public int? TimeLength { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool RatedMature { get; set; }
    }
}
