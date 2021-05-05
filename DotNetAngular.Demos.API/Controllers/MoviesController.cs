using DotNetAngular.Demos.DAL.Common.Services;
using DotNetAngular.Demos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAngular.Demos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMovieService<Movie,int> _service;

        public MoviesController(IMovieService<Movie,int> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _service.Get();
        }
    }
}
