using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.MC_5EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.MC_5EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("GuessIt/{guess}")]
        
            public string GuessIt(string difficulty, int guess)
            {
                return _guessItServices.GuessIt(difficulty, guess);
            }
        

    }
}