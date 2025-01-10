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
        [Route("GuessItEasy/{guess}")]
            public string Easy(string guess)
            {
                return _guessItServices.GuessItEasy(guess);
            }

            [HttpGet]
        [Route("GuessItMedium/{guess}")]
            public string Medium(string guess)
            {
                return _guessItServices.GuessItMedium(guess);
            }

            [HttpGet]
        [Route("GuessItHard/{guess}")]
            public string Hard(string guess)
            {
                return _guessItServices.GuessItHard(guess);
            }
        

    }
}