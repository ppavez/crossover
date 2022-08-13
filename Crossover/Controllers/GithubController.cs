using Crossover.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crossover.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        // GET: api/<GithubController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GithubController>/5
        [HttpGet]
        [Route("RepositoryFirstTen")]
        public object Get(int id)
        {
            return Ok(GithubRepository.RepositoryList(10));
        }
    }
}
