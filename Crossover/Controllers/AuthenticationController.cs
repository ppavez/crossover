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
    public class AuthenticationController : ControllerBase
    {

        // POST api/<AuthenticationController>
        [HttpPost]
        [Route("login")]
        public object Post()
        {
            try
            {
                return Ok(AuthenticationRepository.Login("polo.rock.12@gmail.com", "pp123456"));
            }
            catch(Exception ex)
            {
                return  ex;
            }
        }
    }
}
